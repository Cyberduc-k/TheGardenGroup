using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;


namespace Model
{
    public class FAQ : IEntityBase
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public Category Category { get; set; }

        public FAQ(string question, string answer, Category category)
        {
            Question = question;
            Answer = answer;
            Category = category;
        }

        public FAQ()
        {
        }
    }
}
