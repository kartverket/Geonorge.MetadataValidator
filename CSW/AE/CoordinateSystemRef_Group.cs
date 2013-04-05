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
	/// 	This class represents the Element coordinateSystemRef_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"coordinateSystemRef_Group", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class CoordinateSystemRef_Group : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for CoordinateSystemRef_Group
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public CoordinateSystemRef_Group()
		{
			_elementName = "coordinateSystemRef_Group";
			Init();
		}
		public CoordinateSystemRef_Group(String elementName)
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
			m__CoordinateSystem = null;
			m_TemporalCS = null;
			m_UserDefinedCS = null;
			m_SphericalCS = null;
			m_ObliqueCartesianCS = null;
			m_EllipsoidalCS = null;
			m_PolarCS = null;
			m_CartesianCS = null;
			m_VerticalCS = null;
			m_CylindricalCS = null;
			m_LinearCS = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__CoordinateSystem = null;
			m_TemporalCS = null;
			m_UserDefinedCS = null;
			m_SphericalCS = null;
			m_ObliqueCartesianCS = null;
			m_EllipsoidalCS = null;
			m_PolarCS = null;
			m_CartesianCS = null;
			m_VerticalCS = null;
			m_CylindricalCS = null;
			m_LinearCS = null;
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
			AE.CoordinateSystemRef_Group newObject = new AE.CoordinateSystemRef_Group(_elementName);
			newObject.m__CoordinateSystem = null;
			if (m__CoordinateSystem != null)
				newObject.m__CoordinateSystem = (AE.IAbstractCoordinateSystemType)m__CoordinateSystem.Clone();
			newObject.m_TemporalCS = null;
			if (m_TemporalCS != null)
				newObject.m_TemporalCS = (AE.TemporalCS)m_TemporalCS.Clone();
			newObject.m_UserDefinedCS = null;
			if (m_UserDefinedCS != null)
				newObject.m_UserDefinedCS = (AE.UserDefinedCS)m_UserDefinedCS.Clone();
			newObject.m_SphericalCS = null;
			if (m_SphericalCS != null)
				newObject.m_SphericalCS = (AE.SphericalCS)m_SphericalCS.Clone();
			newObject.m_ObliqueCartesianCS = null;
			if (m_ObliqueCartesianCS != null)
				newObject.m_ObliqueCartesianCS = (AE.ObliqueCartesianCS)m_ObliqueCartesianCS.Clone();
			newObject.m_EllipsoidalCS = null;
			if (m_EllipsoidalCS != null)
				newObject.m_EllipsoidalCS = (AE.EllipsoidalCS)m_EllipsoidalCS.Clone();
			newObject.m_PolarCS = null;
			if (m_PolarCS != null)
				newObject.m_PolarCS = (AE.PolarCS)m_PolarCS.Clone();
			newObject.m_CartesianCS = null;
			if (m_CartesianCS != null)
				newObject.m_CartesianCS = (AE.CartesianCS)m_CartesianCS.Clone();
			newObject.m_VerticalCS = null;
			if (m_VerticalCS != null)
				newObject.m_VerticalCS = (AE.VerticalCS)m_VerticalCS.Clone();
			newObject.m_CylindricalCS = null;
			if (m_CylindricalCS != null)
				newObject.m_CylindricalCS = (AE.CylindricalCS)m_CylindricalCS.Clone();
			newObject.m_LinearCS = null;
			if (m_LinearCS != null)
				newObject.m_LinearCS = (AE.LinearCS)m_LinearCS.Clone();

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

		#region Attribute - _CoordinateSystem
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_CoordinateSystem", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractCoordinateSystemTypeCreateObject")]
		public AE.IAbstractCoordinateSystemType _CoordinateSystem
		{
			get 
			{ 
				return m__CoordinateSystem;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_CoordinateSystem"); // remove selection
				if (value == null)
					m__CoordinateSystem = null;
				else
				{
					m__CoordinateSystem = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_CoordinateSystem");
				}
			}
		}
		protected AE.IAbstractCoordinateSystemType m__CoordinateSystem;

		#endregion

		#region Attribute - TemporalCS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CoordinateSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("TemporalCS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.TemporalCS))]
		public AE.TemporalCS TemporalCS
		{
			get 
			{ 
				return m_TemporalCS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"TemporalCS"); // remove selection
				if (value == null)
					m_TemporalCS = null;
				else
				{
					m_TemporalCS = value; 
				}
			}
		}
		protected AE.TemporalCS m_TemporalCS;
		
		#endregion

		#region Attribute - UserDefinedCS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CoordinateSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("UserDefinedCS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.UserDefinedCS))]
		public AE.UserDefinedCS UserDefinedCS
		{
			get 
			{ 
				return m_UserDefinedCS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"UserDefinedCS"); // remove selection
				if (value == null)
					m_UserDefinedCS = null;
				else
				{
					m_UserDefinedCS = value; 
				}
			}
		}
		protected AE.UserDefinedCS m_UserDefinedCS;
		
		#endregion

		#region Attribute - SphericalCS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CoordinateSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SphericalCS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.SphericalCS))]
		public AE.SphericalCS SphericalCS
		{
			get 
			{ 
				return m_SphericalCS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SphericalCS"); // remove selection
				if (value == null)
					m_SphericalCS = null;
				else
				{
					m_SphericalCS = value; 
				}
			}
		}
		protected AE.SphericalCS m_SphericalCS;
		
		#endregion

		#region Attribute - ObliqueCartesianCS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CoordinateSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("ObliqueCartesianCS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ObliqueCartesianCS))]
		public AE.ObliqueCartesianCS ObliqueCartesianCS
		{
			get 
			{ 
				return m_ObliqueCartesianCS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"ObliqueCartesianCS"); // remove selection
				if (value == null)
					m_ObliqueCartesianCS = null;
				else
				{
					m_ObliqueCartesianCS = value; 
				}
			}
		}
		protected AE.ObliqueCartesianCS m_ObliqueCartesianCS;
		
		#endregion

		#region Attribute - EllipsoidalCS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CoordinateSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("EllipsoidalCS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.EllipsoidalCS))]
		public AE.EllipsoidalCS EllipsoidalCS
		{
			get 
			{ 
				return m_EllipsoidalCS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"EllipsoidalCS"); // remove selection
				if (value == null)
					m_EllipsoidalCS = null;
				else
				{
					m_EllipsoidalCS = value; 
				}
			}
		}
		protected AE.EllipsoidalCS m_EllipsoidalCS;
		
		#endregion

		#region Attribute - PolarCS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CoordinateSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("PolarCS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.PolarCS))]
		public AE.PolarCS PolarCS
		{
			get 
			{ 
				return m_PolarCS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"PolarCS"); // remove selection
				if (value == null)
					m_PolarCS = null;
				else
				{
					m_PolarCS = value; 
				}
			}
		}
		protected AE.PolarCS m_PolarCS;
		
		#endregion

		#region Attribute - CartesianCS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CoordinateSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("CartesianCS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.CartesianCS))]
		public AE.CartesianCS CartesianCS
		{
			get 
			{ 
				return m_CartesianCS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"CartesianCS"); // remove selection
				if (value == null)
					m_CartesianCS = null;
				else
				{
					m_CartesianCS = value; 
				}
			}
		}
		protected AE.CartesianCS m_CartesianCS;
		
		#endregion

		#region Attribute - VerticalCS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CoordinateSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("VerticalCS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.VerticalCS))]
		public AE.VerticalCS VerticalCS
		{
			get 
			{ 
				return m_VerticalCS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"VerticalCS"); // remove selection
				if (value == null)
					m_VerticalCS = null;
				else
				{
					m_VerticalCS = value; 
				}
			}
		}
		protected AE.VerticalCS m_VerticalCS;
		
		#endregion

		#region Attribute - CylindricalCS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CoordinateSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("CylindricalCS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.CylindricalCS))]
		public AE.CylindricalCS CylindricalCS
		{
			get 
			{ 
				return m_CylindricalCS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"CylindricalCS"); // remove selection
				if (value == null)
					m_CylindricalCS = null;
				else
				{
					m_CylindricalCS = value; 
				}
			}
		}
		protected AE.CylindricalCS m_CylindricalCS;
		
		#endregion

		#region Attribute - LinearCS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CoordinateSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("LinearCS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.LinearCS))]
		public AE.LinearCS LinearCS
		{
			get 
			{ 
				return m_LinearCS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"LinearCS"); // remove selection
				if (value == null)
					m_LinearCS = null;
				else
				{
					m_LinearCS = value; 
				}
			}
		}
		protected AE.LinearCS m_LinearCS;
		
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


