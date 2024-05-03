
using System.Text;

var names = new StringBuilder("Alex Pagoada");
//names[0] = 'a';
names.AppendLine(" ");
names.Append("Joel").Append(" ").Append("Orozco");
//names.Capacity = 17;
Console.WriteLine(names.ToString());
Console.ReadLine();

