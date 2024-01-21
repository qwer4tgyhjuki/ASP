using HelloWeb;

var builder = WebApplication.CreateBuilder();
var app = builder.Build();
Company company = new Company
{
<<<<<<< Updated upstream
    cName = "TD",
    cDescription = "Description",
    cEmail = "ttd211s@outlol.com",
    cPhone = "+4172763821782",
    cWorkerks = 50
};
=======
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "FileRoute",
    pattern: "{controller=Home}/{action=Index}");
>>>>>>> Stashed changes

// Token Middlweare || 1g231
app.UseMiddleware<TokenMiddleware>();
app.MapGet("/", () => $"{company}");
app.MapGet("/randnum", () => $"\nRandom number (0 to 100): {company.RandomNumber()}");
app.Run();

