using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class FAQService : IFAQService
    {

        public void Add(FAQ entity)
        {
            throw new NotImplementedException();
        }

        public long Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(FAQ entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteBy(Expression<Func<FAQ, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FAQ> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FAQ> GetAllBy(Expression<Func<FAQ, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public FAQ GetSingle(string id)
        {
            throw new NotImplementedException();
        }

        public FAQ GetSingleBy(Expression<Func<FAQ, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(FAQ entity)
        {
            throw new NotImplementedException();
        }
    }
}
