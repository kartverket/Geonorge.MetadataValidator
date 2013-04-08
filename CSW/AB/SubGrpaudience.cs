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

namespace AB
{
	/// <summary>
	/// 	This class represents the Element SubGrpaudience
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrpaudience", "http://purl.org/dc/terms/", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrpaudience : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrpaudience
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrpaudience()
		{
			_elementName = "SubGrpaudience";
			Init();
		}
		public SubGrpaudience(String elementName)
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
			m_Audience = null;
			m_EducationLevel = null;
			m_Mediator = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_Audience = null;
			m_EducationLevel = null;
			m_Mediator = null;
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
			AB.SubGrpaudience newObject = new AB.SubGrpaudience(_elementName);
			newObject.m_Audience = null;
			if (m_Audience != null)
				newObject.m_Audience = (AA.ISimpleLiteral)m_Audience.Clone();
			newObject.m_EducationLevel = null;
			if (m_EducationLevel != null)
				newObject.m_EducationLevel = (AA.ISimpleLiteral)m_EducationLevel.Clone();
			newObject.m_Mediator = null;
			if (m_Mediator != null)
				newObject.m_Mediator = (AA.ISimpleLiteral)m_Mediator.Clone();

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
			get { return "http://purl.org/dc/terms/"; }
		}

		#region Attribute - audience
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("audience", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Audience
		{
			get 
			{ 
				return m_Audience;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"audience"); // remove selection
				if (value == null)
					m_Audience = null;
				else
				{
					m_Audience = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "audience");
				}
			}
		}
		protected AA.ISimpleLiteral m_Audience;

		#endregion

		#region Attribute - educationLevel
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for audience
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("educationLevel", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral EducationLevel
		{
			get 
			{ 
				return m_EducationLevel;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"educationLevel"); // remove selection
				if (value == null)
					m_EducationLevel = null;
				else
				{
					m_EducationLevel = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "educationLevel");
				}
			}
		}
		protected AA.ISimpleLiteral m_EducationLevel;

		#endregion

		#region Attribute - mediator
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for audience
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("mediator", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Mediator
		{
			get 
			{ 
				return m_Mediator;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"mediator"); // remove selection
				if (value == null)
					m_Mediator = null;
				else
				{
					m_Mediator = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "mediator");
				}
			}
		}
		protected AA.ISimpleLiteral m_Mediator;

		#endregion

		public String ChoiceSelectedElement
		{
			get { return _validElement;  }
		}
		protected String _validElement;
		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://purl.org/dc/terms/"; }
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


