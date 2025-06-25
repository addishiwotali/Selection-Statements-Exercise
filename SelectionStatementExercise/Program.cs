namespace SelectionStatementExercise
{
    public class Program
    {
     static void Main(string[] args)
        { 
         var random = new Random(); 
         var favNumber = random.Next(1,15);
         int response = 0;


         while (response != favNumber)
         {
             Console.WriteLine("Please enter a number between 1 and 15.");
             response = int.Parse(Console.ReadLine());
             
             if (response < favNumber)
             {
                 Console.WriteLine($"Too low!\nyour guess; {response} ");
             }
            
             else if (response > favNumber)
             {
                 Console.WriteLine($"Too high!\nyour guess; {response} ");
             }

             else
             {
                 Console.WriteLine($"you guessed it!\nYour guess; {response} ");
             } 
         }
        }
    }
}
