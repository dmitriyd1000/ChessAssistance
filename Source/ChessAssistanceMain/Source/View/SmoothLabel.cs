using static System.Drawing.Text.TextRenderingHint;

namespace ChessAssistanceMain.Source.View
{
    public class SmoothLabel : Label
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = Font.Size > 15 ? AntiAliasGridFit : SystemDefault;
            base.OnPaint(e);
        }
    }
}
