using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Lesson2_Project
{
    public class ZoomOut200 : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public ZoomOut200()
        {
        }

        protected override void OnClick()
        {
            ZoomUtility.zoomControl(2, 2);
        }

        protected override void OnUpdate()
        {
        }
    }
}
