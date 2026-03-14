namespace MODUL3_103022430003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Pilih Satuan Terlebih Dahulu");
                return;
            }
            if(textBox1.Text == "")
            {
                MessageBox.Show("Masukan Angka Yang Valid");
                return;
            }

            double hasil = this.konversiSuhu(double.Parse(textBox1.Text), comboBox1.Text, comboBox2.Text);
            textBox2.Text = hasil.ToString();

            
        }

        private double konversiSuhu(double nilaiSuhu, string dari, string ke)
        {
            if (dari == ke) return nilaiSuhu;

            double suhuDalamCelcius = nilaiSuhu;

            switch (dari)
            {
                case "Fahrenheit":
                    suhuDalamCelcius = (nilaiSuhu - 32) * 5.0 / 9.0;
                    break;
                case "Kelvin":
                    suhuDalamCelcius = nilaiSuhu - 273.15;
                    break;
                case "Reamur":
                    suhuDalamCelcius = nilaiSuhu * 5.0 / 4.0;
                    break;
            }

            switch (ke)
            {
                case "Fahrenheit":
                    return (suhuDalamCelcius * 9.0 / 5.0) + 32;
                case "Kelvin":
                    return suhuDalamCelcius + 273.15;
                case "Reamur":
                    return suhuDalamCelcius * 4.0 / 5.0;
                default:
                    return suhuDalamCelcius;
            }
        }
    }
}
