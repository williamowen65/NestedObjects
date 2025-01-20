namespace NestedObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Advisor advisor = new Advisor()
            {
                FullName = "Dr. Smith",
                Email = "John@Gmail.com",
                OfficeLocation = "123 Main St."
            };

            Student student = new Student()
            {
                FirstName = "Jane",
                LastName = "Doe",
                DateOfBirth = new DateOnly(2000, 1, 1),
                SchoolEmail = "Jane@Gmail.com",
                PhoneNumber = "123-456-7890",
                AssignedAdvisor = advisor
            };


            Console.WriteLine($"{student.FirstName} {student.LastName} was born on {student.DateOfBirth}");
            Console.WriteLine($"Contact {student.FirstName} at {student.SchoolEmail} or {student.PhoneNumber}");
            Console.WriteLine($"Student's Advisor is {student.AssignedAdvisor.FullName}");
        }

    }
}


