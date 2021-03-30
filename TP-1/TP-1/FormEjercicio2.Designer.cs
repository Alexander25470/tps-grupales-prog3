
namespace TP_1
{
    partial class FormEjercicio2
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
            this.groupBox_izq = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox_der = new System.Windows.Forms.GroupBox();
            this.listbElementos = new System.Windows.Forms.ListBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox_izq.SuspendLayout();
            this.groupBox_der.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_izq
            // 
            this.groupBox_izq.Controls.Add(this.btnAgregar);
            this.groupBox_izq.Controls.Add(this.tbxApellido);
            this.groupBox_izq.Controls.Add(this.tbxNombre);
            this.groupBox_izq.Controls.Add(this.lblApellido);
            this.groupBox_izq.Controls.Add(this.lblNombre);
            this.groupBox_izq.Location = new System.Drawing.Point(12, 27);
            this.groupBox_izq.Name = "groupBox_izq";
            this.groupBox_izq.Size = new System.Drawing.Size(354, 396);
            this.groupBox_izq.TabIndex = 0;
            this.groupBox_izq.TabStop = false;
            this.groupBox_izq.Text = "Ingreso de datos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(152, 284);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 34);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(152, 214);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(171, 23);
            this.tbxApellido.TabIndex = 3;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(154, 167);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(169, 23);
            this.tbxNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(77, 212);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(71, 20);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(77, 167);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // groupBox_der
            // 
            this.groupBox_der.Controls.Add(this.listbElementos);
            this.groupBox_der.Controls.Add(this.btnBorrar);
            this.groupBox_der.Location = new System.Drawing.Point(414, 27);
            this.groupBox_der.Name = "groupBox_der";
            this.groupBox_der.Size = new System.Drawing.Size(374, 396);
            this.groupBox_der.TabIndex = 0;
            this.groupBox_der.TabStop = false;
            this.groupBox_der.Text = "Elementos";
            // 
            // listbElementos
            // 
            this.listbElementos.FormattingEnabled = true;
            this.listbElementos.ItemHeight = 15;
            this.listbElementos.Location = new System.Drawing.Point(6, 22);
            this.listbElementos.Name = "listbElementos";
            this.listbElementos.Size = new System.Drawing.Size(361, 289);
            this.listbElementos.TabIndex = 7;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(134, 340);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(112, 34);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // FormEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_der);
            this.Controls.Add(this.groupBox_izq);
            this.Name = "FormEjercicio2";
            this.Text = "FormEjercicio2";
            this.groupBox_izq.ResumeLayout(false);
            this.groupBox_izq.PerformLayout();
            this.groupBox_der.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_izq;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupBox_der;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListBox listbElementos;
    }
}