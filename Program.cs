using EventDelegatePractice1.Enum;
using System;

namespace EventDelegatePractice1
{
    public delegate void SchoolHierarchyHandler(int years, SchoolType schoolType);
    class Program
    { 
        static void Main(string[] args)
        {
            SchoolHierarchyHandler sc1 = new SchoolHierarchyHandler(SchoolHandler1);
            SchoolHierarchyHandler sc2 = new SchoolHierarchyHandler(SchoolHandler2);

            //sc1(2, SchoolType.Nursary);
            //sc2(1, SchoolType.Primary);

            SchoolLevel(sc1);
        }
        static void SchoolLevel(SchoolHierarchyHandler sc)
        {
            sc(1, SchoolType.Nursary);
            sc(2, SchoolType.Primary);
            sc(10, SchoolType.Secondary);
            sc(2, SchoolType.HigherEducation);
        }
        static void SchoolHandler1(int years, SchoolType schoolType)
        {
            Console.WriteLine("SchoolHandler1 called "+schoolType+" "+years);
        }
        static void SchoolHandler2(int years, SchoolType schoolType)
        {
            Console.WriteLine("SchoolHandler2 called " + schoolType + " " + years);
        }
    }
}
