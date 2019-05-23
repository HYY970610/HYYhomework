# HYYhomework
namespace TheFirstConsoleProgram
    {
        class Program   ///新建程序时自动生成的类
        {
            static void Main()//C#主函数
        {
            Console.Write("a=");
            string a = Console.ReadLine();
            Console.Write("b=");
            string b = Console.ReadLine();
            double x = Convert.ToDouble(a);
            double y = Convert.ToDouble(b);
            Console.WriteLine("a+b=" + (x + y));
            Console.WriteLine("a-b="+ (x-y));
            Console.WriteLine("a*b=" + (x * y));
            Console.WriteLine("a/b=" + x / y);
            Console.ReadKey();
            }
        }
}

