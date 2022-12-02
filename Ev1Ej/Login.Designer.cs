namespace Ev1Ej
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lTitle = new System.Windows.Forms.Label();
            this.lUser = new System.Windows.Forms.Label();
            this.lPsswd = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPsswd = new System.Windows.Forms.TextBox();
            this.bEntrar = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lTitle.Location = new System.Drawing.Point(119, 45);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(241, 45);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Inicio de sesión";
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(214, 139);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(47, 15);
            this.lUser.TabIndex = 1;
            this.lUser.Text = "Usuario";
            // 
            // lPsswd
            // 
            this.lPsswd.AutoSize = true;
            this.lPsswd.Location = new System.Drawing.Point(204, 252);
            this.lPsswd.Name = "lPsswd";
            this.lPsswd.Size = new System.Drawing.Size(67, 15);
            this.lPsswd.TabIndex = 2;
            this.lPsswd.Text = "Contraseña";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(150, 169);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(172, 23);
            this.tbUser.TabIndex = 3;
            // 
            // tbPsswd
            // 
            this.tbPsswd.Location = new System.Drawing.Point(150, 282);
            this.tbPsswd.Name = "tbPsswd";
            this.tbPsswd.PasswordChar = '*';
            this.tbPsswd.Size = new System.Drawing.Size(172, 23);
            this.tbPsswd.TabIndex = 4;
            // 
            // bEntrar
            // 
            this.bEntrar.Location = new System.Drawing.Point(255, 380);
            this.bEntrar.Name = "bEntrar";
            this.bEntrar.Size = new System.Drawing.Size(67, 23);
            this.bEntrar.TabIndex = 5;
            this.bEntrar.Text = "Entrar";
            this.bEntrar.UseVisualStyleBackColor = true;
            this.bEntrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.login);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(150, 380);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(67, 23);
            this.bExit.TabIndex = 6;
            this.bExit.Text = "Salir";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 474);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bEntrar);
            this.Controls.Add(this.tbPsswd);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lPsswd);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.lTitle);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lTitle;
        private Label lUser;
        private Label lPsswd;
        private TextBox tbUser;
        private TextBox tbPsswd;
        private Button bEntrar;
        private Button bExit;
    }
}