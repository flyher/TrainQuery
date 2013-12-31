using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _TrainQuery_
{
    //票类
    public class Tickets
    {
        /// <summary>
        /// 车次编码(购票备用)
        /// </summary>
        public string train_no { get; set; }////2400000K490M//
        /// <summary>
        /// 车次
        /// </summary>
        public string station_train_code { get; set; }//K49//
        /// <summary>
        /// 始发站编码
        /// </summary>
        public string start_station_telecode { get; set; }//BXP//
        /// <summary>
        /// 始发站
        /// </summary>
        public string start_station_name { get; set; }//北京西//
        /// <summary>
        /// 终点站编码
        /// </summary>
        public string end_station_telecode { get; set; }//ESN//
        /// <summary>
        /// 终点站
        /// </summary>
        public string end_station_name { get; set; }//恩施//
        /// <summary>
        /// 出发地编码
        /// </summary>
        public string from_station_telecode { get; set; }//BXP//
        /// <summary>
        /// 出发地
        /// </summary>
        public string from_station_name { get; set; }//北京西//	
        /// <summary>
        /// 目的站编码
        /// </summary>
        public string to_station_telecode { get; set; }//ZZF//
        /// <summary>
        /// 目的站
        /// </summary>
        public string to_station_name { get; set; }//郑州//
        /// <summary>
        /// 出发时间
        /// </summary>
        public string start_time { get; set; }//13:15//
        /// <summary>
        /// 到达时间
        /// </summary>
        public string arrive_time { get; set; }//21:47//
        public string day_difference { get; set; }//0//	
        public string train_class_name { get; set; }////
        /// <summary>
        /// 历时(小时)
        /// </summary>
        public string lishi { get; set; }//08:32//
        /// <summary>
        /// 是否允许购买该票
        /// </summary>
        public string canWebBuy { get; set; }//Y//
        /// <summary>
        /// 历时(分钟)
        /// </summary>
        public string lishiValue { get; set; }//512//
        /// <summary>
        /// 下面都是订票用的
        /// </summary>
        public string yp_info { get; set; }//1009303200402630002510093000003016800054//
        public string control_train_day { get; set; }//20301231//
        public string start_train_date { get; set; }//20131211//
        public string seat_feature { get; set; }//W3431333//	
        public string yp_ex { get; set; }//10401030//
        public string train_seat_feature { get; set; }//3//	
        public string seat_types { get; set; }//1413//
        public string location_code { get; set; }//P2//
        public string from_station_no { get; set; }//01//
        public string to_station_no { get; set; }//11//	
        public string control_day { get; set; }//19
        public string sale_time { get; set; }//0800//
        public string is_support_card { get; set; }//0//
        public string note { get; set; }//已售完//

        /// <summary>
        /// ？？？？？
        /// </summary>
        public string gg_num { get; set; }//--//
        /// <summary>
        /// 高级软卧
        /// </summary>
        public string gr_num { get; set; }//--//
        /// <summary>
        /// 其他
        /// </summary>
        public string qt_num { get; set; }//--//
        /// <summary>
        /// 软卧
        /// </summary>
        public string rw_num { get; set; }//25//
        /// <summary>
        /// 软座
        /// </summary>
        public string rz_num { get; set; }//--//
        /// <summary>
        /// 特等座
        /// </summary>
        public string tz_num { get; set; }//--//
        /// <summary>
        /// 无座
        /// </summary>
        public string wz_num { get; set; }//200//
        public string yb_num { get; set; }//--//
        /// <summary>
        /// 硬卧
        /// </summary>
        public string yw_num { get; set; }//54//
        /// <summary>
        /// 硬座
        /// </summary>
        public string yz_num { get; set; }//无//
        /// <summary>
        /// 二等座
        /// </summary>
        public string ze_num { get; set; }//--//
        /// <summary>
        /// 一等座
        /// </summary>
        public string zy_num { get; set; }//--//
        /// <summary>
        /// 商务座
        /// </summary>
        public string swz_num { get; set; }//--//
    }
}
