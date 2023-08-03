using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.DataAccess
{
    public class CommonCodeRepository : ICommonCodeRepository
    {
        public int Delete(CommonCode entity)
        {
            throw new NotImplementedException();
        }

        public int DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommonCode> GetAll()
        {
            using (var connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            {
                var commonCodes = connection.GetAll<CommonCode>();

                return commonCodes;
            }
        }

        public CommonCode GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(CommonCode entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CommonCode entity)
        {
            throw new NotImplementedException();
        }
    }
}
