namespace Budget_Planner
{
    partial class WorkDayTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titel_txt = new System.Windows.Forms.Label();
            this.clr_s1 = new System.Windows.Forms.Button();
            this.clr_s2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.shift1,
            this.shift2});
            this.dgv.Location = new System.Drawing.Point(3, 39);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(256, 266);
            this.dgv.TabIndex = 0;
            this.dgv.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_edit);
            this.dgv.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Cell_NumberOnly);
            // 
            // item
            // 
            this.item.FillWeight = 228.4264F;
            this.item.HeaderText = "ITEM";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.item.Width = 39;
            // 
            // shift1
            // 
            this.shift1.FillWeight = 35.7868F;
            this.shift1.HeaderText = "Shift 1";
            this.shift1.Name = "shift1";
            this.shift1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.shift1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.shift1.Width = 43;
            // 
            // shift2
            // 
            this.shift2.FillWeight = 35.7868F;
            this.shift2.HeaderText = "Shift 2";
            this.shift2.Name = "shift2";
            this.shift2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.shift2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.shift2.Width = 43;
            // 
            // titel_txt
            // 
            this.titel_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel_txt.Location = new System.Drawing.Point(0, 0);
            this.titel_txt.Margin = new System.Windows.Forms.Padding(0);
            this.titel_txt.Name = "titel_txt";
            this.titel_txt.Size = new System.Drawing.Size(159, 36);
            this.titel_txt.TabIndex = 1;
            this.titel_txt.Text = "label1";
            this.titel_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clr_s1
            // 
            this.clr_s1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clr_s1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clr_s1.Location = new System.Drawing.Point(159, 0);
            this.clr_s1.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.clr_s1.Name = "clr_s1";
            this.clr_s1.Size = new System.Drawing.Size(49, 36);
            this.clr_s1.TabIndex = 2;
            this.clr_s1.Text = "Clear\r\nShift 1";
            this.clr_s1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clr_s1.UseVisualStyleBackColor = true;
            this.clr_s1.Click += new System.EventHandler(this.clr_s1_Click);
            // 
            // clr_s2
            // 
            this.clr_s2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clr_s2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clr_s2.Location = new System.Drawing.Point(210, 0);
            this.clr_s2.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.clr_s2.Name = "clr_s2";
            this.clr_s2.Size = new System.Drawing.Size(49, 36);
            this.clr_s2.TabIndex = 3;
            this.clr_s2.Text = "Clear\r\nShift 2";
            this.clr_s2.UseVisualStyleBackColor = true;
            this.clr_s2.Click += new System.EventHandler(this.clr_s2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.titel_txt);
            this.flowLayoutPanel1.Controls.Add(this.clr_s1);
            this.flowLayoutPanel1.Controls.Add(this.clr_s2);
            this.flowLayoutPanel1.Controls.Add(this.dgv);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(264, 311);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // WorkDayTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "WorkDayTable";
            this.Size = new System.Drawing.Size(264, 311);
            this.Load += new System.EventHandler(this.Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift2;
        private System.Windows.Forms.Label titel_txt;
        private System.Windows.Forms.Button clr_s1;
        private System.Windows.Forms.Button clr_s2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
