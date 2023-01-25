﻿using Calculator.Operations;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.UnitTests
{
    public class OperationTests
    {
        [Fact]
        public void ComplexTest()
        {
            var result = new Sum(new Division(20, 4), 1);

            result.ToResult().Should().Be(6);
        }
    }
}
