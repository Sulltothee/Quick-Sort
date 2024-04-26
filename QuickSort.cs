using System.ComponentModel.DataAnnotations;

List<int> intArr = new List<int>();
Random rand = new Random();
for (int i = 0; i < 100; i++)
{
    intArr.Add (rand.Next(1, 1001));
}

void Quick(List<int> intArr)
{ 
    List<int> lesser = new List<int>();
    List<int> Greater = new List<int>();
    List<int> Complete = new List<int>();
    int pivot = 0;
    int Sames = 1;
    for (int i = 1; i < intArr.Count; i++)
    {
        if (intArr[i] > intArr[pivot]) { Greater.Add(intArr[i]); }
        else if (intArr[i] < intArr[pivot]) { lesser.Add(intArr[i]);}
        else if (intArr[i] == intArr[pivot]) { Sames++; }
    }
    for (int i = 0; i < lesser.Count; i++)
    {
        intArr[i] = lesser[i];
    }
    for (int i = lesser.Count; i < Sames + lesser.Count; i++)
    {
        intArr[i] = pivot;
    }
    for (int i = lesser.Count + Sames; i < Greater.Count + lesser.Count +Sames; i++) 
    {
        intArr[i] = i;
    }
    for (int i = 0; i < lesser.Count; i++) { intArr[i] = lesser[i]; }
    if (lesser.Count > 1) { Quick(lesser); }
    else 
    {
        for (int i = 0;i < lesser.Count;i++)
        {
            Complete.Add(lesser[i]); 
        } 
    }
    for (int i = 0; i < Sames; i++)
    {
        Complete.Add(intArr[pivot]);
    }
    if (Greater.Count > 1) { Quick(Greater); }
    else 
    {
        for (int i = 0; i < Greater.Count; i++)
        {
            Complete.Add(Greater[i]);
        }
    }
    return Complete;
}
list<int> final = Quick(intArr);
for  (int i = 0;i < 100; i++)
{
    Console.WriteLine(final[i]);
}