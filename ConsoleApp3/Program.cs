using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Properties;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo đối tượng
            StudentModel action = new StudentModel();
            //gọi phương thức lấy tất cả sinh viên
            List<Student> listall = action.ListStudent();
            //hiển thị
            foreach (var item in listall)
            {
                item.Display();
            }
            //gọi phương thức lấy sinh viên theo id
            Student hocsinh = action.ListStudent(2);
            //hiển thị
            hocsinh.Display();
            //gọi phương thức lấy sinh viên có tuổi từ 25-30
            List<Student> listage = action.ListStudent(25, 30);
            //hiển thị
            foreach (var item in listage)
            {
                item.Display();

            }
        }
    }
}
