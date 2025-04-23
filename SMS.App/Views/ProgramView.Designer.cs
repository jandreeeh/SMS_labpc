namespace SMS.App
{
    partial class ProgramView
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
            textBoxProgramName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxDescription = new TextBox();
            label3 = new Label();
            textBoxId = new TextBox();
            buttonCreate = new Button();
            buttonRead = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            dataGridViewProgramList = new DataGridView();
            label4 = new Label();
            textBoxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramList).BeginInit();
            SuspendLayout();
            // 
            // textBoxProgramName
            // 
            textBoxProgramName.Location = new Point(43, 124);
            textBoxProgramName.Name = "textBoxProgramName";
            textBoxProgramName.Size = new Size(274, 27);
            textBoxProgramName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 101);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 1;
            label1.Text = "Program Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 154);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(43, 177);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(274, 27);
            textBoxDescription.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 48);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 5;
            label3.Text = "I.D.";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(43, 71);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(274, 27);
            textBoxId.TabIndex = 4;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(43, 233);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(274, 29);
            buttonCreate.TabIndex = 6;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonRead
            // 
            buttonRead.Location = new Point(43, 268);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(274, 29);
            buttonRead.TabIndex = 7;
            buttonRead.Text = "Read";
            buttonRead.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(43, 338);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(274, 29);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(43, 303);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(274, 29);
            buttonUpdate.TabIndex = 8;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProgramList
            // 
            dataGridViewProgramList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProgramList.Location = new Point(356, 124);
            dataGridViewProgramList.Name = "dataGridViewProgramList";
            dataGridViewProgramList.RowHeadersWidth = 51;
            dataGridViewProgramList.Size = new Size(532, 243);
            dataGridViewProgramList.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(614, 48);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 12;
            label4.Text = "Filter:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(614, 71);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(274, 27);
            textBoxSearch.TabIndex = 11;
            // 
            // ProgramView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 395);
            Controls.Add(label4);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridViewProgramList);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonRead);
            Controls.Add(buttonCreate);
            Controls.Add(label3);
            Controls.Add(textBoxId);
            Controls.Add(label2);
            Controls.Add(textBoxDescription);
            Controls.Add(label1);
            Controls.Add(textBoxProgramName);
            Name = "ProgramView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Program Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProgramName;
        private Label label1;
        private Label label2;
        private TextBox textBoxDescription;
        private Label label3;
        private TextBox textBoxId;
        private Button buttonCreate;
        private Button buttonRead;
        private Button buttonDelete;
        private Button buttonUpdate;
        private DataGridView dataGridViewProgramList;
        private Label label4;
        private TextBox textBoxSearch;
    }
}