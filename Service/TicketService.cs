using System;
using System.Collections.Generic;
using Model;
using System.Linq.Expressions;
using DAL;

namespace Service
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _tickets;

        public TicketService(ITicketRepository tickets)
        {
            _tickets = tickets;
        }

        public long Count()
        {
            return _tickets.Count();
        }

        public Ticket GetSingle(string id)
        {
            return _tickets.GetSingle(id);
        }

        public Ticket GetSingleBy(Expression<Func<Ticket, bool>> predicate)
        {
            return _tickets.GetSingleBy(predicate);
        }

        public IEnumerable<Ticket> GetAll()
        {
            return _tickets.GetAll();
        }

        public IEnumerable<Ticket> GetAllBy(Expression<Func<Ticket, bool>> predicate)
        {
            return _tickets.GetAllBy(predicate);
        }

        public void Add(Ticket ticket)
        {
            _tickets.Add(ticket);
        }

        public void Update(Ticket ticket)
        {
            _tickets.Update(ticket);
        }

        public void Delete(Ticket ticket)
        {
            _tickets.Delete(ticket);
        }

        public void DeleteBy(Expression<Func<Ticket, bool>> predicate)
        {
            _tickets.DeleteBy(predicate);
        }
    }
}