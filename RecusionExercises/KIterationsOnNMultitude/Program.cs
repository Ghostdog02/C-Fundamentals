using System;
using System.Collections.Generic;
using System.Linq;

namespace KIterationsOnNMultitude
{
    public class Program
    {
        private static int currentLoop = 1;
        private static int numberOfLoops = 0;
        private static int numberOfIterations = 0;
        private static int[] loops;

        static void Main(string[] args)
        {
            numberOfLoops = 2;
            numberOfIterations = 3;
            loops = new int[numberOfLoops];
            NestedLoops(0, 1);
        }


        static void NestedLoops(int currentLoop, int start)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintNumber(numberOfLoops);
                return;
            }

            for (int i = start; i <= numberOfIterations; i++)
            {
                loops[currentLoop] = i;
                NestedLoops(currentLoop + 1, i);
            }
        }

        static void PrintNumber(int numberOfLoops)
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write($"{loops[i]} ");
            }
            Console.WriteLine();
        }

        //static void GetPermutations(List<int> elementsOutOfTheBag, int[] elementsInTheBag)
        //{
        //    //if (length == 1) return list.Select(t => new T[] { t });

        //    //return GetPermutations(list, length - 1)
        //    //    .SelectMany(t => list.Where(e => !t.Contains(e)),
        //    //        (t1, t2) => t1.Concat(new T[] { t2 }));
        //    //if (elementsInTheBag.Length == 0)
        //    //{
        //    //    return;
        //    //}

        //    //else
        //    //{
        //    //    foreach (var digit in elementsInTheBag)
        //    //    {
        //    //        List<int> newBag = elementsInTheBag.ToList().Where(e => e != digit).ToList();
        //    //        elementsOutOfTheBag.Add(digit);
        //    //        GetPermutations(elementsOutOfTheBag, newBag.ToArray());
        //    //    }

        //    //}

        //}

        //static void GetCombinations(int[] arr, int index, int start, int end)
        //{
        //    if (index >= arr.Length)
        //    {
        //        Console.Write("(");
        //        for (int i = 0; i < arr.Length; i++)
        //            if (i < arr.Length - 1) Console.Write("{0} ", arr[i]);
        //            else Console.Write(arr[i]);
        //        Console.Write("), ");
        //    }

        //    else
        //    {
        //        for (int i = start; i <= end; i++)
        //        {
        //            arr[index] = i;
        //            GetCombinations(arr, index + 1, i, end);
        //        }
        //    }

        //}
    }
}
