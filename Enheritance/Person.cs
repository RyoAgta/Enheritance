using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enheritance
{
    public class Person
    {
        //Properti
        public string Name { get; set; }
        public int Age { get; set; }

        //fungsi
        public Person()
        {

        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;

            Console.WriteLine(" Nama saya {0}, dan umur saya {1}, tahun\n", Name, Age);
            Console.WriteLine();
        }
        public void InfoPerson()
        {
            Console.WriteLine(" Nama saya {0}, dan umur saya {1}, tahun\n", Name, Age);
            Console.WriteLine();
        }
    }
    //Class turunan
    public class Karyawan : Person
    {
        //Properti
        public int KaryawanID { get; set; }
        public string Subject { get; set; }

        //Overide Method 
        public Karyawan()
        {

        }

        public Karyawan(string Subject)
        {
            this.Subject = Subject;
            Console.WriteLine("Saya disini sebagai {0}", this.Subject);
            Console.WriteLine();
        }
        public void InfoKaryawan()
        {
            Console.WriteLine("ID Karyawan : {0} \nNama Karyawan : {1}", KaryawanID, Subject);
            Console.WriteLine();
        }

    }
}
