using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentApplicationDemo.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Email Address")]
        public string Email { get; set; }

        [DisplayName("Full Name")]
        public string FullName => $"{FirstName} {LastName}";

        [Required]
        [DisplayName("Student No")]
        public string StudentNo { get; set; }

        [Required]
        [DisplayName("Course Name")]
        public string CourseName { get; set; }

        [Required]
        [DisplayName("Country Name")]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [DisplayName("Registration Date")]
        public DateTime RegistrationDate { get; set; }
    }
}
