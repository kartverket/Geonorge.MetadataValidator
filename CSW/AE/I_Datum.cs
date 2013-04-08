using System;
using System.Xml;

/**********************************************************************************************
 * Copyright (c) 2001-2013 Liquid Technologies Limited. All rights reserved.
 * See www.liquid-technologies.com for product details.
 *
 * Please see products End User License Agreement for distribution permissions.
 *
 * WARNING: THIS FILE IS GENERATED
 * Changes made outside of ##HAND_CODED_BLOCK_START blocks will be overwritten
 *
 * Generation  : by Liquid XML Data Binder 11.0.7.4537
 * Using Schema: C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd
 **********************************************************************************************/

/// <summary>
/// 	
/// </summary>
/// <remarks>
///		
/// </remarks>
namespace AE
{
	/// <summary>
	/// 	This class represents the abstract Element I_Datum
	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface I_Datum : LiquidTechnologies.Runtime.Net45.XmlObjectInterface
                     , AE.IAbstractDatumBaseType
	{
	
		#region Member variables
		#region Attribute - datumID
		CSW.XmlObjectCollection<AE.DatumID> DatumIDCol {
			get ;
		}
		#endregion	
		#region Attribute - remarks
		AE.Remarks Remarks {
			get ;
			set ;
		}
		#endregion	
		#region Attribute - anchorPoint
		AE.ICodeType AnchorPoint {
			get ;
			set ;
		}
		#endregion	
		#region Attribute - realizationEpoch
		LiquidTechnologies.Runtime.Net45.XmlDateTime RealizationEpoch 	{
			get ;
			set ;
		}
		Boolean IsValidRealizationEpoch	{
			get ;
			set ;
		}	
		#endregion	
		#region Attribute - validArea
		AE.ValidArea ValidArea {
			get ;
			set ;
		}
		#endregion	
		#region Attribute - scope
		String Scope 	{
			get ;
			set ;
		}
		Boolean IsValidScope	{
			get ;
			set ;
		}	
		#endregion	
	
		#endregion	

// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}

