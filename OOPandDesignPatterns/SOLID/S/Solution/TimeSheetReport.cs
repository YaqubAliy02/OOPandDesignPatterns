/*
  Solve the problem by moving the behavior related to printing
 timesheet reports into a separate class. This change lets you
 move other report-related stuff to the new class.
 */
namespace OOPandDesignPatterns.SOLID.S.Solution
{
    internal class TimeSheetReport
    {
        //Some field...
        public void Print(Employee employee)
        {
            employee.GetName();
        }
    }
}
