using System.ComponentModel;

namespace Parcial_II.Vista
{
    partial class UserAdmin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tbcUserAdmin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbcUserAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcUserAdmin
            // 
            this.tbcUserAdmin.Controls.Add(this.tabPage1);
            this.tbcUserAdmin.Controls.Add(this.tabPage2);
            this.tbcUserAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcUserAdmin.Location = new System.Drawing.Point(0, 0);
            this.tbcUserAdmin.Margin = new System.Windows.Forms.Padding(10);
            this.tbcUserAdmin.Name = "tbcUserAdmin";
            this.tbcUserAdmin.SelectedIndex = 0;
            this.tbcUserAdmin.Size = new System.Drawing.Size(448, 448);
            this.tbcUserAdmin.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(440, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (249)))), ((int) (((byte) (249)))), ((int) (((byte) (249)))));
            this.Controls.Add(this.tbcUserAdmin);
            this.DoubleBuffered = true;
            this.Name = "UserAdmin";
            this.Size = new System.Drawing.Size(448, 448);
            this.tbcUserAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tbcUserAdmin;

        #endregion
    }
}