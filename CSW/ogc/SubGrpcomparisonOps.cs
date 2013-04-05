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

namespace ogc
{
	/// <summary>
	/// 	This class represents the Element SubGrpcomparisonOps
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrpcomparisonOps", "http://www.opengis.net/ogc", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrpcomparisonOps : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrpcomparisonOps
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrpcomparisonOps()
		{
			_elementName = "SubGrpcomparisonOps";
			Init();
		}
		public SubGrpcomparisonOps(String elementName)
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
			m_ComparisonOps = null;
			m_PropertyIsLike = null;
			m_PropertyIsBetween = null;
			m_PropertyIsLessThanOrEqualTo = null;
			m_PropertyIsEqualTo = null;
			m_PropertyIsNotEqualTo = null;
			m_PropertyIsLessThan = null;
			m_PropertyIsGreaterThan = null;
			m_PropertyIsGreaterThanOrEqualTo = null;
			m_PropertyIsNull = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_ComparisonOps = null;
			m_PropertyIsLike = null;
			m_PropertyIsBetween = null;
			m_PropertyIsLessThanOrEqualTo = null;
			m_PropertyIsEqualTo = null;
			m_PropertyIsNotEqualTo = null;
			m_PropertyIsLessThan = null;
			m_PropertyIsGreaterThan = null;
			m_PropertyIsGreaterThanOrEqualTo = null;
			m_PropertyIsNull = null;
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
			ogc.SubGrpcomparisonOps newObject = new ogc.SubGrpcomparisonOps(_elementName);
			newObject.m_ComparisonOps = null;
			if (m_ComparisonOps != null)
				newObject.m_ComparisonOps = (ogc.IComparisonOpsType)m_ComparisonOps.Clone();
			newObject.m_PropertyIsLike = null;
			if (m_PropertyIsLike != null)
				newObject.m_PropertyIsLike = (ogc.PropertyIsLike)m_PropertyIsLike.Clone();
			newObject.m_PropertyIsBetween = null;
			if (m_PropertyIsBetween != null)
				newObject.m_PropertyIsBetween = (ogc.PropertyIsBetween)m_PropertyIsBetween.Clone();
			newObject.m_PropertyIsLessThanOrEqualTo = null;
			if (m_PropertyIsLessThanOrEqualTo != null)
				newObject.m_PropertyIsLessThanOrEqualTo = (ogc.PropertyIsLessThanOrEqualTo)m_PropertyIsLessThanOrEqualTo.Clone();
			newObject.m_PropertyIsEqualTo = null;
			if (m_PropertyIsEqualTo != null)
				newObject.m_PropertyIsEqualTo = (ogc.PropertyIsEqualTo)m_PropertyIsEqualTo.Clone();
			newObject.m_PropertyIsNotEqualTo = null;
			if (m_PropertyIsNotEqualTo != null)
				newObject.m_PropertyIsNotEqualTo = (ogc.PropertyIsNotEqualTo)m_PropertyIsNotEqualTo.Clone();
			newObject.m_PropertyIsLessThan = null;
			if (m_PropertyIsLessThan != null)
				newObject.m_PropertyIsLessThan = (ogc.PropertyIsLessThan)m_PropertyIsLessThan.Clone();
			newObject.m_PropertyIsGreaterThan = null;
			if (m_PropertyIsGreaterThan != null)
				newObject.m_PropertyIsGreaterThan = (ogc.PropertyIsGreaterThan)m_PropertyIsGreaterThan.Clone();
			newObject.m_PropertyIsGreaterThanOrEqualTo = null;
			if (m_PropertyIsGreaterThanOrEqualTo != null)
				newObject.m_PropertyIsGreaterThanOrEqualTo = (ogc.PropertyIsGreaterThanOrEqualTo)m_PropertyIsGreaterThanOrEqualTo.Clone();
			newObject.m_PropertyIsNull = null;
			if (m_PropertyIsNull != null)
				newObject.m_PropertyIsNull = (ogc.PropertyIsNull)m_PropertyIsNull.Clone();

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
			get { return "http://www.opengis.net/ogc"; }
		}

		#region Attribute - comparisonOps
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("comparisonOps", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.ClassFactory), "IComparisonOpsTypeCreateObject")]
		public ogc.IComparisonOpsType ComparisonOps
		{
			get 
			{ 
				return m_ComparisonOps;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"comparisonOps"); // remove selection
				if (value == null)
					m_ComparisonOps = null;
				else
				{
					m_ComparisonOps = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "comparisonOps");
				}
			}
		}
		protected ogc.IComparisonOpsType m_ComparisonOps;

		#endregion

		#region Attribute - PropertyIsLike
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for comparisonOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("PropertyIsLike", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.PropertyIsLike))]
		public ogc.PropertyIsLike PropertyIsLike
		{
			get 
			{ 
				return m_PropertyIsLike;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"PropertyIsLike"); // remove selection
				if (value == null)
					m_PropertyIsLike = null;
				else
				{
					m_PropertyIsLike = value; 
				}
			}
		}
		protected ogc.PropertyIsLike m_PropertyIsLike;
		
		#endregion

		#region Attribute - PropertyIsBetween
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for comparisonOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("PropertyIsBetween", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.PropertyIsBetween))]
		public ogc.PropertyIsBetween PropertyIsBetween
		{
			get 
			{ 
				return m_PropertyIsBetween;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"PropertyIsBetween"); // remove selection
				if (value == null)
					m_PropertyIsBetween = null;
				else
				{
					m_PropertyIsBetween = value; 
				}
			}
		}
		protected ogc.PropertyIsBetween m_PropertyIsBetween;
		
		#endregion

		#region Attribute - PropertyIsLessThanOrEqualTo
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for comparisonOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("PropertyIsLessThanOrEqualTo", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.PropertyIsLessThanOrEqualTo))]
		public ogc.PropertyIsLessThanOrEqualTo PropertyIsLessThanOrEqualTo
		{
			get 
			{ 
				return m_PropertyIsLessThanOrEqualTo;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"PropertyIsLessThanOrEqualTo"); // remove selection
				if (value == null)
					m_PropertyIsLessThanOrEqualTo = null;
				else
				{
					m_PropertyIsLessThanOrEqualTo = value; 
				}
			}
		}
		protected ogc.PropertyIsLessThanOrEqualTo m_PropertyIsLessThanOrEqualTo;
		
		#endregion

		#region Attribute - PropertyIsEqualTo
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for comparisonOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("PropertyIsEqualTo", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.PropertyIsEqualTo))]
		public ogc.PropertyIsEqualTo PropertyIsEqualTo
		{
			get 
			{ 
				return m_PropertyIsEqualTo;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"PropertyIsEqualTo"); // remove selection
				if (value == null)
					m_PropertyIsEqualTo = null;
				else
				{
					m_PropertyIsEqualTo = value; 
				}
			}
		}
		protected ogc.PropertyIsEqualTo m_PropertyIsEqualTo;
		
		#endregion

		#region Attribute - PropertyIsNotEqualTo
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for comparisonOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("PropertyIsNotEqualTo", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.PropertyIsNotEqualTo))]
		public ogc.PropertyIsNotEqualTo PropertyIsNotEqualTo
		{
			get 
			{ 
				return m_PropertyIsNotEqualTo;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"PropertyIsNotEqualTo"); // remove selection
				if (value == null)
					m_PropertyIsNotEqualTo = null;
				else
				{
					m_PropertyIsNotEqualTo = value; 
				}
			}
		}
		protected ogc.PropertyIsNotEqualTo m_PropertyIsNotEqualTo;
		
		#endregion

		#region Attribute - PropertyIsLessThan
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for comparisonOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("PropertyIsLessThan", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.PropertyIsLessThan))]
		public ogc.PropertyIsLessThan PropertyIsLessThan
		{
			get 
			{ 
				return m_PropertyIsLessThan;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"PropertyIsLessThan"); // remove selection
				if (value == null)
					m_PropertyIsLessThan = null;
				else
				{
					m_PropertyIsLessThan = value; 
				}
			}
		}
		protected ogc.PropertyIsLessThan m_PropertyIsLessThan;
		
		#endregion

		#region Attribute - PropertyIsGreaterThan
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for comparisonOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("PropertyIsGreaterThan", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.PropertyIsGreaterThan))]
		public ogc.PropertyIsGreaterThan PropertyIsGreaterThan
		{
			get 
			{ 
				return m_PropertyIsGreaterThan;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"PropertyIsGreaterThan"); // remove selection
				if (value == null)
					m_PropertyIsGreaterThan = null;
				else
				{
					m_PropertyIsGreaterThan = value; 
				}
			}
		}
		protected ogc.PropertyIsGreaterThan m_PropertyIsGreaterThan;
		
		#endregion

		#region Attribute - PropertyIsGreaterThanOrEqualTo
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for comparisonOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("PropertyIsGreaterThanOrEqualTo", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.PropertyIsGreaterThanOrEqualTo))]
		public ogc.PropertyIsGreaterThanOrEqualTo PropertyIsGreaterThanOrEqualTo
		{
			get 
			{ 
				return m_PropertyIsGreaterThanOrEqualTo;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"PropertyIsGreaterThanOrEqualTo"); // remove selection
				if (value == null)
					m_PropertyIsGreaterThanOrEqualTo = null;
				else
				{
					m_PropertyIsGreaterThanOrEqualTo = value; 
				}
			}
		}
		protected ogc.PropertyIsGreaterThanOrEqualTo m_PropertyIsGreaterThanOrEqualTo;
		
		#endregion

		#region Attribute - PropertyIsNull
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for comparisonOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("PropertyIsNull", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.PropertyIsNull))]
		public ogc.PropertyIsNull PropertyIsNull
		{
			get 
			{ 
				return m_PropertyIsNull;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"PropertyIsNull"); // remove selection
				if (value == null)
					m_PropertyIsNull = null;
				else
				{
					m_PropertyIsNull = value; 
				}
			}
		}
		protected ogc.PropertyIsNull m_PropertyIsNull;
		
		#endregion

		public String ChoiceSelectedElement
		{
			get { return _validElement;  }
		}
		protected String _validElement;
		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://www.opengis.net/ogc"; }
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


