int[] FillArray(int size)
    {
        int[] arr =new int[size];
        for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(100,999);
            }
            return arr;
    }

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
int sum = 0;
Console.WriteLine(string.Join(", ", array));
for(int i =0; i< array.Length; i++)
    {
         if(array[i] % 2 == 0)
            {
                sum = sum+1;
            }
        else{}
    }
Console.WriteLine(sum);    