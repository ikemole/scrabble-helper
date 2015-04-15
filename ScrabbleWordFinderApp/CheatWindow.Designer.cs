namespace ScrabbleWordFinderApp
{
    partial class CheatWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheatWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.userTilesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.findWordsButton = new System.Windows.Forms.Button();
            this.wordFilterPanel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.endsWithTextbox = new System.Windows.Forms.TextBox();
            this.containsTextbox = new System.Windows.Forms.TextBox();
            this.startsWithTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wordFiltersCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.clearButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resultsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.resultsTable = new System.Windows.Forms.DataGridView();
            this.separatorPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2.SuspendLayout();
            this.wordFilterPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.resultsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find Words Using Your Tiles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.userTilesTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 37);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(335, 50);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // userTilesTextBox
            // 
            this.userTilesTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.userTilesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userTilesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTilesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userTilesTextBox.Location = new System.Drawing.Point(103, 3);
            this.userTilesTextBox.Name = "userTilesTextBox";
            this.userTilesTextBox.Size = new System.Drawing.Size(229, 30);
            this.userTilesTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Tiles:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(103, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Note: You can use underscore as BLANK tile";
            // 
            // findWordsButton
            // 
            this.findWordsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findWordsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findWordsButton.Location = new System.Drawing.Point(66, 3);
            this.findWordsButton.Name = "findWordsButton";
            this.findWordsButton.Size = new System.Drawing.Size(259, 28);
            this.findWordsButton.TabIndex = 2;
            this.findWordsButton.Text = "Find Words";
            this.findWordsButton.UseVisualStyleBackColor = true;
            this.findWordsButton.Click += new System.EventHandler(this.findWordsButton_Click);
            // 
            // wordFilterPanel
            // 
            this.wordFilterPanel.Controls.Add(this.tableLayoutPanel3);
            this.wordFilterPanel.Enabled = false;
            this.wordFilterPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordFilterPanel.Location = new System.Drawing.Point(3, 130);
            this.wordFilterPanel.Name = "wordFilterPanel";
            this.wordFilterPanel.Size = new System.Drawing.Size(224, 104);
            this.wordFilterPanel.TabIndex = 3;
            this.wordFilterPanel.TabStop = false;
            this.wordFilterPanel.Text = "Word Filters";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.endsWithTextbox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.containsTextbox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.startsWithTextbox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(218, 84);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ends With";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contains";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // endsWithTextbox
            // 
            this.endsWithTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.endsWithTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endsWithTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endsWithTextbox.Location = new System.Drawing.Point(112, 59);
            this.endsWithTextbox.Name = "endsWithTextbox";
            this.endsWithTextbox.Size = new System.Drawing.Size(103, 23);
            this.endsWithTextbox.TabIndex = 6;
            // 
            // containsTextbox
            // 
            this.containsTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.containsTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containsTextbox.Location = new System.Drawing.Point(112, 31);
            this.containsTextbox.Name = "containsTextbox";
            this.containsTextbox.Size = new System.Drawing.Size(103, 23);
            this.containsTextbox.TabIndex = 5;
            // 
            // startsWithTextbox
            // 
            this.startsWithTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.startsWithTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startsWithTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startsWithTextbox.Location = new System.Drawing.Point(112, 3);
            this.startsWithTextbox.Name = "startsWithTextbox";
            this.startsWithTextbox.Size = new System.Drawing.Size(103, 23);
            this.startsWithTextbox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Starts With";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wordFiltersCheckBox
            // 
            this.wordFiltersCheckBox.AutoSize = true;
            this.wordFiltersCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordFiltersCheckBox.Location = new System.Drawing.Point(3, 103);
            this.wordFiltersCheckBox.Name = "wordFiltersCheckBox";
            this.wordFiltersCheckBox.Size = new System.Drawing.Size(132, 21);
            this.wordFiltersCheckBox.TabIndex = 4;
            this.wordFiltersCheckBox.Text = "Use Word Filters";
            this.wordFiltersCheckBox.UseVisualStyleBackColor = true;
            this.wordFiltersCheckBox.CheckedChanged += new System.EventHandler(this.wordFiltersCheckBox_CheckedChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.28783F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.71217F));
            this.tableLayoutPanel4.Controls.Add(this.findWordsButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.clearButton, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 276);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(328, 34);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // clearButton
            // 
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.Location = new System.Drawing.Point(3, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(57, 28);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(335, 28);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // resultsPanel
            // 
            this.resultsPanel.ColumnCount = 2;
            this.resultsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.057971F));
            this.resultsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.94203F));
            this.resultsPanel.Controls.Add(this.resultsLabel, 1, 0);
            this.resultsPanel.Controls.Add(this.resultsTable, 1, 1);
            this.resultsPanel.Controls.Add(this.separatorPanel, 0, 0);
            this.resultsPanel.Location = new System.Drawing.Point(344, 3);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.RowCount = 2;
            this.resultsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.resultsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 279F));
            this.resultsPanel.Size = new System.Drawing.Size(342, 307);
            this.resultsPanel.TabIndex = 9;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.BackColor = System.Drawing.Color.Gray;
            this.resultsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsLabel.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.resultsLabel.ForeColor = System.Drawing.Color.White;
            this.resultsLabel.Location = new System.Drawing.Point(16, 0);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(323, 28);
            this.resultsLabel.TabIndex = 2;
            this.resultsLabel.Text = "RESULTS";
            this.resultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultsTable
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.resultsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsTable.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultsTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.resultsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsTable.Location = new System.Drawing.Point(16, 31);
            this.resultsTable.Name = "resultsTable";
            this.resultsTable.ReadOnly = true;
            this.resultsTable.RowHeadersVisible = false;
            this.resultsTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.resultsTable.Size = new System.Drawing.Size(323, 273);
            this.resultsTable.TabIndex = 6;
            // 
            // separatorPanel
            // 
            this.separatorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.separatorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separatorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.separatorPanel.Enabled = false;
            this.separatorPanel.Location = new System.Drawing.Point(3, 3);
            this.separatorPanel.Name = "separatorPanel";
            this.resultsPanel.SetRowSpan(this.separatorPanel, 2);
            this.separatorPanel.Size = new System.Drawing.Size(5, 301);
            this.separatorPanel.TabIndex = 7;
            // 
            // CheatWindow
            // 
            this.AcceptButton = this.findWordsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(689, 316);
            this.Controls.Add(this.wordFilterPanel);
            this.Controls.Add(this.resultsPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.wordFiltersCheckBox);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CheatWindow";
            this.Text = "Cheat - The Scrambler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.hide_form_on_closing);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.wordFilterPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.resultsPanel.ResumeLayout(false);
            this.resultsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox userTilesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button findWordsButton;
        private System.Windows.Forms.GroupBox wordFilterPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox startsWithTextbox;
        private System.Windows.Forms.CheckBox wordFiltersCheckBox;
        private System.Windows.Forms.TextBox endsWithTextbox;
        private System.Windows.Forms.TextBox containsTextbox;
        private System.Windows.Forms.DataGridView resultsTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.TableLayoutPanel resultsPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel separatorPanel;
    }
}