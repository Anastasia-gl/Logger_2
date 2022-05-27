namespace Logger_2.Interfaces.Services
{
    internal interface IFile
    {
        public void WriteText(string text);

        public void Save();

        public void WriteJsonDir();
        public void CreateDir();
        public void Delete();
    }
}
