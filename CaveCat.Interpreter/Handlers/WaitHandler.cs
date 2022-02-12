using CaveCat.Interpreter.Components;
using CaveCat.Interpreter.Runner;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static CaveCat.Interpreter.Components.TypeCheckers;

namespace CaveCat.Interpreter.Handlers
{
    internal class WaitHandler : IHandler
    {
        private readonly Execution execution;
        private readonly Chrome chrome;

        public WaitHandler(Execution execution, Chrome chrome)
        {
            this.execution = execution;
            this.chrome = chrome;
        }

        public void Run(List<string> flags)
        {
            if(Validate(flags))
            {
                var seconds = flags[0].Substring(0, flags[0].Length - 3);
                var sec = Convert.ToInt32(seconds) * 1000;
                Logger.Log(new Output($"Waiting for {sec/1000} seconds...", MessageType.ACTION, execution));
                Thread.Sleep(sec);
            }
        }

        public bool Validate(List<string> flags)
        {
            var type = TypeCheckers.Check(flags[0]);
            if (type == FlagType.NUMBER)
            {
                return true;
            }
            return false;
        }
    }
}
