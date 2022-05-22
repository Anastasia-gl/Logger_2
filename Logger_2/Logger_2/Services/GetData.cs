namespace Logger_2.Services
{
    internal class GetData : Interfaces.Services.IGetData
    {  
        public void GetInfo(Interfaces.Services.IStarter starter)
        {
            starter.PrintToConsole();
        }   

        public void File(Interfaces.Services.IFile file, string str)
        {
            file.WriteText(str);
            file.Save();
            file.WriteJSON();
        }
    }
}
