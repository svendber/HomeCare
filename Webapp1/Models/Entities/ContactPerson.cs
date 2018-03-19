using Microsoft.Ajax.Utilities;

namespace Webapp1.Models.NewFolder1
{
    public class ContactPerson
    {
        private string email;
        private string name;
        private int phone;
        private string occupation;


        public ContactPerson(string email, string name, int phone, string occupation)
        {
            this.email = email;
            this.name = name;
            this.phone = phone;
            this.occupation = occupation; 
        }


    }
}