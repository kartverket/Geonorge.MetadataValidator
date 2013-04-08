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
	/// 	This class represents the Element PropertyIsBetween
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"PropertyIsBetween", "http://www.opengis.net/ogc", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class PropertyIsBetween : CSW.XmlCommonBase
					, ogc.IComparisonOpsType
	{
		#region Constructors
		/// <summary>
		///		Constructor for PropertyIsBetween
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public PropertyIsBetween()
		{
			_elementName = "PropertyIsBetween";
			Init();
		}
		public PropertyIsBetween(String elementName)
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
			m_Expression = new ogc.SubGrpexpression("expression");
			m_LowerBoundary = new ogc.LowerBoundaryType("LowerBoundary");
			m_UpperBoundary = new ogc.UpperBoundaryType("UpperBoundary");



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
			ogc.PropertyIsBetween newObject = new ogc.PropertyIsBetween(_elementName);
			newObject.m_Expression = null;
			if (m_Expression != null)
				newObject.m_Expression = (ogc.SubGrpexpression)m_Expression.Clone();
			newObject.m_LowerBoundary = null;
			if (m_LowerBoundary != null)
				newObject.m_LowerBoundary = (ogc.LowerBoundaryType)m_LowerBoundary.Clone();
			newObject.m_UpperBoundary = null;
			if (m_UpperBoundary != null)
				newObject.m_UpperBoundary = (ogc.UpperBoundaryType)m_UpperBoundary.Clone();


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

		#region Attribute - expression
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("expression", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(ogc.SubGrpexpression), false)]
		public ogc.SubGrpexpression Expression
		{
			get 
			{ 
				return m_Expression;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "expression");
				m_Expression = value;
			}
		}
		protected ogc.SubGrpexpression m_Expression;
		
		#endregion

		#region Attribute - LowerBoundary
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("LowerBoundary", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.LowerBoundaryType), false)]
		public ogc.LowerBoundaryType LowerBoundary
		{
			get 
			{ 
				return m_LowerBoundary;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "LowerBoundary");
				if (value != null)
					SetElementName(value, "LowerBoundary");
				m_LowerBoundary = value;
			}
		}
		protected ogc.LowerBoundaryType m_LowerBoundary;
		
		#endregion

		#region Attribute - UpperBoundary
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("UpperBoundary", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.UpperBoundaryType), false)]
		public ogc.UpperBoundaryType UpperBoundary
		{
			get 
			{ 
				return m_UpperBoundary;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "UpperBoundary");
				if (value != null)
					SetElementName(value, "UpperBoundary");
				m_UpperBoundary = value;
			}
		}
		protected ogc.UpperBoundaryType m_UpperBoundary;
		
		#endregion

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


