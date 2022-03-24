using System;
using System.Linq;

namespace LinqJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = from od in DemoLinq.Teachers()
                    join o in DemoLinq.students()
                    on od.city equals o.city

                    select new
                    {
                        StudentCity = o.Fname,
                        TeacherCity = od.T_name,
                        City=od.city
                    };
            foreach(var item in a)
            {
                Console.WriteLine($"Student Name  "+ item.StudentCity +"  Teacher Name  "+ item.TeacherCity+"  City  "+  item.City );
            }
        
        }
    }
}
