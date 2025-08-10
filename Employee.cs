using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV02
{

    class EmployeeComparerName: IComparer
    {
        public int Compare(object? x,object?y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;
            return X.Name.CompareTo(Y.Name);
        }
    }

    internal class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public int CompareTo(Employee? other)
        {
            return this.Age.CompareTo(other.Age);
        }

        public override string ToString()
        {
            return $"Id : {Id},Name : {Name}, Age : {Age},Salary : {Salary}";
        }
    }
}
