namespace ChessAssistanceMain.Source.Model
{
    [Serializable]
    public class EngineSetting
    {
        public string Name { get; set; }
        public string ExecutablePath { get; set; }
        public string[] Arguments { get; set; }
    }
}
