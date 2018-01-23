using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LostAndFound.General
{
    /// <summary>
    /// Release 的摘要说明
    /// </summary>
    public class Release : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string keys = context.Request["Action"];
            switch (keys)
            {

                ///获取密码
                //case "GetZHMM":
                //    GetPassword(context);
                //    break;
                //case "DeldateSqlDate":
                //    DeleteAccount(context);
                    //break;
                    //case "findZW":
                    //    FindZW(context);
                    //    break;


            }
        }

        /// <summary>
        /// 增加后勤管理员用户
        /// </summary>
        /// <param name="context"></param>
        //private void GetPassword(HttpContext context)
        //{
            //int zhsm = Convert.ToInt32(context.Request["zhsm"]);
            //int addQxid = Convert.ToInt32(context.Request["addQxid"]);
            //BLL.BLL_SystemAdministrator zh = new BLL.BLL_SystemAdministrator();
            //IList<U_SystemAdministrator> date = zh.Getpassword(zhsm, addQxid);
            //JavaScriptSerializer jss = new JavaScriptSerializer();
            //string json = jss.Serialize(date);
            //context.Response.Write("{ \"jsons\":" + json + "}");
        //}
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}