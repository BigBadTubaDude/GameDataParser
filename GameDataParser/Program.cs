using GameDataParser.Classes;

namespace GameDataParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //main code           
            }
            catch (Exception error)
            {
                FileLogger logger = new FileLogger("log.txt");
                logger.LogError(new Exception("wrong thing happened"));
            }
        }
    }
}
