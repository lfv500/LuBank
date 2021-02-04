
namespace LuBank.Presentation.WinForm
{
    partial class FormMain
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegistrations = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegistrationsCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmRegistrations});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(708, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "mainMenu";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFileClose});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(61, 20);
            this.tsmFile.Text = "Arquivo";
            // 
            // tsmFileClose
            // 
            this.tsmFileClose.Name = "tsmFileClose";
            this.tsmFileClose.Size = new System.Drawing.Size(109, 22);
            this.tsmFileClose.Text = "Fechar";
            this.tsmFileClose.Click += new System.EventHandler(this.tsmFileClose_Click);
            // 
            // tsmRegistrations
            // 
            this.tsmRegistrations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRegistrationsCustomer});
            this.tsmRegistrations.Name = "tsmRegistrations";
            this.tsmRegistrations.Size = new System.Drawing.Size(71, 20);
            this.tsmRegistrations.Text = "Cadastros";
            // 
            // tsmRegistrationsCustomer
            // 
            this.tsmRegistrationsCustomer.Name = "tsmRegistrationsCustomer";
            this.tsmRegistrationsCustomer.Size = new System.Drawing.Size(182, 22);
            this.tsmRegistrationsCustomer.Text = "Cadastro de Clientes";
            this.tsmRegistrationsCustomer.Click += new System.EventHandler(this.tsmRegistrationsCustomer_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FormMain";
            this.Text = "LuBank - Application";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmFileClose;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistrations;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistrationsCustomer;
    }
}

