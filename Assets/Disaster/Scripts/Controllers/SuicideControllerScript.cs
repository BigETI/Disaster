using UnityEngine;

/// <summary>
/// Disaster controllers namespace
/// </summary>
namespace Disaster.Controllers
{
    /// <summary>
    /// Suicide controller script class
    /// </summary>
    public class SuicideControllerScript : MonoBehaviour, ISuicideController
    {
        /// <summary>
        /// Destroy myself
        /// </summary>
        public void DestroyMyself()
        {
            Destroy(gameObject);
        }
    }
}
