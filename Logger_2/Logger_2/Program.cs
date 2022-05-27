namespace Logger_2
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Services.GetData getData = new Services.GetData();
            Services.Starter starter = new Services.Starter();
            starter.Run();
            getData.GetInfo(starter);
            getData.File(new Services.Files(), starter.Report);
        }
    }
}
