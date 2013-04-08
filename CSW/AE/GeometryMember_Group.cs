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
	/// 	This class represents the Element geometryMember_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"geometryMember_Group", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class GeometryMember_Group : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for GeometryMember_Group
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public GeometryMember_Group()
		{
			_elementName = "geometryMember_Group";
			Init();
		}
		public GeometryMember_Group(String elementName)
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
			m__Geometry = null;
			m__GeometricPrimitive = null;
			m_SubGrp_GeometricPrimitive = null;
			m__ImplicitGeometry = null;
			m_SubGrp_ImplicitGeometry = null;
			m_GeometricComplex = null;
			m__Ring = null;
			m_SubGrp_Ring = null;
			m__GeometricAggregate = null;
			m_SubGrp_GeometricAggregate = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__Geometry = null;
			m__GeometricPrimitive = null;
			m_SubGrp_GeometricPrimitive = null;
			m__ImplicitGeometry = null;
			m_SubGrp_ImplicitGeometry = null;
			m_GeometricComplex = null;
			m__Ring = null;
			m_SubGrp_Ring = null;
			m__GeometricAggregate = null;
			m_SubGrp_GeometricAggregate = null;
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
			AE.GeometryMember_Group newObject = new AE.GeometryMember_Group(_elementName);
			newObject.m__Geometry = null;
			if (m__Geometry != null)
				newObject.m__Geometry = (AE.IAbstractGeometryType)m__Geometry.Clone();
			newObject.m__GeometricPrimitive = null;
			if (m__GeometricPrimitive != null)
				newObject.m__GeometricPrimitive = (AE.IAbstractGeometricPrimitiveType)m__GeometricPrimitive.Clone();
			newObject.m_SubGrp_GeometricPrimitive = null;
			if (m_SubGrp_GeometricPrimitive != null)
				newObject.m_SubGrp_GeometricPrimitive = (AE.SubGrp_GeometricPrimitive)m_SubGrp_GeometricPrimitive.Clone();
			newObject.m__ImplicitGeometry = null;
			if (m__ImplicitGeometry != null)
				newObject.m__ImplicitGeometry = (AE.IAbstractGeometryType)m__ImplicitGeometry.Clone();
			newObject.m_SubGrp_ImplicitGeometry = null;
			if (m_SubGrp_ImplicitGeometry != null)
				newObject.m_SubGrp_ImplicitGeometry = (AE.SubGrp_ImplicitGeometry)m_SubGrp_ImplicitGeometry.Clone();
			newObject.m_GeometricComplex = null;
			if (m_GeometricComplex != null)
				newObject.m_GeometricComplex = (AE.GeometricComplex)m_GeometricComplex.Clone();
			newObject.m__Ring = null;
			if (m__Ring != null)
				newObject.m__Ring = (AE.IAbstractRingType)m__Ring.Clone();
			newObject.m_SubGrp_Ring = null;
			if (m_SubGrp_Ring != null)
				newObject.m_SubGrp_Ring = (AE.SubGrp_Ring)m_SubGrp_Ring.Clone();
			newObject.m__GeometricAggregate = null;
			if (m__GeometricAggregate != null)
				newObject.m__GeometricAggregate = (AE.IAbstractGeometricAggregateType)m__GeometricAggregate.Clone();
			newObject.m_SubGrp_GeometricAggregate = null;
			if (m_SubGrp_GeometricAggregate != null)
				newObject.m_SubGrp_GeometricAggregate = (AE.SubGrp_GeometricAggregate)m_SubGrp_GeometricAggregate.Clone();

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

		#region Attribute - _Geometry
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

		#region Attribute - _GeometricPrimitive
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Geometry
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_GeometricPrimitive", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractGeometricPrimitiveTypeCreateObject")]
		public AE.IAbstractGeometricPrimitiveType _GeometricPrimitive
		{
			get 
			{ 
				return m__GeometricPrimitive;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_GeometricPrimitive"); // remove selection
				if (value == null)
					m__GeometricPrimitive = null;
				else
				{
					m__GeometricPrimitive = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_GeometricPrimitive");
				}
			}
		}
		protected AE.IAbstractGeometricPrimitiveType m__GeometricPrimitive;

		#endregion

		#region Attribute - SubGrp_GeometricPrimitive
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Geometry
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_GeometricPrimitive", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_GeometricPrimitive))]
		public AE.SubGrp_GeometricPrimitive SubGrp_GeometricPrimitive
		{
			get 
			{ 
				return m_SubGrp_GeometricPrimitive;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_GeometricPrimitive"); // remove selection
				if (value == null)
					m_SubGrp_GeometricPrimitive = null;
				else
				{
					m_SubGrp_GeometricPrimitive = value; 
				}
			}
		}
		protected AE.SubGrp_GeometricPrimitive m_SubGrp_GeometricPrimitive;
		
		#endregion

		#region Attribute - _ImplicitGeometry
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Geometry
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_ImplicitGeometry", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractGeometryTypeCreateObject")]
		public AE.IAbstractGeometryType _ImplicitGeometry
		{
			get 
			{ 
				return m__ImplicitGeometry;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_ImplicitGeometry"); // remove selection
				if (value == null)
					m__ImplicitGeometry = null;
				else
				{
					m__ImplicitGeometry = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_ImplicitGeometry");
				}
			}
		}
		protected AE.IAbstractGeometryType m__ImplicitGeometry;

		#endregion

		#region Attribute - SubGrp_ImplicitGeometry
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Geometry
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_ImplicitGeometry", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_ImplicitGeometry))]
		public AE.SubGrp_ImplicitGeometry SubGrp_ImplicitGeometry
		{
			get 
			{ 
				return m_SubGrp_ImplicitGeometry;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_ImplicitGeometry"); // remove selection
				if (value == null)
					m_SubGrp_ImplicitGeometry = null;
				else
				{
					m_SubGrp_ImplicitGeometry = value; 
				}
			}
		}
		protected AE.SubGrp_ImplicitGeometry m_SubGrp_ImplicitGeometry;
		
		#endregion

		#region Attribute - GeometricComplex
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Geometry
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("GeometricComplex", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.GeometricComplex))]
		public AE.GeometricComplex GeometricComplex
		{
			get 
			{ 
				return m_GeometricComplex;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"GeometricComplex"); // remove selection
				if (value == null)
					m_GeometricComplex = null;
				else
				{
					m_GeometricComplex = value; 
				}
			}
		}
		protected AE.GeometricComplex m_GeometricComplex;
		
		#endregion

		#region Attribute - _Ring
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Geometry
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_Ring", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractRingTypeCreateObject")]
		public AE.IAbstractRingType _Ring
		{
			get 
			{ 
				return m__Ring;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_Ring"); // remove selection
				if (value == null)
					m__Ring = null;
				else
				{
					m__Ring = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_Ring");
				}
			}
		}
		protected AE.IAbstractRingType m__Ring;

		#endregion

		#region Attribute - SubGrp_Ring
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Geometry
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_Ring", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_Ring))]
		public AE.SubGrp_Ring SubGrp_Ring
		{
			get 
			{ 
				return m_SubGrp_Ring;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_Ring"); // remove selection
				if (value == null)
					m_SubGrp_Ring = null;
				else
				{
					m_SubGrp_Ring = value; 
				}
			}
		}
		protected AE.SubGrp_Ring m_SubGrp_Ring;
		
		#endregion

		#region Attribute - _GeometricAggregate
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Geometry
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_GeometricAggregate", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractGeometricAggregateTypeCreateObject")]
		public AE.IAbstractGeometricAggregateType _GeometricAggregate
		{
			get 
			{ 
				return m__GeometricAggregate;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_GeometricAggregate"); // remove selection
				if (value == null)
					m__GeometricAggregate = null;
				else
				{
					m__GeometricAggregate = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_GeometricAggregate");
				}
			}
		}
		protected AE.IAbstractGeometricAggregateType m__GeometricAggregate;

		#endregion

		#region Attribute - SubGrp_GeometricAggregate
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Geometry
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_GeometricAggregate", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_GeometricAggregate))]
		public AE.SubGrp_GeometricAggregate SubGrp_GeometricAggregate
		{
			get 
			{ 
				return m_SubGrp_GeometricAggregate;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_GeometricAggregate"); // remove selection
				if (value == null)
					m_SubGrp_GeometricAggregate = null;
				else
				{
					m_SubGrp_GeometricAggregate = value; 
				}
			}
		}
		protected AE.SubGrp_GeometricAggregate m_SubGrp_GeometricAggregate;
		
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


