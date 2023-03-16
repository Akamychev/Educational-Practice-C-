task 1:

using System;

namespace ConsoleApplication3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Jewelery = Console.ReadLine();
            string Stouns = Console.ReadLine();

            char[] jew = Jewelery.ToCharArray(); //Перекидываем значения пользователя в массив символов
            char[] stoun = Stouns.ToCharArray();

            int result = 0;
            for (int i = 0; i < jew.Length; i++) //создаем двойной цикл для фильтрации массивов
            {
                for (int j = 0; j < stoun.Length; j++)
                {
                    if (jew[i] == stoun[j])
                    {
                        result++; //увеличиваем счетчик при каждом совпадении символа
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}


Task 2:

using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> Candidates = new List<int>() { 2, 5, 2, 1, 2 };
            int Target = 5;

            int Addition; //добавляем новую переменную для пересчета коллекции
            List<int> Combinations = new List<int>(); //добавляем новую коллекция для того,чтобы занести результат работы
            for (int i = 0; i < Candidates.Count; i++)
            {
                Addition = 0; //постоянное обнуление, чтобы код искал именно комбинацию чисел в массиве, а не просто перебирал цифры
                Combinations.Clear(); //постоянно очищаем от мусора коллекцию, в которую заносим конечный результат
                for (int j = 0; j < Candidates.Count; j++)
                {
                    if (i != j) //делаем перебор всей коллекции, дабы найти результат
                    {
                        Addition += Candidates[j]; 
                        Combinations.Add(Candidates[j]); //заносим результат в коллекцию
                    }

                    if (Addition > Target) 
                    {
                        break;
                    }
                    
                    if (Addition == Target)
                    {
                        for (int h = 0; h < Combinations.Count; h++)
                        {
                            Console.Write($"{Combinations[h]}");
                        }
                    }
                }
            }
        }
    }
}

Task 3:

using System;

namespace ConsoleApplication3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };

            bool check = false;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] == nums[j])
                        {
                            check = true;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(check);
        }
    }
}
