using System;
using System.Collections.Generic;
using Model;
using System.Linq.Expressions;
using DAL;

namespace Service
{
    public class FAQService : IFAQService
    {
        private readonly IFAQRepository _faq;

        public FAQService(IFAQRepository faq)
        {
            _faq = faq;
        }

        public long Count()
        {
            return _faq.Count();
        }

        public FAQ GetSingle(string id)
        {
            return _faq.GetSingle(id);
        }

        public FAQ GetSingleBy(Expression<Func<FAQ, bool>> predicate)
        {
            return _faq.GetSingleBy(predicate);
        }

        public IEnumerable<FAQ> GetAll()
        {
            return _faq.GetAll();
        }

        public IEnumerable<FAQ> GetAllBy(Expression<Func<FAQ, bool>> predicate)
        {
            return _faq.GetAllBy(predicate);
        }

        public void Add(FAQ faq)
        {
            _faq.Add(faq);
        }

        public void Update(FAQ faq)
        {
            _faq.Update(faq);
        }

        public void Delete(FAQ faq)
        {
            _faq.Delete(faq);
        }

        public void DeleteBy(Expression<Func<FAQ, bool>> predicate)
        {
            _faq.DeleteBy(predicate);
        }
    }
}
