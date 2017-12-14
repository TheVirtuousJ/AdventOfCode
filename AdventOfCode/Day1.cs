using System;

namespace AdventOfCode
{
    public class Day1
    {

        public int SolvePart1(string input)
        {            
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i].Equals(input[(i < input.Length - 1) ? i + 1 : 0]))
                {
                    result += int.Parse(input[i].ToString());
                }
            }

            return result;
        }

        public int SolvePart2(string input)
        {
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
               
                if(input[i].Equals(input[(i + input.Length / 2) % input.Length]))
                {
                    result += int.Parse(input[i].ToString());
                }
            }

            return result;
        }

    }
}
