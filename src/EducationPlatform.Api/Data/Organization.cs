namespace EducationPlatform.Api.Data;

/// <summary>
/// Represents an organization using the education platform.
/// This entity alone does not implement tenant isolation or access control.
/// </summary>
public sealed class Organization
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public required string Name { get; set; }

    public string? ExternalReference { get; set; }

    public DateTimeOffset CreatedAtUtc { get; set; } = DateTimeOffset.UtcNow;
}
