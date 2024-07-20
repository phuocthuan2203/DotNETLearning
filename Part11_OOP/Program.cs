
using Part11_ClassLibrary1;
using Part11_ClassLibrary1.NewDirectory1;

namespace Part11_OOP;

class Program
{
    static void Main(string[] args)
    {
        // var printer = new Printer("Thuan", 12, "QN")
        // {
        //     State = "USA"
        // };
        
        // var printer2 = new Printer()
        // {
        //     State = "California"
        // };

        var laserPrinter = new LaserPrinter("LaserPrinter", 12, "HCMC", 10000)
        {
            State = "Ha Noi"
        };
        laserPrinter.Name = "Thuan";
        laserPrinter.Resolution = 1000;
        laserPrinter.MyAbstractClass();
        
        // printer.Name = "Thuan Nguyen";
        // Console.WriteLine(printer.Name + " " + printer.State);
        // printer.Print("Nguyen Phuoc Thuan");
        
        // partial class
        var partialClass = new A();
        // accessing 2 methods which are located in 2 files
        // partialClass.A1();
        // partialClass.B1();
    }

}