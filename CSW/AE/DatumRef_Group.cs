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
	/// 	This class represents the Element datumRef_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"datumRef_Group", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class DatumRef_Group : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for DatumRef_Group
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public DatumRef_Group()
		{
			_elementName = "datumRef_Group";
			Init();
		}
		public DatumRef_Group(String elementName)
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
			m__Datum = null;
			m_TemporalDatum = null;
			m_EngineeringDatum = null;
			m_VerticalDatum = null;
			m_GeodeticDatum = null;
			m_ImageDatum = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__Datum = null;
			m_TemporalDatum = null;
			m_EngineeringDatum = null;
			m_VerticalDatum = null;
			m_GeodeticDatum = null;
			m_ImageDatum = null;
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
			AE.DatumRef_Group newObject = new AE.DatumRef_Group(_elementName);
			newObject.m__Datum = null;
			if (m__Datum != null)
				newObject.m__Datum = (AE.IAbstractDatumType)m__Datum.Clone();
			newObject.m_TemporalDatum = null;
			if (m_TemporalDatum != null)
				newObject.m_TemporalDatum = (AE.TemporalDatum)m_TemporalDatum.Clone();
			newObject.m_EngineeringDatum = null;
			if (m_EngineeringDatum != null)
				newObject.m_EngineeringDatum = (AE.EngineeringDatum)m_EngineeringDatum.Clone();
			newObject.m_VerticalDatum = null;
			if (m_VerticalDatum != null)
				newObject.m_VerticalDatum = (AE.VerticalDatum)m_VerticalDatum.Clone();
			newObject.m_GeodeticDatum = null;
			if (m_GeodeticDatum != null)
				newObject.m_GeodeticDatum = (AE.GeodeticDatum)m_GeodeticDatum.Clone();
			newObject.m_ImageDatum = null;
			if (m_ImageDatum != null)
				newObject.m_ImageDatum = (AE.ImageDatum)m_ImageDatum.Clone();

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

		#region Attribute - _Datum
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_Datum", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractDatumTypeCreateObject")]
		public AE.IAbstractDatumType _Datum
		{
			get 
			{ 
				return m__Datum;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_Datum"); // remove selection
				if (value == null)
					m__Datum = null;
				else
				{
					m__Datum = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_Datum");
				}
			}
		}
		protected AE.IAbstractDatumType m__Datum;

		#endregion

		#region Attribute - TemporalDatum
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Datum
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("TemporalDatum", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.TemporalDatum))]
		public AE.TemporalDatum TemporalDatum
		{
			get 
			{ 
				return m_TemporalDatum;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"TemporalDatum"); // remove selection
				if (value == null)
					m_TemporalDatum = null;
				else
				{
					m_TemporalDatum = value; 
				}
			}
		}
		protected AE.TemporalDatum m_TemporalDatum;
		
		#endregion

		#region Attribute - EngineeringDatum
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Datum
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("EngineeringDatum", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.EngineeringDatum))]
		public AE.EngineeringDatum EngineeringDatum
		{
			get 
			{ 
				return m_EngineeringDatum;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"EngineeringDatum"); // remove selection
				if (value == null)
					m_EngineeringDatum = null;
				else
				{
					m_EngineeringDatum = value; 
				}
			}
		}
		protected AE.EngineeringDatum m_EngineeringDatum;
		
		#endregion

		#region Attribute - VerticalDatum
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Datum
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("VerticalDatum", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.VerticalDatum))]
		public AE.VerticalDatum VerticalDatum
		{
			get 
			{ 
				return m_VerticalDatum;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"VerticalDatum"); // remove selection
				if (value == null)
					m_VerticalDatum = null;
				else
				{
					m_VerticalDatum = value; 
				}
			}
		}
		protected AE.VerticalDatum m_VerticalDatum;
		
		#endregion

		#region Attribute - GeodeticDatum
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Datum
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("GeodeticDatum", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.GeodeticDatum))]
		public AE.GeodeticDatum GeodeticDatum
		{
			get 
			{ 
				return m_GeodeticDatum;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"GeodeticDatum"); // remove selection
				if (value == null)
					m_GeodeticDatum = null;
				else
				{
					m_GeodeticDatum = value; 
				}
			}
		}
		protected AE.GeodeticDatum m_GeodeticDatum;
		
		#endregion

		#region Attribute - ImageDatum
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Datum
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("ImageDatum", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ImageDatum))]
		public AE.ImageDatum ImageDatum
		{
			get 
			{ 
				return m_ImageDatum;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"ImageDatum"); // remove selection
				if (value == null)
					m_ImageDatum = null;
				else
				{
					m_ImageDatum = value; 
				}
			}
		}
		protected AE.ImageDatum m_ImageDatum;
		
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


