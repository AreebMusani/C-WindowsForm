namespace Pro
{
    partial class Reminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminder));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.registerUser = new System.Windows.Forms.Panel();
            this.reminderFormpnl = new System.Windows.Forms.Panel();
            this.stdBox4 = new System.Windows.Forms.ComboBox();
            this.Message = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Stop = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Start = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.registerUser.SuspendLayout();
            this.reminderFormpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registerUser
            // 
            this.registerUser.BackColor = System.Drawing.Color.Salmon;
            this.registerUser.Controls.Add(this.reminderFormpnl);
            this.registerUser.Location = new System.Drawing.Point(12, 12);
            this.registerUser.Name = "registerUser";
            this.registerUser.Size = new System.Drawing.Size(526, 580);
            this.registerUser.TabIndex = 1;
            this.registerUser.Paint += new System.Windows.Forms.PaintEventHandler(this.registerUser_Paint);
            // 
            // reminderFormpnl
            // 
            this.reminderFormpnl.BackColor = System.Drawing.Color.SlateGray;
            this.reminderFormpnl.Controls.Add(this.stdBox4);
            this.reminderFormpnl.Controls.Add(this.Message);
            this.reminderFormpnl.Controls.Add(this.timeLbl);
            this.reminderFormpnl.Controls.Add(this.maskedTextBox1);
            this.reminderFormpnl.Controls.Add(this.Stop);
            this.reminderFormpnl.Controls.Add(this.Start);
            this.reminderFormpnl.Controls.Add(this.pictureBox1);
            this.reminderFormpnl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderFormpnl.Location = new System.Drawing.Point(57, 37);
            this.reminderFormpnl.Name = "reminderFormpnl";
            this.reminderFormpnl.Size = new System.Drawing.Size(392, 503);
            this.reminderFormpnl.TabIndex = 12;
            // 
            // stdBox4
            // 
            this.stdBox4.BackColor = System.Drawing.Color.SlateGray;
            this.stdBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stdBox4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdBox4.FormattingEnabled = true;
            this.stdBox4.Location = new System.Drawing.Point(249, 172);
            this.stdBox4.Name = "stdBox4";
            this.stdBox4.Size = new System.Drawing.Size(73, 30);
            this.stdBox4.TabIndex = 41;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.BackColor = System.Drawing.Color.Salmon;
            this.Message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Message.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.ForeColor = System.Drawing.Color.Transparent;
            this.Message.Location = new System.Drawing.Point(70, 205);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(96, 30);
            this.Message.TabIndex = 40;
            this.Message.Text = "Message";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.BackColor = System.Drawing.Color.Salmon;
            this.timeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLbl.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.Transparent;
            this.timeLbl.Location = new System.Drawing.Point(70, 173);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(63, 30);
            this.timeLbl.TabIndex = 39;
            this.timeLbl.Text = "Time";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.LightGray;
            this.maskedTextBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(139, 173);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(104, 29);
            this.maskedTextBox1.TabIndex = 16;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Stop
            // 
            this.Stop.AllowAnimations = true;
            this.Stop.AllowMouseEffects = true;
            this.Stop.AllowToggling = false;
            this.Stop.AnimationSpeed = 200;
            this.Stop.AutoGenerateColors = false;
            this.Stop.AutoRoundBorders = false;
            this.Stop.AutoSizeLeftIcon = true;
            this.Stop.AutoSizeRightIcon = true;
            this.Stop.BackColor = System.Drawing.Color.Transparent;
            this.Stop.BackColor1 = System.Drawing.Color.SlateGray;
            this.Stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Stop.BackgroundImage")));
            this.Stop.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Stop.ButtonText = "Stop";
            this.Stop.ButtonTextMarginLeft = 0;
            this.Stop.ColorContrastOnClick = 45;
            this.Stop.ColorContrastOnHover = 45;
            this.Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Stop.CustomizableEdges = borderEdges1;
            this.Stop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Stop.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Stop.DisabledFillColor = System.Drawing.Color.Gray;
            this.Stop.DisabledForecolor = System.Drawing.Color.White;
            this.Stop.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Stop.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.ForeColor = System.Drawing.Color.White;
            this.Stop.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Stop.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Stop.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Stop.IconMarginLeft = 11;
            this.Stop.IconPadding = 10;
            this.Stop.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Stop.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Stop.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Stop.IconSize = 25;
            this.Stop.IdleBorderColor = System.Drawing.Color.Salmon;
            this.Stop.IdleBorderRadius = 1;
            this.Stop.IdleBorderThickness = 1;
            this.Stop.IdleFillColor = System.Drawing.Color.SlateGray;
            this.Stop.IdleIconLeftImage = null;
            this.Stop.IdleIconRightImage = null;
            this.Stop.IndicateFocus = false;
            this.Stop.Location = new System.Drawing.Point(204, 441);
            this.Stop.Name = "Stop";
            this.Stop.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Stop.OnDisabledState.BorderRadius = 1;
            this.Stop.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Stop.OnDisabledState.BorderThickness = 1;
            this.Stop.OnDisabledState.FillColor = System.Drawing.Color.Gray;
            this.Stop.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.Stop.OnDisabledState.IconLeftImage = null;
            this.Stop.OnDisabledState.IconRightImage = null;
            this.Stop.onHoverState.BorderColor = System.Drawing.Color.SlateGray;
            this.Stop.onHoverState.BorderRadius = 1;
            this.Stop.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Stop.onHoverState.BorderThickness = 1;
            this.Stop.onHoverState.FillColor = System.Drawing.Color.Salmon;
            this.Stop.onHoverState.ForeColor = System.Drawing.Color.Empty;
            this.Stop.onHoverState.IconLeftImage = null;
            this.Stop.onHoverState.IconRightImage = null;
            this.Stop.OnIdleState.BorderColor = System.Drawing.Color.Salmon;
            this.Stop.OnIdleState.BorderRadius = 1;
            this.Stop.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Stop.OnIdleState.BorderThickness = 1;
            this.Stop.OnIdleState.FillColor = System.Drawing.Color.SlateGray;
            this.Stop.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Stop.OnIdleState.IconLeftImage = null;
            this.Stop.OnIdleState.IconRightImage = null;
            this.Stop.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Stop.OnPressedState.BorderRadius = 1;
            this.Stop.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Stop.OnPressedState.BorderThickness = 1;
            this.Stop.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Stop.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Stop.OnPressedState.IconLeftImage = null;
            this.Stop.OnPressedState.IconRightImage = null;
            this.Stop.Size = new System.Drawing.Size(118, 46);
            this.Stop.TabIndex = 15;
            this.Stop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Stop.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Stop.TextMarginLeft = 0;
            this.Stop.TextPadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Stop.UseDefaultRadiusAndThickness = true;
            // 
            // Start
            // 
            this.Start.AllowAnimations = true;
            this.Start.AllowMouseEffects = true;
            this.Start.AllowToggling = false;
            this.Start.AnimationSpeed = 200;
            this.Start.AutoGenerateColors = false;
            this.Start.AutoRoundBorders = false;
            this.Start.AutoSizeLeftIcon = true;
            this.Start.AutoSizeRightIcon = true;
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.BackColor1 = System.Drawing.Color.SlateGray;
            this.Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Start.BackgroundImage")));
            this.Start.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Start.ButtonText = "Start";
            this.Start.ButtonTextMarginLeft = 0;
            this.Start.ColorContrastOnClick = 45;
            this.Start.ColorContrastOnHover = 45;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.Start.CustomizableEdges = borderEdges2;
            this.Start.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Start.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Start.DisabledFillColor = System.Drawing.Color.Gray;
            this.Start.DisabledForecolor = System.Drawing.Color.White;
            this.Start.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Start.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Start.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Start.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Start.IconMarginLeft = 11;
            this.Start.IconPadding = 10;
            this.Start.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Start.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Start.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Start.IconSize = 25;
            this.Start.IdleBorderColor = System.Drawing.Color.Salmon;
            this.Start.IdleBorderRadius = 1;
            this.Start.IdleBorderThickness = 1;
            this.Start.IdleFillColor = System.Drawing.Color.SlateGray;
            this.Start.IdleIconLeftImage = null;
            this.Start.IdleIconRightImage = null;
            this.Start.IndicateFocus = false;
            this.Start.Location = new System.Drawing.Point(70, 441);
            this.Start.Name = "Start";
            this.Start.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Start.OnDisabledState.BorderRadius = 1;
            this.Start.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Start.OnDisabledState.BorderThickness = 1;
            this.Start.OnDisabledState.FillColor = System.Drawing.Color.Gray;
            this.Start.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.Start.OnDisabledState.IconLeftImage = null;
            this.Start.OnDisabledState.IconRightImage = null;
            this.Start.onHoverState.BorderColor = System.Drawing.Color.SlateGray;
            this.Start.onHoverState.BorderRadius = 1;
            this.Start.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Start.onHoverState.BorderThickness = 1;
            this.Start.onHoverState.FillColor = System.Drawing.Color.Salmon;
            this.Start.onHoverState.ForeColor = System.Drawing.Color.Empty;
            this.Start.onHoverState.IconLeftImage = null;
            this.Start.onHoverState.IconRightImage = null;
            this.Start.OnIdleState.BorderColor = System.Drawing.Color.Salmon;
            this.Start.OnIdleState.BorderRadius = 1;
            this.Start.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Start.OnIdleState.BorderThickness = 1;
            this.Start.OnIdleState.FillColor = System.Drawing.Color.SlateGray;
            this.Start.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Start.OnIdleState.IconLeftImage = null;
            this.Start.OnIdleState.IconRightImage = null;
            this.Start.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Start.OnPressedState.BorderRadius = 1;
            this.Start.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Start.OnPressedState.BorderThickness = 1;
            this.Start.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Start.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Start.OnPressedState.IconLeftImage = null;
            this.Start.OnPressedState.IconRightImage = null;
            this.Start.Size = new System.Drawing.Size(116, 46);
            this.Start.TabIndex = 14;
            this.Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Start.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Start.TextMarginLeft = 0;
            this.Start.TextPadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Start.UseDefaultRadiusAndThickness = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pro.Properties.Resources.reminders;
            this.pictureBox1.Location = new System.Drawing.Point(129, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 136);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Text = "Reminder";
            this.notifyIcon1.Visible = true;
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 568);
            this.Controls.Add(this.registerUser);
            this.Name = "Reminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder";
            this.registerUser.ResumeLayout(false);
            this.reminderFormpnl.ResumeLayout(false);
            this.reminderFormpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel registerUser;
        private System.Windows.Forms.Panel reminderFormpnl;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Stop;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.ComboBox stdBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}