﻿using MassRover.Core.Model;

namespace MassRover.Core.Model
{
    internal class East : Direction
    {
        private static East _instance = new East();
        static East() { }
        public static Direction Instance => _instance;
        public override string Name => Constants.Direction.East;
        public override Position PositionChange(double stepSize)
        {
            return new Position(stepSize, 0);
        }
    }
}
