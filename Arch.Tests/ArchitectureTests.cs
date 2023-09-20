using Application.Abstractions;

namespace Arch.Tests;

public class ArchitectureTests : BaseTests
{
    [Fact]
    public void Application_Should_Not_Reference_Infrastructure()
    {

        AllTypes.That().ResideInNamespace(ApplicationNameSpace)
            .ShouldNot().HaveDependencyOn(InfrastructureNameSpace)
            .AssertIsSuccessful();

    }

    [Fact]
    public void Application_Should_Not_Reference_Presentation()
    {

        AllTypes.That().ResideInNamespace(ApplicationNameSpace)
            .ShouldNot().HaveDependencyOn(PresentationNameSpace)
            .AssertIsSuccessful();

    }

    [Fact]
    public void Domain_Should_Not_Reference_Other()
    {
        var domainTypes = AllTypes.That().ResideInNamespace(DomainNameSpace);

        domainTypes.ShouldNot().HaveDependencyOn(InfrastructureNameSpace)
            .AssertIsSuccessful();


        domainTypes.ShouldNot().HaveDependencyOn(PresentationNameSpace)
            .AssertIsSuccessful();

        domainTypes.ShouldNot().HaveDependencyOn(ApplicationNameSpace)
            .AssertIsSuccessful();
    }

    [Fact]
    public void Repositories_Should_Only_In_Infrastructure()
    {
        AllTypes.That().HaveNameEndingWith("Repository")
        .Should().ResideInNamespaceStartingWith(InfrastructureNameSpace)
        .AssertIsSuccessful();

        AllTypes.That().HaveNameEndingWith("Repository")
            .And().AreClasses()
            .Should().ImplementInterface(typeof(IRepository<>))
            .AssertIsSuccessful();
    }
}
