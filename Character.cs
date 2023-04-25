namespace ConsoleApp
{
    abstract class Character
    {
        public string Name { get; protected set; }
        public int MaxPower { get; protected set; }
        public int Health { get; protected set; }
        public int AttackStrength { get; protected set; }
        public int DefensePower { get; protected set; }
        public abstract string AttackName { get; }
        public int DefensivePower { get; private set; }

        public virtual bool IsAlive()
{
    return this.Health > 0;
}

    //      public bool IsAlive
    // {
    //     get
    //     {
    //         return Health > 0;
    //     }
    // }

        public int Attack(Character opponent)
        {
            int damage = new Random().Next(1, AttackStrength + 1);
            opponent.Defend(damage);
            return damage;
        }

        public void Defend(int damage)
    {
        int damageTaken = damage - DefensivePower;
        if (damageTaken > 0)
        {
            Health -= damageTaken;
            Console.WriteLine($"{Name} takes {damageTaken} damage.");
        }
        else
        {
            Console.WriteLine($"{Name} successfully defends against the attack!");
        }
        Console.WriteLine($"{Name}'s remaining health: {Health}");
    }

       




        // public void Defend(int damage)
        // {

        //     Health -= damage / DefensePower;
        //     if (Health < 0)
        //     {
        //         Health = 0;
        //     }
        // }

        // internal void Defend(int damage)
        // {
        //     Health -= damage / DefensePower;
        //     if (Health < 0)
        //     {
        //         Health = 0;
        //     }
        // }
    }
}