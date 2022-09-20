using Microsoft.AspNetCore.Mvc;
using SimpleCrudBackEndNetCore.Application.Contracts;
using SimpleCrudBackEndNetCore.Crosscutting.DataTransferObject.ReadModel;
using SimpleCrudBackEndNetCore.Crosscutting.DataTransferObject.WriteModel;
using SimpleCrudBackEndNetCore.Crosscutting.models;

namespace SimpleCrudBackEndNetCore.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : ApiController
    {
        private readonly IPersonApplicationService _personApplicationService; 

        public PersonController(IPersonApplicationService personApplicationService) 
        {
            _personApplicationService = personApplicationService;
        }

        [HttpPut("CreatePerson")]
        public async Task<IActionResult> CreatePerson([FromBody] CreatePersonDTO dto) 
        {
            return CustomResponse(await _personApplicationService.CreatePerson(dto)); 
        }

        [HttpPut("UpdatePerson")] 
        public async Task<IActionResult> UpdatePerson([FromBody] UpdatePersonDTO dto)
        {
            return CustomResponse(await _personApplicationService.UpdatePerson(dto)); 
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson([FromRoute] Guid id)  
        {
            return CustomResponse(await _personApplicationService.DeletePerson(id));  
        }

        [HttpGet("GetAllPersons")]
        public async Task<GridDTO<PersonReadDTO>> GetAllPersons([FromQuery]  int pageIndex, [FromQuery]  int pageSize, [FromQuery] string? term)  
        {
            return await _personApplicationService.GetAllPersons(pageIndex, pageSize, term);  
        }

        [HttpGet("GetPersonById")] 
        public async Task<PersonReadDTO> GetPersonById([FromQuery] Guid id)  
        {
            return await _personApplicationService.GetPersonById(id);
        }
    }
}
