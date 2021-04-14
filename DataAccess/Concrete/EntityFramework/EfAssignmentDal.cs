using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Entity.Dtos;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAssignmentDal : EfEntityRepositoryBase<Assignment, TaskAssignmentContext>, IAssignmentDal
    {
        public List<AssignmentDetailDto> GetAssginmentDetails()
        {
            using (TaskAssignmentContext context = new TaskAssignmentContext())
            {
                var result = from a in context.Assignments
                             join e in context.Employees
                             on a.EmployeeId equals e.Id
                             join t in context.Tasks
                             on a.TaskId equals t.Id
                             select new AssignmentDetailDto
                             {
                                 Id = a.Id,
                                 Difficulty = t.Difficulty,
                                 FirstName = e.FirstName,
                                 LastName = e.LastName,
                                 TaskName = t.Name
                             };

                return result.ToList();
            }
        }
    }

}
