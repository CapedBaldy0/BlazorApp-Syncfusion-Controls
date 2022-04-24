using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Upload_Button.Data;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

//Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjA0NzI4QDMyMzAyZTMxMmUzMElnd0owNjFveXpldXBBVW9aQ3BkR2VGQUZRK2doVFZPak92T2VzNm5MR1k9");
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjIzNzk4QDMyMzAyZTMxMmUzMFV1TTA0c01ISDBSanhpWTloQWxGcngyOSt6S2JGckRpUzk1cFhTaVJyV2c9");

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSyncfusionBlazor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
