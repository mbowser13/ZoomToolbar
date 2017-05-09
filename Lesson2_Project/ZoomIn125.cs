using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Lesson2_Project
{
    public class ZoomIn125 : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public ZoomIn125()
        {
        }

        protected override void OnClick()
        {
            ZoomUtility.zoomControl(0.8, 0.8); // Call zoomControl procedure
        }

        protected override void OnUpdate()
        {
        }
    }
}
