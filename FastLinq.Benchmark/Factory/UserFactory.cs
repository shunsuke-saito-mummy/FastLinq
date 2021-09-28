using System;
using System.Collections.Generic;
using System.Linq;
using DetailResearchOfLinq.Data;

namespace DetailResearchOfLinq.Utility
{
    public static class UserFactory
    {
        public static User[] CreateUserArray(int count) => Enumerable.Range(0, count)
            .Select(i => new User((ulong) i, $"User_{i}", i % 80))
            .ToArray();
        
        public static List<User> CreateUserList(int count) => Enumerable.Range(0, count)
            .Select(i => new User((ulong)i, $"User_{i}", i % 80))
            .ToList();

        public static Dictionary<ulong, User> CreateUserDictionary(int count)
        {
            var ret = new Dictionary<ulong, User>(count);
            for (var i = 0; i < count; i++)
            {
                ret[(ulong)i] = new User((ulong) i, $"User_{i}", i % 80); 
            }

            return ret;
        }

        public static User[] CreateRandomUserArray(int count)
        {
            var rand = new Random(0);
            User[] users = new User[count];
            for (var i = 0; i < users.Length; i++)
            {
                users[i] = new User((ulong) i, $"User_{i}", rand.Next(10, 30));
            }

            return users;
        }
    }
}
