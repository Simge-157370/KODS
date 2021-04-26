
namespace Rock_Paper_Scissors
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
            this.Player_A = new System.Windows.Forms.PictureBox();
            this.Player_B = new System.Windows.Forms.PictureBox();
            this.Rock = new System.Windows.Forms.PictureBox();
            this.Paper = new System.Windows.Forms.PictureBox();
            this.Scissors = new System.Windows.Forms.PictureBox();
            this.Play_Button = new System.Windows.Forms.Button();
            this.PlayerALabel = new System.Windows.Forms.Label();
            this.PlayerBLabel = new System.Windows.Forms.Label();
            this.ScoreTableA = new System.Windows.Forms.Label();
            this.ScoreTableB = new System.Windows.Forms.Label();
            this.ScoreA = new System.Windows.Forms.Label();
            this.ScoreB = new System.Windows.Forms.Label();
            this.WinnerTable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quits_number = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).BeginInit();
            this.SuspendLayout();
            // 
            // Player_A
            // 
            this.Player_A.ErrorImage = null;
            this.Player_A.Location = new System.Drawing.Point(30, 62);
            this.Player_A.Name = "Player_A";
            this.Player_A.Size = new System.Drawing.Size(220, 220);
            this.Player_A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player_A.TabIndex = 0;
            this.Player_A.TabStop = false;
            this.Player_A.Click += new System.EventHandler(this.Player_A_Click);
            // 
            // Player_B
            // 
            this.Player_B.Location = new System.Drawing.Point(662, 62);
            this.Player_B.Name = "Player_B";
            this.Player_B.Size = new System.Drawing.Size(220, 220);
            this.Player_B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player_B.TabIndex = 2;
            this.Player_B.TabStop = false;
            this.Player_B.Click += new System.EventHandler(this.Player_B_Click);
            // 
            // Rock
            // 
            this.Rock.Image = global::Rock_Paper_Scissors.Properties.Resources.rock_png;
            this.Rock.Location = new System.Drawing.Point(30, 303);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(65, 65);
            this.Rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rock.TabIndex = 3;
            this.Rock.TabStop = false;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // Paper
            // 
            this.Paper.Image = global::Rock_Paper_Scissors.Properties.Resources.paper_png;
            this.Paper.Location = new System.Drawing.Point(101, 303);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(65, 65);
            this.Paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Paper.TabIndex = 5;
            this.Paper.TabStop = false;
            this.Paper.Click += new System.EventHandler(this.Paper_Click);
            // 
            // Scissors
            // 
            this.Scissors.Image = global::Rock_Paper_Scissors.Properties.Resources.scissors_png;
            this.Scissors.Location = new System.Drawing.Point(172, 303);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(65, 65);
            this.Scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Scissors.TabIndex = 6;
            this.Scissors.TabStop = false;
            this.Scissors.Click += new System.EventHandler(this.Scissors_Click);
            // 
            // Play_Button
            // 
            this.Play_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Play_Button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Play_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Play_Button.Location = new System.Drawing.Point(698, 308);
            this.Play_Button.Name = "Play_Button";
            this.Play_Button.Size = new System.Drawing.Size(150, 60);
            this.Play_Button.TabIndex = 7;
            this.Play_Button.Text = "PLAY";
            this.Play_Button.UseVisualStyleBackColor = false;
            this.Play_Button.Click += new System.EventHandler(this.Play_Button_Click);
            // 
            // PlayerALabel
            // 
            this.PlayerALabel.AutoSize = true;
            this.PlayerALabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayerALabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PlayerALabel.Location = new System.Drawing.Point(55, 22);
            this.PlayerALabel.Name = "PlayerALabel";
            this.PlayerALabel.Size = new System.Drawing.Size(97, 29);
            this.PlayerALabel.TabIndex = 8;
            this.PlayerALabel.Text = "PlayerA";
            // 
            // PlayerBLabel
            // 
            this.PlayerBLabel.AutoSize = true;
            this.PlayerBLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayerBLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PlayerBLabel.Location = new System.Drawing.Point(687, 22);
            this.PlayerBLabel.Name = "PlayerBLabel";
            this.PlayerBLabel.Size = new System.Drawing.Size(95, 29);
            this.PlayerBLabel.TabIndex = 9;
            this.PlayerBLabel.Text = "PlayerB";
            // 
            // ScoreTableA
            // 
            this.ScoreTableA.AutoSize = true;
            this.ScoreTableA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ScoreTableA.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreTableA.ForeColor = System.Drawing.Color.White;
            this.ScoreTableA.Location = new System.Drawing.Point(271, 81);
            this.ScoreTableA.Name = "ScoreTableA";
            this.ScoreTableA.Size = new System.Drawing.Size(119, 29);
            this.ScoreTableA.TabIndex = 10;
            this.ScoreTableA.Text = "ScoreOfA";
            // 
            // ScoreTableB
            // 
            this.ScoreTableB.AutoSize = true;
            this.ScoreTableB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ScoreTableB.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreTableB.ForeColor = System.Drawing.Color.White;
            this.ScoreTableB.Location = new System.Drawing.Point(515, 81);
            this.ScoreTableB.Name = "ScoreTableB";
            this.ScoreTableB.Size = new System.Drawing.Size(117, 29);
            this.ScoreTableB.TabIndex = 11;
            this.ScoreTableB.Text = "ScoreOfB";
            // 
            // ScoreA
            // 
            this.ScoreA.AutoSize = true;
            this.ScoreA.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ScoreA.Location = new System.Drawing.Point(311, 140);
            this.ScoreA.Name = "ScoreA";
            this.ScoreA.Size = new System.Drawing.Size(27, 29);
            this.ScoreA.TabIndex = 12;
            this.ScoreA.Text = "0";
            this.ScoreA.Click += new System.EventHandler(this.ScoreA_Click);
            // 
            // ScoreB
            // 
            this.ScoreB.AutoSize = true;
            this.ScoreB.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ScoreB.Location = new System.Drawing.Point(554, 140);
            this.ScoreB.Name = "ScoreB";
            this.ScoreB.Size = new System.Drawing.Size(27, 29);
            this.ScoreB.TabIndex = 13;
            this.ScoreB.Text = "0";
            // 
            // WinnerTable
            // 
            this.WinnerTable.AutoSize = true;
            this.WinnerTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.WinnerTable.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WinnerTable.ForeColor = System.Drawing.Color.Red;
            this.WinnerTable.Location = new System.Drawing.Point(370, 232);
            this.WinnerTable.MaximumSize = new System.Drawing.Size(170, 50);
            this.WinnerTable.MinimumSize = new System.Drawing.Size(170, 50);
            this.WinnerTable.Name = "WinnerTable";
            this.WinnerTable.Size = new System.Drawing.Size(170, 50);
            this.WinnerTable.TabIndex = 14;
            this.WinnerTable.Text = "WİNNER";
            this.WinnerTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WinnerTable.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(370, 282);
            this.label2.MaximumSize = new System.Drawing.Size(170, 50);
            this.label2.MinimumSize = new System.Drawing.Size(170, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 50);
            this.label2.TabIndex = 15;
            this.label2.Text = "Quits";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // quits_number
            // 
            this.quits_number.AutoSize = true;
            this.quits_number.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quits_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.quits_number.Location = new System.Drawing.Point(442, 418);
            this.quits_number.Name = "quits_number";
            this.quits_number.Size = new System.Drawing.Size(27, 29);
            this.quits_number.TabIndex = 17;
            this.quits_number.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(380, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "quitsNumber";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quits_number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WinnerTable);
            this.Controls.Add(this.ScoreB);
            this.Controls.Add(this.ScoreA);
            this.Controls.Add(this.ScoreTableB);
            this.Controls.Add(this.ScoreTableA);
            this.Controls.Add(this.PlayerBLabel);
            this.Controls.Add(this.PlayerALabel);
            this.Controls.Add(this.Play_Button);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Controls.Add(this.Player_B);
            this.Controls.Add(this.Player_A);
            this.Name = "Form1";
            this.Text = "Score_Of_A";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player_A;
        private System.Windows.Forms.PictureBox Player_B;
        private System.Windows.Forms.PictureBox Rock;
        private System.Windows.Forms.PictureBox Paper;
        private System.Windows.Forms.PictureBox Scissors;
        private System.Windows.Forms.Button Play_Button;
        private System.Windows.Forms.Label PlayerALabel;
        private System.Windows.Forms.Label PlayerBLabel;
        private System.Windows.Forms.Label ScoreTableA;
        private System.Windows.Forms.Label ScoreTableB;
        private System.Windows.Forms.Label ScoreA;
        private System.Windows.Forms.Label ScoreB;
        private System.Windows.Forms.Label WinnerTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quits_number;
    }
}

