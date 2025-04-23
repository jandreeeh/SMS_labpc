namespace SMS.App.Views
{
    partial class CreateProgramView
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
            buttonCreate = new Button();
            label3 = new Label();
            textBoxId = new TextBox();
            label2 = new Label();
            textBoxDescription = new TextBox();
            label1 = new Label();
            textBoxProgramName = new TextBox();
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(92, 243);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(274, 29);
            buttonCreate.TabIndex = 13;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 58);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 12;
            label3.Text = "I.D.";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(92, 81);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(274, 27);
            textBoxId.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 164);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 10;
            label2.Text = "Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(92, 187);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(274, 27);
            textBoxDescription.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 111);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 8;
            label1.Text = "Program Name";
            // 
            // textBoxProgramName
            // 
            textBoxProgramName.Location = new Point(92, 134);
            textBoxProgramName.Name = "textBoxProgramName";
            textBoxProgramName.Size = new Size(274, 27);
            textBoxProgramName.TabIndex = 7;
            // 
            // CreateProgramView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 331);
            Controls.Add(buttonCreate);
            Controls.Add(label3);
            Controls.Add(textBoxId);
            Controls.Add(label2);
            Controls.Add(textBoxDescription);
            Controls.Add(label1);
            Controls.Add(textBoxProgramName);
            Name = "CreateProgramView";
            Text = "Add Program";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreate;
        private Label label3;
        private TextBox textBoxId;
        private Label label2;
        private TextBox textBoxDescription;
        private Label label1;
        private TextBox textBoxProgramName;
    }
}