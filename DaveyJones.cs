namespace ConsoleApp
{
    class DaveyJones : Character
{
    public DaveyJones()
    {
        Name = "Davey Jones";
        MaxPower = new Random().Next(1, 101);
        Health = 100;
        AttackStrength = new Random().Next(1, MaxPower + 1);
        DefensePower = new Random().Next(1, MaxPower + 1);
    }

    public override string AttackName => "Cannon fire";
}
}