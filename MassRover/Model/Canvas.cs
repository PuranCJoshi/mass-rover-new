using MassRover.Core.Contracts;

namespace MassRover.Core.Model
{
    public class Canvas : IConstraint
    {
        private readonly double _length;
        private readonly double _breath;
        public Canvas(double length, double breath)
        {
            _length = length;
            _breath = breath;
        }

        public bool CanMove(Position position)
        {
            if (position.X > _length / 2 || position.X < (-1 * _length / 2))
                return false;
            else if (position.Y > _breath / 2 || position.Y < (-1 * _breath / 2))
                return false;
            return true;
        }
    }
}
