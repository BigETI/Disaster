/// <summary>
/// Disaster namespace
/// </summary>
namespace Disaster
{
    /// <summary>
    /// ANimator functions wrapper controller interface
    /// </summary>
    public interface IAnimatorFunctionsWrapperController : IController
    {
        /// <summary>
        /// Set animator boolean false
        /// </summary>
        /// <param name="id">Parameter name hash</param>
        void SetAnimatorBooleanFalse(int id);

        /// <summary>
        /// Set animator boolean false
        /// </summary>
        /// <param name="name">Parameter name</param>
        void SetAnimatorBooleanFalse(string name);

        /// <summary>
        /// Set animator boolean true
        /// </summary>
        /// <param name="id">Parameter name hash</param>
        void SetAnimatorBooleanTrue(int id);

        /// <summary>
        /// Set animator boolean true
        /// </summary>
        /// <param name="name">Parameter name</param>
        void SetAnimatorBooleanTrue(string name);
    }
}
