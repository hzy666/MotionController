﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using static OQC_IC_CHECK_System.EntireMachine;

namespace OQC_IC_CHECK_System
{
    class GlobalVar
    {
        public static IntPtr gl_IntPtr_MainWindow;         //Feeding窗体句柄值
        public static IntPtr gl_IntPtr_MsgWindow;//消息窗体句柄
        //---------windows消息---------------------0x4000  - 0x4100
        private const int Num4000 = 0x4000;         //初始量
        public const int WM_Initialize = Num4000 + 1;        //主窗体通知Feeding 加载完毕

        public const int WM_FixedMotion = Num4000 + 2;     //定点运动
        public const int WM_PCSCheckEMG = Num4000 + 3; //pcs检查机异常需要报警
        public const int WM_PCSCheckEMG_Reset = Num4000 + 4;//PCS检查机报警解除
        public const int WM_PCSAllowDropBoard = Num4000 + 5;//PCS检查机允许下料
        public const int WM_PCSConnection = Num4000 + 6;//握手成功
        public const int WM_PCSAcceptData = Num4000 + 7;//PCS检查机接收数据成功
        public const int WM_PCSStartCheck = Num4000 + 8;//PCS接收到位信号开始检查
        public const int WM_PCSForbideDrop = Num4000 + 9;//PCS检查机检查操作完成
        public const int WM_MsgAlarmDisable = Num4000 + 10;//消除弹框
        public const int WM_PCSForbideWork = Num4000 + 11;//禁止作业
        public const int WM_PCSNG = Num4000 + 12;//PCSNG
        public const int WM_PCSResult = Num4000 + 13;//pcs解析完成
        public const int WM_PCSArrive = Num4000 + 14;//PCS到位【IC屏蔽】


        public const int WM_SYSCommand = 0x112;                     //系统消息
        public const int WM_Mininize = 0xF020;                      //窗口最小化

        //---------Init.ini文件保存参数-------Section和Key-------
        #region sheet
        public const string gl_inisection_Sheet = "Sheet";
        public const string gl_iniKey_BoardCount = "BoardCount";
        public const string gl_iniKey_ICFailCount = "ICFailCount";
        #endregion
        #region CCDInfo
        public const string gl_inisection_CCD = "CCDInfo";      //相机
        public const string gl_iniKey_CCDMode = "ConnectMode";
        public const string gl_iniKey_ICRunMatrix = "ICRunMatrix";
        public const string gl_iniKey_SavePath = "PictureSavePath";
        public const string gl_iniKey_ICForbidden = "ICForbidden";

        #endregion
        #region product
        public const string gl_inisection_Product = "Product";
        public const string gl_iniKey_Product = "Product";
        #endregion
        #region SoftWare
        public const string gl_inisection_SoftWare = "SoftWare";      //软件
        public const string gl_iniKey_LinkX = "LinkX";
        public const string gl_iniKey_LinkY = "LinkY";
        public const string gl_iniKey_LinkA = "LinkA";
        public const string gl_iniKey_LinkB = "LinkB";
        public const string gl_iniKey_LinkC = "LinkC";
        public const string gl_iniKey_LinkD = "LinkD";
        public const string gl_iniKey_LinkZ = "LinkZ";
        public const string gl_iniKey_FeedFilePath = "FeedFilePath";//产品配置的路径，确保先读取此路径，再使用此路径的值去读取产品配置
        public const string gl_iniKey_ZPosition = "ZPosition";
        #endregion
        #region Axis
        public const string gl_inisection_Axis = "Axis";
        public const string gl_iniKey_GPRunVelHigh = "GPRunVelHigh";
        public const string gl_iniKey_GPRunVelLow = "GPRunVelLow";
        public const string gl_iniKey_GPRunAcc = "GPRunAcc";
        public const string gl_iniKey_GPRunDec = "GPRunDec";
        public const string gl_iniKey_HomeSpeed = "HomeSpeed";
        public const string gl_iniKey_RefX = "RefX";
        public const string gl_iniKey_RefY = "RefY";
        public const string gl_iniKey_EndX = "EndX";
        public const string gl_iniKey_EndY = "EndY";
        public const string gl_iniKey_RefSpeedHigh = "RefSpeedHigh";
        public const string gl_iniKey_RefSpeedLow = "RefSpeedLow";
        public const string gl_iniKey_RefAcc = "RefAcc";
        public const string gl_iniKey_RefDcc = "RefDcc";
        public const string gl_iniKey_RunSpeedHigh = "RunSpeedHigh";
        public const string gl_iniKey_RunSpeedLow = "RunSpeedLow";
        public const string gl_iniKey_RunAcc = "RunAcc";
        public const string gl_iniKey_RunDcc = "RunDcc";
        public const string gl_iniKey_RunSpeedHigh_Operate = "RunSpeedHighOperate";
        public const string gl_iniKey_RunSpeedLow_Operate = "RunSpeedLowOperate";
        public const string gl_iniKey_RunAcc_Operate = "RunAccOperate";
        public const string gl_iniKey_RunDcc_Operate = "RunDccOperate";
        public const string gl_iniKey_RunHighVel_Motor = "RunHighVel_Motor";
        public const string gl_iniKey_RunLowVel_Motor = "RunLowVel_Motor";
        public const string gl_iniKey_RunAccVel_Motor = "RunAccVel_Motor";
        public const string gl_iniKey_RunDccVel_Motor = "RunDccVel_Motor";
        public const string gl_iniKey_FeedLeft = "FeedLeft";
        public const string gl_iniKey_FeedRight = "FeedRight";
        public const string gl_iniKey_DropLeft = "DropLeft";
        public const string gl_iniKey_DropRight = "DropRight";
        public const string gl_iniKey_ICFeed = "ICFeed";
        public const string gl_iniKey_ICPhotoPosition = "ICPhotoPosition";
        public const string gl_iniKey_PCSFeed = "PCSFeed";
        public const string gl_iniKey_PCSPhotoPosition = "PCSPhotoPosition";
        public const string gl_iniKey_PCSWaitPosition = "PCSWaitPosition";
        public const string gl_iniKey_FeedSaveDistance = "FeedSaveDistance";
        public const string gl_iniKey_DropSaveDistance = "DropSaveDistance";
        public const string gl_iniKey_CylinderSuctionWaitTime = "CylinderSuctionWaitTime";
        public const string gl_iniKey_CylinderBlowWaitTime = "CylinderBlowWaitTime";
        public const string gl_iniKey_ICYInterval = "ICYInterval ";
        public const string gl_iniKey_ICXInterval = "ICXInterval";
        public const string gl_iniKey_IC_Columns = "Columns";
        public const string gl_iniKey_IC_Rows = "Rows";


        #endregion
        #region COM
        public const string gl_inisection_COM = "COM";
        public const string gl_iniKey_PcsCOM = "PcsCOM";
        #endregion
        #region modbus
        public const string gl_inisection_Ip = "IP";
        public const string gl_iniKey_FeedIP = "FeedIP";
        public const string gl_iniKey_DropIP = "DropIP";
        public const string gl_inisection_Para = "BoardFeedPara";
        public const string gl_iniKey_FeedSpeed = "FeedSpeed";//托盘上下轴速度
        public const string gl_iniKey_FeedAcc = "FeedAcc";//加减速
        public const string gl_iniKey_UPPostion = "UPFeedPosition";//上料设定运动位置 
        public const string gl_iniKey_DropPostion = "DropFeedPosition";//下料设定运动位置

        #endregion

        //---------整个解决方案变量----------------------- 

        /// <summary>
        /// 程序是否关闭
        /// </summary>
        public static bool SoftWareShutDown = false;
        /// <summary>
        /// 时间间隔
        /// </summary>
        internal const int TimerInterval = 100;
        /// <summary>
        /// 最后一次输入密码的时间，5分钟内不再要求输入密码
        /// </summary>
        internal static DateTime LastEnterPassword;

        /// <summary>
        /// 整台机器
        /// </summary>
        internal static EntireMachine Machine = new EntireMachine();

        /// <summary>
        /// Halcon相机模块
        /// </summary>
        internal static HalconCCD.CCDShow CCD;

        /// <summary>
        /// CCD的连接方式
        /// </summary>
        internal static string CCDMode = string.Empty;
        /// <summary>
        /// CAD的点坐标集合
        /// </summary>
        internal static PointInfo CADPointList = new PointInfo();

        /// <summary>
        /// IC条码字典
        /// </summary>
        internal static Dictionary<int, string> IC_Barcode_Dic = new Dictionary<int, string>();

        /// <summary>
        /// 品目
        /// </summary>
        internal static string Product = "A82TFLEX";

        /// <summary>
        /// 单反检查通信COM口
        /// </summary>
        internal static string PCS_COM = "COM3";

        /// <summary>
        /// 单反检查通信类
        /// </summary>
        internal static SerialPortModbus PCS_Port;

        /// <summary>
        /// 机器当前运行模式
        /// </summary>
        internal static RunMode RunningMode = RunMode.Normal;

        /// <summary>
        /// CAD读取运行时环境
        /// </summary>
        public static DWGdirect.Runtime.Services m_dwgdirectServices;
        /// <summary>
        /// 上料Modbus线程
        /// </summary>
        public static CModbus Feed_Modbus;
        /// <summary>
        /// 下料Modbus线程
        /// </summary>
        public static CModbus Drop_Modbus;
        /// <summary>
        /// IC拍照坐标集合
        /// </summary>
        public static List<SPoint> ICPointList = new List<SPoint>();

        /// <summary>
        /// 禁止上料轴运动
        /// </summary>
        internal static bool FeedMoveForbidden = false;
        /// <summary>
        /// 禁止下料轴运动
        /// </summary>
        public static bool DropMoveForbidden = false;
        /// <summary>
        /// ic拍照是否使用矩阵方式运动【true：是；false：使用配置文件】
        /// </summary>
        public static bool ICRunMatrix = true;
        /// <summary>
        ///托盘数量
        /// </summary>
        public static int BoardCount = 0;
        /// <summary>
        /// 解析失败数量
        /// </summary>
        public static int ICFailCount = 0;
        /// <summary>
        /// 用于判断光栅是否作用
        /// </summary>
        public static  bool IsLightSensorWorking = true;
        /// <summary>
        /// 图片存储位置
        /// </summary>
        public static string PictureSavePath = "F:/IC_TESTDATA";

        #region CAD

        public static IntPtr gl_IntPtr_ObjDWGDirect;
        public static SPoint Ref_Point_CADPos = new SPoint();   //CAD图纸中相对参考点原点
        public static SPoint point_CalPos = new SPoint();       //用作校準參考點
        public static SPoint gl_point_CalPosRef = new SPoint();    //校準參考點，调试显示图纸原始Mark点用
        public static SPoint point_ScrrenRefPoint = new SPoint();

        public static SPoint gl_Ref_Point_CADPos = new SPoint();   //CAD图纸中相对参考点原点
        public const string gl_str_TipPoint = "TIPPOINT";
        public const string gl_str_RefPoint = "REFPOINT";
        public const string gl_str_MARKPoint = "MARKPOINT";   //第二个MARK点
        public const string gl_str_ScrrenRefPoint = "SCRRENREFPOINT";      //CAD图纸左上方点块名称--相对应PC屏幕参考原点
        public const string gl_layer_RefPoint = "layer_RefCircle";
        public const string gl_layer_RunPathLayer = "RunPathLayer";
        public static SPoint gl_point_CalPos = new SPoint();       //用作校準參考點
        public static SPoint gl_point_ScrrenRefPoint = new SPoint();

        public static PointInfo gl_List_PointInfo = new PointInfo();  //所有点阵信息类型


        internal static double Point_ICXInterval = 64.157d;//IC托盘X方向间距 单位mm
        internal static double Point_ICYInterval = 62d;//IC托盘Y方向间距 单位mm
        internal static int IC_Columns = 4;//IC托盘列数
        internal static int IC_Rows = 4;//IC托盘行数


        #endregion

        #region 轴相关
        internal static AxisProperty AxisX = new AxisProperty();//X轴
        internal static AxisProperty AxisY = new AxisProperty();//Y轴
        internal static AxisProperty AxisA = new AxisProperty();//上料轴
        internal static AxisProperty AxisC = new AxisProperty();//IC上料轴
        internal static AxisProperty AxisD = new AxisProperty();//单反上料轴
        internal static AxisProperty AxisB = new AxisProperty();//下料轴
        internal static AxisProperty AxisZ = new AxisProperty();//相机轴


        internal static double ZPosition_Read = 0d;//配置文档 读取的值
        internal static double FeedSaveDistance = 200d;//上料轴轴的移动的安全距离
        internal static double DropSaveDistance = 200d;//下料轴的最小安全距离

        /// <summary>
        /// 板卡相关
        /// </summary>
        internal static PCI1285_E AxisPCI;
        internal const int ServCMDRate = 1000;//伺服的命令脉冲倍数关系 1mm
        internal const int MotorRate = 278;//电机的脉冲倍数关系 1mm
        //internal const double MotorZRate = (double)2.333 / MotorRate;//电机的脉冲倍数关系   宽幅调整2.333毫米   一个脉冲 调整的距离

        /**************尽快完成软件的限位编写*************/
        internal static readonly Range_Double AxisXRange = new Range_Double(600, -40);//X轴的运动范围
        internal static readonly Range_Double AxisYRange = new Range_Double(400, -34);//Y轴的运动范围
        internal static readonly Range_Double AxisARange = new Range_Double(670, -36.3);//A轴的运动范围
        internal static readonly Range_Double AxisBRange = new Range_Double(570, -36.3);//B轴的运动范围

        /// <summary>
        /// 紧急停止
        /// </summary>
        internal static bool EMGSTOP;

        internal static double HomeSpeed = 10000;//归原点速度
        internal static double Ref_Point_AxisX = 0.000d;//待机位  单位mm
        internal static double Ref_Point_AxisY = 450.000d;//待机位  单位mm
        internal static double End_Point_AxisX = 0;//矩阵模式结束位置 单位mm
        internal static double End_Point_AxisY = 0;//矩阵模式结束位置 单位mm
        internal static double Point_FeedLeft = 0.000d;//上料轴左行程 单位mm
        internal static double Point_FeedRight = 0.000d;//上料轴右行程 单位mm
        internal static double Point_DropLeft = 400d;//下料轴行程 单位mm
        internal static double Point_DropRight = 000;//下料轴右行程 单位mm
        internal static double Point_ICFeed = 0.00d;//IC轴上料行程
        internal static double Point_ICPhotoPosition = 0.00d;//IC轴拍照位置
        internal static double Point_PCSFeed = 0.00d;//pcs检查上料行程
        internal static double Point_PCSPhotoPosition = 0.00d;//pcs检查拍照位置
        internal static double Point_PCSWaitPosition = 0.00d;//pcs检查等待位置
        public static int CylinderSuctionWaitTime = 500;//气缸吸气等待时间
        public static int CylinderBlowWaitTime = 500;//气缸吹气等待时间


        public static double  RefHighVel = 200000;//回参考原点最快速度
        public static double RefLowVel = 10000;//回参考原点最慢速度
        public static double RefAccVel =400000;//回参考原点加速度
        public static double RefDccVel = 400000;//回参考原点减速度
        public static double RunHighVel = 200000;//运行最快速度
        public static double RunLowVel = 10000;//运行最慢速度
        public static double RunAccVel = 400000;//运行加速度
        public static double RunDccVel = 400000;//运行减速度
        public static double RunHighVel_Motor = 10000;//电机最快速度
        public static double RunLowVel_Motor = 5000;//电机最慢速度
        public static double RunAccVel_Motor = 10000;//电机加速度
        public static double RunDccVel_Motor = 10000;//电机减速度
        public static double RunHighVel_Operate = 200000;//有制品运行最快速度
        public static double RunLowVel_Operate = 10000;//有制品运行最慢速度
        public static double RunAccVel_Operate = 400000;//有制品运行加速度
        public static double RunDccVel_Operate = 400000;//有制品运行减速度
        public static uint m_GPValue_RunVelHigh_move = 20000;  //群组运动最快速度 --用于正常作业
        public static uint m_GPValue_RunVelLow_move = 20000;  //群组运动最慢速度 --用于正常作业
        public static uint m_GPValue_RunAcc_move = 10000;  //群组运动最快加速度 --用于正常作业
        public static uint m_GPValue_RunDec_move = 10000;  //群组运动最快减速度 --用于正常作业
        public static uint m_GPValue_VelHigh_low { get { return m_GPValue_RunVelHigh_move / 2; } }  //群组运动最快速度  --用于原点返回或者其他测试模式
        public static uint m_GPValue_VelLow_low { get { return m_GPValue_RunVelLow_move / 2; } }  //群组运动最慢速度   --用于原点返回或者其他测试模式
        public static uint m_GPValue_Acc_low { get { return m_GPValue_RunAcc_move / 2; } }  //群组运动最快加速度 --用于原点返回或者其他测试模式
        public static uint m_GPValue_Dec_low { get { return m_GPValue_RunDec_move / 2; } }  //群组运动最快减速度 --用于原点返回或者其他测试模式

        

        #endregion

        #region modbus
        /// <summary>
        /// 上料机IP
        /// </summary>
        public static string FeedIP = "";
        /// <summary>
        /// 下料机IP
        /// </summary>
        public static string DropIP = "";
        /// <summary>
        /// 上下料轴速度  
        /// </summary>
        public static double BoardFeedSpeed = 1000d;
        /// <summary>
        /// 上下料加减速
        /// </summary>
        public static double BoardFeedAcc = 1000d;
        /// <summary>
        /// 上料运动位置
        /// </summary>
        public static double UpBoardFeedPosition = 1000d;
        /// <summary>
        /// 下料运动位置
        /// </summary>
        public static double DropBoardFeedPosition = 1000d;
        /// <summary>
        /// IC拍照个数
        /// </summary>
        internal static int ICCount=16;
        internal static bool resetComplete=false;
        /// <summary>
        /// 屏蔽IC解析
        /// </summary>
        internal static bool ICForbiddenMode=false;
        /// <summary>
        /// 是否发送完成
        /// </summary>
        internal static bool OeeSent=false;
        #endregion

    }
}
