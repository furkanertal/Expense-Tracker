namespace ProjeHazırlık1
{
    partial class FormKaydet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKaydet));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.comboBoxAy = new System.Windows.Forms.ComboBox();
            this.comboBoxGider = new System.Windows.Forms.ComboBox();
            this.comboBoxGelir = new System.Windows.Forms.ComboBox();
            this.textBoxIslemler = new System.Windows.Forms.TextBox();
            this.radioButtonGider = new System.Windows.Forms.RadioButton();
            this.radioButtonGelir = new System.Windows.Forms.RadioButton();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.ButtonKaydet = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // comboBoxAy
            // 
            this.comboBoxAy.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxAy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxAy.FormattingEnabled = true;
            this.comboBoxAy.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBoxAy.Location = new System.Drawing.Point(276, 359);
            this.comboBoxAy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxAy.Name = "comboBoxAy";
            this.comboBoxAy.Size = new System.Drawing.Size(212, 35);
            this.comboBoxAy.TabIndex = 28;
            // 
            // comboBoxGider
            // 
            this.comboBoxGider.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxGider.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxGider.FormattingEnabled = true;
            this.comboBoxGider.Items.AddRange(new object[] {
            "Personnel Expenses",
            "Raw Material or Supply Expenses",
            "Rent Expenses",
            "Energy and Fuel Expenses",
            "Sales and Marketing Expenses",
            "Taxes",
            "Research&Development Expenses",
            "Debt Payments"});
            this.comboBoxGider.Location = new System.Drawing.Point(512, 270);
            this.comboBoxGider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxGider.Name = "comboBoxGider";
            this.comboBoxGider.Size = new System.Drawing.Size(212, 35);
            this.comboBoxGider.TabIndex = 27;
            // 
            // comboBoxGelir
            // 
            this.comboBoxGelir.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxGelir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxGelir.FormattingEnabled = true;
            this.comboBoxGelir.Items.AddRange(new object[] {
            "Sales Revenue",
            "Interest Income",
            "Rental Income",
            "Investment Income",
            "Government Grants",
            "Licensing or Royalty Income",
            "Export Revenue"});
            this.comboBoxGelir.Location = new System.Drawing.Point(276, 270);
            this.comboBoxGelir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxGelir.Name = "comboBoxGelir";
            this.comboBoxGelir.Size = new System.Drawing.Size(212, 35);
            this.comboBoxGelir.TabIndex = 26;
            // 
            // textBoxIslemler
            // 
            this.textBoxIslemler.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxIslemler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxIslemler.Location = new System.Drawing.Point(276, 431);
            this.textBoxIslemler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxIslemler.Name = "textBoxIslemler";
            this.textBoxIslemler.Size = new System.Drawing.Size(212, 31);
            this.textBoxIslemler.TabIndex = 25;
            // 
            // radioButtonGider
            // 
            this.radioButtonGider.AutoSize = true;
            this.radioButtonGider.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonGider.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonGider.Location = new System.Drawing.Point(512, 200);
            this.radioButtonGider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonGider.Name = "radioButtonGider";
            this.radioButtonGider.Size = new System.Drawing.Size(117, 31);
            this.radioButtonGider.TabIndex = 24;
            this.radioButtonGider.TabStop = true;
            this.radioButtonGider.Text = "Expense";
            this.radioButtonGider.UseVisualStyleBackColor = true;
            // 
            // radioButtonGelir
            // 
            this.radioButtonGelir.AutoSize = true;
            this.radioButtonGelir.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonGelir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonGelir.Location = new System.Drawing.Point(295, 200);
            this.radioButtonGelir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonGelir.Name = "radioButtonGelir";
            this.radioButtonGelir.Size = new System.Drawing.Size(105, 31);
            this.radioButtonGelir.TabIndex = 23;
            this.radioButtonGelir.TabStop = true;
            this.radioButtonGelir.Text = "Income";
            this.radioButtonGelir.UseVisualStyleBackColor = true;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuLabel5.Location = new System.Drawing.Point(27, 431);
            this.bunifuLabel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(84, 27);
            this.bunifuLabel5.TabIndex = 22;
            this.bunifuLabel5.Text = "Amount:";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuLabel4.Location = new System.Drawing.Point(27, 359);
            this.bunifuLabel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(60, 27);
            this.bunifuLabel4.TabIndex = 21;
            this.bunifuLabel4.Text = "Month";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuLabel3.Location = new System.Drawing.Point(27, 278);
            this.bunifuLabel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(108, 27);
            this.bunifuLabel3.TabIndex = 20;
            this.bunifuLabel3.Text = "Category:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuLabel2.Location = new System.Drawing.Point(27, 200);
            this.bunifuLabel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(240, 27);
            this.bunifuLabel2.TabIndex = 19;
            this.bunifuLabel2.Text = "Type of Transaction: ";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ButtonKaydet
            // 
            this.ButtonKaydet.AllowAnimations = true;
            this.ButtonKaydet.AllowMouseEffects = true;
            this.ButtonKaydet.AllowToggling = false;
            this.ButtonKaydet.AnimationSpeed = 200;
            this.ButtonKaydet.AutoGenerateColors = false;
            this.ButtonKaydet.AutoRoundBorders = false;
            this.ButtonKaydet.AutoSizeLeftIcon = true;
            this.ButtonKaydet.AutoSizeRightIcon = true;
            this.ButtonKaydet.BackColor = System.Drawing.Color.Transparent;
            this.ButtonKaydet.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.ButtonKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonKaydet.BackgroundImage")));
            this.ButtonKaydet.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonKaydet.ButtonText = "Save";
            this.ButtonKaydet.ButtonTextMarginLeft = 0;
            this.ButtonKaydet.ColorContrastOnClick = 45;
            this.ButtonKaydet.ColorContrastOnHover = 45;
            this.ButtonKaydet.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ButtonKaydet.CustomizableEdges = borderEdges1;
            this.ButtonKaydet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonKaydet.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonKaydet.DisabledFillColor = System.Drawing.Color.Empty;
            this.ButtonKaydet.DisabledForecolor = System.Drawing.Color.Empty;
            this.ButtonKaydet.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ButtonKaydet.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonKaydet.ForeColor = System.Drawing.Color.White;
            this.ButtonKaydet.IconLeft = null;
            this.ButtonKaydet.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonKaydet.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ButtonKaydet.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ButtonKaydet.IconMarginLeft = 11;
            this.ButtonKaydet.IconPadding = 10;
            this.ButtonKaydet.IconRight = null;
            this.ButtonKaydet.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonKaydet.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ButtonKaydet.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ButtonKaydet.IconSize = 25;
            this.ButtonKaydet.IdleBorderColor = System.Drawing.Color.Empty;
            this.ButtonKaydet.IdleBorderRadius = 0;
            this.ButtonKaydet.IdleBorderThickness = 0;
            this.ButtonKaydet.IdleFillColor = System.Drawing.Color.Empty;
            this.ButtonKaydet.IdleIconLeftImage = null;
            this.ButtonKaydet.IdleIconRightImage = null;
            this.ButtonKaydet.IndicateFocus = false;
            this.ButtonKaydet.Location = new System.Drawing.Point(564, 392);
            this.ButtonKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonKaydet.Name = "ButtonKaydet";
            this.ButtonKaydet.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonKaydet.OnDisabledState.BorderRadius = 1;
            this.ButtonKaydet.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonKaydet.OnDisabledState.BorderThickness = 1;
            this.ButtonKaydet.OnDisabledState.FillColor = System.Drawing.Color.Gray;
            this.ButtonKaydet.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ButtonKaydet.OnDisabledState.IconLeftImage = null;
            this.ButtonKaydet.OnDisabledState.IconRightImage = null;
            this.ButtonKaydet.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.ButtonKaydet.onHoverState.BorderRadius = 1;
            this.ButtonKaydet.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonKaydet.onHoverState.BorderThickness = 1;
            this.ButtonKaydet.onHoverState.FillColor = System.Drawing.SystemColors.GrayText;
            this.ButtonKaydet.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonKaydet.onHoverState.IconLeftImage = null;
            this.ButtonKaydet.onHoverState.IconRightImage = null;
            this.ButtonKaydet.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonKaydet.OnIdleState.BorderRadius = 1;
            this.ButtonKaydet.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonKaydet.OnIdleState.BorderThickness = 1;
            this.ButtonKaydet.OnIdleState.FillColor = System.Drawing.SystemColors.GrayText;
            this.ButtonKaydet.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ButtonKaydet.OnIdleState.IconLeftImage = null;
            this.ButtonKaydet.OnIdleState.IconRightImage = null;
            this.ButtonKaydet.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ButtonKaydet.OnPressedState.BorderRadius = 1;
            this.ButtonKaydet.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonKaydet.OnPressedState.BorderThickness = 1;
            this.ButtonKaydet.OnPressedState.FillColor = System.Drawing.SystemColors.GrayText;
            this.ButtonKaydet.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ButtonKaydet.OnPressedState.IconLeftImage = null;
            this.ButtonKaydet.OnPressedState.IconRightImage = null;
            this.ButtonKaydet.Size = new System.Drawing.Size(160, 66);
            this.ButtonKaydet.TabIndex = 29;
            this.ButtonKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonKaydet.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonKaydet.TextMarginLeft = 0;
            this.ButtonKaydet.TextPadding = new System.Windows.Forms.Padding(0);
            this.ButtonKaydet.UseDefaultRadiusAndThickness = true;
            this.ButtonKaydet.Click += new System.EventHandler(this.ButtonKaydet_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Cascadia Code", 22F);
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuLabel1.Location = new System.Drawing.Point(101, 61);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(528, 49);
            this.bunifuLabel1.TabIndex = 30;
            this.bunifuLabel1.Text = "Add Data to the Database";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // FormKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(750, 499);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.ButtonKaydet);
            this.Controls.Add(this.comboBoxAy);
            this.Controls.Add(this.comboBoxGider);
            this.Controls.Add(this.comboBoxGelir);
            this.Controls.Add(this.textBoxIslemler);
            this.Controls.Add(this.radioButtonGider);
            this.Controls.Add(this.radioButtonGelir);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormKaydet";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.FormKaydet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxAy;
        public System.Windows.Forms.ComboBox comboBoxGider;
        public System.Windows.Forms.ComboBox comboBoxGelir;
        public System.Windows.Forms.TextBox textBoxIslemler;
        public System.Windows.Forms.RadioButton radioButtonGider;
        public System.Windows.Forms.RadioButton radioButtonGelir;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ButtonKaydet;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}