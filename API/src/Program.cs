using DigiVisio2030.BL.Users;
using DigiVisio2030.BL.Cities;
using DigiVisio2030.DA.Users;
using DigiVisio2030.DA.Cities;
using DigiVisio2030.BL.AutoMapperProfiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationInsightsTelemetry();

ConfigureDI(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(builder =>
            {
                builder
                .AllowAnyHeader()
                .AllowAnyOrigin()
                .AllowAnyMethod();
            });

app.MapControllers();

app.Run();

static void ConfigureDI(WebApplicationBuilder builder)
{
    builder.Services.AddAutoMapper(GetAutoMapperProfiles());
    builder.Services.AddScoped<IUsersAdapter, UsersAdapter>();
    builder.Services.AddScoped<ICitiesAdapter, CitiesAdapter>();
    builder.Services.AddScoped<IUsersService, UsersService>();
    builder.Services.AddScoped<ICitiesService, CitiesService>();
}

static Type[] GetAutoMapperProfiles()
{
    return new[] { typeof(UserProfile), typeof(CityProfile) };
}