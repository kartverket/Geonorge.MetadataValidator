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
	/// 	This class represents the Element ParameterValueType_Type_Choice
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"ParameterValueType_Type_Choice", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class ParameterValueType_Type_Choice : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for ParameterValueType_Type_Choice
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public ParameterValueType_Type_Choice()
		{
			_elementName = "ParameterValueType_Type_Choice";
			Init();
		}
		public ParameterValueType_Type_Choice(String elementName)
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
			m_Value = null;
			m_DmsAngleValue = null;
			m_StringValue = "";
			m_IsValidStringValue = false; 
			m_IntegerValue = 0;
			m_IsValidIntegerValue = false; 
			m_BooleanValue = false;
			m_IsValidBooleanValue = false; 
			m_ValueList = null;
			m_IntegerValueList = "";
			m_IsValidIntegerValueList = false; 
			m_ValueFile = "";
			m_IsValidValueFile = false; 



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_Value = null;
			m_DmsAngleValue = null;
			m_StringValue = "";
			m_IsValidStringValue = false;
			m_IntegerValue = 0;
			m_IsValidIntegerValue = false;
			m_BooleanValue = false;
			m_IsValidBooleanValue = false;
			m_ValueList = null;
			m_IntegerValueList = "";
			m_IsValidIntegerValueList = false;
			m_ValueFile = "";
			m_IsValidValueFile = false;
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
			AE.ParameterValueType_Type_Choice newObject = new AE.ParameterValueType_Type_Choice(_elementName);
			newObject.m_Value = null;
			if (m_Value != null)
				newObject.m_Value = (AE.IMeasureType)m_Value.Clone();
			newObject.m_DmsAngleValue = null;
			if (m_DmsAngleValue != null)
				newObject.m_DmsAngleValue = (AE.DmsAngleValue)m_DmsAngleValue.Clone();
			newObject.m_StringValue = m_StringValue;
			newObject.m_IsValidStringValue = m_IsValidStringValue;
			newObject.m_IntegerValue = m_IntegerValue;
			newObject.m_IsValidIntegerValue = m_IsValidIntegerValue;
			newObject.m_BooleanValue = m_BooleanValue;
			newObject.m_IsValidBooleanValue = m_IsValidBooleanValue;
			newObject.m_ValueList = null;
			if (m_ValueList != null)
				newObject.m_ValueList = (AE.ValueList)m_ValueList.Clone();
			newObject.m_IntegerValueList = m_IntegerValueList;
			newObject.m_IsValidIntegerValueList = m_IsValidIntegerValueList;
			newObject.m_ValueFile = m_ValueFile;
			newObject.m_IsValidValueFile = m_IsValidValueFile;

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

		#region Attribute - value
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("value", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IMeasureTypeCreateObject")]
		public AE.IMeasureType Value
		{
			get 
			{ 
				return m_Value;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"value"); // remove selection
				if (value == null)
					m_Value = null;
				else
				{
					m_Value = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "value");
				}
			}
		}
		protected AE.IMeasureType m_Value;

		#endregion

		#region Attribute - dmsAngleValue
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("dmsAngleValue", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.DmsAngleValue))]
		public AE.DmsAngleValue DmsAngleValue
		{
			get 
			{ 
				return m_DmsAngleValue;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"dmsAngleValue"); // remove selection
				if (value == null)
					m_DmsAngleValue = null;
				else
				{
					m_DmsAngleValue = value; 
				}
			}
		}
		protected AE.DmsAngleValue m_DmsAngleValue;
		
		#endregion

		#region Attribute - stringValue
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("stringValue", "http://www.opengis.net/gml", "IsValidStringValue", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String StringValue
		{
			get 
			{ 
				if (m_IsValidStringValue == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property stringValue is not valid. Set stringValueValid = true");
				return m_StringValue;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("stringValue"); // remove selection
				m_IsValidStringValue = true;
				m_StringValue = value;
			}
		}
		/// <summary>
		/// 	Indicates if stringValue contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for stringValue is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get stringValue
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidStringValue
		{
			get
			{
				return m_IsValidStringValue;
			}
			set 
			{ 
				if (value != m_IsValidStringValue)
				{
					StringValue = "";
					m_IsValidStringValue = value;
				}
			}
		}
		protected Boolean m_IsValidStringValue;
		protected String m_StringValue;
		#endregion

		#region Attribute - integerValue
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("integerValue", "http://www.opengis.net/gml", "IsValidIntegerValue", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "1", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger IntegerValue
		{
			get 
			{ 
				if (m_IsValidIntegerValue == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property integerValue is not valid. Set integerValueValid = true");
				return m_IntegerValue;  
			}
			set 
			{ 
				CheckElementRestriction(3, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("integerValue"); // remove selection
				m_IsValidIntegerValue = true;
				m_IntegerValue = value;
			}
		}
		/// <summary>
		/// 	Indicates if integerValue contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for integerValue is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get integerValue
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidIntegerValue
		{
			get
			{
				return m_IsValidIntegerValue;
			}
			set 
			{ 
				if (value != m_IsValidIntegerValue)
				{
					IntegerValue = 0;
					m_IsValidIntegerValue = value;
				}
			}
		}
		protected Boolean m_IsValidIntegerValue;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_IntegerValue;
		#endregion

		#region Attribute - booleanValue
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("booleanValue", "http://www.opengis.net/gml", "IsValidBooleanValue", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public Boolean BooleanValue
		{
			get 
			{ 
				if (m_IsValidBooleanValue == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property booleanValue is not valid. Set booleanValueValid = true");
				return m_BooleanValue;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("booleanValue"); // remove selection
				m_IsValidBooleanValue = true;
				m_BooleanValue = value;
			}
		}
		/// <summary>
		/// 	Indicates if booleanValue contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for booleanValue is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (false).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get booleanValue
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidBooleanValue
		{
			get
			{
				return m_IsValidBooleanValue;
			}
			set 
			{ 
				if (value != m_IsValidBooleanValue)
				{
					BooleanValue = false;
					m_IsValidBooleanValue = value;
				}
			}
		}
		protected Boolean m_IsValidBooleanValue;
		protected Boolean m_BooleanValue;
		#endregion

		#region Attribute - valueList
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("valueList", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ValueList))]
		public AE.ValueList ValueList
		{
			get 
			{ 
				return m_ValueList;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"valueList"); // remove selection
				if (value == null)
					m_ValueList = null;
				else
				{
					m_ValueList = value; 
				}
			}
		}
		protected AE.ValueList m_ValueList;
		
		#endregion

		#region Attribute - integerValueList
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("integerValueList", "http://www.opengis.net/gml", "IsValidIntegerValueList", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public String IntegerValueList
		{
			get 
			{ 
				if (m_IsValidIntegerValueList == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property integerValueList is not valid. Set integerValueListValid = true");
				return m_IntegerValueList;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("integerValueList"); // remove selection
				m_IsValidIntegerValueList = true;
				m_IntegerValueList = value;
			}
		}
		/// <summary>
		/// 	Indicates if integerValueList contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for integerValueList is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get integerValueList
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidIntegerValueList
		{
			get
			{
				return m_IsValidIntegerValueList;
			}
			set 
			{ 
				if (value != m_IsValidIntegerValueList)
				{
					IntegerValueList = "";
					m_IsValidIntegerValueList = value;
				}
			}
		}
		protected Boolean m_IsValidIntegerValueList;
		protected String m_IntegerValueList;
		#endregion

		#region Attribute - valueFile
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("valueFile", "http://www.opengis.net/gml", "IsValidValueFile", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public String ValueFile
		{
			get 
			{ 
				if (m_IsValidValueFile == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property valueFile is not valid. Set valueFileValid = true");
				return m_ValueFile;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("valueFile"); // remove selection
				m_IsValidValueFile = true;
				m_ValueFile = value;
			}
		}
		/// <summary>
		/// 	Indicates if valueFile contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for valueFile is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get valueFile
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidValueFile
		{
			get
			{
				return m_IsValidValueFile;
			}
			set 
			{ 
				if (value != m_IsValidValueFile)
				{
					ValueFile = "";
					m_IsValidValueFile = value;
				}
			}
		}
		protected Boolean m_IsValidValueFile;
		protected String m_ValueFile;
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


