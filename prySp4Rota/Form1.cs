namespace prySp4Rota
{
    public partial class Form1 : Form
    {
        private readonly float[,] ventas = new float[5, 4];
        private readonly string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidarDatos_Click(object? sender, EventArgs e)
        {
            dgvVentas.EndEdit();

            for (var fila = 0; fila < ventas.GetLength(0); fila++)
            {
                for (var columna = 0; columna < ventas.GetLength(1); columna++)
                {
                    var valorCelda = dgvVentas.Rows[fila].Cells[columna + 1].Value?.ToString();

                    if (!float.TryParse(valorCelda, out var importe) || importe < 0)
                    {
                        btnMozoDelDia.Enabled = false;
                        btnTotales.Enabled = false;
                        dgvVentas.CurrentCell = dgvVentas.Rows[fila].Cells[columna + 1];
                        MessageBox.Show(
                            $"El importe de {mozos[fila]} en la categoría «{dgvVentas.Columns[columna + 1].HeaderText}» no es válido. Ingrese un número mayor o igual a cero.",
                            "Datos inválidos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    ventas[fila, columna] = importe;
                }
            }

            btnMozoDelDia.Enabled = true;
            btnTotales.Enabled = true;
            MessageBox.Show("Los datos fueron validados correctamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvVentas_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                btnMozoDelDia.Enabled = false;
                btnTotales.Enabled = false;
            }
        }

        private void btnMozoDelDia_Click(object? sender, EventArgs e)
        {
            var indiceMozo = 0;
            var mayorVenta = ObtenerTotalMozo(0);

            for (var fila = 1; fila < ventas.GetLength(0); fila++)
            {
                var totalMozo = ObtenerTotalMozo(fila);
                if (totalMozo > mayorVenta)
                {
                    mayorVenta = totalMozo;
                    indiceMozo = fila;
                }
            }

            lblMozoDelDia.Text = $"Mozo: {mozos[indiceMozo]}";
            lblImporteMozo.Text = $"Importe: {mayorVenta:N2}";
        }

        private void btnTotales_Click(object? sender, EventArgs e)
        {
            var totalGeneral = 0f;
            var totalesPorCategoria = new float[4];

            for (var fila = 0; fila < ventas.GetLength(0); fila++)
            {
                for (var columna = 0; columna < ventas.GetLength(1); columna++)
                {
                    totalGeneral += ventas[fila, columna];
                    totalesPorCategoria[columna] += ventas[fila, columna];
                }
            }

            lblTotalGeneral.Text = $"Total general: {totalGeneral:N2}";
            lblTotalComidas.Text = $"Comidas: {totalesPorCategoria[0]:N2}";
            lblTotalBebidasSinAlcohol.Text = $"Bebidas s/alcohol: {totalesPorCategoria[1]:N2}";
            lblTotalBebidasConAlcohol.Text = $"Bebidas c/alcohol: {totalesPorCategoria[2]:N2}";
            lblTotalPostres.Text = $"Postres: {totalesPorCategoria[3]:N2}";
        }

        private float ObtenerTotalMozo(int fila)
        {
            var total = 0f;
            for (var columna = 0; columna < ventas.GetLength(1); columna++)
            {
                total += ventas[fila, columna];
            }

            return total;
        }

        private void btnCerrar_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
