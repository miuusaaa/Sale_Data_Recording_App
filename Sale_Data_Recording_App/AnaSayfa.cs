namespace Sale_Data_Recording_App
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }


        private void btnMusteri_Click(object sender, EventArgs e)
        {
            FrmMusteri frm2 = new FrmMusteri();
            frm2.Show();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.Show();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            FrmKasa frm = new FrmKasa();
            frm.Show();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.Show();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            FrmKategoriler frm = new FrmKategoriler();
            frm.Show();
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            FrmSales frm = new FrmSales();
            frm.Show();
        }
    }
}
