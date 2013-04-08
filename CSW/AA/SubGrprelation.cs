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
	/// 	This class represents the Element SubGrprelation
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrprelation", "http://purl.org/dc/elements/1.1/", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrprelation : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrprelation
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrprelation()
		{
			_elementName = "SubGrprelation";
			Init();
		}
		public SubGrprelation(String elementName)
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
			m_Relation = null;
			m_ConformsTo = null;
			m_Requires = null;
			m_IsVersionOf = null;
			m_IsReplacedBy = null;
			m_References = null;
			m_HasVersion = null;
			m_IsPartOf = null;
			m_HasPart = null;
			m_IsFormatOf = null;
			m_Replaces = null;
			m_IsReferencedBy = null;
			m_IsRequiredBy = null;
			m_HasFormat = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_Relation = null;
			m_ConformsTo = null;
			m_Requires = null;
			m_IsVersionOf = null;
			m_IsReplacedBy = null;
			m_References = null;
			m_HasVersion = null;
			m_IsPartOf = null;
			m_HasPart = null;
			m_IsFormatOf = null;
			m_Replaces = null;
			m_IsReferencedBy = null;
			m_IsRequiredBy = null;
			m_HasFormat = null;
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
			AA.SubGrprelation newObject = new AA.SubGrprelation(_elementName);
			newObject.m_Relation = null;
			if (m_Relation != null)
				newObject.m_Relation = (AA.ISimpleLiteral)m_Relation.Clone();
			newObject.m_ConformsTo = null;
			if (m_ConformsTo != null)
				newObject.m_ConformsTo = (AA.ISimpleLiteral)m_ConformsTo.Clone();
			newObject.m_Requires = null;
			if (m_Requires != null)
				newObject.m_Requires = (AA.ISimpleLiteral)m_Requires.Clone();
			newObject.m_IsVersionOf = null;
			if (m_IsVersionOf != null)
				newObject.m_IsVersionOf = (AA.ISimpleLiteral)m_IsVersionOf.Clone();
			newObject.m_IsReplacedBy = null;
			if (m_IsReplacedBy != null)
				newObject.m_IsReplacedBy = (AA.ISimpleLiteral)m_IsReplacedBy.Clone();
			newObject.m_References = null;
			if (m_References != null)
				newObject.m_References = (AA.ISimpleLiteral)m_References.Clone();
			newObject.m_HasVersion = null;
			if (m_HasVersion != null)
				newObject.m_HasVersion = (AA.ISimpleLiteral)m_HasVersion.Clone();
			newObject.m_IsPartOf = null;
			if (m_IsPartOf != null)
				newObject.m_IsPartOf = (AA.ISimpleLiteral)m_IsPartOf.Clone();
			newObject.m_HasPart = null;
			if (m_HasPart != null)
				newObject.m_HasPart = (AA.ISimpleLiteral)m_HasPart.Clone();
			newObject.m_IsFormatOf = null;
			if (m_IsFormatOf != null)
				newObject.m_IsFormatOf = (AA.ISimpleLiteral)m_IsFormatOf.Clone();
			newObject.m_Replaces = null;
			if (m_Replaces != null)
				newObject.m_Replaces = (AA.ISimpleLiteral)m_Replaces.Clone();
			newObject.m_IsReferencedBy = null;
			if (m_IsReferencedBy != null)
				newObject.m_IsReferencedBy = (AA.ISimpleLiteral)m_IsReferencedBy.Clone();
			newObject.m_IsRequiredBy = null;
			if (m_IsRequiredBy != null)
				newObject.m_IsRequiredBy = (AA.ISimpleLiteral)m_IsRequiredBy.Clone();
			newObject.m_HasFormat = null;
			if (m_HasFormat != null)
				newObject.m_HasFormat = (AA.ISimpleLiteral)m_HasFormat.Clone();

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

		#region Attribute - relation
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("relation", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Relation
		{
			get 
			{ 
				return m_Relation;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"relation"); // remove selection
				if (value == null)
					m_Relation = null;
				else
				{
					m_Relation = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "relation");
				}
			}
		}
		protected AA.ISimpleLiteral m_Relation;

		#endregion

		#region Attribute - conformsTo
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for relation
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("conformsTo", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral ConformsTo
		{
			get 
			{ 
				return m_ConformsTo;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"conformsTo"); // remove selection
				if (value == null)
					m_ConformsTo = null;
				else
				{
					m_ConformsTo = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "conformsTo");
				}
			}
		}
		protected AA.ISimpleLiteral m_ConformsTo;

		#endregion

		#region Attribute - requires
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for relation
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("requires", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Requires
		{
			get 
			{ 
				return m_Requires;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"requires"); // remove selection
				if (value == null)
					m_Requires = null;
				else
				{
					m_Requires = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "requires");
				}
			}
		}
		protected AA.ISimpleLiteral m_Requires;

		#endregion

		#region Attribute - isVersionOf
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for relation
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("isVersionOf", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral IsVersionOf
		{
			get 
			{ 
				return m_IsVersionOf;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"isVersionOf"); // remove selection
				if (value == null)
					m_IsVersionOf = null;
				else
				{
					m_IsVersionOf = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "isVersionOf");
				}
			}
		}
		protected AA.ISimpleLiteral m_IsVersionOf;

		#endregion

		#region Attribute - isReplacedBy
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for relation
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("isReplacedBy", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral IsReplacedBy
		{
			get 
			{ 
				return m_IsReplacedBy;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"isReplacedBy"); // remove selection
				if (value == null)
					m_IsReplacedBy = null;
				else
				{
					m_IsReplacedBy = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "isReplacedBy");
				}
			}
		}
		protected AA.ISimpleLiteral m_IsReplacedBy;

		#endregion

		#region Attribute - references
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for relation
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("references", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral References
		{
			get 
			{ 
				return m_References;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"references"); // remove selection
				if (value == null)
					m_References = null;
				else
				{
					m_References = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "references");
				}
			}
		}
		protected AA.ISimpleLiteral m_References;

		#endregion

		#region Attribute - hasVersion
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for relation
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("hasVersion", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral HasVersion
		{
			get 
			{ 
				return m_HasVersion;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"hasVersion"); // remove selection
				if (value == null)
					m_HasVersion = null;
				else
				{
					m_HasVersion = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "hasVersion");
				}
			}
		}
		protected AA.ISimpleLiteral m_HasVersion;

		#endregion

		#region Attribute - isPartOf
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for relation
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("isPartOf", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral IsPartOf
		{
			get 
			{ 
				return m_IsPartOf;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"isPartOf"); // remove selection
				if (value == null)
					m_IsPartOf = null;
				else
				{
					m_IsPartOf = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "isPartOf");
				}
			}
		}
		protected AA.ISimpleLiteral m_IsPartOf;

		#endregion

		#region Attribute - hasPart
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for relation
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("hasPart", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral HasPart
		{
			get 
			{ 
				return m_HasPart;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"hasPart"); // remove selection
				if (value == null)
					m_HasPart = null;
				else
				{
					m_HasPart = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "hasPart");
				}
			}
		}
		protected AA.ISimpleLiteral m_HasPart;

		#endregion

		#region Attribute - isFormatOf
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for relation
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("isFormatOf", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral IsFormatOf
		{
			get 
			{ 
				return m_IsFormatOf;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"isFormatOf"); // remove selection
				if (value == null)
					m_IsFormatOf = null;
				else
				{
					m_IsFormatOf = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "isFormatOf");
				}
			}
		}
		protected AA.ISimpleLiteral m_IsFormatOf;

		#endregion

		#region Attribute - replaces
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for relation
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("replaces", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Replaces
		{
			get 
			{ 
				return m_Replaces;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"replaces"); // remove selection
				if (value == null)
					m_Replaces = null;
				else
				{
					m_Replaces = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "replaces");
				}
			}
		}
		protected AA.ISimpleLiteral m_Replaces;

		#endregion

		#region Attribute - isReferencedBy
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for relation
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("isReferencedBy", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral IsReferencedBy
		{
			get 
			{ 
				return m_IsReferencedBy;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"isReferencedBy"); // remove selection
				if (value == null)
					m_IsReferencedBy = null;
				else
				{
					m_IsReferencedBy = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "isReferencedBy");
				}
			}
		}
		protected AA.ISimpleLiteral m_IsReferencedBy;

		#endregion

		#region Attribute - isRequiredBy
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for relation
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("isRequiredBy", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral IsRequiredBy
		{
			get 
			{ 
				return m_IsRequiredBy;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"isRequiredBy"); // remove selection
				if (value == null)
					m_IsRequiredBy = null;
				else
				{
					m_IsRequiredBy = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "isRequiredBy");
				}
			}
		}
		protected AA.ISimpleLiteral m_IsRequiredBy;

		#endregion

		#region Attribute - hasFormat
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for relation
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("hasFormat", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral HasFormat
		{
			get 
			{ 
				return m_HasFormat;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"hasFormat"); // remove selection
				if (value == null)
					m_HasFormat = null;
				else
				{
					m_HasFormat = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "hasFormat");
				}
			}
		}
		protected AA.ISimpleLiteral m_HasFormat;

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


