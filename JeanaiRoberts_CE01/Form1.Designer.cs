
namespace JeanaiRoberts_CE01
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbNotComplete = new System.Windows.Forms.GroupBox();
            this.lbNotTaken = new System.Windows.Forms.ListBox();
            this.gbCompleteCourses = new System.Windows.Forms.GroupBox();
            this.lbComplete = new System.Windows.Forms.ListBox();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.bttnMove = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbNotComplete.SuspendLayout();
            this.gbCompleteCourses.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(605, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(280, 44);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(280, 44);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(280, 44);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.bttnDelete);
            this.groupBox1.Controls.Add(this.gbNotComplete);
            this.groupBox1.Controls.Add(this.bttnEdit);
            this.groupBox1.Controls.Add(this.gbCompleteCourses);
            this.groupBox1.Controls.Add(this.bttnMove);
            this.groupBox1.Controls.Add(this.bttnAdd);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(57, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 999);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // gbNotComplete
            // 
            this.gbNotComplete.Controls.Add(this.lbNotTaken);
            this.gbNotComplete.Location = new System.Drawing.Point(3, 98);
            this.gbNotComplete.Name = "gbNotComplete";
            this.gbNotComplete.Size = new System.Drawing.Size(593, 357);
            this.gbNotComplete.TabIndex = 4;
            this.gbNotComplete.TabStop = false;
            this.gbNotComplete.Text = "Non-Complete Courses";
            // 
            // lbNotTaken
            // 
            this.lbNotTaken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNotTaken.FormattingEnabled = true;
            this.lbNotTaken.ItemHeight = 25;
            this.lbNotTaken.Location = new System.Drawing.Point(3, 27);
            this.lbNotTaken.Name = "lbNotTaken";
            this.lbNotTaken.Size = new System.Drawing.Size(587, 327);
            this.lbNotTaken.TabIndex = 0;
            // 
            // gbCompleteCourses
            // 
            this.gbCompleteCourses.Controls.Add(this.lbComplete);
            this.gbCompleteCourses.Location = new System.Drawing.Point(6, 469);
            this.gbCompleteCourses.Name = "gbCompleteCourses";
            this.gbCompleteCourses.Size = new System.Drawing.Size(587, 354);
            this.gbCompleteCourses.TabIndex = 3;
            this.gbCompleteCourses.TabStop = false;
            this.gbCompleteCourses.Text = "Complete Courses";
            // 
            // lbComplete
            // 
            this.lbComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbComplete.FormattingEnabled = true;
            this.lbComplete.ItemHeight = 25;
            this.lbComplete.Location = new System.Drawing.Point(3, 27);
            this.lbComplete.Name = "lbComplete";
            this.lbComplete.Size = new System.Drawing.Size(581, 324);
            this.lbComplete.TabIndex = 0;
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(340, 913);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(161, 60);
            this.bttnDelete.TabIndex = 15;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = true;
            // 
            // bttnEdit
            // 
            this.bttnEdit.Location = new System.Drawing.Point(340, 840);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(161, 55);
            this.bttnEdit.TabIndex = 14;
            this.bttnEdit.Text = "Edit";
            this.bttnEdit.UseVisualStyleBackColor = true;
            // 
            // bttnMove
            // 
            this.bttnMove.Location = new System.Drawing.Point(114, 916);
            this.bttnMove.Name = "bttnMove";
            this.bttnMove.Size = new System.Drawing.Size(161, 51);
            this.bttnMove.TabIndex = 13;
            this.bttnMove.Text = "Move";
            this.bttnMove.UseVisualStyleBackColor = true;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(114, 843);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(161, 52);
            this.bttnAdd.TabIndex = 12;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::JeanaiRoberts_CE01.Properties.Resources.iPhone7Image__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 1280);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbNotComplete.ResumeLayout(false);
            this.gbCompleteCourses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.GroupBox gbNotComplete;
        private System.Windows.Forms.ListBox lbNotTaken;
        private System.Windows.Forms.Button bttnEdit;
        private System.Windows.Forms.GroupBox gbCompleteCourses;
        private System.Windows.Forms.ListBox lbComplete;
        private System.Windows.Forms.Button bttnMove;
        private System.Windows.Forms.Button bttnAdd;
    }
}

