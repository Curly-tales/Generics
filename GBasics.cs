using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsss
{
    class GBasics <T>
    {
       public T ID { get; set; }
        public T Name { get; set; }
        public T Address { get; set; }
        public T Email {  get; set; }   

        public GBasics(T ID, T Name, T Address, T Email)
        {
            this.ID = ID;
            this.Name = Name;
            this.Address = Address;
            this.Email = Email;
            Console.WriteLine("ID: " +  this.ID);
            Console.WriteLine("Name: "+  this.Name);
            Console.WriteLine("Address: " + this.Address);
            Console.WriteLine("Email: " + this.Email);
        }

        public T Student()
        {

            Console.WriteLine("Enter ID: ");
            object Id = Console.ReadLine();
            return Id;


        }

        public void Student_Display()
        {

        }
    }
}
