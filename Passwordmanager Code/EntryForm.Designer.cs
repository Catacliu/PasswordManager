
namespace PasswordManager
{
    partial class EntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            btnAccept = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tbxLink = new System.Windows.Forms.TextBox();
            tbxConfirm = new System.Windows.Forms.TextBox();
            tbxPassword = new System.Windows.Forms.TextBox();
            tbxUsername = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            btnTogglePasswordChar = new System.Windows.Forms.Button();
            tbxTitle = new System.Windows.Forms.TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAccept
            // 
            btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnAccept.Location = new System.Drawing.Point(198, 396);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new System.Drawing.Size(75, 23);
            btnAccept.TabIndex = 5;
            btnAccept.Text = "OK";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += Accept;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(279, 396);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.92617F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.07383F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            tableLayoutPanel1.Controls.Add(tbxLink, 1, 4);
            tableLayoutPanel1.Controls.Add(tbxConfirm, 1, 3);
            tableLayoutPanel1.Controls.Add(tbxPassword, 1, 2);
            tableLayoutPanel1.Controls.Add(tbxUsername, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(btnTogglePasswordChar, 2, 2);
            tableLayoutPanel1.Controls.Add(tbxTitle, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(342, 378);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // tbxLink
            // 
            tbxLink.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbxLink.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            tbxLink.Location = new System.Drawing.Point(117, 327);
            tbxLink.Name = "tbxLink";
            tbxLink.Size = new System.Drawing.Size(174, 23);
            tbxLink.TabIndex = 4;
            // 
            // tbxConfirm
            // 
            tbxConfirm.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbxConfirm.Location = new System.Drawing.Point(117, 251);
            tbxConfirm.Name = "tbxConfirm";
            tbxConfirm.Size = new System.Drawing.Size(174, 23);
            tbxConfirm.TabIndex = 3;
            tbxConfirm.UseSystemPasswordChar = true;
            // 
            // tbxPassword
            // 
            tbxPassword.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbxPassword.Location = new System.Drawing.Point(117, 176);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new System.Drawing.Size(174, 23);
            tbxPassword.TabIndex = 2;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // tbxUsername
            // 
            tbxUsername.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbxUsername.Location = new System.Drawing.Point(117, 101);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new System.Drawing.Size(174, 23);
            tbxUsername.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 105);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(108, 15);
            label3.TabIndex = 2;
            label3.Text = "Nom d'utilisateur :";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Titre :";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(3, 180);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(108, 15);
            label4.TabIndex = 3;
            label4.Text = "Mot de passe :";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 255);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(108, 15);
            label2.TabIndex = 1;
            label2.Text = "Confirmation :";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 331);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(108, 15);
            label5.TabIndex = 4;
            label5.Text = "Adresse (URL) :";
            // 
            // btnTogglePasswordChar
            // 
            btnTogglePasswordChar.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnTogglePasswordChar.Location = new System.Drawing.Point(297, 176);
            btnTogglePasswordChar.Name = "btnTogglePasswordChar";
            btnTogglePasswordChar.Size = new System.Drawing.Size(42, 23);
            btnTogglePasswordChar.TabIndex = 7;
            btnTogglePasswordChar.Text = "***";
            btnTogglePasswordChar.UseVisualStyleBackColor = true;
            btnTogglePasswordChar.Click += TogglePasswordChar;
            // 
            // tbxTitle
            // 
            tbxTitle.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbxTitle.Location = new System.Drawing.Point(117, 26);
            tbxTitle.Name = "tbxTitle";
            tbxTitle.Size = new System.Drawing.Size(174, 23);
            tbxTitle.TabIndex = 0;
            // 
            // EntryForm
            // 
            AcceptButton = btnAccept;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(366, 431);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnAccept);
            Controls.Add(btnCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EntryForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Ajouter un entrée";
            FormClosing += OnFormClosing;
            Load += OnFormLoad;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTogglePasswordChar;
        private System.Windows.Forms.TextBox tbxLink;
        private System.Windows.Forms.TextBox tbxConfirm;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxTitle;
    }
}