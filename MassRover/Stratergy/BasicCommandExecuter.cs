using MassRover.Core.Contracts;
using MassRover.Core.Model;

namespace MassRover.Core.Stratergy
{
    public class BasicCommandExecuter : ICommandExecuter
    {
        private IMoveStratergy _moveStratergy { get; }
        
        public BasicCommandExecuter(IMoveStratergy moveStratergy)
        {
            _moveStratergy = moveStratergy;
        }

        public Position Execute(Position position, Command command)
        {
            var currentPosition = position as PositionVector;
            var orientation = currentPosition.Orientation;

            switch (command)
            {
                case Command.Left:
                    var newOrientation = orientation.TurnLeft as Direction;
                    return new PositionVector(currentPosition.X, currentPosition.Y, newOrientation);

                case Command.Right:
                    newOrientation = orientation.TurnRight as Direction;
                    return new PositionVector(currentPosition.X, currentPosition.Y, newOrientation);
                    
                default:
                    var positionChange 
                        = _moveStratergy.GetPositionChange(command, currentPosition.Orientation);

                    var newXPosition = currentPosition.X + positionChange.X;

                    var newYPosition = currentPosition.Y + positionChange.Y;

                    return 
                        new PositionVector(newXPosition, newYPosition, orientation);
            }
        }
    }
}
