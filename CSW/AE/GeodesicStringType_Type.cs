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
	/// 	This class represents the Element GeodesicStringType_Type
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"GeodesicStringType_Type", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class GeodesicStringType_Type : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for GeodesicStringType_Type
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public GeodesicStringType_Type()
		{
			_elementName = "GeodesicStringType_Type";
			Init();
		}
		public GeodesicStringType_Type(String elementName)
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
			m_Interpolation = AE.Enumerations.CurveInterpolationType.Linear;
			m_IsValidInterpolation = false;
			m_PosList = null;
			m_GeodesicStringType_Type_ChoiceCol = new CSW.XmlObjectCollection<AE.GeodesicStringType_Type_Choice>("GeodesicStringType_Type_Choice", "", 2, -1, true);
			m_GeodesicStringType_Type_ChoiceCol.OnCollectionChange += new CSW.XmlObjectCollection<AE.GeodesicStringType_Type_Choice>.OnCollectionChangeEvent(this.GeodesicStringType_Type_ChoiceCol_OnChange);



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_PosList = null;
			if (m_GeodesicStringType_Type_ChoiceCol != null)
			{
				if ("GeodesicStringType_Type_ChoiceCol" != selectedElement)
					m_GeodesicStringType_Type_ChoiceCol.Clear();
			}
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
			AE.GeodesicStringType_Type newObject = new AE.GeodesicStringType_Type(_elementName);
			newObject.m_Interpolation = m_Interpolation;
			newObject.m_IsValidInterpolation = m_IsValidInterpolation;
			newObject.m_PosList = null;
			if (m_PosList != null)
				newObject.m_PosList = (AE.PosList)m_PosList.Clone();
			foreach (AE.GeodesicStringType_Type_Choice o in m_GeodesicStringType_Type_ChoiceCol)
				newObject.m_GeodesicStringType_Type_ChoiceCol.Add((AE.GeodesicStringType_Type_Choice)o.Clone());

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

		#region Attribute - interpolation
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("interpolation", "", "IsValidInterpolation", typeof(AE.Enumerations), "CurveInterpolationTypeFromString", "CurveInterpolationTypeToString", null)]
		public AE.Enumerations.CurveInterpolationType Interpolation
		{
			get 
			{ 
				if (m_IsValidInterpolation == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property interpolation is not valid. Set interpolationValid = true");
				return m_Interpolation;  
			}
			set 
			{ 
				m_Interpolation = value;
				m_IsValidInterpolation = true;
			}
		}
		/// <summary>
		/// 	Indicates if interpolation contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for interpolation is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AE.Enumerations.CurveInterpolationType.Linear).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get interpolation
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidInterpolation
		{
			get { return m_IsValidInterpolation;  }
			set 
			{ 
				if (value != m_IsValidInterpolation)
				{
					Interpolation = AE.Enumerations.CurveInterpolationType.Linear;
					m_IsValidInterpolation = value;
				}
			}
		}
		protected AE.Enumerations.CurveInterpolationType m_Interpolation;
		protected Boolean m_IsValidInterpolation;

		#endregion

		#region Attribute - posList
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("posList", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.PosList))]
		public AE.PosList PosList
		{
			get 
			{ 
				return m_PosList;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"posList"); // remove selection
				if (value == null)
					m_PosList = null;
				else
				{
					m_PosList = value; 
				}
			}
		}
		protected AE.PosList m_PosList;
		
		#endregion

		#region Attribute - GeodesicStringType_Type_Choice
		/// <summary>
		/// 	A collection of GeodesicStringType_Type_ChoiceCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 2 to Many objects.</BR>
		///		<BR>Only one Element within this class may be set at a time. This collection (as a whole is counted as an element) may contain 0 or 2 to Many entries. Emptying the collection allows a different element to be the selected one. If there is already a selected element, and an item is added to this collection then an exception will be raised</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsCol("GeodesicStringType_Type_Choice", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public CSW.XmlObjectCollection<AE.GeodesicStringType_Type_Choice> GeodesicStringType_Type_ChoiceCol
		{
			get { return m_GeodesicStringType_Type_ChoiceCol; }
		}
		// gets called when the collection changes (allows us to determine if this choice is selected or not)
		private void GeodesicStringType_Type_ChoiceCol_OnChange(object o, EventArgs args)
		{
			// The class represents a choice, so prevent more than one element from being selected
			if (_validElement != "GeodesicStringType_Type_ChoiceCol")
			{
				ClearChoice(m_GeodesicStringType_Type_ChoiceCol.Count == 0?"":"GeodesicStringType_Type_ChoiceCol"); // remove selection
			}
		}
		protected CSW.XmlObjectCollection<AE.GeodesicStringType_Type_Choice> m_GeodesicStringType_Type_ChoiceCol;
		
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


