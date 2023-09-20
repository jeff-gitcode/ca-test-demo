using Microsoft.AspNetCore.Mvc;
using NetArchTest.Rules;

namespace Arch.Tests;

public class PresentationTests: BaseTests
{
    [Fact]
    public void Presentation_Controllers_ShouldOnlyResideInPresentation()
    {
        AllTypes.That().Inherit(typeof(ControllerBase))
            .Should().ResideInNamespaceStartingWith(PresentationNameSpace)
            .AssertIsSuccessful();
    }

    [Fact]
    public void Presentation_Controllers_ShouldInheritFromControllerBase()
    {
        Types.InAssembly(PresentationAssembly)
            .That().HaveNameEndingWith("Controller")
            .Should().Inherit(typeof(ControllerBase))
            .AssertIsSuccessful();
    }

    [Fact]
    public void Presentation_Controllers_ShouldEndWithController()
    {
        AllTypes.That().Inherit(typeof(ControllerBase))
            .Should().HaveNameEndingWith("Controller")
            .AssertIsSuccessful();
    }
}
