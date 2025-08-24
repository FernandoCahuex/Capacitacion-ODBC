namespace odbc
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
            txt_nombre = new Label();
            Txt_puesto = new Label();
            Txt_departamento = new Label();
            BtnAgregar = new Button();
            TxtBNombre = new TextBox();
            TxtBPuesto = new TextBox();
            TxtBDepartamento = new TextBox();
            BtnConsultar = new Button();
            BtnEliminar = new Button();
            SuspendLayout();
            // 
            // txt_nombre
            // 
            txt_nombre.AutoSize = true;
            txt_nombre.Location = new Point(50, 64);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(64, 20);
            txt_nombre.TabIndex = 0;
            txt_nombre.Text = "Nombre";
            // 
            // Txt_puesto
            // 
            Txt_puesto.AutoSize = true;
            Txt_puesto.Location = new Point(50, 123);
            Txt_puesto.Name = "Txt_puesto";
            Txt_puesto.Size = new Size(53, 20);
            Txt_puesto.TabIndex = 1;
            Txt_puesto.Text = "Puesto";
            // 
            // Txt_departamento
            // 
            Txt_departamento.AutoSize = true;
            Txt_departamento.Location = new Point(50, 183);
            Txt_departamento.Name = "Txt_departamento";
            Txt_departamento.Size = new Size(106, 20);
            Txt_departamento.TabIndex = 2;
            Txt_departamento.Text = "Departamento";
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(50, 305);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(94, 29);
            BtnAgregar.TabIndex = 3;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // TxtBNombre
            // 
            TxtBNombre.Location = new Point(165, 61);
            TxtBNombre.Name = "TxtBNombre";
            TxtBNombre.Size = new Size(289, 27);
            TxtBNombre.TabIndex = 4;
            TxtBNombre.TextChanged += TxtBNombre_TextChanged;
            // 
            // TxtBPuesto
            // 
            TxtBPuesto.Location = new Point(165, 116);
            TxtBPuesto.Name = "TxtBPuesto";
            TxtBPuesto.Size = new Size(289, 27);
            TxtBPuesto.TabIndex = 5;
            TxtBPuesto.TextChanged += TxtBPuesto_TextChanged;
            // 
            // TxtBDepartamento
            // 
            TxtBDepartamento.Location = new Point(165, 176);
            TxtBDepartamento.Name = "TxtBDepartamento";
            TxtBDepartamento.Size = new Size(289, 27);
            TxtBDepartamento.TabIndex = 6;
            TxtBDepartamento.TextChanged += TxtBDepartamento_TextChanged;
            // 
            // BtnConsultar
            // 
            BtnConsultar.Location = new Point(490, 305);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(94, 29);
            BtnConsultar.TabIndex = 7;
            BtnConsultar.Text = "Consultar";
            BtnConsultar.UseVisualStyleBackColor = true;
            BtnConsultar.Click += BtnConsultar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(271, 305);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(94, 29);
            BtnEliminar.TabIndex = 8;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnConsultar);
            Controls.Add(TxtBDepartamento);
            Controls.Add(TxtBPuesto);
            Controls.Add(TxtBNombre);
            Controls.Add(BtnAgregar);
            Controls.Add(Txt_departamento);
            Controls.Add(Txt_puesto);
            Controls.Add(txt_nombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt_nombre;
        private Label Txt_puesto;
        private Label Txt_departamento;
        private Button BtnAgregar;
        private TextBox TxtBNombre;
        private TextBox TxtBPuesto;
        private TextBox TxtBDepartamento;
        private Button BtnConsultar;
        private Button BtnEliminar;
    }
}
