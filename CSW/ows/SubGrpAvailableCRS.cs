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

namespace ows
{
	/// <summary>
	/// 	This class represents the Element SubGrpAvailableCRS
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrpAvailableCRS", "http://www.opengis.net/ows", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrpAvailableCRS : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrpAvailableCRS
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrpAvailableCRS()
		{
			_elementName = "SubGrpAvailableCRS";
			Init();
		}
		public SubGrpAvailableCRS(String elementName)
		{
			_elementName = elementName;
			Init();
		}
		#endregion

		#region Initialization methods for the class
		/// <summary>
		///		Initializes the class
		/// </summary>
		/// <remarks>
		///		<BR>The Creates all the mandatory fields (populated with the default data) 
		///		All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd.</BR>
		/// </remarks>
		protected override void Init()
		{
			CSW.Registration.iRegistrationIndicator = 0; // causes registration to take place
			m_AvailableCRS = "";
			m_IsValidAvailableCRS = false; 
			m_SupportedCRS = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_AvailableCRS = "";
			m_IsValidAvailableCRS = false;
			m_SupportedCRS = null;
			_validElement = selectedElement;
		}
		#endregion

		#region ICloneable Interface
		/// <summary>
		///		Allows the class to be copied
		/// </summary>
		/// <remarks>
		///		Performs a 'deep copy' of all the data in the class (and its children)
		/// </remarks>
		public override object Clone()
		{
			ows.SubGrpAvailableCRS newObject = new ows.SubGrpAvailableCRS(_elementName);
			newObject.m_AvailableCRS = m_AvailableCRS;
			newObject.m_IsValidAvailableCRS = m_IsValidAvailableCRS;
			newObject.m_SupportedCRS = null;
			if (m_SupportedCRS != null)
				newObject.m_SupportedCRS = (ows.SupportedCRS)m_SupportedCRS.Clone();

			newObject._validElement = _validElement;

// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			return newObject;
		}
		#endregion

		#region Member variables

		protected override String TargetNamespace
		{
			get { return "http://www.opengis.net/ows"; }
		}

		#region Attribute - AvailableCRS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("AvailableCRS", "http://www.opengis.net/ows", "IsValidAvailableCRS", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public String AvailableCRS
		{
			get 
			{ 
				if (m_IsValidAvailableCRS == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property AvailableCRS is not valid. Set AvailableCRSValid = true");
				return m_AvailableCRS;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("AvailableCRS"); // remove selection
				m_IsValidAvailableCRS = true;
				m_AvailableCRS = value;
			}
		}
		/// <summary>
		/// 	Indicates if AvailableCRS contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for AvailableCRS is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get AvailableCRS
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidAvailableCRS
		{
			get
			{
				return m_IsValidAvailableCRS;
			}
			set 
			{ 
				if (value != m_IsValidAvailableCRS)
				{
					AvailableCRS = "";
					m_IsValidAvailableCRS = value;
				}
			}
		}
		protected Boolean m_IsValidAvailableCRS;
		protected String m_AvailableCRS;
		#endregion

		#region Attribute - SupportedCRS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for AvailableCRS
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SupportedCRS", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ows.SupportedCRS))]
		public ows.SupportedCRS SupportedCRS
		{
			get 
			{ 
				return m_SupportedCRS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SupportedCRS"); // remove selection
				if (value == null)
					m_SupportedCRS = null;
				else
				{
					m_SupportedCRS = value; 
				}
			}
		}
		protected ows.SupportedCRS m_SupportedCRS;
		
		#endregion

		public String ChoiceSelectedElement
		{
			get { return _validElement;  }
		}
		protected String _validElement;
		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://www.opengis.net/ows"; }
		}	
		#endregion	

		#region Attribute - GetBase
		public override LiquidTechnologies.Runtime.Net45.XmlObjectBase GetBase()
		{
			return this;
		}
		#endregion
		#endregion

// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}


