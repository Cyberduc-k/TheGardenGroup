using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Model
{
    public class Error : IEntityBase
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Type { get; set; } //The type of error
        public DateTime Time { get; set; } //The time the error occured
        public string Message { get; set; } //What the message of the error was
        public string Trace { get; set; } //The trace of the error

        public Error() { }

        public Error(string type, DateTime time, string message, string trace)
        {
            Type = type;
            Time = time;
            Message = message;
            Trace = trace;
        }
    }
}