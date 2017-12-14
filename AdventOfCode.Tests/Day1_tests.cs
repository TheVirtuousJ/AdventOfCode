using System;
using Xunit;

namespace AdventOfCode.Tests
{
    public class Day1_tests
    {
        private readonly Day1 _day1;
        // Part 1
    
        public Day1_tests()
        {
            _day1 = new Day1();
        }

        [Fact]
        public void Part1_1122()
        {
            var result = _day1.SolvePart1("1122");

            Assert.Equal(3, result);
        }

        [Fact]
        public void Part1_1111()
        {
            var result = _day1.SolvePart1("1111");

            Assert.Equal(4, result);
        }

        [Fact]
        public void Part1_1234()
        {
            var result = _day1.SolvePart1("1234");

            Assert.Equal(0, result);
        }

        [Fact]
        public void Part1_91212129()
        {
            var result = _day1.SolvePart1("91212129");

            Assert.Equal(9, result);
        }

        // Part 2

        [Fact]
        public void Part2_1212()
        {
            var result = _day1.SolvePart2("1212");

            Assert.Equal(6, result);
        }
        
        [Fact]
        public void Part2_1221()
        {
            var result = _day1.SolvePart2("1221");

            Assert.Equal(0, result);
        }
                
        [Fact]
        public void Part2_123425()
        {
            var result = _day1.SolvePart2("123425");

            Assert.Equal(4, result);
        }

        [Fact]
        public void Part2_123123()
        {
            var result = _day1.SolvePart2("123123");

            Assert.Equal(12, result);
        }

        [Fact]
        public void Part2_12131415()
        {
            var result = _day1.SolvePart2("12131415");

            Assert.Equal(4, result);
        }

    }
}
