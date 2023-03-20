using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class personalID
    {
        private string ID;
        private string name;
        private string phone;
        private string email;
        public personalID()
        {
        }
        public personalID(string ID, string name, string phone, string email)
        {
            this.ID = ID;
            this.name = name;
            this.phone = phone;
            this.email = email;

        }
        public string id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public void Display()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("Email: " + email);
        }
   

    }
}

