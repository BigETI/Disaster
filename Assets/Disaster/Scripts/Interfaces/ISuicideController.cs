/// <summary>
/// Disaster namespace
/// </summary>
namespace Disaster
{
    /// <summary>
    /// Suicide controller interface
    /// </summary>
    public interface ISuicideController : IController
    {
        /// <summary>
        /// Destroy myself
        /// </summary>
        void DestroyMyself();
    }
}
