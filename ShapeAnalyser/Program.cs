using NLog;
using ShapeAnalyser;
using ShapeAnalyser.Factories;

namespace YourNamespace
{
    class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            try
            {
                Logger.Info("Application started.");
                Console.WriteLine("Enter the lengths of the triangle's sides separated by spaces:");

                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    var message = "Invalid input. Please enter the lengths of the triangle's sides separated by spaces.";
                    Logger.Warn(message);
                    Console.WriteLine(message);
                    return;
                }

                var sides = Array.ConvertAll(input.Trim().Split(' '), double.Parse);

                var shapeClassifier = new ShapeClassifier(new TriangleFactory());

                var shapeType = shapeClassifier.DetermineShapeType(sides);

                Console.WriteLine($"Triangle type: {shapeType}");

                Logger.Info("Application ended successfully.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "An error occurred.");
                Console.WriteLine("An error occurred. Please check the logs for more details.");
            }
            finally
            {
                LogManager.Shutdown();
            }
        }
    }
}