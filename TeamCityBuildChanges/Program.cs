using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ManyConsole;

namespace TeamCityBuildChanges
{
    class Program
    {
        static int Main(string[] args)
        {
            ILBundle.RegisterAssemblyResolver();
            var result = Run(args);
            if (Debugger.IsAttached)
                Console.ReadKey();
            return result;
        }
        
        private static int Run(string[] args)
        {
            var commands = GetCommands();
            return ConsoleCommandDispatcher.DispatchCommand(commands, args, Console.Out);
            
        }

        static IEnumerable<ConsoleCommand> GetCommands()
        {
            return ConsoleCommandDispatcher.FindCommandsInSameAssemblyAs(typeof(Program)).Where(c => !string.IsNullOrEmpty(c.Command));
        }
    }
}
