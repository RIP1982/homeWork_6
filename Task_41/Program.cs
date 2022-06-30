/*Задача 41: Пользователь вводит с клавиатуры числа через запятую. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/

Console.Clear();

Console.WriteLine("Введите числа через запятую: ");
int[] num = StrArray(Console.ReadLine());

Console.Write("[");
PrintArray(num);
Console.Write("]");
Console.WriteLine();

int countPositiveNum = 0;

for(int i = 0; i < num.Length; i++)
{
    if(num[i] > 0)
    {
        countPositiveNum++;
    }
}

Console.WriteLine($"Количество положительных чисел = {countPositiveNum}");

int [] StrArray(string output)
{
    int numCount = 0;

    for (int i = 0; i < output.Length; i++)
    {
        if(output[i] == ',')
        {
            numCount++;
        }
    }

    int[] num = new int[(numCount +1)];
    int index = 0;

    for (int i = 0; i < output.Length; i++)
    {
        string tempStr = ""; 
        while(output[i] != ',')
        {
            if(i != output.Length - 1)
            {
                tempStr = tempStr + output[i];
                i++;
            }
            else
            {
                tempStr = tempStr + output[i];
                break;
            }
        }
        num[index] = Convert.ToInt32(tempStr);
        index++;
    }
    return num;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}




