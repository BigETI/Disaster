using Disaster.InputActions;
using UnityEngine;

/// <summary>
/// Disaster namespace
/// </summary>
namespace Disaster
{
    /// <summary>
    /// Player controller interface
    /// </summary>
    public interface IPlayerController : IController
    {
        /// <summary>
        /// View mode
        /// </summary>
        EViewMode ViewMode { get; set; }

        /// <summary>
        /// First person view virtual camera game object
        /// </summary>
        GameObject FirstPersonViewVirtualCameraGameObject { get; set; }

        /// <summary>
        /// Third person view virtual camera game object
        /// </summary>
        GameObject ThirdPersonViewVirtualCameraGameObject { get; set; }

        /// <summary>
        /// Character controller
        /// </summary>
        ICharacterController CharacterController { get; }

        /// <summary>
        /// Game input actions
        /// </summary>
        GameInputActions GameInputActions { get; }

        /// <summary>
        /// Character movement
        /// </summary>
        Vector2 CharacterMovement { get; }

        /// <summary>
        /// Delta character rotation
        /// </summary>
        Vector2 DeltaCharacterRotation { get; }
    }
}
