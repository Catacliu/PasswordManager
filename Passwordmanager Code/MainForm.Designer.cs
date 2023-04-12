
namespace PasswordManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip = new System.Windows.Forms.MenuStrip();
            menuFile = new System.Windows.Forms.ToolStripMenuItem();
            menuNewDatabase = new System.Windows.Forms.ToolStripMenuItem();
            menuOpenDatabase = new System.Windows.Forms.ToolStripMenuItem();
            menuCloseDatabase = new System.Windows.Forms.ToolStripMenuItem();
            menuSaveDatabase = new System.Windows.Forms.ToolStripMenuItem();
            menuLockDatabase = new System.Windows.Forms.ToolStripMenuItem();
            menuExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            menuEntry = new System.Windows.Forms.ToolStripMenuItem();
            menuAddEntry = new System.Windows.Forms.ToolStripMenuItem();
            menuCopyUsername = new System.Windows.Forms.ToolStripMenuItem();
            menuCopyPassword = new System.Windows.Forms.ToolStripMenuItem();
            DtgEntries = new System.Windows.Forms.DataGridView();
            contextMenuDtg = new System.Windows.Forms.ContextMenuStrip(components);
            contextMenuCopyUsername = new System.Windows.Forms.ToolStripMenuItem();
            contextMenuCopyPassword = new System.Windows.Forms.ToolStripMenuItem();
            contextMenuAddEntry = new System.Windows.Forms.ToolStripMenuItem();
            contextMenuEditEntry = new System.Windows.Forms.ToolStripMenuItem();
            contextMenuDeleteEntry = new System.Windows.Forms.ToolStripMenuItem();
            notifyIcon = new System.Windows.Forms.NotifyIcon(components);
            contextMenuNotify = new System.Windows.Forms.ContextMenuStrip(components);
            contextMenuLockDatabase = new System.Windows.Forms.ToolStripMenuItem();
            contextMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgEntries).BeginInit();
            contextMenuDtg.SuspendLayout();
            contextMenuNotify.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { menuFile, menuEntry });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new System.Drawing.Size(784, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuNewDatabase, menuOpenDatabase, menuCloseDatabase, menuSaveDatabase, menuLockDatabase, menuExitApplication });
            menuFile.Name = "menuFile";
            menuFile.Size = new System.Drawing.Size(54, 20);
            menuFile.Text = "Fichier";
            menuFile.DropDownOpening += MenuFileOpening;
            // 
            // menuNewDatabase
            // 
            menuNewDatabase.Name = "menuNewDatabase";
            menuNewDatabase.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            menuNewDatabase.Size = new System.Drawing.Size(263, 22);
            menuNewDatabase.Text = "Nouveau";
            menuNewDatabase.Click += NewDatabase;
            // 
            // menuOpenDatabase
            // 
            menuOpenDatabase.Name = "menuOpenDatabase";
            menuOpenDatabase.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            menuOpenDatabase.Size = new System.Drawing.Size(263, 22);
            menuOpenDatabase.Text = "Ouvrir";
            menuOpenDatabase.Click += OpenDatabase;
            // 
            // menuCloseDatabase
            // 
            menuCloseDatabase.Name = "menuCloseDatabase";
            menuCloseDatabase.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W;
            menuCloseDatabase.Size = new System.Drawing.Size(263, 22);
            menuCloseDatabase.Text = "Fermer";
            menuCloseDatabase.Click += CloseDatabase;
            // 
            // menuSaveDatabase
            // 
            menuSaveDatabase.Name = "menuSaveDatabase";
            menuSaveDatabase.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            menuSaveDatabase.Size = new System.Drawing.Size(263, 22);
            menuSaveDatabase.Text = "Enregistrer";
            menuSaveDatabase.Click += SaveDatabase;
            // 
            // menuLockDatabase
            // 
            menuLockDatabase.Name = "menuLockDatabase";
            menuLockDatabase.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L;
            menuLockDatabase.Size = new System.Drawing.Size(263, 22);
            menuLockDatabase.Text = "Verrouiller l'espace de travail";
            menuLockDatabase.Click += LockDatabase;
            // 
            // menuExitApplication
            // 
            menuExitApplication.Name = "menuExitApplication";
            menuExitApplication.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q;
            menuExitApplication.Size = new System.Drawing.Size(263, 22);
            menuExitApplication.Text = "Quitter";
            menuExitApplication.Click += ExitApplication;
            // 
            // menuEntry
            // 
            menuEntry.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuAddEntry, menuCopyUsername, menuCopyPassword });
            menuEntry.Name = "menuEntry";
            menuEntry.Size = new System.Drawing.Size(52, 20);
            menuEntry.Text = "Entrée";
            menuEntry.DropDownOpening += MenuEntryOpening;
            // 
            // menuAddEntry
            // 
            menuAddEntry.Name = "menuAddEntry";
            menuAddEntry.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I;
            menuAddEntry.Size = new System.Drawing.Size(258, 22);
            menuAddEntry.Text = "Ajouter une entrée";
            menuAddEntry.Click += AddEntry;
            // 
            // menuCopyUsername
            // 
            menuCopyUsername.Name = "menuCopyUsername";
            menuCopyUsername.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B;
            menuCopyUsername.Size = new System.Drawing.Size(258, 22);
            menuCopyUsername.Text = "Copier le nom  d'utilisateur";
            menuCopyUsername.Click += CopyUsername;
            // 
            // menuCopyPassword
            // 
            menuCopyPassword.Name = "menuCopyPassword";
            menuCopyPassword.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C;
            menuCopyPassword.Size = new System.Drawing.Size(258, 22);
            menuCopyPassword.Text = "Copier le mot de passe";
            menuCopyPassword.Click += CopyPassword;
            // 
            // DtgEntries
            // 
            DtgEntries.AllowUserToAddRows = false;
            DtgEntries.AllowUserToDeleteRows = false;
            DtgEntries.AllowUserToResizeRows = false;
            DtgEntries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DtgEntries.BackgroundColor = System.Drawing.Color.White;
            DtgEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgEntries.ContextMenuStrip = contextMenuDtg;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            DtgEntries.DefaultCellStyle = dataGridViewCellStyle1;
            DtgEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            DtgEntries.Location = new System.Drawing.Point(0, 24);
            DtgEntries.Name = "DtgEntries";
            DtgEntries.ReadOnly = true;
            DtgEntries.RowTemplate.Height = 25;
            DtgEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DtgEntries.ShowCellToolTips = false;
            DtgEntries.ShowEditingIcon = false;
            DtgEntries.Size = new System.Drawing.Size(784, 537);
            DtgEntries.TabIndex = 1;
            DtgEntries.CellFormatting += DtgEntriesCellFormatting;
            // 
            // contextMenuDtg
            // 
            contextMenuDtg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { contextMenuCopyUsername, contextMenuCopyPassword, contextMenuAddEntry, contextMenuEditEntry, contextMenuDeleteEntry });
            contextMenuDtg.Name = "contextMenuDtg";
            contextMenuDtg.Size = new System.Drawing.Size(215, 136);
            // 
            // contextMenuCopyUsername
            // 
            contextMenuCopyUsername.Name = "contextMenuCopyUsername";
            contextMenuCopyUsername.Size = new System.Drawing.Size(214, 22);
            contextMenuCopyUsername.Text = "Copier le nom d'utilisateur";
            contextMenuCopyUsername.Click += CopyUsername;
            // 
            // contextMenuCopyPassword
            // 
            contextMenuCopyPassword.Name = "contextMenuCopyPassword";
            contextMenuCopyPassword.Size = new System.Drawing.Size(214, 22);
            contextMenuCopyPassword.Text = "Copier le mot de passe";
            contextMenuCopyPassword.Click += CopyPassword;
            // 
            // contextMenuAddEntry
            // 
            contextMenuAddEntry.Name = "contextMenuAddEntry";
            contextMenuAddEntry.Size = new System.Drawing.Size(214, 22);
            contextMenuAddEntry.Text = "Ajouter une entrée";
            contextMenuAddEntry.Click += AddEntry;
            // 
            // contextMenuEditEntry
            // 
            contextMenuEditEntry.Name = "contextMenuEditEntry";
            contextMenuEditEntry.Size = new System.Drawing.Size(214, 22);
            contextMenuEditEntry.Text = "Modifier l'entrée";
            contextMenuEditEntry.Click += EditEntry;
            // 
            // contextMenuDeleteEntry
            // 
            contextMenuDeleteEntry.Name = "contextMenuDeleteEntry";
            contextMenuDeleteEntry.Size = new System.Drawing.Size(214, 22);
            contextMenuDeleteEntry.Text = "Supprimer l'entrée";
            contextMenuDeleteEntry.Click += DeleteEntry;
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = contextMenuNotify;
            notifyIcon.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "MyPasswordManager";
            notifyIcon.Visible = true;
            // 
            // contextMenuNotify
            // 
            contextMenuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { contextMenuLockDatabase, contextMenuExit });
            contextMenuNotify.Name = "contextMenuNotify";
            contextMenuNotify.Size = new System.Drawing.Size(224, 48);
            contextMenuNotify.Opening += contextMenuNotifyOpening;
            // 
            // contextMenuLockDatabase
            // 
            contextMenuLockDatabase.Name = "contextMenuLockDatabase";
            contextMenuLockDatabase.Size = new System.Drawing.Size(223, 22);
            contextMenuLockDatabase.Text = "Verrouiller l'espace de travail";
            contextMenuLockDatabase.Click += LockDatabase;
            // 
            // contextMenuExit
            // 
            contextMenuExit.Name = "contextMenuExit";
            contextMenuExit.Size = new System.Drawing.Size(223, 22);
            contextMenuExit.Text = "Quitter";
            contextMenuExit.Click += ExitApplication;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(784, 561);
            Controls.Add(DtgEntries);
            Controls.Add(menuStrip);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MyPasswordManager";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtgEntries).EndInit();
            contextMenuDtg.ResumeLayout(false);
            contextMenuNotify.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNewDatabase;
        private System.Windows.Forms.ToolStripMenuItem menuOpenDatabase;
        private System.Windows.Forms.ToolStripMenuItem menuCloseDatabase;
        private System.Windows.Forms.ToolStripMenuItem menuSaveDatabase;
        private System.Windows.Forms.ToolStripMenuItem menuLockDatabase;
        private System.Windows.Forms.ToolStripMenuItem menuExitApplication;
        private System.Windows.Forms.ToolStripMenuItem menuEntry;
        private System.Windows.Forms.ToolStripMenuItem menuAddEntry;
        private System.Windows.Forms.ToolStripMenuItem menuCopyUsername;
        private System.Windows.Forms.ToolStripMenuItem menuCopyPassword;
        private System.Windows.Forms.DataGridView DtgEntries;
        private System.Windows.Forms.ContextMenuStrip contextMenuDtg;
        private System.Windows.Forms.ToolStripMenuItem contextMenuCopyUsername;
        private System.Windows.Forms.ToolStripMenuItem contextMenuCopyPassword;
        private System.Windows.Forms.ToolStripMenuItem contextMenuAddEntry;
        private System.Windows.Forms.ToolStripMenuItem contextMenuEditEntry;
        private System.Windows.Forms.ToolStripMenuItem contextMenuDeleteEntry;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuNotify;
        private System.Windows.Forms.ToolStripMenuItem contextMenuLockDatabase;
        private System.Windows.Forms.ToolStripMenuItem contextMenuExit;
    }
}
