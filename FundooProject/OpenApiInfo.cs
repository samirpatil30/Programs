// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OpenApiInfo.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooProject
{
    using Swashbuckle.AspNetCore.Swagger;
    internal class OpenApiInfo : Info
    {
        public string Title { get; set; }
        public string Version { get; set; }  
    }
}