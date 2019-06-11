using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with System.Object *****\n");
            //Person p1 = new Person();

            //Console.WriteLine("ToString: {0}", p1.ToString());
            //Console.WriteLine("Hash code: {0}", p1.GetHashCode());
            //Console.WriteLine("Type: {0}", p1.GetType());

            //Person p2 = p1;
            //object o = p2;
            //if(o.Equals(p1) && p2.Equals(o))
            //{
            //    Console.WriteLine("Same instance!");
            //}

            Person p1 = new Person("Homer", "Simpson", 50, "12345");
            Person p2 = new Person("Homer", "Simpson", 50, "12345");
            Console.WriteLine($"p1.ToString() = {p1.ToString()}");
            Console.WriteLine($"p2.ToString() = {p2.ToString()}");

            Console.WriteLine($"p1 = p2?: {p1.Equals(p2)}");

            Console.WriteLine($"Same hash codes?: {p1.GetHashCode() == p2.GetHashCode()}");
            Console.WriteLine();

            p2.Age = 45;
            Console.WriteLine($"p1.ToString() = {p1.ToString()}");
            Console.WriteLine($"p2.ToString() = {p2.ToString()}");

            Console.WriteLine($"p1 = p2?: {p1.Equals(p2)}");

            Console.WriteLine($"Same hash codes?: {p1.GetHashCode() == p2.GetHashCode()}");

            Person p3 = new Person("Sally", "Jones", 4, "43562");
            Person p4 = new Person("Sally", "Jones", 4, "43562");
            Console.WriteLine($"P3 and P4 have same state: {object.Equals(p3, p4)}");
            Console.WriteLine($"P3 and P4 are pointing to the same object: {object.ReferenceEquals(p3, p4)}");
            Console.ReadLine();
        }
    }
}
