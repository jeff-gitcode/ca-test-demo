using Application.Abstractions;
using System.Collections.Generic;

namespace Arch.Tests;
public class ApplicationTests : BaseTests
{
    [Fact]
    public void ApplicationLayer_CQRS_ContainsAllQueries()
    {
        AllTypes.That().HaveNameEndingWith("Query")
        .Should().ResideInNamespace(ApplicationNameSpace)
        .AssertIsSuccessful();

    }

    [Fact]
    public void ApplicationLayer_CQRS_ContainsAllCommands()
    {
        AllTypes.That().HaveNameEndingWith("Command")
        .Should().ResideInNamespace(ApplicationNameSpace)
        .AssertIsSuccessful();

    }

    [Fact]
    public void ApplicationLayer_CQRS_ContainsAllQueryHandlers()
    {
        AllTypes.That().HaveNameEndingWith("QueryHandler")
        .Should().ResideInNamespace(ApplicationNameSpace)
        .AssertIsSuccessful();
    }

    [Fact]
    public void ApplicationLayer_CQRS_ContainsAllCommandHandlers()
    {
        AllTypes.That().HaveNameEndingWith("CommandHandler")
        .Should().ResideInNamespace(ApplicationNameSpace)
        .AssertIsSuccessful();
    }
}
