/*
  The Employee class has several reasons to change. The first
 reason might be related to the main job of the class: managing
 employee data. However, there’s another reason: the format of
 the timesheet report may change over time, requiring you to
 change the code within the class
 */

namespace OOPandDesignPatterns.SOLID.S.Problem
{
    internal class Employee
    {
        private string Name { get; set; }

        public void GetName()
        {
            Console.WriteLine("Employee name: " + Name);
        }
        public void PrintTimeSheetReport()
        {
            Console.WriteLine("Print employee time sheet report");
        }
    }
}