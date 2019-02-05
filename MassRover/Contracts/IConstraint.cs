using MassRover.Core.Model;

namespace MassRover.Core.Contracts
{
    public interface IConstraint
    {
        bool CanMove(Position position);
    }
}
