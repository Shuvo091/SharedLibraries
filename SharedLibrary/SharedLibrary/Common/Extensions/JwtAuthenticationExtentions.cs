using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
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
    /// <param name="configuration"> config from program.cs. </param>
    /// <returns> Service collection. </returns>
    public static IServiceCollection AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
    {
        var jwtSection = configuration.GetSection("Jwt");

        var options = jwtSection.Get<JwtOptions>()
            ?? throw new InvalidOperationException("JWT configuration section is missing or invalid.");

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

    /// <summary>
    /// Registers API key authentication services in the specified <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to which the authentication services will be added.</param>
    /// <returns>The same <see cref="IServiceCollection"/> instance so that additional calls can be chained.</returns>
    public static IServiceCollection AddCustomAuthorization(this IServiceCollection services)
    {
        // TODO: Add custom polices or authorization handlers.
        services.AddAuthorization(options =>
        {
            options.DefaultPolicy = new AuthorizationPolicyBuilder()
                .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                .RequireAuthenticatedUser()
                .Build();
        });

        return services;
    }

    /// <summary>
    /// Adds custom authentication and authorization services, including JWT authentication and a default authorization policy.
    /// </summary>
    /// <param name="services">The service collection to add authentication and authorization to.</param>
    /// <param name="configuration">The application configuration containing JWT settings.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddCustomAuth(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddJwtAuthentication(configuration);

        services.AddCustomAuthorization();

        services.AddControllers(options =>
        {
            options.Filters.Add(new AuthorizeFilter());
        });

        return services;
    }
}