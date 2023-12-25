// // Домашняя работа 7 - Аттестация.

// ____________________________________________

// // Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
// // промежутке от M до N. Использовать рекурсию, не использовать циклы.

// int num = 100;
// int num2 = 79;

// void Nums(int chislo1, int chislo2)
// {
//     if(chislo1>chislo2)
// // если первое число больше второго
//     {
//         Console.Write(chislo1 + " "); 
//         if(chislo1 == chislo2)
//         {
//             return;
//         }
//     Nums(chislo1-1, chislo2);
// // спускаемся от первого числа к меньшему
//     }
//     else
// // если второе число больше первого
//     {
//         Console.Write(chislo1 + " "); 
//         if(chislo1 == chislo2)
//         {
//             return;
//         }
//     Nums(chislo1+1, chislo2);
// // поднимаемся от первого числа к большему
//     }
// }
// Nums(num, num2);


// ____________________________________________

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int num1 = 3;
// int num2 = 2;

// int Akkermn (int m, int n)
// {
//     if(m==0)
// // проверка первого возможного случая.
//     {
//         return n+1;
//     }
//     else if(m>0 && n==0)
// // проверка второго возможного случая.
//     {
//         return Akkermn(m-1,1);
//     }
//     else
// // все остальные возможные случаи.
//     {
//         return Akkermn(m-1,Akkermn(m,n-1));
//     }
// }
// Console.WriteLine(Akkermn(num1, num2));


// ____________________________________________

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать
//  рекурсию, не использовать циклы.

// int[] arr = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
// int[] arr1 = new int[]{arr.Length};
// int i=0;
// void Array(int[] arr)
// {
//     if(i==arr.Length)
//     {
//         return;
//     }
//     if(i<arr.Length)
//     {
//         Console.Write(arr[arr.Length-1-i] + "  ");
//         i++;
//     }
//     Array(arr);
// }
// Array(arr);
 


// ************************************************
// ***********************************************
//  Попытка сделать код к 3 задаче через две функции с рекурсиями каждая, но 
//  в консоли выуводится только первая (отмеченная звездочками). По второй функции пробовала без второго массива делать,
//  просто выводить массив в обратном порядке - так же на срабатывает.

// int[] array = new int[10];
// int[] array1 = new int[array.Length];
// int i = 0;

// void Array(int[] arr)
// {
//     if(i==array.Length)
//     {
//         return; 
//     }
//     if(i<array.Length)
//     {
//         arr[i] = new Random().Next(1, 20);
//         Console.Write(arr[i] + "*  ");
//         i++;
//     }
//     Array(arr); 
// }

// void ReversArr(int[] arr, int[] arr1)
// {
//     if(i==array.Length)
//     {
//         return;
//     }
//     if(i<array.Length)
//     {
//         arr1[i] = array[array.Length-1-i];
//         Console.Write(arr1[i] + "  ");
//         i++;
//     }

//     ReversArr(arr, arr1);
// }

// Array(array);
// Console.WriteLine();
// ReversArr(array, array1);

