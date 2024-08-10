namespace To_do_list
{
    partial class ToDoList
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
            TitleTextbox = new TextBox();
            descriptionTextbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            NewButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ToDoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ToDoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial Narrow", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1132, 69);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // TitleTextbox
            // 
            TitleTextbox.Location = new Point(12, 206);
            TitleTextbox.Name = "TitleTextbox";
            TitleTextbox.Size = new Size(1132, 23);
            TitleTextbox.TabIndex = 1;
            // 
            // descriptionTextbox
            // 
            descriptionTextbox.Location = new Point(12, 254);
            descriptionTextbox.Name = "descriptionTextbox";
            descriptionTextbox.Size = new Size(1132, 23);
            descriptionTextbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(12, 228);
            label2.Name = "label2";
            label2.Size = new Size(1131, 23);
            label2.TabIndex = 3;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(13, 180);
            label3.Name = "label3";
            label3.Size = new Size(1131, 23);
            label3.TabIndex = 4;
            label3.Text = "Title:";
            // 
            // NewButton
            // 
            NewButton.Font = new Font("Arial Narrow", 15.75F);
            NewButton.Location = new Point(12, 283);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(283, 40);
            NewButton.TabIndex = 5;
            NewButton.Text = "New";
            NewButton.TextAlign = ContentAlignment.TopCenter;
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 15.75F);
            button1.Location = new Point(298, 283);
            button1.Name = "button1";
            button1.Size = new Size(283, 40);
            button1.TabIndex = 6;
            button1.Text = "Edit";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 15.75F);
            button2.Location = new Point(584, 283);
            button2.Name = "button2";
            button2.Size = new Size(283, 40);
            button2.TabIndex = 7;
            button2.Text = "Delete";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Narrow", 15.75F);
            button3.Location = new Point(869, 283);
            button3.Name = "button3";
            button3.Size = new Size(275, 40);
            button3.TabIndex = 8;
            button3.Text = "Save";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ToDoListView
            // 
            ToDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ToDoListView.BackgroundColor = Color.White;
            ToDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ToDoListView.Location = new Point(12, 329);
            ToDoListView.Name = "ToDoListView";
            ToDoListView.Size = new Size(1132, 382);
            ToDoListView.TabIndex = 9;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1156, 723);
            Controls.Add(ToDoListView);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(NewButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(descriptionTextbox);
            Controls.Add(TitleTextbox);
            Controls.Add(label1);
            Name = "ToDoList";
            Text = "To do list";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ToDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TitleTextbox;
        private TextBox descriptionTextbox;
        private Label label2;
        private Label label3;
        private Button NewButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView ToDoListView;
    }
}
