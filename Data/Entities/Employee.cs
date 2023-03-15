namespace Dot7.OData.Demo.Data.Entities;

public class Employee
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public decimal? Salary { get; set; }
    public string? JobRole { get; set; }
    public List<EmployeeAddresses> EmployeeAddresses { get; set; }
}
