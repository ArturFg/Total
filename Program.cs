Console.WriteLine("Hello, World!"); 
 
 
 
Console.Write("Введите число, что бы зафиксировать размер массива: "); 
int length = Convert.ToInt32(Console.ReadLine());  
 
 
 
int[] arrays = new int[length]; 
for (int i = 0; i < length; i++) 
{ 
    arrays[i] = Convert.ToInt32(Console.ReadLine());  
} 
 
int index = 0; 
Console.Write($"[{arrays[index]}, "); 
for (int i = 1; i < arrays.Length - 1; i++) 
{ 
    Console.Write($"{arrays[i]}, "); 
} 
Console.Write($"{arrays[arrays.Length - 1]}]");
