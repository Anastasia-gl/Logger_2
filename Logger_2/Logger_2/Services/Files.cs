using Newtonsoft.Json;

namespace Logger_2.Services
{
    internal class Files : Interfaces.Services.IFile
    {
        public string Text { get; set; }
        private string path = DateTime.Now.ToString("hh_mm_ss dd-MM-yyyy") + ".txt";
        private string _dirPath = @"C:\Users\Anastasia\Desktop\GIT\Logger_2\Logger_2\Logger_2\bin\Debug\net6.0\files";

        public void WriteJsonDir()
        {
            var json = JsonConvert.SerializeObject(_dirPath);
            File.WriteAllText("configs.json", json);
        }

        public void CreateDir()
        {
            var dir = File.ReadAllText("configs.json");
            var dir1 = JsonConvert.DeserializeObject(dir);
            DirectoryInfo directoryInfo = new DirectoryInfo((string)dir1);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
        }

        public void WriteText(string text)
        {
            Text += text;
        }

        public void Save()
        {
            string pathString = Path.Combine(_dirPath, path);
            using (var sw = new StreamWriter(pathString, false))
            {
                sw.WriteLine(Text);
            }
        }

        public void Delete()
        {
            DirectoryInfo directory = new DirectoryInfo(_dirPath);
            int count = 0;

            for (int i = 0; i < directory.GetFiles().Length; i++)
            {
                count++;
                if (count > 3)
                {
                    directory.GetFiles()[2].Delete();
                }
            }

        }
    }
}

