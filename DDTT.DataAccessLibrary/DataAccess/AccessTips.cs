﻿using DataAccess.ClassLib.GenericDataAccess;
using DataAccess.ClassLib.Interface.BasicDataAccess_Interfaces;
using DDTT.ClassLib.Models.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.DataAccessLibrary.DataAccess
{
    public class AccessTips
    {
        public Tip GetById(int id)
        {
            using (ILoadSingleData cnn = new BasicSqlDataAccess())
            {
                return cnn.LoadSingleData<Tip,dynamic>("dbo.spTip_GetById", "", new { Id = id });
            }
        }
        public List<Tip> GetAll()
        {
            using (ILoadSetData cnn = new BasicSqlDataAccess())
            {
                return cnn.LoadSetData<Tip, dynamic>("dbo.spTip_GetAll", "", new { });
            }
        }
        public void DeleteById(int id)
        {
            using (ILoadSetData cnn = new BasicSqlDataAccess())
            {
                cnn.LoadSetData<Tip, dynamic>("dbo.spTip_DeleteById", "", new { Id = id });
            }
        }
    }
}
