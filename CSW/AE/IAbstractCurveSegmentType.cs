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
	/// 	This class represents the abstract Element IAbstractCurveSegmentType
	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface IAbstractCurveSegmentType : LiquidTechnologies.Runtime.Net45.XmlObjectInterface
	{
	
		#region Member variables
		#region Attribute - numDerivativesAtStart
		LiquidTechnologies.Runtime.Net45.BigInteger NumDerivativesAtStart 	{
			get ;
			set ;
		}
		Boolean IsValidNumDerivativesAtStart	{
			get ;
			set ;
		}	
		#endregion	
		#region Attribute - numDerivativesAtEnd
		LiquidTechnologies.Runtime.Net45.BigInteger NumDerivativesAtEnd 	{
			get ;
			set ;
		}
		Boolean IsValidNumDerivativesAtEnd	{
			get ;
			set ;
		}	
		#endregion	
		#region Attribute - numDerivativeInterior
		LiquidTechnologies.Runtime.Net45.BigInteger NumDerivativeInterior 	{
			get ;
			set ;
		}
		Boolean IsValidNumDerivativeInterior	{
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

