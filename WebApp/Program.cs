var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();

var app = builder.Build();

app.MapGet("/", async context =>
{
    var httpClientFactory = context.RequestServices.GetRequiredService<IHttpClientFactory>();
    var httpClient = httpClientFactory.CreateClient();
    httpClient.Timeout = TimeSpan.FromMilliseconds(500);

    await httpClient.GetAsync(app.Configuration["TEST_SERVER_URL"]);
});

app.Run();