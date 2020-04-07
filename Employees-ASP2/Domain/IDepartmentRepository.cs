using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees_ASP2.Domain
{
    interface IDepartmentRepository
    {
        void Add(Department department);
        void Update(Department department);
        void Remove(Department department);
        Department GetByID(int ID);
        ICollection<Department> GetAllDepartments();
    }
}
