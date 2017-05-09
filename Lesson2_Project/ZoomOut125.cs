using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Lesson2_Project
{
    public class ZoomOut125 : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public ZoomOut125()
        {
        }

        protected override void OnClick()
        {
            ZoomUtility.zoomControl(1.25, 1.25);
        }

        protected override void OnUpdate()
        {
        }
    }
}
