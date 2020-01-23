namespace Lucilvio.DesignPatterns.ECommerce.Problematic
{
    public class Logger
    {
        public void Log(string message)
        {
            System.Console.WriteLine($"LOG: {message}");
        }
    }
}