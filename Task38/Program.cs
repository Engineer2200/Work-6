double[] FillArray(int size)
    {
        double[] arr =new double[size];
        for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(0,50);
            }
            return arr;
    }

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(num);
Console.WriteLine(string.Join(", ", array));

double numMAX = array[0];
double numMIN = array[0];
double difference = 0;

for(int i =0; i< array.Length; i++)
    {
        if(array[i]>numMAX)
            {
                numMAX=array[i];
            }
        if(array[i]<numMIN)
            {
                numMIN=array[i];
            }
    }
difference=numMAX-numMIN;
Console.WriteLine(difference); 

