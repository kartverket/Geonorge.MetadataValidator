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
	/// 	This class represents the abstract Element IArcByCenterPointType
	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface IArcByCenterPointType : LiquidTechnologies.Runtime.Net45.XmlObjectInterface
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
		#region Attribute - numArc
		LiquidTechnologies.Runtime.Net45.BigInteger NumArc {
			get ;
			set ;
		}
		#endregion	
		#region Attribute - ArcByCenterPointType_Type_Choice
		AE.ArcByCenterPointType_Type_Choice ArcByCenterPointType_Type_Choice 	{
			get ;
			set ;
		}
		#endregion	
		#region Attribute - radius
		AE.LengthType Radius 	{
			get ;
			set ;
		}
		#endregion	
		#region Attribute - startAngle
		AE.AngleType StartAngle {
			get ;
			set ;
		}
		#endregion	
		#region Attribute - endAngle
		AE.AngleType EndAngle {
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

