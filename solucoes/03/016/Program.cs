using System;

namespace _016
{
    class Program
    {
        static void Main(string[] args)
        {

            // Criar Units
            Unit soldier = new Unit("Soldier", new Vector2(10, 20), 50f);
            Unit sniper = new Unit("Sniper", new Vector2(20, 6), 30f);
            Unit tank = new Unit("Tank", new Vector2(5, 5), 200f);

            // Criar um Group e adicionar as Units
            Group group = new Group();
            group.Add(soldier);
            group.Add(sniper);
            group.Add(tank);

            // Verificar as propriedades todas das unidades dentro do Group
            foreach(IUnit unit in group)
            {
                Console.WriteLine(unit);
            }
            Console.WriteLine(group + "\n\n");

            // Mover o Group para a posição 5, 10
            group.Move(new Vector2(5, 10));

            // Verificar que as Units moveram-se todas de facto
            foreach (IUnit unit in group)
            {
                Console.WriteLine(unit);
            }
            Console.WriteLine(group + "\n\n");

            // Criar outro Group e adicionar o primeiro Group e mais Units
            Group biggerGroup = new Group();
            Unit mercenary = new Unit("Mercenary", new Vector2(20, 20), 60f);
            Unit mercenary2 = new Unit("Mercenary 2", new Vector2(19, 20), 60f);
            biggerGroup.Add(group);
            biggerGroup.Add(mercenary);
            biggerGroup.Add(mercenary2);

            // Verificar as posições das Units no Group maior
            foreach (IUnit unit in biggerGroup)
            {
                Console.WriteLine(unit);
            }
            Console.WriteLine(biggerGroup + "\n\n");

            // Mover o Group maior para a posição 10, 10
            biggerGroup.Move(new Vector2(10, 10));

            // Verifcar de novo as posições do Group maior
            foreach (IUnit unit in biggerGroup)
            {
                Console.WriteLine(unit);
            }
            Console.WriteLine(biggerGroup);



        }
    }
}
