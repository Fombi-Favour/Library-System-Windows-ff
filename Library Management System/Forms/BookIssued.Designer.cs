namespace Library_Management_System.Forms
{
    partial class BookIssued
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookIssued));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnIssue = new Guna.UI2.WinForms.Guna2Button();
            this.GVlist1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtStudName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBkName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBkid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDateIssue = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.GVlist1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDashboard
            // 
            this.btnDashboard.BorderRadius = 8;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.btnDashboard, "btnDashboard");
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Name = "btnDashboard";
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 20;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Name = "btnEdit";
            // 
            // btnDel
            // 
            this.btnDel.BorderRadius = 20;
            this.btnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDel.FillColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.btnDel, "btnDel");
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Name = "btnDel";
            // 
            // btnIssue
            // 
            this.btnIssue.BorderRadius = 13;
            this.btnIssue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIssue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.btnIssue, "btnIssue");
            this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.Name = "btnIssue";
            // 
            // GVlist1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.GVlist1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GVlist1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVlist1.BackgroundColor = System.Drawing.Color.White;
            this.GVlist1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVlist1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GVlist1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVlist1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.GVlist1, "GVlist1");
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVlist1.DefaultCellStyle = dataGridViewCellStyle6;
            this.GVlist1.EnableHeadersVisualStyles = false;
            this.GVlist1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVlist1.Name = "GVlist1";
            this.GVlist1.RowHeadersVisible = false;
            this.GVlist1.RowTemplate.Height = 24;
            this.GVlist1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVlist1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GVlist1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GVlist1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GVlist1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GVlist1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GVlist1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GVlist1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVlist1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GVlist1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GVlist1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.GVlist1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GVlist1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GVlist1.ThemeStyle.HeaderStyle.Height = 4;
            this.GVlist1.ThemeStyle.ReadOnly = false;
            this.GVlist1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GVlist1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GVlist1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.GVlist1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GVlist1.ThemeStyle.RowsStyle.Height = 24;
            this.GVlist1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVlist1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtStudName
            // 
            this.txtStudName.BorderRadius = 20;
            this.txtStudName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudName.DefaultText = "";
            this.txtStudName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStudName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStudName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudName.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.txtStudName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtStudName, "txtStudName");
            this.txtStudName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtStudName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.PasswordChar = '\0';
            this.txtStudName.PlaceholderText = "";
            this.txtStudName.SelectedText = "";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Name = "label3";
            // 
            // txtBkName
            // 
            this.txtBkName.BorderRadius = 20;
            this.txtBkName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBkName.DefaultText = "";
            this.txtBkName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBkName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBkName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBkName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBkName.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBkName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtBkName, "txtBkName");
            this.txtBkName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtBkName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBkName.Name = "txtBkName";
            this.txtBkName.PasswordChar = '\0';
            this.txtBkName.PlaceholderText = "";
            this.txtBkName.SelectedText = "";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Name = "label2";
            // 
            // txtClass
            // 
            this.txtClass.BorderRadius = 20;
            this.txtClass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClass.DefaultText = "";
            this.txtClass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClass.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.txtClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtClass, "txtClass");
            this.txtClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtClass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClass.Name = "txtClass";
            this.txtClass.PasswordChar = '\0';
            this.txtClass.PlaceholderText = "";
            this.txtClass.SelectedText = "";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Name = "label1";
            // 
            // txtBkid
            // 
            this.txtBkid.BorderRadius = 20;
            this.txtBkid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBkid.DefaultText = "";
            this.txtBkid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBkid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBkid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBkid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBkid.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBkid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtBkid, "txtBkid");
            this.txtBkid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtBkid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBkid.Name = "txtBkid";
            this.txtBkid.PasswordChar = '\0';
            this.txtBkid.PlaceholderText = "";
            this.txtBkid.SelectedText = "";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Name = "label5";
            // 
            // txtDateIssue
            // 
            resources.ApplyResources(this.txtDateIssue, "txtDateIssue");
            this.txtDateIssue.Name = "txtDateIssue";
            // 
            // BookIssued
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.txtDateIssue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBkid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.GVlist1);
            this.Controls.Add(this.txtStudName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBkName);
            this.Controls.Add(this.label2);
            this.Name = "BookIssued";
            ((System.ComponentModel.ISupportInitialize)(this.GVlist1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnIssue;
        private Guna.UI2.WinForms.Guna2DataGridView GVlist1;
        private Guna.UI2.WinForms.Guna2TextBox txtStudName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtBkName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtClass;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtBkid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtDateIssue;
    }
}