namespace Ev1Ej
{
    partial class Productos
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
            this.eliminarProducto = new System.Windows.Forms.Button();
            this.modificarProducto = new System.Windows.Forms.Button();
            this.anyadirProducto = new System.Windows.Forms.Button();
            this.gpListProductos = new System.Windows.Forms.GroupBox();
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.salirProductos = new System.Windows.Forms.Button();
            this.gpListProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // eliminarProducto
            // 
            this.eliminarProducto.Enabled = false;
            this.eliminarProducto.Image = global::Ev1Ej.Properties.Resources.delete;
            this.eliminarProducto.Location = new System.Drawing.Point(211, 238);
            this.eliminarProducto.Name = "eliminarProducto";
            this.eliminarProducto.Size = new System.Drawing.Size(57, 47);
            this.eliminarProducto.TabIndex = 9;
            this.eliminarProducto.UseVisualStyleBackColor = true;
            this.eliminarProducto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deleteProduct);
            // 
            // modificarProducto
            // 
            this.modificarProducto.Enabled = false;
            this.modificarProducto.Image = global::Ev1Ej.Properties.Resources.edit;
            this.modificarProducto.Location = new System.Drawing.Point(211, 153);
            this.modificarProducto.Name = "modificarProducto";
            this.modificarProducto.Size = new System.Drawing.Size(57, 47);
            this.modificarProducto.TabIndex = 8;
            this.modificarProducto.UseVisualStyleBackColor = true;
            this.modificarProducto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openProductForm);
            // 
            // anyadirProducto
            // 
            this.anyadirProducto.Image = global::Ev1Ej.Properties.Resources.add;
            this.anyadirProducto.Location = new System.Drawing.Point(211, 71);
            this.anyadirProducto.Name = "anyadirProducto";
            this.anyadirProducto.Size = new System.Drawing.Size(57, 47);
            this.anyadirProducto.TabIndex = 7;
            this.anyadirProducto.UseVisualStyleBackColor = true;
            this.anyadirProducto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openProductForm);
            // 
            // gpListProductos
            // 
            this.gpListProductos.Controls.Add(this.lbProductos);
            this.gpListProductos.Location = new System.Drawing.Point(10, 49);
            this.gpListProductos.Name = "gpListProductos";
            this.gpListProductos.Size = new System.Drawing.Size(147, 248);
            this.gpListProductos.TabIndex = 6;
            this.gpListProductos.TabStop = false;
            this.gpListProductos.Text = "Productos";
            // 
            // lbProductos
            // 
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.ItemHeight = 15;
            this.lbProductos.Location = new System.Drawing.Point(6, 22);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(135, 214);
            this.lbProductos.TabIndex = 0;
            this.lbProductos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkSelection);
            // 
            // salirProductos
            // 
            this.salirProductos.Location = new System.Drawing.Point(126, 381);
            this.salirProductos.Name = "salirProductos";
            this.salirProductos.Size = new System.Drawing.Size(75, 23);
            this.salirProductos.TabIndex = 5;
            this.salirProductos.Text = "Salir";
            this.salirProductos.UseVisualStyleBackColor = true;
            this.salirProductos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goBack);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.eliminarProducto);
            this.Controls.Add(this.modificarProducto);
            this.Controls.Add(this.anyadirProducto);
            this.Controls.Add(this.gpListProductos);
            this.Controls.Add(this.salirProductos);
            this.Name = "Productos";
            this.Text = "TPV";
            this.gpListProductos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button eliminarProducto;
        private Button modificarProducto;
        private Button anyadirProducto;
        private GroupBox gpListProductos;
        private ListBox lbProductos;
        private Button salirProductos;
    }
}