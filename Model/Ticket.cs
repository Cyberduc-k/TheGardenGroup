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
        [BsonIgnore]
        public User Client { get; set; }
        public string ClientId { get; set; }
        [BsonIgnore]
        public User Handler { get; set; }
        public string HandlerId { get; set; }
        public DateTime DateOfIssueing { get; set; }
        public DateTime DateOfSolving { get; set; }
        public bool Solved { get; set; }
        public string Review { get; set; }
        public byte ReviewScore { get; set; }

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
            ClientId = client.Id;
            DateOfIssueing = dateOfIssueing;
            Solved = false;
        }

        //A full ticket
        public Ticket(string id, string subject, Category category, Priority priority, 
                        int daysToSolve, string description, User client, User handler, string solution, 
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
            ClientId = client.Id;
            Handler = handler;
            HandlerId = handler.Id;
            DateOfIssueing = dateOfIssueing;
            DateOfSolving = dateOfSolving;
            Solved = solved;
        }
    }   
}