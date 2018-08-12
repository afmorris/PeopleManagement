namespace PeopleManagement.Models
{
    public class Person : BaseModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }


        public Person()
        {

        }
    }
}