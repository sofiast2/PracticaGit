namespace Práctica_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.radioBtn1 = new System.Windows.Forms.RadioButton();
            this.radioBtn2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto";
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(80, 97);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(631, 189);
            this.txtTelegrama.TabIndex = 1;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(85, 368);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(51, 15);
            this.labelPrecio.TabIndex = 3;
            this.labelPrecio.Text = "Coste: ";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(142, 367);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(105, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.Location = new System.Drawing.Point(478, 345);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(223, 54);
            this.btnCalcularPrecio.TabIndex = 5;
            this.btnCalcularPrecio.Text = "Calcular";
            this.btnCalcularPrecio.UseVisualStyleBackColor = true;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularPrecio_Click);
            // 
            // radioBtn1
            // 
            this.radioBtn1.AutoSize = true;
            this.radioBtn1.Location = new System.Drawing.Point(80, 324);
            this.radioBtn1.Name = "radioBtn1";
            this.radioBtn1.Size = new System.Drawing.Size(67, 17);
            this.radioBtn1.TabIndex = 6;
            this.radioBtn1.TabStop = true;
            this.radioBtn1.Text = "Ordinario";
            this.radioBtn1.UseVisualStyleBackColor = true;
            // 
            // radioBtn2
            // 
            this.radioBtn2.AutoSize = true;
            this.radioBtn2.Location = new System.Drawing.Point(153, 324);
            this.radioBtn2.Name = "radioBtn2";
            this.radioBtn2.Size = new System.Drawing.Size(63, 17);
            this.radioBtn2.TabIndex = 7;
            this.radioBtn2.TabStop = true;
            this.radioBtn2.Text = "Urgente";
            this.radioBtn2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioBtn2);
            this.Controls.Add(this.radioBtn1);
            this.Controls.Add(this.btnCalcularPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnCalcularPrecio;
        private System.Windows.Forms.RadioButton radioBtn1;
        private System.Windows.Forms.RadioButton radioBtn2;
    }
}

