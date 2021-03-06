using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestableSample2.App
{
    public static class MainFlow
    {
        public static async Task Run()
        {
            var typedValues = ReadTypedValues();

            foreach (var tv in typedValues)
            {
                await Task.Delay(1000);
                tv.WriteLine();
            }
        }

        private static IEnumerable<TypedValue> ReadTypedValues()
        {
            Console.Write("カンマ区切りの値を入力：");
            var valueStrs = Console.ReadLine();

            return valueStrs.Split(",", StringSplitOptions.None)
                            .Select(x => new TypedValue(x));
        }
    }
}
