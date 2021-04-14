using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class AssignmentManager : IAssignmentService
    {
        IAssignmentDal _assignmentDal;
        

        public AssignmentManager(IAssignmentDal assignmentDal)
        {

            _assignmentDal = assignmentDal;
            
        }

        public void Add(Assignment assignment)
        {
           
            _assignmentDal.Add(assignment);
        }

        public void Delete(Assignment assignment)
        {
            _assignmentDal.Delete(assignment);
        }

        public List<Assignment> GetAll()
        {
            return _assignmentDal.GetAll();
        }

        public List<AssignmentDetailDto> GetAssignmentDetails()
        {
            return _assignmentDal.GetAssginmentDetails();
        }

        public Assignment GetByEmployeeId(int employeeId)
        {
            return _assignmentDal.Get(a => a.EmployeeId == employeeId);
        }

        public Assignment GetById(int Id)
        {
            return _assignmentDal.Get(a => a.Id == Id);
        }

        public Assignment GetByTaskId(int taskId)
        {
            return _assignmentDal.Get(a => a.TaskId == taskId);
        }

        public void Update(Assignment assignment)
        {
            _assignmentDal.Update(assignment);
        }
    }
}
