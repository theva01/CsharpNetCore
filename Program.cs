// See https://aka.ms/new-console-template for more information

using System.Xml.Linq;
var (a, b, opcion) = (2, 6, "-");
var data = 2;
var result = opcion switch
{
    "+" => a==b,
    "-" => a>b,
    "*" => a<b
    
};
Console.WriteLine(result);

Console.ReadLine();
