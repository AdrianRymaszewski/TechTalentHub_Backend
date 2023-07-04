
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechTalentHub.API.Data;
using TechTalentHub.API.Models;
using TechTalentHub.API.Models.CurriculumVitae;
using TechTalentHub.API.Models.CurriculumVitae.DTO;
using TechTalentHub.API.Models.TechTalentHubUser;

namespace TechTalentHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurriculumVitaeController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CurriculumVitaeController(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        [HttpPost]
        [Route("create")]
        [Authorize]
        public async Task<ActionResult> CreateCurriculumVitae([FromBody] CreateNewCVDTO createNewCVDTO)
        {
            var newCurriculumVitae = _mapper.Map<CurriculumVitae>(createNewCVDTO);

            await _uow.CurriculumVitaeRepo.InsertAsync(newCurriculumVitae);
            await _uow.SaveChangesAsync();

            return CreatedAtAction(nameof(CreateCurriculumVitae), new { CvId = newCurriculumVitae.Id }, newCurriculumVitae);
        }

/*        [HttpGet]
        public async Task<IEnumerable<JobOffer>> GetAll()
        {
            return await _uow.JobOfferRepo.GetAsync();
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<JobOffer> GetById(int id)
        {
            return await _uow.JobOfferRepo.GetByIdAsync(id);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task Delete(int id)
        {
            await _uow.JobOfferRepo.DeleteAsync(id);
            await _uow.SaveChangesAsync();
        }

        [HttpPut]
        public async Task Put(JobOffer jobOffer)
        {
            _uow.JobOfferRepo.Update(jobOffer);
            await _uow.SaveChangesAsync();
        }*/
    }
}
