namespace DIKUCanteen;

public class Canteen : Room
{
    private int cups; 

    public int Cups => cups; 

    public Canteen(string name) : base(name)
    {
        cups = 100;
    }

    public Canteen(string name, int cups) : base(name)
    {
        this.cups = cups;
    }

    
    public void DecreaseCup()
    {
        if (cups > 0)
        {
            cups--;
        }
    }

    public void IncreaseCup()
    {
        cups++;
    }

    public override string ToString()
    {
        return $"{Name} has {cups} cups.";
    }
}
