using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface PivotDataAxis 
	/// SupportByVersion OWC10, 1
	///</summary>
	[SupportByVersionAttribute("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PivotDataAxis : PivotAxis
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(PivotDataAxis);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public PivotDataAxis(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotDataAxis(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotDataAxis(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotDataAxis(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotDataAxis(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotDataAxis() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotDataAxis(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotTotals Totals
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Totals", paramsArray);
				NetOffice.OWC10Api.PivotTotals newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PivotTotals.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotTotals;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion OWC10 1
		/// 
		/// </summary>
		/// <param name="total">NetOffice.OWC10Api.PivotTotal Total</param>
		/// <param name="before">optional object Before</param>
		[SupportByVersionAttribute("OWC10", 1)]
		public void InsertTotal(NetOffice.OWC10Api.PivotTotal total, object before)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(total, before);
			Invoker.Method(this, "InsertTotal", paramsArray);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// 
		/// </summary>
		/// <param name="total">NetOffice.OWC10Api.PivotTotal Total</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("OWC10", 1)]
		public void InsertTotal(NetOffice.OWC10Api.PivotTotal total)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(total);
			Invoker.Method(this, "InsertTotal", paramsArray);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// 
		/// </summary>
		/// <param name="total">object Total</param>
		[SupportByVersionAttribute("OWC10", 1)]
		public void RemoveTotal(object total)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(total);
			Invoker.Method(this, "RemoveTotal", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}