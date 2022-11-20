Console.WriteLine("Hello, World!"); 
 
Console.Write("Введите число, что бы зафиксировать размер массива: "); 
int length = Convert.ToInt32(Console.ReadLine());  
 
int[] arrays = new int[length]; 
for (int i = 0; i < length; i++) 
{ 
    arrays[i] = Convert.ToInt32(Console.ReadLine());  
} 

for (int i = 0; i < length; i++)
{
    int[] array = new int[1];
    array[0] = arrays[i];
    int size = 1;
    while(array[0] >= 9)
    {
        array[0] /= 10;
        size++;
    }
    if(size > 3) arrays[i] = 0;
}

int index = 0; 
if(arrays[index] > 0) Console.Write($"[{arrays[index]}, "); 
else Console.Write($"[");
for (int i = 1; i < arrays.Length - 1; i++) 
{ 
    if(arrays[i] > 0) Console.Write($"{arrays[i]}, "); 
    else Console.Write($"");
} 
if(arrays[arrays.Length - 1] > 0) Console.Write($"{arrays[arrays.Length - 1]}]");
else Console.Write($"]");
