using System.ComponentModel;

namespace Parcial_II.Vista
{
    partial class NormalUser
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
            this.tlpNormalUser = new System.Windows.Forms.TableLayoutPanel();
            this.lblTittle = new System.Windows.Forms.Label();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtNewPass2 = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.tlpNormalUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpNormalUser
            // 
            this.tlpNormalUser.ColumnCount = 1;
            this.tlpNormalUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNormalUser.Controls.Add(this.lblTittle, 0, 0);
            this.tlpNormalUser.Controls.Add(this.txtActual, 0, 2);
            this.tlpNormalUser.Controls.Add(this.txtNewPass, 0, 4);
            this.tlpNormalUser.Controls.Add(this.txtNewPass2, 0, 6);
            this.tlpNormalUser.Controls.Add(this.btnChangePass, 0, 8);
            this.tlpNormalUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNormalUser.Location = new System.Drawing.Point(0, 0);
            this.tlpNormalUser.Name = "tlpNormalUser";
            this.tlpNormalUser.RowCount = 10;
            this.tlpNormalUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpNormalUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpNormalUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpNormalUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpNormalUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpNormalUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpNormalUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpNormalUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpNormalUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpNormalUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpNormalUser.Size = new System.Drawing.Size(368, 445);
            this.tlpNormalUser.TabIndex = 0;
            // 
            // lblTittle
            // 
            this.lblTittle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblTittle.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (33)))), ((int) (((byte) (92)))));
            this.lblTittle.Location = new System.Drawing.Point(3, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(362, 66);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Cambiar contraseña";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTittle.FontChanged += new System.EventHandler(this.lblTittle_FontChanged);
            // 
            // txtActual
            // 
            this.txtActual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtActual.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtActual.Location = new System.Drawing.Point(95, 108);
            this.txtActual.Name = "txtActual";
            this.txtActual.Size = new System.Drawing.Size(177, 26);
            this.txtActual.TabIndex = 1;
            this.txtActual.Text = " Contraseña actual";
            this.txtActual.Enter += new System.EventHandler(this.txtActual_Enter);
            this.txtActual.Leave += new System.EventHandler(this.txtActual_Leave);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtNewPass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNewPass.Location = new System.Drawing.Point(92, 196);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(183, 26);
            this.txtNewPass.TabIndex = 2;
            this.txtNewPass.Text = " Contraseña nueva";
            this.txtNewPass.Enter += new System.EventHandler(this.txtNewPass_Enter);
            this.txtNewPass.Leave += new System.EventHandler(this.txtNewPass_Leave);
            // 
            // txtNewPass2
            // 
            this.txtNewPass2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtNewPass2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNewPass2.Location = new System.Drawing.Point(95, 284);
            this.txtNewPass2.Name = "txtNewPass2";
            this.txtNewPass2.Size = new System.Drawing.Size(177, 26);
            this.txtNewPass2.TabIndex = 3;
            this.txtNewPass2.Text = " Confirmar contraseña";
            this.txtNewPass2.Enter += new System.EventHandler(this.txtNewPass2_Enter);
            this.txtNewPass2.Leave += new System.EventHandler(this.txtNewPass2_Leave);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (136)))), ((int) (((byte) (116)))), ((int) (((byte) (182)))));
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(122, 364);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(124, 41);
            this.btnChangePass.TabIndex = 4;
            this.btnChangePass.Text = "Cambiar";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.FontChanged += new System.EventHandler(this.btnChangePass_FontChanged);
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // NormalUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (249)))), ((int) (((byte) (249)))), ((int) (((byte) (249)))));
            this.Controls.Add(this.tlpNormalUser);
            this.DoubleBuffered = true;
            this.Name = "NormalUser";
            this.Size = new System.Drawing.Size(368, 445);
            this.tlpNormalUser.ResumeLayout(false);
            this.tlpNormalUser.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.TableLayoutPanel tlpNormalUser;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtNewPass2;

        #endregion
    }
}