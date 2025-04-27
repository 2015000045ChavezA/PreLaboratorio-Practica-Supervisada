namespace LaboratorioChristianChavez
{
    partial class BaseDatos
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
            textBox6 = new TextBox();
            label6 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1016, 318);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(842, 318);
            label6.Name = "label6";
            label6.Size = new Size(163, 20);
            label6.TabIndex = 47;
            label6.Text = "Ciclo académico actual";
            // 
            // button3
            // 
            button3.Location = new Point(123, 408);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 46;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 408);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 45;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(821, 365);
            button1.Name = "button1";
            button1.Size = new Size(339, 72);
            button1.TabIndex = 44;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1016, 248);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(842, 255);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 42;
            label5.Text = "Número de matrícula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(842, 186);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 41;
            label4.Text = "Número de teléfono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(842, 132);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 40;
            label3.Text = "Sección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(842, 67);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 39;
            label2.Text = "Grado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(842, 12);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 38;
            label1.Text = "Nombre";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1016, 186);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 37;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1016, 132);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 36;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1016, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 35;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1016, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 34;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(806, 390);
            dataGridView1.TabIndex = 33;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Grado";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Sección";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Número de teléfono";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Número de matrícula";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ciclo académico actual";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // button4
            // 
            button4.Location = new Point(238, 409);
            button4.Name = "button4";
            button4.Size = new Size(568, 29);
            button4.TabIndex = 49;
            button4.Text = "Créditos";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // BaseDatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 450);
            Controls.Add(button4);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "BaseDatos";
            Text = "BaseDatos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox6;
        private Label label6;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox5;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button button4;
    }
}