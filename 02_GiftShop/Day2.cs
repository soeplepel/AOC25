namespace _02_GiftShop
{
    public class Day2
    {
        private readonly string[] _input;

        public Day2(string input)
        {
            _input = input.Split(",", options: StringSplitOptions.RemoveEmptyEntries);
        }

        private bool Invalid(UInt64 num)
        {
            var strNum = num.ToString();
            var length = strNum.Length;

            if (length % 2 != 0) 
                return false;

            var mid = length / 2;
            var strBegin = strNum[..mid];
            var strEnd = strNum[mid..length];
            return (strBegin == strEnd);
         
        }

        public UInt64 Calculate()
        {
            UInt64 sum = 0;
            foreach (var input in _input)
            {
                var splitLine = input.Split("-");
                List<UInt64> numbersLine = new();
                foreach (var item in splitLine)
                {
                    numbersLine.Add(Convert.ToUInt64(item));
                }

                var num = numbersLine[0];
                var end = numbersLine[1];

                while(num <= end)
                {
                   
                    if(Invalid(num))
                    {
                        sum += num;
                    }
                    num++;

                }
                
            }

            return sum;
        }
    }
}
