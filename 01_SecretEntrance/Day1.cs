namespace _01_SecretEntrance
{
    public class Day1
    {
        private readonly string[] _lines;

        public Day1(string input)
        {

            _lines = input.Split("\n",options: StringSplitOptions.RemoveEmptyEntries);
        }
        
        private static int ModPos(int x, int m)
        {
            return (x % m + m) % m;
        }
        public int Calculate(int start = 50)
        {
            var countZero = 0;
            foreach (var line in _lines)
            {
                var operand = line[..1].ToLower();
                var number = Convert.ToInt32(line[1..]);

                if (operand == "r")
                {
                    start += number;
                }
                else if (operand == "l")
                {
                    start -= number;
                }
                start = ModPos(start, 100);
                if (start == 0)
                {
                    countZero++;
                }

            }
            return countZero;
        }

    }
}
