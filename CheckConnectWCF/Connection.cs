using Database.EF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CheckConnectWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Connection" in both code and config file together.
    public class Connection : IConnection
    {
        public bool IsAlive()
        {
            using (ShopDbContext db = new ShopDbContext())
            {
                db.Database.Exists();
            }

            return true;
        }
    }
}
