using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSERP_SO311
{
   public class SODetailsinfo
    {
       /// <summary>
       /// 业务类型
       /// </summary>
       public string cbustype { get; set; }
       /// <summary>
       /// 销售类型
       /// </summary>
       public string cstname { get; set; }
      /// <summary>
      /// 订单号
      /// </summary>
       public string csocode { get; set; }
       /// <summary>
       /// 订单日期
       /// </summary>
       public string ddate { get; set; }
       /// <summary>
       /// 客户简称
       /// </summary>
       public string ccusabbname { get; set; }
       /// <summary>
       /// 币种
       /// </summary>
       public string cexch_name { get; set; }
       /// <summary>
       /// 汇率
       /// </summary>
       public string iexchrate { get; set; }
       /// <summary>
       /// 销售部门
       /// </summary>
       public string cdepname { get; set; }
      /// <summary>
      /// 业务员
      /// </summary>
       public string cpersonname { get; set; }
        /// <summary>
        /// 存货编码
        /// </summary>
        public string cInvCode { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public double  iquantity { get; set; }
        /// <summary>
        /// 原币含税单价
        /// </summary>
        public double itaxunitprice { get; set; }
        /// <summary>
        /// 本币含税单价
        /// </summary>
        public double inatitaxunitprice { get; set; }
        /// <summary>
        /// 原币无税单价 
        /// </summary>
        public double iUnitPrice { get; set; }
        /// <summary>
        /// 原币无税金额\合计
        /// </summary>
        public double iMoney { get; set; }
        /// <summary>
        /// 原币税额
        /// </summary>
        public double itax { get; set; }
        /// <summary>
        /// 原币价税合计
        /// </summary>
        public double isum { get; set; }

           /// <summary>
        /// 本币无税单价
           /// </summary>
        public double inatunitprice { get; set; }
       /// <summary>
        /// 本币无税金额 
       /// </summary>
        public double inatmoney { get; set; }

        /// <summary>
        /// 本币税额 
        /// </summary>
        public double inattax { get; set; }


        /// <summary>
        /// 本币价税合计 
        /// </summary>
        public double inatsum { get; set; } 

        /// <summary>
        /// 税率
        /// </summary>
        public double iTaxRate { get; set; }

        /// <summary>
        /// 备注内容
        /// </summary>
        public string ctext { get; set; }
        /// <summary>
        /// 存货名称
        /// </summary>
        public string cInvName { get; set; }
        /// <summary>
        /// 制式/开机界面自定义项值
        /// </summary>
        public string Cvalue { get; set; }
        /// <summary>
        /// 显示语言
        /// </summary>
        public string Cvalue11 { get; set; }
        /// <summary>
        /// LOGO
        /// </summary>
        public string Cvalue12 { get; set; }
        /// <summary>
        /// 软件信息
        /// </summary>
        public string useQty { get; set; }
        /// <summary>
        /// 型号规格
        /// </summary>
        public string cInvStd { get; set; }
        /// <summary>
        /// 主计量单位名称
        /// </summary>
        public string cComUnitName { get;set; }
        /// <summary>
        /// So_SOMain表的id号  销售订单主表标识 
        /// </summary>
        public int SO_SOMain_Id { get; set; }
        /// <summary>
        /// SO_SODetails表的isosid号  销售订单子表标识2  
        /// </summary>
        public int SO_SODetails_isosid { get; set; }
        /// <summary>
        /// 行号
        /// </summary>
        public int iRowNo { get; set; }
       /// <summary>
       /// 预发货日期
       /// </summary>
        public string dpredate { get; set; }
        /// <summary>
        /// 预完工日期 dpremodate
        /// </summary>
        public string dpremodate { get; set; }
       /// <summary>
       /// 审核时间
       /// </summary>
        public string dverifysystime { get; set; }




        ///// <summary>
        ///// 数量
        ///// </summary>
        //public string  Copyiquantity { get; set; }
        ///// <summary>
        ///// 原币含税单价
        ///// </summary>
        //public string Copyitaxunitprice { get; set; }
        ///// <summary>
        ///// 本币含税单价
        ///// </summary>
        //public string Copyinatitaxunitprice { get; set; }
        ///// <summary>
        ///// 原币无税单价 
        ///// </summary>
        //public string CopyiUnitPrice { get; set; }
        ///// <summary>
        ///// 原币无税金额\合计
        ///// </summary>
        //public string CopyiMoney { get; set; }
        ///// <summary>
        ///// 原币税额
        ///// </summary>
        //public string Copyitax { get; set; }
        ///// <summary>
        ///// 原币价税合计
        ///// </summary>
        //public string Copyisum { get; set; }

        ///// <summary>
        ///// 本币无税单价
        ///// </summary>
        //public string Copyinatunitprice { get; set; }
        ///// <summary>
        ///// 本币无税金额 
        ///// </summary>
        //public string Copyinatmoney { get; set; }

        ///// <summary>
        ///// 本币税额 
        ///// </summary>
        //public string Copyinattax { get; set; }


        ///// <summary>
        ///// 本币价税合计 
        ///// </summary>
        //public string Copyinatsum { get; set; }

        ///// <summary>
        ///// 税率
        ///// </summary>
        //public string CopyiTaxRate { get; set; }

       /// <summary>
       /// 是否订单BOM
       /// </summary>
        public string borderbom { get; set; }
        /// <summary>
        /// 是否客户BOM
        /// </summary>
        public string busecusbom { get; set; }
        /// <summary>
        /// 需求跟踪方式
        /// </summary>
        public string idemandtype { get; set; }
       /// <summary>
       /// 关闭人
       /// </summary>
        public string cclose { get; set; }






       


       
    }
}
