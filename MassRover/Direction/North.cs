using MassRover.Core.Model;

namespace MassRover.Core.Model
{
    internal class North : Direction
    {
        private static North _instance = new North();
        static North() { }
        public static Direction Instance => _instance;
        public override string Name => Constants.Direction.North;
        public override Position PositionChange(double stepSize)
        {
            return new Position(0, stepSize);
        }
    }
}
