namespace SMS.App
{
    partial class Form1
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
            label1 = new Label();
            textBoxId = new TextBox();
            textBoxName = new TextBox();
            label2 = new Label();
            textBoxEmail = new TextBox();
            label3 = new Label();
            buttonShow = new Button();
            labelAddedInformation = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 157);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(284, 154);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(306, 27);
            textBoxId.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(284, 212);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(306, 27);
            textBoxName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 215);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(284, 270);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(306, 27);
            textBoxEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 273);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(207, 48);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(383, 53);
            buttonShow.TabIndex = 6;
            buttonShow.Text = "Show Information!";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // labelAddedInformation
            // 
            labelAddedInformation.AutoSize = true;
            labelAddedInformation.Location = new Point(284, 320);
            labelAddedInformation.Name = "labelAddedInformation";
            labelAddedInformation.Size = new Size(136, 20);
            labelAddedInformation.TabIndex = 7;
            labelAddedInformation.Text = "Added Information";
            // 
            // Form1
            // 
            AcceptButton = buttonShow;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelAddedInformation);
            Controls.Add(buttonShow);
            Controls.Add(textBoxEmail);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxId;
        private TextBox textBoxName;
        private Label label2;
        private TextBox textBoxEmail;
        private Label label3;
        private Button buttonShow;
        private Label labelAddedInformation;
    }
}
