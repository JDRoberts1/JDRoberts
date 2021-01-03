
namespace JeanaiROberts_CE01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbUserInput = new System.Windows.Forms.GroupBox();
            this.rdoBlueText = new System.Windows.Forms.RadioButton();
            this.rdoRedText = new System.Windows.Forms.RadioButton();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.chkbSeen = new System.Windows.Forms.CheckBox();
            this.txtBMovieName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.bttnMove = new System.Windows.Forms.Button();
            this.gbNotSeenList = new System.Windows.Forms.GroupBox();
            this.lbNotSeen = new System.Windows.Forms.ListBox();
            this.gbSeen = new System.Windows.Forms.GroupBox();
            this.lbSeen = new System.Windows.Forms.ListBox();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbUserInput.SuspendLayout();
            this.gbNotSeenList.SuspendLayout();
            this.gbSeen.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(51, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 998);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(356, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 928);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbUserInput);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 873);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbNotSeenList);
            this.tabPage2.Controls.Add(this.gbSeen);
            this.tabPage2.Controls.Add(this.bttnDelete);
            this.tabPage2.Controls.Add(this.bttnEdit);
            this.tabPage2.Controls.Add(this.bttnMove);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 881);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbUserInput
            // 
            this.gbUserInput.Controls.Add(this.label2);
            this.gbUserInput.Controls.Add(this.rdoBlueText);
            this.gbUserInput.Controls.Add(this.rdoRedText);
            this.gbUserInput.Controls.Add(this.bttnAdd);
            this.gbUserInput.Controls.Add(this.chkbSeen);
            this.gbUserInput.Controls.Add(this.txtBMovieName);
            this.gbUserInput.Controls.Add(this.label1);
            this.gbUserInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUserInput.Location = new System.Drawing.Point(3, 3);
            this.gbUserInput.Name = "gbUserInput";
            this.gbUserInput.Size = new System.Drawing.Size(580, 867);
            this.gbUserInput.TabIndex = 3;
            this.gbUserInput.TabStop = false;
            this.gbUserInput.Text = "Movie Input";
            // 
            // rdoBlueText
            // 
            this.rdoBlueText.AutoSize = true;
            this.rdoBlueText.Location = new System.Drawing.Point(275, 432);
            this.rdoBlueText.Name = "rdoBlueText";
            this.rdoBlueText.Size = new System.Drawing.Size(134, 29);
            this.rdoBlueText.TabIndex = 8;
            this.rdoBlueText.TabStop = true;
            this.rdoBlueText.Text = "Blue Text";
            this.rdoBlueText.UseVisualStyleBackColor = true;
            // 
            // rdoRedText
            // 
            this.rdoRedText.AutoSize = true;
            this.rdoRedText.Location = new System.Drawing.Point(275, 378);
            this.rdoRedText.Name = "rdoRedText";
            this.rdoRedText.Size = new System.Drawing.Size(130, 29);
            this.rdoRedText.TabIndex = 7;
            this.rdoRedText.TabStop = true;
            this.rdoRedText.Text = "Red Text";
            this.rdoRedText.UseVisualStyleBackColor = true;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(191, 572);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(161, 52);
            this.bttnAdd.TabIndex = 3;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = true;
            // 
            // chkbSeen
            // 
            this.chkbSeen.AutoSize = true;
            this.chkbSeen.Location = new System.Drawing.Point(206, 258);
            this.chkbSeen.Name = "chkbSeen";
            this.chkbSeen.Size = new System.Drawing.Size(159, 29);
            this.chkbSeen.TabIndex = 2;
            this.chkbSeen.Text = "Have seen?";
            this.chkbSeen.UseVisualStyleBackColor = true;
            // 
            // txtBMovieName
            // 
            this.txtBMovieName.Location = new System.Drawing.Point(275, 139);
            this.txtBMovieName.Name = "txtBMovieName";
            this.txtBMovieName.Size = new System.Drawing.Size(199, 31);
            this.txtBMovieName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select text color";
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(387, 762);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(161, 60);
            this.bttnDelete.TabIndex = 14;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = true;
            // 
            // bttnEdit
            // 
            this.bttnEdit.Location = new System.Drawing.Point(207, 765);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(161, 55);
            this.bttnEdit.TabIndex = 13;
            this.bttnEdit.Text = "Edit";
            this.bttnEdit.UseVisualStyleBackColor = true;
            // 
            // bttnMove
            // 
            this.bttnMove.Location = new System.Drawing.Point(25, 767);
            this.bttnMove.Name = "bttnMove";
            this.bttnMove.Size = new System.Drawing.Size(161, 51);
            this.bttnMove.TabIndex = 12;
            this.bttnMove.Text = "Move";
            this.bttnMove.UseVisualStyleBackColor = true;
            // 
            // gbNotSeenList
            // 
            this.gbNotSeenList.Controls.Add(this.lbNotSeen);
            this.gbNotSeenList.Location = new System.Drawing.Point(12, 365);
            this.gbNotSeenList.Name = "gbNotSeenList";
            this.gbNotSeenList.Size = new System.Drawing.Size(574, 359);
            this.gbNotSeenList.TabIndex = 18;
            this.gbNotSeenList.TabStop = false;
            this.gbNotSeenList.Text = "Not Seen Movie List";
            // 
            // lbNotSeen
            // 
            this.lbNotSeen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNotSeen.FormattingEnabled = true;
            this.lbNotSeen.ItemHeight = 25;
            this.lbNotSeen.Location = new System.Drawing.Point(3, 27);
            this.lbNotSeen.Name = "lbNotSeen";
            this.lbNotSeen.Size = new System.Drawing.Size(568, 329);
            this.lbNotSeen.TabIndex = 0;
            // 
            // gbSeen
            // 
            this.gbSeen.Controls.Add(this.lbSeen);
            this.gbSeen.Location = new System.Drawing.Point(9, 13);
            this.gbSeen.Name = "gbSeen";
            this.gbSeen.Size = new System.Drawing.Size(577, 337);
            this.gbSeen.TabIndex = 17;
            this.gbSeen.TabStop = false;
            this.gbSeen.Text = "Seen Movie List";
            // 
            // lbSeen
            // 
            this.lbSeen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSeen.FormattingEnabled = true;
            this.lbSeen.ItemHeight = 25;
            this.lbSeen.Location = new System.Drawing.Point(3, 27);
            this.lbSeen.Name = "lbSeen";
            this.lbSeen.Size = new System.Drawing.Size(571, 307);
            this.lbSeen.TabIndex = 0;
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::JeanaiROberts_CE01.Properties.Resources.iPhone7Image__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 1280);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gbUserInput.ResumeLayout(false);
            this.gbUserInput.PerformLayout();
            this.gbNotSeenList.ResumeLayout(false);
            this.gbSeen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbUserInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoBlueText;
        private System.Windows.Forms.RadioButton rdoRedText;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.CheckBox chkbSeen;
        private System.Windows.Forms.TextBox txtBMovieName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnEdit;
        private System.Windows.Forms.Button bttnMove;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbNotSeenList;
        private System.Windows.Forms.ListBox lbNotSeen;
        private System.Windows.Forms.GroupBox gbSeen;
        private System.Windows.Forms.ListBox lbSeen;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    }
}

