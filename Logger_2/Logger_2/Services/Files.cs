using Newtonsoft.Json;

namespace Logger_2.Services
{
    internal class Files : Interfaces.Services.IFile
    {
        public string Text { get; set; }
        public int _index = 0;
        string path = DateTime.Now.ToString("hh_mm_ss dd-MM-yyyy") + ".txt";


        public void WriteText(string text)
        {
            Text += text;
        }

        public void Save()
        {
            using (var sw = new StreamWriter(path, false))
            {
                sw.WriteLine(Text);
            }
        }

        public void WriteJSON()
        {
            var json = JsonConvert.SerializeObject(path);
            File.WriteAllText("config.json", json);
        }
    }
}
