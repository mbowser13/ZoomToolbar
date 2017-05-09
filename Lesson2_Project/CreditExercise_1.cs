using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;
using System.Windows.Forms;

namespace Lesson2_Project
{
    public class CreditExercise_1 : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public CreditExercise_1()
        {
        }

        public void numFields()
        {
            // Instantiate mxd object pointer
            IMxDocument pMxDoc;
            pMxDoc = (IMxDocument)ArcMap.Application.Document;

            // Instantiate data frame object pointer
            IMap pMap;

            // Focus current dataframe
            pMap = pMxDoc.FocusMap;

            // Variable to capture second layer
            ILayerFields pLayerFields;
            pLayerFields = (ILayerFields)pMap.get_Layer(1);

            // Display message box with field count
            MessageBox.Show(pLayerFields.FieldCount.ToString());

        }

        protected override void OnClick()
        {
            numFields(); // Call void procedure
            ArcMap.Application.CurrentTool = null;
        }
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }

}
