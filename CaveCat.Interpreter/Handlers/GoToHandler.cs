using CaveCat.Interpreter.Components;
using CaveCat.Interpreter.Runner;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static CaveCat.Interpreter.Components.TypeCheckers;

namespace CaveCat.Interpreter.Handlers
{
    internal class GoToHandler : IHandler
    {
        private readonly Execution execution;
        private readonly Chrome chrome;

        public GoToHandler(Execution execution, Chrome chrome)
        {
            this.execution = execution;
            this.chrome = chrome;
        }

        public void Run(List<string> flags)
        {
            if (Validate(flags))
            {
                var url = flags[0].Substring(1, flags[0].Length - 2);
                Logger.Log(new Output($"Redirecting to URL {url}", MessageType.ACTION, execution));
                chrome.Goto(url);
                Logger.Log(new Output($"--------------------------------------------------", MessageType.INFO, execution));
                Logger.Log(new Output($"1. Injecting [CaveCat => Web.Supportlibs.JQuery]", MessageType.ACTION, execution));
                chrome.RunJavaScript(File.ReadAllText( Directory.GetCurrentDirectory() + "\\net6.0\\jquery.js"));
                Logger.Log(new Output($"2. Injecting [CaveCat => Chrome.Resolvers.XPath]", MessageType.ACTION, execution));
                var xPathScript = @"
    $x = function(xpath, opt_startNode)
    {
        var doc = (opt_startNode && opt_startNode.ownerDocument) || document;
        var result = doc.evaluate(xpath, opt_startNode || doc, null, XPathResult.ANY_TYPE, null);
        switch (result.resultType) {
        case XPathResult.NUMBER_TYPE:
            return result.numberValue;
        case XPathResult.STRING_TYPE:
            return result.stringValue;
        case XPathResult.BOOLEAN_TYPE:
            return result.booleanValue;
        default:
            var nodes = [];
            var node;
            while (node = result.iterateNext())
                nodes.push(node);
            return nodes;
        }
    }";
                var output = chrome.RunJavaScript(xPathScript);
                Logger.Log(new Output($"Injection completed", MessageType.ACTION, execution));
                Logger.Log(new Output($"--------------------------------------------------", MessageType.INFO, execution));
            }
        }

        public bool Validate(List<string> flags)
        {
            var type = TypeCheckers.Check(flags[0]);
            if (type == FlagType.STRING)
            {
                return true;
            }
            return false;
        }
    }
}
