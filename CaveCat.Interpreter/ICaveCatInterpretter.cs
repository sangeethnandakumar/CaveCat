using CaveCat.Interpreter.Components;
using CaveCat.Interpreter.Handlers;
using CaveCat.Interpreter.Runner;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace CaveCat.Interpreter
{
    internal interface ICaveCatInterpretter
    {
        ChromeDriver GetBrowser();
        void Reset();
        string Sanitize(string code);
        Inference GetInference(string code, Execution execution);
        void Handle(IHandler handler, List<string> args);
    }
}
