namespace Karar_yapıları_orn_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double toplam;
            kitapadet = Convert.ToInt32(textBox1.Text);
            if (kitapadet >= 0 && kitapadet <= 20)
            {
                toplam = Convert.ToDouble((kitapadet * 8) * 0.8);
                listBox1.Items.Add("Toplam Kitap Adedi: " + textBox1.Text);
                listBox1.Items.Add("Toplam İndirimsiz Tutar: " + kitapadet * 8);
                listBox1.Items.Add("Toplam İndirim: " + ((kitapadet * 8) - toplam));
                listBox1.Items.Add("Toplam İndirimli Tutar:" + toplam);
                listBox1.Items.Add("İndirim Oranı:%20");
                listBox1.Items.Add("Ödenecek Tutar:" + toplam);
            }
            if (kitapadet >= 21 && kitapadet <= 41)
            {
                toplam = Convert.ToDouble((kitapadet * 8) * 0.6);
                listBox1.Items.Add("Toplam Kitap Adedi: " + textBox1.Text);
                listBox1.Items.Add("Toplam İndirimsiz Tutar: " + kitapadet * 8);
                listBox1.Items.Add("Toplam İndirim: " + ((kitapadet * 8) - toplam));
                listBox1.Items.Add("Toplam İndirimli Tutar:" + toplam);
                listBox1.Items.Add("İndirim Oranı:%40");
                listBox1.Items.Add("Ödenecek Tutar:" + toplam);
            }
            if (kitapadet >= 42)
            {
                toplam = Convert.ToDouble((kitapadet * 8) * 0.5);
                listBox1.Items.Add("Toplam Kitap Adedi: " + textBox1.Text);
                listBox1.Items.Add("Toplam İndirimsiz Tutar: " + kitapadet * 8);
                listBox1.Items.Add("Toplam İndirim: " + ((kitapadet * 8) - toplam));
                listBox1.Items.Add("Toplam İndirimli Tutar:" + toplam);
                listBox1.Items.Add("İndirim Oranı:%50");
                listBox1.Items.Add("Ödenecek Tutar:" + toplam);
            }
        }
    }
}