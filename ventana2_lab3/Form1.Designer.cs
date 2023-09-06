namespace ventana2_lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDias = new TextBox();
            txtCategoria = new TextBox();
            txtPagoT = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(181, 82);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 0;
            label1.Text = "Dias de estancia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(181, 136);
            label2.Name = "label2";
            label2.Size = new Size(242, 25);
            label2.TabIndex = 1;
            label2.Text = "Categoria de estrellas: (3/5)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(181, 188);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 2;
            label3.Text = "Pago Total:";
            // 
            // txtDias
            // 
            txtDias.Location = new Point(561, 82);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(100, 23);
            txtDias.TabIndex = 3;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(561, 136);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 4;
            // 
            // txtPagoT
            // 
            txtPagoT.Location = new Point(561, 188);
            txtPagoT.Name = "txtPagoT";
            txtPagoT.Size = new Size(100, 23);
            txtPagoT.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(405, 251);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtPagoT);
            Controls.Add(txtCategoria);
            Controls.Add(txtDias);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDias;
        private TextBox txtCategoria;
        private TextBox txtPagoT;
        private Button button1;
    }
}