using NetArchTest.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Arch.Tests
{
    public abstract class BaseTests
    {
        protected const string DomainNameSpace = "Domain";
        protected const string ApplicationNameSpace = "Application";
        protected const string InfrastructureNameSpace = "Infrastructure";
        protected const string PresentationNameSpace = "Presentation";
        protected const string WebApiNameSpace = "WebApi";

        protected static Assembly PresentationAssembly = typeof(Presentation.Controllers.WeatherForecastController).Assembly;
        protected static Assembly InfrastuctureAssembly = typeof(Infrastructure.Weather.WeatherRepository).Assembly;
        protected static Assembly ApplicationAssembly = typeof(Application.Weather.Queries.GetWeatherForecastQuery).Assembly;
        protected static Assembly DomainAssembly = typeof(Domain.WeatherForecast).Assembly;

        protected static Types AllTypes = Types.InAssemblies(new List<Assembly> { PresentationAssembly, InfrastuctureAssembly, ApplicationAssembly, DomainAssembly });

    }
}
