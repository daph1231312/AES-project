namespace balls
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Plaintxt = new System.Windows.Forms.Label();
            this.Keytxt = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Plaintextbox = new System.Windows.Forms.TextBox();
            this.Keytextbox = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.ModeComboBox = new System.Windows.Forms.ComboBox();
            this.KeyLengthComboBox = new System.Windows.Forms.ComboBox();
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            this.Resulttxt = new System.Windows.Forms.Label();
            this.Optiontxt = new System.Windows.Forms.Label();
            this.Modeopt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Plaintxt
            // 
            this.Plaintxt.AutoSize = true;
            this.Plaintxt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plaintxt.Location = new System.Drawing.Point(88, 80);
            this.Plaintxt.Name = "Plaintxt";
            this.Plaintxt.Size = new System.Drawing.Size(241, 50);
            this.Plaintxt.TabIndex = 0;
            this.Plaintxt.Text = "Plain Text:";
            // 
            // Keytxt
            // 
            this.Keytxt.AutoSize = true;
            this.Keytxt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keytxt.Location = new System.Drawing.Point(88, 169);
            this.Keytxt.Name = "Keytxt";
            this.Keytxt.Size = new System.Drawing.Size(116, 50);
            this.Keytxt.TabIndex = 1;
            this.Keytxt.Text = "Key:";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Brown;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(413, 745);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(207, 79);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Plaintextbox
            // 
            this.Plaintextbox.BackColor = System.Drawing.Color.Snow;
            this.Plaintextbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plaintextbox.Location = new System.Drawing.Point(408, 80);
            this.Plaintextbox.Name = "Plaintextbox";
            this.Plaintextbox.Size = new System.Drawing.Size(316, 57);
            this.Plaintextbox.TabIndex = 3;
            // 
            // Keytextbox
            // 
            this.Keytextbox.BackColor = System.Drawing.Color.Snow;
            this.Keytextbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keytextbox.Location = new System.Drawing.Point(408, 162);
            this.Keytextbox.Name = "Keytextbox";
            this.Keytextbox.Size = new System.Drawing.Size(316, 57);
            this.Keytextbox.TabIndex = 4;
            // 
            // EncryptButton
            // 
            this.EncryptButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.EncryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptButton.Location = new System.Drawing.Point(408, 311);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(212, 70);
            this.EncryptButton.TabIndex = 5;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = false;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DecryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecryptButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptButton.Location = new System.Drawing.Point(657, 311);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(212, 70);
            this.DecryptButton.TabIndex = 6;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = false;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // ModeComboBox
            // 
            this.ModeComboBox.AllowDrop = true;
            this.ModeComboBox.BackColor = System.Drawing.Color.Azure;
            this.ModeComboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeComboBox.FormattingEnabled = true;
            this.ModeComboBox.Location = new System.Drawing.Point(437, 459);
            this.ModeComboBox.Name = "ModeComboBox";
            this.ModeComboBox.Size = new System.Drawing.Size(183, 41);
            this.ModeComboBox.TabIndex = 7;
            // 
            // KeyLengthComboBox
            // 
            this.KeyLengthComboBox.AllowDrop = true;
            this.KeyLengthComboBox.BackColor = System.Drawing.Color.Azure;
            this.KeyLengthComboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyLengthComboBox.FormattingEnabled = true;
            this.KeyLengthComboBox.Location = new System.Drawing.Point(437, 557);
            this.KeyLengthComboBox.Name = "KeyLengthComboBox";
            this.KeyLengthComboBox.Size = new System.Drawing.Size(183, 41);
            this.KeyLengthComboBox.TabIndex = 8;
            // 
            // ResultTextbox
            // 
            this.ResultTextbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextbox.Location = new System.Drawing.Point(876, 617);
            this.ResultTextbox.Multiline = true;
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.ReadOnly = true;
            this.ResultTextbox.Size = new System.Drawing.Size(263, 31);
            this.ResultTextbox.TabIndex = 9;
            // 
            // Resulttxt
            // 
            this.Resulttxt.AutoSize = true;
            this.Resulttxt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resulttxt.Location = new System.Drawing.Point(880, 525);
            this.Resulttxt.Name = "Resulttxt";
            this.Resulttxt.Size = new System.Drawing.Size(168, 50);
            this.Resulttxt.TabIndex = 10;
            this.Resulttxt.Text = "Result:";
            // 
            // Optiontxt
            // 
            this.Optiontxt.AutoSize = true;
            this.Optiontxt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Optiontxt.Location = new System.Drawing.Point(88, 321);
            this.Optiontxt.Name = "Optiontxt";
            this.Optiontxt.Size = new System.Drawing.Size(198, 50);
            this.Optiontxt.TabIndex = 11;
            this.Optiontxt.Text = "Options:";
            // 
            // Modeopt
            // 
            this.Modeopt.AutoSize = true;
            this.Modeopt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modeopt.Location = new System.Drawing.Point(97, 459);
            this.Modeopt.Name = "Modeopt";
            this.Modeopt.Size = new System.Drawing.Size(173, 50);
            this.Modeopt.TabIndex = 12;
            this.Modeopt.Text = "Modes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 50);
            this.label3.TabIndex = 13;
            this.label3.Text = "Key Lengths:";
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadFileButton.Location = new System.Drawing.Point(920, 305);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(128, 90);
            this.LoadFileButton.TabIndex = 14;
            this.LoadFileButton.Text = "Load File";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1296, 856);
            this.Controls.Add(this.LoadFileButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Modeopt);
            this.Controls.Add(this.Optiontxt);
            this.Controls.Add(this.Resulttxt);
            this.Controls.Add(this.ResultTextbox);
            this.Controls.Add(this.KeyLengthComboBox);
            this.Controls.Add(this.ModeComboBox);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.Keytextbox);
            this.Controls.Add(this.Plaintextbox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.Keytxt);
            this.Controls.Add(this.Plaintxt);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label encryption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Plainboxx;
        private System.Windows.Forms.TextBox KeyBo;
        private System.Windows.Forms.Button exitbutt;
        private System.Windows.Forms.Button encryptionbtn;
        private System.Windows.Forms.Button decryptionbtn;
        private System.Windows.Forms.ComboBox modes;
        private System.Windows.Forms.ComboBox KEYlength;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.Label Plaintext;
        private System.Windows.Forms.Label Key;
        private System.Windows.Forms.TextBox Plainbox;
        private System.Windows.Forms.TextBox KeyBoxx;
        private System.Windows.Forms.Label Plaintxt;
        private System.Windows.Forms.Label Keytxt;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox Plaintextbox;
        private System.Windows.Forms.TextBox Keytextbox;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.ComboBox ModeComboBox;
        private System.Windows.Forms.ComboBox KeyLengthComboBox;
        private System.Windows.Forms.TextBox ResultTextbox;
        private System.Windows.Forms.Label Resulttxt;
        private System.Windows.Forms.Label Optiontxt;
        private System.Windows.Forms.Label Modeopt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoadFileButton;
    }
}

