namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    hak--;
        //    tahmin = Convert.ToInt32(textBox1.Text);

        //    if (hak != 0)
        //    {
        //        if (tahmin == rastgeleSayi)
        //        {
        //            MessageBox.Show("Tebrikler, bildin!");
        //            label1.Text = "Kalan hakkýn: " + hak;
        //            rastgeleSayi = rastgele.Next(1, 11);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Üzgünüm, bilemediniz.");
        //            label1.Text = "Kalan hakkýn: " + hak;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Hakkýnýz bitti. \n Sayý deðer = " + rastgeleSayi);
        //        hak = 3;
        //        label1.Text = "Kalan hakkýn: " + hak;
        //        rastgeleSayi = rastgele.Next(1, 11);
        //    }
        //}

        //Random rastgele = new Random();
        //int rastgeleSayi;
        //int tahmin;
        //int hak;
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    rastgeleSayi= rastgele.Next(1,11);
        //}

        Random rastgele = new Random();
        int sayiBir;
        int sayiIki;
        int toplam;
        int sonuc;
        
   
        private void button1_Click(object sender, EventArgs e)
        {
            sayiBir = rastgele.Next(1, 100);
            sayiIki = rastgele.Next(1, 100);

            textBox1.Text = sayiBir.ToString();
            textBox2.Text = sayiIki.ToString();

            toplam = sayiBir + sayiIki;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dogru = 0;
            int yanlis = 0;


            if (textBox3.Text == " ")
            {
                MessageBox.Show("lütfen deðer gir");
            }
            else
            {
                sonuc = Convert.ToInt32(textBox3.Text);
                if (toplam == sonuc)
                {
                    MessageBox.Show("cevap dogru");
                    dogru++;
                    label1.Text = dogru.ToString();
                }
                else
                {
                    MessageBox.Show("cevap yanlýþ");
                    yanlis++;
                    label2.Text = yanlis.ToString();
                }
            }
        }
    }
}