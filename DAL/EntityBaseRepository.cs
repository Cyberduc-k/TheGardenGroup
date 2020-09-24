using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace DAL
{
    public class EntityBaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity: class, IEntityBase, new()
    {
        private IMongoDatabase mongoDatabase;
        private IMongoCollection<TEntity> collEntities;
        private string databaseName;

        public EntityBaseRepository() : base()
        {
            string connectionString = "mongodb+srv://Tymo:&u8q1aXUj0u5@cluster0.pehwk.azure.mongodb.net/TheGardenGroup?retryWrites=true&w=majority";
            MongoClient client = new MongoClient(connectionString);

            databaseName = MongoUrl.Create(connectionString).DatabaseName;
            mongoDatabase = client.GetDatabase(databaseName);
            collEntities = mongoDatabase.GetCollection<TEntity>(databaseName);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return collEntities.Find(_ => true).ToList();
        }

        public virtual long Count()
        {
            return collEntities.CountDocuments(new BsonDocument());
        }

        public TEntity GetSingle(string id)
        {
            return collEntities.Find<TEntity>(x => x.Id == id).FirstOrDefault();
        }

        public TEntity GetSingleBy(Expression<Func<TEntity, bool>> predicate)
        {
            return collEntities.AsQueryable<TEntity>()
                               .Where(predicate.Compile())
                               .FirstOrDefault();
        }

        public virtual IEnumerable<TEntity> GetAllBy(Expression<Func<TEntity, bool>> predicate)
        {
            return collEntities.AsQueryable<TEntity>()
                                .Where(predicate.Compile())
                                .ToList();
        }

        public virtual void Add(TEntity entity)
        {
            collEntities.InsertOne(entity);
        }

        public virtual void Update(TEntity entity)
        {
            FilterDefinition<TEntity> EntityIdFilter = Builders<TEntity>.Filter.Eq(x => x.Id, entity.Id);

            try
            {
                collEntities.ReplaceOne(EntityIdFilter, entity);
            }
            catch (MongoException ex)
            {
                string message = ex.Message;

                Console.WriteLine("Error: {0}", message);
            }
        }

        public virtual void Delete(TEntity entity)
        {
            collEntities.DeleteOne<TEntity>(x => x.Id == entity.Id);
        }

        public void DeleteBy(Expression<Func<TEntity, bool>> predicate)
        {
            collEntities.DeleteMany<TEntity>(predicate);
        }
    }
}
