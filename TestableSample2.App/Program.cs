﻿using System.Threading.Tasks;

namespace TestableSample2.App
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            await MainFlow.Run();
        }
    }
}
