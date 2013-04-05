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

namespace csw
{
	/// <summary>
	/// 	This class represents the ComplexType InsertType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"InsertType", "http://www.opengis.net/cat/csw/2.0.2", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class InsertType : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for InsertType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public InsertType()
		{
			_elementName = "InsertType";
			Init();
		}
		public InsertType(String elementName)
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
			m_TypeName = "";
			m_IsValidTypeName = false;
			m_Handle = "";
			m_IsValidHandle = false;
			m_AnyElementCol = new LiquidTechnologies.Runtime.Net45.ElementCol("", "##other", "http://www.opengis.net/cat/csw/2.0.2", 0, -1);



// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
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
			csw.InsertType newObject = new csw.InsertType(_elementName);
			newObject.m_TypeName = m_TypeName;
			newObject.m_IsValidTypeName = m_IsValidTypeName;
			newObject.m_Handle = m_Handle;
			newObject.m_IsValidHandle = m_IsValidHandle;
			foreach (LiquidTechnologies.Runtime.Net45.Element o in m_AnyElementCol)
				newObject.m_AnyElementCol.Add((LiquidTechnologies.Runtime.Net45.Element)o.Clone());


// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			return newObject;
		}
		#endregion

		#region Member variables

		protected override String TargetNamespace
		{
			get { return "http://www.opengis.net/cat/csw/2.0.2"; }
		}

		#region Attribute - typeName
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("typeName", "", "IsValidTypeName", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String TypeName
		{
			get 
			{ 
				if (m_IsValidTypeName == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property typeName is not valid. Set typeNameValid = true");
				return m_TypeName;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidTypeName = true;
				m_TypeName = value;
			}
		}
		/// <summary>
		/// 	Indicates if typeName contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for typeName is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get typeName
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidTypeName
		{
			get
			{
				return m_IsValidTypeName;
			}
			set 
			{ 
				if (value != m_IsValidTypeName)
				{
					TypeName = "";
					m_IsValidTypeName = value;
				}
			}
		}
		protected Boolean m_IsValidTypeName;
		protected String m_TypeName;
		#endregion

		#region Attribute - handle
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("handle", "", "IsValidHandle", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String Handle
		{
			get 
			{ 
				if (m_IsValidHandle == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property handle is not valid. Set handleValid = true");
				return m_Handle;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidHandle = true;
				m_Handle = value;
			}
		}
		/// <summary>
		/// 	Indicates if handle contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for handle is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get handle
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidHandle
		{
			get
			{
				return m_IsValidHandle;
			}
			set 
			{ 
				if (value != m_IsValidHandle)
				{
					Handle = "";
					m_IsValidHandle = value;
				}
			}
		}
		protected Boolean m_IsValidHandle;
		protected String m_Handle;
		#endregion

		#region Attribute - AnyElement
		/// <summary>
		/// 	A collection of untyped elements
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as a collection of Elements in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqUntpdCol("AnyElement", "")]
		public LiquidTechnologies.Runtime.Net45.ElementCol AnyElementCol
		{
			get { return m_AnyElementCol; }
		}
		protected LiquidTechnologies.Runtime.Net45.ElementCol m_AnyElementCol;
		#endregion

		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://www.opengis.net/cat/csw/2.0.2"; }
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


