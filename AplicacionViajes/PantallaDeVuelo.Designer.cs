namespace AplicacionViajes
{
    partial class PantallaDeVuelo
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
            this.dataTableroViajesDisponibles = new System.Windows.Forms.DataGridView();
            this.CellsHorarioProgramado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellsDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAgregarMinutos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAgregarHoras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAgregarDia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAgregarMes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAgregarAno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttAgregarViaje = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableroViajesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableroViajesDisponibles
            // 
            this.dataTableroViajesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableroViajesDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CellsHorarioProgramado,
            this.CellsDestino});
            this.dataTableroViajesDisponibles.Location = new System.Drawing.Point(13, 13);
            this.dataTableroViajesDisponibles.Name = "dataTableroViajesDisponibles";
            this.dataTableroViajesDisponibles.Size = new System.Drawing.Size(493, 425);
            this.dataTableroViajesDisponibles.TabIndex = 0;
            // 
            // CellsHorarioProgramado
            // 
            this.CellsHorarioProgramado.HeaderText = "Horario Programado";
            this.CellsHorarioProgramado.Name = "CellsHorarioProgramado";
            this.CellsHorarioProgramado.Width = 250;
            // 
            // CellsDestino
            // 
            this.CellsDestino.HeaderText = "Destino";
            this.CellsDestino.Name = "CellsDestino";
            this.CellsDestino.Width = 200;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Minutos";
            // 
            // txtAgregarMinutos
            // 
            this.txtAgregarMinutos.Location = new System.Drawing.Point(572, 354);
            this.txtAgregarMinutos.Name = "txtAgregarMinutos";
            this.txtAgregarMinutos.Size = new System.Drawing.Size(48, 20);
            this.txtAgregarMinutos.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Horas";
            // 
            // txtAgregarHoras
            // 
            this.txtAgregarHoras.Location = new System.Drawing.Point(572, 328);
            this.txtAgregarHoras.Name = "txtAgregarHoras";
            this.txtAgregarHoras.Size = new System.Drawing.Size(48, 20);
            this.txtAgregarHoras.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dia";
            // 
            // txtAgregarDia
            // 
            this.txtAgregarDia.Location = new System.Drawing.Point(572, 302);
            this.txtAgregarDia.Name = "txtAgregarDia";
            this.txtAgregarDia.Size = new System.Drawing.Size(48, 20);
            this.txtAgregarDia.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mes";
            // 
            // txtAgregarMes
            // 
            this.txtAgregarMes.Location = new System.Drawing.Point(572, 276);
            this.txtAgregarMes.Name = "txtAgregarMes";
            this.txtAgregarMes.Size = new System.Drawing.Size(48, 20);
            this.txtAgregarMes.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Año";
            // 
            // txtAgregarAno
            // 
            this.txtAgregarAno.Location = new System.Drawing.Point(572, 250);
            this.txtAgregarAno.Name = "txtAgregarAno";
            this.txtAgregarAno.Size = new System.Drawing.Size(48, 20);
            this.txtAgregarAno.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Agregar nuevo vuelo";
            // 
            // bttAgregarViaje
            // 
            this.bttAgregarViaje.Location = new System.Drawing.Point(528, 414);
            this.bttAgregarViaje.Name = "bttAgregarViaje";
            this.bttAgregarViaje.Size = new System.Drawing.Size(92, 23);
            this.bttAgregarViaje.TabIndex = 12;
            this.bttAgregarViaje.Text = "Agregar";
            this.bttAgregarViaje.UseVisualStyleBackColor = true;
            this.bttAgregarViaje.Click += new System.EventHandler(this.bttAgregarViaje_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Destino";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(572, 380);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(103, 20);
            this.txtDestino.TabIndex = 24;
            // 
            // PantallaDeVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAgregarMinutos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAgregarHoras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAgregarDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAgregarMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAgregarAno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttAgregarViaje);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataTableroViajesDisponibles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PantallaDeVuelo";
            this.Text = "PantallaDeVuelo";
            ((System.ComponentModel.ISupportInitialize)(this.dataTableroViajesDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTableroViajesDisponibles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellsHorarioProgramado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellsDestino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAgregarMinutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAgregarHoras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAgregarDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAgregarMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAgregarAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttAgregarViaje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDestino;
    }
}