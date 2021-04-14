using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TaskManager : ITaskService
    {
        ITaskDal _taskDal;

        public TaskManager(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }

        public void Add(Entity.Concrete.Task task)
        {
            _taskDal.Update(task);
        }

        public void Delete(Entity.Concrete.Task task)
        {
            _taskDal.Delete(task);
        }

        public List<Entity.Concrete.Task> GetAll()
        {
            return _taskDal.GetAll();
        }

        public Entity.Concrete.Task GetByDifficulty(string difficulty)
        {
            return _taskDal.Get(t => t.Difficulty == difficulty);
        }

        public Entity.Concrete.Task GetById(int Id)
        {
            return _taskDal.Get(t => t.Id == Id);
        }

        public Entity.Concrete.Task GetByName(string name)
        {
            return _taskDal.Get(t => t.Name == name);
        }

        public void Update(Entity.Concrete.Task task)
        {
            _taskDal.Update(task);
        }
    }
}
