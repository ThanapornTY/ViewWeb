using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace ViewWeb.Models
{
    public class Hitcount
    {
        public void AddCount(HitCounter HC)
        {
            using (MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                DateTime today = DateTime.Now.Date;
                // This code is for check unique ip per day only
                var v = dc.HitCounters.Where(a => a.IPAddress.Equals(HC.IPAddress) && EntityFunctions.TruncateTime(a.CreateDate) == today).FirstOrDefault();
                if (v == null)
                {
                    dc.HitCounters.Add(HC);
                    dc.SaveChanges();
                }
            }

        }

        public object[] GetCount()
        {
            object[] o = new object[2];
            using (MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                DateTime today = DateTime.Now.Date;
                // get Today Hits
                o[0] = dc.HitCounters.Where(a => EntityFunctions.TruncateTime(a.CreateDate) == today).Count();

                // get all hits

                o[1] = dc.HitCounters.Count();
            }
            return o;
        }
    }
}