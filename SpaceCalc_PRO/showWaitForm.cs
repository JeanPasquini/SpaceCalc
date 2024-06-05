using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCalc_PRO
{
    internal class showWaitForm
    {
        private static waitForm frm;

        public static void Open()
        {
            frm = new waitForm();
            frm.Show();
        }

        public static void Close()
        {
            frm.Close();
        }
    }
}
