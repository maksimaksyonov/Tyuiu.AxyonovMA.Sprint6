// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task0.V6.Lib
// Description: Расчёт выражения y(x) = x / sqrt(x^2 + x) (Вариант 6)

using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AxyonovMA.Sprint6.Task0.V6.Lib
{
    public class DataService : ISprint6Task0V6
    {
        // Сигнатура строго как в интерфейсе: int x
        public double Calculate(int x)
        {
            double denom = Math.Sqrt(x * x + x);

            if (denom == 0)
            {
                return 0; // защита от деления на ноль
            }

            double y = x / denom;

            // округление до 3 знаков
            return Math.Round(y, 3);
        }
    }
}
