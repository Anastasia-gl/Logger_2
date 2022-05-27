namespace Logger_2.Services
{
    internal class Actions : Interfaces.Services.IActions
    {
        Models.Flags flag = new Models.Flags();

        public bool StartMethod()
        {
            flag.Flag = true;
            return flag.Flag;
        }

        public bool SecondMethod()
        {
            throw new Exceptions.BusinessException("Skipped logic in method");
            return flag.Flag  = false;
        }

        public bool ThirdMethod()
        {
            throw new Exception("I broke a logic");
            return flag.Flag = false;
        }
    }
}
