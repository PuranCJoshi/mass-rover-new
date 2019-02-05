using MassRover.Core.Contracts;
using MassRover.Core.Model;

namespace MassRover.Core
{
    public abstract class Movable
    {
        private readonly Canvas _canvas;
        private readonly ICommandExecuter _commandExecuter;
        private readonly IDirectionLink _directionLink;

        public Movable(Position position, Canvas canvas)
        {
            _canvas = canvas;
            Position = position;
            _directionLink.CreateLink();
        }

        public Movable(Position position, Canvas canvas, ICommandExecuter commandExecuter, IDirectionLink directionLink)
        {
            _canvas = canvas;
            Position = position;
            _commandExecuter = commandExecuter;
            _directionLink = directionLink;
            _directionLink.CreateLink();
        }

        public virtual Position ExecuteCommand(Command command)
        {
            Position 
                = _commandExecuter.Execute(Position, command, _canvas);

            return Position;
        }

        public Position Position { get; private set; }
    }
}
