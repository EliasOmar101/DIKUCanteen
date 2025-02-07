namespace DIKUCanteen;

public class CanteenBoardMember : Student
{
    private static int CupBudget = 10; 

    public CanteenBoardMember(string name, string occupation, int age)
        : base(name, occupation, age)
    {

    }

    
    public void BuyCup(Canteen canteen, int amount)
    {
        if (CupBudget >= amount)
        {
            canteen.IncreaseCup();
            CupBudget -= amount;
            Console.WriteLine($"{Name} bought {amount} cups for {canteen.Name}. Remaining budget: {CupBudget}");
        }
        else
        {
            Console.WriteLine($"{Name} cannot buy {amount} cups, not enough budget!");
        }
    }
}

