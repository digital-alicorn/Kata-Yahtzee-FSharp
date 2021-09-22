using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.FSharp;
using FluentAssertions;

namespace FSharp.Kata.Yahtzee.Tests
{
    [TestClass]
    public class YahtzeeTests
    {
        [DataTestMethod]
        [DataRow(1, 2, 3, 4, 5, 1)]
        [DataRow(1, 1, 3, 4, 5, 2)]
        [DataRow(1, 1, 3, 1, 5, 3)]
        [DataRow(6, 2, 3, 4, 5, 0)]
        public void OnesAreSummedCorrectly(int x1, int x2, int x3, int x4, int x5, int result)
        {
            var input = Microsoft.FSharp.Collections.ListModule.OfSeq(new[] { x1, x2, x3, x4, x5 });
            Yahtzee.Ones(input).Should().Be(result);
        }

        [DataTestMethod]
        [DataRow(1, 2, 3, 4, 5, 2)]
        [DataRow(2, 2, 3, 4, 5, 4)]
        [DataRow(2, 2, 3, 2, 5, 6)]
        [DataRow(1, 6, 3, 4, 5, 0)]
        public void TwosAreSummedCorrectly(int x1, int x2, int x3, int x4, int x5, int result)
        {
            var input = Microsoft.FSharp.Collections.ListModule.OfSeq(new[] { x1, x2, x3, x4, x5 });
            Yahtzee.Twos(input).Should().Be(result);
        }

        [DataTestMethod]
        [DataRow(1, 2, 3, 4, 5, 3)]
        [DataRow(1, 2, 3, 3, 5, 6)]
        [DataRow(3, 2, 3, 4, 3, 9)]
        [DataRow(1, 2, 6, 4, 5, 0)]
        public void ThreesAreSummedCorrectly(int x1, int x2, int x3, int x4, int x5, int result)
        {
            var input = Microsoft.FSharp.Collections.ListModule.OfSeq(new[] { x1, x2, x3, x4, x5 });
            Yahtzee.Threes(input).Should().Be(result);
        }

        [DataTestMethod]
        [DataRow(1, 2, 3, 4, 5, 4)]
        [DataRow(1, 2, 3, 4, 4, 8)]
        [DataRow(4, 2, 4, 4, 5, 12)]
        [DataRow(1, 2, 3, 6, 5, 0)]
        public void FoursAreSummedCorrectly(int x1, int x2, int x3, int x4, int x5, int result)
        {
            var input = Microsoft.FSharp.Collections.ListModule.OfSeq(new[] { x1, x2, x3, x4, x5 });
            Yahtzee.Fours(input).Should().Be(result);
        }

        [DataTestMethod]
        [DataRow(1, 2, 3, 4, 5, 5)]
        [DataRow(1, 2, 3, 5, 5, 10)]
        [DataRow(5, 2, 3, 5, 5, 15)]
        [DataRow(1, 2, 3, 4, 6, 0)]
        public void FivesAreSummedCorrectly(int x1, int x2, int x3, int x4, int x5, int result)
        {
            var input = Microsoft.FSharp.Collections.ListModule.OfSeq(new[] { x1, x2, x3, x4, x5 });
            Yahtzee.Fives(input).Should().Be(result);
        }

        [DataTestMethod]
        [DataRow(6, 2, 3, 4, 5, 6)]
        [DataRow(6, 6, 3, 4, 5, 12)]
        [DataRow(6, 6, 3, 6, 6, 24)]
        [DataRow(1, 2, 3, 4, 5, 0)]
        public void SixesAreSummedCorrectly(int x1, int x2, int x3, int x4, int x5, int result)
        {
            var input = Microsoft.FSharp.Collections.ListModule.OfSeq(new[] { x1, x2, x3, x4, x5 });
            Yahtzee.Sixes(input).Should().Be(result);
        }

        [DataTestMethod]
        [DataRow(1, 4, 4, 6, 6, 12)]
        [DataRow(5, 2, 3, 4, 5, 10)]
        [DataRow(6, 6, 3, 6, 6, 12)]
        [DataRow(1, 2, 3, 4, 5, 0)]
        public void HighestPairIsSummedCorrectly(int x1, int x2, int x3, int x4, int x5, int result)
        {
            var input = Microsoft.FSharp.Collections.ListModule.OfSeq(new[] { x1, x2, x3, x4, x5 });
            Yahtzee.Pair(input).Should().Be(result);
        }

        [DataTestMethod]
        [DataRow(1, 4, 4, 6, 6, 20)]
        [DataRow(1, 1, 2, 3, 3, 8)]
        [DataRow(6, 6, 3, 6, 6, 24)]
        [DataRow(1, 2, 3, 5, 5, 0)]
        public void TwoPairsAreSummedCorrectly(int x1, int x2, int x3, int x4, int x5, int result)
        {
            var input = Microsoft.FSharp.Collections.ListModule.OfSeq(new[] { x1, x2, x3, x4, x5 });
            Yahtzee.TwoPairs(input).Should().Be(result);
        }

        [DataTestMethod]
        [DataRow(1, 1, 1, 1, 6, 3)]
        [DataRow(1, 2, 2, 2, 3, 6)]
        [DataRow(4, 6, 4, 6, 4, 12)]
        [DataRow(1, 2, 3, 4, 5, 0)]
        public void ThreeOfAKindAreSummedCorrectly(int x1, int x2, int x3, int x4, int x5, int result)
        {
            var input = Microsoft.FSharp.Collections.ListModule.OfSeq(new[] { x1, x2, x3, x4, x5 });
            Yahtzee.ThreeOfAKind(input).Should().Be(result);
        }

        [DataTestMethod]
        [DataRow(1, 1, 1, 1, 6, 4)]
        [DataRow(1, 2, 2, 2, 2, 8)]
        [DataRow(4, 6, 4, 6, 4, 0)]
        public void FourOfAKindAreSummedCorrectly(int x1, int x2, int x3, int x4, int x5, int result)
        {
            var input = Microsoft.FSharp.Collections.ListModule.OfSeq(new[] { x1, x2, x3, x4, x5 });
            Yahtzee.FourOfAKind(input).Should().Be(result);
        }

        [DataTestMethod]
        [DataRow(1, 2, 3, 4, 5, 15)]
        [DataRow(2, 3, 4, 5, 6, 0)]
        public void SmallStraightIsSummedCorrectly(int x1, int x2, int x3, int x4, int x5, int result)
        {
            var input = Microsoft.FSharp.Collections.ListModule.OfSeq(new[] { x1, x2, x3, x4, x5 });
            Yahtzee.SmallStraight(input).Should().Be(result);
        }

        [DataTestMethod]
        [DataRow(2, 3, 4, 5, 6, 20)]
        [DataRow(3, 4, 5, 6, 1, 0)]
        public void LargeStraightIsSummedCorrectly(int x1, int x2, int x3, int x4, int x5, int result)
        {
            var input = Microsoft.FSharp.Collections.ListModule.OfSeq(new[] { x1, x2, x3, x4, x5 });
            Yahtzee.LargeStraight(input).Should().Be(result);
        }

        [DataTestMethod]
        [DataRow(4, 4, 4, 3, 3, 18)]
        [DataRow(2, 2, 5, 5, 5, 19)]
        [DataRow(4, 4, 4, 4, 4, 0)]
        public void FullHouseIsSummedCorrectly(int x1, int x2, int x3, int x4, int x5, int result)
        {
            var input = Microsoft.FSharp.Collections.ListModule.OfSeq(new[] { x1, x2, x3, x4, x5 });
            Yahtzee.FullHouse(input).Should().Be(result);
        }

        [DataTestMethod]
        [DataRow(1, 1, 1, 1, 1, 50)]
        [DataRow(1, 1, 1, 1, 2, 0)]
        public void YahtzeeIsEvaluatedCorrectly(int x1, int x2, int x3, int x4, int x5, int result)
        {
            var input = Microsoft.FSharp.Collections.ListModule.OfSeq(new[] { x1, x2, x3, x4, x5 });
            Yahtzee.Yahtzee(input).Should().Be(result);
        }

        [DataTestMethod]
        [DataRow(1, 2, 3, 4, 5, 15)]
        [DataRow(1, 1, 3, 4, 5, 14)]
        [DataRow(1, 1, 3, 1, 5, 11)]
        [DataRow(6, 2, 3, 4, 5, 20)]
        public void ChanceIsSummedCorrectly(int x1, int x2, int x3, int x4, int x5, int result)
        {
            var input = Microsoft.FSharp.Collections.ListModule.OfSeq(new[] { x1, x2, x3, x4, x5 });
            Yahtzee.Chance(input).Should().Be(result);
        }
    }
}
