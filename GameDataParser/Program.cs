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
                FileLogger logger = new FileLogger("log.txt");
                logger.LogError(new Exception("wrong thing happened"));
            }
            catch (Exception error)
            {

            }
        }
    }
}
