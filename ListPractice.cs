using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsss
{
    public class ListPractice
    {
        public string Emp_Name { get; set; }
        public int Emp_Id { get; set; }
        public string Emp_Type { get; set; }
        public string Emp_Feild { get; set; }

        public ListPractice()
        {
            Console.WriteLine("I AM FROM LIST PRACTICE.");
        
        }

        public void ListEmployee()
        {
            List<ListPractice> emp = new List<ListPractice>();


            ListPractice emp1 = new ListPractice();
            emp1.Emp_Id = 1;
            emp1.Emp_Name = "Namrata";
            emp1.Emp_Feild = "IT";
            emp1.Emp_Type = "permanent";
            emp.Add(emp1);

            ListPractice emp2 = new ListPractice();
            emp2.Emp_Id = 2;
            emp2.Emp_Name = "Mayur";
            emp2.Emp_Feild = null;
            emp2.Emp_Type = null;
            emp.Add(emp2);

            foreach (var item in emp)
            {
                Console.WriteLine("Employee ID: " + item.Emp_Id);
                Console.WriteLine("Employee Name: " + item.Emp_Name);
                Console.WriteLine("Employee Field: " + item.Emp_Feild);
                Console.WriteLine("Employee Type: " + item.Emp_Type);
            }

        }

        
}
}
