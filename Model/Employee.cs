using System;

namespace Model
{
    public class Employee : User
    {
        public Category Expertise { get; set; }
        public int ReviewScore { get; set; }
        public int TicketsSolved { get; set; }

        public Employee(string firstName, string lastName, DateTime birthDate, string email, string password, Category expertise)
            : base(firstName, lastName, birthDate, email, password)
        {
            Expertise = expertise;
            ReviewScore = 0;
            TicketsSolved = 0;
        }
    }
}