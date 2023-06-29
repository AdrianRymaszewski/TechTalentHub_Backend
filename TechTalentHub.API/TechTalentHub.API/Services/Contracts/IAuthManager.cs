using Microsoft.AspNetCore.Identity;
using TechTalentHub.API.Data;
using TechTalentHub.API.Models.TechTalentHubUser;

namespace TechTalentHub.API.Services.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> RegisterNewUser(TechTalentHubUserDTO techTalentHubUserDTO);
        Task<AuthResponseDTO> Login(TechTalentHubLoginDTO techTalentHubLoginDTO);
    }
}
