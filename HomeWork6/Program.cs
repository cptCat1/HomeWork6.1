//HomeWork6.3---------------------------------------------
//a-------------------------------------------------------

//Console.WriteLine("Введите число, возводимое в квадрат:");

//float sqr = Squaring(float.Parse(Console.ReadLine()));
//Console.WriteLine($"Ответ: {sqr}");

//float Squaring(float num)
//{
//    double res = Math.Pow(num, 2);
//    float f = (float)res;
//    return f;
//}

//b-------------------------------------------------------

//Console.WriteLine("Введите число, возводимое в куб:");

//float cub = Cubing(float.Parse(Console.ReadLine()));
//Console.WriteLine($"Ответ: {cub}");

//float Cubing(float num)
//{
//    double res = Math.Pow(num, 3);
//    float f = (float)res;
//    return f;
//}

//c-------------------------------------------------------

//Console.WriteLine("Введите число, которое необходимо возвести в степень \nи степень, " +
//    "в которую необходимо возвести число (через \"Enter\"):");
//float a = float.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());

//float sqr = Pow(a, b);
//Console.WriteLine($"Ответ: {sqr}");


//float Pow(float num, int pow)
//{
//    float res = (float)Math.Pow(num, pow);
//    return res;
//}

//d-------------------------------------------------------

//int[] Array = { 11, 12, 13, 14, 15 };
//Console.WriteLine("Введите число, которое вы ищете:");
//int FindNum = int.Parse(Console.ReadLine());

//int NumIndex = Find(Array, FindNum);
//Console.WriteLine(NumIndex);

//int Find(int[] Nums, int Num)
//{
//    for (int i = 0; i <= Nums.Length; i++)
//        if (Nums[i] == Num)
//        {
//            return i;
//        }
//        return -1;
//}

//e-------------------------------------------------------

int[] Array = { 11, 12, 13, 14, 15 };

int[] NewArray = Invert(Array);
Console.WriteLine(NewArray[0]);

int[] Invert(int[] Nums)
{
    for (int i = 0; i < Nums.Length; i++)
    {

    }
    return
}