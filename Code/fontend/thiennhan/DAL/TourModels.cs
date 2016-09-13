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
        public static List<Tour> GetListRecentTour(List<int> IdTour)
       {
           using (thiennhanEntities conn = new thiennhanEntities())
           {
               var _data = (from to in conn.Tours
                            where IdTour.Contains(to.ID)
                            select to).ToList();
               return _data;
           }
       }
        public static List<Tour> GetListRecentTourPromotions(List<int> IdTour)
        {
            using (thiennhanEntities conn = new thiennhanEntities())
            {
                var _data = (from to in conn.Tours
                             where IdTour.Contains(to.ID)
                             select to).ToList();
                return _data;
            }
        }

   }
}
