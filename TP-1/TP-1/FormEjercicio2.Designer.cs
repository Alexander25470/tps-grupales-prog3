
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
            this.groupBox_der = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox_izq.SuspendLayout();
            this.groupBox_der.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_izq
            // 
            this.groupBox_izq.Controls.Add(this.btnAgregar);
            this.groupBox_izq.Controls.Add(this.textBox2);
            this.groupBox_izq.Controls.Add(this.textBox1);
            this.groupBox_izq.Controls.Add(this.lblApellido);
            this.groupBox_izq.Controls.Add(this.lblNombre);
            this.groupBox_izq.Location = new System.Drawing.Point(12, 27);
            this.groupBox_izq.Name = "groupBox_izq";
            this.groupBox_izq.Size = new System.Drawing.Size(354, 396);
            this.groupBox_izq.TabIndex = 0;
            this.groupBox_izq.TabStop = false;
            this.groupBox_izq.Text = "Ingreso de datos";
            // 
            // groupBox_der
            // 
            this.groupBox_der.Controls.Add(this.btnBorrar);
            this.groupBox_der.Controls.Add(this.listView1);
            this.groupBox_der.Location = new System.Drawing.Point(414, 27);
            this.groupBox_der.Name = "groupBox_der";
            this.groupBox_der.Size = new System.Drawing.Size(374, 396);
            this.groupBox_der.TabIndex = 0;
            this.groupBox_der.TabStop = false;
            this.groupBox_der.Text = "Elementos";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 23);
            this.textBox2.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(152, 284);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 34);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(35, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(309, 282);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListView listView1;
    }
}