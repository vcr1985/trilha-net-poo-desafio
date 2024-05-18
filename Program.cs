using DesafioPOO.Models;

class Program
{
    static void Main()
{
    Console.WriteLine("#IPHONE # \n");
    Iphone iphoneNew = new Iphone("33445566", "Iphone 13", "#33778899", 128);
    iphoneNew.Ligar();
    iphoneNew.ReceberLigacao();
    iphoneNew.InstalarAplicativo("Linkedin");
    Console.WriteLine("##########\n");

    Console.WriteLine("#Nokia # \n");
    Iphone nokiaNew = new Iphone("33445566", "Nokia 1100", "#33778898", 128);
    nokiaNew.Ligar();
    nokiaNew.ReceberLigacao();
    nokiaNew.InstalarAplicativo("Facebook");
    Console.WriteLine("##########\n");
}
}