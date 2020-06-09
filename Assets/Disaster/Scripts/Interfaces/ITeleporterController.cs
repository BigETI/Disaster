using UnityEngine;

/// <summary>
/// Disaster namespace
/// </summary>
namespace Disaster
{
    /// <summary>
    /// Tleporter controller interface
    /// </summary>
    public interface ITeleporterController : IController
    {
        /// <summary>
        /// Target transform
        /// </summary>
        Transform TargetTransform { get; set; }
    }
}
