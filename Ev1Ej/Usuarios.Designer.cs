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
            this.lbUsuarios = new System.Windows.Forms.ListBox();
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
            this.gpListUsuarios.Controls.Add(this.lbUsuarios);
            this.gpListUsuarios.Location = new System.Drawing.Point(12, 49);
            this.gpListUsuarios.Name = "gpListUsuarios";
            this.gpListUsuarios.Size = new System.Drawing.Size(147, 248);
            this.gpListUsuarios.TabIndex = 1;
            this.gpListUsuarios.TabStop = false;
            this.gpListUsuarios.Text = "Usuarios";
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.FormattingEnabled = true;
            this.lbUsuarios.ItemHeight = 15;
            this.lbUsuarios.Location = new System.Drawing.Point(6, 22);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbUsuarios.Size = new System.Drawing.Size(135, 214);
            this.lbUsuarios.TabIndex = 0;
            this.lbUsuarios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkSelection);
            // 
            // anyadirUsuario
            // 
            this.anyadirUsuario.Image = global::Ev1Ej.Properties.Resources.add;
            this.anyadirUsuario.Location = new System.Drawing.Point(213, 71);
            this.anyadirUsuario.Name = "anyadirUsuario";
            this.anyadirUsuario.Size = new System.Drawing.Size(57, 47);
            this.anyadirUsuario.TabIndex = 2;
            this.anyadirUsuario.UseVisualStyleBackColor = true;
            this.anyadirUsuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openUserForm);
            // 
            // modificarUsuario
            // 
            this.modificarUsuario.Enabled = false;
            this.modificarUsuario.Image = global::Ev1Ej.Properties.Resources.edit;
            this.modificarUsuario.Location = new System.Drawing.Point(213, 153);
            this.modificarUsuario.Name = "modificarUsuario";
            this.modificarUsuario.Size = new System.Drawing.Size(57, 47);
            this.modificarUsuario.TabIndex = 3;
            this.modificarUsuario.UseVisualStyleBackColor = true;
            this.modificarUsuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openUserForm);
            // 
            // eliminarUsuario
            // 
            this.eliminarUsuario.Enabled = false;
            this.eliminarUsuario.Image = global::Ev1Ej.Properties.Resources.delete;
            this.eliminarUsuario.Location = new System.Drawing.Point(213, 238);
            this.eliminarUsuario.Name = "eliminarUsuario";
            this.eliminarUsuario.Size = new System.Drawing.Size(57, 47);
            this.eliminarUsuario.TabIndex = 4;
            this.eliminarUsuario.UseVisualStyleBackColor = true;
            this.eliminarUsuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deleteUsers);
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
        private ListBox lbUsuarios;
        private Button anyadirUsuario;
        private Button modificarUsuario;
        private Button eliminarUsuario;
    }
}