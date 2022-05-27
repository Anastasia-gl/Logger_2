namespace Logger_2.Interfaces.Services
{
    internal interface IGetData
    {
        public void GetInfo(IStarter starter);

        public void File(IFile file, string str);
    }
}
