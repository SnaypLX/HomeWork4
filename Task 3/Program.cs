// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива");
int A = int.Parse(Console.ReadLine());


int[] arr = new int[A];

    for (int i = 0; i < arr.Length; i++)
    {
         int num = new Random().Next(1,1000); 
         arr[i] = num;
       
    }

int max = arr[0];
int min = arr[0];
foreach (int item in arr)
{
    Console.WriteLine(item);
}

for (int i = 1; i < arr.Length; i++)
{
if (min > arr[i]){
min = arr[i];
}

else if (max < arr[i]){
max = arr[i];
}
}

Console.WriteLine($"Максимальное число {max} минимальное число {min}");
