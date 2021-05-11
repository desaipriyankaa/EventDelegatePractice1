using EventDelegatePractice1.Enum;
using System;

namespace EventDelegatePractice1
{
    class Program
    { 
        static void Main(string[] args)
        {
            //SchoolHierarchyHandler sc1 = new SchoolHierarchyHandler(SchoolHandler1);
            //SchoolHierarchyHandler sc2 = new SchoolHierarchyHandler(SchoolHandler2);
            //SchoolHierarchyHandler sc3 = new SchoolHierarchyHandler(SchoolHandler3);

            ////sc1(2, SchoolType.Nursary);
            ////sc2(1, SchoolType.Primary);

            //sc1 += sc2 + sc3;
            //int finalYears = sc1(10, SchoolType.Secondary);
            //Console.WriteLine(finalYears);

            Students student = new Students();
            student.StudentPassed += new SchoolHierarchyHandler(student_StudentPassed);
            student.DoScoolLevel(8, SchoolType.Secondary);

        }

        static int student_StudentPassed(int years, SchoolType schoolType)
        {
            Console.WriteLine(years+" "+schoolType);
            return years;
        }

        //static void SchoolLevel(SchoolHierarchyHandler sc)
        //{
        //    sc(1, SchoolType.Nursary);
        //    sc(2, SchoolType.Primary);
        //    sc(10, SchoolType.Secondary);
        //    sc(2, SchoolType.HigherEducation);
        //}
        //static int SchoolHandler1(int years, SchoolType schoolType)
        //{
        //    Console.WriteLine("SchoolHandler1 called "+schoolType+" "+years);
        //    return years;
        //}
        //static int SchoolHandler2(int years, SchoolType schoolType)
        //{
        //    Console.WriteLine("SchoolHandler2 called " + schoolType + " " + years);
        //    return years;
        //}
        //static int SchoolHandler3(int years, SchoolType schoolType)
        //{
        //    Console.WriteLine("SchoolHandler3 called " + schoolType + " " + years);
        //    return years+3;
        //}
    }
}
