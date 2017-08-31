using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSERP_SO311
{
   public class SoInfo_1
    {
        /// <summary>
        /// 销售订单号
        /// </summary>
        public string Csocode { get; set; }
        /// <summary>
        /// 母件存货编码
        /// </summary>
        public string BCinvcode { get; set; }
       /// <summary>
       /// 子件编码
       /// </summary>
        public string cInvCode { get; set; }
       /// <summary>
       /// 子件名称
       /// </summary>
        public string cInvName { get; set; }
       /// <summary>
       /// 子件规格
       /// </summary>
        public string cinvstd { get; set; }
       /// <summary>
       /// 计量单位
       /// </summary>
        public string ccomunitName { get; set; }
       /// <summary>
       /// 使用数量
       /// </summary>
        public double Number { get; set; }
       /// <summary>
       /// 子件存货大类编码
       /// </summary>
        public string cInvCCode { get; set; }
       /// <summary>
       /// 含税子单价
       /// </summary>
        public double  Price { get; set; }
       
    }
   public class zhrs_t_zzcSO_SOAddSeriesInfo 
   {
       /// <summary>
       /// 订单号
       /// </summary>
       public string Csocode { get; set; }
       /// <summary>
       /// 母件存货编码
       /// </summary>
       public string Cinvcodes { get; set; }
       /// <summary>
       /// 子件存货编码
       /// </summary>
       public string Cinvcode { get; set; }
       /// <summary>
       /// 子件存货名称
       /// </summary>
       public string CinvName { get; set; }
       /// <summary>
       /// 子件规格型号
       /// </summary>
       public string Cinvstd { get; set; }
       /// <summary>
       /// 单位
       /// </summary>
       public string CcomunitName { get; set; }
       /// <summary>
       /// 子件存货大类编码
       /// </summary>
       public string cInvCCode { get; set; }
       /// <summary>
       /// 区分手动录入或系统分配
       /// </summary>
       public string COption1 { get; set; }
       /// <summary>
       /// 拆单员/业务员
       /// </summary>
       public string COption2 { get; set; }
       /// <summary>
       /// 录入时间
       /// </summary>
       public DateTime SAddDate { get; set; }
       /// <summary>
       /// 使用数量
       /// </summary>
       public decimal BaseQtyND { get; set; }
       /// <summary>
       /// 需使用总数量
       /// </summary>
       public decimal Ciquantity { get; set; }
       /// <summary>
       /// 单价
       /// </summary>
       public decimal SiQuotedPrice { get; set; }
       /// <summary>
       /// 金额
       /// </summary>
       public decimal SiSum { get; set; }

   }
   public class Count_sql 
   {
       /// <summary>
       /// 页码
       /// </summary>
       public int PageIndex { get; set; }
       /// <summary>
       /// 每页记录数
       /// </summary>
       public int PageSize { get; set; }
   }
}
