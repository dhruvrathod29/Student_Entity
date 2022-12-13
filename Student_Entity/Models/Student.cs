using System.ComponentModel.DataAnnotations;

namespace Student_Entity.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required(ErrorMessage = "Enter Student Name ")]
        [StringLength(250, ErrorMessage = "Name must be less than or euqals to 250 charcter")]
        public string StudentName { get; set; } = null!;


        [Required(ErrorMessage = "Enter Student EnrollmentNo")]
        [StringLength(50, ErrorMessage = "EnrollmentNo must be less than or equals to 50 charcter")]
        public string EnrollmentNo { get; set; } = null!;


        [Required(ErrorMessage = "Enter Student Address")]
        [StringLength(250, ErrorMessage = "Address must be less than or equals to 250 charcter")]
        public string Address { get; set; } = null!;

        [Required(ErrorMessage = "Enter Student Email")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Enter ContactNo")]
        [StringLength(50, ErrorMessage = "ContactNo must be less than or euals to 50 charcter")]
        public string contactNo { get; set; } = null!;

    }
}
