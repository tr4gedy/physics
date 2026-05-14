using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace prct.Features
{
    public class General
    {
        /// <summary>
        /// Логика валидации отрицательного числа
        /// </summary>
        public static bool isNegative(double value)
        {
            if (value < 0)
            {
                MessageBox.Show("Число не должно быть отрицательными.");
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Логика валидации числа на наличие значения
        /// </summary>
        public static bool isNull(double val)
        {
            if (val == null)
            {
                MessageBox.Show("Введите значение.");
                return true;
            }
            return false;
        }
        /// <summary>
        /// Логика валидации числа на наличие значения
        /// </summary>
        public static bool isZero(double val)
        {
            if (val == 0)
            {
                MessageBox.Show("Число не может быть нулем.");
                return true;
            }
            return false;
        }
        /// <summary>
        /// Логика валидации отсутсвия названия
        /// </summary>
        public static bool isEmptyName(string name) {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Название не может быть пустым");
                return true;
            }
            return false;
        }
        /// <summary>
        /// Логика валидации превышаюшего размера текста
        /// </summary>
        public static bool isOverMaxLength(string str, int maxLenght)
        {
            if (str.Length > maxLenght)
            {
                MessageBox.Show($"Название не может быть больше {maxLenght} символов");
                return true;
            }
            return false;
        }
    }
}
