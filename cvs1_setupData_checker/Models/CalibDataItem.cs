using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvs1_setupData_checker.Models
{
    class CalibDataItemUnit
    {
        public Array EccList { get; set; }
        public Double Target { get; set; }

        public CalibDataItemUnit(double target, double ecc0, double ecc1, double ecc2, double ecc3)
        {
            EccList = Array.CreateInstance(typeof(Double), 4);
            EccList.SetValue(ecc0, 0);
            EccList.SetValue(ecc1, 1);
            EccList.SetValue(ecc2, 2);
            EccList.SetValue(ecc3, 3);

            Target = target;
        }
    }

    class CalibDataItem
    {
        List<CalibDataItemUnit> DataList { get; set; }

        public CalibDataItem()
        {
            DataList = new List<CalibDataItemUnit>();
        }

        public void addTarget(double target, double ecc0, double ecc1, double ecc2, double ecc3)
        {
            DataList.Add(new CalibDataItemUnit(target, ecc0, ecc1, ecc2, ecc3));
        }
    }
}
