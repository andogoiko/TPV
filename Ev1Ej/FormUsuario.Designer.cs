namespace Ev1Ej
{
    partial class FormUsuario
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
            this.bAceptar = new System.Windows.Forms.Button();
            this.lUsername = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.gpUsuario = new System.Windows.Forms.GroupBox();
            this.gpUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(136, 357);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 0;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.doQuery);
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Location = new System.Drawing.Point(40, 19);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(63, 15);
            this.lUsername.TabIndex = 1;
            this.lUsername.Text = "Username:";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(40, 135);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(60, 15);
            this.lPassword.TabIndex = 2;
            this.lPassword.Text = "Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(40, 58);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(124, 23);
            this.tbUsername.TabIndex = 4;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(40, 174);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(124, 23);
            this.tbPassword.TabIndex = 5;
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(40, 249);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbAdmin.Size = new System.Drawing.Size(65, 19);
            this.cbAdmin.TabIndex = 6;
            this.cbAdmin.Text = ":Admin";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // gpUsuario
            // 
            this.gpUsuario.Controls.Add(this.lUsername);
            this.gpUsuario.Controls.Add(this.cbAdmin);
            this.gpUsuario.Controls.Add(this.lPassword);
            this.gpUsuario.Controls.Add(this.tbPassword);
            this.gpUsuario.Controls.Add(this.tbUsername);
            this.gpUsuario.Location = new System.Drawing.Point(71, 41);
            this.gpUsuario.Name = "gpUsuario";
            this.gpUsuario.Size = new System.Drawing.Size(200, 293);
            this.gpUsuario.TabIndex = 7;
            this.gpUsuario.TabStop = false;
            this.gpUsuario.Text = "Usuario";
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 429);
            this.Controls.Add(this.gpUsuario);
            this.Controls.Add(this.bAceptar);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.gpUsuario.ResumeLayout(false);
            this.gpUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bAceptar;
        private Label lUsername;
        private Label lPassword;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private CheckBox cbAdmin;
        private GroupBox gpUsuario;
    }
}