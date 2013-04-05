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

namespace AA
{
	/// <summary>
	/// 	This class represents the Element SubGrpDC-element
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrpDC-element", "http://purl.org/dc/elements/1.1/", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrpDC_element : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrpDC_element
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrpDC_element()
		{
			_elementName = "SubGrpDC-element";
			Init();
		}
		public SubGrpDC_element(String elementName)
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
			m_DC_element = null;
			m_RightsHolder = null;
			m_SubGrpaudience = null;
			m_Provenance = null;
			m_SubGrptitle = null;
			m_SubGrpdescription = null;
			m_Subject = null;
			m_SubGrprelation = null;
			m_Publisher = null;
			m_Contributor = null;
			m_Type = null;
			m_SubGrpdate = null;
			m_SubGrpcoverage = null;
			m_SubGrpformat = null;
			m_Creator = null;
			m_Source = null;
			m_SubGrprights = null;
			m_Language = null;
			m_SubGrpidentifier = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_DC_element = null;
			m_RightsHolder = null;
			m_SubGrpaudience = null;
			m_Provenance = null;
			m_SubGrptitle = null;
			m_SubGrpdescription = null;
			m_Subject = null;
			m_SubGrprelation = null;
			m_Publisher = null;
			m_Contributor = null;
			m_Type = null;
			m_SubGrpdate = null;
			m_SubGrpcoverage = null;
			m_SubGrpformat = null;
			m_Creator = null;
			m_Source = null;
			m_SubGrprights = null;
			m_Language = null;
			m_SubGrpidentifier = null;
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
			AA.SubGrpDC_element newObject = new AA.SubGrpDC_element(_elementName);
			newObject.m_DC_element = null;
			if (m_DC_element != null)
				newObject.m_DC_element = (AA.ISimpleLiteral)m_DC_element.Clone();
			newObject.m_RightsHolder = null;
			if (m_RightsHolder != null)
				newObject.m_RightsHolder = (AA.ISimpleLiteral)m_RightsHolder.Clone();
			newObject.m_SubGrpaudience = null;
			if (m_SubGrpaudience != null)
				newObject.m_SubGrpaudience = (AB.SubGrpaudience)m_SubGrpaudience.Clone();
			newObject.m_Provenance = null;
			if (m_Provenance != null)
				newObject.m_Provenance = (AA.ISimpleLiteral)m_Provenance.Clone();
			newObject.m_SubGrptitle = null;
			if (m_SubGrptitle != null)
				newObject.m_SubGrptitle = (AA.SubGrptitle)m_SubGrptitle.Clone();
			newObject.m_SubGrpdescription = null;
			if (m_SubGrpdescription != null)
				newObject.m_SubGrpdescription = (AA.SubGrpdescription)m_SubGrpdescription.Clone();
			newObject.m_Subject = null;
			if (m_Subject != null)
				newObject.m_Subject = (AA.ISimpleLiteral)m_Subject.Clone();
			newObject.m_SubGrprelation = null;
			if (m_SubGrprelation != null)
				newObject.m_SubGrprelation = (AA.SubGrprelation)m_SubGrprelation.Clone();
			newObject.m_Publisher = null;
			if (m_Publisher != null)
				newObject.m_Publisher = (AA.ISimpleLiteral)m_Publisher.Clone();
			newObject.m_Contributor = null;
			if (m_Contributor != null)
				newObject.m_Contributor = (AA.ISimpleLiteral)m_Contributor.Clone();
			newObject.m_Type = null;
			if (m_Type != null)
				newObject.m_Type = (AA.ISimpleLiteral)m_Type.Clone();
			newObject.m_SubGrpdate = null;
			if (m_SubGrpdate != null)
				newObject.m_SubGrpdate = (AA.SubGrpdate)m_SubGrpdate.Clone();
			newObject.m_SubGrpcoverage = null;
			if (m_SubGrpcoverage != null)
				newObject.m_SubGrpcoverage = (AA.SubGrpcoverage)m_SubGrpcoverage.Clone();
			newObject.m_SubGrpformat = null;
			if (m_SubGrpformat != null)
				newObject.m_SubGrpformat = (AA.SubGrpformat)m_SubGrpformat.Clone();
			newObject.m_Creator = null;
			if (m_Creator != null)
				newObject.m_Creator = (AA.ISimpleLiteral)m_Creator.Clone();
			newObject.m_Source = null;
			if (m_Source != null)
				newObject.m_Source = (AA.ISimpleLiteral)m_Source.Clone();
			newObject.m_SubGrprights = null;
			if (m_SubGrprights != null)
				newObject.m_SubGrprights = (AA.SubGrprights)m_SubGrprights.Clone();
			newObject.m_Language = null;
			if (m_Language != null)
				newObject.m_Language = (AA.ISimpleLiteral)m_Language.Clone();
			newObject.m_SubGrpidentifier = null;
			if (m_SubGrpidentifier != null)
				newObject.m_SubGrpidentifier = (AA.SubGrpidentifier)m_SubGrpidentifier.Clone();

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
			get { return "http://purl.org/dc/elements/1.1/"; }
		}

		#region Attribute - DC-element
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("DC-element", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral DC_element
		{
			get 
			{ 
				return m_DC_element;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"DC_element"); // remove selection
				if (value == null)
					m_DC_element = null;
				else
				{
					m_DC_element = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "DC-element");
				}
			}
		}
		protected AA.ISimpleLiteral m_DC_element;

		#endregion

		#region Attribute - rightsHolder
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for DC-element
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("rightsHolder", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral RightsHolder
		{
			get 
			{ 
				return m_RightsHolder;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"rightsHolder"); // remove selection
				if (value == null)
					m_RightsHolder = null;
				else
				{
					m_RightsHolder = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "rightsHolder");
				}
			}
		}
		protected AA.ISimpleLiteral m_RightsHolder;

		#endregion

		#region Attribute - SubGrpaudience
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for DC-element
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrpaudience", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AB.SubGrpaudience))]
		public AB.SubGrpaudience SubGrpaudience
		{
			get 
			{ 
				return m_SubGrpaudience;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrpaudience"); // remove selection
				if (value == null)
					m_SubGrpaudience = null;
				else
				{
					m_SubGrpaudience = value; 
				}
			}
		}
		protected AB.SubGrpaudience m_SubGrpaudience;
		
		#endregion

		#region Attribute - provenance
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for DC-element
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("provenance", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Provenance
		{
			get 
			{ 
				return m_Provenance;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"provenance"); // remove selection
				if (value == null)
					m_Provenance = null;
				else
				{
					m_Provenance = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "provenance");
				}
			}
		}
		protected AA.ISimpleLiteral m_Provenance;

		#endregion

		#region Attribute - SubGrptitle
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for DC-element
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrptitle", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AA.SubGrptitle))]
		public AA.SubGrptitle SubGrptitle
		{
			get 
			{ 
				return m_SubGrptitle;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrptitle"); // remove selection
				if (value == null)
					m_SubGrptitle = null;
				else
				{
					m_SubGrptitle = value; 
				}
			}
		}
		protected AA.SubGrptitle m_SubGrptitle;
		
		#endregion

		#region Attribute - SubGrpdescription
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for DC-element
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrpdescription", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AA.SubGrpdescription))]
		public AA.SubGrpdescription SubGrpdescription
		{
			get 
			{ 
				return m_SubGrpdescription;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrpdescription"); // remove selection
				if (value == null)
					m_SubGrpdescription = null;
				else
				{
					m_SubGrpdescription = value; 
				}
			}
		}
		protected AA.SubGrpdescription m_SubGrpdescription;
		
		#endregion

		#region Attribute - subject
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for DC-element
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("subject", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Subject
		{
			get 
			{ 
				return m_Subject;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"subject"); // remove selection
				if (value == null)
					m_Subject = null;
				else
				{
					m_Subject = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "subject");
				}
			}
		}
		protected AA.ISimpleLiteral m_Subject;

		#endregion

		#region Attribute - SubGrprelation
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for DC-element
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrprelation", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AA.SubGrprelation))]
		public AA.SubGrprelation SubGrprelation
		{
			get 
			{ 
				return m_SubGrprelation;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrprelation"); // remove selection
				if (value == null)
					m_SubGrprelation = null;
				else
				{
					m_SubGrprelation = value; 
				}
			}
		}
		protected AA.SubGrprelation m_SubGrprelation;
		
		#endregion

		#region Attribute - publisher
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for DC-element
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("publisher", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Publisher
		{
			get 
			{ 
				return m_Publisher;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"publisher"); // remove selection
				if (value == null)
					m_Publisher = null;
				else
				{
					m_Publisher = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "publisher");
				}
			}
		}
		protected AA.ISimpleLiteral m_Publisher;

		#endregion

		#region Attribute - contributor
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for DC-element
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("contributor", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Contributor
		{
			get 
			{ 
				return m_Contributor;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"contributor"); // remove selection
				if (value == null)
					m_Contributor = null;
				else
				{
					m_Contributor = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "contributor");
				}
			}
		}
		protected AA.ISimpleLiteral m_Contributor;

		#endregion

		#region Attribute - type
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for DC-element
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("type", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Type
		{
			get 
			{ 
				return m_Type;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"type"); // remove selection
				if (value == null)
					m_Type = null;
				else
				{
					m_Type = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "type");
				}
			}
		}
		protected AA.ISimpleLiteral m_Type;

		#endregion

		#region Attribute - SubGrpdate
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for DC-element
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrpdate", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AA.SubGrpdate))]
		public AA.SubGrpdate SubGrpdate
		{
			get 
			{ 
				return m_SubGrpdate;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrpdate"); // remove selection
				if (value == null)
					m_SubGrpdate = null;
				else
				{
					m_SubGrpdate = value; 
				}
			}
		}
		protected AA.SubGrpdate m_SubGrpdate;
		
		#endregion

		#region Attribute - SubGrpcoverage
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for DC-element
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrpcoverage", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AA.SubGrpcoverage))]
		public AA.SubGrpcoverage SubGrpcoverage
		{
			get 
			{ 
				return m_SubGrpcoverage;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrpcoverage"); // remove selection
				if (value == null)
					m_SubGrpcoverage = null;
				else
				{
					m_SubGrpcoverage = value; 
				}
			}
		}
		protected AA.SubGrpcoverage m_SubGrpcoverage;
		
		#endregion

		#region Attribute - SubGrpformat
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for DC-element
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrpformat", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AA.SubGrpformat))]
		public AA.SubGrpformat SubGrpformat
		{
			get 
			{ 
				return m_SubGrpformat;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrpformat"); // remove selection
				if (value == null)
					m_SubGrpformat = null;
				else
				{
					m_SubGrpformat = value; 
				}
			}
		}
		protected AA.SubGrpformat m_SubGrpformat;
		
		#endregion

		#region Attribute - creator
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for DC-element
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("creator", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Creator
		{
			get 
			{ 
				return m_Creator;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"creator"); // remove selection
				if (value == null)
					m_Creator = null;
				else
				{
					m_Creator = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "creator");
				}
			}
		}
		protected AA.ISimpleLiteral m_Creator;

		#endregion

		#region Attribute - source
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for DC-element
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("source", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Source
		{
			get 
			{ 
				return m_Source;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"source"); // remove selection
				if (value == null)
					m_Source = null;
				else
				{
					m_Source = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "source");
				}
			}
		}
		protected AA.ISimpleLiteral m_Source;

		#endregion

		#region Attribute - SubGrprights
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for DC-element
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrprights", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AA.SubGrprights))]
		public AA.SubGrprights SubGrprights
		{
			get 
			{ 
				return m_SubGrprights;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrprights"); // remove selection
				if (value == null)
					m_SubGrprights = null;
				else
				{
					m_SubGrprights = value; 
				}
			}
		}
		protected AA.SubGrprights m_SubGrprights;
		
		#endregion

		#region Attribute - language
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for DC-element
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("language", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Language
		{
			get 
			{ 
				return m_Language;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"language"); // remove selection
				if (value == null)
					m_Language = null;
				else
				{
					m_Language = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "language");
				}
			}
		}
		protected AA.ISimpleLiteral m_Language;

		#endregion

		#region Attribute - SubGrpidentifier
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for DC-element
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrpidentifier", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AA.SubGrpidentifier))]
		public AA.SubGrpidentifier SubGrpidentifier
		{
			get 
			{ 
				return m_SubGrpidentifier;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrpidentifier"); // remove selection
				if (value == null)
					m_SubGrpidentifier = null;
				else
				{
					m_SubGrpidentifier = value; 
				}
			}
		}
		protected AA.SubGrpidentifier m_SubGrpidentifier;
		
		#endregion

		public String ChoiceSelectedElement
		{
			get { return _validElement;  }
		}
		protected String _validElement;
		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://purl.org/dc/elements/1.1/"; }
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


