namespace DORMULARIOBASE
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
            this.labelSaludo = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPaterno = new System.Windows.Forms.Label();
            this.labelMaterno = new System.Windows.Forms.Label();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.btnCargo = new System.Windows.Forms.Button();
            this.btnNombre = new System.Windows.Forms.Button();
            this.btnApellido = new System.Windows.Forms.Button();
            this.btnApellido2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSaludo
            // 
            this.labelSaludo.AutoSize = true;
            this.labelSaludo.Location = new System.Drawing.Point(33, 33);
            this.labelSaludo.Name = "labelSaludo";
            this.labelSaludo.Size = new System.Drawing.Size(62, 16);
            this.labelSaludo.TabIndex = 0;
            this.labelSaludo.Text = "SALUDO";
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Location = new System.Drawing.Point(188, 33);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(55, 16);
            this.labelCargo.TabIndex = 1;
            this.labelCargo.Text = "CARGO";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(349, 33);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(75, 16);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "NOMBRES";
            // 
            // labelPaterno
            // 
            this.labelPaterno.AutoSize = true;
            this.labelPaterno.Location = new System.Drawing.Point(524, 33);
            this.labelPaterno.Name = "labelPaterno";
            this.labelPaterno.Size = new System.Drawing.Size(73, 16);
            this.labelPaterno.TabIndex = 3;
            this.labelPaterno.Text = "PATERNO";
            // 
            // labelMaterno
            // 
            this.labelMaterno.AutoSize = true;
            this.labelMaterno.Location = new System.Drawing.Point(683, 33);
            this.labelMaterno.Name = "labelMaterno";
            this.labelMaterno.Size = new System.Drawing.Size(75, 16);
            this.labelMaterno.TabIndex = 4;
            this.labelMaterno.Text = "MATERNO";
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(36, 344);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(102, 23);
            this.btnSaludar.TabIndex = 5;
            this.btnSaludar.Text = "SALUDAR";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // btnCargo
            // 
            this.btnCargo.Location = new System.Drawing.Point(191, 344);
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(79, 23);
            this.btnCargo.TabIndex = 6;
            this.btnCargo.Text = "CARGO";
            this.btnCargo.UseVisualStyleBackColor = true;
            this.btnCargo.Click += new System.EventHandler(this.btnCargo_Click);
            // 
            // btnNombre
            // 
            this.btnNombre.Location = new System.Drawing.Point(349, 344);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(84, 23);
            this.btnNombre.TabIndex = 7;
            this.btnNombre.Text = "NOMBRE";
            this.btnNombre.UseVisualStyleBackColor = true;
            this.btnNombre.Click += new System.EventHandler(this.btnNombre_Click);
            // 
            // btnApellido
            // 
            this.btnApellido.Location = new System.Drawing.Point(503, 344);
            this.btnApellido.Name = "btnApellido";
            this.btnApellido.Size = new System.Drawing.Size(94, 23);
            this.btnApellido.TabIndex = 8;
            this.btnApellido.Text = "APELLIDO";
            this.btnApellido.UseVisualStyleBackColor = true;
            this.btnApellido.Click += new System.EventHandler(this.btnApellido_Click);
            // 
            // btnApellido2
            // 
            this.btnApellido2.Location = new System.Drawing.Point(677, 344);
            this.btnApellido2.Name = "btnApellido2";
            this.btnApellido2.Size = new System.Drawing.Size(81, 23);
            this.btnApellido2.TabIndex = 9;
            this.btnApellido2.Text = "APELLIDO";
            this.btnApellido2.UseVisualStyleBackColor = true;
            this.btnApellido2.Click += new System.EventHandler(this.btnApellido2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApellido2);
            this.Controls.Add(this.btnApellido);
            this.Controls.Add(this.btnNombre);
            this.Controls.Add(this.btnCargo);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.labelMaterno);
            this.Controls.Add(this.labelPaterno);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.labelSaludo);
            this.Name = "Form1";
            this.Text = "BASE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSaludo;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPaterno;
        private System.Windows.Forms.Label labelMaterno;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Button btnCargo;
        private System.Windows.Forms.Button btnNombre;
        private System.Windows.Forms.Button btnApellido;
        private System.Windows.Forms.Button btnApellido2;
    }
}

