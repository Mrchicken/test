using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WindowsFormsApp2
{
    /// <summary>
    /// 宁波IC卡接口
    /// </summary>
    public class Ultimate
    {
        /// <summary>
        /// 读卡器测试
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        [DllImport("nbsbRF.dll", EntryPoint = "RF_ReaderTest", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int RF_ReaderTest(int port);

        /// <summary>
        /// 注册,调用功能接口前调用
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        [DllImport("nbsbRF.dll", EntryPoint = "Setup_factory", CharSet = CharSet.Ansi)]
        public static extern int Setup_factory(char[] code);

        /// <summary>
        /// 复位卡
        /// </summary>
        /// <param name="port"></param>
        /// <param name="metertypeno"></param>
        /// <param name="userid"></param>
        /// <param name="date"></param>
        /// <param name="resettype"></param>
        /// <returns></returns>
        [DllImport("nbsbRF.dll", EntryPoint = "MakeResetCard", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MakeResetCard(int port, int metertypeno, string userid, string date, int resettype);
        /// <summary>
        /// 清零卡
        /// </summary>
        /// <param name="port"></param>
        /// <param name="metertypeno"></param>
        /// <param name="userid"></param>
        /// <param name="date"></param>
        /// <param name="resettype"></param>
        /// <returns></returns>
        [DllImport("nbsbRF.dll", EntryPoint = "MakeClearCard", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MakeClearCard(int port, int metertypeno, string userid, string date, int resettype);
        /// <summary>
        /// 用户卡,充值卡,
        /// </summary>
        /// <param name="port"></param>
        /// <param name="metertypeno"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        [DllImport("nbsbRF.dll", EntryPoint = "MakeUserCard", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MakeUserCard(int port, int metertypeno, string userid);
        
        /// <summary>
        /// 设置卡
        /// </summary>
        /// <param name="port"></param>
        /// <param name="metertypeno"></param>
        /// <param name="warn"></param>
        /// <param name="overdraft"></param>
        /// <param name="limit"></param>
        /// <param name="salewater">预置水量,最大值65,但是测试时,不等0就会出现"写入保护内存"的错误</param>
        /// <returns></returns>
        [DllImport("nbsbRF.dll", EntryPoint = "MakeStepCard", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MakeStepCard(int port, int metertypeno, int warn, int overdraft, int limit, int salewater);

        /// <summary>
        /// 换表卡
        /// </summary>
        /// <param name="port"></param>
        /// <param name="metertypeno"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
         [DllImport("nbsbRF.dll", EntryPoint = "ChangeMeterCard", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ChangeMeterCard(int port, int metertypeno, string userid);

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        [DllImport("nbsbRF.dll", EntryPoint = "RF_Init", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int RF_Init(int port);
        /// <summary>
        /// 参数卡
        /// </summary>
        /// <param name="port"></param>
        /// <param name="metertypeno"></param>
        /// <param name="warn">最大值65,输入66时读卡时变成0</param>
        /// <param name="overdraft">最大值65,输入66时读卡时变成0</param>
        /// <param name="limit">最大值2147483,填2147484时再读出来会变成-2147483</param>
        /// <param name="date"></param>
        /// <returns></returns>
        [DllImport("nbsbRF.dll", EntryPoint = "MakeParaCard", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MakeParaCard(int port, int metertypeno, int warn, int overdraft, int limit, string date);

        /// <summary>
        /// 价格卡,已测试通过
        /// </summary>
        /// <param name="port"></param>
        /// <param name="metertypeno"></param>
        /// <param name="price1"></param>
        /// <param name="step1"></param>
        /// <param name="price2"></param>
        /// <param name="step2"></param>
        /// <param name="price3"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        [DllImport("nbsbRF.dll", EntryPoint = "MakePriceCard", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MakePriceCard(int port, int metertypeno, double price1, int step1, double price2, int step2, double price3, [MarshalAs(UnmanagedType.LPStr)]StringBuilder date);

        /// <summary>
        /// 读卡
        /// </summary>
        /// <param name="port">端口</param>
        /// <param name="rfromid">卡号,射频卡出厂序列号</param>
        /// <param name="userid">用户号,用户卡号</param>
        /// <param name="cardtype" >卡类型</param>
        /// <param name="cardflag">刷卡状态,表示是否发卡后在水表上刷过,0未刷  1 已刷</param>
        /// <param name="price">单价,单价数组,长度3,传入数组的第一个元素的地址 参考<seealso cref="https://ask.csdn.net/questions/349922"/></param>
        /// <param name="step">阶梯量,阶梯量数组,长度2,传入数组的第一个元素的地址 参考<seealso cref="https://ask.csdn.net/questions/349922"/></param>
        /// <param name="warn"></param>
        /// <param name="overdraft"></param>
        /// <param name="limit"></param>
        /// <param name="salemoney">购水金额,表示当此卡是购水卡时返回购水金额（元）</param>
        /// <param name="buycount">购水次数,未刷水表时表示当此卡是购水卡时返回购水次数,已刷水表时表示返回水表充值次数</param>
        /// <param name="totalusage">累积用水量</param>
        /// <param name="leftmoney">剩余金额</param>
        /// <param name="reed">磁干扰标识 （reed）（0，正常，1，异常）</param>
        /// <param name="valve">阀门状态 （valve）（0正常，1，损坏）</param>
        /// <param name="flash">读写FLASH（flash）（0，正常，1，异常）</param>
        /// <param name="battery">电池状态 （battery）（0正常，1，低电压）</param>
        /// <param name="meterdate"></param>
        /// <returns></returns>
        [DllImport("nbsbRF.dll", EntryPoint = "ReadCard", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadCard(int port, [MarshalAs(UnmanagedType.LPStr)] StringBuilder rfromid, [MarshalAs(UnmanagedType.LPStr)]StringBuilder userid, 
            ref CardType cardtype, ref int cardflag, ref double price, ref int step, ref int warn, ref byte overdraft, ref int limit, ref double salemoney, 
            ref int buycount, ref double totalusage, ref double leftmoney, ref int reed, ref int valve, ref int flash, ref int battery, [MarshalAs(UnmanagedType.LPStr)]
        StringBuilder meterdate);
         /// <summary>
        /// 充值,与厂家沟通后,由于卡片容量的问题,不能在该接口上写入参数和单价,只能使用对应的卡进行修改
        /// </summary>
        /// <param name="port"></param>
        /// <param name="metertypeno">子表号,其他接口传进去的虽然是userid读出来的是metertypeno</param>
        /// <param name="userid">用户号</param>
        /// <param name="modiflag">固定为0,无用</param>
        /// <param name="modirfromid"> 0表示不换卡，1表示更换用户卡</param>
        /// <param name="chargetype">0用于购水；1用于补水；2用于换表；</param>
        /// <param name="price1">固定为0,无用</param>
        /// <param name="step1">固定为0,无用</param>
        /// <param name="price2">固定为0,无用</param>
        /// <param name="step2">固定为0,无用</param>
        /// <param name="price3">固定为0,无用</param>
        /// <param name="salemoney">购水金额,最大值167772</param>
        /// <param name="buycount">购水次数,最大值255</param>
        /// <param name="warn">固定为0,无用</param>
        /// <param name="overdraft">固定为0,无用</param>
        /// <param name="limit">固定为0,无用</param>
        /// <returns></returns>
        [DllImport("nbsbRF.dll", EntryPoint = "ChargeWater", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ChargeWater(int port, int metertypeno, [MarshalAs(UnmanagedType.LPStr)]StringBuilder userid, int modiflag, int modirfromid, int chargetype, 
            double price1, int step1, double price2, int step2, double price3, double salemoney, int buycount, int warn, int overdraft, int limit);
    }
}
