using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo đối tượng contact với constructor không tham số
            personalID ct1 = new personalID();
            //gán giá trị cho ct1
            ct1.id = "6";
            ct1.Name = "Nguyen Thi Hoa";
            ct1.Phone = "0978735922";
            ct1.Email = "hoahoa@gmail.com";
            //tạo đối tượng contact với constructor có tham số
            personalID ct2 = new personalID("5", "Tran Thi Tinh","0987874555", "bupbecotinhyeu@yahoo.com");
            //hiển thị thông tin ct1 và ct2
            ct1.Display();
            ct2.Display();
            Console.ReadLine()
        }
    }
}

