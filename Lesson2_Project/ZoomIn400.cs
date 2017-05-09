using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Lesson2_Project
{
    public class ZoomIn400 : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public ZoomIn400()
        {
        }

        protected override void OnClick()
        {
            ZoomUtility.zoomControl(0.25, 0.25);
        }

        protected override void OnUpdate()
        {
        }
    }
}
