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
	/// 	This class represents the Element rangeParameters_Group_Choice_Choice
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"rangeParameters_Group_Choice_Choice", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class RangeParameters_Group_Choice_Choice : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for RangeParameters_Group_Choice_Choice
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public RangeParameters_Group_Choice_Choice()
		{
			_elementName = "rangeParameters_Group_Choice_Choice";
			Init();
		}
		public RangeParameters_Group_Choice_Choice(String elementName)
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
			m_Boolean = false;
			m_IsValidBoolean = false; 
			m_Category = null;
			m_Quantity = null;
			m_Count = 0;
			m_IsValidCount = false; 



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_Boolean = false;
			m_IsValidBoolean = false;
			m_Category = null;
			m_Quantity = null;
			m_Count = 0;
			m_IsValidCount = false;
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
			AE.RangeParameters_Group_Choice_Choice newObject = new AE.RangeParameters_Group_Choice_Choice(_elementName);
			newObject.m_Boolean = m_Boolean;
			newObject.m_IsValidBoolean = m_IsValidBoolean;
			newObject.m_Category = null;
			if (m_Category != null)
				newObject.m_Category = (AE.ICodeType)m_Category.Clone();
			newObject.m_Quantity = null;
			if (m_Quantity != null)
				newObject.m_Quantity = (AE.IMeasureType)m_Quantity.Clone();
			newObject.m_Count = m_Count;
			newObject.m_IsValidCount = m_IsValidCount;

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

		#region Attribute - Boolean
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("Boolean", "http://www.opengis.net/gml", "IsValidBoolean", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public Boolean boolean_
		{
			get 
			{ 
				if (m_IsValidBoolean == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property boolean_ is not valid. Set boolean_Valid = true");
				return m_Boolean;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("boolean_"); // remove selection
				m_IsValidBoolean = true;
				m_Boolean = value;
			}
		}
		/// <summary>
		/// 	Indicates if boolean_ contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for boolean_ is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (false).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get boolean_
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidBoolean
		{
			get
			{
				return m_IsValidBoolean;
			}
			set 
			{ 
				if (value != m_IsValidBoolean)
				{
					boolean_ = false;
					m_IsValidBoolean = value;
				}
			}
		}
		protected Boolean m_IsValidBoolean;
		protected Boolean m_Boolean;
		#endregion

		#region Attribute - Category
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("Category", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "ICodeTypeCreateObject")]
		public AE.ICodeType Category
		{
			get 
			{ 
				return m_Category;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Category"); // remove selection
				if (value == null)
					m_Category = null;
				else
				{
					m_Category = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "Category");
				}
			}
		}
		protected AE.ICodeType m_Category;

		#endregion

		#region Attribute - Quantity
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("Quantity", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IMeasureTypeCreateObject")]
		public AE.IMeasureType Quantity
		{
			get 
			{ 
				return m_Quantity;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Quantity"); // remove selection
				if (value == null)
					m_Quantity = null;
				else
				{
					m_Quantity = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "Quantity");
				}
			}
		}
		protected AE.IMeasureType m_Quantity;

		#endregion

		#region Attribute - Count
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("Count", "http://www.opengis.net/gml", "IsValidCount", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger Count
		{
			get 
			{ 
				if (m_IsValidCount == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property Count is not valid. Set CountValid = true");
				return m_Count;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("Count"); // remove selection
				m_IsValidCount = true;
				m_Count = value;
			}
		}
		/// <summary>
		/// 	Indicates if Count contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for Count is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get Count
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidCount
		{
			get
			{
				return m_IsValidCount;
			}
			set 
			{ 
				if (value != m_IsValidCount)
				{
					Count = 0;
					m_IsValidCount = value;
				}
			}
		}
		protected Boolean m_IsValidCount;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_Count;
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


