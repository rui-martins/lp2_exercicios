using System.Collections.Generic;

namespace _016
{
    public class Group : List<IUnit>, IUnit
    {
        // Propriedade que indica o número total de todas as Units no Group e
        // em sub-Groups
        public string UnitName
        {
            get
            {
                int totalUnits = 0;

                // Percorre todas as IUnit no Group
                foreach (IUnit unit in this)
                {
                    if (unit is Group)
                    {
                        // Soma ao total a quantidade de Units contidas no
                        // sub-Group
                        totalUnits += (unit as Group).Count;
                    }
                    else
                        // Incrementa o total por cada Unit no Group
                        totalUnits++;
                }
                // Devolve o total das Units
                return $"Group of {totalUnits} units";
            }
        }

        // Propriedade que indica a Position central do Group
        public Vector2 Position
        {
            get
            {
                float sumX = 0f;
                float sumY = 0f;

                // Percorre todas as IUnit's no Group
                foreach (IUnit unit in this)
                {
                    // Soma todas as posições das units
                    sumX += unit.Position.X;
                    sumY += unit.Position.Y;
                }

                // Devolve a centroide das Units
                return new Vector2(sumX / Count, sumY / Count);
            }
        }

        // Propriedade que indica a média da Health do Group
        public float Health
        {
            get
            {
                float totalHealth = 0;

                // Percorre todas as IUnit e soma ao total da Health
                foreach (IUnit unit in this)
                    totalHealth += unit.Health;

                // Devolve a média da Health
                return totalHealth / Count;

            }
        }

        public Group() : base() { }


        public void Move(Vector2 newPosition)
        {
            // Calcula o movimento dos vetores
            Vector2 moveToPos = new Vector2(
                (newPosition.X - Position.X),
                (newPosition.Y - Position.Y));

            // Verifica cada Unit no Group e move-as com o vetor da deslocação
            foreach (IUnit unit in this)
            {
                // Move a Unit de acordo com a posição atual mais a atualização
                // para onde tem de ir
                unit.Move(new Vector2(
                    unit.Position.X + moveToPos.X,
                    unit.Position.Y + moveToPos.Y));
            }
        }

        public override string ToString()
        {
            return $"{UnitName} at ({Position.X:f1}, {Position.Y:f1}) " +
                $"with {Health:f1} HP";
        }
    }
}