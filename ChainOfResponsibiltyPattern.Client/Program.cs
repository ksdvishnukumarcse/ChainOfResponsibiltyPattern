using ChainOfResponsibiltyPattern.Client.Chain;
using ChainOfResponsibiltyPattern.Client.Models;
using System;

namespace ChainOfResponsibiltyPattern.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing the handler
            // Object creation can be solved from DI as well if we use 
            var tenDaysLeaveHandler = new TenDaysLeaveApproval();
            var twentyDaysLeaveHandler = new TwentyDaysLeaveApproval();
            var thirtyDaysLeaveHandler = new ThirtyDaysLeaveApproval();
            var moreThanThirtyDaysHandler = new MoreThanThirtyDaysLeaveApproval();
            
            //Chaining Handler
            tenDaysLeaveHandler.SetNextHandler(twentyDaysLeaveHandler)
                .SetNextHandler(thirtyDaysLeaveHandler)
                .SetNextHandler(moreThanThirtyDaysHandler);
            Process.ProcessHandler(tenDaysLeaveHandler);
            Console.ReadLine();
        }
    }

    public class Process
    {
        public static void ProcessHandler(AbstractionHandler handler)
        {
            var empList = EmployeeLeaveRequestRepo.GetEmployeeLeaveRequest();
            foreach (var emp in empList)
            {
                var result = handler.HandleRequest(emp.RequestdLeaves, emp.Name);
                Console.WriteLine(result);
            }
        }
    }
}
