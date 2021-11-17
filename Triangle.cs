using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_form1
{
    class Triangle
    {
        public double a; // первая сторона
        public double b; // вторая сторона
        public double c; // третья сторона
        public double h; // высота

        public Triangle(double A, double B, double C) // Конструктор
        {
            a = A; // Создаем с заданными линиями сторон согласно заданию
            b = B;
            c = C;
        }

        public string outputA() // выводим сторону а, данный метод возвращает стровое значение
        {
            return Convert.ToString(a); // a - ссылка на внутреннее поле обьекта класса
        }

        public string outputB()
        {
            return Convert.ToString(b); // выводим сторону b
        }

        public string outputC() //выводим сторону c
        {
            return Convert.ToString(c);
        }

        public double Perimeter() // Сумма всех сторон типа double
        {
            double p = 0;
            p = a + b + c; // вычитание...
            return p; // возврат
        }

        public double Surface() // аналогичер периметру..
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }

        public double GetSetA // свойство позволяющее установить либо изменить значение стороны a
        {
            get // устанавливаем...
            { return a; }
            set // меняем...
            { a = value; }
        }

        public double GetSetB // свойство позволяющее установить либо изменить значение стороны b
        {
            get
            { return b; }
            set
            { b = value; }
        }

        public double GetSetC // свойство позволяющее установить либо изменить значение стороны c
        {
            get
            { return c; }
            set
            { c = value; }
        }

        public bool ExistTriangle // свойство позволяющее установить, существует ли треугольник с заданными сторонами
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b)) // сумма 2 сторон должна быть больше третьей
                    return false;
                else return true;
            }
        }

        public Triangle(double A, double H) // Конструктор нумбер какс
        {
            a = A;
            h = H;
        }

        public string outputAA() // выводим сторону h, данный метод возвращает стровое значение
        {
            return Convert.ToString(a); // h - ссылка на внутреннее поле обьекта класса
        }

        public string outputH() // выводим сторону h, данный метод возвращает стровое значение
        {
            return Convert.ToString(h); // h - ссылка на внутреннее поле обьекта класса
        }

        public double GetSetAA // свойство позволяющее установить либо изменить значение стороны h
        {
            get // устанавливаем...
            { return a; }
            set // меняем...
            { a = value; }
        }

        public double GetSetH // свойство позволяющее установить либо изменить значение стороны h
        {
            get // устанавливаем...
            { return h; }
            set // меняем...
            { h = value; }
        }
        public double square()
        {
            double S = Math.Round((a * h) / 2, 2);
            
            return S;
        }

        public double area()
        {
            double t = Math.Sqrt(a * a) + Math.Sqrt(h * h);
            double P = 2 * t + 2 * a;
            return P;
        }

        public double osnov()
        {
            double os = Math.Sqrt(a * a - h * h);
            os = Math.Pow((os / 2), 2);

            return os;
        }

        public string TriangleType // свойство позволяющее установить, существует ли треугольник с заданными сторонами
        {
            get
            {
                if (ExistTriangle)
                {
                    if (a == b && a == c) // сумма 2 сторон должна быть больше третьей
                    {
                        return "равносторонний";
                    }
                    else if ((c == b && c != a) || (c == a && b != c))
                    {
                        return "равнобедренный";
                    }
                    else
                    {
                        return "разносторонний";
                    }
                }
                else
                {
                    return "ломанная";
                }                
            }
        }
    }
}
