    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Student> students = new List<Student>();

            students.Add(new Student(1, "Nhi", 20));
            students.Add(new Student(2, "Hoa", 19));
            students.Add(new Student(3, "Phúc", 21));
            students.Add(new Student(4, "Uyên", 18));
            students.Add(new Student(5, "Trường", 92));
            students.Add(new Student(6, "Bảo", 28));
            students.Add(new Student(7, "An", 25));


            //Console.WriteLine(students);
            foreach (Student student in students)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Age: {2}", student.ID, student.Name, student.Age);
            }

            students.Sort((s1, s2) => s2.Name.CompareTo(s1.Name));
            Console.WriteLine("************ Danh sách sau khi giải quyết ************");

            foreach (Student student in students)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Age: {2}", student.ID, student.Name, student.Age);
            }
            Console.ReadLine();

        }
    }
