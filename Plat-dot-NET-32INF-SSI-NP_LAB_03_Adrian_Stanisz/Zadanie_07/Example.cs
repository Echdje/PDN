using System.Collections;

namespace Zadanie_07;

public class Example : IEnumerable<int>
{
    public int[] tab;
    
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < tab.Length; i++)
        {
            yield return tab[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}