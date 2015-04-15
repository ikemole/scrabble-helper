namespace ScrabbleWordFinderApp
{
    partial class HomeWindow
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
            if (disposing && ( components != null ))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.launchCheatWindowBtn = new System.Windows.Forms.Button();
            this.launchContestWindowBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // launchCheatWindowBtn
            // 
            this.launchCheatWindowBtn.BackColor = System.Drawing.Color.White;
            this.launchCheatWindowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.launchCheatWindowBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.launchCheatWindowBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchCheatWindowBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.launchCheatWindowBtn.Location = new System.Drawing.Point(178, 3);
            this.launchCheatWindowBtn.Name = "launchCheatWindowBtn";
            this.launchCheatWindowBtn.Size = new System.Drawing.Size(170, 109);
            this.launchCheatWindowBtn.TabIndex = 0;
            this.launchCheatWindowBtn.TabStop = false;
            this.launchCheatWindowBtn.Text = "CHEAT";
            this.launchCheatWindowBtn.UseVisualStyleBackColor = false;
            this.launchCheatWindowBtn.Click += new System.EventHandler(this.launchCheatWindowBtn_Click);
            // 
            // launchContestWindowBtn
            // 
            this.launchContestWindowBtn.BackColor = System.Drawing.Color.White;
            this.launchContestWindowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.launchContestWindowBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.launchContestWindowBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchContestWindowBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.launchContestWindowBtn.Location = new System.Drawing.Point(3, 3);
            this.launchContestWindowBtn.Name = "launchContestWindowBtn";
            this.launchContestWindowBtn.Size = new System.Drawing.Size(169, 109);
            this.launchContestWindowBtn.TabIndex = 0;
            this.launchContestWindowBtn.TabStop = false;
            this.launchContestWindowBtn.Text = "CONTEST";
            this.launchContestWindowBtn.UseVisualStyleBackColor = false;
            this.launchContestWindowBtn.Click += new System.EventHandler(this.launchContestWindowBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.launchCheatWindowBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.launchContestWindowBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 140);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(351, 115);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(351, 257);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Scrambler - A Scrabble Word Finder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button launchCheatWindowBtn;
        private System.Windows.Forms.Button launchContestWindowBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

