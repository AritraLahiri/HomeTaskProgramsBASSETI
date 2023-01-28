using HomeTasksLogic;
namespace HomeTaskMain
{
    internal class Task
    {
        static void Main(string[] args)
        {
            Logic logic = new();
            logic.SetValueToArray();
            Console.WriteLine("Enter a valid Id to check");
            logic.IsValidId(Console.ReadLine());
        }











    }
}
