namespace Ev1Ej
{
    partial class Usuarios
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
            this.salirUsuarios = new System.Windows.Forms.Button();
            this.gpListUsuarios = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.anyadirUsuario = new System.Windows.Forms.Button();
            this.modificarUsuario = new System.Windows.Forms.Button();
            this.eliminarUsuario = new System.Windows.Forms.Button();
            this.gpListUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // salirUsuarios
            // 
            this.salirUsuarios.Location = new System.Drawing.Point(128, 381);
            this.salirUsuarios.Name = "salirUsuarios";
            this.salirUsuarios.Size = new System.Drawing.Size(75, 23);
            this.salirUsuarios.TabIndex = 0;
            this.salirUsuarios.Text = "Salir";
            this.salirUsuarios.UseVisualStyleBackColor = true;
            this.salirUsuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goToMenu);
            // 
            // gpListUsuarios
            // 
            this.gpListUsuarios.Controls.Add(this.listBox1);
            this.gpListUsuarios.Location = new System.Drawing.Point(12, 49);
            this.gpListUsuarios.Name = "gpListUsuarios";
            this.gpListUsuarios.Size = new System.Drawing.Size(147, 248);
            this.gpListUsuarios.TabIndex = 1;
            this.gpListUsuarios.TabStop = false;
            this.gpListUsuarios.Text = "Usuarios";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(6, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(135, 214);
            this.listBox1.TabIndex = 0;
            // 
            // anyadirUsuario
            // 
            this.anyadirUsuario.Image = global::Ev1Ej.Properties.Resources.add;
            this.anyadirUsuario.Location = new System.Drawing.Point(213, 71);
            this.anyadirUsuario.Name = "anyadirUsuario";
            this.anyadirUsuario.Size = new System.Drawing.Size(57, 47);
            this.anyadirUsuario.TabIndex = 2;
            this.anyadirUsuario.UseVisualStyleBackColor = true;
            // 
            // modificarUsuario
            // 
            this.modificarUsuario.Image = global::Ev1Ej.Properties.Resources.edit;
            this.modificarUsuario.Location = new System.Drawing.Point(213, 153);
            this.modificarUsuario.Name = "modificarUsuario";
            this.modificarUsuario.Size = new System.Drawing.Size(57, 47);
            this.modificarUsuario.TabIndex = 3;
            this.modificarUsuario.UseVisualStyleBackColor = true;
            // 
            // eliminarUsuario
            // 
            this.eliminarUsuario.Image = global::Ev1Ej.Properties.Resources.delete;
            this.eliminarUsuario.Location = new System.Drawing.Point(213, 238);
            this.eliminarUsuario.Name = "eliminarUsuario";
            this.eliminarUsuario.Size = new System.Drawing.Size(57, 47);
            this.eliminarUsuario.TabIndex = 4;
            this.eliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.eliminarUsuario);
            this.Controls.Add(this.modificarUsuario);
            this.Controls.Add(this.anyadirUsuario);
            this.Controls.Add(this.gpListUsuarios);
            this.Controls.Add(this.salirUsuarios);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.gpListUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button salirUsuarios;
        private GroupBox gpListUsuarios;
        private ListBox listBox1;
        private Button anyadirUsuario;
        private Button modificarUsuario;
        private Button eliminarUsuario;
    }
}