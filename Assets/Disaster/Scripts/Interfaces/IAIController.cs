using System.Collections.Generic;

/// <summary>
/// Disaster namespace
/// </summary>
namespace Disaster
{
    /// <summary>
    /// AI controller
    /// </summary>
    public interface IAIController : IController
    {
        /// <summary>
        /// Visibility angle
        /// </summary>
        float VisibilityAngle { get; set; }

        /// <summary>
        /// Visibility distance
        /// </summary>
        float VisibilityDistance { get; set; }

        /// <summary>
        /// Detected player characters
        /// </summary>
        IReadOnlyDictionary<int, IPlayerCharacterDetectionState> DetectedPlayerCharacters { get; }

        /// <summary>
        /// Character controller
        /// </summary>
        ICharacterController CharacterController { get; }
    }
}
