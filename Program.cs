// See https://aka.ms/new-console-template for more information

using System.Xml.Linq;

var data = "Jose";
switch (data)
{
    case "Jose3":
        Console.WriteLine("Jose {0}", data);
        break;
    case "Alex":
        Console.WriteLine("Alex {0}", data);
        break;
    default:
        Console.WriteLine("Case {0}", "default");
        break;
}
Console.ReadLine();
