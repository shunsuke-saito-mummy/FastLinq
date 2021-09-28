using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DetailResearchOfLinq.Data;
using DetailResearchOfLinq.Utility;

namespace DetailResearchOfLinq.Benchmark
{
    [Config(typeof(BenchmarkConfig))]
    public abstract class BaseBenchmark
    {
        protected int[] NumbersArray;

        protected int[] RandomIndexes;

        protected User[] UsersArray;

        protected List<int> NumbersList;

        protected Dictionary<int, int> NumbersDict;

        protected Random Rand;

        protected User TargetUser = new User(1000, "User_1000", 10);
        
        [GlobalSetup]
        public void Setup()
        {
            NumbersArray = PrimitiveDataFactory.CreateNumberSequenceByArray(BenchmarkConfig.DATA_SIZE);

            NumbersList = PrimitiveDataFactory.CreateNumberSequenceByArray(BenchmarkConfig.DATA_SIZE).ToList();

            UsersArray = UserFactory.CreateUserArray(BenchmarkConfig.DATA_SIZE);

            NumbersDict = PrimitiveDataFactory.CreateNumberSequenceByArray(BenchmarkConfig.DATA_SIZE)
                .ToDictionary(number => number,
                    number => number);

            Rand = new Random();
            RandomIndexes = new int[BenchmarkConfig.DATA_SIZE];
            for (var i = 0; i < RandomIndexes.Length; i++)
            {
                RandomIndexes[i] = Rand.Next(0, BenchmarkConfig.DATA_SIZE);
            }
        }
    }
}