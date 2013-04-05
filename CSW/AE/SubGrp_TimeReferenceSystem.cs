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
	/// 	This class represents the Element SubGrp_TimeReferenceSystem
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrp_TimeReferenceSystem", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrp_TimeReferenceSystem : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrp_TimeReferenceSystem
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrp_TimeReferenceSystem()
		{
			_elementName = "SubGrp_TimeReferenceSystem";
			Init();
		}
		public SubGrp_TimeReferenceSystem(String elementName)
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
			m__TimeReferenceSystem = null;
			m_TimeClock = null;
			m_TimeOrdinalReferenceSystem = null;
			m_TimeCoordinateSystem = null;
			m_TimeCalendar = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__TimeReferenceSystem = null;
			m_TimeClock = null;
			m_TimeOrdinalReferenceSystem = null;
			m_TimeCoordinateSystem = null;
			m_TimeCalendar = null;
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
			AE.SubGrp_TimeReferenceSystem newObject = new AE.SubGrp_TimeReferenceSystem(_elementName);
			newObject.m__TimeReferenceSystem = null;
			if (m__TimeReferenceSystem != null)
				newObject.m__TimeReferenceSystem = (AE.IAbstractTimeReferenceSystemType)m__TimeReferenceSystem.Clone();
			newObject.m_TimeClock = null;
			if (m_TimeClock != null)
				newObject.m_TimeClock = (AE.TimeClock)m_TimeClock.Clone();
			newObject.m_TimeOrdinalReferenceSystem = null;
			if (m_TimeOrdinalReferenceSystem != null)
				newObject.m_TimeOrdinalReferenceSystem = (AE.TimeOrdinalReferenceSystem)m_TimeOrdinalReferenceSystem.Clone();
			newObject.m_TimeCoordinateSystem = null;
			if (m_TimeCoordinateSystem != null)
				newObject.m_TimeCoordinateSystem = (AE.TimeCoordinateSystem)m_TimeCoordinateSystem.Clone();
			newObject.m_TimeCalendar = null;
			if (m_TimeCalendar != null)
				newObject.m_TimeCalendar = (AE.TimeCalendar)m_TimeCalendar.Clone();

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

		#region Attribute - _TimeReferenceSystem
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_TimeReferenceSystem", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractTimeReferenceSystemTypeCreateObject")]
		public AE.IAbstractTimeReferenceSystemType _TimeReferenceSystem
		{
			get 
			{ 
				return m__TimeReferenceSystem;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_TimeReferenceSystem"); // remove selection
				if (value == null)
					m__TimeReferenceSystem = null;
				else
				{
					m__TimeReferenceSystem = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_TimeReferenceSystem");
				}
			}
		}
		protected AE.IAbstractTimeReferenceSystemType m__TimeReferenceSystem;

		#endregion

		#region Attribute - TimeClock
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _TimeReferenceSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("TimeClock", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.TimeClock))]
		public AE.TimeClock TimeClock
		{
			get 
			{ 
				return m_TimeClock;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"TimeClock"); // remove selection
				if (value == null)
					m_TimeClock = null;
				else
				{
					m_TimeClock = value; 
				}
			}
		}
		protected AE.TimeClock m_TimeClock;
		
		#endregion

		#region Attribute - TimeOrdinalReferenceSystem
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _TimeReferenceSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("TimeOrdinalReferenceSystem", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.TimeOrdinalReferenceSystem))]
		public AE.TimeOrdinalReferenceSystem TimeOrdinalReferenceSystem
		{
			get 
			{ 
				return m_TimeOrdinalReferenceSystem;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"TimeOrdinalReferenceSystem"); // remove selection
				if (value == null)
					m_TimeOrdinalReferenceSystem = null;
				else
				{
					m_TimeOrdinalReferenceSystem = value; 
				}
			}
		}
		protected AE.TimeOrdinalReferenceSystem m_TimeOrdinalReferenceSystem;
		
		#endregion

		#region Attribute - TimeCoordinateSystem
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _TimeReferenceSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("TimeCoordinateSystem", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.TimeCoordinateSystem))]
		public AE.TimeCoordinateSystem TimeCoordinateSystem
		{
			get 
			{ 
				return m_TimeCoordinateSystem;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"TimeCoordinateSystem"); // remove selection
				if (value == null)
					m_TimeCoordinateSystem = null;
				else
				{
					m_TimeCoordinateSystem = value; 
				}
			}
		}
		protected AE.TimeCoordinateSystem m_TimeCoordinateSystem;
		
		#endregion

		#region Attribute - TimeCalendar
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _TimeReferenceSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("TimeCalendar", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.TimeCalendar))]
		public AE.TimeCalendar TimeCalendar
		{
			get 
			{ 
				return m_TimeCalendar;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"TimeCalendar"); // remove selection
				if (value == null)
					m_TimeCalendar = null;
				else
				{
					m_TimeCalendar = value; 
				}
			}
		}
		protected AE.TimeCalendar m_TimeCalendar;
		
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


