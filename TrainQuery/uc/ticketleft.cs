using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _TrainQuery_;
using System.Net;

namespace TrainQuery.uc
{
    public partial class ticketleft : UserControl
    {
        public ticketleft()
        {
            InitializeComponent();
        }
        //public string bookvalue { get; set; }
        //public string key { get; set; }
        //public string values { get; set; }
        ////public CookieCollection ccl { get; set; }
        //public string[] postdata { get; set; }
        //public string trainPassType{ get; set; }
        //public string trainClass{ get; set; }
        //public string date{ get; set; }
        //public string time{ get; set; }
        //public string includeStudent { get; set; }
        //public ticketleft(Tickets ticket, string key, string values, CookieCollection ccl, string[] postdata, string trainPassType, string trainClass, string date, string time, string includeStudent)
        //{
        //    InitializeComponent();
        //    this.key = key;
        //    this.values = values;
        //    //this.ccl = ccl;
        //    this.postdata = postdata;
        //    this.trainPassType=trainPassType;
        //    this.trainClass=trainClass;
        //    this.date=date;
        //    this.time=time;
        //    this.includeStudent = includeStudent;


        //    linkbId.Text = ticket.trainId;
        //    if (ticket.from.Contains("[始]"))
        //    {
        //        lbFrom.ForeColor = Color.Red;
        //    }
        //    lbFrom.Text = ticket.from;
        //    if (ticket.to.Contains("[终]"))
        //    {
        //        lbTo.ForeColor = Color.Red;
        //    }


        //    lbTo.Text = ticket.to;
        //    lbCost.Text = ticket.cost;
        //    lbSW.Text = ticket.trainSW;
        //    lbTD.Text = ticket.trainTD;
        //    lbYD.Text = ticket.trainYD;
        //    lbED.Text = ticket.trainED;
        //    lbGJRW.Text = ticket.trainGJRW;
        //    lbRW.Text = ticket.trainRW;
        //    lbYW.Text = ticket.trainYW;
        //    lbRZ.Text = ticket.trainRZ;
        //    lbYZ.Text = ticket.trainYZ;
        //    lbWZ.Text = ticket.trainWZ;
        //    lbQT.Text = ticket.trainQT;
        //    btnBook.Tag = ticket.trainValue;
        //    linkbId.Tag = ticket.trainValue;//可以将信息用来查询该列车的路线站点

        //    this.bookvalue = ticket.trainValue;

        //    foreach (Control item in panel1.Controls)
        //    {
        //        if (item.Text == "无"||btnBook.Tag.ToString()=="[售完]")
        //        {
        //            item.ForeColor = Color.Silver;
        //        }
        //    }
            ////给button添加一个点击事件
            //btnBook.Click += new EventHandler(btnBook_Click);
            //linkbId.Click += new EventHandler(linkbId_Click);
        //}

    }
}
