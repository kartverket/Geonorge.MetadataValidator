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
	/// 	This class represents the ComplexType Scalar_CapabilitiesType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"Scalar_CapabilitiesType", "http://www.opengis.net/ogc", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Scalar_CapabilitiesType : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for Scalar_CapabilitiesType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public Scalar_CapabilitiesType()
		{
			_elementName = "Scalar_CapabilitiesType";
			Init();
		}
		public Scalar_CapabilitiesType(String elementName)
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
			m_LogicalOperators = null;
			m_ComparisonOperators = null;
			m_ArithmeticOperators = null;



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
			ogc.Scalar_CapabilitiesType newObject = new ogc.Scalar_CapabilitiesType(_elementName);
			newObject.m_LogicalOperators = null;
			if (m_LogicalOperators != null)
				newObject.m_LogicalOperators = (ogc.LogicalOperators)m_LogicalOperators.Clone();
			newObject.m_ComparisonOperators = null;
			if (m_ComparisonOperators != null)
				newObject.m_ComparisonOperators = (ogc.ComparisonOperatorsType)m_ComparisonOperators.Clone();
			newObject.m_ArithmeticOperators = null;
			if (m_ArithmeticOperators != null)
				newObject.m_ArithmeticOperators = (ogc.ArithmeticOperatorsType)m_ArithmeticOperators.Clone();


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

		#region Attribute - LogicalOperators
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("LogicalOperators", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.LogicalOperators))]
		public ogc.LogicalOperators LogicalOperators
		{
			get 
			{ 
				return m_LogicalOperators;  
			}
			set 
			{ 
				if (value == null)
					m_LogicalOperators = null;
				else
				{
					m_LogicalOperators = value; 
				}
			}
		}
		protected ogc.LogicalOperators m_LogicalOperators;
		
		#endregion

		#region Attribute - ComparisonOperators
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("ComparisonOperators", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.ComparisonOperatorsType))]
		public ogc.ComparisonOperatorsType ComparisonOperators
		{
			get 
			{ 
				return m_ComparisonOperators;  
			}
			set 
			{ 
				if (value == null)
					m_ComparisonOperators = null;
				else
				{
					SetElementName(value, "ComparisonOperators");
					m_ComparisonOperators = value; 
				}
			}
		}
		protected ogc.ComparisonOperatorsType m_ComparisonOperators;
		
		#endregion

		#region Attribute - ArithmeticOperators
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("ArithmeticOperators", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.ArithmeticOperatorsType))]
		public ogc.ArithmeticOperatorsType ArithmeticOperators
		{
			get 
			{ 
				return m_ArithmeticOperators;  
			}
			set 
			{ 
				if (value == null)
					m_ArithmeticOperators = null;
				else
				{
					SetElementName(value, "ArithmeticOperators");
					m_ArithmeticOperators = value; 
				}
			}
		}
		protected ogc.ArithmeticOperatorsType m_ArithmeticOperators;
		
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


