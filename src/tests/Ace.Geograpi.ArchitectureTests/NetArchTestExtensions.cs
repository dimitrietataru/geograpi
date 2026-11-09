namespace Ace.Geograpi.ArchitectureTests;

internal static class NetArchTestExtensions
{
    public static void ShouldBeSuccessful(this NetArchTest.Rules.TestResult result)
    {
        result.FailingTypeNames.Should().BeNullOrEmpty();
        result.IsSuccessful.Should().BeTrue();
    }
}
