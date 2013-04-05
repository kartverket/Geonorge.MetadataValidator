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

namespace AE
{
	/// <summary>
	/// 	This class represents the Element SubGrp_GML
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrp_GML", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrp_GML : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrp_GML
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrp_GML()
		{
			_elementName = "SubGrp_GML";
			Init();
		}
		public SubGrp_GML(String elementName)
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
			m__GML = null;
			m_Bag = null;
			m__Geometry = null;
			m_SubGrp_Geometry = null;
			m_Array = null;
			m__Topology = null;
			m_SubGrp_Topology = null;
			m_SubGrpDefinition = null;
			m__TimeObject = null;
			m_SubGrp_TimeObject = null;
			m__Style = null;
			m_SubGrp_Style = null;
			m_TopologyStyle = null;
			m__TimeSlice = null;
			m_SubGrp_TimeSlice = null;
			m__Feature = null;
			m_SubGrp_Feature = null;
			m_FeatureStyle = null;
			m_GraphStyle = null;
			m_GeometryStyle = null;
			m_LabelStyle = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__GML = null;
			m_Bag = null;
			m__Geometry = null;
			m_SubGrp_Geometry = null;
			m_Array = null;
			m__Topology = null;
			m_SubGrp_Topology = null;
			m_SubGrpDefinition = null;
			m__TimeObject = null;
			m_SubGrp_TimeObject = null;
			m__Style = null;
			m_SubGrp_Style = null;
			m_TopologyStyle = null;
			m__TimeSlice = null;
			m_SubGrp_TimeSlice = null;
			m__Feature = null;
			m_SubGrp_Feature = null;
			m_FeatureStyle = null;
			m_GraphStyle = null;
			m_GeometryStyle = null;
			m_LabelStyle = null;
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
			AE.SubGrp_GML newObject = new AE.SubGrp_GML(_elementName);
			newObject.m__GML = null;
			if (m__GML != null)
				newObject.m__GML = (AE.IAbstractGMLType)m__GML.Clone();
			newObject.m_Bag = null;
			if (m_Bag != null)
				newObject.m_Bag = (AE.Bag)m_Bag.Clone();
			newObject.m__Geometry = null;
			if (m__Geometry != null)
				newObject.m__Geometry = (AE.IAbstractGeometryType)m__Geometry.Clone();
			newObject.m_SubGrp_Geometry = null;
			if (m_SubGrp_Geometry != null)
				newObject.m_SubGrp_Geometry = (AE.SubGrp_Geometry)m_SubGrp_Geometry.Clone();
			newObject.m_Array = null;
			if (m_Array != null)
				newObject.m_Array = (AE.Array)m_Array.Clone();
			newObject.m__Topology = null;
			if (m__Topology != null)
				newObject.m__Topology = (AE.IAbstractTopologyType)m__Topology.Clone();
			newObject.m_SubGrp_Topology = null;
			if (m_SubGrp_Topology != null)
				newObject.m_SubGrp_Topology = (AE.SubGrp_Topology)m_SubGrp_Topology.Clone();
			newObject.m_SubGrpDefinition = null;
			if (m_SubGrpDefinition != null)
				newObject.m_SubGrpDefinition = (AE.SubGrpDefinition)m_SubGrpDefinition.Clone();
			newObject.m__TimeObject = null;
			if (m__TimeObject != null)
				newObject.m__TimeObject = (AE.IAbstractTimeObjectType)m__TimeObject.Clone();
			newObject.m_SubGrp_TimeObject = null;
			if (m_SubGrp_TimeObject != null)
				newObject.m_SubGrp_TimeObject = (AE.SubGrp_TimeObject)m_SubGrp_TimeObject.Clone();
			newObject.m__Style = null;
			if (m__Style != null)
				newObject.m__Style = (AE.IAbstractStyleType)m__Style.Clone();
			newObject.m_SubGrp_Style = null;
			if (m_SubGrp_Style != null)
				newObject.m_SubGrp_Style = (AE.SubGrp_Style)m_SubGrp_Style.Clone();
			newObject.m_TopologyStyle = null;
			if (m_TopologyStyle != null)
				newObject.m_TopologyStyle = (AE.TopologyStyleA)m_TopologyStyle.Clone();
			newObject.m__TimeSlice = null;
			if (m__TimeSlice != null)
				newObject.m__TimeSlice = (AE.IAbstractTimeSliceType)m__TimeSlice.Clone();
			newObject.m_SubGrp_TimeSlice = null;
			if (m_SubGrp_TimeSlice != null)
				newObject.m_SubGrp_TimeSlice = (AE.SubGrp_TimeSlice)m_SubGrp_TimeSlice.Clone();
			newObject.m__Feature = null;
			if (m__Feature != null)
				newObject.m__Feature = (AE.IAbstractFeatureType)m__Feature.Clone();
			newObject.m_SubGrp_Feature = null;
			if (m_SubGrp_Feature != null)
				newObject.m_SubGrp_Feature = (AE.SubGrp_Feature)m_SubGrp_Feature.Clone();
			newObject.m_FeatureStyle = null;
			if (m_FeatureStyle != null)
				newObject.m_FeatureStyle = (AE.FeatureStyleA)m_FeatureStyle.Clone();
			newObject.m_GraphStyle = null;
			if (m_GraphStyle != null)
				newObject.m_GraphStyle = (AE.GraphStyleA)m_GraphStyle.Clone();
			newObject.m_GeometryStyle = null;
			if (m_GeometryStyle != null)
				newObject.m_GeometryStyle = (AE.GeometryStyleA)m_GeometryStyle.Clone();
			newObject.m_LabelStyle = null;
			if (m_LabelStyle != null)
				newObject.m_LabelStyle = (AE.LabelStyleA)m_LabelStyle.Clone();

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
			get { return "http://www.opengis.net/gml"; }
		}

		#region Attribute - _GML
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_GML", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractGMLTypeCreateObject")]
		public AE.IAbstractGMLType _GML
		{
			get 
			{ 
				return m__GML;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_GML"); // remove selection
				if (value == null)
					m__GML = null;
				else
				{
					m__GML = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_GML");
				}
			}
		}
		protected AE.IAbstractGMLType m__GML;

		#endregion

		#region Attribute - Bag
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Bag", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.Bag))]
		public AE.Bag Bag
		{
			get 
			{ 
				return m_Bag;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Bag"); // remove selection
				if (value == null)
					m_Bag = null;
				else
				{
					m_Bag = value; 
				}
			}
		}
		protected AE.Bag m_Bag;
		
		#endregion

		#region Attribute - _Geometry
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_Geometry", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractGeometryTypeCreateObject")]
		public AE.IAbstractGeometryType _Geometry
		{
			get 
			{ 
				return m__Geometry;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_Geometry"); // remove selection
				if (value == null)
					m__Geometry = null;
				else
				{
					m__Geometry = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_Geometry");
				}
			}
		}
		protected AE.IAbstractGeometryType m__Geometry;

		#endregion

		#region Attribute - SubGrp_Geometry
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_Geometry", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_Geometry))]
		public AE.SubGrp_Geometry SubGrp_Geometry
		{
			get 
			{ 
				return m_SubGrp_Geometry;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_Geometry"); // remove selection
				if (value == null)
					m_SubGrp_Geometry = null;
				else
				{
					m_SubGrp_Geometry = value; 
				}
			}
		}
		protected AE.SubGrp_Geometry m_SubGrp_Geometry;
		
		#endregion

		#region Attribute - Array
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Array", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.Array))]
		public AE.Array Array
		{
			get 
			{ 
				return m_Array;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Array"); // remove selection
				if (value == null)
					m_Array = null;
				else
				{
					m_Array = value; 
				}
			}
		}
		protected AE.Array m_Array;
		
		#endregion

		#region Attribute - _Topology
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_Topology", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractTopologyTypeCreateObject")]
		public AE.IAbstractTopologyType _Topology
		{
			get 
			{ 
				return m__Topology;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_Topology"); // remove selection
				if (value == null)
					m__Topology = null;
				else
				{
					m__Topology = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_Topology");
				}
			}
		}
		protected AE.IAbstractTopologyType m__Topology;

		#endregion

		#region Attribute - SubGrp_Topology
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_Topology", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_Topology))]
		public AE.SubGrp_Topology SubGrp_Topology
		{
			get 
			{ 
				return m_SubGrp_Topology;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_Topology"); // remove selection
				if (value == null)
					m_SubGrp_Topology = null;
				else
				{
					m_SubGrp_Topology = value; 
				}
			}
		}
		protected AE.SubGrp_Topology m_SubGrp_Topology;
		
		#endregion

		#region Attribute - SubGrpDefinition
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrpDefinition", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrpDefinition))]
		public AE.SubGrpDefinition SubGrpDefinition
		{
			get 
			{ 
				return m_SubGrpDefinition;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrpDefinition"); // remove selection
				if (value == null)
					m_SubGrpDefinition = null;
				else
				{
					m_SubGrpDefinition = value; 
				}
			}
		}
		protected AE.SubGrpDefinition m_SubGrpDefinition;
		
		#endregion

		#region Attribute - _TimeObject
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_TimeObject", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractTimeObjectTypeCreateObject")]
		public AE.IAbstractTimeObjectType _TimeObject
		{
			get 
			{ 
				return m__TimeObject;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_TimeObject"); // remove selection
				if (value == null)
					m__TimeObject = null;
				else
				{
					m__TimeObject = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_TimeObject");
				}
			}
		}
		protected AE.IAbstractTimeObjectType m__TimeObject;

		#endregion

		#region Attribute - SubGrp_TimeObject
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_TimeObject", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_TimeObject))]
		public AE.SubGrp_TimeObject SubGrp_TimeObject
		{
			get 
			{ 
				return m_SubGrp_TimeObject;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_TimeObject"); // remove selection
				if (value == null)
					m_SubGrp_TimeObject = null;
				else
				{
					m_SubGrp_TimeObject = value; 
				}
			}
		}
		protected AE.SubGrp_TimeObject m_SubGrp_TimeObject;
		
		#endregion

		#region Attribute - _Style
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_Style", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractStyleTypeCreateObject")]
		public AE.IAbstractStyleType _Style
		{
			get 
			{ 
				return m__Style;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_Style"); // remove selection
				if (value == null)
					m__Style = null;
				else
				{
					m__Style = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_Style");
				}
			}
		}
		protected AE.IAbstractStyleType m__Style;

		#endregion

		#region Attribute - SubGrp_Style
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_Style", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_Style))]
		public AE.SubGrp_Style SubGrp_Style
		{
			get 
			{ 
				return m_SubGrp_Style;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_Style"); // remove selection
				if (value == null)
					m_SubGrp_Style = null;
				else
				{
					m_SubGrp_Style = value; 
				}
			}
		}
		protected AE.SubGrp_Style m_SubGrp_Style;
		
		#endregion

		#region Attribute - TopologyStyle
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("TopologyStyle", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.TopologyStyleA))]
		public AE.TopologyStyleA TopologyStyle
		{
			get 
			{ 
				return m_TopologyStyle;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"TopologyStyle"); // remove selection
				if (value == null)
					m_TopologyStyle = null;
				else
				{
					m_TopologyStyle = value; 
				}
			}
		}
		protected AE.TopologyStyleA m_TopologyStyle;
		
		#endregion

		#region Attribute - _TimeSlice
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_TimeSlice", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractTimeSliceTypeCreateObject")]
		public AE.IAbstractTimeSliceType _TimeSlice
		{
			get 
			{ 
				return m__TimeSlice;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_TimeSlice"); // remove selection
				if (value == null)
					m__TimeSlice = null;
				else
				{
					m__TimeSlice = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_TimeSlice");
				}
			}
		}
		protected AE.IAbstractTimeSliceType m__TimeSlice;

		#endregion

		#region Attribute - SubGrp_TimeSlice
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_TimeSlice", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_TimeSlice))]
		public AE.SubGrp_TimeSlice SubGrp_TimeSlice
		{
			get 
			{ 
				return m_SubGrp_TimeSlice;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_TimeSlice"); // remove selection
				if (value == null)
					m_SubGrp_TimeSlice = null;
				else
				{
					m_SubGrp_TimeSlice = value; 
				}
			}
		}
		protected AE.SubGrp_TimeSlice m_SubGrp_TimeSlice;
		
		#endregion

		#region Attribute - _Feature
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_Feature", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractFeatureTypeCreateObject")]
		public AE.IAbstractFeatureType _Feature
		{
			get 
			{ 
				return m__Feature;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_Feature"); // remove selection
				if (value == null)
					m__Feature = null;
				else
				{
					m__Feature = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_Feature");
				}
			}
		}
		protected AE.IAbstractFeatureType m__Feature;

		#endregion

		#region Attribute - SubGrp_Feature
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_Feature", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_Feature))]
		public AE.SubGrp_Feature SubGrp_Feature
		{
			get 
			{ 
				return m_SubGrp_Feature;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_Feature"); // remove selection
				if (value == null)
					m_SubGrp_Feature = null;
				else
				{
					m_SubGrp_Feature = value; 
				}
			}
		}
		protected AE.SubGrp_Feature m_SubGrp_Feature;
		
		#endregion

		#region Attribute - FeatureStyle
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("FeatureStyle", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.FeatureStyleA))]
		public AE.FeatureStyleA FeatureStyle
		{
			get 
			{ 
				return m_FeatureStyle;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"FeatureStyle"); // remove selection
				if (value == null)
					m_FeatureStyle = null;
				else
				{
					m_FeatureStyle = value; 
				}
			}
		}
		protected AE.FeatureStyleA m_FeatureStyle;
		
		#endregion

		#region Attribute - GraphStyle
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("GraphStyle", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.GraphStyleA))]
		public AE.GraphStyleA GraphStyle
		{
			get 
			{ 
				return m_GraphStyle;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"GraphStyle"); // remove selection
				if (value == null)
					m_GraphStyle = null;
				else
				{
					m_GraphStyle = value; 
				}
			}
		}
		protected AE.GraphStyleA m_GraphStyle;
		
		#endregion

		#region Attribute - GeometryStyle
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("GeometryStyle", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.GeometryStyleA))]
		public AE.GeometryStyleA GeometryStyle
		{
			get 
			{ 
				return m_GeometryStyle;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"GeometryStyle"); // remove selection
				if (value == null)
					m_GeometryStyle = null;
				else
				{
					m_GeometryStyle = value; 
				}
			}
		}
		protected AE.GeometryStyleA m_GeometryStyle;
		
		#endregion

		#region Attribute - LabelStyle
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GML
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("LabelStyle", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.LabelStyleA))]
		public AE.LabelStyleA LabelStyle
		{
			get 
			{ 
				return m_LabelStyle;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"LabelStyle"); // remove selection
				if (value == null)
					m_LabelStyle = null;
				else
				{
					m_LabelStyle = value; 
				}
			}
		}
		protected AE.LabelStyleA m_LabelStyle;
		
		#endregion

		public String ChoiceSelectedElement
		{
			get { return _validElement;  }
		}
		protected String _validElement;
		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://www.opengis.net/gml"; }
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


