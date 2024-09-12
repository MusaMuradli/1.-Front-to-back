using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();

app.UseEndpoints(endpoints => endpoints.MapControllerRoute("default","{controller=home}/{action=index}/{id?}"));


app.Run();
