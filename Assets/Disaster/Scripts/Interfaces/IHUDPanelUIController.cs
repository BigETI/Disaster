using TMPro;
using UnityEngine.UI;

/// <summary>
/// Disaster namespace
/// </summary>
namespace Disaster
{
    /// <summary>
    /// HUD panel UI controller interface
    /// </summary>
    public interface IHUDPanelUIController : IController
    {
        /// <summary>
        /// Health image
        /// </summary>
        Image HealthImage { get; set; }

        /// <summary>
        /// Weapon name text
        /// </summary>
        TextMeshProUGUI WeaponNameText { get; set; }

        /// <summary>
        /// Weapon ammo text
        /// </summary>
        TextMeshProUGUI WeaponAmmoText { get; set; }

        /// <summary>
        /// Weapon image
        /// </summary>
        Image WeaponImage { get; set; }
    }
}
