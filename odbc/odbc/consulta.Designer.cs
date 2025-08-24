namespace odbc
{
    partial class consulta
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
            BtnCargar = new Button();
            DgvDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvDatos).BeginInit();
            SuspendLayout();
            // 
            // BtnCargar
            // 
            BtnCargar.Location = new Point(595, 40);
            BtnCargar.Name = "BtnCargar";
            BtnCargar.Size = new Size(163, 67);
            BtnCargar.TabIndex = 0;
            BtnCargar.Text = "Cargar datos";
            BtnCargar.UseVisualStyleBackColor = true;
            BtnCargar.Click += BtnCargar_Click;
            // 
            // DgvDatos
            // 
            DgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDatos.Location = new Point(31, 157);
            DgvDatos.Name = "DgvDatos";
            DgvDatos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DgvDatos.Size = new Size(727, 281);
            DgvDatos.TabIndex = 1;
            DgvDatos.CellContentClick += DgvDatos_CellContentClick;
            // 
            // consulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvDatos);
            Controls.Add(BtnCargar);
            Name = "consulta";
            Text = "consulta";
            ((System.ComponentModel.ISupportInitialize)DgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCargar;
        private DataGridView DgvDatos;
    }
}