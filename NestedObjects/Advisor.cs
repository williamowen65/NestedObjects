

namespace NestedObjects
{
    /// <summary>
    /// Represents a college advisor
    /// </summary>
    public class Advisor
    {
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public string? OfficeLocation { get; set; }
    }
}
