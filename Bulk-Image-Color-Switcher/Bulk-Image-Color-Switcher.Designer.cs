namespace Bulk_Image_Color_Switcher
{
    partial class frmBulkImageColorSwitcher
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
            this.ofdCargarImagen = new System.Windows.Forms.OpenFileDialog();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.btnCargarOrigen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnCargarDestino = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fbdOrigen = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdDestino = new System.Windows.Forms.FolderBrowserDialog();
            this.btnReemplazarColor = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pgProgreso = new System.Windows.Forms.ProgressBar();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.bgwReemplazarColor = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.cdColorAnterior = new System.Windows.Forms.ColorDialog();
            this.btnColorAnterior = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnColorNuevo = new System.Windows.Forms.Button();
            this.cdColorNuevo = new System.Windows.Forms.ColorDialog();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.llGiovanniInvencible = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOrigen
            // 
            this.txtOrigen.Enabled = false;
            this.txtOrigen.Location = new System.Drawing.Point(32, 39);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(408, 20);
            this.txtOrigen.TabIndex = 4;
            // 
            // btnCargarOrigen
            // 
            this.btnCargarOrigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarOrigen.Location = new System.Drawing.Point(459, 39);
            this.btnCargarOrigen.Name = "btnCargarOrigen";
            this.btnCargarOrigen.Size = new System.Drawing.Size(75, 23);
            this.btnCargarOrigen.TabIndex = 0;
            this.btnCargarOrigen.Text = "Examinar";
            this.btnCargarOrigen.UseVisualStyleBackColor = true;
            this.btnCargarOrigen.Click += new System.EventHandler(this.btnCargarOrigen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Carpeta de origen:";
            // 
            // txtDestino
            // 
            this.txtDestino.Enabled = false;
            this.txtDestino.Location = new System.Drawing.Point(32, 99);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(408, 20);
            this.txtDestino.TabIndex = 4;
            // 
            // btnCargarDestino
            // 
            this.btnCargarDestino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarDestino.Location = new System.Drawing.Point(459, 99);
            this.btnCargarDestino.Name = "btnCargarDestino";
            this.btnCargarDestino.Size = new System.Drawing.Size(75, 23);
            this.btnCargarDestino.TabIndex = 1;
            this.btnCargarDestino.Text = "Examinar";
            this.btnCargarDestino.UseVisualStyleBackColor = true;
            this.btnCargarDestino.Click += new System.EventHandler(this.btnCargarDestino_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Carpeta de origen:";
            // 
            // btnReemplazarColor
            // 
            this.btnReemplazarColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReemplazarColor.Location = new System.Drawing.Point(32, 200);
            this.btnReemplazarColor.Name = "btnReemplazarColor";
            this.btnReemplazarColor.Size = new System.Drawing.Size(502, 23);
            this.btnReemplazarColor.TabIndex = 4;
            this.btnReemplazarColor.Text = "¡Reemplazar color!";
            this.btnReemplazarColor.UseVisualStyleBackColor = true;
            this.btnReemplazarColor.Click += new System.EventHandler(this.btnReemplazarColor_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(90, 276);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 8;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgProgreso
            // 
            this.pgProgreso.Location = new System.Drawing.Point(85, 240);
            this.pgProgreso.Name = "pgProgreso";
            this.pgProgreso.Size = new System.Drawing.Size(449, 23);
            this.pgProgreso.Step = 5;
            this.pgProgreso.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(32, 304);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(502, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // bgwReemplazarColor
            // 
            this.bgwReemplazarColor.WorkerReportsProgress = true;
            this.bgwReemplazarColor.WorkerSupportsCancellation = true;
            this.bgwReemplazarColor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwReemplazarColor_DoWork);
            this.bgwReemplazarColor.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwReemplazarColor_ProgressChanged);
            this.bgwReemplazarColor.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwReemplazarColor_RunWorkerCompleted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Progreso:";
            // 
            // btnColorAnterior
            // 
            this.btnColorAnterior.BackColor = System.Drawing.Color.White;
            this.btnColorAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorAnterior.Location = new System.Drawing.Point(130, 135);
            this.btnColorAnterior.Name = "btnColorAnterior";
            this.btnColorAnterior.Size = new System.Drawing.Size(40, 40);
            this.btnColorAnterior.TabIndex = 2;
            this.btnColorAnterior.UseVisualStyleBackColor = false;
            this.btnColorAnterior.Click += new System.EventHandler(this.btnColorAnterior_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reemplazar color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "por color:";
            // 
            // btnColorNuevo
            // 
            this.btnColorNuevo.BackColor = System.Drawing.Color.White;
            this.btnColorNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorNuevo.Location = new System.Drawing.Point(274, 135);
            this.btnColorNuevo.Name = "btnColorNuevo";
            this.btnColorNuevo.Size = new System.Drawing.Size(40, 40);
            this.btnColorNuevo.TabIndex = 3;
            this.btnColorNuevo.UseVisualStyleBackColor = false;
            this.btnColorNuevo.Click += new System.EventHandler(this.btnColorNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(32, 350);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(502, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Creado por: ";
            // 
            // llGiovanniInvencible
            // 
            this.llGiovanniInvencible.AutoSize = true;
            this.llGiovanniInvencible.Location = new System.Drawing.Point(263, 400);
            this.llGiovanniInvencible.Name = "llGiovanniInvencible";
            this.llGiovanniInvencible.Size = new System.Drawing.Size(101, 13);
            this.llGiovanniInvencible.TabIndex = 7;
            this.llGiovanniInvencible.TabStop = true;
            this.llGiovanniInvencible.Text = "Giovanni Invencible";
            this.llGiovanniInvencible.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGiovanniInvencible_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Todos los derechos reservados";
            // 
            // frmBulkImageColorSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 459);
            this.Controls.Add(this.llGiovanniInvencible);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnColorNuevo);
            this.Controls.Add(this.btnColorAnterior);
            this.Controls.Add(this.pgProgreso);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReemplazarColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarDestino);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.btnCargarOrigen);
            this.Controls.Add(this.txtOrigen);
            this.Name = "frmBulkImageColorSwitcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reemplazar color en imagenes de una carpeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdCargarImagen;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Button btnCargarOrigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnCargarDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog fbdOrigen;
        private System.Windows.Forms.FolderBrowserDialog fbdDestino;
        private System.Windows.Forms.Button btnReemplazarColor;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.ProgressBar pgProgreso;
        private System.Windows.Forms.Button btnCancelar;
        private System.ComponentModel.BackgroundWorker bgwReemplazarColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog cdColorAnterior;
        private System.Windows.Forms.Button btnColorAnterior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnColorNuevo;
        private System.Windows.Forms.ColorDialog cdColorNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel llGiovanniInvencible;
        private System.Windows.Forms.Label label7;
    }
}

