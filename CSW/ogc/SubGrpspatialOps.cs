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
	/// 	This class represents the Element SubGrpspatialOps
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrpspatialOps", "http://www.opengis.net/ogc", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrpspatialOps : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrpspatialOps
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrpspatialOps()
		{
			_elementName = "SubGrpspatialOps";
			Init();
		}
		public SubGrpspatialOps(String elementName)
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
			m_SpatialOps = null;
			m_Touches = null;
			m_Disjoint = null;
			m_Contains = null;
			m_Within = null;
			m_DWithin = null;
			m_Equals = null;
			m_Overlaps = null;
			m_Crosses = null;
			m_Intersects = null;
			m_Beyond = null;
			m_BBOX = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_SpatialOps = null;
			m_Touches = null;
			m_Disjoint = null;
			m_Contains = null;
			m_Within = null;
			m_DWithin = null;
			m_Equals = null;
			m_Overlaps = null;
			m_Crosses = null;
			m_Intersects = null;
			m_Beyond = null;
			m_BBOX = null;
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
			ogc.SubGrpspatialOps newObject = new ogc.SubGrpspatialOps(_elementName);
			newObject.m_SpatialOps = null;
			if (m_SpatialOps != null)
				newObject.m_SpatialOps = (ogc.ISpatialOpsType)m_SpatialOps.Clone();
			newObject.m_Touches = null;
			if (m_Touches != null)
				newObject.m_Touches = (ogc.Touches)m_Touches.Clone();
			newObject.m_Disjoint = null;
			if (m_Disjoint != null)
				newObject.m_Disjoint = (ogc.Disjoint)m_Disjoint.Clone();
			newObject.m_Contains = null;
			if (m_Contains != null)
				newObject.m_Contains = (ogc.Contains)m_Contains.Clone();
			newObject.m_Within = null;
			if (m_Within != null)
				newObject.m_Within = (ogc.Within)m_Within.Clone();
			newObject.m_DWithin = null;
			if (m_DWithin != null)
				newObject.m_DWithin = (ogc.DWithin)m_DWithin.Clone();
			newObject.m_Equals = null;
			if (m_Equals != null)
				newObject.m_Equals = (ogc.Equals)m_Equals.Clone();
			newObject.m_Overlaps = null;
			if (m_Overlaps != null)
				newObject.m_Overlaps = (ogc.Overlaps)m_Overlaps.Clone();
			newObject.m_Crosses = null;
			if (m_Crosses != null)
				newObject.m_Crosses = (ogc.Crosses)m_Crosses.Clone();
			newObject.m_Intersects = null;
			if (m_Intersects != null)
				newObject.m_Intersects = (ogc.Intersects)m_Intersects.Clone();
			newObject.m_Beyond = null;
			if (m_Beyond != null)
				newObject.m_Beyond = (ogc.Beyond)m_Beyond.Clone();
			newObject.m_BBOX = null;
			if (m_BBOX != null)
				newObject.m_BBOX = (ogc.BBOX)m_BBOX.Clone();

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

		#region Attribute - spatialOps
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("spatialOps", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.ClassFactory), "ISpatialOpsTypeCreateObject")]
		public ogc.ISpatialOpsType SpatialOps
		{
			get 
			{ 
				return m_SpatialOps;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"spatialOps"); // remove selection
				if (value == null)
					m_SpatialOps = null;
				else
				{
					m_SpatialOps = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "spatialOps");
				}
			}
		}
		protected ogc.ISpatialOpsType m_SpatialOps;

		#endregion

		#region Attribute - Touches
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for spatialOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Touches", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Touches))]
		public ogc.Touches Touches
		{
			get 
			{ 
				return m_Touches;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Touches"); // remove selection
				if (value == null)
					m_Touches = null;
				else
				{
					m_Touches = value; 
				}
			}
		}
		protected ogc.Touches m_Touches;
		
		#endregion

		#region Attribute - Disjoint
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for spatialOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Disjoint", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Disjoint))]
		public ogc.Disjoint Disjoint
		{
			get 
			{ 
				return m_Disjoint;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Disjoint"); // remove selection
				if (value == null)
					m_Disjoint = null;
				else
				{
					m_Disjoint = value; 
				}
			}
		}
		protected ogc.Disjoint m_Disjoint;
		
		#endregion

		#region Attribute - Contains
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for spatialOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Contains", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Contains))]
		public ogc.Contains Contains
		{
			get 
			{ 
				return m_Contains;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Contains"); // remove selection
				if (value == null)
					m_Contains = null;
				else
				{
					m_Contains = value; 
				}
			}
		}
		protected ogc.Contains m_Contains;
		
		#endregion

		#region Attribute - Within
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for spatialOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Within", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Within))]
		public ogc.Within Within
		{
			get 
			{ 
				return m_Within;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Within"); // remove selection
				if (value == null)
					m_Within = null;
				else
				{
					m_Within = value; 
				}
			}
		}
		protected ogc.Within m_Within;
		
		#endregion

		#region Attribute - DWithin
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for spatialOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("DWithin", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.DWithin))]
		public ogc.DWithin DWithin
		{
			get 
			{ 
				return m_DWithin;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"DWithin"); // remove selection
				if (value == null)
					m_DWithin = null;
				else
				{
					m_DWithin = value; 
				}
			}
		}
		protected ogc.DWithin m_DWithin;
		
		#endregion

		#region Attribute - Equals
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for spatialOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Equals", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Equals))]
		public ogc.Equals Equals
		{
			get 
			{ 
				return m_Equals;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Equals"); // remove selection
				if (value == null)
					m_Equals = null;
				else
				{
					m_Equals = value; 
				}
			}
		}
		protected ogc.Equals m_Equals;
		
		#endregion

		#region Attribute - Overlaps
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for spatialOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Overlaps", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Overlaps))]
		public ogc.Overlaps Overlaps
		{
			get 
			{ 
				return m_Overlaps;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Overlaps"); // remove selection
				if (value == null)
					m_Overlaps = null;
				else
				{
					m_Overlaps = value; 
				}
			}
		}
		protected ogc.Overlaps m_Overlaps;
		
		#endregion

		#region Attribute - Crosses
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for spatialOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Crosses", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Crosses))]
		public ogc.Crosses Crosses
		{
			get 
			{ 
				return m_Crosses;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Crosses"); // remove selection
				if (value == null)
					m_Crosses = null;
				else
				{
					m_Crosses = value; 
				}
			}
		}
		protected ogc.Crosses m_Crosses;
		
		#endregion

		#region Attribute - Intersects
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for spatialOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Intersects", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Intersects))]
		public ogc.Intersects Intersects
		{
			get 
			{ 
				return m_Intersects;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Intersects"); // remove selection
				if (value == null)
					m_Intersects = null;
				else
				{
					m_Intersects = value; 
				}
			}
		}
		protected ogc.Intersects m_Intersects;
		
		#endregion

		#region Attribute - Beyond
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for spatialOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Beyond", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Beyond))]
		public ogc.Beyond Beyond
		{
			get 
			{ 
				return m_Beyond;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Beyond"); // remove selection
				if (value == null)
					m_Beyond = null;
				else
				{
					m_Beyond = value; 
				}
			}
		}
		protected ogc.Beyond m_Beyond;
		
		#endregion

		#region Attribute - BBOX
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for spatialOps
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("BBOX", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.BBOX))]
		public ogc.BBOX BBOX
		{
			get 
			{ 
				return m_BBOX;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"BBOX"); // remove selection
				if (value == null)
					m_BBOX = null;
				else
				{
					m_BBOX = value; 
				}
			}
		}
		protected ogc.BBOX m_BBOX;
		
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


