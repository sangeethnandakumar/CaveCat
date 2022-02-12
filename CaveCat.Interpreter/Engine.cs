using CaveCat.Interpreter.Components;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace CaveCat.Interpreter
{
    public class Engine
    {
        private readonly CaveCatInterpretter _interpretter;

        public Engine()
        {
            _interpretter = new CaveCatInterpretter();
        }

        public void Execute(string code)
        {
            //Reset the interpretter
            _interpretter.Reset();

            Execution execution = new Execution();
            try
            {
                Logger.Log(new Output($"Execution started", MessageType.STARTED, execution));
                //Extract lines
                for (var i = 0; i <= code.Split('\n').Length; i++)
                {
                    try
                    {
                        var line = code.Split('\n')[i];

                        //Set execution headers
                        execution.Line = i + 1;
                        execution.Code = line;

                        //Sanitise current line
                        var cleanedCode = _interpretter.Sanitize(line);

                        //Get the handler of command (goto, click, type etc..)
                        var inference = _interpretter.GetInference(cleanedCode, execution);

                        //Handle the command to respective handler
                        Logger.Log(new Output($"Handling with: {inference.Handler}", execution));
                        _interpretter.Handle(inference.Handler, inference.Args);
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(new Output($"Handler Exception: {ex.Message}", MessageType.ERROR, execution));
                        Logger.Log(new Output($"StackTrace: {ex}", MessageType.ERROR, execution));
                        _interpretter.GetBrowser().Quit();
                        throw;
                    }
                }
                Logger.Log(new Output($"Execution complete", MessageType.COMPLETE, execution));
            }
            catch (NoSuchElementException ex)
            {
                Logger.Log(new Output($"No Elements: {ex.Message}", MessageType.ERROR, execution));
                Logger.Log(new Output($"StackTrace: {ex}", MessageType.ERROR, execution));
                _interpretter.GetBrowser().Quit();
                throw;
            }
            catch (Exception ex)
            {
                Logger.Log(new Output($"Generic Exception: {ex.Message}", MessageType.ERROR, execution));
                Logger.Log(new Output($"StackTrace: {ex}", MessageType.ERROR, execution));
                _interpretter.GetBrowser().Quit();
                throw;
            }
            finally
            {
                _interpretter.GetBrowser().Quit();
            }
        }
    }
}
