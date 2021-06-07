namespace Pro
{
    partial class ImportBatches
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportBatches));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.importBatch = new System.Windows.Forms.Panel();
            this.importBatchespnl = new System.Windows.Forms.Panel();
            this.dataGridImport = new System.Windows.Forms.DataGridView();
            this.stdListFormLbl = new System.Windows.Forms.Label();
            this.textBoxSheet = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.chooseFile = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.stdNameBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadExcel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.textBoxPath = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.importBatchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.writeBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.importBatch.SuspendLayout();
            this.importBatchespnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBatchesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // importBatch
            // 
            this.importBatch.BackColor = System.Drawing.Color.Salmon;
            this.importBatch.Controls.Add(this.importBatchespnl);
            this.importBatch.Location = new System.Drawing.Point(0, 0);
            this.importBatch.Name = "importBatch";
            this.importBatch.Size = new System.Drawing.Size(805, 753);
            this.importBatch.TabIndex = 5;
            // 
            // importBatchespnl
            // 
            this.importBatchespnl.BackColor = System.Drawing.Color.SlateGray;
            this.importBatchespnl.Controls.Add(this.writeBtn);
            this.importBatchespnl.Controls.Add(this.dataGridImport);
            this.importBatchespnl.Controls.Add(this.stdListFormLbl);
            this.importBatchespnl.Controls.Add(this.textBoxSheet);
            this.importBatchespnl.Controls.Add(this.chooseFile);
            this.importBatchespnl.Controls.Add(this.stdNameBox);
            this.importBatchespnl.Controls.Add(this.pictureBox1);
            this.importBatchespnl.Controls.Add(this.loadExcel);
            this.importBatchespnl.Controls.Add(this.textBoxPath);
            this.importBatchespnl.Location = new System.Drawing.Point(61, 43);
            this.importBatchespnl.Name = "importBatchespnl";
            this.importBatchespnl.Size = new System.Drawing.Size(683, 687);
            this.importBatchespnl.TabIndex = 12;
            this.importBatchespnl.Paint += new System.Windows.Forms.PaintEventHandler(this.importBatchespnl_Paint);
            // 
            // dataGridImport
            // 
            this.dataGridImport.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridImport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridImport.BackgroundColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridImport.GridColor = System.Drawing.Color.SlateGray;
            this.dataGridImport.Location = new System.Drawing.Point(34, 310);
            this.dataGridImport.Name = "dataGridImport";
            this.dataGridImport.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.SlateGray;
            this.dataGridImport.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridImport.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridImport.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Salmon;
            this.dataGridImport.Size = new System.Drawing.Size(634, 321);
            this.dataGridImport.TabIndex = 28;
            // 
            // stdListFormLbl
            // 
            this.stdListFormLbl.AutoSize = true;
            this.stdListFormLbl.BackColor = System.Drawing.Color.Salmon;
            this.stdListFormLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stdListFormLbl.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdListFormLbl.ForeColor = System.Drawing.Color.Transparent;
            this.stdListFormLbl.Location = new System.Drawing.Point(406, 83);
            this.stdListFormLbl.Name = "stdListFormLbl";
            this.stdListFormLbl.Size = new System.Drawing.Size(130, 30);
            this.stdListFormLbl.TabIndex = 27;
            this.stdListFormLbl.Text = "Student List";
            // 
            // textBoxSheet
            // 
            this.textBoxSheet.AcceptsReturn = false;
            this.textBoxSheet.AcceptsTab = false;
            this.textBoxSheet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxSheet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxSheet.BackColor = System.Drawing.Color.SlateGray;
            this.textBoxSheet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxSheet.BackgroundImage")));
            this.textBoxSheet.BorderColorActive = System.Drawing.Color.Salmon;
            this.textBoxSheet.BorderColorDisabled = System.Drawing.Color.SlateGray;
            this.textBoxSheet.BorderColorHover = System.Drawing.Color.Salmon;
            this.textBoxSheet.BorderColorIdle = System.Drawing.Color.LightSteelBlue;
            this.textBoxSheet.BorderRadius = 1;
            this.textBoxSheet.BorderThickness = 2;
            this.textBoxSheet.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxSheet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSheet.DefaultFont = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSheet.DefaultText = "";
            this.textBoxSheet.FillColor = System.Drawing.Color.SlateGray;
            this.textBoxSheet.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxSheet.HideSelection = true;
            this.textBoxSheet.IconLeft = null;
            this.textBoxSheet.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.textBoxSheet.IconPadding = 10;
            this.textBoxSheet.IconRight = null;
            this.textBoxSheet.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.textBoxSheet.Location = new System.Drawing.Point(228, 223);
            this.textBoxSheet.MaxLength = 32767;
            this.textBoxSheet.MinimumSize = new System.Drawing.Size(100, 35);
            this.textBoxSheet.Modified = false;
            this.textBoxSheet.Name = "textBoxSheet";
            this.textBoxSheet.PasswordChar = '\0';
            this.textBoxSheet.ReadOnly = false;
            this.textBoxSheet.SelectedText = "";
            this.textBoxSheet.SelectionLength = 0;
            this.textBoxSheet.SelectionStart = 0;
            this.textBoxSheet.ShortcutsEnabled = true;
            this.textBoxSheet.Size = new System.Drawing.Size(364, 35);
            this.textBoxSheet.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.textBoxSheet.TabIndex = 24;
            this.textBoxSheet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxSheet.TextMarginLeft = 5;
            this.textBoxSheet.TextPlaceholder = "Sheet";
            this.textBoxSheet.UseSystemPasswordChar = false;
            // 
            // chooseFile
            // 
            this.chooseFile.BackColor = System.Drawing.Color.Transparent;
            this.chooseFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chooseFile.BackgroundImage")));
            this.chooseFile.ButtonText = "Choose File";
            this.chooseFile.ButtonTextMarginLeft = 0;
            this.chooseFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseFile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.chooseFile.DisabledFillColor = System.Drawing.Color.Gray;
            this.chooseFile.DisabledForecolor = System.Drawing.Color.White;
            this.chooseFile.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseFile.ForeColor = System.Drawing.Color.White;
            this.chooseFile.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.chooseFile.IconPadding = 10;
            this.chooseFile.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.chooseFile.IdleBorderColor = System.Drawing.Color.Salmon;
            this.chooseFile.IdleBorderRadius = 1;
            this.chooseFile.IdleBorderThickness = 0;
            this.chooseFile.IdleFillColor = System.Drawing.Color.SlateGray;
            this.chooseFile.IdleIconLeftImage = null;
            this.chooseFile.IdleIconRightImage = null;
            this.chooseFile.Location = new System.Drawing.Point(79, 182);
            this.chooseFile.Name = "chooseFile";
            stateProperties2.BorderColor = System.Drawing.Color.SlateGray;
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.Salmon;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.chooseFile.onHoverState = stateProperties2;
            this.chooseFile.Size = new System.Drawing.Size(130, 35);
            this.chooseFile.TabIndex = 23;
            this.chooseFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // stdNameBox
            // 
            this.stdNameBox.BackColor = System.Drawing.Color.SlateGray;
            this.stdNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stdNameBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdNameBox.FormattingEnabled = true;
            this.stdNameBox.Items.AddRange(new object[] {
            "Select Student Name"});
            this.stdNameBox.Location = new System.Drawing.Point(542, 83);
            this.stdNameBox.Name = "stdNameBox";
            this.stdNameBox.Size = new System.Drawing.Size(138, 30);
            this.stdNameBox.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pro.Properties.Resources.ImportBatches;
            this.pictureBox1.Location = new System.Drawing.Point(275, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 124);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // loadExcel
            // 
            this.loadExcel.BackColor = System.Drawing.Color.Transparent;
            this.loadExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadExcel.BackgroundImage")));
            this.loadExcel.ButtonText = "Load Excel";
            this.loadExcel.ButtonTextMarginLeft = 0;
            this.loadExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadExcel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.loadExcel.DisabledFillColor = System.Drawing.Color.Gray;
            this.loadExcel.DisabledForecolor = System.Drawing.Color.White;
            this.loadExcel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExcel.ForeColor = System.Drawing.Color.White;
            this.loadExcel.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.loadExcel.IconPadding = 10;
            this.loadExcel.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.loadExcel.IdleBorderColor = System.Drawing.Color.Salmon;
            this.loadExcel.IdleBorderRadius = 1;
            this.loadExcel.IdleBorderThickness = 0;
            this.loadExcel.IdleFillColor = System.Drawing.Color.SlateGray;
            this.loadExcel.IdleIconLeftImage = null;
            this.loadExcel.IdleIconRightImage = null;
            this.loadExcel.Location = new System.Drawing.Point(79, 223);
            this.loadExcel.Name = "loadExcel";
            stateProperties3.BorderColor = System.Drawing.Color.SlateGray;
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.Salmon;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.loadExcel.onHoverState = stateProperties3;
            this.loadExcel.Size = new System.Drawing.Size(130, 35);
            this.loadExcel.TabIndex = 14;
            this.loadExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadExcel.Click += new System.EventHandler(this.loadExcel_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.AcceptsReturn = false;
            this.textBoxPath.AcceptsTab = false;
            this.textBoxPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxPath.BackColor = System.Drawing.Color.SlateGray;
            this.textBoxPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxPath.BackgroundImage")));
            this.textBoxPath.BorderColorActive = System.Drawing.Color.Salmon;
            this.textBoxPath.BorderColorDisabled = System.Drawing.Color.SlateGray;
            this.textBoxPath.BorderColorHover = System.Drawing.Color.Salmon;
            this.textBoxPath.BorderColorIdle = System.Drawing.Color.LightSteelBlue;
            this.textBoxPath.BorderRadius = 1;
            this.textBoxPath.BorderThickness = 2;
            this.textBoxPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPath.DefaultFont = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPath.DefaultText = "";
            this.textBoxPath.FillColor = System.Drawing.Color.SlateGray;
            this.textBoxPath.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxPath.HideSelection = true;
            this.textBoxPath.IconLeft = null;
            this.textBoxPath.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.textBoxPath.IconPadding = 10;
            this.textBoxPath.IconRight = null;
            this.textBoxPath.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.textBoxPath.Location = new System.Drawing.Point(228, 182);
            this.textBoxPath.MaxLength = 32767;
            this.textBoxPath.MinimumSize = new System.Drawing.Size(100, 35);
            this.textBoxPath.Modified = false;
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.PasswordChar = '\0';
            this.textBoxPath.ReadOnly = false;
            this.textBoxPath.SelectedText = "";
            this.textBoxPath.SelectionLength = 0;
            this.textBoxPath.SelectionStart = 0;
            this.textBoxPath.ShortcutsEnabled = true;
            this.textBoxPath.Size = new System.Drawing.Size(364, 35);
            this.textBoxPath.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.textBoxPath.TabIndex = 11;
            this.textBoxPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPath.TextMarginLeft = 5;
            this.textBoxPath.TextPlaceholder = "Path";
            this.textBoxPath.UseSystemPasswordChar = false;
            // 
            // importBatchesBindingSource
            // 
            this.importBatchesBindingSource.DataSource = typeof(Pro.ImportBatches);
            // 
            // writeBtn
            // 
            this.writeBtn.BackColor = System.Drawing.Color.Transparent;
            this.writeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("writeBtn.BackgroundImage")));
            this.writeBtn.ButtonText = "Write";
            this.writeBtn.ButtonTextMarginLeft = 0;
            this.writeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.writeBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.writeBtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.writeBtn.DisabledForecolor = System.Drawing.Color.White;
            this.writeBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeBtn.ForeColor = System.Drawing.Color.White;
            this.writeBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.writeBtn.IconPadding = 10;
            this.writeBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.writeBtn.IdleBorderColor = System.Drawing.Color.Salmon;
            this.writeBtn.IdleBorderRadius = 1;
            this.writeBtn.IdleBorderThickness = 0;
            this.writeBtn.IdleFillColor = System.Drawing.Color.SlateGray;
            this.writeBtn.IdleIconLeftImage = null;
            this.writeBtn.IdleIconRightImage = null;
            this.writeBtn.Location = new System.Drawing.Point(228, 637);
            this.writeBtn.Name = "writeBtn";
            stateProperties1.BorderColor = System.Drawing.Color.SlateGray;
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Salmon;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.writeBtn.onHoverState = stateProperties1;
            this.writeBtn.Size = new System.Drawing.Size(130, 35);
            this.writeBtn.TabIndex = 29;
            this.writeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.writeBtn.Click += new System.EventHandler(this.writeBtn_Click);
            // 
            // ImportBatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 838);
            this.Controls.Add(this.importBatch);
            this.Name = "ImportBatches";
            this.Text = "ImportBatches";
            this.importBatch.ResumeLayout(false);
            this.importBatchespnl.ResumeLayout(false);
            this.importBatchespnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBatchesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel importBatch;
        private System.Windows.Forms.Panel importBatchespnl;
        private System.Windows.Forms.Label stdListFormLbl;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox textBoxSheet;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton chooseFile;
        private System.Windows.Forms.ComboBox stdNameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton loadExcel;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox textBoxPath;
        private System.Windows.Forms.DataGridView dataGridImport;
        private System.Windows.Forms.BindingSource importBatchesBindingSource;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton writeBtn;
    }
}