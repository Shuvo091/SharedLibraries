namespace SharedLibrary.Contracts.Usermanagement.Responses;

/// <summary>
/// Response after setting a user's professional status.
/// </summary>
public class SetProfessionalResponse
{
    /// <summary>
    /// Gets or sets unique identifier for the user.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether indicates if the user's role was updated.
    /// </summary>
    public bool RoleUpdated { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether indicates if the user is now a professional.
    /// </summary>
    public bool IsProfessional { get; set; }

    /// <summary>
    /// Gets or sets user's previous role.
    /// </summary>
    public string PreviousRole { get; set; } = default!;

    /// <summary>
    /// Gets or sets user's new role.
    /// </summary>
    public string NewRole { get; set; } = default!;

    /// <summary>
    /// Gets or sets date and time from which the new role is effective.
    /// </summary>
    public DateTime EffectiveFrom { get; set; } = DateTime.UtcNow;
}