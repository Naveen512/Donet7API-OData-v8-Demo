using Dot7.OData.Demo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace Dot7.OData.Demo.Controllers;

public class EmployeeODataController:ControllerBase
{
    private readonly MyWorldDbContext _myWorldDbContext;
    public EmployeeODataController(MyWorldDbContext myWorldDbContext)
    {
        _myWorldDbContext = myWorldDbContext;
    }

    [EnableQuery]
    public IActionResult Get()
    {
        return Ok(_myWorldDbContext.Employee.AsQueryable());
    }
}