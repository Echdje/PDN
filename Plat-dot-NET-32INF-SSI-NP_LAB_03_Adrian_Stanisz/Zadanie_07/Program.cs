using System.Text;

namespace Zadanie_07;

class Program
{
    static void Main(string[] args)
    {
       Sentence sample = new Sentence();
       sample.text = "Ala ma kota ale kot nie ma ali";
       
       List<char> letters = new List<char>();
       letters.Add('a');
       letters.Add('e');
       letters.Add('i');
       letters.Add('o');
       letters.Add('u');
       letters.Add('y');

       foreach (char c in sample)
       {
           if (letters.Contains(char.ToLower(c)))
           {
               Console.WriteLine(c);
           }
       }

    }
}