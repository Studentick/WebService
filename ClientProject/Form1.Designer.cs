namespace ClientProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPgLocal = new System.Windows.Forms.TabPage();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInventory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lblTopLoc = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvInstProgr = new System.Windows.Forms.DataGridView();
            this.tbPgSelected = new System.Windows.Forms.TabPage();
            this.tbPgCounter = new System.Windows.Forms.TabPage();
            this.tbRes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPattern = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKriteriy = new System.Windows.Forms.ComboBox();
            this.btnGetCount = new System.Windows.Forms.Button();
            this.btnReadSelected = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSeLoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSeIn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSeId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvProgInfo = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tbPgLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstProgr)).BeginInit();
            this.tbPgSelected.SuspendLayout();
            this.tbPgCounter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPgLocal);
            this.tabControl1.Controls.Add(this.tbPgSelected);
            this.tabControl1.Controls.Add(this.tbPgCounter);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 409);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPgLocal
            // 
            this.tbPgLocal.BackColor = System.Drawing.SystemColors.Control;
            this.tbPgLocal.Controls.Add(this.btnUpload);
            this.tbPgLocal.Controls.Add(this.btnReset);
            this.tbPgLocal.Controls.Add(this.btnDownload);
            this.tbPgLocal.Controls.Add(this.btnRead);
            this.tbPgLocal.Controls.Add(this.label2);
            this.tbPgLocal.Controls.Add(this.tbLoc);
            this.tbPgLocal.Controls.Add(this.label3);
            this.tbPgLocal.Controls.Add(this.tbInventory);
            this.tbPgLocal.Controls.Add(this.label1);
            this.tbPgLocal.Controls.Add(this.tbId);
            this.tbPgLocal.Controls.Add(this.lblTopLoc);
            this.tbPgLocal.Controls.Add(this.lblId);
            this.tbPgLocal.Controls.Add(this.dgvInstProgr);
            this.tbPgLocal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPgLocal.Location = new System.Drawing.Point(4, 24);
            this.tbPgLocal.Margin = new System.Windows.Forms.Padding(4);
            this.tbPgLocal.Name = "tbPgLocal";
            this.tbPgLocal.Padding = new System.Windows.Forms.Padding(4);
            this.tbPgLocal.Size = new System.Drawing.Size(776, 381);
            this.tbPgLocal.TabIndex = 0;
            this.tbPgLocal.Text = "Текущий компьютер";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(684, 80);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(84, 38);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Загрузить";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(573, 80);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 38);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(463, 80);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(84, 38);
            this.btnDownload.TabIndex = 10;
            this.btnDownload.Text = "Скачать";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(354, 80);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(84, 38);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "Считать";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(265, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Установленные программы";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbLoc
            // 
            this.tbLoc.Location = new System.Drawing.Point(480, 41);
            this.tbLoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbLoc.Name = "tbLoc";
            this.tbLoc.Size = new System.Drawing.Size(164, 26);
            this.tbLoc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(364, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Расположение";
            // 
            // tbInventory
            // 
            this.tbInventory.Location = new System.Drawing.Point(165, 87);
            this.tbInventory.Margin = new System.Windows.Forms.Padding(4);
            this.tbInventory.Name = "tbInventory";
            this.tbInventory.Size = new System.Drawing.Size(164, 26);
            this.tbInventory.TabIndex = 5;
            this.tbInventory.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Инвентарный номер";
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.SystemColors.Info;
            this.tbId.Location = new System.Drawing.Point(165, 45);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(164, 26);
            this.tbId.TabIndex = 3;
            // 
            // lblTopLoc
            // 
            this.lblTopLoc.AutoSize = true;
            this.lblTopLoc.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTopLoc.Location = new System.Drawing.Point(248, 4);
            this.lblTopLoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopLoc.Name = "lblTopLoc";
            this.lblTopLoc.Size = new System.Drawing.Size(279, 23);
            this.lblTopLoc.TabIndex = 2;
            this.lblTopLoc.Text = "Инфо о текущем компьютере";
            this.lblTopLoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblId.Location = new System.Drawing.Point(7, 48);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(109, 19);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "id Компьютера";
            // 
            // dgvInstProgr
            // 
            this.dgvInstProgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstProgr.Location = new System.Drawing.Point(4, 156);
            this.dgvInstProgr.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInstProgr.Name = "dgvInstProgr";
            this.dgvInstProgr.Size = new System.Drawing.Size(768, 221);
            this.dgvInstProgr.TabIndex = 0;
            // 
            // tbPgSelected
            // 
            this.tbPgSelected.BackColor = System.Drawing.SystemColors.Control;
            this.tbPgSelected.Controls.Add(this.btnReadSelected);
            this.tbPgSelected.Controls.Add(this.label7);
            this.tbPgSelected.Controls.Add(this.tbSeLoc);
            this.tbPgSelected.Controls.Add(this.label8);
            this.tbPgSelected.Controls.Add(this.tbSeIn);
            this.tbPgSelected.Controls.Add(this.label9);
            this.tbPgSelected.Controls.Add(this.tbSeId);
            this.tbPgSelected.Controls.Add(this.label10);
            this.tbPgSelected.Controls.Add(this.label11);
            this.tbPgSelected.Controls.Add(this.dgvProgInfo);
            this.tbPgSelected.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPgSelected.Location = new System.Drawing.Point(4, 24);
            this.tbPgSelected.Margin = new System.Windows.Forms.Padding(4);
            this.tbPgSelected.Name = "tbPgSelected";
            this.tbPgSelected.Padding = new System.Windows.Forms.Padding(4);
            this.tbPgSelected.Size = new System.Drawing.Size(776, 381);
            this.tbPgSelected.TabIndex = 1;
            this.tbPgSelected.Text = "Другой компьютер";
            // 
            // tbPgCounter
            // 
            this.tbPgCounter.BackColor = System.Drawing.SystemColors.Control;
            this.tbPgCounter.Controls.Add(this.tbRes);
            this.tbPgCounter.Controls.Add(this.label6);
            this.tbPgCounter.Controls.Add(this.tbPattern);
            this.tbPgCounter.Controls.Add(this.label5);
            this.tbPgCounter.Controls.Add(this.label4);
            this.tbPgCounter.Controls.Add(this.cbKriteriy);
            this.tbPgCounter.Controls.Add(this.btnGetCount);
            this.tbPgCounter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPgCounter.Location = new System.Drawing.Point(4, 24);
            this.tbPgCounter.Name = "tbPgCounter";
            this.tbPgCounter.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgCounter.Size = new System.Drawing.Size(776, 381);
            this.tbPgCounter.TabIndex = 2;
            this.tbPgCounter.Text = "Подсчёт по критерию";
            // 
            // tbRes
            // 
            this.tbRes.Location = new System.Drawing.Point(521, 86);
            this.tbRes.Name = "tbRes";
            this.tbRes.Size = new System.Drawing.Size(211, 26);
            this.tbRes.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Результат";
            // 
            // tbPattern
            // 
            this.tbPattern.Location = new System.Drawing.Point(270, 86);
            this.tbPattern.Name = "tbPattern";
            this.tbPattern.Size = new System.Drawing.Size(211, 26);
            this.tbPattern.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Параметр истинности";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Критерий подсчёта";
            // 
            // cbKriteriy
            // 
            this.cbKriteriy.FormattingEnabled = true;
            this.cbKriteriy.Items.AddRange(new object[] {
            "Инвентарный номер",
            "Расположение"});
            this.cbKriteriy.Location = new System.Drawing.Point(19, 86);
            this.cbKriteriy.Name = "cbKriteriy";
            this.cbKriteriy.Size = new System.Drawing.Size(211, 27);
            this.cbKriteriy.TabIndex = 1;
            // 
            // btnGetCount
            // 
            this.btnGetCount.Location = new System.Drawing.Point(270, 281);
            this.btnGetCount.Name = "btnGetCount";
            this.btnGetCount.Size = new System.Drawing.Size(211, 51);
            this.btnGetCount.TabIndex = 0;
            this.btnGetCount.Text = "Посчитать";
            this.btnGetCount.UseVisualStyleBackColor = true;
            this.btnGetCount.Click += new System.EventHandler(this.btnGetCount_Click);
            // 
            // btnReadSelected
            // 
            this.btnReadSelected.Location = new System.Drawing.Point(463, 80);
            this.btnReadSelected.Name = "btnReadSelected";
            this.btnReadSelected.Size = new System.Drawing.Size(84, 38);
            this.btnReadSelected.TabIndex = 20;
            this.btnReadSelected.Text = "Считать";
            this.btnReadSelected.UseVisualStyleBackColor = true;
            this.btnReadSelected.Click += new System.EventHandler(this.btnReadSelected_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(265, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Установленные программы";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbSeLoc
            // 
            this.tbSeLoc.BackColor = System.Drawing.SystemColors.Info;
            this.tbSeLoc.Location = new System.Drawing.Point(480, 41);
            this.tbSeLoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbSeLoc.Name = "tbSeLoc";
            this.tbSeLoc.ReadOnly = true;
            this.tbSeLoc.Size = new System.Drawing.Size(164, 26);
            this.tbSeLoc.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(364, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Расположение";
            // 
            // tbSeIn
            // 
            this.tbSeIn.BackColor = System.Drawing.SystemColors.Info;
            this.tbSeIn.Location = new System.Drawing.Point(165, 87);
            this.tbSeIn.Margin = new System.Windows.Forms.Padding(4);
            this.tbSeIn.Name = "tbSeIn";
            this.tbSeIn.ReadOnly = true;
            this.tbSeIn.Size = new System.Drawing.Size(164, 26);
            this.tbSeIn.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(7, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Инвентарный номер";
            // 
            // tbSeId
            // 
            this.tbSeId.Location = new System.Drawing.Point(165, 45);
            this.tbSeId.Margin = new System.Windows.Forms.Padding(4);
            this.tbSeId.Name = "tbSeId";
            this.tbSeId.Size = new System.Drawing.Size(164, 26);
            this.tbSeId.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(248, 4);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(302, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Инфо о выбранном компьютере";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(7, 48);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 19);
            this.label11.TabIndex = 12;
            this.label11.Text = "id Компьютера";
            // 
            // dgvProgInfo
            // 
            this.dgvProgInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgInfo.Location = new System.Drawing.Point(4, 156);
            this.dgvProgInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProgInfo.Name = "dgvProgInfo";
            this.dgvProgInfo.Size = new System.Drawing.Size(768, 221);
            this.dgvProgInfo.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tbPgLocal.ResumeLayout(false);
            this.tbPgLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstProgr)).EndInit();
            this.tbPgSelected.ResumeLayout(false);
            this.tbPgSelected.PerformLayout();
            this.tbPgCounter.ResumeLayout(false);
            this.tbPgCounter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPgLocal;
        private System.Windows.Forms.TabPage tbPgSelected;
        private System.Windows.Forms.TextBox tbInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lblTopLoc;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvInstProgr;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tbPgCounter;
        private System.Windows.Forms.TextBox tbRes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPattern;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKriteriy;
        private System.Windows.Forms.Button btnGetCount;
        private System.Windows.Forms.Button btnReadSelected;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSeLoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSeIn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSeId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvProgInfo;
    }
}

