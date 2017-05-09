using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Lesson2_Project
{
    public class ZoomOut400 : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public ZoomOut400()
        {
        }

        protected override void OnClick()
        {
            ZoomUtility.zoomControl(4, 4);
        }

        protected override void OnUpdate()
        {
        }
    }
}
