using CaveCat.Interpreter.Components;
using CaveCat.Interpreter.Handlers;
using CaveCat.Interpreter.Runner;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;

namespace CaveCat.Interpreter
{
    internal class CaveCatInterpretter : ICaveCatInterpretter
    {
        private readonly Chrome chrome;

        public CaveCatInterpretter()
        {
            chrome = new Chrome(@"C:\Program Files\Google\Chrome\Application\chrome.exe");
        }

        public ChromeDriver GetBrowser()
        {
            return chrome.GetInstance();
        }

        public Inference GetInference(string code, Execution execution)
        {
            foreach(var part in code.Split(' '))
            {
                if(part.ToLower().StartsWith("goto"))
                {
                    return new Inference
                    {
                        Command = "goto",
                        Handler = new GoToHandler(execution, chrome),
                        Args = code.Split(' ').Skip(1).ToList(),
                    };
                }
                else if (part.ToLower().StartsWith("type"))
                {
                    return new Inference
                    {
                        Command = "type",
                        Handler = new TypeHandler(execution, chrome),
                        Args = code.Split(' ').Skip(1).ToList(),
                    };
                }
                else if (part.ToLower().StartsWith("wait"))
                {
                    return new Inference
                    {
                        Command = "wait",
                        Handler = new WaitHandler(execution, chrome),
                        Args = code.Split(' ').Skip(1).ToList(),
                    };
                }
                else if (part.ToLower().StartsWith("click"))
                {
                    return new Inference
                    {
                        Command = "click",
                        Handler = new ClickHandler(execution, chrome),
                        Args = code.Split(' ').Skip(1).ToList(),
                    };
                }
                else if (part.ToLower().StartsWith("select"))
                {
                    return new Inference
                    {
                        Command = "select",
                        Handler = new SelectHandler(execution, chrome),
                        Args = code.Split(' ').Skip(1).ToList(),
                    };
                }
                else if (part.ToLower().StartsWith("hit"))
                {
                    return new Inference
                    {
                        Command = "hit",
                        Handler = new HitHandler(execution, chrome),
                        Args = code.Split(' ').Skip(1).ToList(),
                    };
                }
            }
            return new Inference { };
        }

        public void Handle(IHandler handler, List<string> args)
        {
            handler.Run(args);
        }

        public void Reset()
        {
        }

        public string Sanitize(string code)
        {
            return code;
        }
    }
}
