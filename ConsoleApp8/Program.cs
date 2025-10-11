using System;
using System.Xml.Serialization;

namespace xmlApp
{
    [Serializable]
    public class Student
    {
        public Student(string name, string surname, int age, DateTime birthday, string className, string teacherName, List<string> subjects)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Birthday = birthday;
            ClassName = className;
            TeacherName = teacherName;
            Subjects = subjects;
        }
        public Student()
        {

        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public string ClassName { get; set; }
        public string TeacherName { get; set; }
        public List<string> Subjects { get; set; }

    }
    [Serializable]
    public class SchoolClass
    {
        public string ClassName { get; set; }
        public List<Student> students;

        public SchoolClass(string name)
        {
            ClassName = name;
        }
        public SchoolClass()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolClass schoolClass = new SchoolClass("7А");
            schoolClass.students = new List<Student>() {
                new Student("Сергей", "Сергеев", 25, DateTime.Today, "7А", "Анна Николаевна", new List<string>(){"Русич", "Матеша", "Физ-ра" }),
                new Student("Натали", "Натальева", 27, DateTime.Today, "7А", "Анна Николаевна", new List<string>(){"Русич", "Матеша", "Физ-ра" }),
                new Student("Тимур", "Тимуров", 29, DateTime.Today, "7А", "Анна Николаевна", new List<string>(){"Русич", "Матеша", "Физ-ра" }),
            };
            XmlSerializer serializer = new XmlSerializer(typeof(SchoolClass));
            FileStream stream = new FileStream("person.xml", FileMode.Create);
            serializer.Serialize(stream, schoolClass);
        }
    }
}
