using UnityEngine;

/// <summary>
/// Disaster namespace
/// </summary>
namespace Disaster
{
    /// <summary>
    /// Transform and parent interface
    /// </summary>
    public interface ITransformAndOldParent
    {
        /// <summary>
        /// Transform
        /// </summary>
        Transform Transform { get; }

        /// <summary>
        /// Old parent transform
        /// </summary>
        Transform OldParent { get; }
    }
}
