using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace DetailResearchOfLinq.Benchmark.Sandbox
{
    [Config(typeof(BenchmarkConfig))]
    public class LinqVsPureLogicBenchmark
    {

        private sealed class User
        {
            public readonly int Id;

            public readonly bool IsPaid;

            public User(int id, bool isPaid)
            {
                Id = id;
                IsPaid = isPaid;
            }
        }

        private User[] _users;
        
        
        [GlobalSetup]
        public void Setup()
        {
            const int size = 100000;
            _users = new User[size];
            var rand = new Random();
            for (var i = 0; i < size; i++)
            {
                _users[i] = new User(i, rand.Next(0, 2) == 0);
            }
        }

        [Benchmark]
        public void PureLogic()
        {
            for (var i = 0; i < _users.Length; i++)
            {
                if (!_users[i].IsPaid)
                {
                    continue;
                }

                var userId = _users[i].Id;
            }
        }

        [Benchmark]
        public void LinqLogic()
        {
            var query = _users.Where(user => user.IsPaid).Select(user => user.Id);
            foreach (var id in query)
            {
                
            }
        }
    }
}