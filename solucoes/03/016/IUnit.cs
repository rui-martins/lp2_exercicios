using System;
using System.Collections.Generic;
using System.Text;

namespace _016
{
    public interface IUnit
    {
        string UnitName { get; }
        Vector2 Position { get; }
        float Health { get; }

        void Move(Vector2 newPosition);
    }
}