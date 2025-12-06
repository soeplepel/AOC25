using System.Diagnostics.CodeAnalysis;

namespace _03_Lobby
{
    public class Day3
    {
        private readonly string[] _lines;
        public Day3(string input)
        {
            _lines = input.Split("\n", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        }

        private Tuple<int, int> GetLargstDigit(char[] arr, int index = 0, bool checkForLast = false)
        {
            var currentLargest = 0;
            var indexLargest = 0;
            var secondLargest = 0;
            var indexSecondLargest = 0;
            for (; index < arr.Length; index++)
            {
                var strAtIndex = arr.ElementAt(index) - '0';
                var digit = Convert.ToUInt16(strAtIndex);
                if (digit > currentLargest)
                {
                    secondLargest = currentLargest;
                    indexSecondLargest = indexLargest;
                    currentLargest = digit;
                    indexLargest = index+1;

                }
            }

            if(indexLargest == arr.Length && checkForLast)
                return Tuple.Create(secondLargest, indexSecondLargest);
            else
                return Tuple.Create(currentLargest, indexLargest);

                
        }

        public UInt64 Calculate()
        {
            UInt64 sum = 0;
            foreach (var line in _lines)
            {
                var charArr = line.ToCharArray();
                var firstPass = GetLargstDigit(charArr,0,true);
                var secondPass = GetLargstDigit(charArr, firstPass.Item2, false);
                sum += Convert.ToUInt64((firstPass.Item1.ToString() + secondPass.Item1.ToString()));
            }

            return sum;
        }
    }
}
