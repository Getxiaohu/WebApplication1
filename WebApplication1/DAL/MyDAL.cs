using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WebApplication1.DAL
{
    public class MyDAL
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int User(UserInfo u)
        {
            string sql = $"select COUNT(*) from UserInfo where UName='{u.UName}' and UPwd='{u.UPwd}' and UState=1";
            return Convert.ToInt32(DBHelper.CMD(sql));
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<Car> Show()
        {
            string sql = "select * from Car";
            var dt = DBHelper.GetDataTable(sql);
            string str = JsonConvert.SerializeObject(dt);
            List<Car> list = JsonConvert.DeserializeObject<List<Car>>(str);
            return list;
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Car ShowOne(int id)
        {
            string sql = $"select * from Car where Cid={id}";
            var dt = DBHelper.GetDataTable(sql);
            string str = JsonConvert.SerializeObject(dt);
            Car list = JsonConvert.DeserializeObject<List<Car>>(str).FirstOrDefault();
            return list;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Del(int id)
        {
            string sql = $"delete from Car where CId={id}";
            return DBHelper.CMD(sql);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int Upd(Car c)
        {
            string sql = $"update Car set CCarCi='{c.CCarCi}',CStart='{c.CStart}',CEnd='{c.CEnd}',CStateTime='{c.CStateTime}',CEndTime='{c.CEndTime}',CPrice='{c.CPrice}',CBeiZhu='{c.CBeiZhu}' where CId={c.CId}";
            return DBHelper.CMD(sql) ;
         }
    }
}