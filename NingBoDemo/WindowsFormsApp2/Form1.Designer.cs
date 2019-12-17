namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.metertypeno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.limit = new System.Windows.Forms.TextBox();
            this.txtSalewater = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.warn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.overdraft = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.step2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.step1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.price2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.price3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.buycount = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.chargetype = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.modiflag = new System.Windows.Forms.ComboBox();
            this.resettype = new System.Windows.Forms.ComboBox();
            this.modirfromid = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalemoney = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "读卡器测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "初始化";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(93, 322);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Tag = "com";
            this.comboBox1.Text = "3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "复位卡";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // metertypeno
            // 
            this.metertypeno.Location = new System.Drawing.Point(93, 382);
            this.metertypeno.Name = "metertypeno";
            this.metertypeno.Size = new System.Drawing.Size(128, 25);
            this.metertypeno.TabIndex = 4;
            this.metertypeno.Text = "123456";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "子表号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "用户号";
            // 
            // userid
            // 
            this.userid.Location = new System.Drawing.Point(93, 351);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(128, 25);
            this.userid.TabIndex = 6;
            this.userid.Text = "123456";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "到期日期";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(93, 413);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(128, 25);
            this.date.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "复位类型";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(310, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 40);
            this.button4.TabIndex = 16;
            this.button4.Text = "充值卡";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(161, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 40);
            this.button5.TabIndex = 15;
            this.button5.Text = "设置卡";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 62);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 40);
            this.button6.TabIndex = 14;
            this.button6.Text = "清零卡";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 578);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "囤积量";
            // 
            // limit
            // 
            this.limit.Location = new System.Drawing.Point(90, 571);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(128, 25);
            this.limit.TabIndex = 23;
            this.limit.Text = "2147483";
            // 
            // txtSalewater
            // 
            this.txtSalewater.Location = new System.Drawing.Point(93, 540);
            this.txtSalewater.Name = "txtSalewater";
            this.txtSalewater.Size = new System.Drawing.Size(128, 25);
            this.txtSalewater.TabIndex = 21;
            this.txtSalewater.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "报警量";
            // 
            // warn
            // 
            this.warn.Location = new System.Drawing.Point(93, 475);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(128, 25);
            this.warn.TabIndex = 19;
            this.warn.Text = "65";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "透支量";
            // 
            // overdraft
            // 
            this.overdraft.Location = new System.Drawing.Point(93, 506);
            this.overdraft.Name = "overdraft";
            this.overdraft.Size = new System.Drawing.Size(128, 25);
            this.overdraft.TabIndex = 17;
            this.overdraft.Text = "65";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(310, 112);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 40);
            this.button7.TabIndex = 27;
            this.button7.Text = "价格卡";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(161, 112);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(143, 40);
            this.button8.TabIndex = 26;
            this.button8.Text = "参数卡";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 112);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(143, 40);
            this.button9.TabIndex = 25;
            this.button9.Text = "充值";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 41;
            this.label9.Text = "阶梯2";
            // 
            // step2
            // 
            this.step2.Location = new System.Drawing.Point(332, 506);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(128, 25);
            this.step2.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 478);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 39;
            this.label10.Text = "阶梯1";
            // 
            // step1
            // 
            this.step1.Location = new System.Drawing.Point(332, 475);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(128, 25);
            this.step1.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(278, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 37;
            this.label11.Text = "单价2";
            // 
            // price2
            // 
            this.price2.Location = new System.Drawing.Point(332, 413);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(128, 25);
            this.price2.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(278, 447);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 35;
            this.label12.Text = "单价3";
            // 
            // price3
            // 
            this.price3.Location = new System.Drawing.Point(332, 444);
            this.price3.Name = "price3";
            this.price3.Size = new System.Drawing.Size(128, 25);
            this.price3.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(278, 385);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 15);
            this.label13.TabIndex = 33;
            this.label13.Text = "单价1";
            // 
            // price1
            // 
            this.price1.Location = new System.Drawing.Point(332, 382);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(128, 25);
            this.price1.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(256, 354);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 31;
            this.label14.Text = "换卡标志";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(256, 323);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 29;
            this.label15.Text = "修改标志";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(256, 571);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 15);
            this.label20.TabIndex = 45;
            this.label20.Text = "购水次数";
            // 
            // buycount
            // 
            this.buycount.Location = new System.Drawing.Point(332, 568);
            this.buycount.Name = "buycount";
            this.buycount.Size = new System.Drawing.Size(128, 25);
            this.buycount.TabIndex = 44;
            this.buycount.Text = "255";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(256, 540);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 15);
            this.label21.TabIndex = 43;
            this.label21.Text = "购水金额";
            // 
            // chargetype
            // 
            this.chargetype.FormattingEnabled = true;
            this.chargetype.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.chargetype.Location = new System.Drawing.Point(332, 599);
            this.chargetype.Name = "chargetype";
            this.chargetype.Size = new System.Drawing.Size(128, 23);
            this.chargetype.TabIndex = 46;
            this.chargetype.Tag = "chargetype";
            this.chargetype.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(256, 602);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 47;
            this.label16.Text = "充值类型";
            // 
            // modiflag
            // 
            this.modiflag.FormattingEnabled = true;
            this.modiflag.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.modiflag.Location = new System.Drawing.Point(332, 320);
            this.modiflag.Name = "modiflag";
            this.modiflag.Size = new System.Drawing.Size(128, 23);
            this.modiflag.TabIndex = 48;
            this.modiflag.Tag = "modiflag";
            this.modiflag.Text = "2";
            // 
            // resettype
            // 
            this.resettype.FormattingEnabled = true;
            this.resettype.Items.AddRange(new object[] {
            "0",
            "1"});
            this.resettype.Location = new System.Drawing.Point(93, 444);
            this.resettype.Name = "resettype";
            this.resettype.Size = new System.Drawing.Size(128, 23);
            this.resettype.TabIndex = 49;
            this.resettype.Tag = "resettype";
            this.resettype.Text = "0";
            // 
            // modirfromid
            // 
            this.modirfromid.FormattingEnabled = true;
            this.modirfromid.Items.AddRange(new object[] {
            "0",
            "1"});
            this.modirfromid.Location = new System.Drawing.Point(332, 351);
            this.modirfromid.Name = "modirfromid";
            this.modirfromid.Size = new System.Drawing.Size(128, 23);
            this.modirfromid.TabIndex = 50;
            this.modirfromid.Tag = "modirfromid";
            this.modirfromid.Text = "0";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(310, 162);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(143, 40);
            this.button10.TabIndex = 53;
            this.button10.Text = "单位代码";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(161, 162);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(143, 40);
            this.button11.TabIndex = 52;
            this.button11.Text = "读卡数据";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.ReadCard_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(12, 162);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(143, 40);
            this.button12.TabIndex = 51;
            this.button12.Text = "换表卡";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(502, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 15);
            this.label17.TabIndex = 56;
            this.label17.Text = "label17";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(310, 209);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 57;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 58;
            this.label6.Text = "预置水量";
            // 
            // txtSalemoney
            // 
            this.txtSalemoney.Location = new System.Drawing.Point(332, 537);
            this.txtSalemoney.Name = "txtSalemoney";
            this.txtSalemoney.Size = new System.Drawing.Size(128, 25);
            this.txtSalemoney.TabIndex = 59;
            this.txtSalemoney.Text = "167772";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(588, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(251, 25);
            this.txtCode.TabIndex = 60;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(515, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 15);
            this.label18.TabIndex = 61;
            this.label18.Text = "单位代码";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 747);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtSalemoney);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.modirfromid);
            this.Controls.Add(this.resettype);
            this.Controls.Add(this.modiflag);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.chargetype);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.buycount);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.step2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.price3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.limit);
            this.Controls.Add(this.txtSalewater);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.overdraft);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metertypeno);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox metertypeno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox limit;
        private System.Windows.Forms.TextBox txtSalewater;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox warn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox overdraft;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox step2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox step1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox price2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox price3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox price1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox buycount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox chargetype;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox modiflag;
        private System.Windows.Forms.ComboBox resettype;
        private System.Windows.Forms.ComboBox modirfromid;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalemoney;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label18;
    }
}

