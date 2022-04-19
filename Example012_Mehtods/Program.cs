﻿// Вид 1 **********************************************************
/*
void Method1()
{
    Console.WriteLine("Автор Олег Осипов");
}

Method1();
*/



//Вид2 ************************************************************

/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Текст сообщения");
*/

/*
void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

//Method21("Текст", 4);
Method21(count: 3, msg: "Новый текст");
*/



//Вид3 **************************************************************
/*
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/



//Вид4 **************************************************************

/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf ");
Console.WriteLine(res);
*/

//Цикл for ****************************************************************************
/*
string Method41(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < 10; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method41(10, "qwerty ");
Console.WriteLine(res);
*/

//Цикл в цикле *************************************************************************
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

//====== Работа с текстом =======
//Дан текст. В тексте все пробелы нужно заменить черточкамию
//маленькие буквы "к" заменить большими "К",
//а большие "С" заменить маленькими "с".
/*
string text = "-Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
//Console.WriteLine(newText);

newText = Replace(newText, 'к', 'К');
//Console.WriteLine(newText1);

newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
*/


//======= Работа с массивами =======

// Задача: отсортировать массив

int[] arr = { 1, 5, 4, 3, 2, 7, 6, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        //Console.Write($"{array[i]} ");
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
//Console.WriteLine();
SelectionSort(arr);
PrintArray(arr);
Console.WriteLine();