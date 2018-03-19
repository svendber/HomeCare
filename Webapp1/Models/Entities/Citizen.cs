using System.Collections;

namespace Webapp1.Models.NewFolder1
{
    public class Citizen
    {
        private string cpr;
        private string name;
        private string address;
        private string zipcode;
        private int phone;
        private string bloodtype;
        private string illnesses;
        private ArrayList assignment;
        private ArrayList comments;



        public Citizen(string cpr, string name, string address, string zipcode, int phone, string bloodtype,
            string illness, ArrayList assigenment, ArrayList comments)
        {
            this.cpr = cpr;
            this.name = name;
            this.address = address;
            this.zipcode = zipcode;
            this.phone = phone;
            this.bloodtype = bloodtype;
            this.illnesses = illness;
            this.assignment = assigenment;
            this.comments = comments;
        }

    }
}