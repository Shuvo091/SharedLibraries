using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace SharedLibrary.Common.Extensions;

/// <summary>
/// Swagger generation extension.
/// </summary>
public static class SwaggerGenExtensions
{
    /// <summary>
    /// Swagger service extension for builder.
    /// </summary>
    /// <param name="services"> builder.Service from program. </param>
    /// <returns>Returns the service collection. </returns>
    public static IServiceCollection AddSwaggerGenWithJwt(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "CohensionX API",
                Version = "v1",
            });

            // Define the JWT Bearer security scheme
            var jwtSecurityScheme = new OpenApiSecurityScheme
            {
                Scheme = "bearer",
                BearerFormat = "JWT",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.Http,
                Description = "JWT Authorization header using the Bearer scheme. Example: 'Bearer {token}'",
                Reference = new OpenApiReference
                {
                    Id = JwtBearerDefaults.AuthenticationScheme,
                    Type = ReferenceType.SecurityScheme,
                },
            };

            options.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);

            // Require JWT token for all endpoints
            options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    jwtSecurityScheme, Array.Empty<string>()
                },
            });
        });

        return services;
    }

    /// <summary>
    /// Swagger UI use.
    /// </summary>
    /// <param name="app"> app from program.cs. </param>
    public static void UseSwaggerUIWithJwt(this IApplicationBuilder app)
    {
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "CohensionX API v1");
        });
    }
}
