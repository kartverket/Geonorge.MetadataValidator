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
	/// 	This class represents the abstract Element I_Geometry
	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface I_Geometry : LiquidTechnologies.Runtime.Net45.XmlObjectInterface
                     , AE.IAbstractGMLType
	{
	
		#region Member variables
		#region Attribute - gid
		String Gid 	{
			get ;
			set ;
		}
		Boolean IsValidGid	{
			get ;
			set ;
		}	
		#endregion	
		#region Attribute - srsName
		String SrsName 	{
			get ;
			set ;
		}
		Boolean IsValidSrsName	{
			get ;
			set ;
		}	
		#endregion	
		#region Attribute - srsDimension
		LiquidTechnologies.Runtime.Net45.BigInteger SrsDimension 	{
			get ;
			set ;
		}
		Boolean IsValidSrsDimension	{
			get ;
			set ;
		}	
		#endregion	
		#region Attribute - axisLabels
		String AxisLabels 	{
			get ;
			set ;
		}
		Boolean IsValidAxisLabels	{
			get ;
			set ;
		}	
		#endregion	
		#region Attribute - uomLabels
		String UomLabels 	{
			get ;
			set ;
		}
		Boolean IsValidUomLabels	{
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

