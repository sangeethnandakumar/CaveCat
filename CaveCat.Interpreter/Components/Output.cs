using System;
using System.Collections.Generic;
using System.Text;

namespace CaveCat.Interpreter.Components
{
    public class Output
    {
        public Output()
        {

        }
        public Output(string message, MessageType type, Execution executionInfo, Dictionary<string, string> meta)
        {
            Message = message;
            Type = type;
            ExecutionInfo = executionInfo;
            Meta = meta;
        }
        public Output(string message, MessageType type, Execution executionInfo)
        {
            Message = message;
            Type = type;
            ExecutionInfo = executionInfo;
            Meta = new Dictionary<string, string>();
        }
        public Output(string message, Execution executionInfo)
        {
            Message = message;
            Type = MessageType.INFO;
            ExecutionInfo = executionInfo;
            Meta = new Dictionary<string, string>();
        }

        public Execution ExecutionInfo { get; set; }
        public string Message { get; set; }
        public MessageType Type { get; set; }
        public Dictionary<string, string> Meta { get; set; }
    }

    public enum MessageType
    {
        INFO,
        ERROR,
        WARNING,
        ACTION,
        COMPLETE,
        STARTED
    }
}
