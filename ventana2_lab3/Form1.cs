namespace ventana2_lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int desayuno;
            int dias = int.Parse(txtDias.Text);
            int categoria = int.Parse(txtCategoria.Text);
            float pago = 0.0f;
            float pago_total;

            switch (categoria)
            {
                case 3:
                    if (dias >= 1 && dias <= 5)
                    {
                        pago = 100f;
                    }
                    else if (dias >= 6 && dias <= 10)
                    {
                        pago = 85f;
                    }
                    else
                    {
                        pago = 70f;
                    }
                    break;
                case 5:
                    if (dias >= 1 && dias <= 5)
                    {
                        pago = 300f;
                    }
                    else if (dias >= 6 && dias <= 10)
                    {
                        pago = 270f;
                    }
                    else
                    {
                        pago = 250f;
                    }
                    break;
            }
            desayuno = dias * 7;
            pago_total = (pago * dias) + desayuno;

            txtPagoT.Text = Convert.ToString(pago_total);
        }
    }
}