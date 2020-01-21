using System;
using System.Diagnostics;
using System.Management.Automation;

namespace DesktopExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
            Onboarding();
        }

         
        static void  Onboarding()
        {

            PowerShell ps = PowerShell.Create();
            ps.AddScript("cd " + Constants.ONBOARDING);
            ps.AddScript("dotnet run");
            ps.Invoke();
        }
            




    }
}
