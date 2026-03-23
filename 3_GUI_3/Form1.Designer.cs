namespace _3_GUI_3
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
            cmbUnitA = new ComboBox();
            cmbUnitB = new ComboBox();
            cmbOperation = new ComboBox();
            cmbResultUnit = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAreaA = new TextBox();
            txtAreaB = new TextBox();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // cmbUnitA
            // 
            cmbUnitA.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnitA.FormattingEnabled = true;
            cmbUnitA.Items.AddRange(new object[] { "м²", "сотка", "гектар", "десятина" });
            cmbUnitA.Location = new Point(101, 115);
            cmbUnitA.Name = "cmbUnitA";
            cmbUnitA.Size = new Size(98, 28);
            cmbUnitA.TabIndex = 0;
            cmbUnitA.SelectedIndexChanged += OnValueChanged;
            // 
            // cmbUnitB
            // 
            cmbUnitB.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnitB.FormattingEnabled = true;
            cmbUnitB.Items.AddRange(new object[] { "м²", "сотка", "гектар", "десятина" });
            cmbUnitB.Location = new Point(444, 115);
            cmbUnitB.Name = "cmbUnitB";
            cmbUnitB.Size = new Size(98, 28);
            cmbUnitB.TabIndex = 1;
            cmbUnitB.SelectedIndexChanged += OnValueChanged;
            // 
            // cmbOperation
            // 
            cmbOperation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperation.FormattingEnabled = true;
            cmbOperation.Items.AddRange(new object[] { "+", "-", "×", "Сравнить" });
            cmbOperation.Location = new Point(244, 81);
            cmbOperation.Name = "cmbOperation";
            cmbOperation.Size = new Size(98, 28);
            cmbOperation.TabIndex = 2;
            cmbOperation.SelectedIndexChanged += OnValueChanged;
            // 
            // cmbResultUnit
            // 
            cmbResultUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResultUnit.FormattingEnabled = true;
            cmbResultUnit.Items.AddRange(new object[] { "м²", "сотка", "гектар", "десятина" });
            cmbResultUnit.Location = new Point(380, 198);
            cmbResultUnit.Name = "cmbResultUnit";
            cmbResultUnit.Size = new Size(98, 28);
            cmbResultUnit.TabIndex = 3;
            cmbResultUnit.SelectedIndexChanged += OnValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 59);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 4;
            label1.Text = "Площадь А";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(383, 38);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 5;
            label2.Text = "Площадь Б";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(383, 58);
            label3.Name = "label3";
            label3.Size = new Size(254, 20);
            label3.TabIndex = 6;
            label3.Text = "(при умножении - обычное число)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 201);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 7;
            label4.Text = "Результат:";
            // 
            // txtAreaA
            // 
            txtAreaA.Location = new Point(40, 82);
            txtAreaA.Name = "txtAreaA";
            txtAreaA.Size = new Size(159, 27);
            txtAreaA.TabIndex = 8;
            txtAreaA.TextChanged += OnValueChanged;
            // 
            // txtAreaB
            // 
            txtAreaB.Location = new Point(383, 82);
            txtAreaB.Name = "txtAreaB";
            txtAreaB.Size = new Size(159, 27);
            txtAreaB.TabIndex = 9;
            txtAreaB.TextChanged += OnValueChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(215, 198);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(159, 27);
            txtResult.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 286);
            Controls.Add(txtResult);
            Controls.Add(txtAreaB);
            Controls.Add(txtAreaA);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbResultUnit);
            Controls.Add(cmbOperation);
            Controls.Add(cmbUnitB);
            Controls.Add(cmbUnitA);
            Name = "Form1";
            Text = "Калькулятор площадей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbUnitA;
        private ComboBox cmbUnitB;
        private ComboBox cmbOperation;
        private ComboBox cmbResultUnit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAreaA;
        private TextBox txtAreaB;
        private TextBox txtResult;
    }
}
