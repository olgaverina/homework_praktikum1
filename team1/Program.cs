// Задача
// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
// Создать на его основе масив B, отбрасывая те элементы, которые

// нарушают порядок возрастания

using static System.Console;

WriteLine("Enter the POSITIVE number of array elements : ");
int length = int.Parse(ReadLine());
int[] array = new int[length];

Write("Рандомный массив: \n");

Create_array(array);

void Create_array(int[] array)                          //создаю первый рандомный массив
{
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(10, 100);
        Write($"{array[index]}  ");
        index++;
    }
    WriteLine();
}
int idx = 0;
int elem = 1;
int max = array[0];
while (idx < length - 1)                                //нахожу размерность второго массива
{
    if (max < array[idx + 1])
    {
        //Write($"{max}  ");
        max = array[idx + 1];
        elem++;
    }
    idx++;
}
//Write($"{max}  ");
int[] massiv1 = new int[elem];
int idx_A = 0;
int idx_M = 1;
max = array[0];
massiv1[0] = array[0];
while (idx_A < length - 1)                                  //записываю во второй массив все числа по возрастанию
{
    if (max < array[idx_A + 1])
    {
        max = array[idx_A + 1];
        massiv1[idx_M] = array[idx_A + 1];
        idx_M++;
    }
    idx_A++;
}
idx_M = 0;
Write("Новый массив по возрастанию: \n");
while(idx_M < elem)                                         //печатаю получившийся массив         
{
    Write($"{massiv1[idx_M]}  ");
    idx_M++;
}


// отбрасывая те элементы, которые больше среднего арифметического элементов A

double sr_arifm = 0;
int sum = 0;
int i = 0;
while (i < length)                                          //находим сумму элементов массива
{
    sum += array[i];
    i++;
}
WriteLine($"\n\nСумма элементов массива - {sum}");                                  // выводим на печать сумму

sr_arifm = sum/length;
WriteLine($"\n\nСреднее арифметическое - {sr_arifm}");
idx = 0;
elem = 0;
WriteLine("\n\nНовый массив с числами ниже среднего арифметического: ");
while (idx < length)                                //нахожу размерность второго массива
{
    if (sr_arifm >= array[idx])
    {
        Write($"!{array[idx]}  \n");
        elem++;
    }
    idx++;
}
//WriteLine($"length = {length}");
int[] massiv2 = new int[elem];
i = 0;
int j = 0;
while (i < length)                                      //записываю во второй массив числа меньше среднего арифметического
{
    if (sr_arifm >= array[i]) //wrong
    {
        massiv2[j] = array[i];
        // WriteLine($"length = {length}, i = {i}, j = {j}, elem = {elem}, ");
        //Write($" {massiv2[j]} ");
        j++;
    }
    i++;
}


// отбрасывая чётные элементы

idx = 0;
elem = 0;
while (idx < length)                                 //нахожу размерность третьго массива
{
    if (array[idx] % 2 != 0)
    {
        elem++;
    }
    idx++;
}

int[] massiv3= new int[elem];
i = 0;
j = 0;

WriteLine("\n\nНовый массив с нечетными числами: ");
while (i < length)                                  //записываем только нечетные элементы
{
    if (array[i] % 2 != 0)
    {
        massiv3[j] = array[i];
        Write($"{massiv3[j]}   ");
        j++;
    }
    i++;
}
if(j == 0)
{
    WriteLine("\n\nНечетные числа отсутсвуют");
}
