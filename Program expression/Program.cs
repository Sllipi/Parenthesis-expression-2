using System;
using System.Collections.Generic;
using System.Text;

namespace Parenthesis_expression_2
{
    class Program_expression
    {
        static void Work()
        {
            Console.WriteLine();
            Console.WriteLine("Введите скобочки!)))");
            var str = Console.ReadLine();
            var num = 0;
            var counter = 0;
            var list = new List<int>();
            if (str.Length == 0)
            {
                Console.WriteLine("Вы не ввели скобки!");
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    num++;
                }
                else if (str[i] == ')')
                {
                    if (str[i + 1] == '(' && str[i - 1] != str.Length - 1)
                    {
                        counter++;
                    }
                    num--;
                }
                if (num == 0)
                {
                    list.Add(counter);
                    counter--;
                }
            }
            if (num == 0)
            {
                Console.WriteLine("Корректных скобочек = " + (list[list.Count - 1] + 1));
            }
            else
            {
                Console.WriteLine("Вы ввели не верное значение!");
            }

        }
    }
}
