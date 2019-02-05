﻿using MassRover.Core.Model;

namespace MassRover.Core.Model
{
    internal class South : Direction
    {
        private static South _instance = new South();
        static South() { }
        public static Direction Instance => _instance;
        public override string Name => Constants.Direction.South;
        public override Position PositionChange(double stepSize)
        {
            return new Position(0, -stepSize);
        }
    }
}
