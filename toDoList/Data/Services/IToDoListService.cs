using toDoList.Data.Models;

namespace toDoList.Data.Services
{
    public interface IToDoListService
    {
        public List<ToDoList> GetAll();
        public void Add(ToDoList beingDone);
        public void Update(ToDoList beingDone);
        public void Delete(ToDoList beingDone);
        public ToDoList GetById(int id);
    }
}
