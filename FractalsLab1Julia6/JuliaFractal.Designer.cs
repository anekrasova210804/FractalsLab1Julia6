namespace FractalsLab1Julia6
{
    partial class JuliaFractalUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuliaFractalUI));
            tableLayout = new TableLayoutPanel();
            cNumberLabel = new Label();
            iterationsLabel = new Label();
            radiusLabel = new Label();
            viewOffSetXLabel = new Label();
            viewOffsetYLabel = new Label();
            zoomLabel = new Label();
            RealСhoice = new TextBox();
            offsetXChoice = new NumericUpDown();
            offsetYChoice = new NumericUpDown();
            zoomChoice = new NumericUpDown();
            iterationsChoice = new NumericUpDown();
            juliaPictureBox = new PictureBox();
            juliaLabel = new Label();
            saveButton = new Button();
            renderButton = new Button();
            ImaginaryChoice = new TextBox();
            radiusChoice = new NumericUpDown();
            tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)offsetXChoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)offsetYChoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zoomChoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iterationsChoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)juliaPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radiusChoice).BeginInit();
            SuspendLayout();
            // 
            // tableLayout
            // 
            tableLayout.BackColor = Color.GhostWhite;
            tableLayout.ColumnCount = 8;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.499327F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.0597F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 24F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 89F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayout.Controls.Add(cNumberLabel, 3, 3);
            tableLayout.Controls.Add(iterationsLabel, 3, 5);
            tableLayout.Controls.Add(radiusLabel, 3, 7);
            tableLayout.Controls.Add(viewOffSetXLabel, 3, 9);
            tableLayout.Controls.Add(viewOffsetYLabel, 3, 11);
            tableLayout.Controls.Add(zoomLabel, 3, 13);
            tableLayout.Controls.Add(RealСhoice, 5, 3);
            tableLayout.Controls.Add(offsetXChoice, 5, 9);
            tableLayout.Controls.Add(offsetYChoice, 5, 11);
            tableLayout.Controls.Add(zoomChoice, 5, 13);
            tableLayout.Controls.Add(iterationsChoice, 5, 5);
            tableLayout.Controls.Add(juliaPictureBox, 1, 3);
            tableLayout.Controls.Add(juliaLabel, 1, 15);
            tableLayout.Controls.Add(saveButton, 3, 15);
            tableLayout.Controls.Add(renderButton, 5, 15);
            tableLayout.Controls.Add(ImaginaryChoice, 6, 3);
            tableLayout.Controls.Add(radiusChoice, 5, 7);
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Location = new Point(0, 0);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 17;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 3.85906029F));
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 14F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayout.Size = new Size(1216, 784);
            tableLayout.TabIndex = 0;
            // 
            // cNumberLabel
            // 
            cNumberLabel.AutoSize = true;
            cNumberLabel.BackColor = Color.MediumPurple;
            cNumberLabel.Dock = DockStyle.Fill;
            cNumberLabel.Font = new Font("MS Gothic", 11.25F, FontStyle.Bold);
            cNumberLabel.ForeColor = Color.GhostWhite;
            cNumberLabel.Location = new Point(835, 31);
            cNumberLabel.Name = "cNumberLabel";
            cNumberLabel.Size = new Size(154, 33);
            cNumberLabel.TabIndex = 0;
            cNumberLabel.Text = "C:";
            cNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iterationsLabel
            // 
            iterationsLabel.AutoSize = true;
            iterationsLabel.BackColor = Color.MediumPurple;
            iterationsLabel.Dock = DockStyle.Fill;
            iterationsLabel.Font = new Font("MS Gothic", 11.25F, FontStyle.Bold);
            iterationsLabel.ForeColor = Color.GhostWhite;
            iterationsLabel.Location = new Point(835, 79);
            iterationsLabel.Name = "iterationsLabel";
            iterationsLabel.Size = new Size(154, 35);
            iterationsLabel.TabIndex = 1;
            iterationsLabel.Text = "Iterations:";
            iterationsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radiusLabel
            // 
            radiusLabel.AutoSize = true;
            radiusLabel.BackColor = Color.MediumPurple;
            radiusLabel.Dock = DockStyle.Fill;
            radiusLabel.Font = new Font("MS Gothic", 11.25F, FontStyle.Bold);
            radiusLabel.ForeColor = Color.GhostWhite;
            radiusLabel.Location = new Point(835, 126);
            radiusLabel.Name = "radiusLabel";
            radiusLabel.Size = new Size(154, 38);
            radiusLabel.TabIndex = 2;
            radiusLabel.Text = "Radius:";
            radiusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // viewOffSetXLabel
            // 
            viewOffSetXLabel.AutoSize = true;
            viewOffSetXLabel.BackColor = Color.MediumPurple;
            viewOffSetXLabel.Dock = DockStyle.Fill;
            viewOffSetXLabel.Font = new Font("MS Gothic", 11.25F, FontStyle.Bold);
            viewOffSetXLabel.ForeColor = Color.GhostWhite;
            viewOffSetXLabel.Location = new Point(835, 176);
            viewOffSetXLabel.Name = "viewOffSetXLabel";
            viewOffSetXLabel.Size = new Size(154, 36);
            viewOffSetXLabel.TabIndex = 3;
            viewOffSetXLabel.Text = "View Offset X:";
            viewOffSetXLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // viewOffsetYLabel
            // 
            viewOffsetYLabel.AutoSize = true;
            viewOffsetYLabel.BackColor = Color.MediumPurple;
            viewOffsetYLabel.Dock = DockStyle.Fill;
            viewOffsetYLabel.Font = new Font("MS Gothic", 11.25F, FontStyle.Bold);
            viewOffsetYLabel.ForeColor = Color.GhostWhite;
            viewOffsetYLabel.Location = new Point(835, 226);
            viewOffsetYLabel.Name = "viewOffsetYLabel";
            viewOffsetYLabel.Size = new Size(154, 36);
            viewOffsetYLabel.TabIndex = 4;
            viewOffsetYLabel.Text = "View Offset Y:";
            viewOffsetYLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // zoomLabel
            // 
            zoomLabel.AutoSize = true;
            zoomLabel.BackColor = Color.MediumPurple;
            zoomLabel.Dock = DockStyle.Fill;
            zoomLabel.Font = new Font("MS Gothic", 11.25F, FontStyle.Bold);
            zoomLabel.ForeColor = Color.GhostWhite;
            zoomLabel.Location = new Point(835, 274);
            zoomLabel.Name = "zoomLabel";
            zoomLabel.Size = new Size(154, 36);
            zoomLabel.TabIndex = 5;
            zoomLabel.Text = "Zoom:";
            zoomLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RealСhoice
            // 
            RealСhoice.BorderStyle = BorderStyle.FixedSingle;
            RealСhoice.Cursor = Cursors.IBeam;
            RealСhoice.Dock = DockStyle.Left;
            RealСhoice.Font = new Font("MS Gothic", 9F);
            RealСhoice.Location = new Point(1017, 34);
            RealСhoice.Name = "RealСhoice";
            RealСhoice.Size = new Size(73, 19);
            RealСhoice.TabIndex = 6;
            RealСhoice.Text = "0,12";
            // 
            // offsetXChoice
            // 
            offsetXChoice.BorderStyle = BorderStyle.FixedSingle;
            tableLayout.SetColumnSpan(offsetXChoice, 2);
            offsetXChoice.DecimalPlaces = 16;
            offsetXChoice.Dock = DockStyle.Left;
            offsetXChoice.Font = new Font("MS Gothic", 9F);
            offsetXChoice.Location = new Point(1017, 179);
            offsetXChoice.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            offsetXChoice.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            offsetXChoice.Name = "offsetXChoice";
            offsetXChoice.Size = new Size(173, 19);
            offsetXChoice.TabIndex = 9;
            // 
            // offsetYChoice
            // 
            offsetYChoice.BorderStyle = BorderStyle.FixedSingle;
            tableLayout.SetColumnSpan(offsetYChoice, 2);
            offsetYChoice.DecimalPlaces = 16;
            offsetYChoice.Dock = DockStyle.Left;
            offsetYChoice.Font = new Font("MS Gothic", 9F);
            offsetYChoice.Location = new Point(1017, 229);
            offsetYChoice.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            offsetYChoice.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            offsetYChoice.Name = "offsetYChoice";
            offsetYChoice.Size = new Size(173, 19);
            offsetYChoice.TabIndex = 10;
            // 
            // zoomChoice
            // 
            zoomChoice.BorderStyle = BorderStyle.FixedSingle;
            tableLayout.SetColumnSpan(zoomChoice, 2);
            zoomChoice.Dock = DockStyle.Left;
            zoomChoice.Font = new Font("MS Gothic", 9F);
            zoomChoice.Location = new Point(1017, 277);
            zoomChoice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            zoomChoice.Name = "zoomChoice";
            zoomChoice.Size = new Size(173, 19);
            zoomChoice.TabIndex = 11;
            zoomChoice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // iterationsChoice
            // 
            iterationsChoice.BorderStyle = BorderStyle.FixedSingle;
            tableLayout.SetColumnSpan(iterationsChoice, 2);
            iterationsChoice.Dock = DockStyle.Left;
            iterationsChoice.Font = new Font("MS Gothic", 9F);
            iterationsChoice.Location = new Point(1017, 82);
            iterationsChoice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            iterationsChoice.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            iterationsChoice.Name = "iterationsChoice";
            iterationsChoice.Size = new Size(173, 19);
            iterationsChoice.TabIndex = 12;
            iterationsChoice.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // juliaPictureBox
            // 
            juliaPictureBox.BackColor = SystemColors.WindowText;
            juliaPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            juliaPictureBox.Dock = DockStyle.Fill;
            juliaPictureBox.Location = new Point(42, 34);
            juliaPictureBox.Name = "juliaPictureBox";
            tableLayout.SetRowSpan(juliaPictureBox, 12);
            juliaPictureBox.Size = new Size(763, 684);
            juliaPictureBox.TabIndex = 13;
            juliaPictureBox.TabStop = false;
            // 
            // juliaLabel
            // 
            juliaLabel.AutoSize = true;
            juliaLabel.BackColor = Color.MediumPurple;
            juliaLabel.Dock = DockStyle.Fill;
            juliaLabel.Font = new Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            juliaLabel.ForeColor = SystemColors.ButtonFace;
            juliaLabel.Location = new Point(42, 721);
            juliaLabel.Name = "juliaLabel";
            juliaLabel.Size = new Size(763, 43);
            juliaLabel.TabIndex = 14;
            juliaLabel.Text = "Julia Set f(z) = z⁵ + c";
            juliaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.SlateBlue;
            saveButton.Dock = DockStyle.Fill;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("MS Gothic", 12F, FontStyle.Bold);
            saveButton.ForeColor = SystemColors.ButtonFace;
            saveButton.Location = new Point(835, 724);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(154, 37);
            saveButton.TabIndex = 15;
            saveButton.Text = "Save as JPEG";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // renderButton
            // 
            renderButton.BackColor = Color.MediumOrchid;
            tableLayout.SetColumnSpan(renderButton, 2);
            renderButton.Dock = DockStyle.Fill;
            renderButton.FlatStyle = FlatStyle.Flat;
            renderButton.Font = new Font("MS Gothic", 12F, FontStyle.Bold);
            renderButton.ForeColor = SystemColors.ButtonFace;
            renderButton.Location = new Point(1017, 724);
            renderButton.Name = "renderButton";
            renderButton.Size = new Size(173, 37);
            renderButton.TabIndex = 16;
            renderButton.Text = "Render";
            renderButton.UseVisualStyleBackColor = false;
            renderButton.Click += renderButton_Click;
            // 
            // ImaginaryChoice
            // 
            ImaginaryChoice.BorderStyle = BorderStyle.FixedSingle;
            ImaginaryChoice.Dock = DockStyle.Right;
            ImaginaryChoice.Font = new Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ImaginaryChoice.Location = new Point(1114, 34);
            ImaginaryChoice.Name = "ImaginaryChoice";
            ImaginaryChoice.Size = new Size(76, 19);
            ImaginaryChoice.TabIndex = 17;
            ImaginaryChoice.Text = "-0,66";
            // 
            // radiusChoice
            // 
            radiusChoice.BorderStyle = BorderStyle.FixedSingle;
            tableLayout.SetColumnSpan(radiusChoice, 2);
            radiusChoice.Font = new Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radiusChoice.Location = new Point(1017, 129);
            radiusChoice.Name = "radiusChoice";
            radiusChoice.Size = new Size(173, 19);
            radiusChoice.TabIndex = 18;
            radiusChoice.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // JuliaFractalUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 784);
            Controls.Add(tableLayout);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "JuliaFractalUI";
            Text = "Julia Fractal 6";
            tableLayout.ResumeLayout(false);
            tableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)offsetXChoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)offsetYChoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)zoomChoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)iterationsChoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)juliaPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)radiusChoice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayout;
        private Label cNumberLabel;
        private Label iterationsLabel;
        private Label radiusLabel;
        private Label viewOffSetXLabel;
        private Label viewOffsetYLabel;
        private Label zoomLabel;
        private TextBox RealСhoice;
        private NumericUpDown offsetXChoice;
        private NumericUpDown offsetYChoice;
        private NumericUpDown zoomChoice;
        private NumericUpDown iterationsChoice;
        private PictureBox juliaPictureBox;
        private Label juliaLabel;
        private Button saveButton;
        private Button renderButton;
        private TextBox ImaginaryChoice;
        private NumericUpDown radiusChoice;
    }
}
