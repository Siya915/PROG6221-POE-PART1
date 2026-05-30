namespace CyberSecurityBotGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox richTextBoxChat;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.richTextBoxChat = new System.Windows.Forms.RichTextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Cyan;
            this.labelTitle.Location = new System.Drawing.Point(60, 20);
            this.labelTitle.Text = "CYBERSECURITY CHATBOT";

            this.richTextBoxChat.BackColor = System.Drawing.Color.Black;
            this.richTextBoxChat.ForeColor = System.Drawing.Color.White;
            this.richTextBoxChat.Location = new System.Drawing.Point(30, 80);
            this.richTextBoxChat.Size = new System.Drawing.Size(520, 280);

            this.textBoxInput.Location = new System.Drawing.Point(30, 380);
            this.textBoxInput.Size = new System.Drawing.Size(390, 22);

            this.buttonSend.BackColor = System.Drawing.Color.Cyan;
            this.buttonSend.Location = new System.Drawing.Point(440, 375);
            this.buttonSend.Size = new System.Drawing.Size(110, 30);
            this.buttonSend.Text = "Send";
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);

            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.richTextBoxChat);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonSend);
            this.Text = "Cybersecurity Awareness Bot";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}