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
	/// 	This class represents the Element BinaryLogicOpType_Type_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"BinaryLogicOpType_Type_Group", "http://www.opengis.net/ogc", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class BinaryLogicOpType_Type_Group : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for BinaryLogicOpType_Type_Group
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public BinaryLogicOpType_Type_Group()
		{
			_elementName = "BinaryLogicOpType_Type_Group";
			Init();
		}
		public BinaryLogicOpType_Type_Group(String elementName)
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
			m_SpatialOps = null;
			m_LogicOps = null;
			m_Function = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_ComparisonOps = null;
			m_SpatialOps = null;
			m_LogicOps = null;
			m_Function = null;
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
			ogc.BinaryLogicOpType_Type_Group newObject = new ogc.BinaryLogicOpType_Type_Group(_elementName);
			newObject.m_ComparisonOps = null;
			if (m_ComparisonOps != null)
				newObject.m_ComparisonOps = (ogc.SubGrpcomparisonOps)m_ComparisonOps.Clone();
			newObject.m_SpatialOps = null;
			if (m_SpatialOps != null)
				newObject.m_SpatialOps = (ogc.SubGrpspatialOps)m_SpatialOps.Clone();
			newObject.m_LogicOps = null;
			if (m_LogicOps != null)
				newObject.m_LogicOps = (ogc.SubGrplogicOps)m_LogicOps.Clone();
			newObject.m_Function = null;
			if (m_Function != null)
				newObject.m_Function = (ogc.Function)m_Function.Clone();

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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("comparisonOps", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(ogc.SubGrpcomparisonOps))]
		public ogc.SubGrpcomparisonOps ComparisonOps
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
				}
			}
		}
		protected ogc.SubGrpcomparisonOps m_ComparisonOps;
		
		#endregion

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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("spatialOps", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(ogc.SubGrpspatialOps))]
		public ogc.SubGrpspatialOps SpatialOps
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
				}
			}
		}
		protected ogc.SubGrpspatialOps m_SpatialOps;
		
		#endregion

		#region Attribute - logicOps
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("logicOps", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(ogc.SubGrplogicOps))]
		public ogc.SubGrplogicOps LogicOps
		{
			get 
			{ 
				return m_LogicOps;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"logicOps"); // remove selection
				if (value == null)
					m_LogicOps = null;
				else
				{
					m_LogicOps = value; 
				}
			}
		}
		protected ogc.SubGrplogicOps m_LogicOps;
		
		#endregion

		#region Attribute - Function
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Function", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Function))]
		public ogc.Function Function
		{
			get 
			{ 
				return m_Function;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Function"); // remove selection
				if (value == null)
					m_Function = null;
				else
				{
					m_Function = value; 
				}
			}
		}
		protected ogc.Function m_Function;
		
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


