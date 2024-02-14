var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/test", async () =>
{
    await Task.Delay(20);

    Console.WriteLine("test endpoint");
});

app.Run();