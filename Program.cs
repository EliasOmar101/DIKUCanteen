    using System;

namespace DIKUCanteen;

class Program
{
    static void Main()
    {
    
        Canteen dikucanteen = new Canteen("DIKU Canteen", 5);

        
        Student student1 = new Student("Alice", "Student", 22);
        Student student2 = new Student("Bob", "Student", 24);
        CanteenBoardMember boardMember = new CanteenBoardMember("Charlie", "Board Member", 25);


        Console.WriteLine(dikucanteen);

       
        student1.TakeCup(dikucanteen);
        student2.TakeCup(dikucanteen);
        Console.WriteLine(dikucanteen);

   
        student1.TakeCup(dikucanteen);


        student1.ReturnCup(dikucanteen);
        Console.WriteLine(dikucanteen);


        boardMember.BuyCup(dikucanteen, 3);
        Console.WriteLine(dikucanteen);
    }
}

}

