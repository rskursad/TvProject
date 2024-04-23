using static Guna.UI2.WinForms.Suite.Descriptions;
using System.Media;

namespace __
{
    public partial class Form1 : Form
    {
        private Image[] resimler1 = new Image[] { Properties.Resources._10, Properties.Resources._11, Properties.Resources._12, Properties.Resources._13, Properties.Resources._14
        , Properties.Resources._15, Properties.Resources._16, Properties.Resources._17, Properties.Resources._18, Properties.Resources._19,Properties.Resources._20, Properties.Resources._21};
        string resimYolu = "C:\\sizin\\resim\\yolunuz\\resim.jpg";
        Image image = Image.FromFile(resimYolu);
        private SoundPlayer player;
        private int kapat;

        public Form1()
        {
            InitializeComponent();
            player = new SoundPlayer(Properties.Resources.mp31);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "TV";
            kapat = 0;
            PictureBox.Visible = false;
            kanalLabel.Hide();
            sinyalLabel.Hide();
            sinyalLabel.Text = "Görüntü kalitesi ayarlarını yapmak için tuşları kullanın!";
            manzaranız.Hide();
        }
        int count = -1;
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
        private void Pic(int deger)
        {
            PictureBox.Image = resimler1[deger];
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void gucButton_Click(object sender, EventArgs e)
        {
            if (count == -1)
            {
                sinyalLabel.Show();
                kanalLabel.Show();
                infoLabel.Text = "?- Kırmızılarla devam et!";
                Button1.FillColor = Color.Red;
                gucButton.FillColor = Color.Black;
                count++;
            }
            if (kapat==1)
            {
                player.Stop();
                Close();
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                aktifKalite.Text = "Aktif Kalite: 480p";
                Pic(8);
                Button2.FillColor = Color.Black;
                Button3.FillColor = Color.Red;
                count++;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                aktifKalite.Text = "Aktif Kalite: 240p";
                sinyalLabel.Hide();
                Pic(0);
                PictureBox.Visible = true;
                infoLabel.Hide();
                Button1.FillColor = Color.Black;
                Button2.FillColor = Color.Red;
                count++;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (count == 2)
            {
                aktifKalite.Text = "Aktif Kalite: 720p";
                Pic(10);
                Button3.FillColor = Color.Black;
                Button4.FillColor = Color.Red;
                count++;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (count == 3)
            {
                aktifKalite.Text = "Aktif Kalite: 1080p";
                Pic(11);
                Button4.FillColor = Color.Black;
                Button5.FillColor = Color.Red;
                count++;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (count == 4)
            {
                PictureBox.Image = image;
                aktifKalite.Text = "Aktif Kalite: ∞";
                manzaranız.Show();
                player.PlayLooping();
                kanalLabel.Text = "♥";
                PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                kapat = 1;
                Button5.FillColor = Color.Black;
                gucButton.FillColor = Color.Red;
                count++;
            }
            
        }
    }
}
