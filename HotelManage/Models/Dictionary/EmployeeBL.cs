using Common.Entities;
using HotelManage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManage.Models.Dictionary
{
    public class EmployeeBL: IEmployeeRepository
    {
        public ApplicationDbContext context = new ApplicationDbContext();

        public IEnumerable<Employee> GetAll()
        {
            return context.Employees.ToList();
        }
        public Employee GetDetail(Guid id)
        {
            return context.Employees.SingleOrDefault(r => r.EmployeeId == id);
        }
        public int Create(Employee employee)
        {
            if (employee != null)
            {
                context.Employees.Add(employee);
                context.SaveChanges();
                return 1;
            }
            return 0;
        }

        public int Edit()
        {
            return 0;
        }
        public int Delete(Guid id)
        {
            if (id != null)
            {
                Employee e = context.Employees.FirstOrDefault(r => r.EmployeeId == id);
                context.Employees.Remove(e);
                context.SaveChanges();
                return 1;
            }
            return 0;
        }
    }
}