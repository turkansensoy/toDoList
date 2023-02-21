using toDoList.Context;
using toDoList.Data.Models;

namespace toDoList.Data.Services
{
    public class BeginDoneService
    {
        private readonly BaseDbContext _context;
        public BeginDoneService(BaseDbContext context)
        {
            _context = context;
        }
        public List<BeingDone> GetAll()
        {
            var result = _context.beingDone.ToList();
            return result;
        }
    }
}
