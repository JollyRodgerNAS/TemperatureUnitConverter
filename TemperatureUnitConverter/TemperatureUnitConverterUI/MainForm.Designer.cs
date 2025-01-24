namespace TemperatureUnitConverterUI
{
    partial class MainForm
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
            button1 = new Button();
            fahrenheitListBox = new ListBox();
            celsiusListBox = new ListBox();
            kelvinListBox = new ListBox();
            fahrenheitLabel = new Label();
            celsiusLabel = new Label();
            kelvinLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(705, 405);
            button1.Name = "button1";
            button1.Size = new Size(67, 33);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fahrenheitListBox
            // 
            fahrenheitListBox.FormattingEnabled = true;
            fahrenheitListBox.ItemHeight = 15;
            fahrenheitListBox.Location = new Point(12, 80);
            fahrenheitListBox.Name = "fahrenheitListBox";
            fahrenheitListBox.Size = new Size(228, 289);
            fahrenheitListBox.TabIndex = 1;
            // 
            // celsiusListBox
            // 
            celsiusListBox.FormattingEnabled = true;
            celsiusListBox.ItemHeight = 15;
            celsiusListBox.Location = new Point(293, 80);
            celsiusListBox.Name = "celsiusListBox";
            celsiusListBox.Size = new Size(228, 289);
            celsiusListBox.TabIndex = 2;
            // 
            // kelvinListBox
            // 
            kelvinListBox.FormattingEnabled = true;
            kelvinListBox.ItemHeight = 15;
            kelvinListBox.Location = new Point(560, 80);
            kelvinListBox.Name = "kelvinListBox";
            kelvinListBox.Size = new Size(228, 289);
            kelvinListBox.TabIndex = 3;
            // 
            // fahrenheitLabel
            // 
            fahrenheitLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fahrenheitLabel.Location = new Point(28, 14);
            fahrenheitLabel.Name = "fahrenheitLabel";
            fahrenheitLabel.Size = new Size(196, 46);
            fahrenheitLabel.TabIndex = 4;
            fahrenheitLabel.Text = "Fahrenheit";
            fahrenheitLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // celsiusLabel
            // 
            celsiusLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            celsiusLabel.Location = new Point(302, 14);
            celsiusLabel.Name = "celsiusLabel";
            celsiusLabel.Size = new Size(196, 46);
            celsiusLabel.TabIndex = 5;
            celsiusLabel.Text = "Celsius";
            celsiusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kelvinLabel
            // 
            kelvinLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kelvinLabel.Location = new Point(576, 14);
            kelvinLabel.Name = "kelvinLabel";
            kelvinLabel.Size = new Size(196, 46);
            kelvinLabel.TabIndex = 6;
            kelvinLabel.Text = "Kelvin";
            kelvinLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(kelvinLabel);
            Controls.Add(celsiusLabel);
            Controls.Add(fahrenheitLabel);
            Controls.Add(kelvinListBox);
            Controls.Add(celsiusListBox);
            Controls.Add(fahrenheitListBox);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox fahrenheitListBox;
        private ListBox celsiusListBox;
        private ListBox kelvinListBox;
        private Label fahrenheitLabel;
        private Label celsiusLabel;
        private Label kelvinLabel;
    }
}
