using MassRover.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MassRover.Core.Contracts
{
    public interface IDirection
    {
        string Name { get;  }
        Position PositionChange(double stepSize);
        IDirection TurnLeft { get; }
        IDirection TurnRight { get; }
    }
}
