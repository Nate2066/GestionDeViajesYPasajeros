﻿namespace AplicacionViajes
{
    partial class formPantallaDeLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttIniciarSesion = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.bttRegistrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttIniciarSesion
            // 
            this.bttIniciarSesion.Location = new System.Drawing.Point(83, 171);
            this.bttIniciarSesion.Name = "bttIniciarSesion";
            this.bttIniciarSesion.Size = new System.Drawing.Size(114, 23);
            this.bttIniciarSesion.TabIndex = 0;
            this.bttIniciarSesion.Text = "Iniciar Sesion";
            this.bttIniciarSesion.UseVisualStyleBackColor = true;
            this.bttIniciarSesion.Click += new System.EventHandler(this.bttIniciarSesion_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(65, 73);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(151, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese sus datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(65, 121);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(151, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // bttRegistrarse
            // 
            this.bttRegistrarse.Location = new System.Drawing.Point(83, 200);
            this.bttRegistrarse.Name = "bttRegistrarse";
            this.bttRegistrarse.Size = new System.Drawing.Size(114, 23);
            this.bttRegistrarse.TabIndex = 7;
            this.bttRegistrarse.Text = "Registrarse";
            this.bttRegistrarse.UseVisualStyleBackColor = true;
            this.bttRegistrarse.Click += new System.EventHandler(this.bttRegistrarse_Click);
            // 
            // formPantallaDeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(280, 261);
            this.Controls.Add(this.bttRegistrarse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.bttIniciarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "formPantallaDeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttIniciarSesion;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button bttRegistrarse;
    }
}

