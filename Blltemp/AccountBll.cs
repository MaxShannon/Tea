using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Text;
using Dal;
using Model;


namespace Bll
{
    public class AccountBll
    {

        //private readonly Base<> _dal = new Base<>();
        public AccountBll()
        {
        }

        /// <summary>
        /// 返回一个Json
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public object Login(string userName, string password)
        {
            if (CheckPassword(userName, password))
            {

            }
            return new object();
        }

        public bool CheckPassword(string userName, string password)
        {
            return true;
        }
    }
}
