using System;

namespace consola_duel_monster
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARA LAS DESCRIPSIONES DE LOS VALORES
            monster monster1 = new monster();
            monster1.nombre = "OBELISCO ATORMENTADOR";
            monster1.ataque = 4000;
            monster1.defensa = 4000;

            monster monster2 = new monster();
            monster2.nombre = "DRAGON ALDO DE RA";
            monster2.ataque = 4000;
            monster2.defensa = 4000;

            monster monster3 = new monster();
            monster3.nombre = "SLIFER DRAGON CELESTIAL";
            monster3.ataque = 4000;
            monster3.defensa = 4000;

            monster monster4 = new monster();
            monster4.nombre = "DRAGON BLANCO DE OJOS AZULES";
            monster4.ataque = 3000;
            monster4.defensa = 2500;

            monster monster5 = new monster();
            monster5.nombre = "MAGO OSCURO";
            monster5.ataque = 2500;
            monster5.defensa = 2100;

            //DECLARA E INSERTA LOS VALORES EN LA CONSOLA
            Console.WriteLine($"el es {monster1.nombre}");
            Console.WriteLine($"tiene {monster1.ataque} de ataque" + $" y {monster1.defensa} de defensa");

            Console.WriteLine($"el es {monster2.nombre}");
            Console.WriteLine($"tiene {monster2.ataque} de ataque" + $" y {monster2.defensa} de defensa");

            Console.WriteLine($"el es {monster3.nombre}");
            Console.WriteLine($"tiene {monster3.ataque} de ataque" + $" y {monster3.defensa} de defensa");

            Console.WriteLine($"el es {monster4.nombre}");
            Console.WriteLine($"tiene {monster4.ataque} de ataque" + $" y {monster4.defensa} de defensa");

            Console.WriteLine($"el es {monster5.nombre}");
            Console.WriteLine($"tiene {monster5.ataque} de ataque" + $" y {monster5.defensa} de defensa");

        }
    }
}
