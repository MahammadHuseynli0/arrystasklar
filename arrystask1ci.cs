

using System.ComponentModel.DataAnnotations;

int[] ededler = { 11, 22, 33, 44, 51, 63, 75, 86, 99 };
int kicik = ededler[0];
for (int i = 0; i < ededler.Length; i++)
{
    if (kicik >= ededler[i])
      {
        kicik = ededler[i];
    }
}
{ 
Console.WriteLine(kicik);
}




