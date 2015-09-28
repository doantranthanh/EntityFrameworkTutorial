﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                Student stud = new Student { StudentName = "Thanh Doan" };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
