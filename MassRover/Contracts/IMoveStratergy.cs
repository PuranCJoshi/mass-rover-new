using MassRover.Core.Model;

namespace MassRover.Core.Contracts
{
    public interface IMoveStratergy
    {
        Position GetPositionChange(Command command, IDirection direction);
    }
}
