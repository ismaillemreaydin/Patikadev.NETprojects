namespace VotingAppWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Button btnShowResults;

        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.btnVote = new System.Windows.Forms.Button();
            this.btnShowResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // Username TextBox
            this.txtUsername.Location = new System.Drawing.Point(30, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 23);
            
            // Register Button
            this.btnRegister.Location = new System.Drawing.Point(240, 30);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            
            // ListBox (Categories)
            this.listBoxCategories.Location = new System.Drawing.Point(30, 70);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(200, 95);
            
            // Vote Button
            this.btnVote.Location = new System.Drawing.Point(240, 70);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(75, 23);
            this.btnVote.Text = "Oy Ver";
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            
            // Show Results Button
            this.btnShowResults.Location = new System.Drawing.Point(240, 110);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(75, 23);
            this.btnShowResults.Text = "Sonuçlar";
            this.btnShowResults.Click += new System.EventHandler(this.btnShowResults_Click);
            
            // Form1
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.listBoxCategories);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.btnShowResults);
            this.Name = "Form1";
            this.Text = "Oylama Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
