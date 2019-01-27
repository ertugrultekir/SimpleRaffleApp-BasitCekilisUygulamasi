using Cekilis.ManuelMesajlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cekilis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            pbEfekt.Image = Cekilis.Properties.Resources.start_button;
            pbEfekt.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                tbOdul.Text = tbOdul.Text.Trim();
                if (tbKisiEkle.Text != "" && tbKisiEkle.Text != " " && tbKisiEkle.Text != null)
                {
                    lstbKisiler.Items.Add(tbKisiEkle.Text);
                    tbKisiEkle.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Bu alan boş bırakılamaz.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tanımlanamayan bir hata oluştu.");
            }
        }

        private void btnOdulEkle_Click(object sender, EventArgs e)
        {
            try
            {
                tbOdul.Text = tbOdul.Text.Trim();
                if (tbOdul.Text != "" && tbOdul.Text != " " && tbOdul.Text != null)
                {
                    lstbOduller.Items.Add(tbOdul.Text);
                    tbOdul.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Bu alan boş bırakılamaz.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tanımlanamayan bir hata oluştu.");
            }
        }

        string esyayiTut = "";
        int x = 0;
        private void btnOdulBelirle_Click(object sender, EventArgs e)
        {
            try
            {
                if (esyayiTut == "")
                {
                    if (lstbOduller.Items.Count < 0)
                    {
                        MessageBox.Show("Seçilecek bir ödül bulunamadı.");
                    }
                    x = rnd.Next(0, lstbOduller.Items.Count);
                    esyayiTut = lstbOduller.Items[x].ToString();
                    lblCekilecekEsya.Text = esyayiTut + "- Bu eşya için çekiliş başlıyor. Herkese Bol Şans :)";
                }
                btnOdulBelirle.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Tanımlanamyan bir hata oluştu.");
            }
            
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Eğer bu mesaj kutusunu onaylarsanız çekilişi başlatmış olursunuz. Çekilişi başlattıktan sonra kişi ve ödül ekleyemezsiniz.", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (esyayiTut == "")
                    {
                        MessageBox.Show("Lütfen öncelikle ödülü belirleyin");
                        return;
                    }
                    if (lstbKisiler.Items.Count != 0 && lstbOduller.Items.Count != 0)
                    {
                        bgwGifGoster.RunWorkerAsync();
                        btnBaslat.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Ödüllerin ve çekilişe katılacak kişilerin olduğu alanlar boş bırakılamaz.");
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tanımlanamayan bir hata oluştu!");
            }
        }

        string isimTut = "";
        private void bgwGifGoster_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                pbEfekt.Image = Cekilis.Properties.Resources.fuse;
                pbEfekt.SizeMode = PictureBoxSizeMode.StretchImage;
                Thread.Sleep(4000);

                int indexTut = rnd.Next(0, lstbKisiler.Items.Count);

                isimTut = lstbKisiler.Items[indexTut].ToString();

                lstbKisiler.Items.RemoveAt(indexTut);
                lblCekilecekEsya.Text = "Ödülümüz sahibini bulmuştur.";
                
                lstbOduller.Items.RemoveAt(x);
                
                pbEfekt.Image = Cekilis.Properties.Resources.firework;
                pbEfekt.SizeMode = PictureBoxSizeMode.StretchImage;

                lstbKazananlar.Items.Add(esyayiTut + " - " + isimTut);

                esyayiTut = "";
                btnOdulBelirle.Enabled = true;
                btnBaslat.Enabled = true;

                if (lstbOduller.Items.Count == 0)
                {
                    btnBaslat.Enabled = false;
                    btnOdulBelirle.Enabled = false;
                    btnKisiEkle.Enabled = false;
                    btnOdulEkle.Enabled = false;
                    tbKisiEkle.Enabled = false;
                    tbOdul.Enabled = false;
                }
            }
            catch (Exception)
            {
                pbEfekt.Image = Cekilis.Properties.Resources.fuse;
                pbEfekt.SizeMode = PictureBoxSizeMode.StretchImage;
                MessageBox.Show("Bir hata oluştu. Eksiksiz bilgi girdiğinizi kontrol ediniz.");
            }
        }
    }
}
