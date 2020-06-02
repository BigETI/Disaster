using Disaster.Objects;

/// <summary>
/// Disaster
/// </summary>
namespace Disaster
{
    /// <summary>
    /// Weapon pickup contorller interface
    /// </summary>
    public interface IWeaponPickupController : IController
    {
        /// <summary>
        /// Weapon
        /// </summary>
        WeaponObjectScript Weapon { get; set; }
    }
}
