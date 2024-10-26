using static TargetTechTask.Utils.Coins;

namespace TargetTechTask
{
    public static class Functions
    {
        public static int GetNumberDigitsSum(int digit)
        {
            digit = Math.Abs(digit);

            if (digit < 10) return digit;
            
            return GetNumberDigitsSum(digit.ToString().Select(c => c - '0').Sum());
        }

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

        public static int GetSortedByDigitsNumber(int number) =>
            number > 0 ? Convert.ToInt32(string.Concat(number.ToString().OrderByDescending(c => c - '0')))
                       : throw new ArgumentException("Number must be positive like this smile face => :)");

        public static int GetPyramidRowValuesSum(int rowNumber)
        {
            if (rowNumber <= 0) throw new ArgumentException("Pyramid doesn't have negative rows...");

            int firstNum = Enumerable.Range(0, rowNumber).Sum() + 2;

            return Enumerable.Range(0, rowNumber)
                             .Select(i => firstNum + 2 * i)
                             .Sum();
        }

        public static int GetFiveBySymbolPosition() => "ABCDEF".IndexOf('F');
        public static int GetFiveByLength() => "ABCDE".Length;
        public static int GetFiveByFileRead() => Convert.ToInt32(File.ReadAllText("NothingSuspiciousHere.txt"));
    }
}
