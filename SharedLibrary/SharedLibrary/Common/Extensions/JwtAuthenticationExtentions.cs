using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using SharedLibrary.Common.Options;

namespace SharedLibrary.Common.Extensions;

/// <summary>
/// Jwt Authentication Extension method.
/// </summary>
public static class JwtAuthenticationExtensions
{
    /// <summary>
    /// Jwt auth service registration.
    /// </summary>
    /// <param name="services"> builder.Services from program.cs. </param>
    /// <param name="config"> config from program.cs. </param>
    /// <returns> Service collection. </returns>
    public static IServiceCollection AddJwtAuthentication(this IServiceCollection services, IConfiguration config)
    {
        var jwtSection = config.GetSection("Jwt");
        services.Configure<JwtOptions>(jwtSection);

        var options = jwtSection.Get<JwtOptions>() !;
        var key = Encoding.UTF8.GetBytes(options.Secret);

        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(x =>
            {
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = options.Issuer,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    RoleClaimType = "role",
                    NameClaimType = "email",
                };
            });

        return services;
    }
}