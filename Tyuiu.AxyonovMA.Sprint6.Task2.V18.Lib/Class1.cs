// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task2.V18.Lib
// Description: Табулирование функции (Вариант 18)

using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AxyonovMA.Sprint6.Task2.V18.Lib
{
    public class DataService : ISprint6Task2V18
    {
        // Возвращает массив значений функции на [startValue; stopValue] с шагом 1
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] y = new double[len];

            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 4 * x - 0.5;
                double value;

                if (denominator == 0)
                {
                    value = 0;              // защита от деления на ноль
                }
                else
                {
                    value = (3 * Math.Cos(x)) / denominator
                            + Math.Sin(x)
                            - 5 * x
                            - 2;
                }

                y[index] = Math.Round(value, 2); // округление до 2 знаков
                index++;
            }

            return y;
        }
    }
}
