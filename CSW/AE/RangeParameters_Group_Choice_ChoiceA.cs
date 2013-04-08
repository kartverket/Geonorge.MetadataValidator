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
	/// 	This class represents the Element rangeParameters_Group_Choice_ChoiceA
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"rangeParameters_Group_Choice_ChoiceA", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class RangeParameters_Group_Choice_ChoiceA : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for RangeParameters_Group_Choice_ChoiceA
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public RangeParameters_Group_Choice_ChoiceA()
		{
			_elementName = "rangeParameters_Group_Choice_ChoiceA";
			Init();
		}
		public RangeParameters_Group_Choice_ChoiceA(String elementName)
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
			m_BooleanList = "";
			m_IsValidBooleanList = false; 
			m_CategoryList = null;
			m_QuantityList = null;
			m_CountList = "";
			m_IsValidCountList = false; 



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_BooleanList = "";
			m_IsValidBooleanList = false;
			m_CategoryList = null;
			m_QuantityList = null;
			m_CountList = "";
			m_IsValidCountList = false;
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
			AE.RangeParameters_Group_Choice_ChoiceA newObject = new AE.RangeParameters_Group_Choice_ChoiceA(_elementName);
			newObject.m_BooleanList = m_BooleanList;
			newObject.m_IsValidBooleanList = m_IsValidBooleanList;
			newObject.m_CategoryList = null;
			if (m_CategoryList != null)
				newObject.m_CategoryList = (AE.ICodeOrNullListType)m_CategoryList.Clone();
			newObject.m_QuantityList = null;
			if (m_QuantityList != null)
				newObject.m_QuantityList = (AE.IMeasureOrNullListType)m_QuantityList.Clone();
			newObject.m_CountList = m_CountList;
			newObject.m_IsValidCountList = m_IsValidCountList;

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

		#region Attribute - BooleanList
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("BooleanList", "http://www.opengis.net/gml", "IsValidBooleanList", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String BooleanList
		{
			get 
			{ 
				if (m_IsValidBooleanList == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property BooleanList is not valid. Set BooleanListValid = true");
				return m_BooleanList;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("BooleanList"); // remove selection
				m_IsValidBooleanList = true;
				m_BooleanList = value;
			}
		}
		/// <summary>
		/// 	Indicates if BooleanList contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for BooleanList is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get BooleanList
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidBooleanList
		{
			get
			{
				return m_IsValidBooleanList;
			}
			set 
			{ 
				if (value != m_IsValidBooleanList)
				{
					BooleanList = "";
					m_IsValidBooleanList = value;
				}
			}
		}
		protected Boolean m_IsValidBooleanList;
		protected String m_BooleanList;
		#endregion

		#region Attribute - CategoryList
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("CategoryList", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "ICodeOrNullListTypeCreateObject")]
		public AE.ICodeOrNullListType CategoryList
		{
			get 
			{ 
				return m_CategoryList;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"CategoryList"); // remove selection
				if (value == null)
					m_CategoryList = null;
				else
				{
					m_CategoryList = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "CategoryList");
				}
			}
		}
		protected AE.ICodeOrNullListType m_CategoryList;

		#endregion

		#region Attribute - QuantityList
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("QuantityList", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IMeasureOrNullListTypeCreateObject")]
		public AE.IMeasureOrNullListType QuantityList
		{
			get 
			{ 
				return m_QuantityList;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"QuantityList"); // remove selection
				if (value == null)
					m_QuantityList = null;
				else
				{
					m_QuantityList = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "QuantityList");
				}
			}
		}
		protected AE.IMeasureOrNullListType m_QuantityList;

		#endregion

		#region Attribute - CountList
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("CountList", "http://www.opengis.net/gml", "IsValidCountList", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String CountList
		{
			get 
			{ 
				if (m_IsValidCountList == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property CountList is not valid. Set CountListValid = true");
				return m_CountList;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("CountList"); // remove selection
				m_IsValidCountList = true;
				m_CountList = value;
			}
		}
		/// <summary>
		/// 	Indicates if CountList contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for CountList is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get CountList
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidCountList
		{
			get
			{
				return m_IsValidCountList;
			}
			set 
			{ 
				if (value != m_IsValidCountList)
				{
					CountList = "";
					m_IsValidCountList = value;
				}
			}
		}
		protected Boolean m_IsValidCountList;
		protected String m_CountList;
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


