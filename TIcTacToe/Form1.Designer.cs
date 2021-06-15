
namespace TIcTacToe
{
    partial class Form1
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
            this.b01 = new System.Windows.Forms.Button();
            this.b02 = new System.Windows.Forms.Button();
            this.b12 = new System.Windows.Forms.Button();
            this.b11 = new System.Windows.Forms.Button();
            this.b10 = new System.Windows.Forms.Button();
            this.b22 = new System.Windows.Forms.Button();
            this.b21 = new System.Windows.Forms.Button();
            this.b20 = new System.Windows.Forms.Button();
            this.b00 = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.tX = new System.Windows.Forms.TextBox();
            this.tO = new System.Windows.Forms.TextBox();
            this.O = new System.Windows.Forms.Button();
            this.state = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Button();
            this.MessageBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b01
            // 
            this.b01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(161)))), ((int)(((byte)(146)))));
            this.b01.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.b01.Location = new System.Drawing.Point(360, 128);
            this.b01.Name = "b01";
            this.b01.Size = new System.Drawing.Size(80, 80);
            this.b01.TabIndex = 1;
            this.b01.UseVisualStyleBackColor = false;
            this.b01.Click += new System.EventHandler(this.Button_Click);
            // 
            // b02
            // 
            this.b02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(161)))), ((int)(((byte)(146)))));
            this.b02.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.b02.Location = new System.Drawing.Point(446, 128);
            this.b02.Name = "b02";
            this.b02.Size = new System.Drawing.Size(80, 80);
            this.b02.TabIndex = 2;
            this.b02.UseVisualStyleBackColor = false;
            this.b02.Click += new System.EventHandler(this.Button_Click);
            // 
            // b12
            // 
            this.b12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(161)))), ((int)(((byte)(146)))));
            this.b12.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.b12.Location = new System.Drawing.Point(446, 214);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(80, 80);
            this.b12.TabIndex = 5;
            this.b12.UseVisualStyleBackColor = false;
            this.b12.Click += new System.EventHandler(this.Button_Click);
            // 
            // b11
            // 
            this.b11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(161)))), ((int)(((byte)(146)))));
            this.b11.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.b11.Location = new System.Drawing.Point(360, 214);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(80, 80);
            this.b11.TabIndex = 4;
            this.b11.UseVisualStyleBackColor = false;
            this.b11.Click += new System.EventHandler(this.Button_Click);
            // 
            // b10
            // 
            this.b10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(161)))), ((int)(((byte)(146)))));
            this.b10.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.b10.Location = new System.Drawing.Point(274, 214);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(80, 80);
            this.b10.TabIndex = 3;
            this.b10.UseVisualStyleBackColor = false;
            this.b10.Click += new System.EventHandler(this.Button_Click);
            // 
            // b22
            // 
            this.b22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(161)))), ((int)(((byte)(146)))));
            this.b22.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.b22.Location = new System.Drawing.Point(446, 300);
            this.b22.Name = "b22";
            this.b22.Size = new System.Drawing.Size(80, 80);
            this.b22.TabIndex = 8;
            this.b22.UseVisualStyleBackColor = false;
            this.b22.Click += new System.EventHandler(this.Button_Click);
            // 
            // b21
            // 
            this.b21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(161)))), ((int)(((byte)(146)))));
            this.b21.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.b21.Location = new System.Drawing.Point(360, 300);
            this.b21.Name = "b21";
            this.b21.Size = new System.Drawing.Size(80, 80);
            this.b21.TabIndex = 7;
            this.b21.UseVisualStyleBackColor = false;
            this.b21.Click += new System.EventHandler(this.Button_Click);
            // 
            // b20
            // 
            this.b20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(161)))), ((int)(((byte)(146)))));
            this.b20.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.b20.Location = new System.Drawing.Point(274, 300);
            this.b20.Name = "b20";
            this.b20.Size = new System.Drawing.Size(80, 80);
            this.b20.TabIndex = 6;
            this.b20.UseVisualStyleBackColor = false;
            this.b20.Click += new System.EventHandler(this.Button_Click);
            // 
            // b00
            // 
            this.b00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(161)))), ((int)(((byte)(146)))));
            this.b00.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b00.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.b00.Location = new System.Drawing.Point(274, 128);
            this.b00.Name = "b00";
            this.b00.Size = new System.Drawing.Size(80, 80);
            this.b00.TabIndex = 9;
            this.b00.UseVisualStyleBackColor = false;
            this.b00.Click += new System.EventHandler(this.Button_Click);
            // 
            // Restart
            // 
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(189)))), ((int)(((byte)(172)))));
            this.Restart.Location = new System.Drawing.Point(-9, 420);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(816, 56);
            this.Restart.TabIndex = 11;
            this.Restart.Text = "RESTART GAME";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // tX
            // 
            this.tX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tX.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tX.Enabled = false;
            this.tX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tX.Location = new System.Drawing.Point(214, 45);
            this.tX.Name = "tX";
            this.tX.ReadOnly = true;
            this.tX.Size = new System.Drawing.Size(28, 22);
            this.tX.TabIndex = 13;
            this.tX.Text = "X";
            this.tX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tO
            // 
            this.tO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tO.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tO.Enabled = false;
            this.tO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tO.Location = new System.Drawing.Point(457, 45);
            this.tO.Name = "tO";
            this.tO.ReadOnly = true;
            this.tO.Size = new System.Drawing.Size(28, 22);
            this.tO.TabIndex = 15;
            this.tO.Text = "O";
            this.tO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // O
            // 
            this.O.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.O.Cursor = System.Windows.Forms.Cursors.Hand;
            this.O.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.O.Location = new System.Drawing.Point(446, 38);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(151, 40);
            this.O.TabIndex = 14;
            this.O.Text = "- ";
            this.O.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.O.UseVisualStyleBackColor = false;
            this.O.Click += new System.EventHandler(this.O_Click);
            // 
            // state
            // 
            this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(189)))), ((int)(((byte)(172)))));
            this.state.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.state.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.state.Location = new System.Drawing.Point(347, 93);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(113, 15);
            this.state.TabIndex = 16;
            this.state.Text = "Click to start";
            this.state.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.X.Location = new System.Drawing.Point(203, 38);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(151, 40);
            this.X.TabIndex = 12;
            this.X.Text = "- ";
            this.X.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // MessageBox
            // 
            this.MessageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(189)))), ((int)(((byte)(172)))));
            this.MessageBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MessageBox.Enabled = false;
            this.MessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.MessageBox.Location = new System.Drawing.Point(0, -1);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(10, 10);
            this.MessageBox.TabIndex = 17;
            this.MessageBox.UseVisualStyleBackColor = false;
            this.MessageBox.Visible = false;
            this.MessageBox.Click += new System.EventHandler(this.MessageBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(189)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.state);
            this.Controls.Add(this.tO);
            this.Controls.Add(this.O);
            this.Controls.Add(this.tX);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.b00);
            this.Controls.Add(this.b22);
            this.Controls.Add(this.b21);
            this.Controls.Add(this.b20);
            this.Controls.Add(this.b12);
            this.Controls.Add(this.b11);
            this.Controls.Add(this.b10);
            this.Controls.Add(this.b02);
            this.Controls.Add(this.b01);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b01;
        private System.Windows.Forms.Button b02;
        private System.Windows.Forms.Button b12;
        private System.Windows.Forms.Button b11;
        private System.Windows.Forms.Button b10;
        private System.Windows.Forms.Button b22;
        private System.Windows.Forms.Button b21;
        private System.Windows.Forms.Button b20;
        private System.Windows.Forms.Button b00;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.TextBox tX;
        private System.Windows.Forms.TextBox tO;
        private System.Windows.Forms.Button O;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button MessageBox;
    }
}

