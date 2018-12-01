using System;
using System.Collections.Generic;
using System.Text;

namespace _016
{
    public class Group : List<IUnit>, IUnit
    {
        public string UnitName
        {
            get
            {
                int totalUnits = 0;
                foreach (IUnit unit in this)
                {
                    if (unit is Group)
                    {
                        totalUnits += (unit as Group).Count;
                    }
                    else
                        totalUnits++;
                }
                // Devolve o total das Units
                return $"Group of {totalUnits} units";
            }
        }

        public Vector2 Position
        {
            get
            {
                float posX = 0f;
                float posY = 0f;
                foreach (IUnit unit in this)
                {
                    posX += unit.Position.X;
                    posY += unit.Position.Y;
                }
                // Devolve a centroide das Units
                return new Vector2(posX / Count, posY / Count);
            }
        }

        public float Health
        {
            get
            {
                float totalHealth = 0;
                foreach (IUnit unit in this)
                    totalHealth += unit.Health;
                // Devolve a média da Health
                return totalHealth / Count;

            }
        }

        public Group() : base() { }

        public void Move(Vector2 newPosition)
        {
            // Calcular o movimento dos vetores
            Vector2 moveToPos = new Vector2(
                (newPosition.X - Position.X),
                (newPosition.Y - Position.Y));

            foreach (IUnit unit in this)
            {
                if (unit is Group)
                {
                    // Mover os Groups contidos no Group
                    foreach (Unit unitInGroup in (unit as Group))
                    {
                        unitInGroup.Position = new Vector2(
                            unitInGroup.Position.X - moveToPos.X,
                            unitInGroup.Position.Y - moveToPos.Y);
                    }
                }
                else
                {
                    // Mover as Units contidas no Group
                    (unit as Unit).Position = new Vector2(
                        unit.Position.X - moveToPos.X,
                        unit.Position.Y - moveToPos.Y);
                }

            }
        }

        public override string ToString()
        {
            return $"{UnitName} at ({Position.X:f1}, {Position.Y:f1}) " +
                $"with {Health:f1} HP";
        }
    }
}