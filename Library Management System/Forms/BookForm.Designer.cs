namespace Library_Management_System.Forms
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBkid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBkauthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBkname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GVlist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVlist)).BeginInit();
            this.SuspendLayout();
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
            // txtBkauthor
            // 
            this.txtBkauthor.BorderRadius = 20;
            this.txtBkauthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBkauthor.DefaultText = "";
            this.txtBkauthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBkauthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBkauthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBkauthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBkauthor.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBkauthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtBkauthor, "txtBkauthor");
            this.txtBkauthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtBkauthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBkauthor.Name = "txtBkauthor";
            this.txtBkauthor.PasswordChar = '\0';
            this.txtBkauthor.PlaceholderText = "";
            this.txtBkauthor.SelectedText = "";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Name = "label2";
            // 
            // txtBkname
            // 
            this.txtBkname.BorderRadius = 20;
            this.txtBkname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBkname.DefaultText = "";
            this.txtBkname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBkname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBkname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBkname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBkname.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBkname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtBkname, "txtBkname");
            this.txtBkname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtBkname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBkname.Name = "txtBkname";
            this.txtBkname.PasswordChar = '\0';
            this.txtBkname.PlaceholderText = "";
            this.txtBkname.SelectedText = "";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Name = "label3";
            // 
            // GVlist
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.GVlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GVlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVlist.BackgroundColor = System.Drawing.Color.White;
            this.GVlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GVlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.GVlist, "GVlist");
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVlist.DefaultCellStyle = dataGridViewCellStyle6;
            this.GVlist.EnableHeadersVisualStyles = false;
            this.GVlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVlist.Name = "GVlist";
            this.GVlist.RowHeadersVisible = false;
            this.GVlist.RowTemplate.Height = 24;
            this.GVlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVlist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GVlist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GVlist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GVlist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GVlist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GVlist.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GVlist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVlist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GVlist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GVlist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.GVlist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GVlist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GVlist.ThemeStyle.HeaderStyle.Height = 4;
            this.GVlist.ThemeStyle.ReadOnly = false;
            this.GVlist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GVlist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GVlist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.GVlist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GVlist.ThemeStyle.RowsStyle.Height = 24;
            this.GVlist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVlist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 13;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Name = "btnAdd";
            // 
            // btnDel
            // 
            this.btnDel.BorderRadius = 13;
            this.btnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDel.FillColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.btnDel, "btnDel");
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Name = "btnDel";
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 13;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Name = "btnEdit";
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
            // BookForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.GVlist);
            this.Controls.Add(this.txtBkname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBkauthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBkid);
            this.Controls.Add(this.label1);
            this.Name = "BookForm";
            ((System.ComponentModel.ISupportInitialize)(this.GVlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtBkid;
        private Guna.UI2.WinForms.Guna2TextBox txtBkauthor;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtBkname;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView GVlist;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
    }
}