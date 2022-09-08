//Aufgabe 1

Console.WriteLine(" _-_ ");
Console.WriteLine("(o o)");
Console.WriteLine("| O |");
Console.WriteLine("|   |");
Console.WriteLine("'~~~'");

//Aufgabe 2

string Vorname = "Nicolai";
string Nachname = "Kohl";
string Alter = "16";

Console.WriteLine("Vorname: {0}", Vorname);
Console.WriteLine("Nachname: {0}", Nachname);
Console.WriteLine("Alter: {0}", Alter);

//Aufgabe 3

string vorname;
string alter;
string klasse;

Console.WriteLine("Geben sie ihre Daten ein!");

vorname = Console.ReadLine();
alter = Console.ReadLine();
klasse = Console.ReadLine();

Console.WriteLine($"{vorname} ist {alter} Jahre alt und besucht die {klasse} des Georg-Simon-Ohm Berufskolleg");