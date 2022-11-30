namespace Ev1Ej
{
    partial class FormProducto
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
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbArticulo = new System.Windows.Forms.TextBox();
            this.lPrecio = new System.Windows.Forms.Label();
            this.lArticulo = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.tbImpuestos = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.lImpuestos = new System.Windows.Forms.Label();
            this.lStock = new System.Windows.Forms.Label();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.lTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(121, 165);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(124, 23);
            this.tbPrecio.TabIndex = 11;
            // 
            // tbArticulo
            // 
            this.tbArticulo.Location = new System.Drawing.Point(121, 74);
            this.tbArticulo.Name = "tbArticulo";
            this.tbArticulo.Size = new System.Drawing.Size(124, 23);
            this.tbArticulo.TabIndex = 10;
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(121, 126);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(43, 15);
            this.lPrecio.TabIndex = 9;
            this.lPrecio.Text = "Precio:";
            // 
            // lArticulo
            // 
            this.lArticulo.AutoSize = true;
            this.lArticulo.Location = new System.Drawing.Point(121, 35);
            this.lArticulo.Name = "lArticulo";
            this.lArticulo.Size = new System.Drawing.Size(52, 15);
            this.lArticulo.TabIndex = 8;
            this.lArticulo.Text = "Artículo:";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(143, 507);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 7;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.doQuery);
            // 
            // tbImpuestos
            // 
            this.tbImpuestos.Location = new System.Drawing.Point(121, 347);
            this.tbImpuestos.Name = "tbImpuestos";
            this.tbImpuestos.Size = new System.Drawing.Size(124, 23);
            this.tbImpuestos.TabIndex = 15;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(121, 256);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(124, 23);
            this.tbStock.TabIndex = 14;
            // 
            // lImpuestos
            // 
            this.lImpuestos.AutoSize = true;
            this.lImpuestos.Location = new System.Drawing.Point(121, 308);
            this.lImpuestos.Name = "lImpuestos";
            this.lImpuestos.Size = new System.Drawing.Size(65, 15);
            this.lImpuestos.TabIndex = 13;
            this.lImpuestos.Text = "Impuestos:";
            // 
            // lStock
            // 
            this.lStock.AutoSize = true;
            this.lStock.Location = new System.Drawing.Point(121, 217);
            this.lStock.Name = "lStock";
            this.lStock.Size = new System.Drawing.Size(39, 15);
            this.lStock.TabIndex = 12;
            this.lStock.Text = "Stock:";
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(121, 442);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(124, 23);
            this.tbTipo.TabIndex = 17;
            // 
            // lTipo
            // 
            this.lTipo.AutoSize = true;
            this.lTipo.Location = new System.Drawing.Point(121, 403);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(33, 15);
            this.lTipo.TabIndex = 16;
            this.lTipo.Text = "Tipo:";
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 560);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.lTipo);
            this.Controls.Add(this.tbImpuestos);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.lImpuestos);
            this.Controls.Add(this.lStock);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbArticulo);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.lArticulo);
            this.Controls.Add(this.bAceptar);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbPrecio;
        private TextBox tbArticulo;
        private Label lPrecio;
        private Label lArticulo;
        private Button bAceptar;
        private TextBox tbImpuestos;
        private TextBox tbStock;
        private Label lImpuestos;
        private Label lStock;
        private TextBox tbTipo;
        private Label lTipo;
    }
}