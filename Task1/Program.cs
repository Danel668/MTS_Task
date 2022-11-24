using System.Diagnostics;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            FailProcess();
        }
        catch
        {

        }
        Console.WriteLine("Failed to fail process!");
        Console.ReadKey();
    }

    static void FailProcess()
    {
        //первый способ
        var process = Process.GetCurrentProcess();
        process.Kill();
        process.WaitForExit();


        //второй способ
        //var processName = Process.GetCurrentProcess().ProcessName;
        //System.Diagnostics.Process.Start("taskkill", $"/im {processName}.exe* /f").WaitForExit();

        //третий способ
        //var processID = Process.GetCurrentProcess().Id;
        //System.Diagnostics.Process.Start("taskkill", $"/pid {processID} /f").WaitForExit();
    }
}