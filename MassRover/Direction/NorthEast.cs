﻿using MassRover.Core.Model;

namespace MassRover.Core.Model
{
    internal class NorthEast : Direction
    {
        private static NorthEast _instance = new NorthEast();
        static NorthEast() { }
        public static Direction Instance => _instance;
        public override string Name => Constants.Direction.NorthEast;
        public override Position PositionChange(double stepSize)
        {
            return new Position(stepSize, stepSize);
        }
    }
}
