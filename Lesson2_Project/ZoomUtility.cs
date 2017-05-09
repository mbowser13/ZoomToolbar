using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;

namespace Lesson2_Project
{
    class ZoomUtility
    {
        public static void zoomControl(double x, double y) //Void procedure to calculate zoom levels
        {
            IMxDocument pMxDoc; // Declare pointer to mxd interface
            pMxDoc = (IMxDocument)ArcMap.Application.Document; // Initialize mxd pointer with current mxd
            IActiveView pActiveView; // Declare pointer to active view interface
            pActiveView = pMxDoc.ActiveView; // Initialize view pointer with current view
            IEnvelope pEnv; // Declare pointer to envelope interface
            pEnv = pActiveView.Extent; // Initialize envelope pointer with the active view
            pEnv.Expand(x, y, true); // Expand the envelope by calling ZoomUtility void procedure
            pActiveView.Extent = pEnv; // Change the extent of the active view based on the envelope
            pActiveView.Refresh(); // refresh the active view
        }
    }
}
