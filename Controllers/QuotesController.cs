using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;

[Route("api/auto/quotes")]
public class QuotesController : Controller
{

    
    public QuotesController() 
    {  
        
    }
    // POST api/quotes
    [HttpPost]

    public IActionResult Post([FromBody]Quote quote) 
    {
        return Ok();
    }

    // GET api/quotes/5

    [HttpGet("{id}")]

    public IActionResult Get(int id) 
    {
           return Ok();
    }

    [HttpGet] 
    public IActionResult GetQuotes() 
    {  
        return Ok(); 
    }

    // PUT api/quotes/putid

    [HttpPut("{id}")]

    public IActionResult Put(int id, [FromBody]Quote quote) 
    {

        return Ok(); 
    }

    // DELETE api/quotes/delid

    [HttpDelete("{id}")]

    public IActionResult Delete(int id) 
    {
        
        return Ok();
    }


}
