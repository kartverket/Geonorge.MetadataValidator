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
	/// 	This class represents the Element SubGrpdate
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrpdate", "http://purl.org/dc/elements/1.1/", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrpdate : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrpdate
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrpdate()
		{
			_elementName = "SubGrpdate";
			Init();
		}
		public SubGrpdate(String elementName)
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
			m_Date = null;
			m_Issued = null;
			m_Created = null;
			m_Valid = null;
			m_DateAccepted = null;
			m_Available = null;
			m_DateCopyrighted = null;
			m_DateSubmitted = null;
			m_Modified = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_Date = null;
			m_Issued = null;
			m_Created = null;
			m_Valid = null;
			m_DateAccepted = null;
			m_Available = null;
			m_DateCopyrighted = null;
			m_DateSubmitted = null;
			m_Modified = null;
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
			AA.SubGrpdate newObject = new AA.SubGrpdate(_elementName);
			newObject.m_Date = null;
			if (m_Date != null)
				newObject.m_Date = (AA.ISimpleLiteral)m_Date.Clone();
			newObject.m_Issued = null;
			if (m_Issued != null)
				newObject.m_Issued = (AA.ISimpleLiteral)m_Issued.Clone();
			newObject.m_Created = null;
			if (m_Created != null)
				newObject.m_Created = (AA.ISimpleLiteral)m_Created.Clone();
			newObject.m_Valid = null;
			if (m_Valid != null)
				newObject.m_Valid = (AA.ISimpleLiteral)m_Valid.Clone();
			newObject.m_DateAccepted = null;
			if (m_DateAccepted != null)
				newObject.m_DateAccepted = (AA.ISimpleLiteral)m_DateAccepted.Clone();
			newObject.m_Available = null;
			if (m_Available != null)
				newObject.m_Available = (AA.ISimpleLiteral)m_Available.Clone();
			newObject.m_DateCopyrighted = null;
			if (m_DateCopyrighted != null)
				newObject.m_DateCopyrighted = (AA.ISimpleLiteral)m_DateCopyrighted.Clone();
			newObject.m_DateSubmitted = null;
			if (m_DateSubmitted != null)
				newObject.m_DateSubmitted = (AA.ISimpleLiteral)m_DateSubmitted.Clone();
			newObject.m_Modified = null;
			if (m_Modified != null)
				newObject.m_Modified = (AA.ISimpleLiteral)m_Modified.Clone();

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

		#region Attribute - date
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("date", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Date
		{
			get 
			{ 
				return m_Date;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"date"); // remove selection
				if (value == null)
					m_Date = null;
				else
				{
					m_Date = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "date");
				}
			}
		}
		protected AA.ISimpleLiteral m_Date;

		#endregion

		#region Attribute - issued
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for date
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("issued", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Issued
		{
			get 
			{ 
				return m_Issued;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"issued"); // remove selection
				if (value == null)
					m_Issued = null;
				else
				{
					m_Issued = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "issued");
				}
			}
		}
		protected AA.ISimpleLiteral m_Issued;

		#endregion

		#region Attribute - created
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for date
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("created", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Created
		{
			get 
			{ 
				return m_Created;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"created"); // remove selection
				if (value == null)
					m_Created = null;
				else
				{
					m_Created = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "created");
				}
			}
		}
		protected AA.ISimpleLiteral m_Created;

		#endregion

		#region Attribute - valid
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for date
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("valid", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Valid
		{
			get 
			{ 
				return m_Valid;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"valid"); // remove selection
				if (value == null)
					m_Valid = null;
				else
				{
					m_Valid = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "valid");
				}
			}
		}
		protected AA.ISimpleLiteral m_Valid;

		#endregion

		#region Attribute - dateAccepted
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for date
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("dateAccepted", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral DateAccepted
		{
			get 
			{ 
				return m_DateAccepted;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"dateAccepted"); // remove selection
				if (value == null)
					m_DateAccepted = null;
				else
				{
					m_DateAccepted = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "dateAccepted");
				}
			}
		}
		protected AA.ISimpleLiteral m_DateAccepted;

		#endregion

		#region Attribute - available
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for date
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("available", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Available
		{
			get 
			{ 
				return m_Available;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"available"); // remove selection
				if (value == null)
					m_Available = null;
				else
				{
					m_Available = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "available");
				}
			}
		}
		protected AA.ISimpleLiteral m_Available;

		#endregion

		#region Attribute - dateCopyrighted
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for date
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("dateCopyrighted", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral DateCopyrighted
		{
			get 
			{ 
				return m_DateCopyrighted;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"dateCopyrighted"); // remove selection
				if (value == null)
					m_DateCopyrighted = null;
				else
				{
					m_DateCopyrighted = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "dateCopyrighted");
				}
			}
		}
		protected AA.ISimpleLiteral m_DateCopyrighted;

		#endregion

		#region Attribute - dateSubmitted
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for date
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("dateSubmitted", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral DateSubmitted
		{
			get 
			{ 
				return m_DateSubmitted;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"dateSubmitted"); // remove selection
				if (value == null)
					m_DateSubmitted = null;
				else
				{
					m_DateSubmitted = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "dateSubmitted");
				}
			}
		}
		protected AA.ISimpleLiteral m_DateSubmitted;

		#endregion

		#region Attribute - modified
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for date
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("modified", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Modified
		{
			get 
			{ 
				return m_Modified;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"modified"); // remove selection
				if (value == null)
					m_Modified = null;
				else
				{
					m_Modified = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "modified");
				}
			}
		}
		protected AA.ISimpleLiteral m_Modified;

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


