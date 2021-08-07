﻿using DDTT.ClassLib.Models.BusinessModels;
using DataAccess.ClassLib.Interface.BasicDataAccess_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.ClassLib.GenericDataAccess;

namespace DDTT.DataAccessLibrary.DataAccess
{
    public class AccessDDPay
    {
        public List<DD_Pay> GetAll()
        {
            using (ILoadSetData cnn = new BasicSqlDataAccess())
            {
                return cnn.LoadSetData<DD_Pay, dynamic>("dbo.spDDPay_GetAll", "", new { }).ToList();
            }
        }
        public DD_Pay GetById(int id)
        {
            using (ILoadSingleData cnn = new )
            {

            }
        }
    }
}