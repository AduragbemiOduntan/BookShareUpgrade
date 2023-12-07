

using BookShare.Api.Extension;
using BookShare.Application.MappingProfile;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureDbContext(builder.Configuration);
builder.Services.AddAutoMapper(typeof(MapInitializer));
builder.Services.ConfigureRepositoryBase();
builder.Services.ConfigureApplicationServices();
builder.Services.ConfigureIdentity();
builder.Services.ConfigureJWT(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
