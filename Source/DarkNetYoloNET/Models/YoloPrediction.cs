using System.Drawing;

namespace DarkNetYoloNET.Models
{
    public class YoloPrediction
    {
        public Rectangle Rectangle { get; set; }

        public string Label { get; set; }

        public double Confidence { get; set; }
    }
}
