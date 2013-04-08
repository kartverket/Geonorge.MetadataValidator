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

namespace AG
{
	/// <summary>
	/// 	This class represents the Element animateColor
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"animateColor", "http://www.w3.org/2001/SMIL20/Language", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class AnimateColor : CSW.XmlCommonBase
					, AF.IanimateColorPrototype
					, AG.IanimateColorType
	{
		#region Constructors
		/// <summary>
		///		Constructor for AnimateColor
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public AnimateColor()
		{
			_elementName = "animateColor";
			Init();
		}
		public AnimateColor(String elementName)
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
			m_AttributeName = "";
			m_AttributeType = CSW.Enumerations.IanimateColorPrototype_AttributeType.Auto;
			m_IsValidAttributeType = true;
			m_Additive = CSW.Enumerations.IanimateColorPrototype_Additive.Replace;
			m_IsValidAdditive = true;
			m_Accumulate = CSW.Enumerations.IanimateColorPrototype_Accumulate.None;
			m_IsValidAccumulate = true;
			m_To = "";
			m_IsValidTo = false;
			m_From = "";
			m_IsValidFrom = false;
			m_By = "";
			m_IsValidBy = false;
			m_Values = "";
			m_IsValidValues = false;
			m_AnimateColorTypeDataCol = new CSW.XmlObjectCollection<AG.AnimateColorType_Type>("animateColorTypeData", "http://www.w3.org/2001/SMIL20/Language", 0, -1, true);



// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
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
			AG.AnimateColor newObject = new AG.AnimateColor(_elementName);
			newObject.m_AttributeName = m_AttributeName;
			newObject.m_AttributeType = m_AttributeType;
			newObject.m_IsValidAttributeType = m_IsValidAttributeType;
			newObject.m_Additive = m_Additive;
			newObject.m_IsValidAdditive = m_IsValidAdditive;
			newObject.m_Accumulate = m_Accumulate;
			newObject.m_IsValidAccumulate = m_IsValidAccumulate;
			newObject.m_To = m_To;
			newObject.m_IsValidTo = m_IsValidTo;
			newObject.m_From = m_From;
			newObject.m_IsValidFrom = m_IsValidFrom;
			newObject.m_By = m_By;
			newObject.m_IsValidBy = m_IsValidBy;
			newObject.m_Values = m_Values;
			newObject.m_IsValidValues = m_IsValidValues;
			foreach (AG.AnimateColorType_Type o in m_AnimateColorTypeDataCol)
				newObject.m_AnimateColorTypeDataCol.Add((AG.AnimateColorType_Type)o.Clone());


// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			return newObject;
		}
		#endregion

		#region Member variables

		protected override String TargetNamespace
		{
			get { return "http://www.w3.org/2001/SMIL20/Language"; }
		}

		#region Attribute - attributeName
		/// <summary>
		///		Represents a mandatory Attribute in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Attribute in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to "".</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("attributeName", "", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String AttributeName
		{
			get 
			{ 
				return m_AttributeName;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_AttributeName = value;
			}
		}
		protected String m_AttributeName;

		#endregion

		#region Attribute - attributeType
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("attributeType", "", "IsValidAttributeType", typeof(CSW.Enumerations), "IanimateColorPrototype_AttributeTypeFromString", "IanimateColorPrototype_AttributeTypeToString", "auto")]
		public CSW.Enumerations.IanimateColorPrototype_AttributeType AttributeType
		{
			get 
			{ 
				if (m_IsValidAttributeType == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property attributeType is not valid. Set attributeTypeValid = true");
				return m_AttributeType;  
			}
			set 
			{ 
				m_AttributeType = value;
				m_IsValidAttributeType = true;
			}
		}
		/// <summary>
		/// 	Indicates if attributeType contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for attributeType is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (CSW.Enumerations.IanimateColorPrototype_AttributeType.Auto).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get attributeType
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidAttributeType
		{
			get { return m_IsValidAttributeType;  }
			set 
			{ 
				if (value != m_IsValidAttributeType)
				{
					AttributeType = CSW.Enumerations.IanimateColorPrototype_AttributeType.Auto;
					m_IsValidAttributeType = value;
				}
			}
		}
		protected CSW.Enumerations.IanimateColorPrototype_AttributeType m_AttributeType;
		protected Boolean m_IsValidAttributeType;

		#endregion

		#region Attribute - additive
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("additive", "", "IsValidAdditive", typeof(CSW.Enumerations), "IanimateColorPrototype_AdditiveFromString", "IanimateColorPrototype_AdditiveToString", "replace")]
		public CSW.Enumerations.IanimateColorPrototype_Additive Additive
		{
			get 
			{ 
				if (m_IsValidAdditive == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property additive is not valid. Set additiveValid = true");
				return m_Additive;  
			}
			set 
			{ 
				m_Additive = value;
				m_IsValidAdditive = true;
			}
		}
		/// <summary>
		/// 	Indicates if additive contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for additive is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (CSW.Enumerations.IanimateColorPrototype_Additive.Replace).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get additive
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidAdditive
		{
			get { return m_IsValidAdditive;  }
			set 
			{ 
				if (value != m_IsValidAdditive)
				{
					Additive = CSW.Enumerations.IanimateColorPrototype_Additive.Replace;
					m_IsValidAdditive = value;
				}
			}
		}
		protected CSW.Enumerations.IanimateColorPrototype_Additive m_Additive;
		protected Boolean m_IsValidAdditive;

		#endregion

		#region Attribute - accumulate
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("accumulate", "", "IsValidAccumulate", typeof(CSW.Enumerations), "IanimateColorPrototype_AccumulateFromString", "IanimateColorPrototype_AccumulateToString", "none")]
		public CSW.Enumerations.IanimateColorPrototype_Accumulate Accumulate
		{
			get 
			{ 
				if (m_IsValidAccumulate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property accumulate is not valid. Set accumulateValid = true");
				return m_Accumulate;  
			}
			set 
			{ 
				m_Accumulate = value;
				m_IsValidAccumulate = true;
			}
		}
		/// <summary>
		/// 	Indicates if accumulate contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for accumulate is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (CSW.Enumerations.IanimateColorPrototype_Accumulate.None).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get accumulate
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidAccumulate
		{
			get { return m_IsValidAccumulate;  }
			set 
			{ 
				if (value != m_IsValidAccumulate)
				{
					Accumulate = CSW.Enumerations.IanimateColorPrototype_Accumulate.None;
					m_IsValidAccumulate = value;
				}
			}
		}
		protected CSW.Enumerations.IanimateColorPrototype_Accumulate m_Accumulate;
		protected Boolean m_IsValidAccumulate;

		#endregion

		#region Attribute - to
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("to", "", "IsValidTo", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String to_
		{
			get 
			{ 
				if (m_IsValidTo == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property to_ is not valid. Set to_Valid = true");
				return m_To;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidTo = true;
				m_To = value;
			}
		}
		/// <summary>
		/// 	Indicates if to_ contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for to_ is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get to_
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidTo
		{
			get
			{
				return m_IsValidTo;
			}
			set 
			{ 
				if (value != m_IsValidTo)
				{
					to_ = "";
					m_IsValidTo = value;
				}
			}
		}
		protected Boolean m_IsValidTo;
		protected String m_To;
		#endregion

		#region Attribute - from
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("from", "", "IsValidFrom", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String From
		{
			get 
			{ 
				if (m_IsValidFrom == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property from is not valid. Set fromValid = true");
				return m_From;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidFrom = true;
				m_From = value;
			}
		}
		/// <summary>
		/// 	Indicates if from contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for from is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get from
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidFrom
		{
			get
			{
				return m_IsValidFrom;
			}
			set 
			{ 
				if (value != m_IsValidFrom)
				{
					From = "";
					m_IsValidFrom = value;
				}
			}
		}
		protected Boolean m_IsValidFrom;
		protected String m_From;
		#endregion

		#region Attribute - by
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("by", "", "IsValidBy", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String By
		{
			get 
			{ 
				if (m_IsValidBy == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property by is not valid. Set byValid = true");
				return m_By;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidBy = true;
				m_By = value;
			}
		}
		/// <summary>
		/// 	Indicates if by contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for by is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get by
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidBy
		{
			get
			{
				return m_IsValidBy;
			}
			set 
			{ 
				if (value != m_IsValidBy)
				{
					By = "";
					m_IsValidBy = value;
				}
			}
		}
		protected Boolean m_IsValidBy;
		protected String m_By;
		#endregion

		#region Attribute - values
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("values", "", "IsValidValues", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String Values
		{
			get 
			{ 
				if (m_IsValidValues == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property values is not valid. Set valuesValid = true");
				return m_Values;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidValues = true;
				m_Values = value;
			}
		}
		/// <summary>
		/// 	Indicates if values contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for values is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get values
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidValues
		{
			get
			{
				return m_IsValidValues;
			}
			set 
			{ 
				if (value != m_IsValidValues)
				{
					Values = "";
					m_IsValidValues = value;
				}
			}
		}
		protected Boolean m_IsValidValues;
		protected String m_Values;
		#endregion

		#region Attribute - animateColorTypeData
		/// <summary>
		/// 	A collection of animateColorTypeDataCols
		///		Holds all the information contained within the element
		/// </summary>
		/// <remarks>
		/// 	<BR>Because this is a base type, all the objects in it must be contained within a second class. This means all classes supporting this interface can expose use the same interface regardless of how they are extended.</BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("animateColorTypeData", "http://www.w3.org/2001/SMIL20/Language", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public CSW.XmlObjectCollection<AG.AnimateColorType_Type> AnimateColorTypeDataCol
		{
			get { return m_AnimateColorTypeDataCol; }
		}
		protected CSW.XmlObjectCollection<AG.AnimateColorType_Type> m_AnimateColorTypeDataCol;
		
		#endregion

		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://www.w3.org/2001/SMIL20/Language"; }
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

