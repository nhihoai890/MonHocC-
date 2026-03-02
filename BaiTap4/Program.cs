// See https://aka.ms/new-console-template for more information
using BaiTap4;

class Program
{
    static void Main(string[] args)
    {
        Generic.display<int>(10);
        Generic.display<string>("Hello World");
        int kq = Generic.traVe<int>(20);
        Console.WriteLine("Gia tri tra ve: " + kq);
    }
}
