using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
namespace DAL
{
   public class TourModels
   {
        public static List<Tour> GetListRecentTour(List<int> IdTour,int limit=6)
       {
           using (thiennhanEntities conn = new thiennhanEntities())
           {
               var _data = (from to in conn.Tours
                            where IdTour.Contains(to.ID)
                            orderby to.Adddate descending
                            select to).Take(limit).ToList();
               return _data;
           }
       }
        public static List<Tour> GetListRecentTourPromotions(int limit=6)
        {
            using (thiennhanEntities conn = new thiennhanEntities())
            {
                var _data = (from to in conn.Tours
                             where to.Percentpromotion!=0
                             orderby to.Adddate descending
                             select to).Take(limit).ToList();
                return _data;
            }
        }
        public static List<Tour> GetListRecentTourbyType(int Type,int limit=6)
        {
            using (thiennhanEntities conn = new thiennhanEntities())
            {
                var _data = (from to in conn.Tours
                             where to.Type == Type
                             orderby to.Adddate descending
                             select to).Take(limit).ToList();
                return _data;
            }
        }
        public static List<Tour> GetListRecentTourbynew(int limit=6)
        {
            using (thiennhanEntities conn = new thiennhanEntities())
            {
                var _data = (from to in conn.Tours
                             orderby to.Adddate descending
                             select to).Take(limit).ToList();
                return _data;
            }
        }

   }
}
