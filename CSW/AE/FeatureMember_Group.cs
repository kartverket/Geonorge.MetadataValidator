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
	/// 	This class represents the Element featureMember_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"featureMember_Group", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class FeatureMember_Group : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for FeatureMember_Group
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public FeatureMember_Group()
		{
			_elementName = "featureMember_Group";
			Init();
		}
		public FeatureMember_Group(String elementName)
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
			m__Feature = null;
			m_SubGrpObservation = null;
			m__FeatureCollection = null;
			m__FeatureCollectionA = null;
			m_FeatureCollection = null;
			m__Coverage = null;
			m_SubGrp_Coverage = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__Feature = null;
			m_SubGrpObservation = null;
			m__FeatureCollection = null;
			m__FeatureCollectionA = null;
			m_FeatureCollection = null;
			m__Coverage = null;
			m_SubGrp_Coverage = null;
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
			AE.FeatureMember_Group newObject = new AE.FeatureMember_Group(_elementName);
			newObject.m__Feature = null;
			if (m__Feature != null)
				newObject.m__Feature = (AE.IAbstractFeatureType)m__Feature.Clone();
			newObject.m_SubGrpObservation = null;
			if (m_SubGrpObservation != null)
				newObject.m_SubGrpObservation = (AE.SubGrpObservation)m_SubGrpObservation.Clone();
			newObject.m__FeatureCollection = null;
			if (m__FeatureCollection != null)
				newObject.m__FeatureCollection = (AE.IAbstractFeatureCollectionType)m__FeatureCollection.Clone();
			newObject.m__FeatureCollectionA = null;
			if (m__FeatureCollectionA != null)
				newObject.m__FeatureCollectionA = (AE.IAbstractFeatureCollectionType)m__FeatureCollectionA.Clone();
			newObject.m_FeatureCollection = null;
			if (m_FeatureCollection != null)
				newObject.m_FeatureCollection = (AE.IFeatureCollectionType)m_FeatureCollection.Clone();
			newObject.m__Coverage = null;
			if (m__Coverage != null)
				newObject.m__Coverage = (AE.IAbstractCoverageType)m__Coverage.Clone();
			newObject.m_SubGrp_Coverage = null;
			if (m_SubGrp_Coverage != null)
				newObject.m_SubGrp_Coverage = (AE.SubGrp_Coverage)m_SubGrp_Coverage.Clone();

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

		#region Attribute - _Feature
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

		#region Attribute - SubGrpObservation
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Feature
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrpObservation", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrpObservation))]
		public AE.SubGrpObservation SubGrpObservation
		{
			get 
			{ 
				return m_SubGrpObservation;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrpObservation"); // remove selection
				if (value == null)
					m_SubGrpObservation = null;
				else
				{
					m_SubGrpObservation = value; 
				}
			}
		}
		protected AE.SubGrpObservation m_SubGrpObservation;
		
		#endregion

		#region Attribute - _FeatureCollection
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Feature
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_FeatureCollection", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractFeatureCollectionTypeCreateObject")]
		public AE.IAbstractFeatureCollectionType _FeatureCollection
		{
			get 
			{ 
				return m__FeatureCollection;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_FeatureCollection"); // remove selection
				if (value == null)
					m__FeatureCollection = null;
				else
				{
					m__FeatureCollection = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_FeatureCollection");
				}
			}
		}
		protected AE.IAbstractFeatureCollectionType m__FeatureCollection;

		#endregion

		#region Attribute - _FeatureCollection
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Feature
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_FeatureCollection", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractFeatureCollectionTypeCreateObject")]
		public AE.IAbstractFeatureCollectionType _FeatureCollectionA
		{
			get 
			{ 
				return m__FeatureCollectionA;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_FeatureCollectionA"); // remove selection
				if (value == null)
					m__FeatureCollectionA = null;
				else
				{
					m__FeatureCollectionA = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_FeatureCollection");
				}
			}
		}
		protected AE.IAbstractFeatureCollectionType m__FeatureCollectionA;

		#endregion

		#region Attribute - FeatureCollection
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Feature
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("FeatureCollection", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IFeatureCollectionTypeCreateObject")]
		public AE.IFeatureCollectionType FeatureCollection
		{
			get 
			{ 
				return m_FeatureCollection;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"FeatureCollection"); // remove selection
				if (value == null)
					m_FeatureCollection = null;
				else
				{
					m_FeatureCollection = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "FeatureCollection");
				}
			}
		}
		protected AE.IFeatureCollectionType m_FeatureCollection;

		#endregion

		#region Attribute - _Coverage
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Feature
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_Coverage", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractCoverageTypeCreateObject")]
		public AE.IAbstractCoverageType _Coverage
		{
			get 
			{ 
				return m__Coverage;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_Coverage"); // remove selection
				if (value == null)
					m__Coverage = null;
				else
				{
					m__Coverage = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_Coverage");
				}
			}
		}
		protected AE.IAbstractCoverageType m__Coverage;

		#endregion

		#region Attribute - SubGrp_Coverage
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Feature
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_Coverage", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_Coverage))]
		public AE.SubGrp_Coverage SubGrp_Coverage
		{
			get 
			{ 
				return m_SubGrp_Coverage;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_Coverage"); // remove selection
				if (value == null)
					m_SubGrp_Coverage = null;
				else
				{
					m_SubGrp_Coverage = value; 
				}
			}
		}
		protected AE.SubGrp_Coverage m_SubGrp_Coverage;
		
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


