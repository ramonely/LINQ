using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            int min = nums.Min();
            int max = nums.Max();
            List<int> max2 = (from num in nums where num < 10000 select num).ToList();
            List<int> range = (from num in nums where num > 10 && num < 100 select num).ToList();
            List<int> range2 = (from num in nums where num >= 100000 && num <= 999999 select num).ToList();
            List<int> even = (from num in nums where num % 2 == 0 select num).ToList();

            List<Student> drink = students.Where(x => x.age >= 21).ToList();
            Student old = students.OrderBy(x => x.age).Last();
            Student young = students.OrderBy(x => x.age).First();
            Student oldest = students.Where(x => x.age < 25).OrderBy(x => x.age).Last();
            List<Student> over21 = students.Where(x => x.age > 21 && x.age % 2 == 0).ToList();
            List<Student> teens = students.Where(x => x.age >= 13 && x.age <= 19).ToList();
            List<Student> vowels = students.Where(x => x.name.StartsWith('A') || x.name.StartsWith('E') || x.name.StartsWith('I') || x.name.StartsWith('O') || x.name.StartsWith('U')).ToList();


        }
    }
        public class Student
        {
            public string name { get; set; }
            public int age { get; set; }

            public Student(string name, int age)
            {

            }
        }
    }

