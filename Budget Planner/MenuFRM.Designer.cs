namespace Budget_Planner
{
    partial class MenuFRM
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
            this.flw_menu = new System.Windows.Forms.FlowLayoutPanel();
            this.HRD_group = new Plibs.ExpandContainer();
            this.btn_mpp = new System.Windows.Forms.Button();
            this.btn_meal = new System.Windows.Forms.Button();
            this.btn_hrdparam = new System.Windows.Forms.Button();
            this.flw_menu.SuspendLayout();
            this.HRD_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // flw_menu
            // 
            this.flw_menu.Controls.Add(this.HRD_group);
            this.flw_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flw_menu.Location = new System.Drawing.Point(0, 0);
            this.flw_menu.Name = "flw_menu";
            this.flw_menu.Size = new System.Drawing.Size(184, 402);
            this.flw_menu.TabIndex = 0;
            // 
            // HRD_group
            // 
            this.HRD_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HRD_group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HRD_group.Controls.Add(this.btn_hrdparam);
            this.HRD_group.Controls.Add(this.btn_meal);
            this.HRD_group.Controls.Add(this.btn_mpp);
            this.HRD_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRD_group.HeightContainer = 202;
            this.HRD_group.Location = new System.Drawing.Point(3, 2);
            this.HRD_group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HRD_group.Name = "HRD_group";
            this.HRD_group.Size = new System.Drawing.Size(180, 239);
            this.HRD_group.TabIndex = 3;
            this.HRD_group.Tag = "";
            this.HRD_group.TitleText = "HRDGA";
            // 
            // btn_mpp
            // 
            this.btn_mpp.BackColor = System.Drawing.Color.Transparent;
            this.btn_mpp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mpp.Location = new System.Drawing.Point(4, 35);
            this.btn_mpp.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.btn_mpp.Name = "btn_mpp";
            this.btn_mpp.Size = new System.Drawing.Size(170, 29);
            this.btn_mpp.TabIndex = 4;
            this.btn_mpp.Text = "Man Power Plan";
            this.btn_mpp.UseVisualStyleBackColor = false;
            this.btn_mpp.Click += new System.EventHandler(this.mpp_btn_Click);
            // 
            // btn_meal
            // 
            this.btn_meal.BackColor = System.Drawing.Color.Transparent;
            this.btn_meal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_meal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_meal.Location = new System.Drawing.Point(4, 66);
            this.btn_meal.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.btn_meal.Name = "btn_meal";
            this.btn_meal.Size = new System.Drawing.Size(170, 29);
            this.btn_meal.TabIndex = 5;
            this.btn_meal.Text = "Meal n Drink";
            this.btn_meal.UseVisualStyleBackColor = false;
            // 
            // btn_hrdparam
            // 
            this.btn_hrdparam.BackColor = System.Drawing.Color.Transparent;
            this.btn_hrdparam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hrdparam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hrdparam.Location = new System.Drawing.Point(4, 98);
            this.btn_hrdparam.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.btn_hrdparam.Name = "btn_hrdparam";
            this.btn_hrdparam.Size = new System.Drawing.Size(170, 29);
            this.btn_hrdparam.TabIndex = 6;
            this.btn_hrdparam.Text = "Parameter";
            this.btn_hrdparam.UseVisualStyleBackColor = false;
            this.btn_hrdparam.Click += new System.EventHandler(this.btn_hrdparam_Click);
            // 
            // MenuFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 402);
            this.Controls.Add(this.flw_menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MenuFRM";
            this.Text = ".:: MENU ::.";
            this.flw_menu.ResumeLayout(false);
            this.HRD_group.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flw_menu;
        private Plibs.ExpandContainer HRD_group;
        private System.Windows.Forms.Button btn_mpp;
        private System.Windows.Forms.Button btn_meal;
        private System.Windows.Forms.Button btn_hrdparam;
    }
}