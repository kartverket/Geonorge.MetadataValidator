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
	/// 	This class represents the Element SubGrpArcByCenterPoint
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrpArcByCenterPoint", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrpArcByCenterPoint : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrpArcByCenterPoint
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrpArcByCenterPoint()
		{
			_elementName = "SubGrpArcByCenterPoint";
			Init();
		}
		public SubGrpArcByCenterPoint(String elementName)
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
			m_ArcByCenterPoint = null;
			m_CircleByCenterPoint = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_ArcByCenterPoint = null;
			m_CircleByCenterPoint = null;
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
			AE.SubGrpArcByCenterPoint newObject = new AE.SubGrpArcByCenterPoint(_elementName);
			newObject.m_ArcByCenterPoint = null;
			if (m_ArcByCenterPoint != null)
				newObject.m_ArcByCenterPoint = (AE.IArcByCenterPointType)m_ArcByCenterPoint.Clone();
			newObject.m_CircleByCenterPoint = null;
			if (m_CircleByCenterPoint != null)
				newObject.m_CircleByCenterPoint = (AE.CircleByCenterPoint)m_CircleByCenterPoint.Clone();

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

		#region Attribute - ArcByCenterPoint
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("ArcByCenterPoint", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IArcByCenterPointTypeCreateObject")]
		public AE.IArcByCenterPointType ArcByCenterPoint
		{
			get 
			{ 
				return m_ArcByCenterPoint;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"ArcByCenterPoint"); // remove selection
				if (value == null)
					m_ArcByCenterPoint = null;
				else
				{
					m_ArcByCenterPoint = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "ArcByCenterPoint");
				}
			}
		}
		protected AE.IArcByCenterPointType m_ArcByCenterPoint;

		#endregion

		#region Attribute - CircleByCenterPoint
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for ArcByCenterPoint
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("CircleByCenterPoint", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.CircleByCenterPoint))]
		public AE.CircleByCenterPoint CircleByCenterPoint
		{
			get 
			{ 
				return m_CircleByCenterPoint;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"CircleByCenterPoint"); // remove selection
				if (value == null)
					m_CircleByCenterPoint = null;
				else
				{
					m_CircleByCenterPoint = value; 
				}
			}
		}
		protected AE.CircleByCenterPoint m_CircleByCenterPoint;
		
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

