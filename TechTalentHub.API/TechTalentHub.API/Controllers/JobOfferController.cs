using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechTalentHub.API.Data;
using TechTalentHub.API.Models;

namespace TechTalentHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobOfferController : ControllerBase
    {
        private readonly IUnitOfWork _uow;

        public JobOfferController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        [HttpPost]
        public async Task<ActionResult<JobOfferController>> AddJob(JobOffer jobOffer)
        {
            await _uow.JobOfferRepo.InsertAsync(jobOffer);
            await _uow.SaveChangesAsync();
            return CreatedAtAction(nameof(AddJob), new { id = jobOffer.Id }, jobOffer);
        }

        [HttpGet]
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
        }
    }
}
