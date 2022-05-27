namespace Logger_2.Services
{
    internal class Starter : Interfaces.Services.IStarter
    {
        public string Report { get; set; }

        Models.Logger logger = new Models.Logger();

        public void Run()
        {
            Random random = new Random();
            Actions act = new Actions();

            int number = random.Next(0, 3);
            for (int i = 0; i < 100; i++)
            {
                if (number == 0)
                {
                    if (act.StartMethod())
                    {
                      Report = $"{DateTime.Now:HH:mm:ss} {logger.Type[0]}";
                    }
                }

                if (number == 1)
                {
                    try
                    {
                        act.SecondMethod();
                    }
                    catch (Exceptions.BusinessException ex)
                    {
                        logger.Message = $"Action got this custom Exception: {ex.Message}";
                        Report = $"{DateTime.Now:HH:mm:ss} {logger.Type[2]}  {logger.Message} ";
                    }
                }
                if (number == 2)
                {
                    try
                    {
                        act.ThirdMethod();
                    }
                    catch (Exception ex)
                    {
                        logger.Message = $"Action failed by a reson: {ex.Message}";
                        Report = $"{DateTime.Now:HH:mm:ss}  {logger.Type[1]}  {logger.Message} ";
                    }
                }
                break;
            }
        }

        public void PrintToConsole()
        {
            Console.Write(Report);
        }
    }
}

