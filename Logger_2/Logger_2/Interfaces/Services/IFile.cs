namespace Logger_2.Interfaces.Services
{
    internal interface IFile
    {
        public void WriteText(string text);

        public void Save();

        public void WriteJSON();
    }
}
