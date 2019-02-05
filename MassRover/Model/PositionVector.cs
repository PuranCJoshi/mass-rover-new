using MassRover.Core.Contracts;

namespace MassRover.Core.Model
{
    public class PositionVector : Position
    {
        public string Direction => Orientation.Name;
        internal readonly Direction Orientation;
        public PositionVector(double x, double y, Direction direction) : base(x, y)
        {
            Orientation = direction;
        }
    }
}
