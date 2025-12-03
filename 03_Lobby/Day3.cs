using System.Diagnostics.CodeAnalysis;

namespace _03_Lobby
{
    public class Day3
    {
        private readonly string[] _lines;
        public Day3(string input)
        {
            _lines = input.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
        }

        private Tuple<int, int> GetLargstDigit(char[] arr, int index = 0)
        {
            var currentLargest = 0;
            var indexLargest = 0;
            for (; index < arr.Length; index++)
            {
                var strAtIndex = arr.ElementAt(index) - '0';

                var digit = Convert.ToUInt16(strAtIndex);
                if (digit > currentLargest)
                {
                    currentLargest = digit;
                    indexLargest = index + 1; ;
                }
                   

            }

            if (indexLargest == arr.Length)
            {
                arr[indexLargest-1] = '0';
                var ret =  GetLargstDigit(arr);
                arr[indexLargest - 1] = Convert.ToChar(currentLargest);

                return ret;
            }
                 
            return new Tuple<int, int>(currentLargest, indexLargest);
        }

        public int Calculate()
        {
            var sum = 0;
            foreach (var line in _lines)
            {
                var charArr = line.ToCharArray();
                var firstPass = GetLargstDigit(charArr);
                var secondPass = GetLargstDigit(charArr, firstPass.Item2);
                sum += Convert.ToUInt16((firstPass.Item1.ToString() + secondPass.Item1.ToString()));
            }

            return sum;
        }
    }
}
