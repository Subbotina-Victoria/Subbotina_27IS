using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subbotina_27IS
{
    class Rectangle//прямоугольник
    {
        // Открытые поля для хранения высоты и ширины
        public double height;
        public double width;

        // Метод для показа данных о прямоугольнике
        public void Show()
        {
            Console.WriteLine($"Прямоугольник: высота = {height}, ширина = {width}");
        }

        // Метод расчета периметра прямоугольника
        // P = 2 * высота + 2 * ширина
        public double Perimetr()
        {
            double p = 2 * height + 2 * width;
            return p;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаем объект класса Rectangle
            Rectangle rect = new Rectangle();

            // 2. Задаем значения полям объекта
            rect.height = 2;
            rect.width = 3;

            // 3. Выводим на экран данные объекта
            rect.Show();

            // 4. Рассчитываем периметр и выводим его на экран
            double perimetr = rect.Perimetr();
            Console.WriteLine($"Периметр прямоугольника = {perimetr}");

            Console.ReadKey();
        }
    }

}
