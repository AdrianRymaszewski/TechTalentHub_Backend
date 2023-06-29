using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TechTalentHub.API.Data;
using TechTalentHub.API.Models.TechTalentHubUser;
using TechTalentHub.API.Services.Contracts;

namespace TechTalentHub.API.Services
{
    public class AuthManager : IAuthManager
    {
        private readonly IMapper _mapper;
        private readonly UserManager<TechTalentHubUser> _userManager;
        private readonly IConfiguration _config;
        public AuthManager(IMapper mapper, UserManager<TechTalentHubUser> userManager, IConfiguration config)
        {
            this._mapper = mapper;
            this._userManager = userManager;
            this._config = config;
        }

        public async Task<AuthResponseDTO> Login(TechTalentHubLoginDTO techTalentHubLoginDTO)
        {
            var user = await _userManager.FindByEmailAsync(techTalentHubLoginDTO.Email);
            var isValidUser = await _userManager.CheckPasswordAsync(user, techTalentHubLoginDTO.Password);

            if (user == null ||  isValidUser==false)
            {
                return null;
            }

            var token = await GenerateToken(user);
            return new AuthResponseDTO
            {
                UserId = user.Id,
                Token = token
            };
        }

        public async Task<IEnumerable<IdentityError>> RegisterNewUser(TechTalentHubUserDTO techTalentHubUserDTO)
        {
            var newUser = _mapper.Map<TechTalentHubUser>(techTalentHubUserDTO);
            newUser.UserName = techTalentHubUserDTO.Email;

            var result = await _userManager.CreateAsync(newUser, techTalentHubUserDTO.Password);

            if(result.Succeeded) { await _userManager.AddToRoleAsync(newUser,"User");}

            return result.Errors;
        }

        private async Task<string> GenerateToken(TechTalentHubUser techTalentHubUser)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JwTSettings:Key"]));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var roles = await _userManager.GetRolesAsync(techTalentHubUser);

            var roleClaims = roles.Select(x=> new Claim(ClaimTypes.Role,x)).ToList();
            var userClaims = await _userManager.GetClaimsAsync(techTalentHubUser);

            var claims = new List<Claim> { 
                new Claim(JwtRegisteredClaimNames.Sub, techTalentHubUser.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email,techTalentHubUser.Email),
            }.Union(userClaims).Union(roleClaims);

            var token = new JwtSecurityToken(
                issuer: _config["JwTSettings:Issuer"],
                audience: _config["JwTSettings:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToInt32(_config["JwTSettings:DurationInMinutes"])),
                signingCredentials: credentials
                ); 

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
