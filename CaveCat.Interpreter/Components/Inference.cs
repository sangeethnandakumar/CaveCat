using CaveCat.Interpreter.Handlers;
using System.Collections.Generic;

namespace CaveCat.Interpreter.Components
{
    internal class Inference
    {
        public string Command { get; set; }
        public IHandler Handler { get; set; }
        public List<string> Args { get; set; }
    }
}
