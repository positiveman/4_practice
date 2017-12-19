using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////task1
            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////task2
            //for (int i = 100; i < 201; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////task2.1

            //for (int i = 200; i  >99; i--)
            //{
            //    Console.WriteLine(i);
            //}

            ////task3
            //for (int i = 0; i < 51; i++)
            //{

            //    if (i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            ////task4

            //int sum = 0;
            //for (int i = 0; i < 101; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            ////task5

            //int mult = 1;

            //for (int i = 1; i < 11; i++)
            //{
            //    mult = mult * i;
            //}

            //Console.WriteLine(mult);





            ////task6

            //string number = Console.ReadLine();

            //foreach (var item in number)
            //{
            //    Console.WriteLine(item);
            //}

            ////task6.1

            //string number = Console.ReadLine();
            //string[] afterSplit = number.Split('.');
            //foreach (string part in afterSplit)
            //{
            //    Console.WriteLine(part);
            //}

            ////task7

            //string number = Console.ReadLine();
            //int sum = 0;

            //foreach (char item in number)
            //{
            //    sum += int.Parse(item.ToString());
            //}

            //Console.WriteLine(sum);

            ////task8

            //String text = Console.ReadLine();
            //char[] charArray = text.ToCharArray();
            //Array.Reverse(charArray);
            //foreach (char character in charArray)
            //{
            //    Console.Write(character);
            //}

            ////task9

            //int[] intArr= new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    intArr[i] = i;
            //}

            //foreach (int value in intArr)
            //{
            //    Console.WriteLine(value);
            //}

            //task10

            //int size =int.Parse( Console.ReadLine());

            //int[] intArr = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    intArr[i] = int.Parse(Console.ReadLine());
            //}

            ////task11
            //int[] intArr = new int[] {1, 5, 9, 5 };

            //int sum = 0;

            //foreach (int value in intArr)
            //{
            //    sum += value;
            //}

            //Console.WriteLine(sum);

            ////task12

            //int[] intArr = new int[] { 1, 5, 9, 5 };

            //int mult = 1;

            //foreach (int value in intArr)
            //{
            //    mult = mult * value;
            //}

            //Console.WriteLine(mult);

            ////task13

            //int[] intArr = new int[] { 1, 5, 9, 5 };

            //Console.WriteLine(intArr.Min());


            ////task14

            //int[] intArr = new int[] { 1, 5, 9, 5 };

            //Console.WriteLine(intArr.Max());

            ////task15

            //int[] intArr = new int[] { 2, 5, 9, 5 };

            //double sum = 0;

            //foreach (int value in intArr)
            //{
            //    sum += value;
            //}

            //Console.WriteLine(sum/intArr.Length);


            ////task16

            //int[] intArr = new int[] { 1, 5, 9, 5 };

            //int min = intArr.Min();
            //int max = intArr.Max();

            //int positionOfMin = Array.IndexOf(intArr, min);
            //int positionOfMax = Array.IndexOf(intArr, max);

            //int temp = intArr[positionOfMin];
            //intArr[positionOfMin] = intArr[positionOfMax];
            //intArr[positionOfMax] = temp;

            //foreach (int value in intArr)
            //{
            //    Console.WriteLine(value);

            //}


            //// task17
            //Console.WriteLine("Enter the size:");
            //int size = int.Parse(Console.ReadLine());

            //int[] intArr1 = new int[size];
            //int[] intArr2 = new int[size];

            //Console.WriteLine("Enter the elements of 1st array:");

            //for (int i = 0; i < size; i++)
            //{
            //    intArr1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter the elements of 2nd array:");

            //for (int i = 0; i < size; i++)
            //{
            //    intArr2[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < size; i++)
            //{
            //    if (intArr1[i]> intArr2[i])
            //    {
            //        Console.WriteLine("Element in 1st array is greather");
            //    }
            //    else if(intArr1[i] < intArr2[i])
            //    {
            //        Console.WriteLine("Element in 2nd array is greather");
            //    } 
            //    else
            //    {
            //        Console.WriteLine("They're equal");    
            //    }
            //}


            ////task18
            //int[] intArr = new int[] { 1, 5, 9, 5 };

            //for (int i = 0; i < intArr.Length; i++)
            //{
            //    intArr[i] = intArr[i] * 2;
            //    Console.WriteLine(intArr[i]);
            //}


            ////task19

            //Console.WriteLine("Enter the size:");
            //int size = int.Parse(Console.ReadLine());

            //String[] arrayOfStrings = new String[size];


            //Console.WriteLine("Enter the strings:");
            //for (int i = 0; i < size; i++)
            //{
            //    arrayOfStrings[i] = Console.ReadLine();

            //}

            //Console.WriteLine("Enter the word you want to find");
            //string wordToFind  = Console.ReadLine();


            //foreach (string element in arrayOfStrings)
            //{
            //    if (element.Contains(wordToFind))
            //    {
            //        Console.WriteLine("Word {0} in word {1} begins from {2} char", wordToFind, element, element.IndexOf(wordToFind)+1);


            //    } 
            //    else
            //    {
            //        Console.WriteLine("Word {0} doesn't contain {1}", element, wordToFind);

            //    }


            //}


            ////task20

            //Console.WriteLine("Enter the size:");
            //int size = int.Parse(Console.ReadLine());

            //String[] arrayOfStrings = new String[size];


            //Console.WriteLine("Enter the strings:");
            //for (int i = 0; i < size; i++)
            //{
            //    arrayOfStrings[i] = Console.ReadLine();

            //}

            //Console.WriteLine("Enter the word you want to delete");
            //string wordToDelete = Console.ReadLine();

            //for (int i = 0; i < size; i++)
            //{
            //    if (arrayOfStrings[i].Contains(wordToDelete))
            //    {
            //        Console.WriteLine(   arrayOfStrings[i].Replace(wordToDelete, "")); 



            //    } else
            //    {
            //        Console.WriteLine("Word {0} doesn't contain {1}", arrayOfStrings[i], wordToDelete);

            //    }



            //}


            ////task21

            //int[] array = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Random r = new Random();



            //for (int i = array.Length; i > 0; i--)
            //{
            //    int j = r.Next(i);
            //    int k = array[j];
            //    array[j] = array[i - 1];
            //    array[i - 1] = k;
            //}

            //foreach (var item in array)
            //{

            //    Console.WriteLine( item);
            //}
        }
    }
}
