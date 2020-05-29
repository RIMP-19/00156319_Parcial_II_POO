using System.ComponentModel;

namespace Parcial_II.Vista
{
    partial class FrmMainMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.tlpMainMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnProducts = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnAddress = new System.Windows.Forms.Button();
            this.btnBusiness = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.tlpMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainMenu
            // 
            this.tlpMainMenu.ColumnCount = 2;
            this.tlpMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpMainMenu.Controls.Add(this.btnProducts, 0, 5);
            this.tlpMainMenu.Controls.Add(this.lblTittle, 1, 0);
            this.tlpMainMenu.Controls.Add(this.btnOrders, 0, 2);
            this.tlpMainMenu.Controls.Add(this.btnAddress, 0, 3);
            this.tlpMainMenu.Controls.Add(this.btnBusiness, 0, 4);
            this.tlpMainMenu.Controls.Add(this.btnUsuario, 0, 1);
            this.tlpMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tlpMainMenu.Name = "tlpMainMenu";
            this.tlpMainMenu.RowCount = 6;
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMainMenu.Size = new System.Drawing.Size(612, 443);
            this.tlpMainMenu.TabIndex = 0;
            // 
            // btnProducts
            // 
            this.btnProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (136)))), ((int) (((byte) (116)))), ((int) (((byte) (182)))));
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(16, 378);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(120, 52);
            this.btnProducts.TabIndex = 5;
            this.btnProducts.Text = "Productos";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.FontChanged += new System.EventHandler(this.btnProducts_FontChanged);
            // 
            // lblTittle
            // 
            this.lblTittle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTittle.ForeColor = System.Drawing.Color.White;
            this.lblTittle.Location = new System.Drawing.Point(156, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(453, 73);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "hugo";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTittle.FontChanged += new System.EventHandler(this.lblTittle_FontChanged);
            // 
            // btnOrders
            // 
            this.btnOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (136)))), ((int) (((byte) (116)))), ((int) (((byte) (182)))));
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(16, 156);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(120, 52);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Ordenes";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.FontChanged += new System.EventHandler(this.btnOrders_FontChanged);
            // 
            // btnAddress
            // 
            this.btnAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddress.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (136)))), ((int) (((byte) (116)))), ((int) (((byte) (182)))));
            this.btnAddress.FlatAppearance.BorderSize = 0;
            this.btnAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddress.ForeColor = System.Drawing.Color.White;
            this.btnAddress.Location = new System.Drawing.Point(16, 229);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(120, 52);
            this.btnAddress.TabIndex = 3;
            this.btnAddress.Text = "Direcciones";
            this.btnAddress.UseVisualStyleBackColor = false;
            this.btnAddress.FontChanged += new System.EventHandler(this.btnAddress_FontChanged);
            // 
            // btnBusiness
            // 
            this.btnBusiness.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBusiness.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (136)))), ((int) (((byte) (116)))), ((int) (((byte) (182)))));
            this.btnBusiness.FlatAppearance.BorderSize = 0;
            this.btnBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnBusiness.ForeColor = System.Drawing.Color.White;
            this.btnBusiness.Location = new System.Drawing.Point(16, 302);
            this.btnBusiness.Name = "btnBusiness";
            this.btnBusiness.Size = new System.Drawing.Size(120, 52);
            this.btnBusiness.TabIndex = 4;
            this.btnBusiness.Text = "Negocios";
            this.btnBusiness.UseVisualStyleBackColor = false;
            this.btnBusiness.FontChanged += new System.EventHandler(this.btnBusiness_FontChanged);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (136)))), ((int) (((byte) (116)))), ((int) (((byte) (182)))));
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Location = new System.Drawing.Point(16, 83);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(120, 52);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.FontChanged += new System.EventHandler(this.btnUsuario_FontChanged);
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (33)))), ((int) (((byte) (92)))));
            this.ClientSize = new System.Drawing.Size(612, 443);
            this.Controls.Add(this.tlpMainMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hugo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMainMenu_FormClosed);
            this.tlpMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.Button btnBusiness;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.TableLayoutPanel tlpMainMenu;

        #endregion
    }
}