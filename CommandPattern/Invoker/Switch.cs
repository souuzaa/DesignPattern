﻿using CommandPattern.Interfaces;
using System;

namespace CommandPattern.Invoker
{
    public class Switch
    {
        ICommand _closedCommand;
        ICommand _openedCommand;

        public Switch(ICommand closedCommand, ICommand openedCommand)
        {
            this._closedCommand = closedCommand;
            this._openedCommand = openedCommand;
        }

        //close the circuit/power on
        public void On()
        {
            this._closedCommand.Execute();
        }

        //open the circuit/power off
        public void Off()
        {
            this._openedCommand.Execute();
        }
    }
}
