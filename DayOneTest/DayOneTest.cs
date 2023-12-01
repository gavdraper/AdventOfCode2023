namespace DayOneTest
{
    public class DayOneTest
    {

        public Dictionary<string, int> Matches = new Dictionary<string, int>()
        {
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 },
            {"1",1},
            {"2",2},
            {"3",3},
            {"4",4},
            {"5",5},
            {"6",6},
            {"7",7},
            {"8",8},
            {"9",9},
        };


        public int ParseLine(string input)
        {
            int? first = null;
            int? last = null;
            //Walk Forward
            for (var i = 0; i < input.Length; i++)
            {
                foreach (var m in Matches)
                {
                    if (input.IndexOf(m.Key) == i)
                    {
                        if(first == null)
                            first = m.Value;    
                        break;
                    }
                }
                if (first != null) break;
            }
            //Walk Back
            for (var i = input.Length-1; i >= 0; i--)
            {
                foreach (var m in Matches)
                {
                    if (input.LastIndexOf(m.Key) == i)
                    {
                        last = m.Value;
                        break;
                    }
                }

                if (last != null) break;
            }

            return int.Parse(first.ToString() + last.ToString());
        }

        [Fact]
        public void Test1()
        {
            var input = File.ReadAllText("../../../Sample.txt");
            var sample = Run(input);
            input = File.ReadAllText("../../../Real.txt");
            var real = Run(input);
        }

        public int Run(string input)
        {
            var lines = input.Split('\n');
            var digits = new List<int>();
            foreach (var l in lines)
            {
                var parsedInput = ParseLine(l.ToLower());
                digits.Add(parsedInput);

            }
            return digits.Sum();
        }
    }
}