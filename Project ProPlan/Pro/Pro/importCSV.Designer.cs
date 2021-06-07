namespace Pro
{
    partial class importCSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(importCSV));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.importBatchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importBatch = new System.Windows.Forms.Panel();
            this.MinBtn = new System.Windows.Forms.PictureBox();
            this.importBatchespnl = new System.Windows.Forms.Panel();
            this.ExitBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadExcel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.importCSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.importBatchesBindingSource)).BeginInit();
            this.importBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinBtn)).BeginInit();
            this.importBatchespnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importCSVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // importBatch
            // 
            this.importBatch.BackColor = System.Drawing.Color.Salmon;
            this.importBatch.Controls.Add(this.MinBtn);
            this.importBatch.Controls.Add(this.importBatchespnl);
            this.importBatch.Location = new System.Drawing.Point(2, 2);
            this.importBatch.Name = "importBatch";
            this.importBatch.Size = new System.Drawing.Size(810, 806);
            this.importBatch.TabIndex = 6;
            this.importBatch.Paint += new System.Windows.Forms.PaintEventHandler(this.importBatch_Paint);
            // 
            // MinBtn
            // 
            this.MinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinBtn.Image = global::Pro.Properties.Resources.minimize1;
            this.MinBtn.Location = new System.Drawing.Point(762, 10);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(34, 36);
            this.MinBtn.TabIndex = 14;
            this.MinBtn.TabStop = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // importBatchespnl
            // 
            this.importBatchespnl.BackColor = System.Drawing.Color.SlateGray;
            this.importBatchespnl.Controls.Add(this.ExitBtn);
            this.importBatchespnl.Controls.Add(this.richTextBox1);
            this.importBatchespnl.Controls.Add(this.pictureBox1);
            this.importBatchespnl.Controls.Add(this.loadExcel);
            this.importBatchespnl.Location = new System.Drawing.Point(61, 43);
            this.importBatchespnl.Name = "importBatchespnl";
            this.importBatchespnl.Size = new System.Drawing.Size(683, 687);
            this.importBatchespnl.TabIndex = 12;
            // 
            // ExitBtn
            // 
            this.ExitBtn.AllowAnimations = true;
            this.ExitBtn.AllowMouseEffects = true;
            this.ExitBtn.AllowToggling = false;
            this.ExitBtn.AnimationSpeed = 200;
            this.ExitBtn.AutoGenerateColors = false;
            this.ExitBtn.AutoRoundBorders = false;
            this.ExitBtn.AutoSizeLeftIcon = true;
            this.ExitBtn.AutoSizeRightIcon = true;
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BackColor1 = System.Drawing.Color.SlateGray;
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ExitBtn.ButtonText = "Exit";
            this.ExitBtn.ButtonTextMarginLeft = 0;
            this.ExitBtn.ColorContrastOnClick = 45;
            this.ExitBtn.ColorContrastOnHover = 45;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ExitBtn.CustomizableEdges = borderEdges1;
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExitBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ExitBtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.ExitBtn.DisabledForecolor = System.Drawing.Color.White;
            this.ExitBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ExitBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ExitBtn.IconMarginLeft = 11;
            this.ExitBtn.IconPadding = 10;
            this.ExitBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ExitBtn.IconSize = 25;
            this.ExitBtn.IdleBorderColor = System.Drawing.Color.Salmon;
            this.ExitBtn.IdleBorderRadius = 1;
            this.ExitBtn.IdleBorderThickness = 1;
            this.ExitBtn.IdleFillColor = System.Drawing.Color.SlateGray;
            this.ExitBtn.IdleIconLeftImage = null;
            this.ExitBtn.IdleIconRightImage = null;
            this.ExitBtn.IndicateFocus = false;
            this.ExitBtn.Location = new System.Drawing.Point(352, 187);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ExitBtn.OnDisabledState.BorderRadius = 1;
            this.ExitBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ExitBtn.OnDisabledState.BorderThickness = 1;
            this.ExitBtn.OnDisabledState.FillColor = System.Drawing.Color.Gray;
            this.ExitBtn.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.OnDisabledState.IconLeftImage = null;
            this.ExitBtn.OnDisabledState.IconRightImage = null;
            this.ExitBtn.onHoverState.BorderColor = System.Drawing.Color.SlateGray;
            this.ExitBtn.onHoverState.BorderRadius = 1;
            this.ExitBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ExitBtn.onHoverState.BorderThickness = 1;
            this.ExitBtn.onHoverState.FillColor = System.Drawing.Color.Salmon;
            this.ExitBtn.onHoverState.ForeColor = System.Drawing.Color.Empty;
            this.ExitBtn.onHoverState.IconLeftImage = null;
            this.ExitBtn.onHoverState.IconRightImage = null;
            this.ExitBtn.OnIdleState.BorderColor = System.Drawing.Color.Salmon;
            this.ExitBtn.OnIdleState.BorderRadius = 1;
            this.ExitBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ExitBtn.OnIdleState.BorderThickness = 1;
            this.ExitBtn.OnIdleState.FillColor = System.Drawing.Color.SlateGray;
            this.ExitBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.OnIdleState.IconLeftImage = null;
            this.ExitBtn.OnIdleState.IconRightImage = null;
            this.ExitBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ExitBtn.OnPressedState.BorderRadius = 1;
            this.ExitBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ExitBtn.OnPressedState.BorderThickness = 1;
            this.ExitBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ExitBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.OnPressedState.IconLeftImage = null;
            this.ExitBtn.OnPressedState.IconRightImage = null;
            this.ExitBtn.Size = new System.Drawing.Size(193, 52);
            this.ExitBtn.TabIndex = 33;
            this.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExitBtn.TextMarginLeft = 0;
            this.ExitBtn.TextPadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.ExitBtn.UseDefaultRadiusAndThickness = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SlateGray;
            this.richTextBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 254);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(658, 397);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pro.Properties.Resources.ImportBatches;
            this.pictureBox1.Location = new System.Drawing.Point(276, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 124);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // loadExcel
            // 
            this.loadExcel.AllowAnimations = true;
            this.loadExcel.AllowMouseEffects = true;
            this.loadExcel.AllowToggling = false;
            this.loadExcel.AnimationSpeed = 200;
            this.loadExcel.AutoGenerateColors = false;
            this.loadExcel.AutoRoundBorders = false;
            this.loadExcel.AutoSizeLeftIcon = true;
            this.loadExcel.AutoSizeRightIcon = true;
            this.loadExcel.BackColor = System.Drawing.Color.Transparent;
            this.loadExcel.BackColor1 = System.Drawing.Color.SlateGray;
            this.loadExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadExcel.BackgroundImage")));
            this.loadExcel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loadExcel.ButtonText = "Import Excel File";
            this.loadExcel.ButtonTextMarginLeft = 0;
            this.loadExcel.ColorContrastOnClick = 45;
            this.loadExcel.ColorContrastOnHover = 45;
            this.loadExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.loadExcel.CustomizableEdges = borderEdges2;
            this.loadExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loadExcel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.loadExcel.DisabledFillColor = System.Drawing.Color.Gray;
            this.loadExcel.DisabledForecolor = System.Drawing.Color.White;
            this.loadExcel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.loadExcel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExcel.ForeColor = System.Drawing.Color.White;
            this.loadExcel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadExcel.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.loadExcel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.loadExcel.IconMarginLeft = 11;
            this.loadExcel.IconPadding = 10;
            this.loadExcel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadExcel.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.loadExcel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.loadExcel.IconSize = 25;
            this.loadExcel.IdleBorderColor = System.Drawing.Color.Salmon;
            this.loadExcel.IdleBorderRadius = 1;
            this.loadExcel.IdleBorderThickness = 1;
            this.loadExcel.IdleFillColor = System.Drawing.Color.SlateGray;
            this.loadExcel.IdleIconLeftImage = null;
            this.loadExcel.IdleIconRightImage = null;
            this.loadExcel.IndicateFocus = false;
            this.loadExcel.Location = new System.Drawing.Point(137, 187);
            this.loadExcel.Name = "loadExcel";
            this.loadExcel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.loadExcel.OnDisabledState.BorderRadius = 1;
            this.loadExcel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loadExcel.OnDisabledState.BorderThickness = 1;
            this.loadExcel.OnDisabledState.FillColor = System.Drawing.Color.Gray;
            this.loadExcel.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.loadExcel.OnDisabledState.IconLeftImage = null;
            this.loadExcel.OnDisabledState.IconRightImage = null;
            this.loadExcel.onHoverState.BorderColor = System.Drawing.Color.SlateGray;
            this.loadExcel.onHoverState.BorderRadius = 1;
            this.loadExcel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loadExcel.onHoverState.BorderThickness = 1;
            this.loadExcel.onHoverState.FillColor = System.Drawing.Color.Salmon;
            this.loadExcel.onHoverState.ForeColor = System.Drawing.Color.Empty;
            this.loadExcel.onHoverState.IconLeftImage = null;
            this.loadExcel.onHoverState.IconRightImage = null;
            this.loadExcel.OnIdleState.BorderColor = System.Drawing.Color.Salmon;
            this.loadExcel.OnIdleState.BorderRadius = 1;
            this.loadExcel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loadExcel.OnIdleState.BorderThickness = 1;
            this.loadExcel.OnIdleState.FillColor = System.Drawing.Color.SlateGray;
            this.loadExcel.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.loadExcel.OnIdleState.IconLeftImage = null;
            this.loadExcel.OnIdleState.IconRightImage = null;
            this.loadExcel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.loadExcel.OnPressedState.BorderRadius = 1;
            this.loadExcel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loadExcel.OnPressedState.BorderThickness = 1;
            this.loadExcel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.loadExcel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.loadExcel.OnPressedState.IconLeftImage = null;
            this.loadExcel.OnPressedState.IconRightImage = null;
            this.loadExcel.Size = new System.Drawing.Size(193, 52);
            this.loadExcel.TabIndex = 14;
            this.loadExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadExcel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.loadExcel.TextMarginLeft = 0;
            this.loadExcel.TextPadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.loadExcel.UseDefaultRadiusAndThickness = true;
            this.loadExcel.Click += new System.EventHandler(this.loadExcel_Click);
            // 
            // importCSVBindingSource
            // 
            this.importCSVBindingSource.DataSource = typeof(Pro.importCSV);
            // 
            // importCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 780);
            this.Controls.Add(this.importBatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "importCSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.importCSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.importBatchesBindingSource)).EndInit();
            this.importBatch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinBtn)).EndInit();
            this.importBatchespnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importCSVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel importBatch;
        private System.Windows.Forms.Panel importBatchespnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton loadExcel;
        private System.Windows.Forms.BindingSource importBatchesBindingSource;
        private System.Windows.Forms.BindingSource importCSVBindingSource;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ExitBtn;
        private System.Windows.Forms.PictureBox MinBtn;
    }
}