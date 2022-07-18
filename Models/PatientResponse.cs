using System.ComponentModel.DataAnnotations;

namespace AppointmentDoctor.Models
{
    public class PatientResponse
    {
        [Required(ErrorMessage= "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter yout phone number")]
        public string DoctorType { get; set; }

        [Required(ErrorMessage = "Please, indicate the date of admission")]
        public string? Date { get; set; }
    }
}
