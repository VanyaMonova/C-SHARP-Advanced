using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private readonly List<Student> students;

        private Classroom()
        {
            this.students = new List<Student>();
        }
        public Classroom(int capacity)
            : this()
        {
            this.Capacity = capacity;
        }
        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return this.students.Count;
            }
        }

        public string RegisterStudent(Student student)
        {
            if (this.students.Count < this.Capacity)
            {
                this.students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            return "No seats in the classroom";
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student student = this.students.Where(s => s.FirstName == firstName).FirstOrDefault(s => s.LastName == lastName);

            if (student != null)
            {
                this.students.Remove(student);
                return $"Dismissed student {student.FirstName} {student.LastName}";
            }
            return "Student not found";
        }
        public string GetSubjectInfo(string subject)
        {
            StringBuilder sb = new StringBuilder();
            Student[] substudents = this.students.Where(s => s.Subject == subject).ToArray();

            if (substudents.Length > 0)
            {
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine($"Students:");
                foreach (var substudent in substudents)
                {
                    sb.AppendLine($"{substudent.FirstName} {substudent.LastName}");
                }
            }
            else
            {
                sb.AppendLine($"No students enrolled for the subject");
            }

            return sb.ToString().TrimEnd();
        }

        public int GetStudentsCount()
        {
            return students.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            Student student = this.students.Where(r => r.FirstName == firstName).FirstOrDefault(r => r.LastName == lastName);

            if (student != null)
            {
                return student;
            }
            return null;
        }
    }
}

