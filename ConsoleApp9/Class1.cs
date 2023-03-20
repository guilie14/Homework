using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    //public class Book
    //{
    //    public int ID;
    //    public string Title;
    //    public string Author;
    //    public string Publisher;
    //    public int Year;
    //    public string Type;
    //    public Book(int ID, string Title, string Author, string Publisher, int Year, string Type)
    //    {
    //        this.ID = ID;
    //        this.Title = Title;
    //        this.Author = Author;
    //        this.Publisher = Publisher;
    //        this.Year = Year;
    //        this.Type = Type;
    //    }
    //}
    //{
    //    public int ID { get; set; }
    //    public string Title { get; set; }
    //    public string Author { get; set; }
    //    public string Publisher { get; set; }
    //    public int Year { get; set; }
    //    public string Type { get; set; }
    //}
    class Student
    {
        //khai báo các thuộc tính tự động
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public double Avg { get; set; }
        //ghi đè phương thức tostring
        public override string ToString()
        {
            return "\nId:" + Id + "\nFullName:" + FirstName + " " + LastName
            + "\nGender:" + (Gender ? "Male" : "Female") + "\nAverage mark:" +
            Avg;
        }
        //thực thi phương thức CompareTo và so sánh tuổi để sắp xếp tăng dần,
        nếu sắp xếp giảm dần thì đảo lại đối tượng là xong
        public int CompareTo(Student other)
        {
            return this.Avg.CompareTo(other.Avg);
        }
    }
}

