using Core.DataAccess;
using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAssignmentDal : IEntityRepository<Assignment>
    {
        List<AssignmentDetailDto> GetAssginmentDetails();
    }
}
