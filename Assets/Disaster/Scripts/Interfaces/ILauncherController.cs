/// <summary>
/// Disaster namespace
/// </summary>
namespace Disaster
{
    /// <summary>
    /// Launcher controller interface
    /// </summary>
    public interface ILauncherController : IController
    {
        /// <summary>
        /// Jump height
        /// </summary>
        float JumpHeight { get; set; }
    }
}
