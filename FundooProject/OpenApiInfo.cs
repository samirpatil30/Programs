using Swashbuckle.AspNetCore.Swagger;

namespace FundooProject
{
    internal class OpenApiInfo : Info
    {
        public string Title { get; set; }
        public string Version { get; set; }
    }
}