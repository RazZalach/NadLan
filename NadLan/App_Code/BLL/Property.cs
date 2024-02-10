using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using NadLan;

namespace BLL
{
    public class Property
    {
        public int Pid { get; set; }
        public int Aid { get; set; }
        public string Pname { get; set; }
        public int RoomNumber { get; set; }
        public int PFloor { get; set; }
        public string PAddress { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string TypeDeal { get; set; }
        public int PriceReq { get; set; }
        public string Pic { get; set; }
        public static List<Property> GetProperty()
        {

            return PropertyDal.GetProperty();
        }
        public static Property GetPropsById(int id)
        {
            return PropertyDal.GetPropById(id);
        }
        public void SaveProperty()
        {
            PropertyDal.SaveProperty(this);
        }
        public static bool RemovePropById(int id)
        {
            return PropertyDal.RemovePropById(id);
        }

        public bool CheckLogin()
        {
            return PropertyDal.CheckLogin(this);
        }

    }
}