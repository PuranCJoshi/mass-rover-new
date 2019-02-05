using MassRover.Core.Model;

namespace MassRover.Core.Model
{
    internal class NorthWest : Direction
    {
        private static NorthWest _instance = new NorthWest();
        static NorthWest() { }
        public static Direction Instance => _instance;
        public override string Name => Constants.Direction.NorthWest;
        public override Position PositionChange(double stepSize)
        {
            return new Position(-stepSize, stepSize);
        }
    }
}
