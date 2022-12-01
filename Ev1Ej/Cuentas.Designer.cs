namespace Ev1Ej
{
    partial class Cuentas
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
            this.bSalirCuentas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bAnyadir = new System.Windows.Forms.Button();
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bQuitar = new System.Windows.Forms.Button();
            this.lbCuenta = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lTotal = new System.Windows.Forms.Label();
            this.bPayNScan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSalirCuentas
            // 
            this.bSalirCuentas.Location = new System.Drawing.Point(358, 369);
            this.bSalirCuentas.Name = "bSalirCuentas";
            this.bSalirCuentas.Size = new System.Drawing.Size(75, 23);
            this.bSalirCuentas.TabIndex = 0;
            this.bSalirCuentas.Text = "Salir";
            this.bSalirCuentas.UseVisualStyleBackColor = true;
            this.bSalirCuentas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goToMenuCamareros);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bAnyadir);
            this.groupBox1.Controls.Add(this.lbProductos);
            this.groupBox1.Location = new System.Drawing.Point(78, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Productos Disponibles";
            // 
            // bAnyadir
            // 
            this.bAnyadir.Location = new System.Drawing.Point(146, 86);
            this.bAnyadir.Name = "bAnyadir";
            this.bAnyadir.Size = new System.Drawing.Size(75, 23);
            this.bAnyadir.TabIndex = 1;
            this.bAnyadir.Text = "Añadir";
            this.bAnyadir.UseVisualStyleBackColor = true;
            this.bAnyadir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addToCuenta);
            // 
            // lbProductos
            // 
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.ItemHeight = 15;
            this.lbProductos.Location = new System.Drawing.Point(20, 36);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(120, 139);
            this.lbProductos.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bQuitar);
            this.groupBox2.Controls.Add(this.lbCuenta);
            this.groupBox2.Location = new System.Drawing.Point(454, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 193);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Cuenta del Cliente";
            // 
            // bQuitar
            // 
            this.bQuitar.Location = new System.Drawing.Point(145, 86);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(75, 23);
            this.bQuitar.TabIndex = 2;
            this.bQuitar.Text = "Quitar";
            this.bQuitar.UseVisualStyleBackColor = true;
            this.bQuitar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.removeFromCuenta);
            // 
            // lbCuenta
            // 
            this.lbCuenta.FormattingEnabled = true;
            this.lbCuenta.ItemHeight = 15;
            this.lbCuenta.Location = new System.Drawing.Point(19, 36);
            this.lbCuenta.Name = "lbCuenta";
            this.lbCuenta.Size = new System.Drawing.Size(120, 139);
            this.lbCuenta.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::Ev1Ej.Properties.Resources.exchange;
            this.button1.Location = new System.Drawing.Point(335, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 93);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Location = new System.Drawing.Point(473, 269);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(74, 15);
            this.lTotal.TabIndex = 4;
            this.lTotal.Text = "Recibo Total:";
            // 
            // bPayNScan
            // 
            this.bPayNScan.Location = new System.Drawing.Point(508, 311);
            this.bPayNScan.Name = "bPayNScan";
            this.bPayNScan.Size = new System.Drawing.Size(127, 23);
            this.bPayNScan.TabIndex = 5;
            this.bPayNScan.Text = "Pagar e imprimir";
            this.bPayNScan.UseVisualStyleBackColor = true;
            this.bPayNScan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.payNImpress);
            // 
            // Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bPayNScan);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bSalirCuentas);
            this.Name = "Cuentas";
            this.Text = "Cuentas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bSalirCuentas;
        private GroupBox groupBox1;
        private Button bAnyadir;
        private ListBox lbProductos;
        private GroupBox groupBox2;
        private Button bQuitar;
        private ListBox lbCuenta;
        private Button button1;
        private Label lTotal;
        private Button bPayNScan;
    }
}