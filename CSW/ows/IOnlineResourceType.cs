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
namespace ows
{
	/// <summary>
	/// 	This class represents the abstract Element IOnlineResourceType
	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface IOnlineResourceType : LiquidTechnologies.Runtime.Net45.XmlObjectInterface
	{
	
		#region Member variables
		#region Attribute - type
		AC.Enumerations.TypeType Type  {
			get ;
			set ;
		}
		Boolean IsValidType	{
			get ;
			set ;
		}
		#endregion	
		#region Attribute - href
		String Href 	{
			get ;
			set ;
		}
		Boolean IsValidHref	{
			get ;
			set ;
		}	
		#endregion	
		#region Attribute - role
		String Role 	{
			get ;
			set ;
		}
		Boolean IsValidRole	{
			get ;
			set ;
		}	
		#endregion	
		#region Attribute - arcrole
		String Arcrole 	{
			get ;
			set ;
		}
		Boolean IsValidArcrole	{
			get ;
			set ;
		}	
		#endregion	
		#region Attribute - title
		String Title 	{
			get ;
			set ;
		}
		Boolean IsValidTitle	{
			get ;
			set ;
		}	
		#endregion	
		#region Attribute - show
		AC.Enumerations.ShowType Show  {
			get ;
			set ;
		}
		Boolean IsValidShow	{
			get ;
			set ;
		}
		#endregion	
		#region Attribute - actuate
		AC.Enumerations.ActuateType Actuate  {
			get ;
			set ;
		}
		Boolean IsValidActuate	{
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

