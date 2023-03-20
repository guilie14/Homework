﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
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

        public int CompareTo(Student other)
            {
                return this.Avg.CompareTo(other.Avg);
            }
        }
}
