

namespace Core.Models
{
    public class Form
    {
        public int Id { get; set; }  // ID for identifying the inquiry
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsComplaint { get; set; }
        public string Description { get; set; }
    }
}
