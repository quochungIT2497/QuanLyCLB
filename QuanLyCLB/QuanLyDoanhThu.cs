using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCLB
{
    internal class QuanLyDoanhThu
    {
        private string _CLB;
        private string _QG;
        private double _GV;
        private string _SVD;
        private int _SLV;

        public QuanLyDoanhThu(string cLB, string qG, double gV, string sVD, int sLV)
        {
            CLB = cLB;
            QG = qG;
            GV = gV;
            SVD = sVD;
            SLV = sLV;
        }

        public string CLB { get => _CLB; set => _CLB = value; }
        public string QG { get => _QG; set => _QG = value; }
        public double GV { get => _GV; set => _GV = value; }
        public string SVD { get => _SVD; set => _SVD = value; }
        public int SLV { get => _SLV; set => _SLV = value; }
        public double Tong() 
        {
            return GV * SLV;
        }
    }
}
