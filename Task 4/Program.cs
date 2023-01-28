// Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200.
// Обновите список только при первом вхождении числа 20.

Console.WriteLine("Введите размер массива");
int A = int.Parse(Console.ReadLine());


int[] arr = new int[A];

    for (int i = 0; i < arr.Length; i++)
    {
         int num = new Random().Next(1,88); 
         arr[i] = num;
       
    }



for (int i = 0; i < arr.Length; i++)
{
if (arr[i] == 20 ){
arr[i] = 200;
break;
}


}

foreach (int item in arr)
{
    Console.WriteLine(item);
}
