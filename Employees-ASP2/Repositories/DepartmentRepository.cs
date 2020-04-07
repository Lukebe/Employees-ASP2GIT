using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employees_ASP;
using Employees_ASP2.Domain;
using NHibernate;
using NHibernate.Criterion;

namespace Employees_ASP2.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public void Add(Department department)
        {
            using (ISession session = NHibernateHelper.OpenSessionDepartment())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(department);
                transaction.Commit();
            }
        }

        public ICollection<Department> GetAllDepartments()
        {
            using (ISession session = NHibernateHelper.OpenSessionDepartment())
                return session.Query<Department>( ).ToList();
        }

        public Department GetByID(int Id)
        {
            using (ISession session = NHibernateHelper.OpenSessionDepartment())
                return session.Get<Department>(Id);
        }

        public void Remove(Department department)
        {
            using (ISession session = NHibernateHelper.OpenSessionDepartment())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(department);
                transaction.Commit();
            }
        }

        public void Update(Department department)
        {
            using (ISession session = NHibernateHelper.OpenSessionDepartment())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(department);
                transaction.Commit();
            }
        }
    }
}
