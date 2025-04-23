using System.Text.RegularExpressions;

Console.WriteLine("Podaj adres IP w formacie XXX.XXX.XXX.XXX");
String ipValue = Console.ReadLine();

String regIP = @"^(25[0-5]|2[0-4]\d|1\d\d|[1-9]\d|[1-9])(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}$";

if (Regex.IsMatch(ipValue,regIP)) {
    Console.WriteLine("Adres IP jest poprawny");
}
else {
    Console.WriteLine("Adres IP nie jest poprawy");
}