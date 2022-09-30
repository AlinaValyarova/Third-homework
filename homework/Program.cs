using System;

namespace homework
{
    class Program
    {
        public static void Main(string[] args)
        {
            ex12();
        }

        static void ex1()
        {
            Console.WriteLine("Вася пытается высунуть голову в форточку размерами a и b см." +
                " Приняв условно, что его голова — круглая диаметром d см, определить, сможет ли Вася сделать это. " +
                "Для прохождения головы в форточку необходим зазор в 1 см с каждой стороны.");
            Console.WriteLine("Enter side of the window");
            int side = Convert.ToInt32(Console.ReadLine());
            int area = (side + 1) * (side + 1);
            Console.WriteLine("Enter diameter of head");
            int dm = Convert.ToInt32(Console.ReadLine());
            double circle = (dm / 2) * (dm / 2) * Math.PI;
            if (circle < area)
            {
                Console.WriteLine("Yes, he will be able to put his head through the window");
            }
            else
            {
                Console.WriteLine("No, he won't be able to put his head througn the window");
            }
        }

        static void ex2()
        {
            Console.WriteLine("Напечатать таблицу умножения на число n (значение n вводится с клавиатуры; 1 <= n <= 9).");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            for (i = 0; i < 11; i++)
            {
                Console.WriteLine(n + " * " + i + " = " + n * i);
            }
        }

        static void ex3()
        {
            Console.WriteLine("Создайте программу, которая принимает на вход число и возвращает:" +
                "- “Бэнг” -если число делится на 3" +
                "- “Бум” -если число делится на 5" +
                "- “БэнгБум” -если число делится и на 3, и на 5" +
                "- “Мимо” -в остальных случаях." +
                "Примечание: программа выводит только что - то одно.");
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 3 == 0 && num % 5 != 0)
            {
                Console.WriteLine("Bang");
            }
            while (num % 5 == 0 && num % 3 != 0)
            {
                Console.WriteLine("Boom");
            }
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("BangBoom");
            }
            else
            {
                Console.WriteLine("pass");
            }
        }

        static void ex4()
        {
            Console.WriteLine("Проверить, введена ли с консоли строка ВСЕМИ ЗАГЛАВНЫМИ БУКВАМИ.");
            Console.WriteLine("Enter a text");
            string text = Console.ReadLine();
            string text2 = text.ToUpper();
            bool result = text.Equals(text2);
            Console.WriteLine("Entered text is in upper case is " + result);
        }

        static void ex5()
        {
            Console.WriteLine("Пользователь вводит в консоль положительное целое число, " +
                "(например, 3) вывести строку по шаблону: 1 овца… 2 овца… 3 овца…");
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            for (i = 1; i <= num; i++)
            {
                Console.WriteLine(i + " Sheep...");
            }
        }

        static void ex6()
        {
            Console.WriteLine("Обязательно использовать try-catch-(finally). Дана непустая последовательность неотрицательных целых чисел," +
                " оканчивающаяся отрицательным числом.Найти среднее арифметическое всех чисел последовательности" +
                "(без учета отрицательного числа).");
            try
            {
                Console.WriteLine("Enter number of elements");
                int el = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[el];
                int i = 0;
                int j = 0;
                int sum = 0;
                Console.WriteLine("Enter numbers through enter");
                do
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    i += 1;
                }
                while (i < el);
                for (j = 0; j < (arr.Length - 1); j++)
                {
                    sum += arr[j];
                }
                Console.WriteLine(sum);
            }

            catch
            {
                Console.WriteLine("Try again!");
            }


        }
        enum cards
        {
            Туз = 14,
            Король = 13,
            Дама = 12,
            Валет = 11,
            Десятка = 10,
            Девятка = 9,
            Восьмерка = 8,
            Семерка = 7,
            Шестерка = 6,
        }
        static void ex7()
        {
            Console.WriteLine("Обязательно использовать try-catch-(finally). " +
                "Игральным картам условно присвоены следующие порядковые номера в зависимости от их достоинства: " +
                "«валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14." +
                "Порядковые номера остальных карт соответствуют их названиям(«шестерка», «девятка» и т.п.)." +
                "По заданному номеру карты k(6 <= k <= 14) определить достоинство соответствующей карты.");

            Console.WriteLine("Enter a number");
            int k = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("Your card is: " + Enum.GetName(typeof(cards), k));
            }
            catch
            {
                Console.WriteLine("Wrong enter! Try again.");
            }
        }

        static void ex8()
        {
            Console.WriteLine("Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента " +
                "'Hello Kitty' или  'Barbie doll' необходимо положить их в “сумку”, " +
                "т.е. прибавить к результату. Вывести на экран сколько кукол в 'сумке'.");
            string[] bag = new string[6] { "Lipstick", "Hello Kitty", "Mirror", "Barbie Doll", "Hello Kitty", "Hello Kitty" };
            int h = 0;
            int b = 0;
            foreach (string a in bag)
            {
                if (a == "Hello Kitty")
                {
                    h += 1;
                }
                else if (a == "Barbie Doll")
                {
                    b += 1;
                }


            }
            Console.WriteLine("There are " + h + " Hello Kitty " + b + " Barbie Doll in the bag");

        }
        enum Days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Satarday = 6,
            Sunday = 7,
        }
        static void ex9()
        {
            Console.WriteLine(" Составить программу, которая в зависимости от порядкового номера дня недели" +
                "(1, 2, ..., 7) выводит на экран его название(понедельник, вторник, ..., воскресенье).Использовать enum.");
            Console.WriteLine("Enter number of the day");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your day is: " + Enum.GetName(typeof(Days), num));
        }

        static int[] BubbleSort(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        int a= mas[i];
                        mas[i] = mas[j];
                        mas[j] = a ;

                    }
                }
            }
            return mas;
        }

        static void ex10()
        {
            Console.WriteLine("Отсортировать массив по возрастанию при помощи “пузырька”, встроенных методов и кортежей.");
            int[] arr = { 2, 23, 84, 6, 7, 45, 1, 4, 3 };
            BubbleSort(arr);
            Console.WriteLine("After sorting:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();


        }

        static void ex11()
        {
            Console.WriteLine("Дана последовательность из 10 чисел. " +
                "Определить, есть ли эта последовательность упорядоченной по возрастанию. " +
                "В случае отрицательного ответа определить порядковый номер первого числа, которое нарушает данную последовательность. " +
                "Использовать break. ");
            int[] nums = new int[10];
            Console.WriteLine("Enter 10 number through enter");
            nums[0] = Convert.ToInt32(Console.ReadLine());
            nums[1] = Convert.ToInt32(Console.ReadLine());
            nums[2] = Convert.ToInt32(Console.ReadLine());
            nums[3] = Convert.ToInt32(Console.ReadLine());
            nums[4] = Convert.ToInt32(Console.ReadLine());
            nums[5] = Convert.ToInt32(Console.ReadLine());
            nums[6] = Convert.ToInt32(Console.ReadLine());
            nums[7] = Convert.ToInt32(Console.ReadLine());
            nums[8] = Convert.ToInt32(Console.ReadLine());
            nums[9] = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            int i = 0;
            do
            {
                if (i > 0 && nums[i] < nums[i - 1])
                {
                    flag = false;
                    break;
                }
            } while (i++ < 9);
            Console.WriteLine(flag ? "\nRight order" : $"\nWrong order, number: {i + 1}");

        }
        public struct student
        {
            public string name;
            public DateTime Birthdate;
        }
        public static void ex12()
        {
            Console.WriteLine("Создать структуру студента с датой рождения, вывести сколько ему лет сейчас");
            student student1 = new student();
            Console.WriteLine("Enter your year");
            student1.name = Console.ReadLine();
            Console.WriteLine("Enter your date of birth in a format DD/MM/YYYY");
            student1.Birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Student's age: " + (DateTime.Now.Year - student1.Birthdate.Year));

        }


    }
    }



