using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();
            Console.ReadKey();
        }
    }
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()   //constructor
        {
            universities = new List<University>();
            students = new List<Student>();

            //add university
            universities.Add(new University { Id = 1, Nmae = "Graphic Era Deemed University" });
            universities.Add(new University { Id = 2, Nmae = "Graphic Era Hill University" });


            //add students
            students.Add(new Student { Id = 1, Name = "Shivam", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Rohan", Gender = "male", Age = 21, UniversityId = 2 });
            students.Add(new Student { Id = 3, Name = "Ram", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 4, Name = "Ravi", Gender = "male", Age = 21, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Geeta", Gender = "female", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 6, Name = "Sita", Gender = "female", Age = 21, UniversityId = 2 });
        }
        public void MaleStudents()
        {
            IEnumerable<Student> mailStudents = from Student in students where Student.Gender == "male" select Student;
            Console.WriteLine("Male student: ");

            foreach (Student student in mailStudents)
            {
                student.Print();
            }

        }
        public void FemaleStudents()
        {
            IEnumerable<Student> femailStudents = from Student in students where Student.Gender == "female" select Student;
            Console.WriteLine("female student: ");

            foreach (Student student in femailStudents)
            {
                student.Print();
            }
        }
    }


    class University
    {
        public int Id { get; set; }
        public string Nmae { get; set; }


        public void Print()
        {
            Console.WriteLine("University {0} with id is {1} ", Nmae, Id);
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public int UniversityId { get; set; }
        public void Print()
        {
            Console.WriteLine("Student {0} with Id {1},Gender {2}" +
                "nad Age {3} fro University with the Id {4}", Name
                , Id, Gender, Age, UniversityId);
        }

    }
}
