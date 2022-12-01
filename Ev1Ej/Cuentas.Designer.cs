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
            // Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSalirCuentas);
            this.Name = "Cuentas";
            this.Text = "Cuentas";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bSalirCuentas;
    }
}