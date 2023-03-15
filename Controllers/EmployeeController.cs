
using Dot7.OData.Demo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;

namespace Dot7.OData.Demo.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly MyWorldDbContext _myWorldDbContext;
    
    public EmployeeController(MyWorldDbContext myWorldDbContext
    )
    {
        _myWorldDbContext = myWorldDbContext;
    }
    [EnableQuery]
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_myWorldDbContext.Employee.AsQueryable());
    }
    [EnableQuery]
    [HttpGet]
    [Route("addresses")]
    public IActionResult GetWithAddresses()
    {
        return Ok(_myWorldDbContext.
        Employee.AsQueryable());
    }
}