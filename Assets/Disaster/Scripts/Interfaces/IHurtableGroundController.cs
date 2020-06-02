/// <summary>
/// Disaster namespace
/// </summary>
namespace Disaster
{
    /// <summary>
    /// Hurtable ground controller interface
    /// </summary>
    public interface IHurtableGroundController : IController
    {
        /// <summary>
        /// Damage per second
        /// </summary>
        float DamagePerSecond { get; set; }
    }
}
