namespace Ev1Ej
{
    partial class Menu
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
            this.salirMenu = new System.Windows.Forms.Button();
            this.bGoUsuarios = new System.Windows.Forms.Button();
            this.bGoProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salirMenu
            // 
            this.salirMenu.Location = new System.Drawing.Point(207, 239);
            this.salirMenu.Name = "salirMenu";
            this.salirMenu.Size = new System.Drawing.Size(75, 23);
            this.salirMenu.TabIndex = 0;
            this.salirMenu.Text = "Salir";
            this.salirMenu.UseVisualStyleBackColor = true;
            this.salirMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goToLogin);
            // 
            // bGoUsuarios
            // 
            this.bGoUsuarios.Location = new System.Drawing.Point(50, 40);
            this.bGoUsuarios.Name = "bGoUsuarios";
            this.bGoUsuarios.Size = new System.Drawing.Size(155, 122);
            this.bGoUsuarios.TabIndex = 1;
            this.bGoUsuarios.Text = "Usuarios";
            this.bGoUsuarios.UseVisualStyleBackColor = true;
            this.bGoUsuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goToUsuarios);
            // 
            // bGoProductos
            // 
            this.bGoProductos.Location = new System.Drawing.Point(289, 40);
            this.bGoProductos.Name = "bGoProductos";
            this.bGoProductos.Size = new System.Drawing.Size(155, 122);
            this.bGoProductos.TabIndex = 2;
            this.bGoProductos.Text = "Productos";
            this.bGoProductos.UseVisualStyleBackColor = true;
            this.bGoProductos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goToProductos);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 317);
            this.Controls.Add(this.bGoProductos);
            this.Controls.Add(this.bGoUsuarios);
            this.Controls.Add(this.salirMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button salirMenu;
        private Button bGoUsuarios;
        private Button bGoProductos;
    }
}