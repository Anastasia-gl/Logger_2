namespace Logger_2.Models
{
    internal class Logger
    {
        public string Message { get; set; }

        public string[] Type { get; set; } = new string[3] {"Info", "Error","Warning"};

    }
}
