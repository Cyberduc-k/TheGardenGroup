using System;

namespace Model
{
    public class Customer : User
    {
        public string Company { get; set; }
        public string Occupation { get; set; }
        public int Tickets { get; set; }

        public Customer(string firstName, string lastName, DateTime birthDate, string email, string password, string company, string occupation)
            : base(firstName, lastName, birthDate, email, password)
        {
            Company = company;
            Occupation = occupation;
            Tickets = 0;
        }
    }
}
