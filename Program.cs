using System;
using System.Collections.Generic;
using System.Text;

namespace CovarianceDemo3_0
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }

    public class Manager : Employee
    {
        public int Incentives { get; set; }

        public Manager(int id, string name, int inc)
            : base(id, name)
        {
            Incentives = inc;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Manager> mgrList = new List<Manager>();

            mgrList.Add(new Manager(101, "Robert", 3899));
            mgrList.Add(new Manager(102, "Walt", 4000));
            mgrList.Add(new Manager(103, "Jason", 3899));
            mgrList.Add(new Manager(104, "Jasmin", 5000));
            mgrList.Add(new Manager(105, "Maria", 2000));
            mgrList.Add(new Manager(106, "Ruby", 3899));

            IEnumerable<Employee> emp = mgrList;

            foreach (var item in emp)
            {
                Console.WriteLine(item.ID + "\t" +item.Name);
            }

            Console.ReadKey();
        }
    }
}
