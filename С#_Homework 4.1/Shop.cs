using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С__Homework_4._1
{
    internal class Shop
    {
        private string name;
        private string address;
        private string descript;
        private double number;
        private string email;
        private int area;


        public Shop() : this("АТБ", "Ген. Бочарова, 57", "Продуктовый магазин", 0933371435, "www.atbmarket.com", 980)
        {

        }

        public Shop(string n, string ad, string d, double num, string e, int ar)
        {
            name = n;
            address = ad;
            descript = d;
            number = num;
            email = e;
            area = ar;
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

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                if (value != "")
                {
                    address = value;
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

        public int Area
        {
            get
            {
                return area;
            }
            set
            {
                area = (value < 100) ? area : value;
            }
        }

        // ПЕРЕГРУЗКИ ОПЕРАЦИЙ
        public static Shop operator +(Shop a, int b)
        {
            Shop result = new()
            {
                area = a.area + b
            };
            return result;
        }

        public static Shop operator -(Shop a, int b)
        {
            Shop result = new()
            {
                area = a.area - b
            };
            return result;
        }

        public override bool Equals(object? a)
        {
            Shop temp = (Shop)a;
            if (area == temp.area)
                return true;
            else
                return false;
        }

        public static bool operator ==(Shop a, Shop b)
        {
            if (a.Equals(b))
                return true;
            else
                return false;
        }

        public static bool operator !=(Shop a, Shop b)
        {
            if (a.area != b.area)
                return true;
            else
                return false;
        }

        public static bool operator <(Shop a, Shop b)
        {
            if (a.area < b.area)
                return true;
            else
                return false;
        }

        public static bool operator >(Shop a, Shop b)
        {
            if (a.area > b.area)
                return true;
            else
                return false;
        }

        //public void PrintState()		
        //{
        //    Console.WriteLine("Название магазина: {0}", Name);
        //    Console.WriteLine("Адрес: {0}", Address);
        //    Console.WriteLine("Описание профиля магазина: {0}", Descript);
        //    Console.WriteLine("Контактный телефон: {0}", Number);
        //    Console.WriteLine("Контактный e-mail: {0}", Email);
        //    Console.WriteLine("Площадь магазина: {0}", Area);
        //}
    }
}
