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

namespace AE
{
	/// <summary>
	/// 	This class represents the Element rangeParameters_Group_Choice_ChoiceB
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"rangeParameters_Group_Choice_ChoiceB", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class RangeParameters_Group_Choice_ChoiceB : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for RangeParameters_Group_Choice_ChoiceB
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public RangeParameters_Group_Choice_ChoiceB()
		{
			_elementName = "rangeParameters_Group_Choice_ChoiceB";
			Init();
		}
		public RangeParameters_Group_Choice_ChoiceB(String elementName)
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
			m_CategoryExtent = null;
			m_QuantityExtent = null;
			m_CountExtent = "";
			m_IsValidCountExtent = false; 



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_CategoryExtent = null;
			m_QuantityExtent = null;
			m_CountExtent = "";
			m_IsValidCountExtent = false;
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
			AE.RangeParameters_Group_Choice_ChoiceB newObject = new AE.RangeParameters_Group_Choice_ChoiceB(_elementName);
			newObject.m_CategoryExtent = null;
			if (m_CategoryExtent != null)
				newObject.m_CategoryExtent = (AE.CategoryExtent)m_CategoryExtent.Clone();
			newObject.m_QuantityExtent = null;
			if (m_QuantityExtent != null)
				newObject.m_QuantityExtent = (AE.QuantityExtent)m_QuantityExtent.Clone();
			newObject.m_CountExtent = m_CountExtent;
			newObject.m_IsValidCountExtent = m_IsValidCountExtent;

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
			get { return "http://www.opengis.net/gml"; }
		}

		#region Attribute - CategoryExtent
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("CategoryExtent", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.CategoryExtent))]
		public AE.CategoryExtent CategoryExtent
		{
			get 
			{ 
				return m_CategoryExtent;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"CategoryExtent"); // remove selection
				if (value == null)
					m_CategoryExtent = null;
				else
				{
					m_CategoryExtent = value; 
				}
			}
		}
		protected AE.CategoryExtent m_CategoryExtent;
		
		#endregion

		#region Attribute - QuantityExtent
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("QuantityExtent", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.QuantityExtent))]
		public AE.QuantityExtent QuantityExtent
		{
			get 
			{ 
				return m_QuantityExtent;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"QuantityExtent"); // remove selection
				if (value == null)
					m_QuantityExtent = null;
				else
				{
					m_QuantityExtent = value; 
				}
			}
		}
		protected AE.QuantityExtent m_QuantityExtent;
		
		#endregion

		#region Attribute - CountExtent
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("CountExtent", "http://www.opengis.net/gml", "IsValidCountExtent", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String CountExtent
		{
			get 
			{ 
				if (m_IsValidCountExtent == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property CountExtent is not valid. Set CountExtentValid = true");
				return m_CountExtent;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("CountExtent"); // remove selection
				m_IsValidCountExtent = true;
				m_CountExtent = value;
			}
		}
		/// <summary>
		/// 	Indicates if CountExtent contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for CountExtent is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get CountExtent
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidCountExtent
		{
			get
			{
				return m_IsValidCountExtent;
			}
			set 
			{ 
				if (value != m_IsValidCountExtent)
				{
					CountExtent = "";
					m_IsValidCountExtent = value;
				}
			}
		}
		protected Boolean m_IsValidCountExtent;
		protected String m_CountExtent;
		#endregion

		public String ChoiceSelectedElement
		{
			get { return _validElement;  }
		}
		protected String _validElement;
		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://www.opengis.net/gml"; }
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


