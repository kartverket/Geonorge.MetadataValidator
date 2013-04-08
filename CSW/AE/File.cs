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
	/// 	This class represents the Element File
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"File", "http://www.opengis.net/gml", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class File : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for File
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public File()
		{
			_elementName = "File";
			Init();
		}
		public File(String elementName)
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
			m_RangeParameters = new AE.RangeParameters("rangeParameters");
			m_FileName = "";
			m_FileStructure = AE.Enumerations.FileValueModelType.RecordSpaceInterleaved;
			m_MimeType = "";
			m_IsValidMimeType = false; 
			m_Compression = "";
			m_IsValidCompression = false; 



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
			AE.File newObject = new AE.File(_elementName);
			newObject.m_RangeParameters = null;
			if (m_RangeParameters != null)
				newObject.m_RangeParameters = (AE.RangeParameters)m_RangeParameters.Clone();
			newObject.m_FileName = m_FileName;
			newObject.m_FileStructure = m_FileStructure;
			newObject.m_MimeType = m_MimeType;
			newObject.m_IsValidMimeType = m_IsValidMimeType;
			newObject.m_Compression = m_Compression;
			newObject.m_IsValidCompression = m_IsValidCompression;


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

		#region Attribute - rangeParameters
		/// <summary>
		///		Represents a mandatory Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>If this property is set, then the object will be COPIED. If the property is set to null an exception is raised.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("rangeParameters", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.RangeParameters), false)]
		public AE.RangeParameters RangeParameters
		{
			get 
			{ 
				return m_RangeParameters;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "rangeParameters");
				m_RangeParameters = value;
			}
		}
		protected AE.RangeParameters m_RangeParameters;
		
		#endregion

		#region Attribute - fileName
		/// <summary>
		///		Represents a mandatory Element in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to "".</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("fileName", "http://www.opengis.net/gml", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public String FileName
		{
			get 
			{ 
				return m_FileName;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_FileName = value;
			}
		}
		protected String m_FileName;

		#endregion

		#region Attribute - fileStructure
		/// <summary>
		///		Represents a mandatory enumerated Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is mandatory and therefore must be populated within the XML.</BR>
		/// 	<BR>It is defaulted to AE.Enumerations.FileValueModelType.RecordSpaceInterleaved;.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqEnumMnd("fileStructure", "http://www.opengis.net/gml", null, typeof(AE.Enumerations), "FileValueModelTypeFromString", "FileValueModelTypeToString")]
		public AE.Enumerations.FileValueModelType FileStructure
		{
			get 
			{ 
				return m_FileStructure;  
			}
			set 
			{ 
				m_FileStructure = value;
			}
		}
		protected AE.Enumerations.FileValueModelType m_FileStructure;

		#endregion

		#region Attribute - mimeType
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("mimeType", "http://www.opengis.net/gml", "IsValidMimeType", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public String MimeType
		{
			get 
			{ 
				if (m_IsValidMimeType == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property mimeType is not valid. Set mimeTypeValid = true");
				return m_MimeType;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidMimeType = true;
				m_MimeType = value;
			}
		}
		/// <summary>
		/// 	Indicates if mimeType contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for mimeType is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get mimeType
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidMimeType
		{
			get
			{
				return m_IsValidMimeType;
			}
			set 
			{ 
				if (value != m_IsValidMimeType)
				{
					MimeType = "";
					m_IsValidMimeType = value;
				}
			}
		}
		protected Boolean m_IsValidMimeType;
		protected String m_MimeType;
		#endregion

		#region Attribute - compression
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("compression", "http://www.opengis.net/gml", "IsValidCompression", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public String Compression
		{
			get 
			{ 
				if (m_IsValidCompression == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property compression is not valid. Set compressionValid = true");
				return m_Compression;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidCompression = true;
				m_Compression = value;
			}
		}
		/// <summary>
		/// 	Indicates if compression contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for compression is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get compression
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidCompression
		{
			get
			{
				return m_IsValidCompression;
			}
			set 
			{ 
				if (value != m_IsValidCompression)
				{
					Compression = "";
					m_IsValidCompression = value;
				}
			}
		}
		protected Boolean m_IsValidCompression;
		protected String m_Compression;
		#endregion

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


