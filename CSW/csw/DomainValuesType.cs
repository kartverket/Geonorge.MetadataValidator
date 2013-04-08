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

namespace csw
{
	/// <summary>
	/// 	This class represents the ComplexType DomainValuesType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"DomainValuesType", "http://www.opengis.net/cat/csw/2.0.2", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class DomainValuesType : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for DomainValuesType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public DomainValuesType()
		{
			_elementName = "DomainValuesType";
			Init();
		}
		public DomainValuesType(String elementName)
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
			m_Type = "";
			m_Uom = "";
			m_IsValidUom = false;
			m_DomainValuesType_Choice = new csw.DomainValuesType_Choice("DomainValuesType_Choice");
			m_DomainValuesType_ChoiceA = null;



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
			csw.DomainValuesType newObject = new csw.DomainValuesType(_elementName);
			newObject.m_Type = m_Type;
			newObject.m_Uom = m_Uom;
			newObject.m_IsValidUom = m_IsValidUom;
			newObject.m_DomainValuesType_Choice = null;
			if (m_DomainValuesType_Choice != null)
				newObject.m_DomainValuesType_Choice = (csw.DomainValuesType_Choice)m_DomainValuesType_Choice.Clone();
			newObject.m_DomainValuesType_ChoiceA = null;
			if (m_DomainValuesType_ChoiceA != null)
				newObject.m_DomainValuesType_ChoiceA = (csw.DomainValuesType_ChoiceA)m_DomainValuesType_ChoiceA.Clone();


// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			return newObject;
		}
		#endregion

		#region Member variables

		protected override String TargetNamespace
		{
			get { return "http://www.opengis.net/cat/csw/2.0.2"; }
		}

		#region Attribute - type
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
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("type", "", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String Type
		{
			get 
			{ 
				return m_Type;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_Type = value;
			}
		}
		protected String m_Type;

		#endregion

		#region Attribute - uom
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("uom", "", "IsValidUom", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String Uom
		{
			get 
			{ 
				if (m_IsValidUom == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property uom is not valid. Set uomValid = true");
				return m_Uom;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidUom = true;
				m_Uom = value;
			}
		}
		/// <summary>
		/// 	Indicates if uom contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for uom is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get uom
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidUom
		{
			get
			{
				return m_IsValidUom;
			}
			set 
			{ 
				if (value != m_IsValidUom)
				{
					Uom = "";
					m_IsValidUom = value;
				}
			}
		}
		protected Boolean m_IsValidUom;
		protected String m_Uom;
		#endregion

		#region Attribute - DomainValuesType_Choice
		/// <summary>
		///		Represents a mandatory Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>If this property is set, then the object will be COPIED. If the property is set to null an exception is raised.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("DomainValuesType_Choice", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(csw.DomainValuesType_Choice), false)]
		public csw.DomainValuesType_Choice DomainValuesType_Choice
		{
			get 
			{ 
				return m_DomainValuesType_Choice;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "DomainValuesType_Choice");
				m_DomainValuesType_Choice = value;
			}
		}
		protected csw.DomainValuesType_Choice m_DomainValuesType_Choice;
		
		#endregion

		#region Attribute - DomainValuesType_ChoiceA
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("DomainValuesType_ChoiceA", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(csw.DomainValuesType_ChoiceA))]
		public csw.DomainValuesType_ChoiceA DomainValuesType_ChoiceA
		{
			get 
			{ 
				return m_DomainValuesType_ChoiceA;  
			}
			set 
			{ 
				if (value == null)
					m_DomainValuesType_ChoiceA = null;
				else
				{
					m_DomainValuesType_ChoiceA = value; 
				}
			}
		}
		protected csw.DomainValuesType_ChoiceA m_DomainValuesType_ChoiceA;
		
		#endregion

		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://www.opengis.net/cat/csw/2.0.2"; }
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


