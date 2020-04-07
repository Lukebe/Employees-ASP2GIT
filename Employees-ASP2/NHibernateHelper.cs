using Employees_ASP2.Domain;
using NHibernate;
using NHibernate.Cfg;

namespace Employees_ASP
{
    public sealed class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactoryEmployee
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var configuration = new Configuration();
                    configuration.Configure();
                    configuration.AddAssembly(typeof(Employee).Assembly);
                    _sessionFactory = configuration.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        private static ISessionFactory SessionFactoryDepartment
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var configuration = new Configuration();
                    configuration.Configure();
                    configuration.AddAssembly(typeof(Department).Assembly);
                    _sessionFactory = configuration.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public static ISession OpenSessionEmployee()
        {
            return SessionFactoryEmployee.OpenSession();
        }
        public static ISession OpenSessionDepartment()
        {
            return SessionFactoryDepartment.OpenSession();
        }
    }
}