using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.IdentityModel.Tokens;
using MovieReview.API;
using MovieReview.API.Services;
using MovieReview.API.Services.Interfaces;
using MovieReview.Database.Repositories;
using MovieReview.Database.Repositories.Interfaces;
using MovieReview.Database.Services;
using MovieReview.Database.Services.Interfaces;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var key = Encoding.ASCII.GetBytes(Settings.SecretKey);

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddSingleton<IUserService, UserService>();

builder.Services.AddSingleton<IActorRepository, ActorRepository>();
builder.Services.AddSingleton<IActorService, ActorService>();

builder.Services.AddSingleton<ITitleRepository, TitleRepository>();
builder.Services.AddSingleton<ITitleService, TitleService>();

builder.Services.AddSingleton<IReviewRepository, ReviewRepository>();
builder.Services.AddSingleton<IReviewService, ReviewService>();

builder.Services.AddSingleton<IDirectorRepository, DirectorRepository>();
builder.Services.AddSingleton<IDirectorService, DirectorService>();

builder.Services.AddSingleton<IScreenwriterRepository, ScreenwriterRepository>();
builder.Services.AddSingleton<IScreenwriterService, ScreenwriterService>();

builder.Services.AddSingleton<IActorTitleRepository, ActorTitleRepository>();
builder.Services.AddSingleton<IActorTitleService, ActorTitleService>();

builder.Services.AddSingleton<ITokenService, TokenService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseAuthentication();

app.UseRouting();

app.MapControllers();

app.Run();
