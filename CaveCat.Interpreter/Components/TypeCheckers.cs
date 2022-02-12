using System;
using System.Collections.Generic;
using System.Text;

namespace CaveCat.Interpreter.Components
{
    internal static class TypeCheckers
    {
        private static List<string> subcommands = new List<string> { "in", "on", "from", "enter", "backspace", "arrow-up", "arrow-down", "arrow-left", "arrow-right" };

        public static FlagType Check(string flag)
        {
            if(flag.StartsWith("'") && flag.EndsWith("'"))
            {
                return FlagType.STRING;
            }
            if (subcommands.Exists(x=>x==flag))
            {
                return FlagType.SUBCOMMAND;
            }
            if (flag.StartsWith("(") && flag.EndsWith(")"))
            {
                return FlagType.XPATH;
            }
            if (flag.EndsWith("sec"))
            {
                return FlagType.NUMBER;
            }
            return FlagType.UNKNOWN;
        }

        public enum FlagType
        {
            STRING,
            SUBCOMMAND,
            NUMBER,
            XPATH,
            UNKNOWN
        }
    }
}
