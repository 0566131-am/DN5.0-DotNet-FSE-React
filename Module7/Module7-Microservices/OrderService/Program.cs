using OrderService.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<OrderStore>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Config-based "service discovery" — BaseUrl comes from appsettings.json,
// so it can be swapped per environment or replaced with a real discovery client later.
builder.Services.AddHttpClient<ProductServiceClient>(client =>
{
    var baseUrl = builder.Configuration["ProductService:BaseUrl"];
    client.BaseAddress = new Uri(baseUrl!);
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/health", () => Results.Ok(new { status = "Healthy", service = "OrderService" }));

app.MapControllers();

app.Run();
