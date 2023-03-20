using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{      
    public class Window 
    {
        public int top;
        public int left;
        public Window(int top, int left)
            {
            this.top = top;
            this.left = left;
            }
        public virtual void DrawWindow() 
        {
            Console.WriteLine("Window size top: {0} left: {1}", top, left);
        }
    }
    public class Button : Window 
    {
        public Button(int top, int left)
        :base(top, left) 
        {
        }
        public override void DrawWindow()
        {
            Console.WriteLine("Button create window size top: {0} left: {1}", top, left);
        }
    }
    public class Listbox : Window 
    {
        private string Listcontent;
        public Listbox(int top, int left, string content)
       :base(top, left) 
        {
           Listcontent = content;
        }
        public override void DrawWindow()
        {   
            base.DrawWindow();
            Console.WriteLine("Content of the box {0}", Listcontent);
        }
    }
}
