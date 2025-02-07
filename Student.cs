namespace DIKUCanteen;

public class Student : Person
{
    public bool HasCup { get; private set; } 
    public Student(string name, string occupation, int age) 
        : base(name, occupation, age)
    {
        HasCup = false; 
    }

    
    public void TakeCup(Canteen canteen)
    {
        if (!HasCup && canteen.Cups > 0)
        {
            canteen.DecreaseCup();
            HasCup = true;
            Console.WriteLine($"{Name} took a cup from {canteen.Name}.");
        }
        else
        {
            Console.WriteLine($"{Name} cannot take a cup!");
        }
    }

   
    public void ReturnCup(Canteen canteen)
    {
        if (HasCup)
        {
            canteen.IncreaseCup();
            HasCup = false;
            Console.WriteLine($"{Name} returned a cup to {canteen.Name}.");
        }
        else
        {
            Console.WriteLine($"{Name} has no cup to return!");
        }
    }
}
