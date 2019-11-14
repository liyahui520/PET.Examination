using System.ComponentModel.DataAnnotations;

namespace PET.Examination.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}