using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            date.Text = DateTime.Now.ToString("yyMMdd");
            price1.Text = "1.00";
            price2.Text = "2.00";
            price3.Text = "3.00";

            step1.Text = "20";
            step2.Text = "40";

            string code = "0000000000000000";
            this.txtCode.Text = code;
            int ret = Ultimate.Setup_factory(code.ToCharArray());
            //MessageBox.Show(ret.ToString());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int com = int.Parse(comboBox1.Text);
            int i = Ultimate.RF_ReaderTest(com);
            label17.Text = i.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int com = int.Parse(comboBox1.Text);
            int i = Ultimate.RF_Init(com);
            label17.Text = i.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int com = int.Parse(comboBox1.Text);
            int MeterTypeNo = int.Parse(metertypeno.Text);
            string Userid = userid.Text;
            string Date = date.Text;
            int ResetType = int.Parse(resettype.Text);

            int ret = Ultimate.MakeResetCard(com, MeterTypeNo, Userid, Date, ResetType);

            label17.Text = ret.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int com = int.Parse(comboBox1.Text);
            int MeterTypeNo = int.Parse(metertypeno.Text);
            string Userid = userid.Text;
            string Date = date.Text;
            int ResetType = int.Parse(resettype.Text);


            int ret = Ultimate.MakeClearCard(com, MeterTypeNo, Userid, Date, ResetType);

            label17.Text = ret.ToString();
        }
        /// <summary>
        /// 设置卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                port = int.Parse(comboBox1.Text);

                int ret = -1;

                //long MeterTypeNo = int.Parse(metertypeno.Text);

                //long Warn = int.Parse(warn.Text);
                //long Overdraft = int.Parse(overdraft.Text);
                //long Limit = int.Parse(limit.Text);
                //long Salewater = int.Parse(txtSalewater.Text);
                //ret = Class1.MakeStepCard(port, ref MeterTypeNo, ref Warn, ref Overdraft, ref Limit, ref Salewater);


                int MeterTypeNo = int.Parse(metertypeno.Text);

                int Warn = int.Parse(warn.Text);
                int Overdraft = int.Parse(overdraft.Text);
                int Limit = int.Parse(limit.Text);
                int Salewater = int.Parse(txtSalewater.Text);
                ret = Ultimate.MakeStepCard(port, MeterTypeNo, Warn, Overdraft, Limit, Salewater);
                //   ret = Class1.MakeStepCard(port, ToIntPtr(MeterTypeNo), ToIntPtr(Warn), ToIntPtr(Overdraft), ToIntPtr(Limit), ToIntPtr(Salewater));

                label17.Text = ret.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int com = int.Parse(comboBox1.Text);
            int MeterTypeNo = int.Parse(metertypeno.Text);
            string Userid = userid.Text;

            int ret = Ultimate.MakeUserCard(com, MeterTypeNo, Userid);

            label17.Text = ret.ToString();
        }

        /// <summary>
        /// 参数卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int com = int.Parse(comboBox1.Text);
                int MeterTypeNo = int.Parse(metertypeno.Text);
                string Userid = userid.Text;
                int Warn = int.Parse(warn.Text);
                int Overdraft = int.Parse(overdraft.Text);
                int Limit = int.Parse(limit.Text);
                string Date = date.Text;

                int ret = Ultimate.MakeParaCard(com, MeterTypeNo, Warn, Overdraft, Limit, Date);

                label17.Text = (ret.ToString());
                ReadCard_Click(null, null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        /// <summary>
        /// 价格卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int com = int.Parse(comboBox1.Text);
                var MeterTypeNo = Convert.ToInt32(metertypeno.Text);
                Decimal Price1 = Decimal.Parse(price1.Text);
                Decimal Price2 = Decimal.Parse(price2.Text);
                Decimal Price3 = Decimal.Parse(price3.Text);

                var Price1_d = (float)Price1;
                var Price2_d = (float)Price2;
                var Price3_d = (float)Price3;

                int Step1 = int.Parse(step1.Text);
                int Step2 = int.Parse(step2.Text);
                StringBuilder Date = new StringBuilder(date.Text, 6);
                string dateStr = date.Text;
                int ret = 0;
                ret = Ultimate.MakePriceCard(com, MeterTypeNo, Price1_d, Step1, Price2_d, Step2, Price3_d, Date);
                // ret = Class1.MakePriceCard(com, ref MeterTypeNo, ref Price1,  Step1, ref Price2,  Step2, ref Price3, Date);
                // ret = Class1.MakePriceCard(com, MeterTypeNo, Price1, Step1, Price2, Step2, Price3, Date);
                label17.Text = (ret.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private static int port = 0;//int.Parse(comboBox1.Text);

        /// <summary>
        /// 充值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            port = int.Parse(comboBox1.Text);
            int MeterTypeNo = int.Parse(metertypeno.Text);
            StringBuilder Userid = new StringBuilder(userid.Text);
            int Modiflag = int.Parse(modiflag.Text);
            int Modirformid = int.Parse(modirfromid.Text);
            int Chargetype = int.Parse(chargetype.Text);
            Double Price1 = float.Parse(price1.Text);
            Double Price2 = float.Parse(price2.Text);
            Double Price3 = float.Parse(price3.Text);
            int Step1 = int.Parse(step1.Text);
            int Step2 = int.Parse(step2.Text);
            Double Salemoney = float.Parse(txtSalemoney.Text);
            var Buycount = int.Parse(buycount.Text);
            int Warn = int.Parse(warn.Text);
            int Overdraft = int.Parse(overdraft.Text);
            int Limit = int.Parse(limit.Text);
            int ret = -1;
            ret = Ultimate.ChargeWater(port, MeterTypeNo, Userid, Modiflag, Modirformid, Chargetype,
                Price1, Step1, Price2, Step2, Price3, Salemoney, Buycount, Warn, Overdraft, Limit);

            label17.Text = (ret.ToString());

            ReadCard_Click(sender, e);

        }
        /// <summary>
        /// 读卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadCard_Click(object sender, EventArgs e)
        {
            try
            {
                port = int.Parse(comboBox1.Text);
                StringBuilder Rfromid = new StringBuilder(6);
                StringBuilder Userid = new StringBuilder(6);
                StringBuilder Meterdate = new StringBuilder(6);
                //String Rfromid = "".PadLeft(100), Userid = "".PadLeft(100), Meterdate = "".PadLeft(100);//= String.Empty.PadLeft()

                CardType Cardtype = 0;
                int Cardflag = 0;
                double[] Price = new double[3];

                int[] Step = new int[2];

                int Warn = 0;
                byte Overdraft = 0;
                int Limit = 0;
                double Salemoney = 0;
                int Buycount = 0;
                double Totalusage = 0;
                double Leftmoney = 0;
                int Reed = 0;
                int Valve = 0;
                int Flash = 0;
                int Battery = 0;
                for(int i = 0; i < 2; i++)
                {
                    Step[i] = 0;
                }

                for(int i = 0; i < 3; i++)
                {
                    Price[i] = 0.00f;
                }

                long ret = -1;
                //var pricePtr = Marshal.

                //int ret = Class1.ReadCard(port, Rfromid, Userid , Cardtype, Cardflag, Price, Step, Warn, Overdraft, Limit, Salemoney, Buycount, Totalusage, Leftmoney, Read, Value, Flash, Battery, Meterdate );


                //var RfromidPtr = Marshal.StringToHGlobalAnsi(Rfromid);
                //var UseridPtr = Marshal.StringToHGlobalAnsi(Userid);
                //var MeterdatePtr = Marshal.StringToHGlobalAnsi(Meterdate);

                //ret = Class1.ReadCard(port, RfromidPtr, UseridPtr ,ref Cardtype,ref Cardflag,ref Price,ref Step,ref Warn,ref Overdraft,ref Limit,ref Salemoney,ref Buycount,ref Totalusage,ref Leftmoney,ref Read,ref Value,ref Flash,ref Battery, MeterdatePtr );

                ret = Ultimate.ReadCard(port, Rfromid, Userid, ref Cardtype, ref Cardflag, ref Price[0], ref Step[0], ref Warn, ref Overdraft, ref Limit, ref Salemoney, ref Buycount, ref Totalusage, ref Leftmoney, ref Reed, ref Valve, ref Flash, ref Battery, Meterdate);
                if(ret == 0)
                {

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("读卡成功");
                    sb.AppendLine("卡号：" + Rfromid.ToString());
                    sb.AppendLine("用户号：" + Userid.ToString());
                    sb.AppendLine("卡类型：" + Cardtype + "(" + (int)Cardtype + ")");
                    sb.AppendLine("刷卡状态：" + Cardflag);
                    sb.AppendLine("购水金额：" + Salemoney);
                    sb.AppendLine("购水次数：" + Buycount);
                    sb.AppendLine("报警水量:" + Warn);
                    sb.AppendLine("透支水量:" + Overdraft);
                    sb.AppendLine("囤积量:" + Limit);
                    sb.AppendLine("累积用水量：" + Totalusage);
                    sb.AppendLine("剩余金额：" + Leftmoney);
                    sb.AppendLine("磁干扰标识：" + Reed);
                    sb.AppendLine("阀门状态：" + Valve);
                    sb.AppendLine("读写Flash：" + Flash);
                    sb.AppendLine("电池状态：" + Battery);
                    for(int i = 0; i < Price.Length; i++)
                    {
                        sb.AppendLine("单价" + (i + 1) + "：" + Price[i]);
                    }
                    for(int i = 0; i < Step.Length; i++)
                    {
                        sb.AppendLine("阶梯量" + (i + 1) + "：" + Step[i]);
                    }
                    sb.AppendLine("日期：" + Meterdate.ToString());
                    label17.Text = (sb.ToString());




                    //MessageBox.Show(string.Format("读卡成功！\r\n卡号:{0}\r\n用户号:{1}\r\n卡类型:{2}\r\n刷卡状态:{3}\r\n购水金额:{4}\r\n" +
                    //    "购水次数:{5}\r\n累积用水量:{6}\r\n剩余金额:{7}\r\n磁干扰标识:{8}\r\n阀门状态:{9}\r\n" +
                    //    "读写:{10}\r\n电池状态:{11}\r\n单价1:{12}\r\n单价2:{13}\r\n单价3:{14}\r\n阶梯1:{15}\r\n阶梯2:{16}\r\n日期:{17}\r\n",
                    //    port, Rfromid, Userid, Cardtype, Cardflag, Price[0], Price[1], Price[2], Step[0], Step[1], Warn, Overdraft, Limit,
                    //    Salemoney, Buycount, Totalusage, Leftmoney, Read, Value, Flash, Battery, Meterdate));

                }
                else
                {
                    label17.Text = (ret.ToString());
                }
            }
            catch(Exception ex)
            {
                label17.Text = (ex.Message);
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            string code = this.txtCode.Text;
            int ret = Ultimate.Setup_factory(code.ToCharArray());
            label17.Text = ret.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int com = int.Parse(comboBox1.Text);
            int MeterTypeNo = int.Parse(metertypeno.Text);
            string Userid = userid.Text;

            int ret = Ultimate.ChangeMeterCard(com, MeterTypeNo, Userid);

            label17.Text = ret.ToString();

        }


        private IntPtr ToIntPtr<T>(T t)
        {
            IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(t));
            Marshal.StructureToPtr(t, ptr, false);
            return ptr;
        }
        private T FromIntPtr<T>(IntPtr ptr, T t)
        {
            return (T)Marshal.PtrToStructure(ptr, typeof(T));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double i = 12.2;
            IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(i));
            Marshal.StructureToPtr(i, ptr, false);
            i = 10;
            MessageBox.Show(i.ToString());

            i = (double)Marshal.PtrToStructure(ptr, i.GetType());
            MessageBox.Show(i.ToString());
        }

      
    }
}
