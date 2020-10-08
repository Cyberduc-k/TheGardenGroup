using Model;

namespace DAL
{
    public class ErrorRepository : EntityBaseRepository<Error>, IErrorRepository
    {
        public ErrorRepository() : base("Errors") { }
    }
}