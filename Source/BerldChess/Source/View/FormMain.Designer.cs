namespace BerldChess.View
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
	        this.components = new System.ComponentModel.Container();
	        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
	        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
	        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
	        this._timerValidation = new System.Windows.Forms.Timer(this.components);
	        this._timerAutoCheck = new System.Windows.Forms.Timer(this.components);
	        this._timerAutoRecognition = new System.Windows.Forms.Timer(this.components);
	        this._menuItemGame = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemLoadFen = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemCopyFen = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemLoadPgn = new System.Windows.Forms.ToolStripMenuItem();
	        this.getBoardFromScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.getBoardFromPrevScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemEngine = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemEngineSettings = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemMultiPv = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemComputerMove = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemAutoPlay = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemDepthAnalysis = new System.Windows.Forms.ToolStripMenuItem();
	        this.startTimeAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemCheatMode = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemAnimationTime = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemClickDelay = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemAutoMove = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemCheckAuto = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemLevel = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemAppearance = new System.Windows.Forms.ToolStripMenuItem();
	        this.alterBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemAlterPieces = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemFlipBoard = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemLocalMode = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemHideOutput = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemHideArrows = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemFilterArrows = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuIllegalSound = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemIllegalSound = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemDisplayLegalMoves = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemDisplayCoordinates = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemNavigation = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemGoBack = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemGoForward = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemGoToStart = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemGoToLatest = new System.Windows.Forms.ToolStripMenuItem();
	        this._menuItemBlackTime = new System.Windows.Forms.ToolStripTextBox();
	        this._menuItemWhiteTime = new System.Windows.Forms.ToolStripTextBox();
	        this._menuStripMain = new System.Windows.Forms.MenuStrip();
	        this._panelRight = new System.Windows.Forms.Panel();
	        this.tabTables = new System.Windows.Forms.TabControl();
	        this.tabTableView = new System.Windows.Forms.TabPage();
	        this._tableLayoutPanelModules = new System.Windows.Forms.TableLayoutPanel();
	        this._dataGridViewMoves = new System.Windows.Forms.DataGridView();
	        this._whiteMove = new System.Windows.Forms.DataGridViewTextBoxColumn();
	        this._blackMove = new System.Windows.Forms.DataGridViewTextBoxColumn();
	        this._panelEvaluationChart = new System.Windows.Forms.Panel();
	        this.tabTreeView = new System.Windows.Forms.TabPage();
	        this.tabPaths = new System.Windows.Forms.TreeView();
	        this.tabSnapshotSettings = new System.Windows.Forms.TabPage();
	        this.btnCancelRecogn = new System.Windows.Forms.Button();
	        this.prgbarRecognition = new System.Windows.Forms.ProgressBar();
	        this.grpbxAutoRefresh = new System.Windows.Forms.GroupBox();
	        this.lbLastRecognTime = new System.Windows.Forms.Label();
	        this.lebel44 = new System.Windows.Forms.Label();
	        this.label3 = new System.Windows.Forms.Label();
	        this.txtbxRefreshTime = new System.Windows.Forms.TextBox();
	        this.label2 = new System.Windows.Forms.Label();
	        this.chkbxIsAutoRefresh = new System.Windows.Forms.CheckBox();
	        this.label1 = new System.Windows.Forms.Label();
	        this.numbxTolleranceRecogn = new System.Windows.Forms.NumericUpDown();
	        this.chkbxEnPassant = new System.Windows.Forms.CheckBox();
	        this.grbxCastle = new System.Windows.Forms.GroupBox();
	        this.chkbxCanBlackCastleQueenSide = new System.Windows.Forms.CheckBox();
	        this.chkbxCanBlackCastleKingSide = new System.Windows.Forms.CheckBox();
	        this.chkbxCanWhiteCastleQueenSide = new System.Windows.Forms.CheckBox();
	        this.chkbxCanWhiteCastleKingSide = new System.Windows.Forms.CheckBox();
	        this.grbxWhoseTurn = new System.Windows.Forms.GroupBox();
	        this.rbutBlackTurn = new System.Windows.Forms.RadioButton();
	        this.rbutWhiteTurn = new System.Windows.Forms.RadioButton();
	        this._tableLayoutPanelEvalInfos = new System.Windows.Forms.TableLayoutPanel();
	        this._labelTime = new BerldChess.View.SmoothLabel();
	        this._labelNPS = new BerldChess.View.SmoothLabel();
	        this._labelDepth = new BerldChess.View.SmoothLabel();
	        this._labelShowNodes = new BerldChess.View.SmoothLabel();
	        this._labelShowDepth = new BerldChess.View.SmoothLabel();
	        this._labelShowTime = new BerldChess.View.SmoothLabel();
	        this._labelShowNPS = new BerldChess.View.SmoothLabel();
	        this._labelNodes = new BerldChess.View.SmoothLabel();
	        this._labelEvaluation = new BerldChess.View.SmoothLabel();
	        this._labelShowEvaluation = new BerldChess.View.SmoothLabel();
	        this._splitContainerBoard = new System.Windows.Forms.SplitContainer();
	        this._dataGridViewEvaluation = new System.Windows.Forms.DataGridView();
	        this._splitContainerMain = new System.Windows.Forms.SplitContainer();
	        this._menuStripMain.SuspendLayout();
	        this._panelRight.SuspendLayout();
	        this.tabTables.SuspendLayout();
	        this.tabTableView.SuspendLayout();
	        this._tableLayoutPanelModules.SuspendLayout();
	        ((System.ComponentModel.ISupportInitialize)(this._dataGridViewMoves)).BeginInit();
	        this.tabTreeView.SuspendLayout();
	        this.tabSnapshotSettings.SuspendLayout();
	        this.grpbxAutoRefresh.SuspendLayout();
	        ((System.ComponentModel.ISupportInitialize)(this.numbxTolleranceRecogn)).BeginInit();
	        this.grbxCastle.SuspendLayout();
	        this.grbxWhoseTurn.SuspendLayout();
	        this._tableLayoutPanelEvalInfos.SuspendLayout();
	        ((System.ComponentModel.ISupportInitialize)(this._splitContainerBoard)).BeginInit();
	        this._splitContainerBoard.Panel2.SuspendLayout();
	        this._splitContainerBoard.SuspendLayout();
	        ((System.ComponentModel.ISupportInitialize)(this._dataGridViewEvaluation)).BeginInit();
	        ((System.ComponentModel.ISupportInitialize)(this._splitContainerMain)).BeginInit();
	        this._splitContainerMain.Panel1.SuspendLayout();
	        this._splitContainerMain.Panel2.SuspendLayout();
	        this._splitContainerMain.SuspendLayout();
	        this.SuspendLayout();
	        // 
	        // _timerValidation
	        // 
	        this._timerValidation.Enabled = true;
	        this._timerValidation.Interval = 17;
	        this._timerValidation.Tick += new System.EventHandler(this.OnTimerValidationTick);
	        // 
	        // _timerAutoCheck
	        // 
	        this._timerAutoCheck.Enabled = true;
	        this._timerAutoCheck.Interval = 40;
	        this._timerAutoCheck.Tick += new System.EventHandler(this.OnTimerAutoCheckTick);
	        // 
	        // _timerAutoRecognition
	        // 
	        this._timerAutoRecognition.Interval = 10000;
	        this._timerAutoRecognition.Tick += new System.EventHandler(this.OnTimerAutoRecognitionTick);
	        // 
	        // _menuItemGame
	        // 
	        this._menuItemGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this._menuItemNew, this._menuItemLoadFen, this._menuItemCopyFen, this._menuItemLoadPgn, this.getBoardFromScreenToolStripMenuItem, this.getBoardFromPrevScreenToolStripMenuItem });
	        this._menuItemGame.Name = "_menuItemGame";
	        this._menuItemGame.Size = new System.Drawing.Size(75, 32);
	        this._menuItemGame.Text = "Game";
	        // 
	        // _menuItemNew
	        // 
	        this._menuItemNew.Name = "_menuItemNew";
	        this._menuItemNew.ShortcutKeyDisplayString = "N";
	        this._menuItemNew.Size = new System.Drawing.Size(394, 32);
	        this._menuItemNew.Tag = "";
	        this._menuItemNew.Text = "New";
	        this._menuItemNew.Click += new System.EventHandler(this.OnMenuItemNewClick);
	        // 
	        // _menuItemLoadFen
	        // 
	        this._menuItemLoadFen.Name = "_menuItemLoadFen";
	        this._menuItemLoadFen.ShortcutKeyDisplayString = "L";
	        this._menuItemLoadFen.Size = new System.Drawing.Size(394, 32);
	        this._menuItemLoadFen.Tag = "";
	        this._menuItemLoadFen.Text = "Load from FEN";
	        this._menuItemLoadFen.Click += new System.EventHandler(this.OnMenuItemLoadFenClick);
	        // 
	        // _menuItemCopyFen
	        // 
	        this._menuItemCopyFen.Name = "_menuItemCopyFen";
	        this._menuItemCopyFen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
	        this._menuItemCopyFen.Size = new System.Drawing.Size(394, 32);
	        this._menuItemCopyFen.Text = "Copy FEN To Clipboard";
	        this._menuItemCopyFen.Click += new System.EventHandler(this.OnMenuItemCopyFenClick);
	        // 
	        // _menuItemLoadPgn
	        // 
	        this._menuItemLoadPgn.Name = "_menuItemLoadPgn";
	        this._menuItemLoadPgn.Size = new System.Drawing.Size(394, 32);
	        this._menuItemLoadPgn.Text = "Load from PGN";
	        this._menuItemLoadPgn.Click += new System.EventHandler(this.OnMenuItemLoadPgnClick);
	        // 
	        // getBoardFromScreenToolStripMenuItem
	        // 
	        this.getBoardFromScreenToolStripMenuItem.Name = "getBoardFromScreenToolStripMenuItem";
	        this.getBoardFromScreenToolStripMenuItem.ShortcutKeyDisplayString = "G";
	        this.getBoardFromScreenToolStripMenuItem.Size = new System.Drawing.Size(394, 32);
	        this.getBoardFromScreenToolStripMenuItem.Text = "Get Board from new screen";
	        this.getBoardFromScreenToolStripMenuItem.Click += new System.EventHandler(this.getBoardFromScreenToolStripMenuItem_Click);
	        // 
	        // getBoardFromPrevScreenToolStripMenuItem
	        // 
	        this.getBoardFromPrevScreenToolStripMenuItem.Name = "getBoardFromPrevScreenToolStripMenuItem";
	        this.getBoardFromPrevScreenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
	        this.getBoardFromPrevScreenToolStripMenuItem.Size = new System.Drawing.Size(394, 32);
	        this.getBoardFromPrevScreenToolStripMenuItem.Text = "Get Board from prev screen";
	        this.getBoardFromPrevScreenToolStripMenuItem.Click += new System.EventHandler(this.getBoardFromPrevScreenToolStripMenuItem_Click);
	        // 
	        // _menuItemEngine
	        // 
	        this._menuItemEngine.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this._menuItemEngineSettings, this._menuItemMultiPv, this._menuItemComputerMove, this._menuItemAutoPlay, this._menuItemDepthAnalysis, this.startTimeAnalysisToolStripMenuItem, this._menuItemCheatMode });
	        this._menuItemEngine.Name = "_menuItemEngine";
	        this._menuItemEngine.Size = new System.Drawing.Size(83, 32);
	        this._menuItemEngine.Text = "Engine";
	        // 
	        // _menuItemEngineSettings
	        // 
	        this._menuItemEngineSettings.Name = "_menuItemEngineSettings";
	        this._menuItemEngineSettings.Size = new System.Drawing.Size(237, 32);
	        this._menuItemEngineSettings.Text = "Engine Settings";
	        this._menuItemEngineSettings.Click += new System.EventHandler(this.OnMenuItemEngineSettingsClick);
	        // 
	        // _menuItemMultiPv
	        // 
	        this._menuItemMultiPv.Name = "_menuItemMultiPv";
	        this._menuItemMultiPv.Size = new System.Drawing.Size(237, 32);
	        this._menuItemMultiPv.Text = "MultiPv";
	        this._menuItemMultiPv.Click += new System.EventHandler(this.OnMenuItemMultiPvClick);
	        // 
	        // _menuItemComputerMove
	        // 
	        this._menuItemComputerMove.Name = "_menuItemComputerMove";
	        this._menuItemComputerMove.ShortcutKeyDisplayString = "C";
	        this._menuItemComputerMove.Size = new System.Drawing.Size(237, 32);
	        this._menuItemComputerMove.Text = "Play Now";
	        this._menuItemComputerMove.Click += new System.EventHandler(this.OnMenuItemComputerMoveClick);
	        // 
	        // _menuItemAutoPlay
	        // 
	        this._menuItemAutoPlay.Name = "_menuItemAutoPlay";
	        this._menuItemAutoPlay.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
	        this._menuItemAutoPlay.Size = new System.Drawing.Size(237, 32);
	        this._menuItemAutoPlay.Text = "Auto Play";
	        this._menuItemAutoPlay.Click += new System.EventHandler(this.OnMenuItemAutoPlayClick);
	        // 
	        // _menuItemDepthAnalysis
	        // 
	        this._menuItemDepthAnalysis.Name = "_menuItemDepthAnalysis";
	        this._menuItemDepthAnalysis.Size = new System.Drawing.Size(237, 32);
	        this._menuItemDepthAnalysis.Text = "Depth Analysis";
	        this._menuItemDepthAnalysis.Click += new System.EventHandler(this.OnMenuItemDepthAnalysisClick);
	        // 
	        // startTimeAnalysisToolStripMenuItem
	        // 
	        this.startTimeAnalysisToolStripMenuItem.Name = "startTimeAnalysisToolStripMenuItem";
	        this.startTimeAnalysisToolStripMenuItem.Size = new System.Drawing.Size(237, 32);
	        this.startTimeAnalysisToolStripMenuItem.Text = "Time Analysis";
	        this.startTimeAnalysisToolStripMenuItem.Click += new System.EventHandler(this.OnMenuItemTimeAnalysisClick);
	        // 
	        // _menuItemCheatMode
	        // 
	        this._menuItemCheatMode.CheckOnClick = true;
	        this._menuItemCheatMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this._menuItemAnimationTime, this._menuItemClickDelay, this._menuItemAutoMove, this._menuItemCheckAuto });
	        this._menuItemCheatMode.Name = "_menuItemCheatMode";
	        this._menuItemCheatMode.Size = new System.Drawing.Size(237, 32);
	        this._menuItemCheatMode.Text = "Cheat Mode";
	        this._menuItemCheatMode.CheckedChanged += new System.EventHandler(this.OnMenuItemCheatModeCheckedChanged);
	        // 
	        // _menuItemAnimationTime
	        // 
	        this._menuItemAnimationTime.Name = "_menuItemAnimationTime";
	        this._menuItemAnimationTime.Size = new System.Drawing.Size(222, 32);
	        this._menuItemAnimationTime.Text = "Animation Time";
	        this._menuItemAnimationTime.Click += new System.EventHandler(this.OnMenuItemAnimationTimeClick);
	        // 
	        // _menuItemClickDelay
	        // 
	        this._menuItemClickDelay.Name = "_menuItemClickDelay";
	        this._menuItemClickDelay.Size = new System.Drawing.Size(222, 32);
	        this._menuItemClickDelay.Text = "Click Delay";
	        this._menuItemClickDelay.Click += new System.EventHandler(this.OnMenuItemClickDelayClick);
	        // 
	        // _menuItemAutoMove
	        // 
	        this._menuItemAutoMove.Name = "_menuItemAutoMove";
	        this._menuItemAutoMove.ShortcutKeyDisplayString = "A";
	        this._menuItemAutoMove.Size = new System.Drawing.Size(222, 32);
	        this._menuItemAutoMove.Text = "Auto Move";
	        this._menuItemAutoMove.Click += new System.EventHandler(this.OnMenuItemAutoMoveClick);
	        // 
	        // _menuItemCheckAuto
	        // 
	        this._menuItemCheckAuto.CheckOnClick = true;
	        this._menuItemCheckAuto.Name = "_menuItemCheckAuto";
	        this._menuItemCheckAuto.Size = new System.Drawing.Size(222, 32);
	        this._menuItemCheckAuto.Text = "Check Auto";
	        // 
	        // _menuItemLevel
	        // 
	        this._menuItemLevel.Name = "_menuItemLevel";
	        this._menuItemLevel.Size = new System.Drawing.Size(68, 32);
	        this._menuItemLevel.Text = "Level";
	        this._menuItemLevel.Click += new System.EventHandler(this.OnMenuItemLevelClick);
	        // 
	        // _menuItemAppearance
	        // 
	        this._menuItemAppearance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.alterBoardToolStripMenuItem, this._menuItemAlterPieces });
	        this._menuItemAppearance.Name = "_menuItemAppearance";
	        this._menuItemAppearance.Size = new System.Drawing.Size(128, 32);
	        this._menuItemAppearance.Text = "Appearance";
	        // 
	        // alterBoardToolStripMenuItem
	        // 
	        this.alterBoardToolStripMenuItem.Name = "alterBoardToolStripMenuItem";
	        this.alterBoardToolStripMenuItem.Size = new System.Drawing.Size(151, 32);
	        this.alterBoardToolStripMenuItem.Text = "General";
	        this.alterBoardToolStripMenuItem.Click += new System.EventHandler(this.OnMenuItemBoardClick);
	        // 
	        // _menuItemAlterPieces
	        // 
	        this._menuItemAlterPieces.Name = "_menuItemAlterPieces";
	        this._menuItemAlterPieces.Size = new System.Drawing.Size(151, 32);
	        this._menuItemAlterPieces.Text = "Pieces";
	        this._menuItemAlterPieces.Click += new System.EventHandler(this.OnMenuItemPiecesClick);
	        // 
	        // _menuItemOptions
	        // 
	        this._menuItemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this._menuItemFlipBoard, this._menuItemLocalMode, this._menuItemHideOutput, this._menuItemHideArrows, this._menuItemFilterArrows, this._menuIllegalSound, this._menuItemDisplayLegalMoves, this._menuItemDisplayCoordinates });
	        this._menuItemOptions.Name = "_menuItemOptions";
	        this._menuItemOptions.Size = new System.Drawing.Size(94, 32);
	        this._menuItemOptions.Text = "Options";
	        // 
	        // _menuItemFlipBoard
	        // 
	        this._menuItemFlipBoard.CheckOnClick = true;
	        this._menuItemFlipBoard.Name = "_menuItemFlipBoard";
	        this._menuItemFlipBoard.ShortcutKeyDisplayString = "F";
	        this._menuItemFlipBoard.Size = new System.Drawing.Size(262, 32);
	        this._menuItemFlipBoard.Text = "Flip Board";
	        this._menuItemFlipBoard.CheckedChanged += new System.EventHandler(this.OnMenuItemFlipBoardCheckedChanged);
	        // 
	        // _menuItemLocalMode
	        // 
	        this._menuItemLocalMode.CheckOnClick = true;
	        this._menuItemLocalMode.Name = "_menuItemLocalMode";
	        this._menuItemLocalMode.Size = new System.Drawing.Size(262, 32);
	        this._menuItemLocalMode.Text = "Local Mode";
	        this._menuItemLocalMode.CheckedChanged += new System.EventHandler(this.OnMenuItemLocalModeCheckedChanged);
	        // 
	        // _menuItemHideOutput
	        // 
	        this._menuItemHideOutput.CheckOnClick = true;
	        this._menuItemHideOutput.Name = "_menuItemHideOutput";
	        this._menuItemHideOutput.Size = new System.Drawing.Size(262, 32);
	        this._menuItemHideOutput.Text = "Hide Output";
	        this._menuItemHideOutput.CheckedChanged += new System.EventHandler(this.OnMenuItemHideOutputCheckedChanged);
	        // 
	        // _menuItemHideArrows
	        // 
	        this._menuItemHideArrows.CheckOnClick = true;
	        this._menuItemHideArrows.Name = "_menuItemHideArrows";
	        this._menuItemHideArrows.Size = new System.Drawing.Size(262, 32);
	        this._menuItemHideArrows.Text = "Hide Engine Arrows";
	        // 
	        // _menuItemFilterArrows
	        // 
	        this._menuItemFilterArrows.CheckOnClick = true;
	        this._menuItemFilterArrows.Name = "_menuItemFilterArrows";
	        this._menuItemFilterArrows.Size = new System.Drawing.Size(262, 32);
	        this._menuItemFilterArrows.Text = "Filter Engine Arrows";
	        // 
	        // _menuIllegalSound
	        // 
	        this._menuIllegalSound.CheckOnClick = true;
	        this._menuIllegalSound.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this._menuItemIllegalSound });
	        this._menuIllegalSound.Name = "_menuIllegalSound";
	        this._menuIllegalSound.ShortcutKeyDisplayString = "S";
	        this._menuIllegalSound.Size = new System.Drawing.Size(262, 32);
	        this._menuIllegalSound.Text = "Sound";
	        // 
	        // _menuItemIllegalSound
	        // 
	        this._menuItemIllegalSound.CheckOnClick = true;
	        this._menuItemIllegalSound.Name = "_menuItemIllegalSound";
	        this._menuItemIllegalSound.Size = new System.Drawing.Size(253, 32);
	        this._menuItemIllegalSound.Text = "Illegal Move Sound";
	        // 
	        // _menuItemDisplayLegalMoves
	        // 
	        this._menuItemDisplayLegalMoves.CheckOnClick = true;
	        this._menuItemDisplayLegalMoves.Name = "_menuItemDisplayLegalMoves";
	        this._menuItemDisplayLegalMoves.Size = new System.Drawing.Size(262, 32);
	        this._menuItemDisplayLegalMoves.Text = "Display Legal Moves";
	        this._menuItemDisplayLegalMoves.CheckedChanged += new System.EventHandler(this.OnMenuItemDisplayLegalMovesCheckedChanged);
	        // 
	        // _menuItemDisplayCoordinates
	        // 
	        this._menuItemDisplayCoordinates.CheckOnClick = true;
	        this._menuItemDisplayCoordinates.Name = "_menuItemDisplayCoordinates";
	        this._menuItemDisplayCoordinates.Size = new System.Drawing.Size(262, 32);
	        this._menuItemDisplayCoordinates.Text = "Display Coordinates";
	        this._menuItemDisplayCoordinates.CheckedChanged += new System.EventHandler(this.OnMenuItemDisplayCoordinatesCheckedChanged);
	        // 
	        // _menuItemNavigation
	        // 
	        this._menuItemNavigation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this._menuItemGoBack, this._menuItemGoForward, this._menuItemGoToStart, this._menuItemGoToLatest });
	        this._menuItemNavigation.Name = "_menuItemNavigation";
	        this._menuItemNavigation.Size = new System.Drawing.Size(121, 32);
	        this._menuItemNavigation.Text = "Navigation";
	        // 
	        // _menuItemGoBack
	        // 
	        this._menuItemGoBack.Name = "_menuItemGoBack";
	        this._menuItemGoBack.ShortcutKeyDisplayString = "Left";
	        this._menuItemGoBack.Size = new System.Drawing.Size(242, 32);
	        this._menuItemGoBack.Text = "Go back";
	        this._menuItemGoBack.Click += new System.EventHandler(this.OnMenuItemBackClick);
	        // 
	        // _menuItemGoForward
	        // 
	        this._menuItemGoForward.Name = "_menuItemGoForward";
	        this._menuItemGoForward.ShortcutKeyDisplayString = "Right";
	        this._menuItemGoForward.Size = new System.Drawing.Size(242, 32);
	        this._menuItemGoForward.Text = "Go forward";
	        this._menuItemGoForward.Click += new System.EventHandler(this.OnMenuItemForwardClick);
	        // 
	        // _menuItemGoToStart
	        // 
	        this._menuItemGoToStart.Name = "_menuItemGoToStart";
	        this._menuItemGoToStart.ShortcutKeyDisplayString = "Down";
	        this._menuItemGoToStart.Size = new System.Drawing.Size(242, 32);
	        this._menuItemGoToStart.Text = "Go to start";
	        this._menuItemGoToStart.Click += new System.EventHandler(this.OnMenuItemStartClick);
	        // 
	        // _menuItemGoToLatest
	        // 
	        this._menuItemGoToLatest.Name = "_menuItemGoToLatest";
	        this._menuItemGoToLatest.ShortcutKeyDisplayString = "Up";
	        this._menuItemGoToLatest.Size = new System.Drawing.Size(242, 32);
	        this._menuItemGoToLatest.Text = "Go to latest";
	        this._menuItemGoToLatest.Click += new System.EventHandler(this.OnMenuItemLatestClick);
	        // 
	        // _menuItemBlackTime
	        // 
	        this._menuItemBlackTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
	        this._menuItemBlackTime.BackColor = System.Drawing.SystemColors.AppWorkspace;
	        this._menuItemBlackTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
	        this._menuItemBlackTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	        this._menuItemBlackTime.Name = "_menuItemBlackTime";
	        this._menuItemBlackTime.ReadOnly = true;
	        this._menuItemBlackTime.Size = new System.Drawing.Size(199, 32);
	        this._menuItemBlackTime.Text = "00:00.00";
	        this._menuItemBlackTime.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
	        // 
	        // _menuItemWhiteTime
	        // 
	        this._menuItemWhiteTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
	        this._menuItemWhiteTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
	        this._menuItemWhiteTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	        this._menuItemWhiteTime.Name = "_menuItemWhiteTime";
	        this._menuItemWhiteTime.ReadOnly = true;
	        this._menuItemWhiteTime.Size = new System.Drawing.Size(199, 32);
	        this._menuItemWhiteTime.Text = "00:00.00";
	        this._menuItemWhiteTime.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
	        // 
	        // _menuStripMain
	        // 
	        this._menuStripMain.BackColor = System.Drawing.SystemColors.Control;
	        this._menuStripMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	        this._menuStripMain.GripMargin = new System.Windows.Forms.Padding(2, 4, 0, 2);
	        this._menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
	        this._menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this._menuItemGame, this._menuItemEngine, this._menuItemLevel, this._menuItemAppearance, this._menuItemOptions, this._menuItemNavigation, this._menuItemBlackTime, this._menuItemWhiteTime });
	        this._menuStripMain.Location = new System.Drawing.Point(0, 0);
	        this._menuStripMain.Name = "_menuStripMain";
	        this._menuStripMain.Padding = new System.Windows.Forms.Padding(5, 5, 5, 2);
	        this._menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
	        this._menuStripMain.Size = new System.Drawing.Size(1562, 39);
	        this._menuStripMain.TabIndex = 1;
	        // 
	        // _panelRight
	        // 
	        this._panelRight.AutoScroll = true;
	        this._panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
	        this._panelRight.Controls.Add(this.tabTables);
	        this._panelRight.Controls.Add(this._tableLayoutPanelEvalInfos);
	        this._panelRight.Controls.Add(this._labelEvaluation);
	        this._panelRight.Controls.Add(this._labelShowEvaluation);
	        this._panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
	        this._panelRight.Location = new System.Drawing.Point(0, 0);
	        this._panelRight.Margin = new System.Windows.Forms.Padding(4);
	        this._panelRight.Name = "_panelRight";
	        this._panelRight.Size = new System.Drawing.Size(579, 1277);
	        this._panelRight.TabIndex = 4;
	        // 
	        // tabTables
	        // 
	        this.tabTables.Controls.Add(this.tabTableView);
	        this.tabTables.Controls.Add(this.tabTreeView);
	        this.tabTables.Controls.Add(this.tabSnapshotSettings);
	        this.tabTables.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	        this.tabTables.Location = new System.Drawing.Point(25, 225);
	        this.tabTables.Name = "tabTables";
	        this.tabTables.SelectedIndex = 0;
	        this.tabTables.Size = new System.Drawing.Size(400, 523);
	        this.tabTables.TabIndex = 9;
	        // 
	        // tabTableView
	        // 
	        this.tabTableView.Controls.Add(this._tableLayoutPanelModules);
	        this.tabTableView.Location = new System.Drawing.Point(4, 32);
	        this.tabTableView.Name = "tabTableView";
	        this.tabTableView.Padding = new System.Windows.Forms.Padding(3);
	        this.tabTableView.Size = new System.Drawing.Size(392, 487);
	        this.tabTableView.TabIndex = 0;
	        this.tabTableView.Text = "Table View";
	        this.tabTableView.UseVisualStyleBackColor = true;
	        // 
	        // _tableLayoutPanelModules
	        // 
	        this._tableLayoutPanelModules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
	        this._tableLayoutPanelModules.ColumnCount = 1;
	        this._tableLayoutPanelModules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
	        this._tableLayoutPanelModules.Controls.Add(this._dataGridViewMoves, 0, 0);
	        this._tableLayoutPanelModules.Controls.Add(this._panelEvaluationChart, 0, 2);
	        this._tableLayoutPanelModules.Location = new System.Drawing.Point(0, 3);
	        this._tableLayoutPanelModules.Margin = new System.Windows.Forms.Padding(0);
	        this._tableLayoutPanelModules.Name = "_tableLayoutPanelModules";
	        this._tableLayoutPanelModules.RowCount = 3;
	        this._tableLayoutPanelModules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.41675F));
	        this._tableLayoutPanelModules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.933535F));
	        this._tableLayoutPanelModules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.64972F));
	        this._tableLayoutPanelModules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
	        this._tableLayoutPanelModules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
	        this._tableLayoutPanelModules.Size = new System.Drawing.Size(389, 479);
	        this._tableLayoutPanelModules.TabIndex = 7;
	        this._tableLayoutPanelModules.Resize += new System.EventHandler(this.OnTableLayoutPanelModulesResize);
	        // 
	        // _dataGridViewMoves
	        // 
	        this._dataGridViewMoves.AllowDrop = true;
	        this._dataGridViewMoves.AllowUserToAddRows = false;
	        this._dataGridViewMoves.AllowUserToDeleteRows = false;
	        this._dataGridViewMoves.AllowUserToResizeColumns = false;
	        this._dataGridViewMoves.AllowUserToResizeRows = false;
	        this._dataGridViewMoves.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
	        this._dataGridViewMoves.BackgroundColor = System.Drawing.Color.White;
	        this._dataGridViewMoves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	        this._dataGridViewMoves.ColumnHeadersVisible = false;
	        this._dataGridViewMoves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this._whiteMove, this._blackMove });
	        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
	        dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
	        dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
	        dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
	        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
	        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
	        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
	        this._dataGridViewMoves.DefaultCellStyle = dataGridViewCellStyle1;
	        this._dataGridViewMoves.Dock = System.Windows.Forms.DockStyle.Fill;
	        this._dataGridViewMoves.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
	        this._dataGridViewMoves.GridColor = System.Drawing.SystemColors.Control;
	        this._dataGridViewMoves.Location = new System.Drawing.Point(4, 4);
	        this._dataGridViewMoves.Margin = new System.Windows.Forms.Padding(4);
	        this._dataGridViewMoves.MultiSelect = false;
	        this._dataGridViewMoves.Name = "_dataGridViewMoves";
	        this._dataGridViewMoves.RowHeadersVisible = false;
	        this._dataGridViewMoves.RowHeadersWidth = 51;
	        this._dataGridViewMoves.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
	        this._dataGridViewMoves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
	        this._dataGridViewMoves.ShowCellErrors = false;
	        this._dataGridViewMoves.ShowEditingIcon = false;
	        this._dataGridViewMoves.ShowRowErrors = false;
	        this._dataGridViewMoves.Size = new System.Drawing.Size(381, 219);
	        this._dataGridViewMoves.TabIndex = 6;
	        this._dataGridViewMoves.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnDataGridViewMovesCellMouseClick);
	        this._dataGridViewMoves.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnDataGridViewMovesKeyDown);
	        this._dataGridViewMoves.Resize += new System.EventHandler(this.OnDataGridViewMovesResize);
	        // 
	        // _whiteMove
	        // 
	        this._whiteMove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
	        this._whiteMove.FillWeight = 50F;
	        this._whiteMove.HeaderText = "White Move";
	        this._whiteMove.MinimumWidth = 6;
	        this._whiteMove.Name = "_whiteMove";
	        // 
	        // _blackMove
	        // 
	        this._blackMove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
	        this._blackMove.FillWeight = 50F;
	        this._blackMove.HeaderText = "Black Move";
	        this._blackMove.MinimumWidth = 6;
	        this._blackMove.Name = "_blackMove";
	        // 
	        // _panelEvaluationChart
	        // 
	        this._panelEvaluationChart.BackColor = System.Drawing.Color.White;
	        this._panelEvaluationChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
	        this._panelEvaluationChart.Dock = System.Windows.Forms.DockStyle.Fill;
	        this._panelEvaluationChart.Location = new System.Drawing.Point(4, 254);
	        this._panelEvaluationChart.Margin = new System.Windows.Forms.Padding(4);
	        this._panelEvaluationChart.Name = "_panelEvaluationChart";
	        this._panelEvaluationChart.Size = new System.Drawing.Size(381, 221);
	        this._panelEvaluationChart.TabIndex = 5;
	        this._panelEvaluationChart.Tag = "";
	        this._panelEvaluationChart.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPanelEvaluationChartPaint);
	        this._panelEvaluationChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnPanelEvaluationChartMouseClick);
	        // 
	        // tabTreeView
	        // 
	        this.tabTreeView.Controls.Add(this.tabPaths);
	        this.tabTreeView.Location = new System.Drawing.Point(4, 32);
	        this.tabTreeView.Name = "tabTreeView";
	        this.tabTreeView.Padding = new System.Windows.Forms.Padding(3);
	        this.tabTreeView.Size = new System.Drawing.Size(392, 487);
	        this.tabTreeView.TabIndex = 1;
	        this.tabTreeView.Text = "Analyze Paths";
	        this.tabTreeView.UseVisualStyleBackColor = true;
	        // 
	        // tabPaths
	        // 
	        this.tabPaths.Location = new System.Drawing.Point(0, 3);
	        this.tabPaths.Name = "tabPaths";
	        this.tabPaths.Size = new System.Drawing.Size(389, 479);
	        this.tabPaths.TabIndex = 0;
	        // 
	        // tabSnapshotSettings
	        // 
	        this.tabSnapshotSettings.Controls.Add(this.btnCancelRecogn);
	        this.tabSnapshotSettings.Controls.Add(this.prgbarRecognition);
	        this.tabSnapshotSettings.Controls.Add(this.grpbxAutoRefresh);
	        this.tabSnapshotSettings.Controls.Add(this.label1);
	        this.tabSnapshotSettings.Controls.Add(this.numbxTolleranceRecogn);
	        this.tabSnapshotSettings.Controls.Add(this.chkbxEnPassant);
	        this.tabSnapshotSettings.Controls.Add(this.grbxCastle);
	        this.tabSnapshotSettings.Controls.Add(this.grbxWhoseTurn);
	        this.tabSnapshotSettings.Location = new System.Drawing.Point(4, 32);
	        this.tabSnapshotSettings.Name = "tabSnapshotSettings";
	        this.tabSnapshotSettings.Padding = new System.Windows.Forms.Padding(3);
	        this.tabSnapshotSettings.Size = new System.Drawing.Size(392, 487);
	        this.tabSnapshotSettings.TabIndex = 2;
	        this.tabSnapshotSettings.Text = "Snapshot Settings";
	        this.tabSnapshotSettings.UseVisualStyleBackColor = true;
	        // 
	        // btnCancelRecogn
	        // 
	        this.btnCancelRecogn.Anchor = System.Windows.Forms.AnchorStyles.None;
	        this.btnCancelRecogn.BackColor = System.Drawing.Color.Red;
	        this.btnCancelRecogn.Enabled = false;
	        this.btnCancelRecogn.Font = new System.Drawing.Font("Wingdings", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
	        this.btnCancelRecogn.ForeColor = System.Drawing.Color.Red;
	        this.btnCancelRecogn.Location = new System.Drawing.Point(320, 468);
	        this.btnCancelRecogn.Margin = new System.Windows.Forms.Padding(0);
	        this.btnCancelRecogn.Name = "btnCancelRecogn";
	        this.btnCancelRecogn.Size = new System.Drawing.Size(15, 15);
	        this.btnCancelRecogn.TabIndex = 8;
	        this.btnCancelRecogn.UseVisualStyleBackColor = false;
	        this.btnCancelRecogn.Click += new System.EventHandler(this.btnCancelRecogn_Click);
	        // 
	        // prgbarRecognition
	        // 
	        this.prgbarRecognition.Location = new System.Drawing.Point(3, 471);
	        this.prgbarRecognition.Maximum = 64;
	        this.prgbarRecognition.Name = "prgbarRecognition";
	        this.prgbarRecognition.Size = new System.Drawing.Size(314, 10);
	        this.prgbarRecognition.TabIndex = 7;
	        // 
	        // grpbxAutoRefresh
	        // 
	        this.grpbxAutoRefresh.Controls.Add(this.lbLastRecognTime);
	        this.grpbxAutoRefresh.Controls.Add(this.lebel44);
	        this.grpbxAutoRefresh.Controls.Add(this.label3);
	        this.grpbxAutoRefresh.Controls.Add(this.txtbxRefreshTime);
	        this.grpbxAutoRefresh.Controls.Add(this.label2);
	        this.grpbxAutoRefresh.Controls.Add(this.chkbxIsAutoRefresh);
	        this.grpbxAutoRefresh.Location = new System.Drawing.Point(7, 349);
	        this.grpbxAutoRefresh.Name = "grpbxAutoRefresh";
	        this.grpbxAutoRefresh.Size = new System.Drawing.Size(328, 119);
	        this.grpbxAutoRefresh.TabIndex = 6;
	        this.grpbxAutoRefresh.TabStop = false;
	        this.grpbxAutoRefresh.Text = "Auto Refresh";
	        // 
	        // lbLastRecognTime
	        // 
	        this.lbLastRecognTime.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	        this.lbLastRecognTime.Location = new System.Drawing.Point(160, 96);
	        this.lbLastRecognTime.Name = "lbLastRecognTime";
	        this.lbLastRecognTime.Size = new System.Drawing.Size(100, 23);
	        this.lbLastRecognTime.TabIndex = 5;
	        // 
	        // lebel44
	        // 
	        this.lebel44.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	        this.lebel44.Location = new System.Drawing.Point(3, 96);
	        this.lebel44.Name = "lebel44";
	        this.lebel44.Size = new System.Drawing.Size(194, 23);
	        this.lebel44.TabIndex = 4;
	        this.lebel44.Text = "Last recognizing time, s";
	        // 
	        // label3
	        // 
	        this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	        this.label3.Location = new System.Drawing.Point(3, 59);
	        this.label3.Name = "label3";
	        this.label3.Size = new System.Drawing.Size(319, 42);
	        this.label3.TabIndex = 3;
	        this.label3.Text = "Time cannot be bigger than recognizing time. It will be corrected if it is less.";
	        // 
	        // txtbxRefreshTime
	        // 
	        this.txtbxRefreshTime.Location = new System.Drawing.Point(211, 25);
	        this.txtbxRefreshTime.Name = "txtbxRefreshTime";
	        this.txtbxRefreshTime.Size = new System.Drawing.Size(111, 30);
	        this.txtbxRefreshTime.TabIndex = 2;
	        // 
	        // label2
	        // 
	        this.label2.Location = new System.Drawing.Point(131, 29);
	        this.label2.Name = "label2";
	        this.label2.Size = new System.Drawing.Size(77, 30);
	        this.label2.TabIndex = 1;
	        this.label2.Text = "Time, s";
	        // 
	        // chkbxIsAutoRefresh
	        // 
	        this.chkbxIsAutoRefresh.Location = new System.Drawing.Point(6, 23);
	        this.chkbxIsAutoRefresh.Name = "chkbxIsAutoRefresh";
	        this.chkbxIsAutoRefresh.Size = new System.Drawing.Size(118, 42);
	        this.chkbxIsAutoRefresh.TabIndex = 0;
	        this.chkbxIsAutoRefresh.Text = "Enable";
	        this.chkbxIsAutoRefresh.UseVisualStyleBackColor = true;
	        this.chkbxIsAutoRefresh.CheckedChanged += new System.EventHandler(this.chkbxIsAutoRefresh_CheckedChanged);
	        // 
	        // label1
	        // 
	        this.label1.Location = new System.Drawing.Point(6, 285);
	        this.label1.Name = "label1";
	        this.label1.Size = new System.Drawing.Size(186, 29);
	        this.label1.TabIndex = 5;
	        this.label1.Text = "Recognition tolerance";
	        // 
	        // numbxTolleranceRecogn
	        // 
	        this.numbxTolleranceRecogn.DecimalPlaces = 3;
	        this.numbxTolleranceRecogn.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
	        this.numbxTolleranceRecogn.Location = new System.Drawing.Point(6, 317);
	        this.numbxTolleranceRecogn.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
	        this.numbxTolleranceRecogn.Name = "numbxTolleranceRecogn";
	        this.numbxTolleranceRecogn.Size = new System.Drawing.Size(198, 30);
	        this.numbxTolleranceRecogn.TabIndex = 5;
	        this.numbxTolleranceRecogn.Value = new decimal(new int[] { 98, 0, 0, 131072 });
	        // 
	        // chkbxEnPassant
	        // 
	        this.chkbxEnPassant.Location = new System.Drawing.Point(225, 283);
	        this.chkbxEnPassant.Name = "chkbxEnPassant";
	        this.chkbxEnPassant.Size = new System.Drawing.Size(112, 28);
	        this.chkbxEnPassant.TabIndex = 4;
	        this.chkbxEnPassant.Text = "EnPassant";
	        this.chkbxEnPassant.UseVisualStyleBackColor = true;
	        // 
	        // grbxCastle
	        // 
	        this.grbxCastle.Controls.Add(this.chkbxCanBlackCastleQueenSide);
	        this.grbxCastle.Controls.Add(this.chkbxCanBlackCastleKingSide);
	        this.grbxCastle.Controls.Add(this.chkbxCanWhiteCastleQueenSide);
	        this.grbxCastle.Controls.Add(this.chkbxCanWhiteCastleKingSide);
	        this.grbxCastle.Location = new System.Drawing.Point(3, 110);
	        this.grbxCastle.Name = "grbxCastle";
	        this.grbxCastle.Size = new System.Drawing.Size(334, 172);
	        this.grbxCastle.TabIndex = 3;
	        this.grbxCastle.TabStop = false;
	        this.grbxCastle.Text = "Castle";
	        // 
	        // chkbxCanBlackCastleQueenSide
	        // 
	        this.chkbxCanBlackCastleQueenSide.Checked = true;
	        this.chkbxCanBlackCastleQueenSide.CheckState = System.Windows.Forms.CheckState.Checked;
	        this.chkbxCanBlackCastleQueenSide.Location = new System.Drawing.Point(6, 123);
	        this.chkbxCanBlackCastleQueenSide.Name = "chkbxCanBlackCastleQueenSide";
	        this.chkbxCanBlackCastleQueenSide.Size = new System.Drawing.Size(322, 44);
	        this.chkbxCanBlackCastleQueenSide.TabIndex = 3;
	        this.chkbxCanBlackCastleQueenSide.Text = "Can Black Castle Queen Side?";
	        this.chkbxCanBlackCastleQueenSide.UseVisualStyleBackColor = true;
	        // 
	        // chkbxCanBlackCastleKingSide
	        // 
	        this.chkbxCanBlackCastleKingSide.Checked = true;
	        this.chkbxCanBlackCastleKingSide.CheckState = System.Windows.Forms.CheckState.Checked;
	        this.chkbxCanBlackCastleKingSide.Location = new System.Drawing.Point(6, 92);
	        this.chkbxCanBlackCastleKingSide.Name = "chkbxCanBlackCastleKingSide";
	        this.chkbxCanBlackCastleKingSide.Size = new System.Drawing.Size(311, 44);
	        this.chkbxCanBlackCastleKingSide.TabIndex = 2;
	        this.chkbxCanBlackCastleKingSide.Text = "Can Black Castle King Side?";
	        this.chkbxCanBlackCastleKingSide.UseVisualStyleBackColor = true;
	        // 
	        // chkbxCanWhiteCastleQueenSide
	        // 
	        this.chkbxCanWhiteCastleQueenSide.Checked = true;
	        this.chkbxCanWhiteCastleQueenSide.CheckState = System.Windows.Forms.CheckState.Checked;
	        this.chkbxCanWhiteCastleQueenSide.Location = new System.Drawing.Point(6, 61);
	        this.chkbxCanWhiteCastleQueenSide.Name = "chkbxCanWhiteCastleQueenSide";
	        this.chkbxCanWhiteCastleQueenSide.Size = new System.Drawing.Size(322, 44);
	        this.chkbxCanWhiteCastleQueenSide.TabIndex = 1;
	        this.chkbxCanWhiteCastleQueenSide.Text = "Can White Castle Queen Side?";
	        this.chkbxCanWhiteCastleQueenSide.UseVisualStyleBackColor = true;
	        // 
	        // chkbxCanWhiteCastleKingSide
	        // 
	        this.chkbxCanWhiteCastleKingSide.Checked = true;
	        this.chkbxCanWhiteCastleKingSide.CheckState = System.Windows.Forms.CheckState.Checked;
	        this.chkbxCanWhiteCastleKingSide.Location = new System.Drawing.Point(6, 30);
	        this.chkbxCanWhiteCastleKingSide.Name = "chkbxCanWhiteCastleKingSide";
	        this.chkbxCanWhiteCastleKingSide.Size = new System.Drawing.Size(322, 44);
	        this.chkbxCanWhiteCastleKingSide.TabIndex = 0;
	        this.chkbxCanWhiteCastleKingSide.Text = "Can White Castle King Side?";
	        this.chkbxCanWhiteCastleKingSide.UseVisualStyleBackColor = true;
	        // 
	        // grbxWhoseTurn
	        // 
	        this.grbxWhoseTurn.Controls.Add(this.rbutBlackTurn);
	        this.grbxWhoseTurn.Controls.Add(this.rbutWhiteTurn);
	        this.grbxWhoseTurn.Location = new System.Drawing.Point(6, 6);
	        this.grbxWhoseTurn.Name = "grbxWhoseTurn";
	        this.grbxWhoseTurn.Size = new System.Drawing.Size(153, 98);
	        this.grbxWhoseTurn.TabIndex = 1;
	        this.grbxWhoseTurn.TabStop = false;
	        this.grbxWhoseTurn.Text = "Whose Turn";
	        // 
	        // rbutBlackTurn
	        // 
	        this.rbutBlackTurn.Location = new System.Drawing.Point(6, 58);
	        this.rbutBlackTurn.Name = "rbutBlackTurn";
	        this.rbutBlackTurn.Size = new System.Drawing.Size(141, 35);
	        this.rbutBlackTurn.TabIndex = 2;
	        this.rbutBlackTurn.Text = "Black";
	        this.rbutBlackTurn.UseVisualStyleBackColor = true;
	        // 
	        // rbutWhiteTurn
	        // 
	        this.rbutWhiteTurn.Checked = true;
	        this.rbutWhiteTurn.Location = new System.Drawing.Point(6, 20);
	        this.rbutWhiteTurn.Name = "rbutWhiteTurn";
	        this.rbutWhiteTurn.Size = new System.Drawing.Size(141, 42);
	        this.rbutWhiteTurn.TabIndex = 1;
	        this.rbutWhiteTurn.TabStop = true;
	        this.rbutWhiteTurn.Text = "White";
	        this.rbutWhiteTurn.UseVisualStyleBackColor = true;
	        // 
	        // _tableLayoutPanelEvalInfos
	        // 
	        this._tableLayoutPanelEvalInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
	        this._tableLayoutPanelEvalInfos.ColumnCount = 2;
	        this._tableLayoutPanelEvalInfos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
	        this._tableLayoutPanelEvalInfos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
	        this._tableLayoutPanelEvalInfos.Controls.Add(this._labelTime, 0, 4);
	        this._tableLayoutPanelEvalInfos.Controls.Add(this._labelNPS, 0, 4);
	        this._tableLayoutPanelEvalInfos.Controls.Add(this._labelDepth, 0, 1);
	        this._tableLayoutPanelEvalInfos.Controls.Add(this._labelShowNodes, 1, 0);
	        this._tableLayoutPanelEvalInfos.Controls.Add(this._labelShowDepth, 0, 0);
	        this._tableLayoutPanelEvalInfos.Controls.Add(this._labelShowTime, 0, 3);
	        this._tableLayoutPanelEvalInfos.Controls.Add(this._labelShowNPS, 1, 3);
	        this._tableLayoutPanelEvalInfos.Controls.Add(this._labelNodes, 1, 1);
	        this._tableLayoutPanelEvalInfos.Location = new System.Drawing.Point(25, 96);
	        this._tableLayoutPanelEvalInfos.Margin = new System.Windows.Forms.Padding(4);
	        this._tableLayoutPanelEvalInfos.Name = "_tableLayoutPanelEvalInfos";
	        this._tableLayoutPanelEvalInfos.RowCount = 6;
	        this._tableLayoutPanelEvalInfos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.10392F));
	        this._tableLayoutPanelEvalInfos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.10392F));
	        this._tableLayoutPanelEvalInfos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.793664F));
	        this._tableLayoutPanelEvalInfos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.10392F));
	        this._tableLayoutPanelEvalInfos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.10392F));
	        this._tableLayoutPanelEvalInfos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.790648F));
	        this._tableLayoutPanelEvalInfos.Size = new System.Drawing.Size(245, 122);
	        this._tableLayoutPanelEvalInfos.TabIndex = 8;
	        // 
	        // _labelTime
	        // 
	        this._labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
	        this._labelTime.BackColor = System.Drawing.SystemColors.Control;
	        this._labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	        this._labelTime.Location = new System.Drawing.Point(0, 88);
	        this._labelTime.Margin = new System.Windows.Forms.Padding(0);
	        this._labelTime.Name = "_labelTime";
	        this._labelTime.Size = new System.Drawing.Size(122, 28);
	        this._labelTime.TabIndex = 8;
	        this._labelTime.Text = "-";
	        this._labelTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        this._labelTime.TextChanged += new System.EventHandler(this.OnLabelTextValidate);
	        this._labelTime.Resize += new System.EventHandler(this.OnLabelTextValidate);
	        // 
	        // _labelNPS
	        // 
	        this._labelNPS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
	        this._labelNPS.BackColor = System.Drawing.SystemColors.Control;
	        this._labelNPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	        this._labelNPS.Location = new System.Drawing.Point(122, 88);
	        this._labelNPS.Margin = new System.Windows.Forms.Padding(0);
	        this._labelNPS.Name = "_labelNPS";
	        this._labelNPS.Size = new System.Drawing.Size(123, 28);
	        this._labelNPS.TabIndex = 7;
	        this._labelNPS.Text = "-";
	        this._labelNPS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        this._labelNPS.TextChanged += new System.EventHandler(this.OnLabelTextValidate);
	        this._labelNPS.Resize += new System.EventHandler(this.OnLabelTextValidate);
	        // 
	        // _labelDepth
	        // 
	        this._labelDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
	        this._labelDepth.BackColor = System.Drawing.SystemColors.Control;
	        this._labelDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	        this._labelDepth.ForeColor = System.Drawing.SystemColors.ControlText;
	        this._labelDepth.Location = new System.Drawing.Point(0, 28);
	        this._labelDepth.Margin = new System.Windows.Forms.Padding(0);
	        this._labelDepth.Name = "_labelDepth";
	        this._labelDepth.Size = new System.Drawing.Size(122, 28);
	        this._labelDepth.TabIndex = 6;
	        this._labelDepth.Text = "-";
	        this._labelDepth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        this._labelDepth.TextChanged += new System.EventHandler(this.OnLabelTextValidate);
	        this._labelDepth.Resize += new System.EventHandler(this.OnLabelTextValidate);
	        // 
	        // _labelShowNodes
	        // 
	        this._labelShowNodes.BackColor = System.Drawing.SystemColors.Control;
	        this._labelShowNodes.Dock = System.Windows.Forms.DockStyle.Fill;
	        this._labelShowNodes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	        this._labelShowNodes.Location = new System.Drawing.Point(122, 0);
	        this._labelShowNodes.Margin = new System.Windows.Forms.Padding(0);
	        this._labelShowNodes.Name = "_labelShowNodes";
	        this._labelShowNodes.Size = new System.Drawing.Size(123, 28);
	        this._labelShowNodes.TabIndex = 4;
	        this._labelShowNodes.Text = "Nodes";
	        this._labelShowNodes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
	        this._labelShowNodes.Resize += new System.EventHandler(this.OnLabelTextValidate);
	        // 
	        // _labelShowDepth
	        // 
	        this._labelShowDepth.BackColor = System.Drawing.SystemColors.Control;
	        this._labelShowDepth.Dock = System.Windows.Forms.DockStyle.Fill;
	        this._labelShowDepth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	        this._labelShowDepth.Location = new System.Drawing.Point(0, 0);
	        this._labelShowDepth.Margin = new System.Windows.Forms.Padding(0);
	        this._labelShowDepth.Name = "_labelShowDepth";
	        this._labelShowDepth.Size = new System.Drawing.Size(122, 28);
	        this._labelShowDepth.TabIndex = 3;
	        this._labelShowDepth.Text = "Depth";
	        this._labelShowDepth.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
	        this._labelShowDepth.Resize += new System.EventHandler(this.OnLabelTextValidate);
	        // 
	        // _labelShowTime
	        // 
	        this._labelShowTime.BackColor = System.Drawing.SystemColors.Control;
	        this._labelShowTime.Dock = System.Windows.Forms.DockStyle.Fill;
	        this._labelShowTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	        this._labelShowTime.Location = new System.Drawing.Point(0, 60);
	        this._labelShowTime.Margin = new System.Windows.Forms.Padding(0);
	        this._labelShowTime.Name = "_labelShowTime";
	        this._labelShowTime.Size = new System.Drawing.Size(122, 28);
	        this._labelShowTime.TabIndex = 9;
	        this._labelShowTime.Text = "Time";
	        this._labelShowTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
	        this._labelShowTime.Resize += new System.EventHandler(this.OnLabelTextValidate);
	        // 
	        // _labelShowNPS
	        // 
	        this._labelShowNPS.BackColor = System.Drawing.SystemColors.Control;
	        this._labelShowNPS.Dock = System.Windows.Forms.DockStyle.Fill;
	        this._labelShowNPS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	        this._labelShowNPS.Location = new System.Drawing.Point(122, 60);
	        this._labelShowNPS.Margin = new System.Windows.Forms.Padding(0);
	        this._labelShowNPS.Name = "_labelShowNPS";
	        this._labelShowNPS.Size = new System.Drawing.Size(123, 28);
	        this._labelShowNPS.TabIndex = 10;
	        this._labelShowNPS.Text = "NPS";
	        this._labelShowNPS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
	        this._labelShowNPS.Resize += new System.EventHandler(this.OnLabelTextValidate);
	        // 
	        // _labelNodes
	        // 
	        this._labelNodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
	        this._labelNodes.BackColor = System.Drawing.SystemColors.Control;
	        this._labelNodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	        this._labelNodes.ForeColor = System.Drawing.SystemColors.ControlText;
	        this._labelNodes.Location = new System.Drawing.Point(122, 28);
	        this._labelNodes.Margin = new System.Windows.Forms.Padding(0);
	        this._labelNodes.Name = "_labelNodes";
	        this._labelNodes.Size = new System.Drawing.Size(123, 28);
	        this._labelNodes.TabIndex = 5;
	        this._labelNodes.Text = "-";
	        this._labelNodes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        this._labelNodes.TextChanged += new System.EventHandler(this.OnLabelTextValidate);
	        this._labelNodes.Resize += new System.EventHandler(this.OnLabelTextValidate);
	        // 
	        // _labelEvaluation
	        // 
	        this._labelEvaluation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
	        this._labelEvaluation.BackColor = System.Drawing.SystemColors.Control;
	        this._labelEvaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	        this._labelEvaluation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
	        this._labelEvaluation.Location = new System.Drawing.Point(4, 37);
	        this._labelEvaluation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
	        this._labelEvaluation.Name = "_labelEvaluation";
	        this._labelEvaluation.Size = new System.Drawing.Size(271, 48);
	        this._labelEvaluation.TabIndex = 3;
	        this._labelEvaluation.Text = "+0.00";
	        this._labelEvaluation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	        this._labelEvaluation.TextChanged += new System.EventHandler(this.OnLabelEvaluationTextChanged);
	        this._labelEvaluation.Resize += new System.EventHandler(this.OnLabelTextValidate);
	        // 
	        // _labelShowEvaluation
	        // 
	        this._labelShowEvaluation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
	        this._labelShowEvaluation.BackColor = System.Drawing.SystemColors.Control;
	        this._labelShowEvaluation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	        this._labelShowEvaluation.Location = new System.Drawing.Point(-1, 11);
	        this._labelShowEvaluation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
	        this._labelShowEvaluation.Name = "_labelShowEvaluation";
	        this._labelShowEvaluation.Size = new System.Drawing.Size(281, 26);
	        this._labelShowEvaluation.TabIndex = 2;
	        this._labelShowEvaluation.Text = "Evaluation:";
	        this._labelShowEvaluation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	        // 
	        // _splitContainerBoard
	        // 
	        this._splitContainerBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
	        this._splitContainerBoard.Dock = System.Windows.Forms.DockStyle.Fill;
	        this._splitContainerBoard.ForeColor = System.Drawing.SystemColors.ControlText;
	        this._splitContainerBoard.Location = new System.Drawing.Point(0, 0);
	        this._splitContainerBoard.Margin = new System.Windows.Forms.Padding(4);
	        this._splitContainerBoard.Name = "_splitContainerBoard";
	        this._splitContainerBoard.Orientation = System.Windows.Forms.Orientation.Horizontal;
	        // 
	        // _splitContainerBoard.Panel2
	        // 
	        this._splitContainerBoard.Panel2.Controls.Add(this._dataGridViewEvaluation);
	        this._splitContainerBoard.Size = new System.Drawing.Size(980, 1277);
	        this._splitContainerBoard.SplitterDistance = 1152;
	        this._splitContainerBoard.TabIndex = 0;
	        this._splitContainerBoard.TabStop = false;
	        // 
	        // _dataGridViewEvaluation
	        // 
	        this._dataGridViewEvaluation.BackgroundColor = System.Drawing.SystemColors.Control;
	        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
	        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
	        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
	        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
	        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
	        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
	        this._dataGridViewEvaluation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
	        this._dataGridViewEvaluation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
	        dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
	        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	        dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
	        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
	        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
	        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
	        this._dataGridViewEvaluation.DefaultCellStyle = dataGridViewCellStyle3;
	        this._dataGridViewEvaluation.Dock = System.Windows.Forms.DockStyle.Fill;
	        this._dataGridViewEvaluation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
	        this._dataGridViewEvaluation.Location = new System.Drawing.Point(0, 0);
	        this._dataGridViewEvaluation.Margin = new System.Windows.Forms.Padding(4);
	        this._dataGridViewEvaluation.MultiSelect = false;
	        this._dataGridViewEvaluation.Name = "_dataGridViewEvaluation";
	        this._dataGridViewEvaluation.ReadOnly = true;
	        this._dataGridViewEvaluation.RowHeadersVisible = false;
	        this._dataGridViewEvaluation.RowHeadersWidth = 51;
	        this._dataGridViewEvaluation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
	        this._dataGridViewEvaluation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
	        this._dataGridViewEvaluation.ShowCellErrors = false;
	        this._dataGridViewEvaluation.ShowEditingIcon = false;
	        this._dataGridViewEvaluation.ShowRowErrors = false;
	        this._dataGridViewEvaluation.Size = new System.Drawing.Size(978, 119);
	        this._dataGridViewEvaluation.TabIndex = 1;
	        // 
	        // _splitContainerMain
	        // 
	        this._splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
	        this._splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
	        this._splitContainerMain.Location = new System.Drawing.Point(0, 42);
	        this._splitContainerMain.Margin = new System.Windows.Forms.Padding(4);
	        this._splitContainerMain.Name = "_splitContainerMain";
	        // 
	        // _splitContainerMain.Panel1
	        // 
	        this._splitContainerMain.Panel1.Controls.Add(this._splitContainerBoard);
	        // 
	        // _splitContainerMain.Panel2
	        // 
	        this._splitContainerMain.Panel2.Controls.Add(this._panelRight);
	        this._splitContainerMain.Panel2MinSize = 200;
	        this._splitContainerMain.Size = new System.Drawing.Size(1562, 1277);
	        this._splitContainerMain.SplitterDistance = 980;
	        this._splitContainerMain.SplitterWidth = 3;
	        this._splitContainerMain.TabIndex = 5;
	        // 
	        // FormMain
	        // 
	        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
	        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	        this.BackColor = System.Drawing.SystemColors.Control;
	        this.ClientSize = new System.Drawing.Size(1562, 1175);
	        this.Controls.Add(this._splitContainerMain);
	        this.Controls.Add(this._menuStripMain);
	        this.DoubleBuffered = true;
	        this.KeyPreview = true;
	        this.Location = new System.Drawing.Point(15, 15);
	        this.MainMenuStrip = this._menuStripMain;
	        this.Margin = new System.Windows.Forms.Padding(4);
	        this.MinimumSize = new System.Drawing.Size(627, 358);
	        this.Name = "FormMain";
	        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
	        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormMainClosing);
	        this.Load += new System.EventHandler(this.OnFormMainLoad);
	        this._menuStripMain.ResumeLayout(false);
	        this._menuStripMain.PerformLayout();
	        this._panelRight.ResumeLayout(false);
	        this.tabTables.ResumeLayout(false);
	        this.tabTableView.ResumeLayout(false);
	        this._tableLayoutPanelModules.ResumeLayout(false);
	        ((System.ComponentModel.ISupportInitialize)(this._dataGridViewMoves)).EndInit();
	        this.tabTreeView.ResumeLayout(false);
	        this.tabSnapshotSettings.ResumeLayout(false);
	        this.grpbxAutoRefresh.ResumeLayout(false);
	        this.grpbxAutoRefresh.PerformLayout();
	        ((System.ComponentModel.ISupportInitialize)(this.numbxTolleranceRecogn)).EndInit();
	        this.grbxCastle.ResumeLayout(false);
	        this.grbxWhoseTurn.ResumeLayout(false);
	        this._tableLayoutPanelEvalInfos.ResumeLayout(false);
	        this._splitContainerBoard.Panel2.ResumeLayout(false);
	        ((System.ComponentModel.ISupportInitialize)(this._splitContainerBoard)).EndInit();
	        this._splitContainerBoard.ResumeLayout(false);
	        ((System.ComponentModel.ISupportInitialize)(this._dataGridViewEvaluation)).EndInit();
	        this._splitContainerMain.Panel1.ResumeLayout(false);
	        this._splitContainerMain.Panel2.ResumeLayout(false);
	        ((System.ComponentModel.ISupportInitialize)(this._splitContainerMain)).EndInit();
	        this._splitContainerMain.ResumeLayout(false);
	        this.ResumeLayout(false);
	        this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem getBoardFromPrevScreenToolStripMenuItem;


        private System.Windows.Forms.ToolStripMenuItem getBoardFromScreenToolStripMenuItem;

        internal System.Windows.Forms.Label lbLastRecognTime;

        internal System.Windows.Forms.ProgressBar prgbarRecognition;
        internal System.Windows.Forms.Button btnCancelRecogn;

        private System.Windows.Forms.Label lebel44;

        private System.Windows.Forms.CheckBox chkbxIsAutoRefresh;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtbxRefreshTime;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.GroupBox grpbxAutoRefresh;

        internal System.Windows.Forms.NumericUpDown numbxTolleranceRecogn;
        private System.Windows.Forms.Label label1;

        internal System.Windows.Forms.CheckBox chkbxEnPassant;

        internal System.Windows.Forms.CheckBox chkbxCanBlackCastleKingSide;
        internal System.Windows.Forms.CheckBox chkbxCanBlackCastleQueenSide;

        internal System.Windows.Forms.CheckBox chkbxCanWhiteCastleQueenSide;

        internal System.Windows.Forms.CheckBox chkbxCanWhiteCastleKingSide;

        private System.Windows.Forms.GroupBox grbxCastle;

        internal System.Windows.Forms.RadioButton rbutBlackTurn;

        private System.Windows.Forms.TabPage tabSnapshotSettings;
        internal System.Windows.Forms.RadioButton rbutWhiteTurn;
        private System.Windows.Forms.GroupBox grbxWhoseTurn;

        private System.Windows.Forms.ToolStripMenuItem _menuItemGame;
        private System.Windows.Forms.ToolStripMenuItem _menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem _menuItemLoadFen;
        private System.Windows.Forms.ToolStripMenuItem _menuItemCopyFen;
        private System.Windows.Forms.ToolStripMenuItem _menuItemLoadPgn;
        private System.Windows.Forms.ToolStripMenuItem _menuItemEngine;
        private System.Windows.Forms.ToolStripMenuItem _menuItemEngineSettings;
        private System.Windows.Forms.ToolStripMenuItem _menuItemMultiPv;
        private System.Windows.Forms.ToolStripMenuItem _menuItemComputerMove;
        private System.Windows.Forms.ToolStripMenuItem _menuItemAutoPlay;
        private System.Windows.Forms.ToolStripMenuItem _menuItemDepthAnalysis;
        private System.Windows.Forms.ToolStripMenuItem startTimeAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _menuItemCheatMode;
        private System.Windows.Forms.ToolStripMenuItem _menuItemAnimationTime;
        private System.Windows.Forms.ToolStripMenuItem _menuItemClickDelay;
        private System.Windows.Forms.ToolStripMenuItem _menuItemAutoMove;
        private System.Windows.Forms.ToolStripMenuItem _menuItemCheckAuto;
        private System.Windows.Forms.ToolStripMenuItem _menuItemLevel;
        private System.Windows.Forms.ToolStripMenuItem _menuItemAppearance;
        private System.Windows.Forms.ToolStripMenuItem alterBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _menuItemAlterPieces;
        private System.Windows.Forms.ToolStripMenuItem _menuItemOptions;
        internal System.Windows.Forms.ToolStripMenuItem _menuItemFlipBoard;
        private System.Windows.Forms.ToolStripMenuItem _menuItemLocalMode;
        private System.Windows.Forms.ToolStripMenuItem _menuItemHideOutput;
        private System.Windows.Forms.ToolStripMenuItem _menuItemHideArrows;
        private System.Windows.Forms.ToolStripMenuItem _menuItemFilterArrows;
        private System.Windows.Forms.ToolStripMenuItem _menuIllegalSound;
        private System.Windows.Forms.ToolStripMenuItem _menuItemIllegalSound;
        private System.Windows.Forms.ToolStripMenuItem _menuItemDisplayLegalMoves;
        private System.Windows.Forms.ToolStripMenuItem _menuItemDisplayCoordinates;
        private System.Windows.Forms.ToolStripMenuItem _menuItemNavigation;
        private System.Windows.Forms.ToolStripMenuItem _menuItemGoBack;
        private System.Windows.Forms.ToolStripMenuItem _menuItemGoForward;
        private System.Windows.Forms.ToolStripMenuItem _menuItemGoToStart;
        private System.Windows.Forms.ToolStripMenuItem _menuItemGoToLatest;
        private System.Windows.Forms.ToolStripTextBox _menuItemBlackTime;
        private System.Windows.Forms.ToolStripTextBox _menuItemWhiteTime;
        private System.Windows.Forms.MenuStrip _menuStripMain;
        private System.Windows.Forms.Panel _panelRight;
        private BerldChess.View.SmoothLabel _labelShowEvaluation;
        private BerldChess.View.SmoothLabel _labelEvaluation;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelEvalInfos;
        private BerldChess.View.SmoothLabel _labelNodes;
        private BerldChess.View.SmoothLabel _labelShowNPS;
        private BerldChess.View.SmoothLabel _labelShowTime;
        private BerldChess.View.SmoothLabel _labelShowDepth;
        private BerldChess.View.SmoothLabel _labelShowNodes;
        private BerldChess.View.SmoothLabel _labelDepth;
        private BerldChess.View.SmoothLabel _labelNPS;
        private BerldChess.View.SmoothLabel _labelTime;
        private System.Windows.Forms.SplitContainer _splitContainerBoard;
        private System.Windows.Forms.DataGridView _dataGridViewEvaluation;
        private System.Windows.Forms.SplitContainer _splitContainerMain;
        private System.Windows.Forms.TabPage tabTreeView;
        private System.Windows.Forms.TreeView tabPaths;
        private System.Windows.Forms.TabPage tabTableView;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelModules;
        private System.Windows.Forms.Panel _panelEvaluationChart;
        private System.Windows.Forms.DataGridView _dataGridViewMoves;
        private System.Windows.Forms.DataGridViewTextBoxColumn _blackMove;
        private System.Windows.Forms.DataGridViewTextBoxColumn _whiteMove;
        private System.Windows.Forms.TabControl tabTables;

        #endregion

        private System.Windows.Forms.Timer _timerValidation;
        private System.Windows.Forms.Timer _timerAutoCheck;
        private System.Windows.Forms.Timer _timerAutoRecognition;
    }
}

