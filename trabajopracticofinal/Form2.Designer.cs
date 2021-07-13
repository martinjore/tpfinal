namespace trabajopracticofinal
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtnombrecomp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcasado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.btnreg = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dni";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(223, 115);
            this.txtedad.MaxLength = 3;
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 12;
            this.txtedad.TextChanged += new System.EventHandler(this.txtedad_TextChanged);
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad_KeyPress);
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(223, 89);
            this.txtdni.MaxLength = 10;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(100, 20);
            this.txtdni.TabIndex = 11;
            // 
            // txtnombrecomp
            // 
            this.txtnombrecomp.Location = new System.Drawing.Point(223, 63);
            this.txtnombrecomp.Name = "txtnombrecomp";
            this.txtnombrecomp.Size = new System.Drawing.Size(100, 20);
            this.txtnombrecomp.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre completo";
            // 
            // cmbcasado
            // 
            this.cmbcasado.FormattingEnabled = true;
            this.cmbcasado.Location = new System.Drawing.Point(223, 141);
            this.cmbcasado.Name = "cmbcasado";
            this.cmbcasado.Size = new System.Drawing.Size(100, 21);
            this.cmbcasado.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Casado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Salario";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(223, 168);
            this.txtsalario.Multiline = true;
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 20);
            this.txtsalario.TabIndex = 18;
            this.txtsalario.TextChanged += new System.EventHandler(this.txtsalario_TextChanged);
            this.txtsalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsalario_KeyPress);
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(173, 214);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(75, 23);
            this.btnreg.TabIndex = 17;
            this.btnreg.Text = "Registrar";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.AccessibleName = "";
            this.btneliminar.Location = new System.Drawing.Point(271, 216);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 20;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(362, 216);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(66, 25);
            this.btnmodificar.TabIndex = 21;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 295);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbcasado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtnombrecomp);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Alta Empleados";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtedad;
        public System.Windows.Forms.TextBox txtdni;
        public System.Windows.Forms.TextBox txtnombrecomp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtsalario;
        public System.Windows.Forms.Button btnreg;
        public System.Windows.Forms.ComboBox cmbcasado;
        public System.Windows.Forms.Button btneliminar;
        public System.Windows.Forms.Button btnmodificar;
    }
}