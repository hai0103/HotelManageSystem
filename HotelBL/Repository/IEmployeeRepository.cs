using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        int Create(Employee employee);
        int Edit();
        int Delete(Guid id);
    }
}
