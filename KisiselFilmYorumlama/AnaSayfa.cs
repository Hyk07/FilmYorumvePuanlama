namespace classProje
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilmEkle flm = new FilmEkle();
            flm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilmListele flmlist = new FilmListele();
            flmlist.ShowDialog();
        }
    }
}