using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Domain.Business;
using System.Globalization;
using System.Data;

namespace Domain.Persistence
{
    public class PersistenceCode
    {
        string _connectionString;

        public PersistenceCode()
        {
            _connectionString = "server=localhost; port = 3306; user id=root; persistsecurityinfo = true; database = CliniresearchDB; password = Ratava989";
        }

        #region Get







        #endregion


    }
