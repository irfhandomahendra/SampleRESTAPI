using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SampleRESTAPI.Dtos
{
    public class CourseForCreateDto : IValidatableObject
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public int Credits { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Title.Length >= 50 || !Title.StartsWith("Training"))
            {
                yield return new ValidationResult("Title harus diawali dengan " +
                    "kata 'Traning' " + "dan maksimal 50 karakter", new[] { "Title" });
            }
            if (Credits >= 10)
            {
                yield return new ValidationResult("Masimal credits adalah 10", 
                    new[] {"Credits"});
            }
        }
    }
}
