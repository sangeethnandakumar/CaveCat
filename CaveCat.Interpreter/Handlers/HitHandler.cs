using CaveCat.Interpreter.Components;
using CaveCat.Interpreter.Runner;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static CaveCat.Interpreter.Components.TypeCheckers;

namespace CaveCat.Interpreter.Handlers
{
    internal class HitHandler : IHandler
    {
        private readonly Execution execution;
        private readonly Chrome chrome;

        public HitHandler(Execution execution, Chrome chrome)
        {
            this.execution = execution;
            this.chrome = chrome;
        }

        public void Run(List<string> flags)
        {
            if(Validate(flags))
            {
                var key = flags[0];               
                Actions builder = new Actions(chrome.GetInstance());                
                switch (key)
                {
                    case "enter":
                        builder.SendKeys(Keys.Enter);
                        Logger.Log(new Output($"Hitting ENTER key...", MessageType.ACTION, execution));
                        break;
                    case "backspace":
                        builder.SendKeys(Keys.Backspace);
                        Logger.Log(new Output($"Hitting BACKSPACE key...", MessageType.ACTION, execution));
                        break;
                    case "arrow-down":
                        builder.SendKeys(Keys.ArrowDown);
                        Logger.Log(new Output($"Hitting DOWN key...", MessageType.ACTION, execution));
                        break;
                    case "arrow-up":
                        builder.SendKeys(Keys.ArrowUp);
                        Logger.Log(new Output($"Hitting UP key...", MessageType.ACTION, execution));
                        break;
                    case "arrow-left":
                        builder.SendKeys(Keys.ArrowLeft);
                        Logger.Log(new Output($"Hitting LEFT key...", MessageType.ACTION, execution));
                        break;
                    case "arrow-right":
                        builder.SendKeys(Keys.ArrowRight);
                        Logger.Log(new Output($"Hitting RIGHT key...", MessageType.ACTION, execution));
                        break;
                }
            }
        }

        public bool Validate(List<string> flags)
        {
            var type = TypeCheckers.Check(flags[0]);
            if (type == FlagType.SUBCOMMAND)
            {
                return true;
            }
            return false;
        }
    }
}
