Console.Clear();

var str = Console.ReadLine();
string[] array = str.Split(" ");
List<string> newArray = new List<string>();

for(int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        newArray.Add(array[i]);
}

Console.WriteLine($"[{String.Join(", ", newArray)}]");