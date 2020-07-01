namespace Sikhnewala
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.TBFilter = new System.Windows.Forms.TextBox();
            this.bPrevious = new System.Windows.Forms.Button();
            this.bSubsequent = new System.Windows.Forms.Button();
            this.LBGroup = new System.Windows.Forms.ListBox();
            this.BApplyFilter = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.BAdjust = new System.Windows.Forms.Button();
            this.LStatus = new System.Windows.Forms.Label();
            this.BReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLogs
            // 
            this.dgvLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogs.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLogs.Location = new System.Drawing.Point(12, 12);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.RowTemplate.Height = 24;
            this.dgvLogs.Size = new System.Drawing.Size(1199, 433);
            this.dgvLogs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Group";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter";
            // 
            // TBSearch
            // 
            this.TBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TBSearch.Location = new System.Drawing.Point(67, 491);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(282, 22);
            this.TBSearch.TabIndex = 5;
            this.TBSearch.Enter += new System.EventHandler(this.TBSearch_Enter);
            this.TBSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBSearch_KeyUp);
            // 
            // TBFilter
            // 
            this.TBFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TBFilter.Location = new System.Drawing.Point(67, 517);
            this.TBFilter.Name = "TBFilter";
            this.TBFilter.Size = new System.Drawing.Size(282, 22);
            this.TBFilter.TabIndex = 6;
            this.TBFilter.TextChanged += new System.EventHandler(this.TBFilter_TextChanged);
            // 
            // bPrevious
            // 
            this.bPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bPrevious.Location = new System.Drawing.Point(356, 489);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(25, 23);
            this.bPrevious.TabIndex = 7;
            this.bPrevious.Text = "<";
            this.bPrevious.UseVisualStyleBackColor = true;
            this.bPrevious.Click += new System.EventHandler(this.BPrevious_Click);
            // 
            // bSubsequent
            // 
            this.bSubsequent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bSubsequent.Location = new System.Drawing.Point(386, 489);
            this.bSubsequent.Name = "bSubsequent";
            this.bSubsequent.Size = new System.Drawing.Size(25, 23);
            this.bSubsequent.TabIndex = 8;
            this.bSubsequent.Text = ">";
            this.bSubsequent.UseVisualStyleBackColor = true;
            this.bSubsequent.Click += new System.EventHandler(this.BSubsequent_Click);
            // 
            // LBGroup
            // 
            this.LBGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LBGroup.FormattingEnabled = true;
            this.LBGroup.ItemHeight = 16;
            this.LBGroup.Location = new System.Drawing.Point(67, 451);
            this.LBGroup.Name = "LBGroup";
            this.LBGroup.Size = new System.Drawing.Size(283, 36);
            this.LBGroup.TabIndex = 9;
            this.LBGroup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LBGroup_MouseClick);
            this.LBGroup.CursorChanged += new System.EventHandler(this.LBGroup_CursorChanged);
            // 
            // BApplyFilter
            // 
            this.BApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BApplyFilter.Location = new System.Drawing.Point(356, 517);
            this.BApplyFilter.Name = "BApplyFilter";
            this.BApplyFilter.Size = new System.Drawing.Size(75, 26);
            this.BApplyFilter.TabIndex = 12;
            this.BApplyFilter.Text = "Apply";
            this.BApplyFilter.UseVisualStyleBackColor = true;
            this.BApplyFilter.Click += new System.EventHandler(this.BApplyFilter_Click);
            // 
            // BClear
            // 
            this.BClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BClear.Location = new System.Drawing.Point(437, 517);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(75, 26);
            this.BClear.TabIndex = 13;
            this.BClear.Text = "Clear";
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // BAdjust
            // 
            this.BAdjust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BAdjust.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAdjust.Location = new System.Drawing.Point(1136, 559);
            this.BAdjust.Name = "BAdjust";
            this.BAdjust.Size = new System.Drawing.Size(75, 26);
            this.BAdjust.TabIndex = 14;
            this.BAdjust.Text = "Adjust";
            this.BAdjust.UseVisualStyleBackColor = true;
            this.BAdjust.Click += new System.EventHandler(this.BAdjust_Click);
            // 
            // LStatus
            // 
            this.LStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LStatus.AutoSize = true;
            this.LStatus.Location = new System.Drawing.Point(12, 559);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(109, 17);
            this.LStatus.TabIndex = 15;
            this.LStatus.Text = "Status message";
            // 
            // BReload
            // 
            this.BReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BReload.Location = new System.Drawing.Point(356, 451);
            this.BReload.Name = "BReload";
            this.BReload.Size = new System.Drawing.Size(75, 26);
            this.BReload.TabIndex = 16;
            this.BReload.Text = "Reload";
            this.BReload.UseVisualStyleBackColor = true;
            this.BReload.Click += new System.EventHandler(this.BReload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 586);
            this.Controls.Add(this.BReload);
            this.Controls.Add(this.LStatus);
            this.Controls.Add(this.BAdjust);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BApplyFilter);
            this.Controls.Add(this.LBGroup);
            this.Controls.Add(this.bSubsequent);
            this.Controls.Add(this.bPrevious);
            this.Controls.Add(this.TBFilter);
            this.Controls.Add(this.TBSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLogs);
            this.Name = "Form1";
            this.Text = "سیکھنے والا";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.TextBox TBFilter;
        private System.Windows.Forms.Button bPrevious;
        private System.Windows.Forms.Button bSubsequent;
        private System.Windows.Forms.ListBox LBGroup;
        private System.Windows.Forms.Button BApplyFilter;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.Button BAdjust;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Button BReload;
    }
}

