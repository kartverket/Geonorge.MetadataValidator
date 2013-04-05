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
namespace AF
{
	/// <summary>
	/// 	This class represents the abstract Element IanimateColorPrototype
	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface IanimateColorPrototype : LiquidTechnologies.Runtime.Net45.XmlObjectInterface
	{
	
		#region Member variables
		#region Attribute - attributeName
		String AttributeName {
			get ;
			set ;
		}
		#endregion	
		#region Attribute - attributeType
		CSW.Enumerations.IanimateColorPrototype_AttributeType AttributeType  {
			get ;
			set ;
		}
		Boolean IsValidAttributeType	{
			get ;
			set ;
		}
		#endregion	
		#region Attribute - additive
		CSW.Enumerations.IanimateColorPrototype_Additive Additive  {
			get ;
			set ;
		}
		Boolean IsValidAdditive	{
			get ;
			set ;
		}
		#endregion	
		#region Attribute - accumulate
		CSW.Enumerations.IanimateColorPrototype_Accumulate Accumulate  {
			get ;
			set ;
		}
		Boolean IsValidAccumulate	{
			get ;
			set ;
		}
		#endregion	
		#region Attribute - to
		String to_ 	{
			get ;
			set ;
		}
		Boolean IsValidTo	{
			get ;
			set ;
		}	
		#endregion	
		#region Attribute - from
		String From 	{
			get ;
			set ;
		}
		Boolean IsValidFrom	{
			get ;
			set ;
		}	
		#endregion	
		#region Attribute - by
		String By 	{
			get ;
			set ;
		}
		Boolean IsValidBy	{
			get ;
			set ;
		}	
		#endregion	
		#region Attribute - values
		String Values 	{
			get ;
			set ;
		}
		Boolean IsValidValues	{
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

