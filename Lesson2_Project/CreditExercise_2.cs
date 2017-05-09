using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;

namespace Lesson2_Project
{
    public class CreditExercise_2 : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public CreditExercise_2()
        {
        }

        public void expandCollapse()
        {
            // Instantiate mxd object pointer
            IMxDocument pMxDoc;
            pMxDoc = (IMxDocument)ArcMap.Application.Document;

            // Instantiate data frame object pointer
            IMap pMap;

            // Capture multiple data frames
            IMaps pMaps;
            pMaps = pMxDoc.Maps;

            // Loop through data frames
            for (int i = 0; i < pMaps.Count; i++)
            {
                pMap = pMaps.Item[i];
                if (pMap.Expanded == true) // Determine if the df is expanded
                {
                    pMap.Expanded = false; // Collapse df
                }
                else if (pMap.Expanded == false) // Determine if the df is collapsed
                {
                    pMap.Expanded = true; // Expand df
                }
            }

            pMxDoc.UpdateContents(); // Update map document
        }

        protected override void OnClick()
        {
            expandCollapse(); // Call void procedure
        }

        protected override void OnUpdate()
        {
        }
    }
}
