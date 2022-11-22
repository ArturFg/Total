Console.WriteLine("Hello, World!"); 
 
string[] arr = {"Fhneh", "Vi", "Trg", "Yiop"};

int index = 0;
Console.Write($"[ {arr[index]}, ");
for (int i = 1; i < arr.Length - 1; i++)
{
    Console.Write($"{arr[i]}, ");
}
Console.WriteLine($"{arr[arr.Length - 1]}]");

for (int i = 0; i <= 3; i++)
{
    if(i == 0)
    {
        int a = arr[i].Length;
        if(a <= 3) Console.Write($"[ {arr[i]}, ");
        else Console.Write("[ ");
    }
    if(i != 3) 
    {    
        int b = arr[i].Length;
        if(b <= 3) Console.Write($"{arr[i]}, ");
        else Console.Write("");
    }
    if(i == 3)
    {
        int b = arr[i].Length;
        if(b <= 3) Console.Write($"{arr[arr.Length - 1]}]");
        else Console.WriteLine("]");
    }
}
