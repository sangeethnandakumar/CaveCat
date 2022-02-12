using CaveCat.Interpreter.Components;
using CaveCat.Interpreter.Runner;
using System;
using System.Collections.Generic;
using System.Text;
using static CaveCat.Interpreter.Components.TypeCheckers;

namespace CaveCat.Interpreter.Handlers
{
    internal class SelectHandler : IHandler
    {
        private readonly Execution execution;
        private readonly Chrome chrome;

        public SelectHandler(Execution execution, Chrome chrome)
        {
            this.execution = execution;
            this.chrome = chrome;
        }

        public void Run(List<string> flags)
        {
            if(Validate(flags))
            {
                var text = flags[0].Substring(1, flags[0].Length - 2);
                var xpath = flags[2].Substring(1, flags[2].Length - 2);
                Logger.Log(new Output("Selecting element...", MessageType.ACTION ,execution));
                chrome.SelectByText(xpath, text);
            }
        }

        public bool Validate(List<string> flags)
        {
            if (TypeCheckers.Check(flags[0]) == FlagType.STRING)
            {
                if (TypeCheckers.Check(flags[1]) == FlagType.SUBCOMMAND && flags[1]=="from")
                {
                    if (TypeCheckers.Check(flags[2]) == FlagType.XPATH)
                    {
                        return true;
                    }
                }
            }
            return true;
        }
    }
}
