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
	/// 	This class represents the Element LinearRingType_Type
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"LinearRingType_Type", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class LinearRingType_Type : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for LinearRingType_Type
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public LinearRingType_Type()
		{
			_elementName = "LinearRingType_Type";
			Init();
		}
		public LinearRingType_Type(String elementName)
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
			m_LinearRingType_Type_Seq_Choice_ChoiceCol = new CSW.XmlObjectCollection<AE.LinearRingType_Type_Seq_Choice_Choice>("LinearRingType_Type_Seq_Choice_Choice", "", 4, -1, true);
			m_LinearRingType_Type_Seq_Choice_ChoiceCol.OnCollectionChange += new CSW.XmlObjectCollection<AE.LinearRingType_Type_Seq_Choice_Choice>.OnCollectionChangeEvent(this.LinearRingType_Type_Seq_Choice_ChoiceCol_OnChange);
			m_PosList = null;
			m_Coordinates = null;
			m_CoordCol = new CSW.XmlObjectCollection<AE.Coord>("coord", "http://www.opengis.net/gml", 4, -1, false);
			m_CoordCol.OnCollectionChange += new CSW.XmlObjectCollection<AE.Coord>.OnCollectionChangeEvent(this.CoordCol_OnChange);



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			if (m_LinearRingType_Type_Seq_Choice_ChoiceCol != null)
			{
				if ("LinearRingType_Type_Seq_Choice_ChoiceCol" != selectedElement)
					m_LinearRingType_Type_Seq_Choice_ChoiceCol.Clear();
			}
			m_PosList = null;
			m_Coordinates = null;
			if (m_CoordCol != null)
			{
				if ("coordCol" != selectedElement)
					m_CoordCol.Clear();
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
			AE.LinearRingType_Type newObject = new AE.LinearRingType_Type(_elementName);
			foreach (AE.LinearRingType_Type_Seq_Choice_Choice o in m_LinearRingType_Type_Seq_Choice_ChoiceCol)
				newObject.m_LinearRingType_Type_Seq_Choice_ChoiceCol.Add((AE.LinearRingType_Type_Seq_Choice_Choice)o.Clone());
			newObject.m_PosList = null;
			if (m_PosList != null)
				newObject.m_PosList = (AE.PosList)m_PosList.Clone();
			newObject.m_Coordinates = null;
			if (m_Coordinates != null)
				newObject.m_Coordinates = (AE.Coordinates)m_Coordinates.Clone();
			foreach (AE.Coord o in m_CoordCol)
				newObject.m_CoordCol.Add((AE.Coord)o.Clone());

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

		#region Attribute - LinearRingType_Type_Seq_Choice_Choice
		/// <summary>
		/// 	A collection of LinearRingType_Type_Seq_Choice_ChoiceCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 4 to Many objects.</BR>
		///		<BR>Only one Element within this class may be set at a time. This collection (as a whole is counted as an element) may contain 0 or 4 to Many entries. Emptying the collection allows a different element to be the selected one. If there is already a selected element, and an item is added to this collection then an exception will be raised</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsCol("LinearRingType_Type_Seq_Choice_Choice", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public CSW.XmlObjectCollection<AE.LinearRingType_Type_Seq_Choice_Choice> LinearRingType_Type_Seq_Choice_ChoiceCol
		{
			get { return m_LinearRingType_Type_Seq_Choice_ChoiceCol; }
		}
		// gets called when the collection changes (allows us to determine if this choice is selected or not)
		private void LinearRingType_Type_Seq_Choice_ChoiceCol_OnChange(object o, EventArgs args)
		{
			// The class represents a choice, so prevent more than one element from being selected
			if (_validElement != "LinearRingType_Type_Seq_Choice_ChoiceCol")
			{
				ClearChoice(m_LinearRingType_Type_Seq_Choice_ChoiceCol.Count == 0?"":"LinearRingType_Type_Seq_Choice_ChoiceCol"); // remove selection
			}
		}
		protected CSW.XmlObjectCollection<AE.LinearRingType_Type_Seq_Choice_Choice> m_LinearRingType_Type_Seq_Choice_ChoiceCol;
		
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

		#region Attribute - coord
		/// <summary>
		/// 	A collection of coordCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 4 to Many objects.</BR>
		///		<BR>Only one Element within this class may be set at a time. This collection (as a whole is counted as an element) may contain 0 or 4 to Many entries. Emptying the collection allows a different element to be the selected one. If there is already a selected element, and an item is added to this collection then an exception will be raised</BR>
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


