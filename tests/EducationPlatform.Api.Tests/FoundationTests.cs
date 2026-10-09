using EducationPlatform.Api.Data;
using Xunit;

namespace EducationPlatform.Api.Tests;

public sealed class FoundationTests
{
    [Fact]
    public void Organization_HasUniqueIdByDefault()
    {
        var first = new Organization { Name = "Example School" };
        var second = new Organization { Name = "Another School" };

        Assert.NotEqual(Guid.Empty, first.Id);
        Assert.NotEqual(first.Id, second.Id);
    }

    [Fact]
    public void Organization_SetsCreationTimestampByDefault()
    {
        var before = DateTimeOffset.UtcNow;
        var organization = new Organization { Name = "Example School" };
        var after = DateTimeOffset.UtcNow;

        Assert.InRange(organization.CreatedAtUtc, before, after);
    }
}
