﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Qlbs.Class;
using Qlbs.Model;

namespace Qlbs.Control
{
    class HangHoactrl
    {
        HangHoaMod hhMod = new HangHoaMod();
        public DataTable GetData()
        {
            return hhMod.GetData();
        }
        public DataTable GetData(string dieukien)
        {
            return hhMod.GetData(dieukien);
        }
        public bool AddData(HangHoa hhObj)
        {
            return hhMod.AddData(hhObj);
        }
        public bool UpdData(HangHoa hhObj)
        {
            return hhMod.UpdData(hhObj);
        }

        public bool UpdNhapHang(DataTable dt)
        {
            DataTable dthh = new DataTable();
            dthh = hhMod.GetData();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dthh.Rows.Count; j++)
                {
                    if (dt.Rows[i][1].ToString() == dthh.Rows[j][0].ToString())
                    {
                        int SLcu = int.Parse(dthh.Rows[j][5].ToString());
                        int SLmoi = int.Parse(dthh.Rows[j][5].ToString()) + int.Parse(dt.Rows[i][3].ToString());
                        int SLNhap = int.Parse(dthh.Rows[j][4].ToString()) + int.Parse(dt.Rows[i][3].ToString());
                        if (!hhMod.UpdSL(dthh.Rows[j][0].ToString(), SLmoi, SLNhap))
                            return false;
                        break;
                    }
                }

            }
            return true;
        }

        public bool UpdSL(DataTable dt)
        {
            DataTable dthh = new DataTable();
            dthh = hhMod.GetData();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dthh.Rows.Count; j++)
                {
                    if (dt.Rows[i][1].ToString() == dthh.Rows[j][0].ToString())
                    {
                        int SLcu = int.Parse(dthh.Rows[j][5].ToString());
                        int SLmoi = int.Parse(dthh.Rows[j][5].ToString()) - int.Parse(dt.Rows[i][3].ToString());
                        if (!hhMod.UpdSL(dthh.Rows[j][0].ToString(), SLmoi, 0))
                            return false;
                        break;
                    }
                }

            }
            return true;
        }
        public bool DelData(string ma)
        {
            return hhMod.DelData(ma);
        }
    }
}
