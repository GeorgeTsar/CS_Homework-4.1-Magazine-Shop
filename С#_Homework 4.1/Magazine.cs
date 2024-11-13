using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace С__Homework_4._1
{
    internal class Magazine
    {
        private string name;
        private int year;
        private string descript;
        private double number;
        private string email;
        private int employees;


        public Magazine() : this("Вокруг света", 1861, "Научно-популярный географический журнал", 2685214, "vokrugsveta@sholding.ru", 100)
        {

        }

        public Magazine(string n, int y, string d, double num, string e, int empl)
        {
            name = n;
            year = y;
            descript = d;
            number = num;
            email = e;
            employees = empl;
        }

        public string Name
        {
            get 
            { 
                return name; 
            }
            set
            {
                if (value != "")
                {
                    name = value;
                }
            }
        }

        public int Year
        {
            get 
            { 
                return year; 
            }
            set
            {
                if (value > 0)
                {
                    year = value;
                }
            }
        }

        public string Descript
        {
            get
            {
                return descript;
            }
            set
            {
                if (value != "")
                {
                    descript = value;
                }
            }
        }

        public double Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value != "")
                {
                    email = value;
                }
            }
        }

        public int Employees
        {
            get
            {
                return employees;
            }
            set
            {
                employees = (value < 10) ? employees : value;
            }
        }

        // ПЕРЕГРУЗКИ ОПЕРАЦИЙ
        public static Magazine operator + (Magazine a, int b)
        {
            Magazine result = new()
            {
                employees = a.employees + b
            };
            return result;
        }

        public static Magazine operator - (Magazine a, int b)
        {
            Magazine result = new()
            {
                employees = a.employees - b
            };
            return result;
        }

        public override bool Equals(object? a)
        {
            Magazine temp = (Magazine)a;
            if (employees == temp.employees)
                return true;
            else
                return false;
        }

        public static bool operator ==(Magazine a, Magazine b)
        {
            if (a.Equals(b))
                return true;
            else
                return false;
        }

        public static bool operator !=(Magazine a, Magazine b)
        {
            if (a.employees != b.employees)
                return true;
            else
                return false;
        }

        public static bool operator < (Magazine a, Magazine b)
        {
            if (a.employees < b.employees)
                return true;
            else
                return false;
        }

        public static bool operator > (Magazine a, Magazine b)
        {
            if (a.employees > b.employees)
                return true;
            else
                return false;
        }

        //public void PrintState()		
        //{
        //    Console.WriteLine("Название журнала: {0}", Name);
        //    Console.WriteLine("Год основания: {0}", Year);
        //    Console.WriteLine("Описание журнала: {0}", Descript);
        //    Console.WriteLine("Контактный телефон: {0}", Number);
        //    Console.WriteLine("Контактный e-mail: {0}", Email);
        //    Console.WriteLine("Количество сотрудников: {0}", Employees);
        //}
    }
}



