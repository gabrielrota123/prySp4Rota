namespace prySp4Rota
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvVentas;
        private Button btnValidarDatos;
        private Button btnMozoDelDia;
        private Button btnTotales;
        private Button btnCerrar;
        private Label lblMozoDelDia;
        private Label lblImporteMozo;
        private Label lblTotalGeneral;
        private Label lblTotalComidas;
        private Label lblTotalBebidasSinAlcohol;
        private Label lblTotalBebidasConAlcohol;
        private Label lblTotalPostres;

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
            dgvVentas = new DataGridView();
            btnValidarDatos = new Button();
            btnMozoDelDia = new Button();
            btnTotales = new Button();
            btnCerrar = new Button();
            lblMozoDelDia = new Label();
            lblImporteMozo = new Label();
            lblTotalGeneral = new Label();
            lblTotalComidas = new Label();
            lblTotalBebidasSinAlcohol = new Label();
            lblTotalBebidasConAlcohol = new Label();
            lblTotalPostres = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();

            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(30, 70);
            dgvVentas.MultiSelect = false;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvVentas.Size = new Size(740, 200);
            dgvVentas.TabIndex = 0;
            dgvVentas.CellValueChanged += dgvVentas_CellValueChanged;

            var columnaMozo = new DataGridViewTextBoxColumn { HeaderText = "Mozo", ReadOnly = true, Name = "Mozo", FillWeight = 120 };
            dgvVentas.Columns.Add(columnaMozo);
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Comidas", Name = "Comidas" });
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Bebidas sin alcohol", Name = "BebidasSinAlcohol" });
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Bebidas con alcohol", Name = "BebidasConAlcohol" });
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Postres", Name = "Postres" });
            dgvVentas.Rows.Add("Julio");
            dgvVentas.Rows.Add("Esteban");
            dgvVentas.Rows.Add("Javier");
            dgvVentas.Rows.Add("Gonzalo");
            dgvVentas.Rows.Add("Alberto");

            btnValidarDatos.Location = new Point(30, 290);
            btnValidarDatos.Size = new Size(140, 35);
            btnValidarDatos.Text = "Validar Datos";
            btnValidarDatos.Click += btnValidarDatos_Click;

            btnMozoDelDia.Enabled = false;
            btnMozoDelDia.Location = new Point(30, 350);
            btnMozoDelDia.Size = new Size(140, 35);
            btnMozoDelDia.Text = "Mozo del día";
            btnMozoDelDia.Click += btnMozoDelDia_Click;

            btnTotales.Enabled = false;
            btnTotales.Location = new Point(30, 405);
            btnTotales.Size = new Size(140, 35);
            btnTotales.Text = "Totales";
            btnTotales.Click += btnTotales_Click;

            btnCerrar.Location = new Point(650, 405);
            btnCerrar.Size = new Size(120, 35);
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;

            ConfigurarEtiqueta(lblMozoDelDia, "Mozo:", new Point(200, 350), new Size(250, 25));
            ConfigurarEtiqueta(lblImporteMozo, "Importe:", new Point(470, 350), new Size(180, 25));
            ConfigurarEtiqueta(lblTotalGeneral, "Total general:", new Point(200, 405), new Size(210, 25));
            ConfigurarEtiqueta(lblTotalComidas, "Comidas:", new Point(420, 405), new Size(150, 25));
            ConfigurarEtiqueta(lblTotalBebidasSinAlcohol, "Bebidas sin alcohol:", new Point(200, 440), new Size(210, 25));
            ConfigurarEtiqueta(lblTotalBebidasConAlcohol, "Bebidas con alcohol:", new Point(420, 440), new Size(210, 25));
            ConfigurarEtiqueta(lblTotalPostres, "Postres:", new Point(650, 440), new Size(120, 25));

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(dgvVentas);
            Controls.Add(btnValidarDatos);
            Controls.Add(btnMozoDelDia);
            Controls.Add(btnTotales);
            Controls.Add(btnCerrar);
            Controls.Add(lblMozoDelDia);
            Controls.Add(lblImporteMozo);
            Controls.Add(lblTotalGeneral);
            Controls.Add(lblTotalComidas);
            Controls.Add(lblTotalBebidasSinAlcohol);
            Controls.Add(lblTotalBebidasConAlcohol);
            Controls.Add(lblTotalPostres);
            Name = "Form1";
            Text = "La Milanga - Ventas diarias";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        private static void ConfigurarEtiqueta(Label etiqueta, string texto, Point ubicacion, Size tamano)
        {
            etiqueta.AutoSize = false;
            etiqueta.BorderStyle = BorderStyle.FixedSingle;
            etiqueta.Location = ubicacion;
            etiqueta.Size = tamano;
            etiqueta.Text = texto;
            etiqueta.TextAlign = ContentAlignment.MiddleLeft;
        }

        #endregion
    }
}
