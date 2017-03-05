using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Models;
using FisherInsuranceApi.Data;

[Route("api/claims/claim")]
public class ClaimsController : Controller
{
    public ClaimsController()
    {
      
    } 
    // POST api/claims/claim
    [HttpPost]

    public IActionResult Post([FromBody]Claim claim) 
    {
        return Ok();
    }

    // GET api/claims/claim/5

    [HttpGet("{id}")]

    public IActionResult Get(int id) 
    {
           return Ok(); 
    }

    [HttpGet]
    public IActionResult Claims()
    {
        return Ok();
    } 

    // PUT api/claims/claim/id

    [HttpPut("{id}")]

    public IActionResult Put(int id, [FromBody]Claim claim) 
    {
        return Ok();
    }

    // DELETE api/claims/id

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
   {
        
        return Ok();
   }

}