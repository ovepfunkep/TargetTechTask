using static TargetTechTask.Utils.Coins;

namespace TargetTechTask
{
    public static class Functions
    {
        /*
         * 1. Напишите функцию, которая в качестве аргумента принимает натуральное число n и возвращает сумму цифр этого числа.
         * Если это значение имеет более одной цифры, продолжайте уменьшать его таким образом, пока не будет получено одноразрядное число.
         * Это применимо только к натуральным числам. 
         */
        public static int GetNumberDigitsSum(int digit)
        {
            digit = Math.Abs(digit);

            if (digit < 10) return digit;
            
            return GetNumberDigitsSum(digit.ToString().Select(c => c - '0').Sum());
        }

        /*
         * 2. Напишите функцию, которая принимает количество американской валюты центы (cents) и возвращает словарь / хэш,
         * который показывает наименьшее количество монет, используемых для создания этой суммы. 
         * Рассматриваются только номиналы монет: Pennies (1¢), Nickels (5¢), Dimes (10¢) and Quarters (25¢). 
         * Поэтому возвращаемый словарь должен содержать ровно 4 пары ключ / значение.
         */
        public static Dictionary<string, int> GetCoinsFromValue(double money)
        {
            Coin[] possibleCoins = Enum.GetValues<Coin>();

            Dictionary<Coin, int> coins = possibleCoins.Select(c => new KeyValuePair<Coin, int>(c, 0))
                                                       .ToDictionary();

            int iMoney = Convert.ToInt32(Math.Floor(money));

            IEnumerator<Coin> coinEnumerator = possibleCoins.OrderByDescending(c => (int)c).GetEnumerator();
            while (iMoney > 0)
            {
                if (!coinEnumerator.MoveNext()) break;

                Coin coin = coinEnumerator.Current;
                
                int coinCount = iMoney / (int)coin;
                coins[coin] += coinCount;
                iMoney %= (int)coin;
            }

            return coins.Select(c => new KeyValuePair<string, int>(c.Key.ToString(), c.Value)).ToDictionary();
        }

        /*
         * 3. Напишите функцию, которая может принимать любое неотрицательное целое число в качестве аргумента и 
         * возвращать его вместе с цифрами в порядке убывания. Переставьте цифры так, чтобы на выходе создать максимально возможное число.
         */
        public static int GetSortedByDigitsNumber(int number) =>
            number > 0 ? Convert.ToInt32(string.Concat(number.ToString().OrderByDescending(c => c - '0')))
                       : throw new ArgumentException("Number must be positive like this smile face => :)");

        /*
         * 4. Дана бесконечная пирамида чисел:
         *               1
         *            3     5
         *         7     9    11
         *     13    15    17    19
         *  21    23    25    27    29
         *  ...
         *  Напишите функцию, которая вычисляет сумму строки этого треугольника из переданного в функцию индекса строки (начиная с индекса 1).
         *  Пример: 	my_function (2) => 3 + 5 = 8
         */
        public static int GetPyramidRowValuesSum(int rowNumber)
        {
            if (rowNumber <= 0) throw new ArgumentException("Pyramid doesn't have negative rows...");

            int firstNum = Enumerable.Range(0, rowNumber).Sum() + 2;

            return Enumerable.Range(0, rowNumber)
                             .Select(i => firstNum + 2 * i)
                             .Sum();
        }

        /*
         * 5.Как на счет функции, которая не принимает аргументов и всегда возвращает 5? 
         * Звучит просто, не правда ли? Просто имейте в виду, что вы не можете использовать ни один из следующих символов: 
         * 0 1 2 3 4 5 6 7 8 9 * + - /
         * Напишите несколько реализаций такой функции использующих разный подход к задаче.
         */
        public static int GetFiveBySymbolPosition() => "ABCDEF".IndexOf('F');
        public static int GetFiveByLength() => "ABCDE".Length;
        public static int GetFiveByFileRead() => Convert.ToInt32(File.ReadAllText("NothingSuspiciousHere.txt"));
    }
}
