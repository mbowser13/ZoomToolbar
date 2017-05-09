using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Lesson2_Project
{
    public class ZoomIn200 : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public ZoomIn200()
        {
        }

        protected override void OnClick()
        {
            ZoomUtility.zoomControl(0.5, 0.5);
        }

        protected override void OnUpdate()
        {
        }
    }
}
