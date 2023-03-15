using Dot7.OData.Demo.Data;
using Dot7.OData.Demo.Data.Entities;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
.AddOData(options =>
    options.Select().Filter().Count().OrderBy().Expand().SetMaxTop(100)
    .AddRouteComponents("odata",GetEdmModel()));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyWorldDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyWorldDbConnection"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


static IEdmModel GetEdmModel()
{
	ODataConventionModelBuilder modelBuilder = new ODataConventionModelBuilder();
	modelBuilder.EntitySet<Employee>("EmployeeOData");
	return modelBuilder.GetEdmModel();
}
