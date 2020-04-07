using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employees_ASP;
using Employees_ASP2.Domain;
using NHibernate;
using NHibernate.Criterion;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Employees_ASP2.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        [EnableCors(origins: "http://mywebclient.azurewebsites.net", headers: "*", methods: "*")]
        public void Add(Employee employee)
        {
            using (ISession session = NHibernateHelper.OpenSessionEmployee())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(employee);
                transaction.Commit();
            }
        }
        public void Update(Employee employee)
        {
            using (ISession session = NHibernateHelper.OpenSessionEmployee())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(employee);
                transaction.Commit();
            }
        }
        public void Remove(Employee employee)
        {
            using (ISession session = NHibernateHelper.OpenSessionEmployee())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(employee);
                transaction.Commit();
            }
        }
        public Employee GetById(int employeeId)
        {
            using (ISession session = NHibernateHelper.OpenSessionEmployee())
                return session.Get<Employee>(employeeId);
        }
        public ICollection<Employee> GetByDepartment(int department)
        {
            using (ISession session = NHibernateHelper.OpenSessionEmployee())
            {
                var products = session
                    .CreateCriteria(typeof(Employee))
                    .Add(Restrictions.Eq("Department", department))
                    .List<Employee>();
                return products;
            }
        }
    }
}
