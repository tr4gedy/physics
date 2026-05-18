namespace prct.Features
{
    
    public class Validation
    {
        /// <summary>
        /// Логика валидации отрицательного числа
        /// </summary>
        public static bool isNegative(double value)
        {
            if (value < 0)
            {
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
            string err;
            if (val == null)
            {
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
        public static bool isZero(double val)
        {
            if (val == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Логика валидации отсутсвия названия
        /// </summary>
        public static bool isEmptyName(string str)
        {
            string err;
            if (string.IsNullOrWhiteSpace(str))
            {
                return true;
            }
            else { 
                return false;
            }
        }
        /// <summary>
        /// Логика валидации превышаюшего размера текста
        /// </summary>
        public static bool isOverMaxLength(string str, int maxLenght)
        {
            if (str.Length > maxLenght)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
