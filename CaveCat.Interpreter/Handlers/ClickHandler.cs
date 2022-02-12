using CaveCat.Interpreter.Components;
using CaveCat.Interpreter.Runner;
using System;
using System.Collections.Generic;
using System.Text;
using static CaveCat.Interpreter.Components.TypeCheckers;

namespace CaveCat.Interpreter.Handlers
{
    internal class ClickHandler : IHandler
    {
        private readonly Execution execution;
        private readonly Chrome chrome;

        public ClickHandler(Execution execution, Chrome chrome)
        {
            this.execution = execution;
            this.chrome = chrome;
        }

        public void Run(List<string> flags)
        {
            if(Validate(flags))
            {
                var xpath = flags[1].Substring(1, flags[1].Length - 2);
                Logger.Log(new Output("Clicking on element...", MessageType.ACTION, execution));
                //Do work
                var script = $"$($x(\"{xpath}\")).click();";
                Logger.Log(new Output($"Executing:{script}", MessageType.WARNING, execution));
                //Log back
                var output = chrome.RunJavaScript(script);
                Logger.Log(new Output($"Executed", MessageType.WARNING, execution));
            }
        }

        public bool Validate(List<string> flags)
        {
            if (TypeCheckers.Check(flags[0]) == FlagType.SUBCOMMAND && flags[0] == "on")
            {
                if (TypeCheckers.Check(flags[1]) == FlagType.XPATH)
                {
                    return true;
                }
            }
            return true;
        }
    }
}
