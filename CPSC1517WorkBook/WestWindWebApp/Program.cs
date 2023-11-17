//***************************************************************
// Required namespaces
using Microsoft.EntityFrameworkCore;
using WestWindSystem;
using WestWindWebApp.Data;
//***************************************************************

var builder = WebApplication.CreateBuilder(args);

<<<<<<< HEAD
builder.Services.WwBackEndDependencies(options =>
    options.UseSqlServer());

=======
>>>>>>> parent of d9c3778 (The most important changes include adding namespace references to BackEndExtensions.cs file, registering CategoryServices using AddTransient method in BackEndExtensions.cs file, and adding a new menu item to NavMenu.razor file.)
//***************************************************************
// Add our services to the web application container
// NOTE: the method calls in the BackEndExtensions class could be
// placed in here, but, then the web app would be responsible for
// additional configuration steps that would then be moved
// outside of our system assembly (i.e. more work for someone to 
// implement in the application). Utilizing the BackEndExtensions
// class allows for all the config work to be kept inside the 
// system library, and minimal work to be done here to use the 
// system.

// Register a factory and configure the options
//builder.Services.WwBackEndDependencies(options =>
//	options.UseSqlServer("Server=.;Database=WestWind;TrustServerCertificate=True;Trusted_Connection=true;MultipleActiveResultSets=true"));

// Having the connection string in here is difficult to manage,
// move to the appsettings.json file
var connectionString = builder.Configuration.GetConnectionString("WWDB");
<<<<<<< HEAD
builder.Services.WwBackEndDependencies(
    options => options.UseSqlServer(connectionString));
=======
builder.Services.WwBackEndDependencies(options =>
    options.UseSqlServer(connectionString));
>>>>>>> parent of d9c3778 (The most important changes include adding namespace references to BackEndExtensions.cs file, registering CategoryServices using AddTransient method in BackEndExtensions.cs file, and adding a new menu item to NavMenu.razor file.)
//***************************************************************

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
