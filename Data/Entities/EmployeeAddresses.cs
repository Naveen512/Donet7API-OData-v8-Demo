namespace Dot7.OData.Demo.Data.Entities;

public class EmployeeAddresses
{
    public int Id { get; set; }
    public string? HouseNumber { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
}

