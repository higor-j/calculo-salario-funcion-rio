using System.Threading.Channels;

string name; int year; double wage; double readjustment;

Console.WriteLine("Type your name: ");
name = Console.ReadLine();

Console.WriteLine("Enter the year you were born: ");
year = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your salary: ");
wage = double.Parse(Console.ReadLine());

Console.WriteLine("Enter your readjustment: ");
readjustment = Double.Parse(Console.ReadLine());

double salaryReadjustment = wage + (wage * readjustment);

Console.WriteLine($"Hello {name}, the year you were born is {year} and your salary with readjustment is " +
                  $"$ {salaryReadjustment}");