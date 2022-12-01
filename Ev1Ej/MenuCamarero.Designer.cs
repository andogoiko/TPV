namespace Ev1Ej
{
    partial class MenuCamarero
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
            this.bGoProductos = new System.Windows.Forms.Button();
            this.bGoCuentas = new System.Windows.Forms.Button();
            this.salirMenuCamarero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bGoProductos
            // 
            this.bGoProductos.Location = new System.Drawing.Point(288, 47);
            this.bGoProductos.Name = "bGoProductos";
            this.bGoProductos.Size = new System.Drawing.Size(155, 122);
            this.bGoProductos.TabIndex = 5;
            this.bGoProductos.Text = "Productos";
            this.bGoProductos.UseVisualStyleBackColor = true;
            this.bGoProductos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goToProductos);
            // 
            // bGoCuentas
            // 
            this.bGoCuentas.Location = new System.Drawing.Point(49, 47);
            this.bGoCuentas.Name = "bGoCuentas";
            this.bGoCuentas.Size = new System.Drawing.Size(155, 122);
            this.bGoCuentas.TabIndex = 4;
            this.bGoCuentas.Text = "Cuentas";
            this.bGoCuentas.UseVisualStyleBackColor = true;
            this.bGoCuentas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goToCuentas);
            // 
            // salirMenuCamarero
            // 
            this.salirMenuCamarero.Location = new System.Drawing.Point(206, 246);
            this.salirMenuCamarero.Name = "salirMenuCamarero";
            this.salirMenuCamarero.Size = new System.Drawing.Size(75, 23);
            this.salirMenuCamarero.TabIndex = 3;
            this.salirMenuCamarero.Text = "Salir";
            this.salirMenuCamarero.UseVisualStyleBackColor = true;
            this.salirMenuCamarero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goToLogin);
            // 
            // MenuCamarero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 317);
            this.Controls.Add(this.bGoProductos);
            this.Controls.Add(this.bGoCuentas);
            this.Controls.Add(this.salirMenuCamarero);
            this.Name = "MenuCamarero";
            this.Text = "MenuCamarero";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bGoProductos;
        private Button bGoCuentas;
        private Button salirMenuCamarero;
    }
}