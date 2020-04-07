using System;
using System.Collections.Generic;

namespace Employees_ASP2.Domain
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        void Update(Employee employee);
        void Remove(Employee employee);
        Employee GetById(int employeeId);
        ICollection<Employee> GetByDepartment(int department);

    }
}
