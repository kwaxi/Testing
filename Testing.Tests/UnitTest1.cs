using System;
using Testing.Models;
using FluentAssertions;
using Xunit;

namespace Testing.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CircleIsAShape()
        {
            typeof(Circle).Should().BeDerivedFrom(typeof(Shape));
        }
    }
}
