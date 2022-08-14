namespace CSharpLessons
{   
    class MyProgram
    {
        readonly static string[] TaskText = {
            "Задача 41: " +
                "Вам нужно ввести с клавиатуры N чисел в одну линию, " +
                "\nЧисла должны разделены пробелами. Программа посчитает, сколько чисел больше 0 вы ввели.",
            "Задача 43: " +
                "Программа найдет точку, которая является пересечением двух прямых, " +
                "\nзаданных уравнениями: " +
                "\ny = k1 * x + b1, " +
                "\ny = k2 * x + b2; " +
                "\nзначения b1, k1, b2 и k2 задаются пользователем."
        };

        private static bool MyRead(out int result, string whatToRead = "целое число")
        {
            Console.Write($"Введите {whatToRead}: ");
            string _temp = Console.ReadLine();
            return (Int32.TryParse(_temp, out result));
        }

        private static bool MyRead(out double result, string whatToRead = "дробное число")
        {
            Console.Write($"Введите {whatToRead}: ");
            string _temp = Console.ReadLine();
            return (Double.TryParse(_temp, out result));
        }

        private static int TaskOne()
        {
            Console.Write("Введите числа: ");
            return Array.ConvertAll(Console.ReadLine().Split(), S => double.Parse(S)).Count(_temp => _temp > 0);
        }

        private static double[] TaskTwo()
        {
            double[] _result = { 0, 0 };
            if (MyRead(out double k1, "коефициент k1"))
            {
                if (MyRead(out double k2, "коефициент k2") && k2 != k1)
                {
                    if (MyRead(out double b1, "коефициент b1"))
                    {
                        if (MyRead(out double b2, "коефициент b2"))
                        {
                            _result[0] = (b2 - b1) / (k1 - k2);
                            _result[1] = (b2 * k1 - b1 * k2) / (k1 - k2);
                        }
                    }
                }
            }
            return _result;
        }

        static void Main(string[] args)
        { 
            if (MyRead(out int taskNumber, "номер задачи"))
            {
                Console.WriteLine();

                Console.WriteLine(TaskText[taskNumber - 1] + "\n");
                Console.WriteLine();

                switch (taskNumber)
                {
                    case 1:
                        double _result = MyProgram.TaskOne();
                        Console.WriteLine($"Результат: {_result}.");
                        break;
                    case 2:
                        double[] _result2 = MyProgram.TaskTwo();
                        Console.WriteLine($"Результат: [{_result2[0]}, {_result2[1]}].");
                        break;
                    default:
                        Console.WriteLine("Нет такой задачи!");
                        break;
                }
            }

            Console.Write("Для продолжения нажмите ввод...");
            Console.ReadLine();
        }
    }
}