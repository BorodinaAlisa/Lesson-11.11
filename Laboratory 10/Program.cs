using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Laboratory_10.Coordinates;

namespace Laboratory_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 10.1.Создать интерфейс ICipher, который определяет методы поддержки шифрования строк. В интерфейсе объявляются два метода encode() и decode(), которые используются для шифрования и дешифрования строк, соответственно. Создать класс ACipher, реализующий интерфейс ICipher. Класс шифрует строку посредством сдвига каждого символа на одну «алфавитную» позицию выше. Например, в результате такого сдвига буква А становится буквой Б. Создать класс BCipher, реализующий интерфейс ICipher. Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й позиции, на букву того же регистра, расположенную в алфавите на i-й позиции с конца алфавита. Например, буква В заменяется на букву Э. Написать программу,демонстрирующую функционирование классов.");
            ACipher aCipher = new ACipher();
            BCipher bCipher = new BCipher();
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            string encodedText1 = aCipher.Encode(text);
            string decodedText1 = aCipher.Decode(encodedText1);
            string encodedText2 = bCipher.Encode(text);
            string decodedText2 = bCipher.Decode(encodedText2);
            Console.WriteLine("ACipher:");
            Console.WriteLine("Оригинальный текст: " + text);
            Console.WriteLine("Закодированный текст: " + encodedText1);
            Console.WriteLine("Расшифрованный текст: " + decodedText1);
            Console.WriteLine("BCipher:");
            Console.WriteLine("Оригинальный текст: " + text);
            Console.WriteLine("Закодированный текст: " + encodedText2);
            Console.WriteLine("Расшифрованный текст: " + decodedText2);
            Console.WriteLine("Домашнее задание 10.1.Создать класс Figure для работы с геометрическими фигурами. В качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое». Реализовать операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение цвета, опрос состояния (видимый/невидимый). Метод вывода на экран должен выводить состояние всех полей объекта. Создать класс Point (точка) как потомок геометрической фигуры. Создать класс Circle (окружность) как потомок точки. В класс Circle добавить метод, который вычисляет площадь окружности. Создать класс Rectangle (прямоугольник) как потомок точки, реализовать метод вычисления площади прямоугольника. Точка,окружность, прямоугольник должны поддерживать методы передвижения по горизонтали и вертикали, изменения цвета. Подумать, какие методы можно объявить в интерфейсе, нужно ли объявлять абстрактный класс, какие методы и поля будут в абстрактном классе, какие методы будут виртуальными, какие перегруженными.");
            Coordinates coord = new Coordinates();
            coord.X = 0;
            coord.Y = 0;
            Point point = new Point(Color.Красный, State.Видимое, coord);
            point.Print();
            point.MoveVert(3);
            point.MoveHoriz(4);
            point.Print();
            int radius = 3;
            Circle circle = new Circle(Color.Синий, State.Видимое, coord, radius);
            circle.Print();
            Console.ReadKey();



        }
    }
}
