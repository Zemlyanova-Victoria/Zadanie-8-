using System;
using static System.Console;
using System.Collections.Generic;
using static System.Convert;
using Studentlib;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введи дату: ");
            WriteLine("День: ");
            int day = ToInt32(ReadLine());
            WriteLine("Месяц: ");
            int month = ToInt32(ReadLine());
            WriteLine("Год: ");
            int year = ToInt32(ReadLine());

            Class1 a = new Class1();
            int n = 1;
            while (n > 0)
            {
                WriteLine("1 - Добавить студента.\n2 - Изменить данные о студенте.\n3 - Удалить студента.\n4 - Вывод всех студентов.");

                 n = ToInt32(ReadLine());
                if (n == 1)
                {
                    WriteLine("1 - Вся информация о студентах.\n2 - Список студентов с инициалами.\n3 - Список студентов старше 18.\n4 - Список студентов младше 18.");
                    int m = ToInt32(ReadLine());
                    if (m == 1)
                    {
                        a.show();
                    }
                    else if (m == 2)
                    {
                        a.initials();
                    }
                    else if (m == 3)
                    {
                        a.Vozrast(m, day, month, year);
                    }
                    else if (m == 4)
                    {

                        a.Vozrast(m, day, month, year);
                    }
                    WriteLine("Введи действие: ");
                }
                else if (n == 2)
                {

                    WriteLine("ID: "); string Id = ReadLine();

                    WriteLine("ФИО: "); string FIO = ReadLine();

                    WriteLine("Группа: "); string Group = ReadLine();

                    WriteLine("Дата: "); string Data = ReadLine();

                    a.add(Id, FIO, Group, Data);

                    WriteLine("Введи действие: ");
                }
                else if (n == 4)
                {
                    WriteLine("Введи ID и измененные данные: ");

                    WriteLine("ID: "); string Id = ReadLine();

                    WriteLine("ФИО: "); string FIO = ReadLine();

                    WriteLine("Группа: "); string Group = ReadLine();

                    WriteLine("Дата: "); string Data = ReadLine();

                    a.change(Id, FIO, Group, Data);

                    WriteLine("Введи действие: ");
                }
                else if (n == 3)
                {
                    WriteLine("Введи ID: ");

                    string Id = ReadLine();

                    a.remov(Id);

                    WriteLine("Введи действие: ");
                }
                else if (n == 5)
                {
                    WriteLine("1 - поиск по ID.\n2 - поиск по фамилии\n");
                    int m = ToInt32(ReadLine());
                    if (m == 1)
                    {
                        WriteLine("Введи ID: ");
                        string Id = ReadLine();
                        a.initials();
                    }
                    else if (m == 2)
                    {
                        WriteLine("Введи фамилию: ");
                        string famil = ReadLine();
                        a.surname(famil);
                        WriteLine("Введи действие: ");
                    }
                    else if (n == 6)
                    {
                        Environment.Exit(0);
                    }
                }
            }

        }
    }
}
