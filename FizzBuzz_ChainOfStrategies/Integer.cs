﻿using FizzBuzz_ChainOfStrategies.Strategies;

namespace FizzBuzz_ChainOfStrategies
{
    public class Integer
    {
        private readonly IIntegerToStringStrategy _strategyChain;

        public Integer(int value) : this(new FizzBuzzStrategy(value)) { }

        public Integer(IIntegerToStringStrategy strategyChain)
        {
            _strategyChain = strategyChain;
        }

        public override string ToString()
        {
            return _strategyChain.ToString();
        }
    }
}