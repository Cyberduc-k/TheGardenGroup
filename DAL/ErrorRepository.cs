using Model;

namespace DAL
{
    class ErrorRepository : EntityBaseRepository<Error>, IErrorRepository
    {
        public ErrorRepository() : base("Errors") { }
    }
}