using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Model
{
    public class Ticket : IEntityBase
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Subject { get; set; }
        public Category Category { get; set; }
        public Priority Priority { get; set; }
        public int DaysToSolve { get; set; }
        public string Description { get; set; }
        public string Solution { get; set; }
        public User Client { get; set; }
        public User Handler { get; set; }
        public DateTime DateOfIssueing { get; set; }
        public DateTime DateOfSolving { get; set; }
        public bool PassedOn { get; set; }
        public bool Solved { get; set; }

        public Ticket() { }

        //A ticket created by the client
        public Ticket(string subject, Category category, Priority priority, 
                        int daysToSolve, string description, User client, DateTime dateOfIssueing)
        {
            Subject = subject;
            Category = category;
            Priority = priority;
            DaysToSolve = daysToSolve;
            Description = description;
            Client = client;
            DateOfIssueing = dateOfIssueing;
            Solved = false;
        }

        //A full ticket
        public Ticket(string id, string subject, Category category, Priority priority, 
                        int daysToSolve, string description, string solution, User client, User handler, 
                        DateTime dateOfIssueing, DateTime dateOfSolving, bool solved)
        {
            Id = id;
            Subject = subject;
            Category = category;
            Priority = priority;
            DaysToSolve = daysToSolve;
            Description = description;
            Solution = solution;
            Client = client;
            Handler = handler;
            DateOfIssueing = dateOfIssueing;
            DateOfSolving = dateOfSolving;
            Solved = solved;
        }
    }   
}