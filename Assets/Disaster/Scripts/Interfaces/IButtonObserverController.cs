using Disaster.Controllers;
using System.Collections.Generic;

/// <summary>
/// Disaster namespace
/// </summary>
namespace Disaster
{
    /// <summary>
    /// Button observer controller interface
    /// </summary>
    public interface IButtonObserverController : IController
    {
        /// <summary>
        /// Button controllers
        /// </summary>
        IReadOnlyList<ButtonControllerScript> ButtonControllers { get; }
    }
}
