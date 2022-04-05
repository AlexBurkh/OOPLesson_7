﻿/*
 * 2. Создать класс Figure для работы с геометрическими фигурами. 
 * В качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое». 
 * Реализовать операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение цвета, опрос состояния (видимый/невидимый). 
 * Метод вывода на экран должен выводить состояние всех полей объекта. 
 * Создать класс Point (точка) как потомок геометрической фигуры. 
 * Создать класс Circle (окружность) как потомок точки. 
 * В класс Circle добавить метод, который вычисляет площадь окружности. 
 * Создать класс Rectangle (прямоугольник) как потомок точки, реализовать метод вычисления площади прямоугольника. 
 * Точка, окружность, прямоугольник должны поддерживать методы передвижения по горизонтали и вертикали, изменения цвета.
 */

using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[] 
            {
                new Point(5,5),
                new Circle(5,5,4,Color.blue,true),
                new Rectangle(6,6,4,3,Color.green,true),
            };

            Console.WriteLine("Вывод начального состояния (после создания объектов)");
            for (int i = 0; i < figures.Length; i++)
            {
                Console.WriteLine(figures[i]);
            }

            Console.WriteLine("Изменение координат");
            for (int i = 0; i < figures.Length; i++)
            {
                figures[i].MoveX(2);
                figures[i].MoveY(3);
            }

            Console.WriteLine("Вывод итогового состояния (после методов перемещения");
            for (int i = 0; i < figures.Length; i++)
            {
                Console.WriteLine(figures[i]);
            }

            Console.WriteLine("Изменение цвета");
            for (int i = 0; i < figures.Length; i++)
            {
                figures[i].ChangeColor(Color.magentayellow);
            }

            Console.WriteLine("Вывод итогового состояния (после методов изменения цвета");
            for (int i = 0; i < figures.Length; i++)
            {
                Console.WriteLine(figures[i]);
            }
        }
    }
}
