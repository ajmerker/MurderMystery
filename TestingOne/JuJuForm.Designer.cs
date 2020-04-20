namespace MurderMystery
{
    partial class JuJuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuJuForm));
            this.BTN_Play_Click = new System.Windows.Forms.Button();
            this.LB_Char1 = new System.Windows.Forms.Label();
            this.TB_charToGuess = new System.Windows.Forms.TextBox();
            this.LB_LifeValue = new System.Windows.Forms.Label();
            this.TB_MissedWords = new System.Windows.Forms.TextBox();
            this.LB_Char5 = new System.Windows.Forms.Label();
            this.LB_Char4 = new System.Windows.Forms.Label();
            this.LB_Char3 = new System.Windows.Forms.Label();
            this.LB_Char2 = new System.Windows.Forms.Label();
            this.LB_Char6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Play_Click
            // 
            this.BTN_Play_Click.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Play_Click.Location = new System.Drawing.Point(485, 355);
            this.BTN_Play_Click.Name = "BTN_Play_Click";
            this.BTN_Play_Click.Size = new System.Drawing.Size(94, 44);
            this.BTN_Play_Click.TabIndex = 0;
            this.BTN_Play_Click.Text = "Play";
            this.BTN_Play_Click.UseVisualStyleBackColor = true;
            this.BTN_Play_Click.Click += new System.EventHandler(this.BTN_Play_Click_Click);
            // 
            // LB_Char1
            // 
            this.LB_Char1.AutoSize = true;
            this.LB_Char1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Char1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LB_Char1.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Char1.Location = new System.Drawing.Point(76, 188);
            this.LB_Char1.Name = "LB_Char1";
            this.LB_Char1.Size = new System.Drawing.Size(24, 29);
            this.LB_Char1.TabIndex = 2;
            this.LB_Char1.Text = "*";
            this.LB_Char1.Click += new System.EventHandler(this.LB_Char1_Click);
            // 
            // TB_charToGuess
            // 
            this.TB_charToGuess.Location = new System.Drawing.Point(181, 379);
            this.TB_charToGuess.Name = "TB_charToGuess";
            this.TB_charToGuess.Size = new System.Drawing.Size(100, 20);
            this.TB_charToGuess.TabIndex = 3;
            // 
            // LB_LifeValue
            // 
            this.LB_LifeValue.AutoSize = true;
            this.LB_LifeValue.BackColor = System.Drawing.Color.LightCoral;
            this.LB_LifeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LifeValue.Location = new System.Drawing.Point(83, 344);
            this.LB_LifeValue.Name = "LB_LifeValue";
            this.LB_LifeValue.Size = new System.Drawing.Size(38, 31);
            this.LB_LifeValue.TabIndex = 4;
            this.LB_LifeValue.Text = "   ";
            // 
            // TB_MissedWords
            // 
            this.TB_MissedWords.Location = new System.Drawing.Point(440, 63);
            this.TB_MissedWords.Name = "TB_MissedWords";
            this.TB_MissedWords.Size = new System.Drawing.Size(339, 20);
            this.TB_MissedWords.TabIndex = 5;
            this.TB_MissedWords.Text = resources.GetString("TB_MissedWords.Text");
            // 
            // LB_Char5
            // 
            this.LB_Char5.AutoSize = true;
            this.LB_Char5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LB_Char5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LB_Char5.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Char5.Location = new System.Drawing.Point(529, 188);
            this.LB_Char5.Name = "LB_Char5";
            this.LB_Char5.Size = new System.Drawing.Size(24, 29);
            this.LB_Char5.TabIndex = 6;
            this.LB_Char5.Text = "*";
            // 
            // LB_Char4
            // 
            this.LB_Char4.AutoSize = true;
            this.LB_Char4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LB_Char4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LB_Char4.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Char4.Location = new System.Drawing.Point(414, 188);
            this.LB_Char4.Name = "LB_Char4";
            this.LB_Char4.Size = new System.Drawing.Size(24, 29);
            this.LB_Char4.TabIndex = 7;
            this.LB_Char4.Text = "*";
            // 
            // LB_Char3
            // 
            this.LB_Char3.AutoSize = true;
            this.LB_Char3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LB_Char3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LB_Char3.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Char3.Location = new System.Drawing.Point(297, 188);
            this.LB_Char3.Name = "LB_Char3";
            this.LB_Char3.Size = new System.Drawing.Size(24, 29);
            this.LB_Char3.TabIndex = 8;
            this.LB_Char3.Text = "*";
            // 
            // LB_Char2
            // 
            this.LB_Char2.AutoSize = true;
            this.LB_Char2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Char2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LB_Char2.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Char2.Location = new System.Drawing.Point(185, 188);
            this.LB_Char2.Name = "LB_Char2";
            this.LB_Char2.Size = new System.Drawing.Size(24, 29);
            this.LB_Char2.TabIndex = 9;
            this.LB_Char2.Text = "*";
            // 
            // LB_Char6
            // 
            this.LB_Char6.AutoSize = true;
            this.LB_Char6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LB_Char6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LB_Char6.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Char6.Location = new System.Drawing.Point(650, 185);
            this.LB_Char6.Name = "LB_Char6";
            this.LB_Char6.Size = new System.Drawing.Size(20, 36);
            this.LB_Char6.TabIndex = 10;
            this.LB_Char6.Text = "*";
            this.LB_Char6.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tries left:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "incorrect letters you have guessed: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(617, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(297, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 54);
            this.button2.TabIndex = 14;
            this.button2.Text = "Guess a letter!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // JuJuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(809, 445);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Char6);
            this.Controls.Add(this.LB_Char2);
            this.Controls.Add(this.LB_Char3);
            this.Controls.Add(this.LB_Char4);
            this.Controls.Add(this.LB_Char5);
            this.Controls.Add(this.TB_MissedWords);
            this.Controls.Add(this.LB_LifeValue);
            this.Controls.Add(this.TB_charToGuess);
            this.Controls.Add(this.LB_Char1);
            this.Controls.Add(this.BTN_Play_Click);
            this.Name = "JuJuForm";
            this.Text = "JuJuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Play_Click;
       // private System.Windows.Forms.Button BTN_Guess_Click;
        private System.Windows.Forms.Label LB_Char1;
        private System.Windows.Forms.TextBox TB_charToGuess;
        private System.Windows.Forms.Label LB_LifeValue;
        private System.Windows.Forms.TextBox TB_MissedWords;
        private System.Windows.Forms.Label LB_Char5;
        private System.Windows.Forms.Label LB_Char4;
        private System.Windows.Forms.Label LB_Char3;
        private System.Windows.Forms.Label LB_Char2;
        private System.Windows.Forms.Label LB_Char6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}