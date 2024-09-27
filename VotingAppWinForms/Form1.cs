using System;
using System.Windows.Forms;

namespace VotingAppWinForms
{
    public partial class Form1 : Form
    {
        Vote voting;
        public Form1()
        {
            InitializeComponent();
            voting = new Vote();
            // Kategorileri ListBox'a ekleyelim
            foreach (var category in voting.GetCategories().Keys)
            {
                listBoxCategories.Items.Add(category);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (!User.IsUserRegistered(username))
            {
                User.RegisterUser(username);
                MessageBox.Show($"{username} başarıyla kayıt edildi!", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{username} zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (!User.IsUserRegistered(username))
            {
                MessageBox.Show("Lütfen önce kayıt olun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listBoxCategories.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kategori seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedCategory = listBoxCategories.SelectedItem.ToString();
            voting.CastVote(selectedCategory);
            MessageBox.Show($"{selectedCategory} kategorisine oy verildi.", "Oylama Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnShowResults_Click(object sender, EventArgs e)
        {
            string results = voting.GetResults();
            MessageBox.Show(results, "Oylama Sonuçları", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
