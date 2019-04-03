using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairBeautyNWRC
{
    class MyTreatment
    {
        private int treatmentNo;
        private String treatGroup;
        private String treatName;
        private String treatType;
        private decimal treatPrice;

        public MyTreatment()
        {
            treatmentNo = 0;
            treatGroup = "";
            treatName = "";
            treatType = "";
            treatPrice = 0;
        }

        public MyTreatment(int treatmentNo, string treatGroup, string treatName, string treatType, decimal treatPrice)
        {
            this.treatmentNo = treatmentNo;
            this.treatGroup = treatGroup;
            this.treatName = treatName;
            this.treatType = treatType;
            this.treatPrice = treatPrice;
        }

        public int TreatmentNo { get => treatmentNo; set => treatmentNo = value; }
        public string TreatGroup { get => treatGroup; set => treatGroup = value; }
        public string TreatName { get => treatName; set => treatName = value; }
        public string TreatType { get => treatType; set => treatType = value; }
        public decimal TreatPrice { get => treatPrice; set => treatPrice = value; }
    }
}
