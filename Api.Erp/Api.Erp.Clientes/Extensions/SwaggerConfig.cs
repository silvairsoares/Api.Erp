//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;
//using System.Reflection;

//namespace Api.Erp.Clientes.Extensions
//{
//    public static class SwaggerConfig
//    {
//        internal static void ConfigureSwaggerDoc(this IServiceCollection services, string description)
//        {           

//            services.AddOpenApiDocument(config =>
//            {
//                config.Version = "v1";                
//                config.AllowReferencesWithProperties = true; //Habilita a geração de exemplos prara propriedades aninhadas
//                config.Title = "Documentação da API: " + Assembly.GetEntryAssembly().GetName().Name;
//                config.Description = description;
//            });
//        }

//        internal static void ConfigureSwaggerUI(this IApplicationBuilder app)
//        {
//            // Ativa o middleware para veicular o Swagger gerado como um terminal JSON.
//            app.UseOpenApi();

//            // Registra o gerador Swagger e os middlewares Swagger UI
//            app.UseSwaggerUi3(config => config.TransformToExternalPath = (internalUiRoute, request) =>
//            {
//                config.Path = "/swagger";
//                if (internalUiRoute.StartsWith("/") == true && internalUiRoute.StartsWith(request.PathBase) == false)
//                {
//                    return request.PathBase + internalUiRoute;
//                }
//                else
//                {
//                    return internalUiRoute;
//                }
//            });
//        }
//    }
//}