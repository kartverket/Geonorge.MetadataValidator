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

namespace ows
{
	/// <summary>
	/// 	This class represents the Element OperationsMetadata
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"OperationsMetadata", "http://www.opengis.net/ows", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class OperationsMetadata : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for OperationsMetadata
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public OperationsMetadata()
		{
			_elementName = "OperationsMetadata";
			Init();
		}
		public OperationsMetadata(String elementName)
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
			m_OperationCol = new CSW.XmlObjectCollection<ows.Operation>("Operation", "http://www.opengis.net/ows", 2, -1, false);
			m_ParameterCol = new CSW.XmlObjectCollection<ows.DomainType>("Parameter", "http://www.opengis.net/ows", 0, -1, false);
			m_ConstraintCol = new CSW.XmlObjectCollection<ows.DomainType>("Constraint", "http://www.opengis.net/ows", 0, -1, false);
			m_ExtendedCapabilities = null;



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
			ows.OperationsMetadata newObject = new ows.OperationsMetadata(_elementName);
			foreach (ows.Operation o in m_OperationCol)
				newObject.m_OperationCol.Add((ows.Operation)o.Clone());
			foreach (ows.DomainType o in m_ParameterCol)
				newObject.m_ParameterCol.Add((ows.DomainType)o.Clone());
			foreach (ows.DomainType o in m_ConstraintCol)
				newObject.m_ConstraintCol.Add((ows.DomainType)o.Clone());
			newObject.m_ExtendedCapabilities = null;
			if (m_ExtendedCapabilities != null)
				newObject.m_ExtendedCapabilities = (LiquidTechnologies.Runtime.Net45.Element)m_ExtendedCapabilities.Clone();


// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			return newObject;
		}
		#endregion

		#region Member variables

		protected override String TargetNamespace
		{
			get { return "http://www.opengis.net/ows"; }
		}

		#region Attribute - Operation
		/// <summary>
		/// 	A collection of OperationCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 2 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("Operation", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<ows.Operation> OperationCol
		{
			get { return m_OperationCol; }
		}
		protected CSW.XmlObjectCollection<ows.Operation> m_OperationCol;
		
		#endregion

		#region Attribute - Parameter
		/// <summary>
		/// 	A collection of ParameterCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("Parameter", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<ows.DomainType> ParameterCol
		{
			get { return m_ParameterCol; }
		}
		protected CSW.XmlObjectCollection<ows.DomainType> m_ParameterCol;
		
		#endregion

		#region Attribute - Constraint
		/// <summary>
		/// 	A collection of ConstraintCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("Constraint", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<ows.DomainType> ConstraintCol
		{
			get { return m_ConstraintCol; }
		}
		protected CSW.XmlObjectCollection<ows.DomainType> m_ConstraintCol;
		
		#endregion

		#region Attribute - ExtendedCapabilities
		/// <summary>
		///		Represents an optional untyped element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqUntpdOpt("ExtendedCapabilities", "http://www.opengis.net/ows", "##any", "http://www.opengis.net/cat/csw/2.0.2")]
		public LiquidTechnologies.Runtime.Net45.Element ExtendedCapabilities
		{
			get
			{
				return m_ExtendedCapabilities;  
			}
			set
			{
				if (value != null)
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "http://www.opengis.net/cat/csw/2.0.2");
				m_ExtendedCapabilities = value; 
			}
		}
		protected LiquidTechnologies.Runtime.Net45.Element m_ExtendedCapabilities;
		#endregion

		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://www.opengis.net/ows"; }
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


