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
	/// 	This class represents the Element dmsAngleValue_Choice
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"dmsAngleValue_Choice", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class DmsAngleValue_Choice : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for DmsAngleValue_Choice
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public DmsAngleValue_Choice()
		{
			_elementName = "dmsAngleValue_Choice";
			Init();
		}
		public DmsAngleValue_Choice(String elementName)
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
			m_DecimalMinutes = 0;
			m_IsValidDecimalMinutes = false; 
			m_DmsAngleValue_Choice_Seq = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_DecimalMinutes = 0;
			m_IsValidDecimalMinutes = false;
			m_DmsAngleValue_Choice_Seq = null;
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
			AE.DmsAngleValue_Choice newObject = new AE.DmsAngleValue_Choice(_elementName);
			newObject.m_DecimalMinutes = m_DecimalMinutes;
			newObject.m_IsValidDecimalMinutes = m_IsValidDecimalMinutes;
			newObject.m_DmsAngleValue_Choice_Seq = null;
			if (m_DmsAngleValue_Choice_Seq != null)
				newObject.m_DmsAngleValue_Choice_Seq = (AE.DmsAngleValue_Choice_Seq)m_DmsAngleValue_Choice_Seq.Clone();

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

		#region Attribute - decimalMinutes
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("decimalMinutes", "http://www.opengis.net/gml", "IsValidDecimalMinutes", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "0.00", "", "", "60.00", -1)]
		public Decimal DecimalMinutes
		{
			get 
			{ 
				if (m_IsValidDecimalMinutes == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property decimalMinutes is not valid. Set decimalMinutesValid = true");
				return m_DecimalMinutes;  
			}
			set 
			{ 
				CheckElementRestriction(0, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("decimalMinutes"); // remove selection
				m_IsValidDecimalMinutes = true;
				m_DecimalMinutes = value;
			}
		}
		/// <summary>
		/// 	Indicates if decimalMinutes contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for decimalMinutes is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get decimalMinutes
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidDecimalMinutes
		{
			get
			{
				return m_IsValidDecimalMinutes;
			}
			set 
			{ 
				if (value != m_IsValidDecimalMinutes)
				{
					DecimalMinutes = 0;
					m_IsValidDecimalMinutes = value;
				}
			}
		}
		protected Boolean m_IsValidDecimalMinutes;
		protected Decimal m_DecimalMinutes;
		#endregion

		#region Attribute - dmsAngleValue_Choice_Seq
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("dmsAngleValue_Choice_Seq", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.DmsAngleValue_Choice_Seq))]
		public AE.DmsAngleValue_Choice_Seq DmsAngleValue_Choice_Seq
		{
			get 
			{ 
				return m_DmsAngleValue_Choice_Seq;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"dmsAngleValue_Choice_Seq"); // remove selection
				if (value == null)
					m_DmsAngleValue_Choice_Seq = null;
				else
				{
					m_DmsAngleValue_Choice_Seq = value; 
				}
			}
		}
		protected AE.DmsAngleValue_Choice_Seq m_DmsAngleValue_Choice_Seq;
		
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


