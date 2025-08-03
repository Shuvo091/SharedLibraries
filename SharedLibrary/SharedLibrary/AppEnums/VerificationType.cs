using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.AppEnums
{
    /// <summary>
    /// Specifies the type of verification required.
    /// </summary>
    public enum VerificationType
    {
        /// <summary>
        /// Verification by ID document.
        /// </summary>
        [Display(Name = "id_document")]
        IdDocument,
    }
}