namespace XlsxImport
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Store = new DataGridViewTextBoxColumn();
            DocNumber = new DataGridViewTextBoxColumn();
            DocDate = new DataGridViewTextBoxColumn();
            openFileDialog1 = new OpenFileDialog();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            tabPage2 = new TabPage();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(590, 21);
            button1.Name = "button1";
            button1.Size = new Size(168, 50);
            button1.TabIndex = 0;
            button1.Text = "Загрузить файл...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Store, DocNumber, DocDate });
            dataGridView1.Location = new Point(6, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(763, 284);
            dataGridView1.TabIndex = 1;
            // 
            // Store
            // 
            Store.HeaderText = "store";
            Store.MinimumWidth = 6;
            Store.Name = "Store";
            Store.Width = 125;
            // 
            // DocNumber
            // 
            DocNumber.HeaderText = "docNumber";
            DocNumber.MinimumWidth = 6;
            DocNumber.Name = "DocNumber";
            DocNumber.Width = 125;
            // 
            // DocDate
            // 
            DocDate.HeaderText = "docDate";
            DocDate.MinimumWidth = 6;
            DocDate.Name = "DocDate";
            DocDate.Width = 125;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 8);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(783, 455);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(775, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Импорт из xlsc";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(569, 55);
            label1.TabIndex = 2;
            label1.Text = "Здесь можно загрузить данные из файла. Для этого нажмите кнопку \"Загрузить файл...\". Формат файла должен соответствовать таблице ниже\r\n";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(button2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(775, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Загрузка из БД";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Location = new Point(17, 20);
            label2.Name = "label2";
            label2.Size = new Size(569, 55);
            label2.TabIndex = 3;
            label2.Text = "Здесь можно просмотреть данные, что находятся в БД.\r\n";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView2.Location = new Point(6, 89);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(763, 285);
            dataGridView2.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "store";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "docNumber";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "docDate";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // button2
            // 
            button2.Location = new Point(592, 20);
            button2.Name = "button2";
            button2.Size = new Size(160, 51);
            button2.TabIndex = 0;
            button2.Text = "Загрузить из БД";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(159, 380);
            button3.Name = "button3";
            button3.Size = new Size(452, 29);
            button3.TabIndex = 3;
            button3.Text = "Загрузить еще";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(152, 387);
            button4.Name = "button4";
            button4.Size = new Size(452, 29);
            button4.TabIndex = 4;
            button4.Text = "Загрузить еще";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 466);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "XlsxImport";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridViewTextBoxColumn Store;
        private DataGridViewTextBoxColumn DocNumber;
        private DataGridViewTextBoxColumn DocDate;
        private Label label1;
        private DataGridView dataGridView2;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label2;
        private Button button3;
        private Button button4;
    }
}
