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
	/// 	This class represents the Element SubGrpdescription
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrpdescription", "http://purl.org/dc/elements/1.1/", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrpdescription : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrpdescription
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrpdescription()
		{
			_elementName = "SubGrpdescription";
			Init();
		}
		public SubGrpdescription(String elementName)
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
			m_Description = null;
			m_Abstract = null;
			m_TableOfContents = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_Description = null;
			m_Abstract = null;
			m_TableOfContents = null;
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
			AA.SubGrpdescription newObject = new AA.SubGrpdescription(_elementName);
			newObject.m_Description = null;
			if (m_Description != null)
				newObject.m_Description = (AA.ISimpleLiteral)m_Description.Clone();
			newObject.m_Abstract = null;
			if (m_Abstract != null)
				newObject.m_Abstract = (AA.ISimpleLiteral)m_Abstract.Clone();
			newObject.m_TableOfContents = null;
			if (m_TableOfContents != null)
				newObject.m_TableOfContents = (AA.ISimpleLiteral)m_TableOfContents.Clone();

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

		#region Attribute - description
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("description", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Description
		{
			get 
			{ 
				return m_Description;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"description"); // remove selection
				if (value == null)
					m_Description = null;
				else
				{
					m_Description = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "description");
				}
			}
		}
		protected AA.ISimpleLiteral m_Description;

		#endregion

		#region Attribute - abstract
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for description
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("abstract", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral abstract_
		{
			get 
			{ 
				return m_Abstract;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"abstract_"); // remove selection
				if (value == null)
					m_Abstract = null;
				else
				{
					m_Abstract = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "abstract");
				}
			}
		}
		protected AA.ISimpleLiteral m_Abstract;

		#endregion

		#region Attribute - tableOfContents
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for description
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("tableOfContents", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral TableOfContents
		{
			get 
			{ 
				return m_TableOfContents;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"tableOfContents"); // remove selection
				if (value == null)
					m_TableOfContents = null;
				else
				{
					m_TableOfContents = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "tableOfContents");
				}
			}
		}
		protected AA.ISimpleLiteral m_TableOfContents;

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


