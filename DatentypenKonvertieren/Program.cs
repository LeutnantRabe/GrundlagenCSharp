//Aufgabe 1

Console.WriteLine(short.MaxValue);
Console.WriteLine(short.MinValue);
/*
  16 Bit 
  32767
  -32768
*/

Console.WriteLine(int.MaxValue);
Console.WriteLine(int.MinValue);
/*
 * 214783647
-2147483648
*/


//Aufgabe 2

string vorname = "Nicolai";
string alter = "16";
string frage = "true";

Console.WriteLine("Ich stelle Ihnen Jetzt ein paar Fragen");
Console.WriteLine("");
Console.WriteLine("Frage 1. Wie heißen Sie");
vorname = Console.ReadLine();
Console.WriteLine("Frage 2. Wie alt sind Sie?");
alter = Console.ReadLine();
Console.WriteLine("Frage 3. Ist C# die erste Programiersprache, die Sie lernen?");
frage = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("Ihre Antworten:");
Console.WriteLine($"1. {vorname}\n2. {alter}\n3. {frage}");


//Aufgabe 3
/*
  int Dollarzahl = 36;
  char Dollar = Dollarzahl
  */


//Aufagbe 4
Console.WriteLine("Geben Sie die ertste Variable ein!");
string v1_str = Console.ReadLine();

short v1_short = Convert.ToInt16(v1_str);
Console.WriteLine(v1_short);