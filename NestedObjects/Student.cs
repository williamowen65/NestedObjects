
namespace NestedObjects
{
    /// <summary>
    /// Represents a individual college student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The legal first name of the student
        /// </summary>
        public required string FirstName { get; set; }

        /// <summary>
        /// The legal last name of the student
        /// </summary> 
        public required string LastName { get; set; }

        /// <summary>
        /// The Date of Birth of the student
        /// </summary>
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// The assigned school email address
        /// </summary>
        public required string SchoolEmail { get; set; }

        /// <summary>
        /// The phone number (Format?)
        /// </summary>
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// The student's Advisor
        /// </summary>
        public Advisor AssignedAdvisor { get; set; }
    }
}
