using System.Runtime.InteropServices;

namespace SomerenModel
{
    public class Teacher
    {
        public int Id { get; set; }     // database id
        public string FirstName { get; set; }
        public int TelephoneNumber { get; set; }

        public string LastName { get; set; }
        
        public int Age { get; set; }
    }
}