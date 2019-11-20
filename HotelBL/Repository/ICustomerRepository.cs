using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.Services
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
        int Create();
        int Edit();
        int Delete();
    }
}
