
// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. Создать на его основе масив B, отбрасывая те, которые нарушают порядок

// возрастания
// элементы, больше 8
// знакочередования

using static System.Console;

WriteLine("Enter the POSITIVE number of array elements : ");

int length = int.Parse(ReadLine());
int[] array = new int[length];

array = Create_Random_Array(array, length);

int[] Create_Random_Array(int[] arr, int len)               //создаем массив запросив предварительно мин и макс число у пользователя
{
    WriteLine("Введите первое число");
    int minValue = int.Parse(ReadLine());
    WriteLine("Введите второе число, оно должно быть больше первого");
    int maxValue = int.Parse(ReadLine()) + 1; // чтобы захватить полностью отрезок
    int i = 0;
    WriteLine("Рандомный массив: ");
    while (i < len)
    {
        arr[i] = new Random().Next(minValue, maxValue);
        Write($" {arr[i]  }");
        i++;
    }
    WriteLine();
    return (arr);
}


int len_mass_b = Search_Increasing(array, length);
int[] massiv1 = new int[len_mass_b];
int Search_Increasing(int[] massiv, int len)
{
    int i = 1;
    int max = massiv[0];
    int len_in = 1;
    while (i < len)
    {
        if (max < massiv[i] && (massiv[i] < 8) && ((max > 0 &&  massiv[i] < 0) || (max < 0 && massiv[i] > 0)))
        {
            //WriteLine($"i = {i}; max = {max}; massiv[{i}] = {massiv[i]}");
            max = massiv[i];
            len_in++;
        }
        i++;
    }
    return(len_in);
}

WriteLine($"Второй массив состоит из {len_mass_b} элементов.");
Get_Incr(array, length);

void Get_Incr(int[] arr, int len)
{
    int i = 1;
    int current = arr[0];
    int j = 0;
    if (len_mass_b > 0 && current < 8)
        WriteLine($"{current}; ");
    while (i < len)
    {
        if (current < arr[i] && (arr[i] < 8) && ((current > 0 && arr[i] < 0) || (current < 0 && arr[i] > 0)))
        {
            current = arr[i];
            massiv1[j] = arr[i];
            j++;
            WriteLine($"{current}; ");
        }
        i++;
    }
}


