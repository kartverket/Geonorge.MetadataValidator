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
	/// 	This class represents the abstract Element IBSplineType
	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface IBSplineType : LiquidTechnologies.Runtime.Net45.XmlObjectInterface
                     , AE.IAbstractCurveSegmentType
	{
	
		#region Member variables
		#region Attribute - interpolation
		AE.Enumerations.CurveInterpolationType Interpolation  {
			get ;
			set ;
		}
		Boolean IsValidInterpolation	{
			get ;
			set ;
		}
		#endregion	
		#region Attribute - isPolynomial
		Boolean IsPolynomial 	{
			get ;
			set ;
		}
		Boolean IsValidIsPolynomial	{
			get ;
			set ;
		}	
		#endregion	
		#region Attribute - knotType
		AE.Enumerations.KnotTypesType KnotType  {
			get ;
			set ;
		}
		Boolean IsValidKnotType	{
			get ;
			set ;
		}
		#endregion	
		#region Attribute - BSplineType_Type_Choice
		AE.BSplineType_Type_Choice BSplineType_Type_Choice 	{
			get ;
			set ;
		}
		#endregion	
		#region Attribute - degree
		LiquidTechnologies.Runtime.Net45.BigInteger Degree {
			get ;
			set ;
		}
		#endregion	
		#region Attribute - knot
		CSW.XmlObjectCollection<AE.KnotPropertyType> KnotCol {
			get ;
		}
		#endregion	
	
		#endregion	

// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}

