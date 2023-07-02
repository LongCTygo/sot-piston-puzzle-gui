namespace SoTSolverGUI
{
    partial class SolverForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonA4 = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.buttonB4 = new System.Windows.Forms.Button();
            this.buttonD4 = new System.Windows.Forms.Button();
            this.buttonC4 = new System.Windows.Forms.Button();
            this.buttonD3 = new System.Windows.Forms.Button();
            this.buttonC3 = new System.Windows.Forms.Button();
            this.buttonB3 = new System.Windows.Forms.Button();
            this.buttonA3 = new System.Windows.Forms.Button();
            this.buttonD1 = new System.Windows.Forms.Button();
            this.buttonC1 = new System.Windows.Forms.Button();
            this.buttonB1 = new System.Windows.Forms.Button();
            this.buttonA1 = new System.Windows.Forms.Button();
            this.buttonD2 = new System.Windows.Forms.Button();
            this.buttonC2 = new System.Windows.Forms.Button();
            this.buttonB2 = new System.Windows.Forms.Button();
            this.buttonA2 = new System.Windows.Forms.Button();
            this.seedBox = new System.Windows.Forms.NumericUpDown();
            this.seedLabel = new System.Windows.Forms.Label();
            this.loadSeedButton = new System.Windows.Forms.Button();
            this.createSeedButton = new System.Windows.Forms.Button();
            this.copySeedButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.buttonDownA = new System.Windows.Forms.Button();
            this.buttonDownB = new System.Windows.Forms.Button();
            this.buttonDownC = new System.Windows.Forms.Button();
            this.buttonDownD = new System.Windows.Forms.Button();
            this.buttonUpA = new System.Windows.Forms.Button();
            this.buttonUpB = new System.Windows.Forms.Button();
            this.buttonUpC = new System.Windows.Forms.Button();
            this.buttonUpD = new System.Windows.Forms.Button();
            this.buttonLeft4 = new System.Windows.Forms.Button();
            this.buttonLeft3 = new System.Windows.Forms.Button();
            this.buttonLeft2 = new System.Windows.Forms.Button();
            this.buttonLeft1 = new System.Windows.Forms.Button();
            this.buttonRight4 = new System.Windows.Forms.Button();
            this.buttonRight3 = new System.Windows.Forms.Button();
            this.buttonRight2 = new System.Windows.Forms.Button();
            this.buttonRight1 = new System.Windows.Forms.Button();
            this.solveButton = new System.Windows.Forms.Button();
            this.isSolvedLabel = new System.Windows.Forms.Label();
            this.solutionGrid = new System.Windows.Forms.DataGridView();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.unlockCheck = new System.Windows.Forms.CheckBox();
            this.ignoreBadMovesBox = new System.Windows.Forms.CheckBox();
            this.maxSearchBox = new System.Windows.Forms.NumericUpDown();
            this.maxSearchLabel = new System.Windows.Forms.Label();
            this.maxDepthBox = new System.Windows.Forms.NumericUpDown();
            this.maxDepthLabel = new System.Windows.Forms.Label();
            this.practiceGroupBox = new System.Windows.Forms.GroupBox();
            this.maxMovesBox = new System.Windows.Forms.NumericUpDown();
            this.minMovesBox = new System.Windows.Forms.NumericUpDown();
            this.getSeedButton = new System.Windows.Forms.Button();
            this.obstructedCheckBox = new System.Windows.Forms.CheckBox();
            this.maxMovesLabel = new System.Windows.Forms.Label();
            this.minMovesLabel = new System.Windows.Forms.Label();
            this.coalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionGrid)).BeginInit();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSearchBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDepthBox)).BeginInit();
            this.practiceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxMovesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minMovesBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonA4
            // 
            this.buttonA4.Location = new System.Drawing.Point(62, 88);
            this.buttonA4.Name = "buttonA4";
            this.buttonA4.Size = new System.Drawing.Size(70, 70);
            this.buttonA4.TabIndex = 0;
            this.buttonA4.Text = "A4";
            this.buttonA4.UseVisualStyleBackColor = true;
            this.buttonA4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseClick);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(390, 31);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Sands Of Time Piston Puzzle Solver";
            // 
            // buttonB4
            // 
            this.buttonB4.Location = new System.Drawing.Point(138, 88);
            this.buttonB4.Name = "buttonB4";
            this.buttonB4.Size = new System.Drawing.Size(70, 70);
            this.buttonB4.TabIndex = 2;
            this.buttonB4.Text = "B4";
            this.buttonB4.UseVisualStyleBackColor = true;
            this.buttonB4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseClick);
            // 
            // buttonD4
            // 
            this.buttonD4.Location = new System.Drawing.Point(290, 88);
            this.buttonD4.Name = "buttonD4";
            this.buttonD4.Size = new System.Drawing.Size(70, 70);
            this.buttonD4.TabIndex = 4;
            this.buttonD4.Text = "D4";
            this.buttonD4.UseVisualStyleBackColor = true;
            this.buttonD4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseClick);
            // 
            // buttonC4
            // 
            this.buttonC4.Location = new System.Drawing.Point(214, 88);
            this.buttonC4.Name = "buttonC4";
            this.buttonC4.Size = new System.Drawing.Size(70, 70);
            this.buttonC4.TabIndex = 3;
            this.buttonC4.Text = "C4";
            this.buttonC4.UseVisualStyleBackColor = true;
            this.buttonC4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseClick);
            // 
            // buttonD3
            // 
            this.buttonD3.Location = new System.Drawing.Point(290, 164);
            this.buttonD3.Name = "buttonD3";
            this.buttonD3.Size = new System.Drawing.Size(70, 70);
            this.buttonD3.TabIndex = 8;
            this.buttonD3.Text = "D3";
            this.buttonD3.UseVisualStyleBackColor = true;
            this.buttonD3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseClick);
            // 
            // buttonC3
            // 
            this.buttonC3.Location = new System.Drawing.Point(214, 164);
            this.buttonC3.Name = "buttonC3";
            this.buttonC3.Size = new System.Drawing.Size(70, 70);
            this.buttonC3.TabIndex = 7;
            this.buttonC3.Text = "C3";
            this.buttonC3.UseVisualStyleBackColor = true;
            this.buttonC3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseClick);
            // 
            // buttonB3
            // 
            this.buttonB3.Location = new System.Drawing.Point(138, 164);
            this.buttonB3.Name = "buttonB3";
            this.buttonB3.Size = new System.Drawing.Size(70, 70);
            this.buttonB3.TabIndex = 6;
            this.buttonB3.Text = "B3";
            this.buttonB3.UseVisualStyleBackColor = true;
            this.buttonB3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseClick);
            // 
            // buttonA3
            // 
            this.buttonA3.Location = new System.Drawing.Point(62, 164);
            this.buttonA3.Name = "buttonA3";
            this.buttonA3.Size = new System.Drawing.Size(70, 70);
            this.buttonA3.TabIndex = 5;
            this.buttonA3.Text = "A3";
            this.buttonA3.UseVisualStyleBackColor = true;
            this.buttonA3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseClick);
            // 
            // buttonD1
            // 
            this.buttonD1.Location = new System.Drawing.Point(290, 316);
            this.buttonD1.Name = "buttonD1";
            this.buttonD1.Size = new System.Drawing.Size(70, 70);
            this.buttonD1.TabIndex = 16;
            this.buttonD1.Text = "D1";
            this.buttonD1.UseVisualStyleBackColor = true;
            this.buttonD1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseClick);
            // 
            // buttonC1
            // 
            this.buttonC1.Location = new System.Drawing.Point(214, 316);
            this.buttonC1.Name = "buttonC1";
            this.buttonC1.Size = new System.Drawing.Size(70, 70);
            this.buttonC1.TabIndex = 15;
            this.buttonC1.Text = "C1";
            this.buttonC1.UseVisualStyleBackColor = true;
            this.buttonC1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseClick);
            // 
            // buttonB1
            // 
            this.buttonB1.Location = new System.Drawing.Point(138, 316);
            this.buttonB1.Name = "buttonB1";
            this.buttonB1.Size = new System.Drawing.Size(70, 70);
            this.buttonB1.TabIndex = 14;
            this.buttonB1.Text = "B1";
            this.buttonB1.UseVisualStyleBackColor = true;
            this.buttonB1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseClick);
            // 
            // buttonA1
            // 
            this.buttonA1.Location = new System.Drawing.Point(62, 316);
            this.buttonA1.Name = "buttonA1";
            this.buttonA1.Size = new System.Drawing.Size(70, 70);
            this.buttonA1.TabIndex = 13;
            this.buttonA1.Text = "A1";
            this.buttonA1.UseVisualStyleBackColor = true;
            this.buttonA1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseClick);
            // 
            // buttonD2
            // 
            this.buttonD2.Location = new System.Drawing.Point(290, 240);
            this.buttonD2.Name = "buttonD2";
            this.buttonD2.Size = new System.Drawing.Size(70, 70);
            this.buttonD2.TabIndex = 12;
            this.buttonD2.Text = "D2";
            this.buttonD2.UseVisualStyleBackColor = true;
            this.buttonD2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseClick);
            // 
            // buttonC2
            // 
            this.buttonC2.Location = new System.Drawing.Point(214, 240);
            this.buttonC2.Name = "buttonC2";
            this.buttonC2.Size = new System.Drawing.Size(70, 70);
            this.buttonC2.TabIndex = 11;
            this.buttonC2.Text = "C2";
            this.buttonC2.UseVisualStyleBackColor = true;
            this.buttonC2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseClick);
            // 
            // buttonB2
            // 
            this.buttonB2.Location = new System.Drawing.Point(138, 240);
            this.buttonB2.Name = "buttonB2";
            this.buttonB2.Size = new System.Drawing.Size(70, 70);
            this.buttonB2.TabIndex = 10;
            this.buttonB2.Text = "B2";
            this.buttonB2.UseVisualStyleBackColor = true;
            this.buttonB2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseClick);
            // 
            // buttonA2
            // 
            this.buttonA2.Location = new System.Drawing.Point(62, 240);
            this.buttonA2.Name = "buttonA2";
            this.buttonA2.Size = new System.Drawing.Size(70, 70);
            this.buttonA2.TabIndex = 9;
            this.buttonA2.Text = "A2";
            this.buttonA2.UseVisualStyleBackColor = true;
            this.buttonA2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseClick);
            // 
            // seedBox
            // 
            this.seedBox.Location = new System.Drawing.Point(491, 55);
            this.seedBox.Name = "seedBox";
            this.seedBox.Size = new System.Drawing.Size(150, 27);
            this.seedBox.TabIndex = 17;
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(430, 57);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(42, 20);
            this.seedLabel.TabIndex = 18;
            this.seedLabel.Text = "Seed";
            // 
            // loadSeedButton
            // 
            this.loadSeedButton.Location = new System.Drawing.Point(430, 96);
            this.loadSeedButton.Name = "loadSeedButton";
            this.loadSeedButton.Size = new System.Drawing.Size(100, 29);
            this.loadSeedButton.TabIndex = 19;
            this.loadSeedButton.Text = "Load Seed";
            this.loadSeedButton.UseVisualStyleBackColor = true;
            this.loadSeedButton.Click += new System.EventHandler(this.loadSeedButton_Click);
            // 
            // createSeedButton
            // 
            this.createSeedButton.Location = new System.Drawing.Point(541, 96);
            this.createSeedButton.Name = "createSeedButton";
            this.createSeedButton.Size = new System.Drawing.Size(100, 29);
            this.createSeedButton.TabIndex = 20;
            this.createSeedButton.Text = "Create Seed";
            this.createSeedButton.UseVisualStyleBackColor = true;
            this.createSeedButton.Click += new System.EventHandler(this.createSeedButton_Click);
            // 
            // copySeedButton
            // 
            this.copySeedButton.Location = new System.Drawing.Point(430, 131);
            this.copySeedButton.Name = "copySeedButton";
            this.copySeedButton.Size = new System.Drawing.Size(100, 29);
            this.copySeedButton.TabIndex = 21;
            this.copySeedButton.Text = "Copy Seed";
            this.copySeedButton.UseVisualStyleBackColor = true;
            this.copySeedButton.Click += new System.EventHandler(this.copySeedButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(541, 131);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 29);
            this.clearButton.TabIndex = 22;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // buttonDownA
            // 
            this.buttonDownA.Location = new System.Drawing.Point(62, 55);
            this.buttonDownA.Name = "buttonDownA";
            this.buttonDownA.Size = new System.Drawing.Size(70, 30);
            this.buttonDownA.TabIndex = 23;
            this.buttonDownA.Text = "↓";
            this.buttonDownA.UseVisualStyleBackColor = true;
            this.buttonDownA.Click += new System.EventHandler(this.buttonDownA_Click);
            // 
            // buttonDownB
            // 
            this.buttonDownB.Location = new System.Drawing.Point(138, 55);
            this.buttonDownB.Name = "buttonDownB";
            this.buttonDownB.Size = new System.Drawing.Size(70, 30);
            this.buttonDownB.TabIndex = 24;
            this.buttonDownB.Text = "↓";
            this.buttonDownB.UseVisualStyleBackColor = true;
            this.buttonDownB.Click += new System.EventHandler(this.buttonDownB_Click);
            // 
            // buttonDownC
            // 
            this.buttonDownC.Location = new System.Drawing.Point(214, 55);
            this.buttonDownC.Name = "buttonDownC";
            this.buttonDownC.Size = new System.Drawing.Size(70, 30);
            this.buttonDownC.TabIndex = 25;
            this.buttonDownC.Text = "↓";
            this.buttonDownC.UseVisualStyleBackColor = true;
            this.buttonDownC.Click += new System.EventHandler(this.buttonDownC_Click);
            // 
            // buttonDownD
            // 
            this.buttonDownD.Location = new System.Drawing.Point(290, 55);
            this.buttonDownD.Name = "buttonDownD";
            this.buttonDownD.Size = new System.Drawing.Size(70, 30);
            this.buttonDownD.TabIndex = 26;
            this.buttonDownD.Text = "↓";
            this.buttonDownD.UseVisualStyleBackColor = true;
            this.buttonDownD.Click += new System.EventHandler(this.buttonDownD_Click);
            // 
            // buttonUpA
            // 
            this.buttonUpA.Location = new System.Drawing.Point(62, 392);
            this.buttonUpA.Name = "buttonUpA";
            this.buttonUpA.Size = new System.Drawing.Size(70, 30);
            this.buttonUpA.TabIndex = 27;
            this.buttonUpA.Text = "↑";
            this.buttonUpA.UseVisualStyleBackColor = true;
            this.buttonUpA.Click += new System.EventHandler(this.buttonUpA_Click);
            // 
            // buttonUpB
            // 
            this.buttonUpB.Location = new System.Drawing.Point(138, 392);
            this.buttonUpB.Name = "buttonUpB";
            this.buttonUpB.Size = new System.Drawing.Size(70, 30);
            this.buttonUpB.TabIndex = 28;
            this.buttonUpB.Text = "↑";
            this.buttonUpB.UseVisualStyleBackColor = true;
            this.buttonUpB.Click += new System.EventHandler(this.buttonUpB_Click);
            // 
            // buttonUpC
            // 
            this.buttonUpC.Location = new System.Drawing.Point(214, 392);
            this.buttonUpC.Name = "buttonUpC";
            this.buttonUpC.Size = new System.Drawing.Size(70, 30);
            this.buttonUpC.TabIndex = 29;
            this.buttonUpC.Text = "↑";
            this.buttonUpC.UseVisualStyleBackColor = true;
            this.buttonUpC.Click += new System.EventHandler(this.buttonUpC_Click);
            // 
            // buttonUpD
            // 
            this.buttonUpD.Location = new System.Drawing.Point(290, 392);
            this.buttonUpD.Name = "buttonUpD";
            this.buttonUpD.Size = new System.Drawing.Size(70, 30);
            this.buttonUpD.TabIndex = 30;
            this.buttonUpD.Text = "↑";
            this.buttonUpD.UseVisualStyleBackColor = true;
            this.buttonUpD.Click += new System.EventHandler(this.buttonUpD_Click);
            // 
            // buttonLeft4
            // 
            this.buttonLeft4.Location = new System.Drawing.Point(366, 88);
            this.buttonLeft4.Name = "buttonLeft4";
            this.buttonLeft4.Size = new System.Drawing.Size(30, 70);
            this.buttonLeft4.TabIndex = 31;
            this.buttonLeft4.Text = "←";
            this.buttonLeft4.UseVisualStyleBackColor = true;
            this.buttonLeft4.Click += new System.EventHandler(this.buttonLeft4_Click);
            // 
            // buttonLeft3
            // 
            this.buttonLeft3.Location = new System.Drawing.Point(366, 164);
            this.buttonLeft3.Name = "buttonLeft3";
            this.buttonLeft3.Size = new System.Drawing.Size(30, 70);
            this.buttonLeft3.TabIndex = 32;
            this.buttonLeft3.Text = "←";
            this.buttonLeft3.UseVisualStyleBackColor = true;
            this.buttonLeft3.Click += new System.EventHandler(this.buttonLeft3_Click);
            // 
            // buttonLeft2
            // 
            this.buttonLeft2.Location = new System.Drawing.Point(366, 240);
            this.buttonLeft2.Name = "buttonLeft2";
            this.buttonLeft2.Size = new System.Drawing.Size(30, 70);
            this.buttonLeft2.TabIndex = 33;
            this.buttonLeft2.Text = "←";
            this.buttonLeft2.UseVisualStyleBackColor = true;
            this.buttonLeft2.Click += new System.EventHandler(this.buttonLeft2_Click);
            // 
            // buttonLeft1
            // 
            this.buttonLeft1.Location = new System.Drawing.Point(366, 316);
            this.buttonLeft1.Name = "buttonLeft1";
            this.buttonLeft1.Size = new System.Drawing.Size(30, 70);
            this.buttonLeft1.TabIndex = 34;
            this.buttonLeft1.Text = "←";
            this.buttonLeft1.UseVisualStyleBackColor = true;
            this.buttonLeft1.Click += new System.EventHandler(this.buttonLeft1_Click);
            // 
            // buttonRight4
            // 
            this.buttonRight4.Location = new System.Drawing.Point(26, 88);
            this.buttonRight4.Name = "buttonRight4";
            this.buttonRight4.Size = new System.Drawing.Size(30, 70);
            this.buttonRight4.TabIndex = 35;
            this.buttonRight4.Text = "→";
            this.buttonRight4.UseVisualStyleBackColor = true;
            this.buttonRight4.Click += new System.EventHandler(this.buttonRight4_Click);
            // 
            // buttonRight3
            // 
            this.buttonRight3.Location = new System.Drawing.Point(26, 164);
            this.buttonRight3.Name = "buttonRight3";
            this.buttonRight3.Size = new System.Drawing.Size(30, 70);
            this.buttonRight3.TabIndex = 36;
            this.buttonRight3.Text = "→";
            this.buttonRight3.UseVisualStyleBackColor = true;
            this.buttonRight3.Click += new System.EventHandler(this.buttonRight3_Click);
            // 
            // buttonRight2
            // 
            this.buttonRight2.Location = new System.Drawing.Point(26, 240);
            this.buttonRight2.Name = "buttonRight2";
            this.buttonRight2.Size = new System.Drawing.Size(30, 70);
            this.buttonRight2.TabIndex = 37;
            this.buttonRight2.Text = "→";
            this.buttonRight2.UseVisualStyleBackColor = true;
            this.buttonRight2.Click += new System.EventHandler(this.buttonRight2_Click);
            // 
            // buttonRight1
            // 
            this.buttonRight1.Location = new System.Drawing.Point(26, 316);
            this.buttonRight1.Name = "buttonRight1";
            this.buttonRight1.Size = new System.Drawing.Size(30, 70);
            this.buttonRight1.TabIndex = 38;
            this.buttonRight1.Text = "→";
            this.buttonRight1.UseVisualStyleBackColor = true;
            this.buttonRight1.Click += new System.EventHandler(this.buttonRight1_Click);
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(430, 166);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(211, 29);
            this.solveButton.TabIndex = 39;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // isSolvedLabel
            // 
            this.isSolvedLabel.AutoSize = true;
            this.isSolvedLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isSolvedLabel.Location = new System.Drawing.Point(430, 198);
            this.isSolvedLabel.Name = "isSolvedLabel";
            this.isSolvedLabel.Size = new System.Drawing.Size(86, 20);
            this.isSolvedLabel.TabIndex = 40;
            this.isSolvedLabel.Text = "Not Solved";
            // 
            // solutionGrid
            // 
            this.solutionGrid.AllowUserToAddRows = false;
            this.solutionGrid.AllowUserToDeleteRows = false;
            this.solutionGrid.AllowUserToResizeColumns = false;
            this.solutionGrid.AllowUserToResizeRows = false;
            this.solutionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.solutionGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.solutionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.solutionGrid.Location = new System.Drawing.Point(430, 234);
            this.solutionGrid.Name = "solutionGrid";
            this.solutionGrid.RowHeadersWidth = 51;
            this.solutionGrid.RowTemplate.Height = 29;
            this.solutionGrid.Size = new System.Drawing.Size(211, 188);
            this.solutionGrid.TabIndex = 41;
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.unlockCheck);
            this.groupBoxSettings.Controls.Add(this.ignoreBadMovesBox);
            this.groupBoxSettings.Controls.Add(this.maxSearchBox);
            this.groupBoxSettings.Controls.Add(this.maxSearchLabel);
            this.groupBoxSettings.Controls.Add(this.maxDepthBox);
            this.groupBoxSettings.Controls.Add(this.maxDepthLabel);
            this.groupBoxSettings.Location = new System.Drawing.Point(647, 12);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(303, 148);
            this.groupBoxSettings.TabIndex = 42;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Debug Settings";
            // 
            // unlockCheck
            // 
            this.unlockCheck.AutoSize = true;
            this.unlockCheck.Location = new System.Drawing.Point(6, 26);
            this.unlockCheck.Name = "unlockCheck";
            this.unlockCheck.Size = new System.Drawing.Size(236, 24);
            this.unlockCheck.TabIndex = 6;
            this.unlockCheck.Text = "I like messing around so let me";
            this.unlockCheck.UseVisualStyleBackColor = true;
            this.unlockCheck.CheckedChanged += new System.EventHandler(this.unlockCheck_CheckedChanged);
            // 
            // ignoreBadMovesBox
            // 
            this.ignoreBadMovesBox.AutoSize = true;
            this.ignoreBadMovesBox.Checked = true;
            this.ignoreBadMovesBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ignoreBadMovesBox.Enabled = false;
            this.ignoreBadMovesBox.Location = new System.Drawing.Point(6, 122);
            this.ignoreBadMovesBox.Name = "ignoreBadMovesBox";
            this.ignoreBadMovesBox.Size = new System.Drawing.Size(219, 24);
            this.ignoreBadMovesBox.TabIndex = 5;
            this.ignoreBadMovesBox.Text = "Ignore Potential \'Bad\' Moves";
            this.ignoreBadMovesBox.UseVisualStyleBackColor = true;
            // 
            // maxSearchBox
            // 
            this.maxSearchBox.Enabled = false;
            this.maxSearchBox.Location = new System.Drawing.Point(162, 86);
            this.maxSearchBox.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.maxSearchBox.Name = "maxSearchBox";
            this.maxSearchBox.Size = new System.Drawing.Size(122, 27);
            this.maxSearchBox.TabIndex = 3;
            this.maxSearchBox.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // maxSearchLabel
            // 
            this.maxSearchLabel.AutoSize = true;
            this.maxSearchLabel.Location = new System.Drawing.Point(6, 92);
            this.maxSearchLabel.Name = "maxSearchLabel";
            this.maxSearchLabel.Size = new System.Drawing.Size(85, 20);
            this.maxSearchLabel.TabIndex = 2;
            this.maxSearchLabel.Text = "Max Search";
            // 
            // maxDepthBox
            // 
            this.maxDepthBox.Enabled = false;
            this.maxDepthBox.Location = new System.Drawing.Point(162, 53);
            this.maxDepthBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.maxDepthBox.Name = "maxDepthBox";
            this.maxDepthBox.Size = new System.Drawing.Size(122, 27);
            this.maxDepthBox.TabIndex = 1;
            this.maxDepthBox.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // maxDepthLabel
            // 
            this.maxDepthLabel.AutoSize = true;
            this.maxDepthLabel.Location = new System.Drawing.Point(6, 59);
            this.maxDepthLabel.Name = "maxDepthLabel";
            this.maxDepthLabel.Size = new System.Drawing.Size(82, 20);
            this.maxDepthLabel.TabIndex = 0;
            this.maxDepthLabel.Text = "Max Depth";
            // 
            // practiceGroupBox
            // 
            this.practiceGroupBox.Controls.Add(this.maxMovesBox);
            this.practiceGroupBox.Controls.Add(this.minMovesBox);
            this.practiceGroupBox.Controls.Add(this.getSeedButton);
            this.practiceGroupBox.Controls.Add(this.obstructedCheckBox);
            this.practiceGroupBox.Controls.Add(this.maxMovesLabel);
            this.practiceGroupBox.Controls.Add(this.minMovesLabel);
            this.practiceGroupBox.Location = new System.Drawing.Point(653, 166);
            this.practiceGroupBox.Name = "practiceGroupBox";
            this.practiceGroupBox.Size = new System.Drawing.Size(297, 187);
            this.practiceGroupBox.TabIndex = 43;
            this.practiceGroupBox.TabStop = false;
            this.practiceGroupBox.Text = "Practice Puzzles";
            // 
            // maxMovesBox
            // 
            this.maxMovesBox.Location = new System.Drawing.Point(156, 74);
            this.maxMovesBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.maxMovesBox.Name = "maxMovesBox";
            this.maxMovesBox.Size = new System.Drawing.Size(122, 27);
            this.maxMovesBox.TabIndex = 13;
            this.maxMovesBox.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // minMovesBox
            // 
            this.minMovesBox.Location = new System.Drawing.Point(156, 41);
            this.minMovesBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.minMovesBox.Name = "minMovesBox";
            this.minMovesBox.Size = new System.Drawing.Size(122, 27);
            this.minMovesBox.TabIndex = 12;
            this.minMovesBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // getSeedButton
            // 
            this.getSeedButton.Location = new System.Drawing.Point(15, 140);
            this.getSeedButton.Name = "getSeedButton";
            this.getSeedButton.Size = new System.Drawing.Size(263, 29);
            this.getSeedButton.TabIndex = 11;
            this.getSeedButton.Text = "Get Puzzle";
            this.getSeedButton.UseVisualStyleBackColor = true;
            this.getSeedButton.Click += new System.EventHandler(this.getSeedButton_Click);
            // 
            // obstructedCheckBox
            // 
            this.obstructedCheckBox.AutoSize = true;
            this.obstructedCheckBox.Location = new System.Drawing.Point(15, 110);
            this.obstructedCheckBox.Name = "obstructedCheckBox";
            this.obstructedCheckBox.Size = new System.Drawing.Size(204, 24);
            this.obstructedCheckBox.TabIndex = 10;
            this.obstructedCheckBox.Text = "Allow \'Obstructed\' Puzzles";
            this.obstructedCheckBox.UseVisualStyleBackColor = true;
            // 
            // maxMovesLabel
            // 
            this.maxMovesLabel.AutoSize = true;
            this.maxMovesLabel.Location = new System.Drawing.Point(6, 76);
            this.maxMovesLabel.Name = "maxMovesLabel";
            this.maxMovesLabel.Size = new System.Drawing.Size(122, 20);
            this.maxMovesLabel.TabIndex = 9;
            this.maxMovesLabel.Text = "Maximum Moves";
            // 
            // minMovesLabel
            // 
            this.minMovesLabel.AutoSize = true;
            this.minMovesLabel.Location = new System.Drawing.Point(6, 43);
            this.minMovesLabel.Name = "minMovesLabel";
            this.minMovesLabel.Size = new System.Drawing.Size(119, 20);
            this.minMovesLabel.TabIndex = 7;
            this.minMovesLabel.Text = "Minimum Moves";
            // 
            // coalLabel
            // 
            this.coalLabel.AutoSize = true;
            this.coalLabel.Location = new System.Drawing.Point(653, 356);
            this.coalLabel.Name = "coalLabel";
            this.coalLabel.Size = new System.Drawing.Size(297, 80);
            this.coalLabel.TabIndex = 7;
            this.coalLabel.Text = "Left Click to toggle cells between empty or \r\noccupied. Right Click to mark cell " +
    "as the \r\nplayer\'s position. Middle Click to mark cell \r\nas the goal\'s position.";
            // 
            // SolverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 445);
            this.Controls.Add(this.coalLabel);
            this.Controls.Add(this.practiceGroupBox);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.solutionGrid);
            this.Controls.Add(this.isSolvedLabel);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.buttonRight1);
            this.Controls.Add(this.buttonRight2);
            this.Controls.Add(this.buttonRight3);
            this.Controls.Add(this.buttonRight4);
            this.Controls.Add(this.buttonLeft1);
            this.Controls.Add(this.buttonLeft2);
            this.Controls.Add(this.buttonLeft3);
            this.Controls.Add(this.buttonLeft4);
            this.Controls.Add(this.buttonUpD);
            this.Controls.Add(this.buttonUpC);
            this.Controls.Add(this.buttonUpB);
            this.Controls.Add(this.buttonUpA);
            this.Controls.Add(this.buttonDownD);
            this.Controls.Add(this.buttonDownC);
            this.Controls.Add(this.buttonDownB);
            this.Controls.Add(this.buttonDownA);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.copySeedButton);
            this.Controls.Add(this.createSeedButton);
            this.Controls.Add(this.loadSeedButton);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.seedBox);
            this.Controls.Add(this.buttonD1);
            this.Controls.Add(this.buttonC1);
            this.Controls.Add(this.buttonB1);
            this.Controls.Add(this.buttonA1);
            this.Controls.Add(this.buttonD2);
            this.Controls.Add(this.buttonC2);
            this.Controls.Add(this.buttonB2);
            this.Controls.Add(this.buttonA2);
            this.Controls.Add(this.buttonD3);
            this.Controls.Add(this.buttonC3);
            this.Controls.Add(this.buttonB3);
            this.Controls.Add(this.buttonA3);
            this.Controls.Add(this.buttonD4);
            this.Controls.Add(this.buttonC4);
            this.Controls.Add(this.buttonB4);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.buttonA4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SolverForm";
            this.Text = "Puzzle Solver";
            ((System.ComponentModel.ISupportInitialize)(this.seedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionGrid)).EndInit();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSearchBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDepthBox)).EndInit();
            this.practiceGroupBox.ResumeLayout(false);
            this.practiceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxMovesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minMovesBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonA4;
        private Label titleLabel;
        private Button buttonB4;
        private Button buttonD4;
        private Button buttonC4;
        private Button buttonD3;
        private Button buttonC3;
        private Button buttonB3;
        private Button buttonA3;
        private Button buttonD1;
        private Button buttonC1;
        private Button buttonB1;
        private Button buttonA1;
        private Button buttonD2;
        private Button buttonC2;
        private Button buttonB2;
        private Button buttonA2;
        private NumericUpDown seedBox;
        private Label seedLabel;
        private Button loadSeedButton;
        private Button createSeedButton;
        private Button copySeedButton;
        private Button clearButton;
        private Button buttonDownA;
        private Button buttonDownB;
        private Button buttonDownC;
        private Button buttonDownD;
        private Button buttonUpA;
        private Button buttonUpB;
        private Button buttonUpC;
        private Button buttonUpD;
        private Button buttonLeft4;
        private Button buttonLeft3;
        private Button buttonLeft2;
        private Button buttonLeft1;
        private Button buttonRight4;
        private Button buttonRight3;
        private Button buttonRight2;
        private Button buttonRight1;
        private Button solveButton;
        private Label isSolvedLabel;
        private DataGridView solutionGrid;
        private GroupBox groupBoxSettings;
        private NumericUpDown maxSearchBox;
        private Label maxSearchLabel;
        private NumericUpDown maxDepthBox;
        private Label maxDepthLabel;
        private CheckBox ignoreBadMovesBox;
        private CheckBox unlockCheck;
        private GroupBox practiceGroupBox;
        private Button getSeedButton;
        private CheckBox obstructedCheckBox;
        private Label maxMovesLabel;
        private Label minMovesLabel;
        private Label coalLabel;
        private NumericUpDown minMovesBox;
        private NumericUpDown maxMovesBox;
    }
}