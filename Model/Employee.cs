using System;

namespace Model
{
    public class Employee : User
    {
        public Category Category { get; set; }
        public int ReviewScore { get; set; }
        public int TicketsProcessed { get; set; }
        public int TicketsSucceeded { get; set; }
        public int TicketsFailed { get; set; }

        public Employee(string firstName, string lastName, DateTime birthDate, string email, string password, Category category)
            : base(firstName, lastName, birthDate, email, password)
        {
            Category = category;
            ReviewScore = 0;
            TicketsProcessed = 0;
            TicketsSucceeded = 0;
            TicketsFailed = 0;
        }
    }
}
