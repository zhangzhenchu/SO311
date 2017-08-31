using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSERP_SO311
{
    
    public class SOaddInfo
    {
        /// <summary>
        /// 销售订单号
        /// </summary>
        public string Csocode { get; set; }
        /// <summary>
        /// 母件存货大类编码
        /// </summary>
        public string CInvCCode { get; set; }
        /// <summary>
        /// 母件存货大类编码前两个字母
        /// </summary>
        public string CInvCCode_CB { get; set; }
        /// <summary>
        /// 母件存货编码
        /// </summary>
        public string Cinvcode { get; set; }
        /// <summary>
        /// SO_SODetails表的isosid号  销售订单子表标识2  
        /// </summary>
        public int SO_SODetails_isosid { get; set; }
  

        /// <summary>
        ///  数量
        /// </summary>
        public double Siquantity { get; set; }

        /// <summary>
        ///  含税单价
        /// </summary>
        public double SiQuotedPrice { get; set; }

        /// <summary>
        ///  含税合计金额
        /// </summary>
        public double SiSum { get; set; }

        /// <summary>
        /// 添加的当前时间
        /// </summary>
        public DateTime SAddDate { get; set; }





    }
}
