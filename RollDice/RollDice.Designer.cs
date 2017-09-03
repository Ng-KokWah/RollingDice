namespace RollDice
{
    partial class RollDice
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.dicetwo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(97, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 263);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(24, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 30);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(238, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 30);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(24, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 30);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(238, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 30);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(24, 201);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 30);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(238, 201);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 30);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(133, 113);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(31, 30);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Black;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(159, 357);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(164, 81);
            this.start.TabIndex = 1;
            this.start.Text = "Roll";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // dicetwo
            // 
            this.dicetwo.BackColor = System.Drawing.Color.Black;
            this.dicetwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dicetwo.ForeColor = System.Drawing.Color.White;
            this.dicetwo.Location = new System.Drawing.Point(329, 456);
            this.dicetwo.Name = "dicetwo";
            this.dicetwo.Size = new System.Drawing.Size(153, 64);
            this.dicetwo.TabIndex = 2;
            this.dicetwo.Text = "Second Dice";
            this.dicetwo.UseVisualStyleBackColor = false;
            this.dicetwo.Click += new System.EventHandler(this.dicetwo_Click);
            // 
            // RollDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(494, 532);
            this.Controls.Add(this.dicetwo);
            this.Controls.Add(this.start);
            this.Controls.Add(this.panel1);
            this.Name = "RollDice";
            this.Text = "Roll Dice";
            this.Load += new System.EventHandler(this.RollDice_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button dicetwo;
    }
}

