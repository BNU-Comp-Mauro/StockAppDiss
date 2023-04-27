
namespace StockAppDiss
{
    partial class ManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.FnameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PasswordTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.emailTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UsersGV = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 113);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(951, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(381, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manage Users";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // unameTb
            // 
            this.unameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.unameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.unameTb.HintForeColor = System.Drawing.Color.Empty;
            this.unameTb.HintText = "";
            this.unameTb.isPassword = false;
            this.unameTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.unameTb.LineIdleColor = System.Drawing.Color.Gray;
            this.unameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.unameTb.LineThickness = 3;
            this.unameTb.Location = new System.Drawing.Point(13, 177);
            this.unameTb.Margin = new System.Windows.Forms.Padding(4);
            this.unameTb.Name = "unameTb";
            this.unameTb.Size = new System.Drawing.Size(208, 35);
            this.unameTb.TabIndex = 1;
            this.unameTb.Text = "Username";
            this.unameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.unameTb.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // FnameTb
            // 
            this.FnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FnameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FnameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FnameTb.HintForeColor = System.Drawing.Color.Empty;
            this.FnameTb.HintText = "";
            this.FnameTb.isPassword = false;
            this.FnameTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.FnameTb.LineIdleColor = System.Drawing.Color.Gray;
            this.FnameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.FnameTb.LineThickness = 3;
            this.FnameTb.Location = new System.Drawing.Point(13, 228);
            this.FnameTb.Margin = new System.Windows.Forms.Padding(4);
            this.FnameTb.Name = "FnameTb";
            this.FnameTb.Size = new System.Drawing.Size(208, 33);
            this.FnameTb.TabIndex = 2;
            this.FnameTb.Text = "Fullname";
            this.FnameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PasswordTb
            // 
            this.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PasswordTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PasswordTb.HintForeColor = System.Drawing.Color.Empty;
            this.PasswordTb.HintText = "";
            this.PasswordTb.isPassword = false;
            this.PasswordTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.PasswordTb.LineIdleColor = System.Drawing.Color.Gray;
            this.PasswordTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PasswordTb.LineThickness = 3;
            this.PasswordTb.Location = new System.Drawing.Point(13, 280);
            this.PasswordTb.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(208, 33);
            this.PasswordTb.TabIndex = 3;
            this.PasswordTb.Text = "Password";
            this.PasswordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // emailTb
            // 
            this.emailTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTb.HintForeColor = System.Drawing.Color.Empty;
            this.emailTb.HintText = "";
            this.emailTb.isPassword = false;
            this.emailTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.emailTb.LineIdleColor = System.Drawing.Color.Gray;
            this.emailTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.emailTb.LineThickness = 3;
            this.emailTb.Location = new System.Drawing.Point(13, 335);
            this.emailTb.Margin = new System.Windows.Forms.Padding(4);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(208, 33);
            this.emailTb.TabIndex = 4;
            this.emailTb.Text = "Email";
            this.emailTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailTb.OnValueChanged += new System.EventHandler(this.emailTb_OnValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(146, 433);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(620, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 41);
            this.label3.TabIndex = 10;
            this.label3.Text = "User List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UsersGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.UsersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersGV.BackgroundColor = System.Drawing.Color.White;
            this.UsersGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UsersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.UsersGV.EnableHeadersVisualStyles = false;
            this.UsersGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersGV.Location = new System.Drawing.Point(388, 254);
            this.UsersGV.Name = "UsersGV";
            this.UsersGV.RowHeadersVisible = false;
            this.UsersGV.RowHeadersWidth = 51;
            this.UsersGV.RowTemplate.Height = 24;
            this.UsersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersGV.Size = new System.Drawing.Size(570, 286);
            this.UsersGV.TabIndex = 11;
            this.UsersGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UsersGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UsersGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.UsersGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UsersGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.UsersGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UsersGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGV.ThemeStyle.HeaderStyle.Height = 4;
            this.UsersGV.ThemeStyle.ReadOnly = false;
            this.UsersGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UsersGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.UsersGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UsersGV.ThemeStyle.RowsStyle.Height = 24;
            this.UsersGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UsersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 594);
            this.Controls.Add(this.UsersGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.FnameTb);
            this.Controls.Add(this.unameTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox unameTb;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox FnameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PasswordTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaDataGridView UsersGV;
    }
}