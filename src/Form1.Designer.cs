namespace rtext
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.replaceWithDataGridView = new System.Windows.Forms.DataGridView();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.replaceButton = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.findWhatDataGridView = new System.Windows.Forms.DataGridView();
            this.findButton = new System.Windows.Forms.Button();
            this.findWhatTextBox = new System.Windows.Forms.TextBox();
            this.replaceWithTextBox = new System.Windows.Forms.TextBox();
            this.colHistoryDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHistoryFind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHistoryReplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFindWhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReplaceWith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.replaceWithDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findWhatDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // replaceWithDataGridView
            // 
            this.replaceWithDataGridView.AllowUserToAddRows = false;
            this.replaceWithDataGridView.AllowUserToResizeRows = false;
            this.replaceWithDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.replaceWithDataGridView.ColumnHeadersVisible = false;
            this.replaceWithDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReplaceWith});
            this.replaceWithDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replaceWithDataGridView.Location = new System.Drawing.Point(232, 0);
            this.replaceWithDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.replaceWithDataGridView.MultiSelect = false;
            this.replaceWithDataGridView.Name = "replaceWithDataGridView";
            this.replaceWithDataGridView.RowHeadersVisible = false;
            this.replaceWithDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.replaceWithDataGridView.Size = new System.Drawing.Size(228, 118);
            this.replaceWithDataGridView.TabIndex = 4;
            this.replaceWithDataGridView.SelectionChanged += new System.EventHandler(this.replaceWithDataGridView_SelectionChanged);
            this.replaceWithDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.replaceWithDataGridView_UserDeletingRow);
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.AllowUserToAddRows = false;
            this.historyDataGridView.AllowUserToResizeRows = false;
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHistoryDt,
            this.colHistoryFind,
            this.colHistoryReplace});
            this.historyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyDataGridView.Location = new System.Drawing.Point(0, 0);
            this.historyDataGridView.MultiSelect = false;
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.RowHeadersVisible = false;
            this.historyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historyDataGridView.Size = new System.Drawing.Size(460, 144);
            this.historyDataGridView.TabIndex = 5;
            this.historyDataGridView.SelectionChanged += new System.EventHandler(this.historyDataGridView_SelectionChanged);
            this.historyDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.historyDataGridView_UserDeletingRow);
            // 
            // replaceButton
            // 
            this.replaceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.replaceButton.Enabled = false;
            this.replaceButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.replaceButton.Location = new System.Drawing.Point(232, 145);
            this.replaceButton.Margin = new System.Windows.Forms.Padding(0);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(228, 25);
            this.replaceButton.TabIndex = 0;
            this.replaceButton.Text = "Заменить";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(2, 2);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.historyDataGridView);
            this.splitContainer.Size = new System.Drawing.Size(460, 318);
            this.splitContainer.SplitterDistance = 170;
            this.splitContainer.TabIndex = 4;
            this.splitContainer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.splitContainer_MouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.replaceButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.replaceWithDataGridView, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.findWhatDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.findButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.findWhatTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.replaceWithTextBox, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 170);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // findWhatDataGridView
            // 
            this.findWhatDataGridView.AllowUserToAddRows = false;
            this.findWhatDataGridView.AllowUserToResizeRows = false;
            this.findWhatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.findWhatDataGridView.ColumnHeadersVisible = false;
            this.findWhatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFindWhat});
            this.findWhatDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findWhatDataGridView.Location = new System.Drawing.Point(0, 0);
            this.findWhatDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.findWhatDataGridView.MultiSelect = false;
            this.findWhatDataGridView.Name = "findWhatDataGridView";
            this.findWhatDataGridView.RowHeadersVisible = false;
            this.findWhatDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.findWhatDataGridView.Size = new System.Drawing.Size(228, 118);
            this.findWhatDataGridView.TabIndex = 3;
            this.findWhatDataGridView.SelectionChanged += new System.EventHandler(this.findWhatDataGridView_SelectionChanged);
            this.findWhatDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.findWhatDataGridView_UserDeletingRow);
            // 
            // findButton
            // 
            this.findButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.findButton.Enabled = false;
            this.findButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.findButton.Location = new System.Drawing.Point(0, 145);
            this.findButton.Margin = new System.Windows.Forms.Padding(0);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(228, 25);
            this.findButton.TabIndex = 0;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // findWhatTextBox
            // 
            this.findWhatTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findWhatTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.findWhatTextBox.Location = new System.Drawing.Point(0, 120);
            this.findWhatTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.findWhatTextBox.Name = "findWhatTextBox";
            this.findWhatTextBox.Size = new System.Drawing.Size(228, 23);
            this.findWhatTextBox.TabIndex = 5;
            this.findWhatTextBox.TextChanged += new System.EventHandler(this.findWhatTextBox_TextChanged);
            // 
            // replaceWithTextBox
            // 
            this.replaceWithTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replaceWithTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.replaceWithTextBox.Location = new System.Drawing.Point(232, 120);
            this.replaceWithTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.replaceWithTextBox.Name = "replaceWithTextBox";
            this.replaceWithTextBox.Size = new System.Drawing.Size(228, 23);
            this.replaceWithTextBox.TabIndex = 5;
            this.replaceWithTextBox.TextChanged += new System.EventHandler(this.replaceWithTextBox_TextChanged);
            // 
            // colHistoryDt
            // 
            this.colHistoryDt.FillWeight = 110F;
            this.colHistoryDt.HeaderText = "Время";
            this.colHistoryDt.Name = "colHistoryDt";
            this.colHistoryDt.ReadOnly = true;
            this.colHistoryDt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colHistoryDt.Width = 110;
            // 
            // colHistoryFind
            // 
            this.colHistoryFind.FillWeight = 160F;
            this.colHistoryFind.HeaderText = "Найдено";
            this.colHistoryFind.Name = "colHistoryFind";
            this.colHistoryFind.ReadOnly = true;
            this.colHistoryFind.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colHistoryFind.Width = 160;
            // 
            // colHistoryReplace
            // 
            this.colHistoryReplace.FillWeight = 160F;
            this.colHistoryReplace.HeaderText = "Заменено";
            this.colHistoryReplace.Name = "colHistoryReplace";
            this.colHistoryReplace.ReadOnly = true;
            this.colHistoryReplace.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colHistoryReplace.Width = 160;
            // 
            // colFindWhat
            // 
            this.colFindWhat.FillWeight = 195F;
            this.colFindWhat.HeaderText = "Найти";
            this.colFindWhat.Name = "colFindWhat";
            this.colFindWhat.ReadOnly = true;
            this.colFindWhat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFindWhat.Width = 195;
            // 
            // colReplaceWith
            // 
            this.colReplaceWith.FillWeight = 195F;
            this.colReplaceWith.HeaderText = "Заменить";
            this.colReplaceWith.Name = "colReplaceWith";
            this.colReplaceWith.ReadOnly = true;
            this.colReplaceWith.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colReplaceWith.Width = 195;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Поиск и замена текста";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.replaceWithDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findWhatDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView replaceWithDataGridView;
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView findWhatDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox findWhatTextBox;
        private System.Windows.Forms.TextBox replaceWithTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistoryDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistoryFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistoryReplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReplaceWith;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFindWhat;
    }
}