using System;
using System.Collections.Generic;
using System.Numerics;

namespace TestConsole {
    internal static class Program {
        private static void Main () {
            Func<int, bool> myTesTFunc;

            List<Vector2> abc =
                new List<Vector2> {
                    new Vector2 (2, 2),
                    new Vector2 (3, 3),
                    new Vector2 (4, 4),
                    new Vector2 (5, 5),
                    new Vector2 (6, 6),
                    new Vector2 (7, 7),
                    new Vector2 (8, 8)
                };

            myTesTFunc = (int i) => i < 5;

            Console.WriteLine (myTesTFunc (6));

            foreach (Vector2 v in abc) {
                Console.WriteLine (v);
            }

            Console.WriteLine ("Hello World!");

            for (int i = 0; i < 5; i++) {
                Console.WriteLine (i + 1);
            }

            Person myPerson = new Person { Age = 25, Name = "Henrique" };
        }
    }
}