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
	/// 	This class represents the Element validArea_Choice
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"validArea_Choice", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class ValidArea_Choice : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for ValidArea_Choice
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public ValidArea_Choice()
		{
			_elementName = "validArea_Choice";
			Init();
		}
		public ValidArea_Choice(String elementName)
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
			m_BoundingBoxCol = new CSW.XmlAbstractObjectCollection<AE.IEnvelopeType>("boundingBox", "http://www.opengis.net/gml", 0, -1, typeof(AE.ClassFactory), "IEnvelopeTypeCreateObject");
			m_BoundingBoxCol.OnCollectionChange += new CSW.XmlAbstractObjectCollection<AE.IEnvelopeType>.OnCollectionChangeEvent(this.BoundingBoxCol_OnChange);
			m_BoundingPolygonCol = new CSW.XmlObjectCollection<AE.BoundingPolygon>("boundingPolygon", "http://www.opengis.net/gml", 0, -1, false);
			m_BoundingPolygonCol.OnCollectionChange += new CSW.XmlObjectCollection<AE.BoundingPolygon>.OnCollectionChangeEvent(this.BoundingPolygonCol_OnChange);



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			if (m_BoundingBoxCol != null)
			{
				if ("boundingBoxCol" != selectedElement)
					m_BoundingBoxCol.Clear();
			}
			if (m_BoundingPolygonCol != null)
			{
				if ("boundingPolygonCol" != selectedElement)
					m_BoundingPolygonCol.Clear();
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
			AE.ValidArea_Choice newObject = new AE.ValidArea_Choice(_elementName);
			foreach (AE.IEnvelopeType o in m_BoundingBoxCol)
				newObject.m_BoundingBoxCol.Add((AE.IEnvelopeType)o.Clone());
			foreach (AE.BoundingPolygon o in m_BoundingPolygonCol)
				newObject.m_BoundingPolygonCol.Add((AE.BoundingPolygon)o.Clone());

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

		#region Attribute - boundingBox
		/// <summary>
		/// 	A collection of boundingBoxCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		///		<BR>Only one Element within this class may be set at a time. This collection (as a whole is counted as an element) may contain 0 or 0 to Many entries. Emptying the collection allows a different element to be the selected one. If there is already a selected element, and an item is added to this collection then an exception will be raised</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsCol("boundingBox", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlAbstractObjectCollection<AE.IEnvelopeType> BoundingBoxCol
		{
			get { return m_BoundingBoxCol;  }
		}
		// gets called when the collection changes (allows us to determine if this choice is selected or not)
		private void BoundingBoxCol_OnChange(object o, EventArgs args)
		{
			// The class represents a choice, so prevent more than one element from being selected
			if (_validElement != "boundingBoxCol")
			{
				ClearChoice(m_BoundingBoxCol.Count == 0?"":"boundingBoxCol"); // remove selection
			}
		}
		protected CSW.XmlAbstractObjectCollection<AE.IEnvelopeType> m_BoundingBoxCol;
		
		#endregion

		#region Attribute - boundingPolygon
		/// <summary>
		/// 	A collection of boundingPolygonCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		///		<BR>Only one Element within this class may be set at a time. This collection (as a whole is counted as an element) may contain 0 or 0 to Many entries. Emptying the collection allows a different element to be the selected one. If there is already a selected element, and an item is added to this collection then an exception will be raised</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsCol("boundingPolygon", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.BoundingPolygon> BoundingPolygonCol
		{
			get { return m_BoundingPolygonCol; }
		}
		// gets called when the collection changes (allows us to determine if this choice is selected or not)
		private void BoundingPolygonCol_OnChange(object o, EventArgs args)
		{
			// The class represents a choice, so prevent more than one element from being selected
			if (_validElement != "boundingPolygonCol")
			{
				ClearChoice(m_BoundingPolygonCol.Count == 0?"":"boundingPolygonCol"); // remove selection
			}
		}
		protected CSW.XmlObjectCollection<AE.BoundingPolygon> m_BoundingPolygonCol;
		
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


