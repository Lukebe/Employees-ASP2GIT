using Employees_ASP2.Domain;
using Employees_ASP2.Repositories;
using Xunit;

namespace Employees_ASP2
{
    public class Class1
    {
        [Fact]
        public void CanSaveEmployee()
        {
            Employee emp = new Employee {FirstName= "h", LastName = "w", Department = 3 };
            var employeeR = new EmployeeRepository();
            employeeR.Add(emp);
        }
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }
        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }
        int Add(int x, int y)
        {
            return x + y;
        }
    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(6)]
    public void MyFirstTheory(int value)
    {
        Assert.True(IsOdd(value));
    }

    bool IsOdd(int value)
    {
        return value % 2 == 1;
    }
    }
}