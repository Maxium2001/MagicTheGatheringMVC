using MagicTheGatheringApi.Services;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSoapCore();
builder.Services.AddScoped<IMagicServices, MagicServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(endpoints => endpoints.UseSoapEndpoint<IMagicServices>
               ("/MagicTheGathering.wsdl", new SoapEncoderOptions(), SoapSerializer.XmlSerializer));
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
