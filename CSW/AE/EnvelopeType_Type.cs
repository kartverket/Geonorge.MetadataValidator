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
	/// 	This class represents the Element EnvelopeType_Type
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"EnvelopeType_Type", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class EnvelopeType_Type : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for EnvelopeType_Type
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public EnvelopeType_Type()
		{
			_elementName = "EnvelopeType_Type";
			Init();
		}
		public EnvelopeType_Type(String elementName)
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
			m_SrsName = "";
			m_IsValidSrsName = false;
			m_SrsDimension = 0;
			m_IsValidSrsDimension = false;
			m_AxisLabels = "";
			m_IsValidAxisLabels = false;
			m_UomLabels = "";
			m_IsValidUomLabels = false;
			m_EnvelopeType_Type_Seq = null;
			m_CoordCol = new CSW.XmlObjectCollection<AE.Coord>("coord", "http://www.opengis.net/gml", 2, 2, false);
			m_CoordCol.OnCollectionChange += new CSW.XmlObjectCollection<AE.Coord>.OnCollectionChangeEvent(this.CoordCol_OnChange);
			m_PosCol = new CSW.XmlObjectCollection<AE.Pos>("pos", "http://www.opengis.net/gml", 2, 2, false);
			m_PosCol.OnCollectionChange += new CSW.XmlObjectCollection<AE.Pos>.OnCollectionChangeEvent(this.PosCol_OnChange);
			m_Coordinates = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_EnvelopeType_Type_Seq = null;
			if (m_CoordCol != null)
			{
				if ("coordCol" != selectedElement)
					m_CoordCol.Clear();
			}
			if (m_PosCol != null)
			{
				if ("posCol" != selectedElement)
					m_PosCol.Clear();
			}
			m_Coordinates = null;
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
			AE.EnvelopeType_Type newObject = new AE.EnvelopeType_Type(_elementName);
			newObject.m_SrsName = m_SrsName;
			newObject.m_IsValidSrsName = m_IsValidSrsName;
			newObject.m_SrsDimension = m_SrsDimension;
			newObject.m_IsValidSrsDimension = m_IsValidSrsDimension;
			newObject.m_AxisLabels = m_AxisLabels;
			newObject.m_IsValidAxisLabels = m_IsValidAxisLabels;
			newObject.m_UomLabels = m_UomLabels;
			newObject.m_IsValidUomLabels = m_IsValidUomLabels;
			newObject.m_EnvelopeType_Type_Seq = null;
			if (m_EnvelopeType_Type_Seq != null)
				newObject.m_EnvelopeType_Type_Seq = (AE.EnvelopeType_Type_Seq)m_EnvelopeType_Type_Seq.Clone();
			foreach (AE.Coord o in m_CoordCol)
				newObject.m_CoordCol.Add((AE.Coord)o.Clone());
			foreach (AE.Pos o in m_PosCol)
				newObject.m_PosCol.Add((AE.Pos)o.Clone());
			newObject.m_Coordinates = null;
			if (m_Coordinates != null)
				newObject.m_Coordinates = (AE.Coordinates)m_Coordinates.Clone();

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

		#region Attribute - srsName
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("srsName", "", "IsValidSrsName", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String SrsName
		{
			get 
			{ 
				if (m_IsValidSrsName == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property srsName is not valid. Set srsNameValid = true");
				return m_SrsName;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidSrsName = true;
				m_SrsName = value;
			}
		}
		/// <summary>
		/// 	Indicates if srsName contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for srsName is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get srsName
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidSrsName
		{
			get
			{
				return m_IsValidSrsName;
			}
			set 
			{ 
				if (value != m_IsValidSrsName)
				{
					SrsName = "";
					m_IsValidSrsName = value;
				}
			}
		}
		protected Boolean m_IsValidSrsName;
		protected String m_SrsName;
		#endregion

		#region Attribute - srsDimension
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("srsDimension", "", "IsValidSrsDimension", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger SrsDimension
		{
			get 
			{ 
				if (m_IsValidSrsDimension == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property srsDimension is not valid. Set srsDimensionValid = true");
				return m_SrsDimension;  
			}
			set 
			{ 
				m_IsValidSrsDimension = true;
				m_SrsDimension = value;
			}
		}
		/// <summary>
		/// 	Indicates if srsDimension contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for srsDimension is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get srsDimension
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidSrsDimension
		{
			get
			{
				return m_IsValidSrsDimension;
			}
			set 
			{ 
				if (value != m_IsValidSrsDimension)
				{
					SrsDimension = 0;
					m_IsValidSrsDimension = value;
				}
			}
		}
		protected Boolean m_IsValidSrsDimension;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_SrsDimension;
		#endregion

		#region Attribute - axisLabels
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("axisLabels", "", "IsValidAxisLabels", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String AxisLabels
		{
			get 
			{ 
				if (m_IsValidAxisLabels == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property axisLabels is not valid. Set axisLabelsValid = true");
				return m_AxisLabels;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidAxisLabels = true;
				m_AxisLabels = value;
			}
		}
		/// <summary>
		/// 	Indicates if axisLabels contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for axisLabels is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get axisLabels
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidAxisLabels
		{
			get
			{
				return m_IsValidAxisLabels;
			}
			set 
			{ 
				if (value != m_IsValidAxisLabels)
				{
					AxisLabels = "";
					m_IsValidAxisLabels = value;
				}
			}
		}
		protected Boolean m_IsValidAxisLabels;
		protected String m_AxisLabels;
		#endregion

		#region Attribute - uomLabels
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("uomLabels", "", "IsValidUomLabels", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String UomLabels
		{
			get 
			{ 
				if (m_IsValidUomLabels == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property uomLabels is not valid. Set uomLabelsValid = true");
				return m_UomLabels;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidUomLabels = true;
				m_UomLabels = value;
			}
		}
		/// <summary>
		/// 	Indicates if uomLabels contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for uomLabels is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get uomLabels
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidUomLabels
		{
			get
			{
				return m_IsValidUomLabels;
			}
			set 
			{ 
				if (value != m_IsValidUomLabels)
				{
					UomLabels = "";
					m_IsValidUomLabels = value;
				}
			}
		}
		protected Boolean m_IsValidUomLabels;
		protected String m_UomLabels;
		#endregion

		#region Attribute - EnvelopeType_Type_Seq
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("EnvelopeType_Type_Seq", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.EnvelopeType_Type_Seq))]
		public AE.EnvelopeType_Type_Seq EnvelopeType_Type_Seq
		{
			get 
			{ 
				return m_EnvelopeType_Type_Seq;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"EnvelopeType_Type_Seq"); // remove selection
				if (value == null)
					m_EnvelopeType_Type_Seq = null;
				else
				{
					m_EnvelopeType_Type_Seq = value; 
				}
			}
		}
		protected AE.EnvelopeType_Type_Seq m_EnvelopeType_Type_Seq;
		
		#endregion

		#region Attribute - coord
		/// <summary>
		/// 	A collection of coordCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 2 to 2 objects.</BR>
		///		<BR>Only one Element within this class may be set at a time. This collection (as a whole is counted as an element) may contain 0 or 2 to 2 entries. Emptying the collection allows a different element to be the selected one. If there is already a selected element, and an item is added to this collection then an exception will be raised</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsCol("coord", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.Coord> CoordCol
		{
			get { return m_CoordCol; }
		}
		// gets called when the collection changes (allows us to determine if this choice is selected or not)
		private void CoordCol_OnChange(object o, EventArgs args)
		{
			// The class represents a choice, so prevent more than one element from being selected
			if (_validElement != "coordCol")
			{
				ClearChoice(m_CoordCol.Count == 0?"":"coordCol"); // remove selection
			}
		}
		protected CSW.XmlObjectCollection<AE.Coord> m_CoordCol;
		
		#endregion

		#region Attribute - pos
		/// <summary>
		/// 	A collection of posCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 2 to 2 objects.</BR>
		///		<BR>Only one Element within this class may be set at a time. This collection (as a whole is counted as an element) may contain 0 or 2 to 2 entries. Emptying the collection allows a different element to be the selected one. If there is already a selected element, and an item is added to this collection then an exception will be raised</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsCol("pos", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.Pos> PosCol
		{
			get { return m_PosCol; }
		}
		// gets called when the collection changes (allows us to determine if this choice is selected or not)
		private void PosCol_OnChange(object o, EventArgs args)
		{
			// The class represents a choice, so prevent more than one element from being selected
			if (_validElement != "posCol")
			{
				ClearChoice(m_PosCol.Count == 0?"":"posCol"); // remove selection
			}
		}
		protected CSW.XmlObjectCollection<AE.Pos> m_PosCol;
		
		#endregion

		#region Attribute - coordinates
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("coordinates", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.Coordinates))]
		public AE.Coordinates Coordinates
		{
			get 
			{ 
				return m_Coordinates;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"coordinates"); // remove selection
				if (value == null)
					m_Coordinates = null;
				else
				{
					m_Coordinates = value; 
				}
			}
		}
		protected AE.Coordinates m_Coordinates;
		
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


