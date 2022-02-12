using System;
using System.Collections.Generic;
using System.Text;

namespace CaveCat.Interpreter.Handlers
{
    internal interface IHandler
    {
        bool Validate(List<string> flags);
        void Run(List<string> flags);
    }
}
