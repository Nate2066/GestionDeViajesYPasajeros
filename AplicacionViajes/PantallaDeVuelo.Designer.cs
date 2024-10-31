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
            this.bttProgramarViaje = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CellsHorarioProgramado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellsDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // bttProgramarViaje
            // 
            this.bttProgramarViaje.Location = new System.Drawing.Point(512, 13);
            this.bttProgramarViaje.Name = "bttProgramarViaje";
            this.bttProgramarViaje.Size = new System.Drawing.Size(162, 23);
            this.bttProgramarViaje.TabIndex = 1;
            this.bttProgramarViaje.Text = "Programar Viaje";
            this.bttProgramarViaje.UseVisualStyleBackColor = true;
            this.bttProgramarViaje.Click += new System.EventHandler(this.bttProgramarViaje_Click);
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
            // PantallaDeVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bttProgramarViaje);
            this.Controls.Add(this.dataTableroViajesDisponibles);
            this.Name = "PantallaDeVuelo";
            this.Text = "PantallaDeVuelo";
            ((System.ComponentModel.ISupportInitialize)(this.dataTableroViajesDisponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTableroViajesDisponibles;
        private System.Windows.Forms.Button bttProgramarViaje;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellsHorarioProgramado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellsDestino;
    }
}