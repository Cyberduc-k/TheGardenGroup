using System;
using System.Collections.Generic;
using Model;
using System.Linq.Expressions;
using DAL;

namespace Service
{
    public class ErrorService : IErrorService
    {
        private readonly IErrorRepository _errors;

        public ErrorService(IErrorRepository errors)
        {
            _errors = errors;
        }

        public long Count()
        {
            return _errors.Count();
        }

        public Error GetSingle(string id)
        {
            return _errors.GetSingle(id);
        }

        public Error GetSingleBy(Expression<Func<Error, bool>> predicate)
        {
            return _errors.GetSingleBy(predicate);
        }

        public IEnumerable<Error> GetAll()
        {
            return _errors.GetAll();
        }

        public IEnumerable<Error> GetAllBy(Expression<Func<Error, bool>> predicate)
        {
            return _errors.GetAllBy(predicate);
        }

        public void Add(Error error)
        {
            _errors.Add(error);
        }

        public void Update(Error error)
        {
            _errors.Update(error);
        }

        public void Delete(Error error)
        {
            _errors.Delete(error);
        }

        public void DeleteBy(Expression<Func<Error, bool>> predicate)
        {
            _errors.DeleteBy(predicate);
        }
    }
}