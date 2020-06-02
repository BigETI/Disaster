/// <summary>
/// Disaster namespace
/// </summary>
namespace Disaster
{
    /// <summary>
    /// Interactable controller script interface
    /// </summary>
    public interface IInteractableController : IController
    {
        /// <summary>
        /// Interact
        /// </summary>
        void Interact();
    }
}
