using BerldChess.Properties;
using ChessAssistanceMain.Source.Model;
using ilf.pgn.Data;
using System.ComponentModel;
using ilf.pgn;

namespace ChessAssistanceMain.Source.View
{
    public partial class FormPgnLoader : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Game PgnLoadedGame { get; set; } = null;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Analysis { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Depth { get; set; }

        public FormPgnLoader(bool analysis, int depth)
        {
            InitializeComponent();
            InitializeWindow();

            _checkBoxAnalysis.Checked = analysis;
            _textBoxDepth.Enabled = analysis;

            if(analysis)
            {
                _textBoxDepth.Text = depth.ToString();
            }
        }

        private void InitializeWindow()
        {
            Icon = Resources.PawnRush;
        }

        private void OnButtonLoadClick(object sender, EventArgs e)
        {
            try
            {
                PgnReader reader = new PgnReader();
                Database database = reader.ReadFromFile(_textBoxPgnInput.Text);

                if (database.Games.Count > 0)
                {
                    Game firstGame = database.Games[0];
                    PgnLoadedGame = firstGame;

                    Analysis = _checkBoxAnalysis.Checked;

                    int parseDepth;
                    bool parsed = int.TryParse(_textBoxDepth.Text, out parseDepth);

                    if (parsed)
                    {
                        Depth = Math.Abs(parseDepth);
                    }
                    else
                    {
                        Analysis = false;
                    }

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("No valid game found.", "BerldChess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with reading input.\n\n" + ex.Message, "BerldChess", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnButtonChooseFileClick(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = SerializedInfo.Instance.LastPgnDir;
            fileDialog.Filter = "pgn files (*.pgn)|*.pgn";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                SerializedInfo.Instance.LastPgnDir = fileDialog.FileName;

                try
                {
                    PgnReader reader = new PgnReader();
                    Database database = reader.ReadFromFile(fileDialog.FileName);

                    if (database.Games.Count > 0)
                    {
                        Game firstGame = database.Games[0];
                        PgnLoadedGame = firstGame;

                        Analysis = _checkBoxAnalysis.Checked;

                        int parseDepth;
                        bool parsed = int.TryParse(_textBoxDepth.Text, out parseDepth);

                        if (parsed)
                        {
                            Depth = Math.Abs(parseDepth);
                        }
                        else
                        {
                            Analysis = false;
                        }

                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("No valid game found.", "BerldChess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error with reading input.\n\n" + ex.Message, "BerldChess", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OnButtonCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OnCheckBoxAnalysisCheckedChanged(object sender, EventArgs e)
        {
            _textBoxDepth.Enabled = _checkBoxAnalysis.Checked;
        }
    }
}
