using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoin
{
    public static class DemoLinq
    {
        public static IList<Student> students()
        {
            List<Student> studentlist=new List<Student>
            {
                new Student(){ Id=1,Fname="shruti",city="pune"},
                new Student(){ Id=2,Fname="siri",city="nagar"},
                new Student(){ Id=3,Fname="neha",city="mumbai"},
                new Student(){ Id=4,Fname="rakul",city="pune"},
                new Student(){ Id=5,Fname="pranav",city="nasik"} 
            };
            return studentlist;

        }
       
        
        public static IList<Teacher> Teachers()
        {
            var teacherlist = new List<Teacher>
            {
                new Teacher(){T_Id=1,T_name="kiran",city="pune"},
                new Teacher(){T_Id=2,T_name="Aman",city="mumbai"},
                new Teacher(){T_Id=3,T_name="renuka",city="pune"},
                new Teacher(){T_Id=4,T_name="heena",city="akkalkot"},
            };
            return teacherlist;
        
        }
        public class Student
        {
            public int Id { get; set; }
            public string Fname { get; set; }
            //public int Marks { get; set; }
            public string city { get; set; }
        }
        
        public class Teacher
        {
            public int T_Id { get; set; }
            public string T_name { get; set; }
            //public int Marks { get; set; }
            public string city { get; set; }
        }
        }
    }

