
string[] arr = { "eli", "ramal", "nurlan" };


for (int i = 0; i < arr.Length - 1; i++)
{
    string terssira = "";

    for (int a = arr[i].Length - 1; i >= 0; i--)
    {
        terssira += arr[i][a];
    }

    Console.WriteLine(terssira);
}