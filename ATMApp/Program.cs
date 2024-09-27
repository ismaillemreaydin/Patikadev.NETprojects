using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ATMApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }

    public class LoginForm : Form
    {
        private TextBox userIdTextBox;
        private TextBox pinTextBox;
        private Button loginButton;
        private Label userIdLabel;
        private Label pinLabel;

        // Hatalı giriş denemeleri için bir log listesi oluşturuyoruz.
        private static List<string> failedLoginAttempts = new List<string>();

        public LoginForm()
        {
            userIdLabel = new Label() { Left = 50, Top = 20, Text = "Kullanıcı ID:" };
            userIdTextBox = new TextBox() { Left = 150, Top = 20, Width = 100 };

            pinLabel = new Label() { Left = 50, Top = 50, Text = "PIN:" };
            pinTextBox = new TextBox() { Left = 150, Top = 50, Width = 100, PasswordChar = '*' };

            loginButton = new Button() { Text = "Giriş", Left = 150, Top = 80, Width = 100 };
            loginButton.Click += new EventHandler(LoginButton_Click);

            this.Controls.Add(userIdLabel);
            this.Controls.Add(userIdTextBox);
            this.Controls.Add(pinLabel);
            this.Controls.Add(pinTextBox);
            this.Controls.Add(loginButton);

            this.Text = "ATM Giriş Ekranı";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userId = userIdTextBox.Text;
            string pin = pinTextBox.Text;

            if (AuthenticateUser(userId, pin))
            {
                MessageBox.Show("Giriş Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var mainMenu = new MainMenuForm();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                failedLoginAttempts.Add($"{DateTime.Now}: Hatalı giriş - Kullanıcı ID: {userId}");
                MessageBox.Show("Geçersiz Kullanıcı ID veya PIN.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string userId, string pin)
        {
            return userId == "1" && pin == "1234"; // Örnek kullanıcı
        }

        public static List<string> GetFailedLoginAttempts()
        {
            return failedLoginAttempts;
        }
    }

    public class MainMenuForm : Form
    {
        private Button withdrawButton;
        private Button depositButton;
        private Button paymentButton;
        private Button eodButton;
        private Button logoutButton;

        // Günlük işlem logları
        private static List<string> transactionLogs = new List<string>();

        public MainMenuForm()
        {
            withdrawButton = new Button() { Text = "Para Çekme", Left = 50, Top = 20, Width = 100 };
            withdrawButton.Click += new EventHandler(WithdrawButton_Click);

            depositButton = new Button() { Text = "Para Yatırma", Left = 50, Top = 50, Width = 100 };
            depositButton.Click += new EventHandler(DepositButton_Click);

            paymentButton = new Button() { Text = "Ödeme Yapma", Left = 50, Top = 80, Width = 100 };
            paymentButton.Click += new EventHandler(PaymentButton_Click);

            eodButton = new Button() { Text = "Gün Sonu", Left = 50, Top = 110, Width = 100 };
            eodButton.Click += new EventHandler(EODButton_Click);

            logoutButton = new Button() { Text = "Çıkış", Left = 50, Top = 140, Width = 100 };
            logoutButton.Click += new EventHandler(LogoutButton_Click);

            this.Controls.Add(withdrawButton);
            this.Controls.Add(depositButton);
            this.Controls.Add(paymentButton);
            this.Controls.Add(eodButton);
            this.Controls.Add(logoutButton);

            this.Text = "ATM Ana Menü";
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            transactionLogs.Add($"{DateTime.Now}: Para çekme işlemi yapıldı.");
            MessageBox.Show("Para Çekme işlemi yapıldı.", "Bilgi");
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            transactionLogs.Add($"{DateTime.Now}: Para yatırma işlemi yapıldı.");
            MessageBox.Show("Para Yatırma işlemi yapıldı.", "Bilgi");
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            transactionLogs.Add($"{DateTime.Now}: Ödeme işlemi yapıldı.");
            MessageBox.Show("Ödeme işlemi yapıldı.", "Bilgi");
        }

        private void EODButton_Click(object sender, EventArgs e)
        {
            // Gün sonu işlemi
            string filePath = $"EOD_{DateTime.Now.ToString("ddMMyyyy")}.txt";
            List<string> failedLogins = LoginForm.GetFailedLoginAttempts();

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Günlük İşlem Logları:");
                foreach (var log in transactionLogs)
                {
                    writer.WriteLine(log);
                }

                writer.WriteLine("\nHatalı Giriş Denemeleri:");
                foreach (var log in failedLogins)
                {
                    writer.WriteLine(log);
                }
            }

            MessageBox.Show($"Gün sonu raporu kaydedildi: {filePath}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
