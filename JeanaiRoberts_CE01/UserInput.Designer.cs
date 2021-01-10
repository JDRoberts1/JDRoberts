
namespace JeanaiRoberts_CE01
{
    partial class UserInput
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
            this.classInput = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.dateClassDate = new System.Windows.Forms.DateTimePicker();
            this.chkTaken = new System.Windows.Forms.CheckBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.classInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // classInput
            // 
            this.classInput.Controls.Add(this.btnAdd);
            this.classInput.Controls.Add(this.label3);
            this.classInput.Controls.Add(this.label2);
            this.classInput.Controls.Add(this.label1);
            this.classInput.Controls.Add(this.btnSave);
            this.classInput.Controls.Add(this.rdoBlue);
            this.classInput.Controls.Add(this.rdoRed);
            this.classInput.Controls.Add(this.dateClassDate);
            this.classInput.Controls.Add(this.chkTaken);
            this.classInput.Controls.Add(this.txtClassName);
            this.classInput.Location = new System.Drawing.Point(51, 176);
            this.classInput.Name = "classInput";
            this.classInput.Size = new System.Drawing.Size(611, 999);
            this.classInput.TabIndex = 0;
            this.classInput.TabStop = false;
            this.classInput.Text = "Course Information";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(203, 522);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 65);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select text color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date Projected/Completed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Class Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(203, 634);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 65);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Location = new System.Drawing.Point(255, 417);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(127, 29);
            this.rdoBlue.TabIndex = 4;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "Blue text";
            this.rdoBlue.UseVisualStyleBackColor = true;
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(255, 353);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(123, 29);
            this.rdoRed.TabIndex = 3;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Red text";
            this.rdoRed.UseVisualStyleBackColor = true;
            // 
            // dateClassDate
            // 
            this.dateClassDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateClassDate.Location = new System.Drawing.Point(310, 272);
            this.dateClassDate.Name = "dateClassDate";
            this.dateClassDate.Size = new System.Drawing.Size(165, 31);
            this.dateClassDate.TabIndex = 2;
            this.dateClassDate.Value = new System.DateTime(2021, 1, 4, 19, 0, 25, 0);
            // 
            // chkTaken
            // 
            this.chkTaken.AutoSize = true;
            this.chkTaken.Location = new System.Drawing.Point(255, 209);
            this.chkTaken.Name = "chkTaken";
            this.chkTaken.Size = new System.Drawing.Size(218, 29);
            this.chkTaken.TabIndex = 1;
            this.chkTaken.Text = "Course complete?";
            this.chkTaken.UseVisualStyleBackColor = true;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(255, 144);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(220, 31);
            this.txtClassName.TabIndex = 0;
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::JeanaiRoberts_CE01.Properties.Resources.iPhone7Image__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 1348);
            this.Controls.Add(this.classInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserInput";
            this.Text = "Movie Input";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserInput_FormClosed);
            this.classInput.ResumeLayout(false);
            this.classInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox classInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.DateTimePicker dateClassDate;
        private System.Windows.Forms.CheckBox chkTaken;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Button btnAdd;
    }
}