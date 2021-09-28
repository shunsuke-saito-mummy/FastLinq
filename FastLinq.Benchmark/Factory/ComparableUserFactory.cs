using System;
using DetailResearchOfLinq.Data;

namespace DetailResearchOfLinq.Utility
{
    public static class ComparableUserFactory
    {
        public static ComparableUser[] CreateComparableUserInRandomOrder(int size)
        {
            var rand = new Random();
            ComparableUser[] comparableUsers = new ComparableUser[size];
            for (var i = 0; i < size; i++)
            {
                var id = rand.Next(0, 100);
                comparableUsers[i] = new ComparableUser((ulong)id, $"ComparableUser_{id}", 20);
            }

            return comparableUsers;
        }
    }
}