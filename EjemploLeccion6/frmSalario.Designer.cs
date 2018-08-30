namespace EjemploLeccion6
{
    partial class frmSalario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSalarioBase = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.chkAsociacion = new System.Windows.Forms.CheckBox();
            this.chkRenta = new System.Windows.Forms.CheckBox();
            this.chkCCSS = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtsalarioNeto = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSalarioBase);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Empleado";
            // 
            // TxtSalarioBase
            // 
            this.TxtSalarioBase.Location = new System.Drawing.Point(179, 83);
            this.TxtSalarioBase.Name = "TxtSalarioBase";
            this.TxtSalarioBase.Size = new System.Drawing.Size(197, 33);
            this.TxtSalarioBase.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(179, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(338, 33);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario Base";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCalcular);
            this.groupBox2.Controls.Add(this.chkAsociacion);
            this.groupBox2.Controls.Add(this.chkRenta);
            this.groupBox2.Controls.Add(this.chkCCSS);
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deducciones";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(393, 53);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(124, 33);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "&Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // chkAsociacion
            // 
            this.chkAsociacion.AutoSize = true;
            this.chkAsociacion.Location = new System.Drawing.Point(234, 57);
            this.chkAsociacion.Name = "chkAsociacion";
            this.chkAsociacion.Size = new System.Drawing.Size(142, 29);
            this.chkAsociacion.TabIndex = 2;
            this.chkAsociacion.Text = "Asociación";
            this.chkAsociacion.UseVisualStyleBackColor = true;
            // 
            // chkRenta
            // 
            this.chkRenta.AutoSize = true;
            this.chkRenta.Location = new System.Drawing.Point(125, 57);
            this.chkRenta.Name = "chkRenta";
            this.chkRenta.Size = new System.Drawing.Size(93, 29);
            this.chkRenta.TabIndex = 1;
            this.chkRenta.Text = "Renta";
            this.chkRenta.UseVisualStyleBackColor = true;
            // 
            // chkCCSS
            // 
            this.chkCCSS.AutoSize = true;
            this.chkCCSS.Location = new System.Drawing.Point(16, 57);
            this.chkCCSS.Name = "chkCCSS";
            this.chkCCSS.Size = new System.Drawing.Size(89, 29);
            this.chkCCSS.TabIndex = 0;
            this.chkCCSS.Text = "CCSS";
            this.chkCCSS.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtsalarioNeto);
            this.panel1.Controls.Add(this.txttotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 115);
            this.panel1.TabIndex = 2;
            // 
            // txtsalarioNeto
            // 
            this.txtsalarioNeto.BackColor = System.Drawing.SystemColors.Info;
            this.txtsalarioNeto.Enabled = false;
            this.txtsalarioNeto.Location = new System.Drawing.Point(234, 62);
            this.txtsalarioNeto.Name = "txtsalarioNeto";
            this.txtsalarioNeto.Size = new System.Drawing.Size(255, 33);
            this.txtsalarioNeto.TabIndex = 3;
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.SystemColors.Info;
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(234, 19);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(255, 33);
            this.txttotal.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Salario Neto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Deducciones";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(411, 419);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(124, 32);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(281, 419);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(124, 32);
            this.BtnLimpiar.TabIndex = 4;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // frmSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(547, 462);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Salario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtSalarioBase;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.CheckBox chkAsociacion;
        private System.Windows.Forms.CheckBox chkRenta;
        private System.Windows.Forms.CheckBox chkCCSS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtsalarioNeto;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}

