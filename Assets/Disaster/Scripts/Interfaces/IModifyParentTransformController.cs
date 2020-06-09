using System.Collections.Generic;

/// <summary>
/// Disaster namespace
/// </summary>
namespace Disaster
{
    /// <summary>
    /// Modify parent transform controller interface
    /// </summary>
    public interface IModifyParentTransformController : IController
    {
        /// <summary>
        /// Children transforms
        /// </summary>
        IReadOnlyDictionary<int, ITransformAndOldParent> ChildrenTransforms { get; }
    }
}
