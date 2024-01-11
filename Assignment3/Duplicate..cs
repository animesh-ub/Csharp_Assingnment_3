//namespace Assignment3;
//using System.Collections.Generic;


//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter Element");
//        int size = int.Parse(Console.ReadLine());

//        int[] array = new int[size];

//        for (int i = 0; i < size; i++)
//        {
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int duplicate = Duplicates(array);
//        Console.WriteLine($"Total number of duplicate: {duplicate}");
//    }

//        static int Duplicates(int[] array)
//        {
//            int duplicateCount = 0;

//            Dictionary<int, int> elementFrequency = new Dictionary<int, int>();

//            foreach (var element in array)
//            {
//                if (elementFrequency.ContainsKey(element))
//                {
//                    elementFrequency[element]++;
//                }
//                else
//                {
//                    elementFrequency[element] = 1;
//                }
//            }

//            foreach (var frequency in elementFrequency.Values)
//            {
//                if (frequency > 1)
//                {
//                    duplicateCount += (frequency - 1);
//                }
//            }

//            return duplicateCount;
//        }
//    }
//}
