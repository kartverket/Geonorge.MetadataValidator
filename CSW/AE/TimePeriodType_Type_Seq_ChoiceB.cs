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
	/// 	This class represents the Element TimePeriodType_Type_Seq_ChoiceB
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"TimePeriodType_Type_Seq_ChoiceB", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class TimePeriodType_Type_Seq_ChoiceB : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for TimePeriodType_Type_Seq_ChoiceB
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public TimePeriodType_Type_Seq_ChoiceB()
		{
			_elementName = "TimePeriodType_Type_Seq_ChoiceB";
			Init();
		}
		public TimePeriodType_Type_Seq_ChoiceB(String elementName)
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
			m_Duration = new LiquidTechnologies.Runtime.Net45.XmlDateTimeSpan();
			m_IsValidDuration = false; 
			m_TimeInterval = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_Duration = new LiquidTechnologies.Runtime.Net45.XmlDateTimeSpan();
			m_IsValidDuration = false;
			m_TimeInterval = null;
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
			AE.TimePeriodType_Type_Seq_ChoiceB newObject = new AE.TimePeriodType_Type_Seq_ChoiceB(_elementName);
			newObject.m_Duration = (LiquidTechnologies.Runtime.Net45.XmlDateTimeSpan)m_Duration.Clone();
			newObject.m_IsValidDuration = m_IsValidDuration;
			newObject.m_TimeInterval = null;
			if (m_TimeInterval != null)
				newObject.m_TimeInterval = (AE.TimeInterval)m_TimeInterval.Clone();

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

		#region Attribute - duration
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("duration", "http://www.opengis.net/gml", "IsValidDuration", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_duration, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.XmlDateTimeSpan Duration
		{
			get 
			{ 
				if (m_IsValidDuration == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property duration is not valid. Set durationValid = true");
				return m_Duration;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("duration"); // remove selection
				m_IsValidDuration = true;
				m_Duration = value;
			}
		}
		/// <summary>
		/// 	Indicates if duration contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for duration is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (new LiquidTechnologies.Runtime.Net45.XmlDateTimeSpan()).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get duration
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidDuration
		{
			get
			{
				return m_IsValidDuration;
			}
			set 
			{ 
				if (value != m_IsValidDuration)
				{
					Duration = new LiquidTechnologies.Runtime.Net45.XmlDateTimeSpan();
					m_IsValidDuration = value;
				}
			}
		}
		protected Boolean m_IsValidDuration;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTimeSpan m_Duration;
		#endregion

		#region Attribute - timeInterval
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("timeInterval", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.TimeInterval))]
		public AE.TimeInterval TimeInterval
		{
			get 
			{ 
				return m_TimeInterval;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"timeInterval"); // remove selection
				if (value == null)
					m_TimeInterval = null;
				else
				{
					m_TimeInterval = value; 
				}
			}
		}
		protected AE.TimeInterval m_TimeInterval;
		
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


