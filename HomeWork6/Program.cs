﻿//HomeWork6.1---------------------------------------------
/*Contains   proverka na nalichie simvola
EndsWith     proverka konca stroki na simvol
StartsWith   proverka nachala stroki na simvol
Join         soediniaet el massiva i stavit zadannyj razdelitel meghdu nimi
LastIndexOf  vozvrat pozicii indeksa, libo -1
*/



//HomeWork6.2---------------------------------------------
/*using System;

static void Action1(int num1, int num2)
{
    return num1 + num2;
}
---void ne vozvrashaemyj tip 

static int Action1(int num1; int num2)
        {
    return num1 + num2;
}
---parametry cherez zapiatuju

static int Action1(int num1, int[] num2)
{
    return num1 + num2;
}
---nevozmozhno slozhyt tipy dannyh int i int[]

static int Action1(int num1, int num2)
            return num1 + num2;
---telo metoda neobhodimo vlozhit v {}

static Action1(int num1, int num2)
{
    return num1 + num2;
}
---chtoby vernut rezultat neobhodimo ukazat tip pri objavlenii metoda

static int Action1(num1, num2)
{
    return num1 + num2;
}
---ne ukazan tip dannyh v parametrah

*/


//HomeWork6.3---------------------------------------------
//a-------------------------------------------------------
/*
Console.WriteLine("Введите число, возводимое в квадрат:");

float sqr = Squaring(float.Parse(Console.ReadLine()));
Console.WriteLine($"Ответ: {sqr}");

float Squaring(float num)
{
    double res = Math.Pow(num, 2);
    float f = (float)res;
    return f;
}

//b-------------------------------------------------------

Console.WriteLine("Введите число, возводимое в куб:");

float cub = Cubing(float.Parse(Console.ReadLine()));
Console.WriteLine($"Ответ: {cub}");

float Cubing(float num)
{
    double res = Math.Pow(num, 3);
    float f = (float)res;
    return f;
}

//c-------------------------------------------------------

Console.WriteLine("Введите число, которое необходимо возвести в степень \nи степень, " +
    "в которую необходимо возвести число (через \"Enter\"):");
float a = float.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

float sqr = Pow(a, b);
Console.WriteLine($"Ответ: {sqr}");


float Pow(float num, int pow)
{
    float res = (float)Math.Pow(num, pow);
    return res;
}

*///d-------------------------------------------------------

/*int[] Array = { 11, 12, 13, 14, 15 };
Console.WriteLine("Введите число, которое вы ищете:");
int FindNum = int.Parse(Console.ReadLine());

int NumIndex = Find(Array, FindNum);
Console.WriteLine(NumIndex);

//d1

int Find(int[] Nums, int Num)
{
    for (int i = 0; i < Nums.Length; i++)
        if (Nums[i] == Num)
        {
            return i;
        }
    return -1;
}
*/
//e-------------------------------------------------------

/*//ne rabotaet

int[] Array = { 11, 12, 13, 14, 15 };

int[] NewArray = Invert(Array);
Console.WriteLine(NewArray[0]);

int[] Invert(int[] Nums)
{
    *//*    for (int i = 0; i < Nums.Length; i++)
        {
            for (int j = Nums.Length - 1; j >= 0; j--)
            {
                int t = Nums[j]; 4 3 2 1 0   15 14 13 12
                Nums[j] = Nums[i]; 0 1 2 3 4 11 12 13 
                Nums[i] = t; 4 3 2 1 0       15 14 13 
            }
        }
    *//*
    int t = 0;
    int i = 0;
    while (i < Nums.Length)
    {
        i++;
        t = Nums[i];
    }

    return Nums;
}

*/
/*//HomeWork6.4

string camelCase = "domenIncModelCommonFile";

string uri = toUri(camelCase);
Console.WriteLine(uri);

string toUri(string str)
{
    //разбить строку на массив по признаку большой буквы
    char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K',
        'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
    string[] words = { };
    foreach (char s in str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                if (str[i] == letters[j])
                {
                    words = new string[] { str.Substring(0,) }


                    //заменить в каждом элементе массива большую букву на маленькую
                    string strLower = str.ToLower();
                    //записать все элементы массива в одну строку через /
                    //вернуть string


                }
            }
        }
    }
    return str;


}
*/


/*string CamelCase = "";
*//*
domen
Inc
Model
Common
File
*//*
string[] uri = Uri(CamelCase);
Console.WriteLine(uri);
char.IsUpper(CamelCase[4]);
CamelCase[4].
string Uri(string Line)
{
    string[] Text = Line.Split('A-Z');
    return Text;
}
*/

/*using System;

string CamelCase = "domenIncModelCommonFile";
string AddressUri = Uri(CamelCase);
Console.WriteLine(AddressUri);

string Uri(string Address)
{
    string AddressUri = "";
    int ArrayLength = 1;
    foreach (char Char in Address)
    {
        if (char.IsUpper(Char))
        {
            ArrayLength++;
        }
    }

    string[] Ways = new string[ArrayLength];
    for (int i = 0; i < Ways.Length; i++)
    {

    }




    return AddressUri;
}
*/
using System;

string CamelCase = "domenIncModelCommonFile";
string AddressUri = Uri(CamelCase);
Console.WriteLine(AddressUri);

string Uri(string Address)
{
    string AddressUri = "";
    int NewArrayLength = 1;
    int Index = 0;
    int AddressLenght = 0;
    int j = 0;

    foreach (char Char in Address)
    {
        AddressLenght++;
        if (char.IsUpper(Char))
        {
            NewArrayLength++;
        }
    }
    string[] Ways = new string[NewArrayLength];

    foreach (char Char in Address)
    {
        if (char.IsUpper(Char))
        {
            Index = Address.IndexOf(Char);

            Console.WriteLine(Char);
            Console.WriteLine("{0}, {1}, {2}", Index, NewArrayLength, AddressLenght);
            Console.WriteLine("{0}", Address.Substring(Index));

        }

    }

/*    foreach (char Char in Address)
    {
        if (char.IsUpper(Char))
        {
            Index = Address.IndexOf(Char);
        }

    }


    for (int i = 0; i < Address.Length; i++)
    {
        if (char.IsUpper(Address[i]))
        {
            Ways[j] = Address.Substring(0, Index);
            Console.WriteLine(Ways[j]);
        }

    }
*/

    return AddressUri;
}