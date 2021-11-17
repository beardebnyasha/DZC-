// // 0. Вывести квадрат числа +

// int number = 5;
// Console.WriteLine(number*number);

// 1. По двум введённым числам проверять является ли первое квадратом второго

// Console.WriteLine("Введите квадрат числа А");
// string number1 = Console.ReadLine();
// Console.WriteLine("Введите чиисло А");
// string number2 = Console.ReadLine();
// if (Convert.ToInt32(number1) == (Convert.ToInt32(number2)*Convert.ToInt32(number2)))
// {
//     Console.WriteLine("true");
// }
// else {
//     Console.WriteLine("false");
// }

// 2. Даны два числа. Показать большее и меньшее число

// Console.WriteLine("Введите число А");
// string numberA = Console.ReadLine();
// Console.WriteLine("Введите число В");
// string numberB = Console.ReadLine();
// if (Convert.ToInt32(numberA) > Convert.ToInt32(numberB))
// {
//     Console.Write("Число А = " +numberA);
//     Console.Write(", больше числа В = " +numberB);
// }
// else {
//     Console.Write("Число В = " +numberB);
//     Console.Write(", больше числа А = " +numberA);
// }

// 3. По введенному номеру дня недели вывести его название

// Console.WriteLine("Введите день номер дня недели");
// string number1 = Console.ReadLine();
// if(Convert.ToInt32(number1) == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// if(Convert.ToInt32(number1) == 2)
// {
//     Console.WriteLine("Вторник");
// }
// if(Convert.ToInt32(number1) == 3)
// {
//     Console.WriteLine("Среда");
// }
// if(Convert.ToInt32(number1) == 4)
// {
//     Console.WriteLine("Четверг");
// }
// if(Convert.ToInt32(number1) == 5)
// {
//     Console.WriteLine("Пятница");
// }
// if(Convert.ToInt32(number1) == 6)
// {
//     Console.WriteLine("Суббота");
// }
// if(Convert.ToInt32(number1) == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// if(Convert.ToInt32(number1) > 7)
// {
//     Console.WriteLine("Число не корректно");
// }

// 4. Найти максимальное из трех чисел

// Console.WriteLine("Введите число А");
// string numberA = Console.ReadLine();
// Console.WriteLine("Введите число В");
// string numberB = Console.ReadLine();
// Console.WriteLine("Введите число С");
// string numberС = Console.ReadLine();

// int max = Convert.ToInt32(numberA);

// if (max < Convert.ToInt32(numberB))
// {
//     max = Convert.ToInt32(numberB);
// }

// if (max < Convert.ToInt32(numberС))
// {
//     max = Convert.ToInt32(numberС);
// }
// Console.WriteLine("Максимальное число " +max);

// 5. Написать программу вычисления значения функции y=f(a)

// int y(int x)
// {
//     return x - 5;
// }
// Console.WriteLine("Введите значение x");
// string numberA = Console.ReadLine();

// Console.WriteLine("функция = " +y(Convert.ToInt32(numberA)));

// 6. Выяснить является ли число чётным

// Console.WriteLine("Введите число А");
// string number1 = Console.ReadLine();
// if (Convert.ToInt32(number1)%2 == 0)
// {
//     Console.WriteLine("Число четное");
// }
// else {
//     Console.WriteLine("Число не четное");
// }


// 7. Показать числа от -N до N

// int Revers(int a)
// {
//     int b = -a;
//     while (b <= a)
//     {
//         Console.WriteLine(b);
//         b++;
//     }
//     return a;
// }
// Revers(3);

// 8. Показать четные числа от 1 до N

// int Chet(int a)
// {
//     int b = 1;
//     while (b <= a)
//     {
//         if (b%2==0)
//         {
//             Console.WriteLine(b);
//             b++;
//         }
//         else
//         {
//            b++; 
//         }
//     }
//     return a;
// }
// Chet(3);


// 9. Показать последнюю цифру трёхзначного числа

// int Number3 = 123;
// Console.WriteLine(Number3%10);

// 10. Показать вторую цифру трёхзначного числа

// int Number2 = 583;
// Console.WriteLine((Number2/10)%10);

// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа


// int max(int a)
// {
//     if ( a/10 < a%10 )
//     {
//         Console.WriteLine(a%10);
//     }
//     else
//     {
//         Console.WriteLine(a/10);
//     }
//     return a;
// }
// int rnd = new Random().Next(10,100);
// Console.WriteLine(rnd);
// max(rnd);

// 12. Удалить вторую цифру трёхзначного числа

// void DeleteSecondNumber(int a)
// {
//     Console.WriteLine(a/100*10+a%10);
// }
// DeleteSecondNumber(683);

// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

// void Cratnost(int delimoe, int delitel)
// {
//     if (delimoe%delitel==0)
//     {
//         Console.WriteLine($"Число {delitel} кратно {delimoe}");
//     }
//     else
//     {
//         Console.WriteLine("Остаток: " +delimoe%delitel);
//     }
// }

// Cratnost(70,5);

// 14. Найти третью цифру числа или сообщить, что её нет

// void FindNumber3(int a)
// {
//     if (a/100%10 == 0)
//     {
//         Console.WriteLine("Третьей цифры нет");
//     }
//     else
//     {
//         Console.WriteLine("Третья цифра: " +a/100%10);
//     }
// }
// FindNumber3(487);


// Почувствуй себя джуном
// 15. Дано число. Проверить кратно ли оно 7 и 23

// void Cratnost1(int number)
// {
//     if (number%23==0)
//     {
//         if (number%7==0);
//         {
//             Console.WriteLine($"Число {number} кратно, числам 7 и 23");
//         }
//         }
//     else
//     {
//         Console.WriteLine($"Число {number} не кратно, числам 7 и 23");
//     }
// }
// Cratnost1(322);

// 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём

// void FindWeekend(int a)
// {
//     if (a==6 || a==7)
//     {
//         Console.WriteLine("Выходной день");
//     }
//     else 
//     {
//         Console.WriteLine("Будний день");
//     }
// }
// FindWeekend(6);

// 21. Программа проверяет пятизначное число на палиндромом.

// bool Palindrom(int a)
// {
//     string number = Convert.ToString(a);
//     int lenght = number.Length;
//     int i = 0;
//     while (i < lenght)
//     {
//         if (number[i] != number[lenght - i - 1]) 
//             {
//             return false;
//             }
//         i++;
//     }
//     return true;   
// }
// Console.WriteLine(Palindrom(12571));

// 22. Найти расстояние между точками в пространстве 2D/3D

// double line (int ColToch, int[] tochka_1, int[] tochka_2)
// {
//     double result =0;
//     for(int i = 0; i < ColToch; i++)
//     {
//         result += Math.Pow(tochka_1[i]-tochka_2[i], 2);
//     }
//     return Math.Sqrt(result);
// }

// Console.WriteLine(line(3, new int[] {1,2}, new int[] {2,1}));

// double line2 (int ColToch, int[] tochka_1, int[] tochka_2)
// {
//     double result =0;
//     for(int i = 0; i < ColToch; i++)
//     {
//         result += Math.Pow(tochka_1[i]-tochka_2[i], 2);
//     }
//     return Math.Sqrt(result);
// }

// Console.WriteLine(line2(3, new int[] {1,2,3}, new int[] {3,2,1}));

// 23. Показать таблицу квадратов чисел от 1 до N 

// int PowFrom1ToNumber(int number)
// {
//     for (int i = 0; i < number; i++)
//     {
//         Console.WriteLine($"{i+1}^2 = {Math.Pow(i+1, 2)}");
//     }
//     return number;
// }
// PowFrom1ToNumber(225);

// 24. Найти кубы чисел от 1 до N

// int PowFrom1ToNumber(int number)
// {
//     for (int i = 0; i < number; i++)
//     {
//         Console.WriteLine(Math.Pow(i+1, 3));
//     }
//     return number;
// }
// PowFrom1ToNumber(10);

// 25. Найти сумму чисел от 1 до А

// int SumFrom1ToA(int A)
// {
//     int sum = 0;
//     for(int i = 0; i < A; i++)
//     {
//         sum = sum + i + 1;
//     }
//     return sum;
// }
// Console.WriteLine(SumFrom1ToA(7));

// 26. Возведите число А в натуральную степень B используя цикл

// double NaturePowB(int A, int B)
// {
//     double result = A;
//     for(int i = 0; i < B; i++)
//     {
//         result = Math.Pow(A, i+1);
//     }
//     return result;
// }
// Console.WriteLine(NaturePowB(3,5));

// 27. Определить количество цифр в числе

// int ColNum(int number)
// {
//     string Number2 = Convert.ToString(number);
//     return Number2.Length;
// }


// Console.WriteLine(ColNum(11111));


// 28. Подсчитать сумму цифр в числе

// int SumChislo(int a)
// {
//     int result = 0;
//     while (a>0)
//     {
//         result = result + a%10;
//         a = a/10;
//     }
//     return result;
// }
// Console.WriteLine(SumChislo(12));


// 29. Написать программу вычисления произведения чисел от 1 до N

// int ProizFrom1ToN(int N)
// {
//     int result=0;
//     for (int i = 0; i<N; i++)
//     {
//         result = result + i+1;
//     }
//     return result;
// }

// Console.WriteLine(ProizFrom1ToN(5));

// 30. Показать кубы чисел, заканчивающихся на четную цифру

// double CubChet(int a)
// {
//     if (a % 2 == 0)
//     {
//         return Math.Pow(a, 3);
//     }
//     else 
//     {
//         return 0;
//     }
// }

// Console.WriteLine(CubChet(3));

// 31. Задать массив из 8 элементов и вывести их на экран 

// int[] NewMassive(int size)
// {
//     int[] array = new int [size];
//     for (int i = 0; i<size; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//     }
//     return array;
// }

// int[] array = NewMassive(3);

// for(int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine(array[i]);
// }


// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

// int[] NewMassive()
// {
//     int[] array = new int [8];
//     for (int i = 0; i<8; i++)
//     {
//         Console.WriteLine(array[i] = new Random().Next(0, 2));
//     }
//     return array;
// }

// NewMassive();

// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива

// int SumPol = 0;
// int SumOtr = 0;
//     int[] array= new int[12];
//         for (int i = 0; i<array.Length; i++)
//     {
//         int result = new  Random().Next(-9,13);
//         Console.Write(result+ " ");
//         if(result<0)
//         {
//             SumPol = SumPol + result;
//         }
//         if (result>0)
//         {
//             SumOtr = SumOtr + result;
//         }
//     }
//     Console.WriteLine("Сумма пол:" +SumPol);
//     Console.WriteLine("Сумма отр:" +SumOtr);

// 34. Написать программу замену элементов массива на противоположные

// int[] array = new int[4];
// for (int i = 0; i < array.Length; i++)
// {
//     int result = new Random().Next(0, 150);
//     array[i] = result;
//     Console.Write(result + " ");
// }

// int[] SwapElements(int[] arr)
// {
//     int box = 0;
//     string ConMas = Convert.ToString(arr);

//     for (int i = 0; i <= ConMas.Length / 2; i++)
//     {
//         box = ConMas[i];
//         ConMas[i] = ConMas[ConMas.Length - i-1];
//         ConMas[ConMas.Length - i] = box;
//     }
//     for (int i = 0; i <= ConMas.Length; i++)
//     {
//         Console.WriteLine(arr[i] + " ");
//     }
//     return ConMas;
// }
// SwapElements(array);


// 35. Определить, присутствует ли в заданном массиве, некоторое число 

// int Number(int a)  //bool Number(int[] array, int number)
// {
//     int index = 0;
//     int[] array= new int[15];
//     for (int i = 0; i<array.Length; i++)
//     {
//         int result = new  Random().Next(0,99);
//         Console.Write(result+ " ");
//         if(result==a)
//         {
//             index = 1;
//         }
//     }
//     if(index > 0)
//         {
//             Console.WriteLine("Попадание");
//         }
//         else
//         {
//             Console.WriteLine("Промах");
//         }
//         return a;
// }

// Number(15);


// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

// int[] array = new int[30];
// for (int i = 0; i < array.Length; i++)
// {
//     int result = new Random().Next(100, 1000);
//     array[i] = result;
//     Console.Write(result + " ");
// }

// int[] ChetNechet(int[] arr)
// {
//     int Chet = 0;
//     int Nechet = 0;
//     for (int i = 0; i<arr.Length; i++)
//     {
//         if(arr[i]%2 == 0)
//         {
//             Chet = Chet+1;
//         }
//         else 
//         {
//             Nechet = Nechet + 1;
//         }
//     }
//     Console.WriteLine(" ");
//     Console.WriteLine("Чет: " +Chet);
//     Console.WriteLine("Не чет: " +Nechet);
//     return arr;
// }

// ChetNechet(array);

// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// int[] array = new int[123];
// for (int i = 0; i < array.Length; i++)
// {
//     int result = new Random().Next(0, 150);
//     array[i] = result;
//     Console.Write(result + " ");
// }

// int Colwo(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] >= 9 && arr[i] < 100)
//         {
//             count = count + 1;
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine("Количество цифр в масиве " +count);
//     return count;
// }
// Colwo(array);

// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//     int result = new Random().Next(0, 2);
//     array[i] = result;
//     Console.Write(result + " ");
// }

// int[] SumNechet(int[] arr)
// {
//     int result =0;
//     for (int i = 0; i<arr.Length; i++)
//     {
//         if(i%2 == 0)
//         {
//             result = result+arr[i];
//         }

//     }
//     Console.WriteLine(" ");
//     Console.WriteLine("Суммы нечетных позиций массива: " +result);

//     return arr;
// }
// SumNechet(array);

// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// int[] array = new int[4];
// for (int i = 0; i < array.Length; i++)
// {
//     int result = new Random().Next(0, 5);
//     array[i] = result;
//     Console.Write(result + " ");
// }

// int[] ProPar(int[] arr)
// {

//     for (int i = 0; i<arr.Length/2; i++)
//     {
//     Console.WriteLine(" ");
//     Console.WriteLine("Сумма" +arr[i] * arr[arr.Length - i-1]);
//     }
//     return arr;
// }
// ProPar(array);

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//     int result = new Random().Next(0, 100);
//     array[i] = result;
//     Console.Write(result + " ");
// }

// int[] RazMinMax(int[] arr)
// {
//     int max = arr[1];
//     int min = arr[1];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (max < arr[i])
//         {
//             max = arr[i];
//         }
//         if (min > arr[i])
//         {
//             min = arr[i];
//         }
//     }
//     Console.WriteLine(" ");
//     Console.WriteLine("Мин: " + min);
//     Console.WriteLine("Макс: " + max);
//     Console.WriteLine("Макс-Мин: " + (max - min));

//     return arr;
// }
// RazMinMax(array);