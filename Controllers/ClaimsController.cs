using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Models;
using FisherInsuranceApi.Data;

[Route("api/claims/claim")]
public class ClaimsController : Controller
{
    private IMemoryStore db;
    public ClaimsController(IMemoryStore repo)
    {
      db = repo;
    } 
    // POST api/claims/claim
    [HttpPost]

    public IActionResult Post([FromBody]Claim claim) 
    {
        return Ok(db.CreateClaim(claim));
    }

    // GET api/claims/claim/5

    [HttpGet("{id}")]

    public IActionResult Get(int id) 
    {
           return Ok(db.RetrieveClaim(id)); 
    }

    [HttpGet]
    public IActionResult Claims()
    {
        return Ok(db.RetrieveAllClaims);
    } 

    // PUT api/claims/claim/id

    [HttpPut("{id}")]

    public IActionResult Put(int id, [FromBody]Claim claim) 
    {
        return Ok(db.UpdateClaim(claim));
    }

    // DELETE api/claims/id

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
   {
        db.DeleteClaim(id);
        return Ok();
   }

}