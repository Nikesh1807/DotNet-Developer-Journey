using StudentManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace StudentManagementSystem.Services
{
    public class StudentServices
    {
        private List<Student> students = new List<Student>();
        private readonly string filePath = Path.Combine(
            Directory.GetCurrentDirectory(),
            "Data",
            "students.json"
        );

        public StudentServices()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);
            LoadStudents();
        }

        private void SaveStudents()
        {
            string json = JsonSerializer.Serialize(
                students,
                new JsonSerializerOptions { WriteIndented = true }
            );
            File.WriteAllText(filePath, json);
        }

        private void LoadStudents()
        {
            if (!File.Exists(filePath))
            {
                return;
            }

            try
            {
                string json = File.ReadAllText(filePath);

                if (string.IsNullOrWhiteSpace(json))
                {
                    return;
                }

                List<Student>? loadedStudents =
                    JsonSerializer.Deserialize<List<Student>>(json);

                if (loadedStudents != null)
                {
                    students = loadedStudents;
                }
            }
            catch (JsonException)
            {
                Console.WriteLine("Invalid JSON data found!");
                Console.WriteLine("Starting with an empty student list.");
            }
            catch (IOException)
            {
                Console.WriteLine("Unable to read student data file!");
            }
        }

        public void AddStudent()
        {
            Console.Write("\nEnter Student ID: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id) || id <= 0)
            {
                Console.Write("Invalid ID! Enter a positive number:");
            }
            if (students.Any(s => s.Id == id))
            {
                Console.WriteLine("Student ID Already exists:");
                return;
            }

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine() ?? "";
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Name cannot be empty. Enter Name: ");
                name = Console.ReadLine() ?? "";
            }

            Console.Write("Enter Student Age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.Write("Invalid age! Enter a Valid age:");
            }


            Console.Write("Enter Course: ");
            string course = Console.ReadLine() ?? "";
            while (string.IsNullOrWhiteSpace(course))
            {
                Console.Write("Course cannot be empty. Enter Course: ");
                course = Console.ReadLine() ?? "";
            }

            Console.Write("Enter Marks: ");
            double marks;
            while (!double.TryParse(Console.ReadLine(), out marks) || marks < 0 || marks > 100)
            {
                Console.Write("Enter Valid marks between 0 to 100: ");
            }


            Student student = new Student
            {
                Id = id,
                Name = name,
                Age = age,
                Course = course,
                Marks = marks
            };
            students.Add(student);
            SaveStudents();
            System.Console.WriteLine("\nStudent added successfully!");
        }

        public void ViewAllStudents()
        {
            if (students.Count == 0)
            {
                System.Console.WriteLine("\nNo students found!");
                return;
            }

            System.Console.WriteLine("\n==========student records============");
            foreach (Student student in students)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine($"ID: {student.Id}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Age: {student.Age}");
                Console.WriteLine($"Course: {student.Course}");
                Console.WriteLine($"Marks: {student.Marks}");
            }
        }

        public void SearchStudent()
        {
            Console.Write("Enter Student ID to search: ");
            int id;
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid ID!");
                return;
            }

            Student? student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                Console.WriteLine("Student not found!");
                return;
            }
            Console.WriteLine("\n===== STUDENT FOUND =====");
            Console.WriteLine($"ID: {student.Id}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"Course: {student.Course}");
            Console.WriteLine($"Marks: {student.Marks}");
        }


        public void UpdateStudents()
        {
            Console.Write("\nEnter Student ID to update: ");
            int id;

            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid ID!");
                return;
            }
            Student? student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                Console.WriteLine("Student not found!");
                return;
            }
            Console.WriteLine("\nEnter New Details:");

            Console.Write("Enter New Name: ");
            string name = Console.ReadLine() ?? "";

            if (!string.IsNullOrWhiteSpace(name))
            {
                student.Name = name;
            }
            Console.Write("Enter New Age: ");
            string ageInput = Console.ReadLine() ?? "";

            if (int.TryParse(ageInput, out int age) && age > 0)
            {
                student.Age = age;
            }

            Console.Write("Enter New Course: ");
            string course = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(course))
            {
                student.Course = course;
            }

            Console.Write("Enter New Marks: ");
            string marksInput = Console.ReadLine() ?? "";

            if (double.TryParse(marksInput, out Double marks) && marks >= 0 && marks <= 100)
            {
                student.Marks = marks;
            }
            SaveStudents();
            Console.WriteLine("\nStudent details updated successfully!");
        }


        public void DeleteStudents()
        {
            Console.Write("\nEnter Student ID to delete:");
            int id;
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                System.Console.WriteLine("invalid ID!");
                return;
            }
            Student? student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                System.Console.WriteLine("Students not found!");
                return;
            }

            students.Remove(student);
            SaveStudents();
            System.Console.WriteLine("\nStudents deleted successfully!");
        }


        public void SearchByCourse()
        {
            Console.Write("\nEnter Course Name:");
            string course = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(course))
            {
                Console.WriteLine("Course name cannot be empty!");
                return;
            }

            List<Student> result = students.Where(s => s.Course.Contains(course, StringComparison.OrdinalIgnoreCase)).ToList();

            if (result.Count == 0)
            {
                Console.WriteLine("No students found in this course!");
                return;
            }

            System.Console.WriteLine("\n======== Students By Course ========");


            foreach (Student student in result)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine($"ID: {student.Id}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Course: {student.Course}");
                Console.WriteLine($"Marks: {student.Marks}");
            }
        }


        public void CalculateAverageMarks()
        {
            if (students.Count == 0)
            {
                System.Console.WriteLine("\nNo student records available!");
                return;
            }
            double average = students.Average(s => s.Marks);
            System.Console.WriteLine($"\nAverage Marks: {average:F2}");
        }
    }
}