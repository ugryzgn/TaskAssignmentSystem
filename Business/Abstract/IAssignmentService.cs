using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Abstract
{
    public interface IAssignmentService
    {
        List<Assignment> GetAll();
        List<AssignmentDetailDto> GetAssignmentDetails();

        Assignment GetById(int Id);
        Assignment GetByEmployeeId(int employeeId);
        Assignment GetByTaskId(int taskId);

        void Add(Assignment assignment);
        void Delete(Assignment assignment);
        void Update(Assignment assignment);

    }
}
