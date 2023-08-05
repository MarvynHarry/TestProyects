// See https://aka.ms/new-console-template for more information
using ConsoleApp;

Soliution soliution = new Soliution();
//char[] space = new char[] { ' ' };
//string[] ops = Console.ReadLine().Split(space);
//int output = soliution.CalPoints(ops);

string ops = Console.ReadLine();
string output = soliution.GetmaxSrtring(ops);
Console.WriteLine(output.ToString());