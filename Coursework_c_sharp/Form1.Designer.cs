namespace Coursework_c_sharp
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
         this.priceNumUpDwn = new System.Windows.Forms.NumericUpDown();
         this.yearNumUpDwn = new System.Windows.Forms.NumericUpDown();
         this.authorTB = new System.Windows.Forms.TextBox();
         this.pubhousTB = new System.Windows.Forms.TextBox();
         this.label8 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.nameTB = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.stateComBox = new System.Windows.Forms.ComboBox();
         this.dTim = new System.Windows.Forms.DateTimePicker();
         this.dGV = new System.Windows.Forms.DataGridView();
         this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.yearpub = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.pubhous = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.addbut = new System.Windows.Forms.Button();
         this.deletbut = new System.Windows.Forms.Button();
         this.savebut = new System.Windows.Forms.Button();
         this.backbut = new System.Windows.Forms.Button();
         this.nextbut = new System.Windows.Forms.Button();
         this.redagbut = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.priceNumUpDwn)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.yearNumUpDwn)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
         this.SuspendLayout();
         // 
         // priceNumUpDwn
         // 
         this.priceNumUpDwn.Location = new System.Drawing.Point(137, 135);
         this.priceNumUpDwn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
         this.priceNumUpDwn.Name = "priceNumUpDwn";
         this.priceNumUpDwn.Size = new System.Drawing.Size(167, 22);
         this.priceNumUpDwn.TabIndex = 32;
         // 
         // yearNumUpDwn
         // 
         this.yearNumUpDwn.Location = new System.Drawing.Point(137, 78);
         this.yearNumUpDwn.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
         this.yearNumUpDwn.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
         this.yearNumUpDwn.Name = "yearNumUpDwn";
         this.yearNumUpDwn.Size = new System.Drawing.Size(167, 22);
         this.yearNumUpDwn.TabIndex = 31;
         this.yearNumUpDwn.Value = new decimal(new int[] {
            1995,
            0,
            0,
            0});
         // 
         // authorTB
         // 
         this.authorTB.Location = new System.Drawing.Point(137, 50);
         this.authorTB.Name = "authorTB";
         this.authorTB.Size = new System.Drawing.Size(167, 22);
         this.authorTB.TabIndex = 30;
         // 
         // pubhousTB
         // 
         this.pubhousTB.Location = new System.Drawing.Point(137, 104);
         this.pubhousTB.Name = "pubhousTB";
         this.pubhousTB.Size = new System.Drawing.Size(167, 22);
         this.pubhousTB.TabIndex = 29;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(22, 79);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(91, 17);
         this.label8.TabIndex = 28;
         this.label8.Text = "Год издания";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(22, 107);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(100, 17);
         this.label7.TabIndex = 27;
         this.label7.Text = "Издательство";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(22, 137);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(43, 17);
         this.label6.TabIndex = 26;
         this.label6.Text = "Цена";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(22, 170);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(79, 17);
         this.label5.TabIndex = 25;
         this.label5.Text = "Состояние";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(22, 206);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(103, 17);
         this.label4.TabIndex = 24;
         this.label4.Text = "Дата  выдачи ";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(22, 53);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(47, 17);
         this.label2.TabIndex = 23;
         this.label2.Text = "Автор";
         // 
         // nameTB
         // 
         this.nameTB.Location = new System.Drawing.Point(137, 21);
         this.nameTB.Name = "nameTB";
         this.nameTB.Size = new System.Drawing.Size(167, 22);
         this.nameTB.TabIndex = 22;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(22, 21);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(112, 17);
         this.label1.TabIndex = 21;
         this.label1.Text = "Название книги";
         // 
         // stateComBox
         // 
         this.stateComBox.FormattingEnabled = true;
         this.stateComBox.Items.AddRange(new object[] {
            "новая",
            "как новая",
            "отличное",
            "хорошее",
            "приемлимое",
            "плохое"});
         this.stateComBox.Location = new System.Drawing.Point(137, 167);
         this.stateComBox.Name = "stateComBox";
         this.stateComBox.Size = new System.Drawing.Size(167, 24);
         this.stateComBox.TabIndex = 36;
         this.stateComBox.Text = "новая";
         // 
         // dTim
         // 
         this.dTim.CustomFormat = "";
         this.dTim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.dTim.Location = new System.Drawing.Point(137, 201);
         this.dTim.MaxDate = new System.DateTime(2019, 5, 26, 0, 0, 0, 0);
         this.dTim.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
         this.dTim.Name = "dTim";
         this.dTim.Size = new System.Drawing.Size(167, 22);
         this.dTim.TabIndex = 37;
         this.dTim.Value = new System.DateTime(2019, 5, 26, 0, 0, 0, 0);
         // 
         // dGV
         // 
         this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name,
            this.author,
            this.yearpub,
            this.pubhous,
            this.price,
            this.state,
            this.date});
         this.dGV.Location = new System.Drawing.Point(326, 21);
         this.dGV.Name = "dGV";
         this.dGV.RowTemplate.Height = 24;
         this.dGV.Size = new System.Drawing.Size(806, 377);
         this.dGV.TabIndex = 38;
         // 
         // number
         // 
         this.number.HeaderText = "№";
         this.number.Name = "number";
         this.number.Width = 35;
         // 
         // name
         // 
         this.name.HeaderText = "Название книги";
         this.name.Name = "name";
         this.name.Width = 85;
         // 
         // author
         // 
         this.author.HeaderText = "Автор";
         this.author.Name = "author";
         this.author.Width = 85;
         // 
         // yearpub
         // 
         this.yearpub.HeaderText = "Год издания";
         this.yearpub.Name = "yearpub";
         this.yearpub.Width = 65;
         // 
         // pubhous
         // 
         this.pubhous.HeaderText = "Издательство";
         this.pubhous.Name = "pubhous";
         this.pubhous.Width = 95;
         // 
         // price
         // 
         this.price.HeaderText = "Цена";
         this.price.Name = "price";
         this.price.Width = 50;
         // 
         // state
         // 
         this.state.HeaderText = "Состояние";
         this.state.Name = "state";
         this.state.Width = 70;
         // 
         // date
         // 
         this.date.HeaderText = "Дата выдачи";
         this.date.Name = "date";
         this.date.Width = 75;
         // 
         // addbut
         // 
         this.addbut.Location = new System.Drawing.Point(48, 285);
         this.addbut.Name = "addbut";
         this.addbut.Size = new System.Drawing.Size(92, 45);
         this.addbut.TabIndex = 40;
         this.addbut.Text = "Добавить";
         this.addbut.UseVisualStyleBackColor = true;
         this.addbut.Click += new System.EventHandler(this.addbut_Click);
         // 
         // deletbut
         // 
         this.deletbut.Location = new System.Drawing.Point(179, 285);
         this.deletbut.Name = "deletbut";
         this.deletbut.Size = new System.Drawing.Size(92, 45);
         this.deletbut.TabIndex = 40;
         this.deletbut.Text = "Удалить";
         this.deletbut.UseVisualStyleBackColor = true;
         this.deletbut.Click += new System.EventHandler(this.delet_Click);
         // 
         // savebut
         // 
         this.savebut.Location = new System.Drawing.Point(176, 348);
         this.savebut.Name = "savebut";
         this.savebut.Size = new System.Drawing.Size(128, 50);
         this.savebut.TabIndex = 41;
         this.savebut.Text = "Сохранить";
         this.savebut.UseVisualStyleBackColor = true;
         this.savebut.Click += new System.EventHandler(this.savebut_Click);
         // 
         // backbut
         // 
         this.backbut.Location = new System.Drawing.Point(45, 229);
         this.backbut.Name = "backbut";
         this.backbut.Size = new System.Drawing.Size(92, 38);
         this.backbut.TabIndex = 43;
         this.backbut.Text = "<";
         this.backbut.UseVisualStyleBackColor = true;
         this.backbut.Click += new System.EventHandler(this.backbut_Click);
         // 
         // nextbut
         // 
         this.nextbut.Location = new System.Drawing.Point(179, 229);
         this.nextbut.Name = "nextbut";
         this.nextbut.Size = new System.Drawing.Size(92, 38);
         this.nextbut.TabIndex = 43;
         this.nextbut.Text = ">";
         this.nextbut.UseVisualStyleBackColor = true;
         this.nextbut.Click += new System.EventHandler(this.nextbut_Click);
         // 
         // redagbut
         // 
         this.redagbut.Location = new System.Drawing.Point(12, 348);
         this.redagbut.Name = "redagbut";
         this.redagbut.Size = new System.Drawing.Size(128, 50);
         this.redagbut.TabIndex = 44;
         this.redagbut.Text = "Редактировать";
         this.redagbut.UseVisualStyleBackColor = true;
         this.redagbut.Click += new System.EventHandler(this.redagbut_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1140, 422);
         this.Controls.Add(this.redagbut);
         this.Controls.Add(this.nextbut);
         this.Controls.Add(this.backbut);
         this.Controls.Add(this.savebut);
         this.Controls.Add(this.deletbut);
         this.Controls.Add(this.addbut);
         this.Controls.Add(this.dGV);
         this.Controls.Add(this.dTim);
         this.Controls.Add(this.stateComBox);
         this.Controls.Add(this.priceNumUpDwn);
         this.Controls.Add(this.yearNumUpDwn);
         this.Controls.Add(this.authorTB);
         this.Controls.Add(this.pubhousTB);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.nameTB);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.priceNumUpDwn)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.yearNumUpDwn)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.NumericUpDown priceNumUpDwn;
      private System.Windows.Forms.NumericUpDown yearNumUpDwn;
      private System.Windows.Forms.TextBox authorTB;
      private System.Windows.Forms.TextBox pubhousTB;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox nameTB;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox stateComBox;
      private System.Windows.Forms.DateTimePicker dTim;
      private System.Windows.Forms.DataGridView dGV;
      private System.Windows.Forms.Button addbut;
      private System.Windows.Forms.Button deletbut;
      private System.Windows.Forms.Button savebut;
      private System.Windows.Forms.Button backbut;
      private System.Windows.Forms.Button nextbut;
      private System.Windows.Forms.Button redagbut;
      private System.Windows.Forms.DataGridViewTextBoxColumn number;
      private System.Windows.Forms.DataGridViewTextBoxColumn name;
      private System.Windows.Forms.DataGridViewTextBoxColumn author;
      private System.Windows.Forms.DataGridViewTextBoxColumn yearpub;
      private System.Windows.Forms.DataGridViewTextBoxColumn pubhous;
      private System.Windows.Forms.DataGridViewTextBoxColumn price;
      private System.Windows.Forms.DataGridViewTextBoxColumn state;
      private System.Windows.Forms.DataGridViewTextBoxColumn date;
   }
}

