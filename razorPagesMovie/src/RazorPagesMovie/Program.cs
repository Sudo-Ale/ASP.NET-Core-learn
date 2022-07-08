var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

//he following code sets the exception endpoint to /Error and enables HTTP Strict Transport Security Protocol (HSTS) when the app is not running in development mode
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//Redirects HTTP requests to HTTPS.
app.UseHttpsRedirection();

//Enables static files, such as HTML, CSS, images, and JavaScript to be served.
app.UseStaticFiles();

//Adds route matching to the middleware pipeline.
app.UseRouting();

//Authorizes a user to access secure resources. This app doesn't use authorization, therefore this line could be removed.
app.UseAuthorization();

//Configures endpoint routing for Razor Pages.
app.MapRazorPages();

//Runs the app.
app.Run();
