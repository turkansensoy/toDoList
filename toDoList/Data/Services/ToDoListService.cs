using toDoList.Context;
using toDoList.Data.Models;

namespace toDoList.Data.Services
{
    public class ToDoListService:IToDoListService
    {
        private readonly BaseDbContext _context;
        public ToDoListService(BaseDbContext context)
        {
            _context = context;
        }
        public List<ToDoList> GetAll()
        {
            var result = _context.toDoLists.ToList();
            return result;
        }
        public void Add(ToDoList beingDone)
        {
            _context.Add(beingDone);
            _context.SaveChanges();
        }
        public ToDoList GetById(int id)
        {
           ToDoList beingDone= _context.toDoLists.FirstOrDefault(_ => _.Id == id);
            return beingDone;
        }
        public void Update(ToDoList beingDone)
        {
            _context.toDoLists.Update(beingDone);
            _context.SaveChanges();
        }
        public void Delete(ToDoList beingDone)
        {
            _context.toDoLists.Remove(beingDone);
            _context.SaveChanges();
        }
    }
}
