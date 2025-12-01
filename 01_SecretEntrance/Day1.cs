namespace _01_SecretEntrance
{
    public class Day1
    {
        private readonly string[] _input;

        public Day1(string input)
        {

            _input = input.Split("\r\n");
        }
        //positive modulo result
        private static int Mod(int x, int m)
        {
            return (x % m + m) % m;
        }
        public int Calculate(int start = 50)
        {
            var countZero = 0;
            foreach (var input in _input)
            {
                var operand = input[..1].ToLower();
                var number = Convert.ToInt32(input[1..]);

                if (operand == "r")
                {
                    start += number;
                }
                else if (operand == "l")
                {
                    start -= number;
                }
                start = Mod(start, 100);
                if (start == 0)
                {
                    countZero++;
                }

            }
            return countZero;
        }

    }
}
