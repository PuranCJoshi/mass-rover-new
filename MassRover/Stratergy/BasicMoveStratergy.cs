using MassRover.Core.Contracts;
using MassRover.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MassRover.Core.Stratergy
{
    public class BasicMoveStratergy : IMoveStratergy
    {
        private double _stepSize;
        public BasicMoveStratergy(int stepSize)
        {
            _stepSize = stepSize;
        }

        public Position GetPositionChange(Command command, IDirection direction)
        {
            switch (command)
            {
                case Command.Forward:
                    return direction.PositionChange(_stepSize);

                case Command.Backward:
                    return direction.PositionChange(-_stepSize);

                default:
                    throw new Exception("Invalid command");
            }
        }
    }
}