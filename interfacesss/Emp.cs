using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesss
{  public interface IPrantabl
    {
        string Print();
    }
     public class Emp:IPrantabl
    {
        public int empid;
        public string name;
        public double salary;

        public Emp(int empid, string name, double salary)
        {

            this.empid = empid;
            this.name = name;
            this.salary = salary;
        }
        public string Print()
        {
            return$"emp id: {empid}  \nemp name: {name}  \nsalary: {salary}\n";
        }

        public class Student:IPrantabl
        {
            public int rollno;
            public string name;
            public double per;


            public Student(int rollno, string name, double per)
            {
                this.rollno = rollno;
                this.name = name;
                this.per = per; 
            }
            public string Print()
            {
                return $"student rollno: {rollno}  \nstudent name: {name}  \npercentage: {per}%";
            }
        }

    }
}
