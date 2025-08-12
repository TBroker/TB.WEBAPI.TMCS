using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Text;
using TB.WEBAPI.TMCS.INFRASTRUCTURE.Configurations;

namespace TB.WEBAPI.TMCS.INFRASTRUCTURE.ApiClients
{
    public static class HttpClientFactory
    {
        public static void RegisterHttpClients(IServiceCollection services)
        {
            // อ่านการตั้งค่าจาก app settings
            services.Configure<ApiSettings>(options => { });

            services.AddHttpClient("ExternalApi", (serviceProvider, client) =>
            {
                // ดึงการตั้งค่าจาก DI Container
                var apiSettings = serviceProvider.GetRequiredService<IOptions<ApiSettings>>().Value;

                client.BaseAddress = new Uri(apiSettings.ServiceUrl);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{apiSettings.UserName}:{apiSettings.Password}")));
                client.DefaultRequestHeaders.Add("API_KEY", apiSettings.ApiKey);
            });
        }
    }
}