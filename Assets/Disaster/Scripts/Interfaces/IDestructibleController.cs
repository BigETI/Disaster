using System;

/// <summary>
/// Disaster namespace
/// </summary>
namespace Disaster
{
    /// <summary>
    /// Destructible controller interface
    /// </summary>
    public interface IDestructibleController : IController
    {
        /// <summary>
        /// Health
        /// </summary>
        float Health { get; set; }

        /// <summary>
        /// On destroyed
        /// </summary>
        event Action OnDestroyed;
    }
}
