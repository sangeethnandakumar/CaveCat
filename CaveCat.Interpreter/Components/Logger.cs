using Newtonsoft.Json;
using System;

namespace CaveCat.Interpreter.Components
{
    internal static class Logger
    {
        public static void Log(Output output)
        {
            var json = JsonConvert.SerializeObject(output, Formatting.None);
            Console.WriteLine(json);
        }
    }
}
