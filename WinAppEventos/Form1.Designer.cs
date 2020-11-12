namespace WinAppEventos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSalir = new System.Windows.Forms.Button();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.pictureBoxLleno1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLleno2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxVacio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLleno1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLleno2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVacio)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.SystemColors.Info;
            this.buttonSalir.Font = new System.Drawing.Font("MoeumT R", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSalir.Location = new System.Drawing.Point(85, 190);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(139, 57);
            this.buttonSalir.TabIndex = 0;
            this.buttonSalir.Text = "&Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            this.buttonSalir.MouseEnter += new System.EventHandler(this.buttonSalir_MouseEnter);
            this.buttonSalir.MouseLeave += new System.EventHandler(this.buttonSalir_MouseLeave);
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font("MoeumT R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMensaje.Location = new System.Drawing.Point(49, 97);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(0, 22);
            this.labelMensaje.TabIndex = 1;
            // 
            // pictureBoxLleno1
            // 
            this.pictureBoxLleno1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLleno1.Image")));
            this.pictureBoxLleno1.Location = new System.Drawing.Point(331, 38);
            this.pictureBoxLleno1.Name = "pictureBoxLleno1";
            this.pictureBoxLleno1.Size = new System.Drawing.Size(172, 166);
            this.pictureBoxLleno1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLleno1.TabIndex = 2;
            this.pictureBoxLleno1.TabStop = false;
            this.pictureBoxLleno1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBoxLleno1_DragEnter);
            this.pictureBoxLleno1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLleno1_MouseClick);
            this.pictureBoxLleno1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLleno1_MouseDown);
            // 
            // pictureBoxLleno2
            // 
            this.pictureBoxLleno2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLleno2.Image")));
            this.pictureBoxLleno2.Location = new System.Drawing.Point(558, 38);
            this.pictureBoxLleno2.Name = "pictureBoxLleno2";
            this.pictureBoxLleno2.Size = new System.Drawing.Size(172, 166);
            this.pictureBoxLleno2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLleno2.TabIndex = 3;
            this.pictureBoxLleno2.TabStop = false;
            this.pictureBoxLleno2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLleno2_MouseClick);
            this.pictureBoxLleno2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLleno2_MouseDown);
            // 
            // pictureBoxVacio
            // 
            this.pictureBoxVacio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxVacio.Location = new System.Drawing.Point(331, 245);
            this.pictureBoxVacio.Name = "pictureBoxVacio";
            this.pictureBoxVacio.Size = new System.Drawing.Size(399, 193);
            this.pictureBoxVacio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVacio.TabIndex = 4;
            this.pictureBoxVacio.TabStop = false;
            this.pictureBoxVacio.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBoxVacio_DragDrop);
            this.pictureBoxVacio.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBoxVacio_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxVacio);
            this.Controls.Add(this.pictureBoxLleno2);
            this.Controls.Add(this.pictureBoxLleno1);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.buttonSalir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLleno1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLleno2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVacio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.PictureBox pictureBoxLleno1;
        private System.Windows.Forms.PictureBox pictureBoxLleno2;
        private System.Windows.Forms.PictureBox pictureBoxVacio;
    }
}

