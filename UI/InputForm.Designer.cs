namespace Lab2.UI
{
    partial class InputForm
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
            this.graph = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.functionBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.intervalStartBox = new System.Windows.Forms.TextBox();
            this.intervalEndBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stepBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.targetXBox = new System.Windows.Forms.TextBox();
            this.targetYBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.epsilonBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.methodBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph.AllowExternalDrop = true;
            this.graph.CreationProperties = null;
            this.graph.DefaultBackgroundColor = System.Drawing.Color.White;
            this.graph.Location = new System.Drawing.Point(180, 11);
            this.graph.Margin = new System.Windows.Forms.Padding(2);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(364, 281);
            this.graph.TabIndex = 16;
            this.graph.ZoomFactor = 1D;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(9, 192);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(163, 20);
            this.calculateButton.TabIndex = 37;
            this.calculateButton.Text = "Вычислить";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(12, 216);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(163, 76);
            this.resultLabel.TabIndex = 40;
            this.resultLabel.Text = "Результат:\r\nВычисления не проводились\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Функция:";
            // 
            // functionBox
            // 
            this.functionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.functionBox.FormattingEnabled = true;
            this.functionBox.Items.AddRange(new object[] {
            "y\'=y+(1+x)y^2"});
            this.functionBox.Location = new System.Drawing.Point(12, 60);
            this.functionBox.Name = "functionBox";
            this.functionBox.Size = new System.Drawing.Size(154, 21);
            this.functionBox.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Интервал:";
            // 
            // intervalStartBox
            // 
            this.intervalStartBox.Location = new System.Drawing.Point(12, 100);
            this.intervalStartBox.Name = "intervalStartBox";
            this.intervalStartBox.ReadOnly = true;
            this.intervalStartBox.Size = new System.Drawing.Size(67, 20);
            this.intervalStartBox.TabIndex = 44;
            this.intervalStartBox.Text = "1";
            // 
            // intervalEndBox
            // 
            this.intervalEndBox.Location = new System.Drawing.Point(99, 100);
            this.intervalEndBox.Name = "intervalEndBox";
            this.intervalEndBox.Size = new System.Drawing.Size(67, 20);
            this.intervalEndBox.TabIndex = 45;
            this.intervalEndBox.Text = "1.5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Шаг:";
            // 
            // stepBox
            // 
            this.stepBox.Location = new System.Drawing.Point(12, 139);
            this.stepBox.Name = "stepBox";
            this.stepBox.Size = new System.Drawing.Size(67, 20);
            this.stepBox.TabIndex = 47;
            this.stepBox.Text = "0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "x0 =";
            // 
            // targetXBox
            // 
            this.targetXBox.Location = new System.Drawing.Point(45, 166);
            this.targetXBox.Name = "targetXBox";
            this.targetXBox.Size = new System.Drawing.Size(46, 20);
            this.targetXBox.TabIndex = 51;
            this.targetXBox.Text = "1";
            this.targetXBox.TextChanged += new System.EventHandler(this.targetXBox_TextChanged);
            // 
            // targetYBox
            // 
            this.targetYBox.Location = new System.Drawing.Point(126, 166);
            this.targetYBox.Name = "targetYBox";
            this.targetYBox.Size = new System.Drawing.Size(46, 20);
            this.targetYBox.TabIndex = 53;
            this.targetYBox.Text = "-1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "y0 =";
            // 
            // epsilonBox
            // 
            this.epsilonBox.Location = new System.Drawing.Point(99, 139);
            this.epsilonBox.Name = "epsilonBox";
            this.epsilonBox.Size = new System.Drawing.Size(67, 20);
            this.epsilonBox.TabIndex = 55;
            this.epsilonBox.Text = "0.1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Точность:";
            // 
            // methodBox
            // 
            this.methodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodBox.FormattingEnabled = true;
            this.methodBox.Items.AddRange(new object[] {
            "Эйлера",
            "Улучшенный Эйлера",
            "Адамса"});
            this.methodBox.Location = new System.Drawing.Point(12, 25);
            this.methodBox.Name = "methodBox";
            this.methodBox.Size = new System.Drawing.Size(154, 21);
            this.methodBox.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Метод:";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 299);
            this.Controls.Add(this.methodBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.epsilonBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.targetYBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.targetXBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stepBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.intervalEndBox);
            this.Controls.Add(this.intervalStartBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.functionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.graph);
            this.Name = "InputForm";
            this.Text = "Лабораторная работа №6";
            this.Load += new System.EventHandler(this.InputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 graph;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox functionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox intervalStartBox;
        private System.Windows.Forms.TextBox intervalEndBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stepBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox targetXBox;
        private System.Windows.Forms.TextBox targetYBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox epsilonBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox methodBox;
        private System.Windows.Forms.Label label7;
    }
}