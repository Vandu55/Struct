using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public  class Structt
    {
        static void Main(string[] args)
        {
            //int var = 10;
            MyDataType obj = new MyDataType();
            obj.Integer = 12;
            //MyDataType obj;
            obj.MyMehtod();

            //obj.Integer = 10;
        }
    }
    struct MyDataType

    {
        //public int Integer = 10     we cannot this type of declare in struct
        public int Integer;
        public  void MyMehtod()
        {
            Console.WriteLine("The value of Integer " + Integer);
            Console.ReadLine();
        }
    }
}
