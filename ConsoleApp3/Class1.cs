using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Properties
{
    public class Student
    {
        public int Id;
        public string Name;
        public int Age;
        public void Display()
        {
            Console.WriteLine("Student ID: {0}", Id);
            Console.WriteLine("Student age: {0}", Age);
            Console.WriteLine("Student name: {0}", Name);
        }
    }
    class StudentModel
    {
        //khai báo danh tập hợp chứa các sinh viên
        List<Student> liststudent;
        //phương thức khởi tạo
        public StudentModel()
        {
            //khởi tạo danh sách sinh viên
            liststudent = new List<Student>
            {
                new Student() { Id = 1, Name = "Dung", Age = 20 },
                new Student() { Id = 2, Name = "Tuan", Age = 25 },
                new Student() { Id = 3, Name = "Ha", Age = 18 },
                new Student() { Id = 4, Name = "Anh", Age = 30 },
                new Student() { Id = 5, Name = "Long", Age = 24 },
            };
        }
        //phương thức trả về danh sách sinh viên
        public List<Student> ListStudent()
        {
            return liststudent;
        }
        //phương thức trả về sinh viên theo id
        public Student ListStudent(int id)
        {
            Student st = null;
            foreach (var item in liststudent)
            {
                if (item.Id == id)
                    st = item;
            }
            return st;
        }
        //phương thức trả về sinh viên có tuổi từ x to y
        public List<Student> ListStudent(int x, int y)
        {
            List<Student> result = new List<Student>();
            foreach (var item in liststudent)
            {
                if (item.Age >= x && item.Age <= y)
                    result.Add(item);
            }
            return result;
        }
    }


}
