using System;
using System.Collections;
using System.Collections.Generic;
using PX.SM;
using PX.Data;


namespace MySmartPanel//.DAC
{
    public class NOPersisted : IBqlTable
    {
        #region Campo fecha
        public abstract class fecha : PX.Data.IBqlField { }
        protected DateTime? _Fecha;
        [PXDate()]
        [PXUIField(DisplayName = "Fecha")]
        public virtual DateTime? Fecha
        {
            get { return this._Fecha; }
            set { this._Fecha = value; }
        }
        #endregion

        #region Campo checkBox
        public abstract class isPago : PX.Data.IBqlField { }
        protected bool? _IsPago;
        [PXBool()]
        [PXUIField(DisplayName = "Agregar cantidad")]
        public virtual bool? IsPago
        {
            get { return this._IsPago; }
            set { this._IsPago = value; }
        }
        #endregion
    }
}