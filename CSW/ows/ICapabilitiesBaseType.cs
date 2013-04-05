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
	/// 	This class represents the abstract Element ICapabilitiesBaseType
	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface ICapabilitiesBaseType : LiquidTechnologies.Runtime.Net45.XmlObjectInterface
	{
	
		#region Member variables
		#region Attribute - version
		String Version {
			get ;
			set ;
		}
		#endregion	
		#region Attribute - updateSequence
		String UpdateSequence 	{
			get ;
			set ;
		}
		Boolean IsValidUpdateSequence	{
			get ;
			set ;
		}	
		#endregion	
		#region Attribute - ServiceIdentification
		ows.ServiceIdentification ServiceIdentification {
			get ;
			set ;
		}
		#endregion	
		#region Attribute - ServiceProvider
		ows.ServiceProvider ServiceProvider {
			get ;
			set ;
		}
		#endregion	
		#region Attribute - OperationsMetadata
		ows.OperationsMetadata OperationsMetadata {
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

