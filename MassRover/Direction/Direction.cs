using MassRover.Core.Contracts;
using MassRover.Core.Model;

namespace MassRover.Core.Model
{
    public abstract class Direction : IDirection
    {
        public abstract string Name { get; }
        public abstract Position PositionChange(double stepSize);
        public void SetLeftAndRight(IDirection directionToLeft, IDirection directionToRight)
        {
            TurnLeft = directionToLeft;
            TurnRight = directionToRight;
        }
        public IDirection TurnLeft{ get; private set; }
        public IDirection TurnRight{ get; private set; }
    }
}
