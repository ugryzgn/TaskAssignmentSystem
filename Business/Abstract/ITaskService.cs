using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Abstract
{
    public interface ITaskService
    {
        List<Task> GetAll();
        Task GetById(int Id);
        Task GetByName(string name);
        Task GetByDifficulty(string difficulty);
        void Add(Task task);
        void Delete(Task task);
        void Update(Task task);
    }
}
