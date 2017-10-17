using System;
using CommandPattern.Command;
using CommandPattern.Interfaces;
using CommandPattern.Invoker;
using CommandPattern.Receiver;
namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //just to simulate argument input
            String[] argument = new String[1];
            argument[0] = "ON";
            Run(argument);

            argument[0] = "OFF";
            Run(argument);

            Console.ReadKey(true);
        }

        public static void Run(String[] args)
        {
            string argument = args.Length > 0 ? args[0].ToUpper() : null;

            ISwitchable lamp = new Light();

            //Pass reference to the lamp instance to each command
            ICommand switchClose = new CloseSwitchCommand(lamp);
            ICommand switchOpen = new OpenSwitchCommand(lamp);

            //Pass reference to instances of the Command objects to the switch
            Switch @switch = new Switch(switchClose, switchOpen);

            if (argument == "ON")
            {
                // Switch (the Invoker) will invoke Execute() on the command object.
                @switch.On();
            }
            else if (argument == "OFF")
            {
                //Switch (the Invoker) will invoke the Execute() on the command object.
                @switch.Off();
            }
            else
            {
                Console.WriteLine("Argument \"ON\" or \"OFF\" is required.");
            }
        }
    }
}
