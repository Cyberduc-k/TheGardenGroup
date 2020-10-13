using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace Model
{
    [BsonKnownTypes(typeof(Customer), typeof(Employee))]
    public class User : IEntityBase
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Alias { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Name
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public User() { }

        public User(string firstName, string lastName, DateTime birthDate, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Email = email;
            Password = password;
        }
    }
}
