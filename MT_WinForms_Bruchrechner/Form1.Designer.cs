namespace MT_WinForms_Bruchrechner
{
    partial class Form1
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
            Plus = new Button();
            Minus = new Button();
            Zähler_2 = new TextBox();
            Nenner_1 = new TextBox();
            Zähler_1 = new TextBox();
            Nenner_2 = new TextBox();
            Mal = new Button();
            Divisor = new Button();
            Potenz = new Button();
            Wurzel = new Button();
            Zähler_End = new TextBox();
            Nenner_End = new TextBox();
            Exponent = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // Plus
            // 
            Plus.Location = new Point(391, 60);
            Plus.Name = "Plus";
            Plus.Size = new Size(75, 23);
            Plus.TabIndex = 2;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = true;
            Plus.Click += Plus_Click;
            // 
            // Minus
            // 
            Minus.Location = new Point(391, 89);
            Minus.Name = "Minus";
            Minus.Size = new Size(75, 23);
            Minus.TabIndex = 3;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += Minus_Click;
            // 
            // Zähler_2
            // 
            Zähler_2.Location = new Point(74, 59);
            Zähler_2.Name = "Zähler_2";
            Zähler_2.Size = new Size(100, 23);
            Zähler_2.TabIndex = 4;
            // 
            // Nenner_1
            // 
            Nenner_1.Location = new Point(74, 115);
            Nenner_1.Name = "Nenner_1";
            Nenner_1.Size = new Size(100, 23);
            Nenner_1.TabIndex = 5;
            // 
            // Zähler_1
            // 
            Zähler_1.Location = new Point(206, 61);
            Zähler_1.Name = "Zähler_1";
            Zähler_1.Size = new Size(100, 23);
            Zähler_1.TabIndex = 6;
            // 
            // Nenner_2
            // 
            Nenner_2.Location = new Point(206, 115);
            Nenner_2.Name = "Nenner_2";
            Nenner_2.Size = new Size(100, 23);
            Nenner_2.TabIndex = 7;
            // 
            // Mal
            // 
            Mal.Location = new Point(472, 60);
            Mal.Name = "Mal";
            Mal.Size = new Size(75, 23);
            Mal.TabIndex = 8;
            Mal.Text = "*";
            Mal.UseVisualStyleBackColor = true;
            Mal.Click += Mal_Click;
            // 
            // Divisor
            // 
            Divisor.Location = new Point(472, 89);
            Divisor.Name = "Divisor";
            Divisor.Size = new Size(75, 23);
            Divisor.TabIndex = 9;
            Divisor.Text = "/";
            Divisor.UseVisualStyleBackColor = true;
            Divisor.Click += Divisor_Click;
            // 
            // Potenz
            // 
            Potenz.Location = new Point(391, 163);
            Potenz.Name = "Potenz";
            Potenz.Size = new Size(75, 23);
            Potenz.TabIndex = 10;
            Potenz.Text = "^";
            Potenz.UseVisualStyleBackColor = true;
            Potenz.Click += Potenz_Click;
            // 
            // Wurzel
            // 
            Wurzel.Location = new Point(553, 89);
            Wurzel.Name = "Wurzel";
            Wurzel.Size = new Size(75, 23);
            Wurzel.TabIndex = 11;
            Wurzel.Text = "√";
            Wurzel.UseVisualStyleBackColor = true;
            Wurzel.Click += Wurzel_Click;
            // 
            // Zähler_End
            // 
            Zähler_End.Location = new Point(656, 61);
            Zähler_End.Name = "Zähler_End";
            Zähler_End.Size = new Size(100, 23);
            Zähler_End.TabIndex = 12;
            // 
            // Nenner_End
            // 
            Nenner_End.Location = new Point(656, 115);
            Nenner_End.Name = "Nenner_End";
            Nenner_End.Size = new Size(100, 23);
            Nenner_End.TabIndex = 13;
            // 
            // Exponent
            // 
            Exponent.Location = new Point(472, 163);
            Exponent.Name = "Exponent";
            Exponent.Size = new Size(100, 23);
            Exponent.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 41);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 15;
            label1.Text = "Zähler 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 41);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 16;
            label2.Text = "Zähler2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 97);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 17;
            label3.Text = "Nenner1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 97);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 18;
            label4.Text = "Nenner2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(472, 145);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 19;
            label5.Text = "Exponent";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(656, 43);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 20;
            label6.Text = "Zähler Ergebniss";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(656, 97);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 21;
            label7.Text = "Nenner Ergebniss";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Exponent);
            Controls.Add(Nenner_End);
            Controls.Add(Zähler_End);
            Controls.Add(Wurzel);
            Controls.Add(Potenz);
            Controls.Add(Divisor);
            Controls.Add(Mal);
            Controls.Add(Nenner_2);
            Controls.Add(Zähler_1);
            Controls.Add(Nenner_1);
            Controls.Add(Zähler_2);
            Controls.Add(Minus);
            Controls.Add(Plus);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Plus;
        private Button Minus;
        private TextBox Zähler_2;
        private TextBox Nenner_1;
        private TextBox Zähler_1;
        private TextBox Nenner_2;
        private Button Mal;
        private Button Divisor;
        private Button Potenz;
        private Button Wurzel;
        private TextBox Zähler_End;
        private TextBox Nenner_End;
        private TextBox Exponent;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
