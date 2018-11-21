using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using PX.Common;
using PX.Data;
using PX.Data.Api.Export;
using PX.Objects.AR.Standalone;
using PX.Objects.Common;
using PX.Objects.AR.MigrationMode;
using PX.Objects.AR.CCPaymentProcessing;
using PX.Objects.CA;
using PX.Objects.CM;
using PX.Objects.CR;
using PX.Objects.CS;
using PX.Objects.GL;
using SOAdjust = PX.Objects.SO.SOAdjust;
using SOOrder = PX.Objects.SO.SOOrder;
using SOOrderEntry = PX.Objects.SO.SOOrderEntry;
using SOOrderType = PX.Objects.SO.SOOrderType;
using PX.Objects.AR.CCPaymentProcessing.Common;
using PX.Objects.AR.CCPaymentProcessing.Helpers;
using PX.Objects.AR;
using PX.Objects.EP;
using PX.Objects.Common.Extensions;
using PX.Objects;
using MySmartPanel;

namespace PX.Objects.AR
{
  public class ARPaymentEntry_Extension : PXGraphExtension<ARPaymentEntry>
  {
        public PXSelect<ARPayment, Where<ARPayment.refNbr, Equal<Current<ARPayment.docType>>, And<ARPayment.refNbr, Equal<Current<ARPayment.refNbr>>>>> CurrentDocument;
        #region Event Handlers
        public PXAction<ARPayment> OpenSmartPanel;

        
        [PXButton(CommitChanges =true, Tooltip = "Boton que contiene la funcionalidad de un SmartPanel")]
        [PXUIField(DisplayName = "SMART PANEL", MapEnableRights = PXCacheRights.Select, MapViewRights = PXCacheRights.Select)]
        public void openSmartPanel()
        {
            if (this.MyPanel.AskExt() != WebDialogResult.OK)
            {
                return;
            }
            else
            {
                if (this.MyPanel.Current.IsPago == true)
                {
                    DateTime oFecha = (DateTime)this.MyPanel.Current.Fecha;
                    if (oFecha != null )
                    {
                        CurrentDocument.Current.AdjDate = oFecha;
                    }

                    CurrentDocument.Current.CuryOrigDocAmt = 150;

                    CurrentDocument.Cache.Update(CurrentDocument.Current);
                }
            }
        }
        #endregion

        public PXFilter<NOPersisted> MyPanel;
  }
}