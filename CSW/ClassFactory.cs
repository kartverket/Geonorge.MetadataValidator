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

namespace CSW 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net45.ClassFactoryBase
	{


		/// <summary>
		/// Creates an object from XML data held in a string.
		/// </summary>
		/// <param name="xmlIn">The data to be loaded</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		static public LiquidTechnologies.Runtime.Net45.XmlObjectBase FromXml( String xmlIn )
		{
			return FromXml( xmlIn, LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default );
		}
		/// <summary>
		/// Creates an object from XML data held in a string.
		/// </summary>
		/// <param name="xmlIn">The data to be loaded</param>
		/// <param name="context">The context to use when loading the data</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		static public LiquidTechnologies.Runtime.Net45.XmlObjectBase FromXml( String xmlIn, LiquidTechnologies.Runtime.Net45.XmlSerializationContext context )
		{
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.PreserveWhitespace  = true;
			xmlDoc.LoadXml(xmlIn);
			return FromXmlElement(xmlDoc.DocumentElement, context);
		}

		/// <summary>
		/// Creates an object from XML data held in a File
		/// </summary>
		/// <param name="FileName">The file to be loaded</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		static public LiquidTechnologies.Runtime.Net45.XmlObjectBase FromXmlFile( String FileName )
		{
			return FromXmlFile(FileName, LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default);
		}
		/// <summary>
		/// Creates an object from XML data held in a File
		/// </summary>
		/// <param name="FileName">The file to be loaded</param>
		/// <param name="context">The context to use when loading the data</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		static public LiquidTechnologies.Runtime.Net45.XmlObjectBase FromXmlFile( String FileName, LiquidTechnologies.Runtime.Net45.XmlSerializationContext context )
		{
			using (System.IO.Stream stream = new System.IO.FileStream(FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read,System.IO.FileShare.Read))
			{
				return FromXmlStream(stream, context);
			}
		}

		/// <summary>
		/// Creates an object from XML data held in a stream.
		/// </summary>
		/// <param name="stream">The data to be loaded</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		static public LiquidTechnologies.Runtime.Net45.XmlObjectBase FromXmlStream(System.IO.Stream stream)
		{
			return FromXmlStream(stream, LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default);
		}
		/// <summary>
		/// Creates an object from XML data held in a stream.
		/// </summary>
		/// <param name="stream">The data to be loaded</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		static public LiquidTechnologies.Runtime.Net45.XmlObjectBase FromXmlStream(System.IO.Stream stream, LiquidTechnologies.Runtime.Net45.XmlSerializationContext context)
		{
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.PreserveWhitespace  = true;
			// use regular XML Parser
			xmlDoc.Load(stream);
	
			return FromXmlElement(xmlDoc.DocumentElement, context);

		}

		
		/// <summary>
		/// Creates an object from an XML Element.
		/// </summary>
		/// <param name="xmlParent">The data that needs loading</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		static public LiquidTechnologies.Runtime.Net45.XmlObjectBase FromXmlElement(XmlElement xmlParent)
		{
			return FromXmlElement(xmlParent, LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default);
		}
			
		/// <summary>
		/// Creates an object from an XML Element.
		/// </summary>
		/// <param name="xmlParent">The data that needs loading</param>
		/// <param name="context">The context to use when loading the data</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		static public LiquidTechnologies.Runtime.Net45.XmlObjectBase FromXmlElement(XmlElement xmlParent, LiquidTechnologies.Runtime.Net45.XmlSerializationContext context)
		{
			LiquidTechnologies.Runtime.Net45.XmlObjectBase retVal = null;
			String elementName;
			String elementNamespaceUri;


			// Get the type name this is either 
			// from the element i.e. <Parent>... = Parent
			// or from the type i.e. <Parent xsi:type="someNS:SomeElement">... = SomeElement
			if (GetElementType(xmlParent) == "")
			{
				elementName = xmlParent.LocalName;
				elementNamespaceUri = xmlParent.NamespaceURI;
			}
			else
			{
				elementName = GetElementType(xmlParent);
				elementNamespaceUri = GetElementTypeNamespaceUri(xmlParent);
			}

			// create the appropriate object
			if (elementName == null || elementName == String.Empty)
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidParamException("The element to load has no name"); 
			else if (elementName == "absoluteExternalPositionalAccuracy" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AbsoluteExternalPositionalAccuracy();
			else if (elementName == "AbsoluteExternalPositionalAccuracyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AbsoluteExternalPositionalAccuracyType();
			else if (elementName == "abstract" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.abstract_();
			else if (elementName == "Abstract" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.abstract_();
			else if (elementName == "abstractGeneralOperationParameterRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AbstractGeneralOperationParameterRef();
			else if (elementName == "abstractGeneralOperationParameterRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AbstractGeneralOperationParameterRef_Group();
			else if (elementName == "AbstractGriddedSurfaceType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AbstractGriddedSurfaceType();
			else if (elementName == "AbstractParametricCurveSurfaceType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AbstractParametricCurveSurfaceType();
			else if (elementName == "AbstractRingPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AbstractRingPropertyType();
			else if (elementName == "AbstractRingPropertyType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AbstractRingPropertyType_Type();
			else if (elementName == "AbstractSolidType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AbstractSolidType();
			else if (elementName == "AbstractSurfaceType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AbstractSurfaceType();
			else if (elementName == "AcceptFormatsType" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.AcceptFormatsType();
			else if (elementName == "AcceptVersionsType" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.AcceptVersionsType();
			else if (elementName == "AccessConstraints" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.AccessConstraints();
			else if (elementName == "accessRights" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.AccessRights();
			else if (elementName == "Acknowledgement" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.Acknowledgement();
			else if (elementName == "Add" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Add();
			else if (elementName == "AddressType" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.AddressType();
			else if (elementName == "AffinePlacement" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AffinePlacement();
			else if (elementName == "alternative" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.Alternative();
			else if (elementName == "anchorPoint" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AnchorPoint();
			else if (elementName == "And" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.And();
			else if (elementName == "angle" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Angle();
			else if (elementName == "AngleType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AngleType();
			else if (elementName == "animate" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.Animate();
			else if (elementName == "animate" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.Animate();
			else if (elementName == "animateColor" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.AnimateColor();
			else if (elementName == "animateColor" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateColor();
			else if (elementName == "animateColorPrototype" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.AnimateColorPrototype();
			else if (elementName == "animateColorType" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateColorType();
			else if (elementName == "animateColorType_Type" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateColorType_Type();
			else if (elementName == "animateColorType_Type_Group" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateColorType_Type_Group();
			else if (elementName == "animateMotion" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.AnimateMotion();
			else if (elementName == "animateMotion" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateMotion();
			else if (elementName == "animateMotionPrototype" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.AnimateMotionPrototype();
			else if (elementName == "animateMotionType" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateMotionType();
			else if (elementName == "animateMotionType_Type" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateMotionType_Type();
			else if (elementName == "animateMotionType_Type_Group" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateMotionType_Type_Group();
			else if (elementName == "animatePrototype" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.AnimatePrototype();
			else if (elementName == "animateType" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateType();
			else if (elementName == "animateType_Type" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateType_Type();
			else if (elementName == "animateType_Type_Group" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateType_Type_Group();
			else if (elementName == "Arc" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Arc();
			else if (elementName == "ArcByBulge" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ArcByBulge();
			else if (elementName == "ArcByBulgeType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ArcByBulgeType();
			else if (elementName == "ArcByCenterPoint" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ArcByCenterPoint();
			else if (elementName == "ArcByCenterPointType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ArcByCenterPointType();
			else if (elementName == "ArcByCenterPointType_Type_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ArcByCenterPointType_Type_Choice();
			else if (elementName == "ArcByCenterPointType_Type_Choice_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ArcByCenterPointType_Type_Choice_Choice();
			else if (elementName == "ArcString" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ArcString();
			else if (elementName == "ArcStringByBulge" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ArcStringByBulge();
			else if (elementName == "ArcStringByBulgeType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ArcStringByBulgeType();
			else if (elementName == "ArcStringByBulgeType_Type_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ArcStringByBulgeType_Type_Choice();
			else if (elementName == "ArcStringByBulgeType_Type_Choice_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ArcStringByBulgeType_Type_Choice_Choice();
			else if (elementName == "ArcStringType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ArcStringType();
			else if (elementName == "ArcStringType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ArcStringType_Type();
			else if (elementName == "ArcStringType_Type_Choice_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ArcStringType_Type_Choice_Choice();
			else if (elementName == "ArcType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ArcType();
			else if (elementName == "AreaType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AreaType();
			else if (elementName == "ArithmeticOperatorsType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.ArithmeticOperatorsType();
			else if (elementName == "ArithmeticOperatorsType_Group" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.ArithmeticOperatorsType_Group();
			else if (elementName == "Array" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Array();
			else if (elementName == "ArrayType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ArrayType();
			else if (elementName == "AssociationType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AssociationType_Type();
			else if (elementName == "AssociationType_Type_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AssociationType_Type_Group();
			else if (elementName == "audience" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.Audience();
			else if (elementName == "available" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.Available();
			else if (elementName == "AvailableCRS" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.AvailableCRS();
			else if (elementName == "axisAbbrev" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AxisAbbrev();
			else if (elementName == "axisDirection" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AxisDirection();
			else if (elementName == "axisID" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.AxisID();
			else if (elementName == "Bag" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Bag();
			else if (elementName == "BagType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BagType();
			else if (elementName == "baseCRS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BaseCRS();
			else if (elementName == "baseCRS_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BaseCRS_Group();
			else if (elementName == "baseCurve" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BaseCurve();
			else if (elementName == "baseCurve_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BaseCurve_Group();
			else if (elementName == "BaseStyleDescriptorType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BaseStyleDescriptorType();
			else if (elementName == "baseSurface" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BaseSurface();
			else if (elementName == "baseSurface_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BaseSurface_Group();
			else if (elementName == "BaseUnit" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BaseUnit();
			else if (elementName == "BaseUnitType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BaseUnitType();
			else if (elementName == "BBOX" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.BBOX();
			else if (elementName == "BBOXType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.BBOXType();
			else if (elementName == "Beyond" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Beyond();
			else if (elementName == "Bezier" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Bezier();
			else if (elementName == "BezierType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BezierType();
			else if (elementName == "bibliographicCitation" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.BibliographicCitation();
			else if (elementName == "BinaryComparisonOpType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.BinaryComparisonOpType();
			else if (elementName == "BinaryLogicOpType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.BinaryLogicOpType();
			else if (elementName == "BinaryLogicOpType_Type" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.BinaryLogicOpType_Type();
			else if (elementName == "BinaryLogicOpType_Type_Group" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.BinaryLogicOpType_Type_Group();
			else if (elementName == "BinaryOperatorType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.BinaryOperatorType();
			else if (elementName == "BinarySpatialOpType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.BinarySpatialOpType();
			else if (elementName == "BinarySpatialOpType_Type_Choice" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.BinarySpatialOpType_Type_Choice();
			else if (elementName == "Boolean" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.boolean_();
			else if (elementName == "BooleanList" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BooleanList();
			else if (elementName == "BooleanPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BooleanPropertyType();
			else if (elementName == "BooleanPropertyType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BooleanPropertyType_Type();
			else if (elementName == "booleanValue" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BooleanValue();
			else if (elementName == "boundedBy" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BoundedBy();
			else if (elementName == "boundingBox" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BoundingBox();
			else if (elementName == "BoundingBox" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.BoundingBox();
			else if (elementName == "BoundingBoxType" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.BoundingBoxType();
			else if (elementName == "boundingPolygon" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BoundingPolygon();
			else if (elementName == "BriefRecord" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.BriefRecord();
			else if (elementName == "BriefRecordType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.BriefRecordType();
			else if (elementName == "BSpline" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BSpline();
			else if (elementName == "BSplineType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BSplineType();
			else if (elementName == "BSplineType_Type_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BSplineType_Type_Choice();
			else if (elementName == "BSplineType_Type_Choice_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.BSplineType_Type_Choice_Choice();
			else if (elementName == "Capabilities" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.Capabilities();
			else if (elementName == "CapabilitiesBaseType" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.CapabilitiesBaseType();
			else if (elementName == "CapabilitiesType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.CapabilitiesType();
			else if (elementName == "CartesianCS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CartesianCS();
			else if (elementName == "cartesianCSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CartesianCSRef();
			else if (elementName == "cartesianCSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CartesianCSRef_Group();
			else if (elementName == "CartesianCSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CartesianCSType();
			else if (elementName == "catalogSymbol" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CatalogSymbol();
			else if (elementName == "Category" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Category();
			else if (elementName == "CategoryExtent" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CategoryExtent();
			else if (elementName == "CategoryExtentType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CategoryExtentType();
			else if (elementName == "CategoryList" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CategoryList();
			else if (elementName == "CategoryPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CategoryPropertyType();
			else if (elementName == "CategoryPropertyType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CategoryPropertyType_Type();
			else if (elementName == "centerLineOf" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CenterLineOf();
			else if (elementName == "centerLineOf_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CenterLineOf_Group();
			else if (elementName == "centerOf" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CenterOf();
			else if (elementName == "centerOf_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CenterOf_Group();
			else if (elementName == "Circle" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Circle();
			else if (elementName == "CircleByCenterPoint" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CircleByCenterPoint();
			else if (elementName == "CircleByCenterPointType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CircleByCenterPointType();
			else if (elementName == "CircleType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CircleType();
			else if (elementName == "Clothoid" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Clothoid();
			else if (elementName == "ClothoidType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ClothoidType();
			else if (elementName == "CodeOrNullListType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CodeOrNullListType();
			else if (elementName == "CodeType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CodeType();
			else if (elementName == "CodeType" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.CodeType();
			else if (elementName == "columnIndex" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ColumnIndex();
			else if (elementName == "ComparisonOperatorsType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.ComparisonOperatorsType();
			else if (elementName == "CompassPoint" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CompassPoint();
			else if (elementName == "CompositeCurve" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CompositeCurve();
			else if (elementName == "CompositeCurveType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CompositeCurveType();
			else if (elementName == "CompositeSolid" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CompositeSolid();
			else if (elementName == "CompositeSolidType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CompositeSolidType();
			else if (elementName == "CompositeSurface" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CompositeSurface();
			else if (elementName == "CompositeSurfaceType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CompositeSurfaceType();
			else if (elementName == "CompositeValue" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CompositeValue();
			else if (elementName == "CompositeValueType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CompositeValueType();
			else if (elementName == "CompoundCRS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CompoundCRS();
			else if (elementName == "compoundCRSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CompoundCRSRef();
			else if (elementName == "compoundCRSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CompoundCRSRef_Group();
			else if (elementName == "CompoundCRSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CompoundCRSType();
			else if (elementName == "ConcatenatedOperation" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ConcatenatedOperation();
			else if (elementName == "concatenatedOperationRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ConcatenatedOperationRef();
			else if (elementName == "concatenatedOperationRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ConcatenatedOperationRef_Group();
			else if (elementName == "ConcatenatedOperationType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ConcatenatedOperationType();
			else if (elementName == "ConceptualSchemeType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.ConceptualSchemeType();
			else if (elementName == "Cone" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Cone();
			else if (elementName == "ConeType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ConeType();
			else if (elementName == "conformsTo" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.ConformsTo();
			else if (elementName == "Constraint" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.Constraint();
			else if (elementName == "ContactInfo" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.ContactInfo();
			else if (elementName == "container" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Container();
			else if (elementName == "container_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Container_Group();
			else if (elementName == "Contains" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Contains();
			else if (elementName == "contributor" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Contributor();
			else if (elementName == "controlPoint" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ControlPoint();
			else if (elementName == "controlPoint_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ControlPoint_Choice();
			else if (elementName == "ConventionalUnit" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ConventionalUnit();
			else if (elementName == "ConventionalUnitType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ConventionalUnitType();
			else if (elementName == "ConventionalUnitType_Type_Seq_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ConventionalUnitType_Type_Seq_Choice();
			else if (elementName == "Conversion" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Conversion();
			else if (elementName == "conversionRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ConversionRef();
			else if (elementName == "conversionRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ConversionRef_Group();
			else if (elementName == "conversionToPreferredUnit" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ConversionToPreferredUnit();
			else if (elementName == "ConversionToPreferredUnitType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ConversionToPreferredUnitType();
			else if (elementName == "ConversionToPreferredUnitType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ConversionToPreferredUnitType_Type();
			else if (elementName == "ConversionType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ConversionType();
			else if (elementName == "coord" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Coord();
			else if (elementName == "coordinateOperationID" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CoordinateOperationID();
			else if (elementName == "coordinateOperationName" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CoordinateOperationName();
			else if (elementName == "coordinateOperationRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CoordinateOperationRef();
			else if (elementName == "coordinateOperationRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CoordinateOperationRef_Group();
			else if (elementName == "coordinateReferenceSystemRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CoordinateReferenceSystemRef();
			else if (elementName == "coordinateReferenceSystemRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CoordinateReferenceSystemRef_Group();
			else if (elementName == "coordinates" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Coordinates();
			else if (elementName == "CoordinateSystemAxis" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CoordinateSystemAxis();
			else if (elementName == "coordinateSystemAxisRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CoordinateSystemAxisRef();
			else if (elementName == "coordinateSystemAxisRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CoordinateSystemAxisRef_Group();
			else if (elementName == "CoordinateSystemAxisType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CoordinateSystemAxisType();
			else if (elementName == "coordinateSystemRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CoordinateSystemRef();
			else if (elementName == "coordinateSystemRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CoordinateSystemRef_Group();
			else if (elementName == "Count" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Count();
			else if (elementName == "CountExtent" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CountExtent();
			else if (elementName == "CountList" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CountList();
			else if (elementName == "CountPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CountPropertyType();
			else if (elementName == "CountPropertyType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CountPropertyType_Type();
			else if (elementName == "covariance" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Covariance();
			else if (elementName == "covarianceMatrix" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CovarianceMatrix();
			else if (elementName == "CovarianceMatrixType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CovarianceMatrixType();
			else if (elementName == "coverage" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Coverage();
			else if (elementName == "coverageFunction" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CoverageFunction();
			else if (elementName == "created" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.Created();
			else if (elementName == "creator" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Creator();
			else if (elementName == "Crosses" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Crosses();
			else if (elementName == "crsRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CrsRef();
			else if (elementName == "crsRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CrsRef_Group();
			else if (elementName == "csID" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CsID();
			else if (elementName == "csName" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CsName();
			else if (elementName == "CubicSpline" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CubicSpline();
			else if (elementName == "CubicSplineType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CubicSplineType();
			else if (elementName == "CubicSplineType_Type_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CubicSplineType_Type_Choice();
			else if (elementName == "CubicSplineType_Type_Choice_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CubicSplineType_Type_Choice_Choice();
			else if (elementName == "Curve" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Curve();
			else if (elementName == "curveArrayProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CurveArrayProperty();
			else if (elementName == "curveMember" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CurveMember();
			else if (elementName == "curveMember_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CurveMember_Group();
			else if (elementName == "curveMembers" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CurveMembers();
			else if (elementName == "curveProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CurveProperty();
			else if (elementName == "curveProperty_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CurveProperty_Group();
			else if (elementName == "CurvePropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CurvePropertyType();
			else if (elementName == "CurvePropertyType_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CurvePropertyType_Group();
			else if (elementName == "CurveType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CurveType();
			else if (elementName == "Cylinder" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Cylinder();
			else if (elementName == "CylinderType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CylinderType();
			else if (elementName == "CylindricalCS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CylindricalCS();
			else if (elementName == "cylindricalCSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CylindricalCSRef();
			else if (elementName == "cylindricalCSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CylindricalCSRef_Group();
			else if (elementName == "CylindricalCSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.CylindricalCSType();
			else if (elementName == "DataBlock" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DataBlock();
			else if (elementName == "DataBlock_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DataBlock_Choice();
			else if (elementName == "dataSource" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DataSource();
			else if (elementName == "date" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Date();
			else if (elementName == "dateAccepted" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.DateAccepted();
			else if (elementName == "dateCopyrighted" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.DateCopyrighted();
			else if (elementName == "dateSubmitted" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.DateSubmitted();
			else if (elementName == "datumID" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DatumID();
			else if (elementName == "datumName" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DatumName();
			else if (elementName == "datumRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DatumRef();
			else if (elementName == "datumRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DatumRef_Group();
			else if (elementName == "DCMIRecord" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.DCMIRecord();
			else if (elementName == "DCMIRecordType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.DCMIRecordType();
			else if (elementName == "DCP" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.DCP();
			else if (elementName == "decimalMinutes" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DecimalMinutes();
			else if (elementName == "defaultStyle" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DefaultStyle();
			else if (elementName == "definedByConversion" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DefinedByConversion();
			else if (elementName == "definedByConversion_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DefinedByConversion_Group();
			else if (elementName == "Definition" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Definition();
			else if (elementName == "DefinitionCollection" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DefinitionCollection();
			else if (elementName == "definitionMember" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DefinitionMember();
			else if (elementName == "DefinitionProxy" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DefinitionProxy();
			else if (elementName == "DefinitionProxyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DefinitionProxyType();
			else if (elementName == "definitionRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DefinitionRef();
			else if (elementName == "DefinitionType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DefinitionType();
			else if (elementName == "degrees" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Degrees();
			else if (elementName == "DeleteType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.DeleteType();
			else if (elementName == "derivationUnitTerm" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DerivationUnitTerm();
			else if (elementName == "DerivationUnitTermType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DerivationUnitTermType();
			else if (elementName == "DerivedCRS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DerivedCRS();
			else if (elementName == "derivedCRSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DerivedCRSRef();
			else if (elementName == "derivedCRSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DerivedCRSRef_Group();
			else if (elementName == "derivedCRSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DerivedCRSType();
			else if (elementName == "DerivedCRSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DerivedCRSTypeA();
			else if (elementName == "DerivedCRSTypeType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DerivedCRSTypeType();
			else if (elementName == "DerivedUnit" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DerivedUnit();
			else if (elementName == "DerivedUnitType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DerivedUnitType();
			else if (elementName == "DescribeRecord" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.DescribeRecord();
			else if (elementName == "DescribeRecordResponse" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.DescribeRecordResponse();
			else if (elementName == "DescribeRecordType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.DescribeRecordType();
			else if (elementName == "description" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Description();
			else if (elementName == "description" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Description();
			else if (elementName == "DescriptionType" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.DescriptionType();
			else if (elementName == "Dictionary" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Dictionary();
			else if (elementName == "dictionaryEntry" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DictionaryEntry();
			else if (elementName == "DictionaryEntryType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DictionaryEntryType();
			else if (elementName == "DictionaryEntryType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DictionaryEntryType_Type();
			else if (elementName == "DictionaryEntryType_Type_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DictionaryEntryType_Type_Group();
			else if (elementName == "DictionaryType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DictionaryType();
			else if (elementName == "DictionaryType_Type_Seq" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DictionaryType_Type_Seq();
			else if (elementName == "directedEdge" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DirectedEdge();
			else if (elementName == "directedEdge_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DirectedEdge_Group();
			else if (elementName == "directedFace" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DirectedFace();
			else if (elementName == "directedFace_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DirectedFace_Group();
			else if (elementName == "directedNode" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DirectedNode();
			else if (elementName == "directedNode_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DirectedNode_Group();
			else if (elementName == "DirectedObservation" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DirectedObservation();
			else if (elementName == "DirectedObservationAtDistance" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DirectedObservationAtDistance();
			else if (elementName == "DirectedObservationAtDistanceType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DirectedObservationAtDistanceType();
			else if (elementName == "DirectedObservationType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DirectedObservationType();
			else if (elementName == "directedTopoSolid" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DirectedTopoSolid();
			else if (elementName == "directedTopoSolid_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DirectedTopoSolid_Group();
			else if (elementName == "direction" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Direction();
			else if (elementName == "DirectionPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DirectionPropertyType();
			else if (elementName == "DirectionVector" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DirectionVector();
			else if (elementName == "DirectionVector_Seq" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DirectionVector_Seq();
			else if (elementName == "DirectPositionType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DirectPositionType();
			else if (elementName == "Disjoint" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Disjoint();
			else if (elementName == "DistanceBufferType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.DistanceBufferType();
			else if (elementName == "DistanceType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.DistanceType();
			else if (elementName == "DistributedSearchType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.DistributedSearchType();
			else if (elementName == "Div" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Div();
			else if (elementName == "dmsAngle" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DmsAngle();
			else if (elementName == "dmsAngleValue" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DmsAngleValue();
			else if (elementName == "dmsAngleValue_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DmsAngleValue_Choice();
			else if (elementName == "dmsAngleValue_Choice_Seq" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DmsAngleValue_Choice_Seq();
			else if (elementName == "domainSet" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DomainSet();
			else if (elementName == "DomainSetType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DomainSetType();
			else if (elementName == "DomainSetType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DomainSetType_Type();
			else if (elementName == "DomainSetType_Type_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DomainSetType_Type_Group();
			else if (elementName == "DomainType" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.DomainType();
			else if (elementName == "DomainValuesType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.DomainValuesType();
			else if (elementName == "DomainValuesType_Choice" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.DomainValuesType_Choice();
			else if (elementName == "DomainValuesType_ChoiceA" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.DomainValuesType_ChoiceA();
			else if (elementName == "doubleOrNullTupleList" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DoubleOrNullTupleList();
			else if (elementName == "duration" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Duration();
			else if (elementName == "DWithin" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.DWithin();
			else if (elementName == "DynamicFeatureCollectionType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DynamicFeatureCollectionType();
			else if (elementName == "DynamicFeatureType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.DynamicFeatureType();
			else if (elementName == "EchoedRequestType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.EchoedRequestType();
			else if (elementName == "Edge" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Edge();
			else if (elementName == "edgeOf" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EdgeOf();
			else if (elementName == "edgeOf_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EdgeOf_Group();
			else if (elementName == "EdgeType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EdgeType();
			else if (elementName == "educationLevel" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.EducationLevel();
			else if (elementName == "EID" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.EID();
			else if (elementName == "ElementSetName" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.ElementSetName();
			else if (elementName == "Ellipsoid" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Ellipsoid();
			else if (elementName == "EllipsoidalCS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EllipsoidalCS();
			else if (elementName == "ellipsoidalCSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EllipsoidalCSRef();
			else if (elementName == "ellipsoidalCSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EllipsoidalCSRef_Group();
			else if (elementName == "EllipsoidalCSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EllipsoidalCSType();
			else if (elementName == "ellipsoidID" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EllipsoidID();
			else if (elementName == "ellipsoidName" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EllipsoidName();
			else if (elementName == "ellipsoidRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EllipsoidRef();
			else if (elementName == "ellipsoidRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EllipsoidRef_Group();
			else if (elementName == "EllipsoidType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EllipsoidType();
			else if (elementName == "EmptyType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.EmptyType();
			else if (elementName == "EngineeringCRS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EngineeringCRS();
			else if (elementName == "engineeringCRSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EngineeringCRSRef();
			else if (elementName == "engineeringCRSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EngineeringCRSRef_Group();
			else if (elementName == "EngineeringCRSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EngineeringCRSType();
			else if (elementName == "EngineeringDatum" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EngineeringDatum();
			else if (elementName == "engineeringDatumRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EngineeringDatumRef();
			else if (elementName == "engineeringDatumRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EngineeringDatumRef_Group();
			else if (elementName == "EngineeringDatumType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EngineeringDatumType();
			else if (elementName == "Envelope" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Envelope();
			else if (elementName == "EnvelopeType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EnvelopeType();
			else if (elementName == "EnvelopeType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EnvelopeType_Type();
			else if (elementName == "EnvelopeType_Type_Seq" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EnvelopeType_Type_Seq();
			else if (elementName == "EnvelopeWithTimePeriod" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EnvelopeWithTimePeriod();
			else if (elementName == "EnvelopeWithTimePeriodType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EnvelopeWithTimePeriodType();
			else if (elementName == "EnvelopeWithTimePeriodType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.EnvelopeWithTimePeriodType_Type();
			else if (elementName == "Equals" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Equals();
			else if (elementName == "Exception" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.Exception();
			else if (elementName == "ExceptionReport" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.ExceptionReport();
			else if (elementName == "ExtendedCapabilities" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.ExtendedCapabilities();
			else if (elementName == "extent" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.Extent();
			else if (elementName == "extentOf" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ExtentOf();
			else if (elementName == "extentOf_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ExtentOf_Group();
			else if (elementName == "exterior" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Exterior();
			else if (elementName == "Face" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Face();
			else if (elementName == "FaceType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.FaceType();
			else if (elementName == "FeatureCollection" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.FeatureCollection();
			else if (elementName == "FeatureCollectionType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.FeatureCollectionType();
			else if (elementName == "FeatureId" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.FeatureId();
			else if (elementName == "FeatureIdType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.FeatureIdType();
			else if (elementName == "featureMember" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.FeatureMember();
			else if (elementName == "featureMember_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.FeatureMember_Group();
			else if (elementName == "featureMembers" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.FeatureMembers();
			else if (elementName == "featureProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.FeatureProperty();
			else if (elementName == "featureProperty_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.FeatureProperty_Group();
			else if (elementName == "featureStyle" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.FeatureStyle();
			else if (elementName == "FeatureStyle" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.FeatureStyleA();
			else if (elementName == "FeatureStyleType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.FeatureStyleType();
			else if (elementName == "Fees" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.Fees();
			else if (elementName == "FID" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.FID();
			else if (elementName == "File" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.File();
			else if (elementName == "Filter" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Filter();
			else if (elementName == "Filter_Capabilities" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Filter_Capabilities();
			else if (elementName == "format" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Format();
			else if (elementName == "FormulaType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.FormulaType();
			else if (elementName == "Function" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Function();
			else if (elementName == "FunctionNamesType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.FunctionNamesType();
			else if (elementName == "FunctionNameType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.FunctionNameType();
			else if (elementName == "FunctionsType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.FunctionsType();
			else if (elementName == "FunctionType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.FunctionType();
			else if (elementName == "generalConversionRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeneralConversionRef();
			else if (elementName == "generalConversionRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeneralConversionRef_Group();
			else if (elementName == "generalTransformationRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeneralTransformationRef();
			else if (elementName == "generalTransformationRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeneralTransformationRef_Group();
			else if (elementName == "GenericMetaData" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GenericMetaData();
			else if (elementName == "GenericMetaDataType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GenericMetaDataType();
			else if (elementName == "GeocentricCRS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeocentricCRS();
			else if (elementName == "geocentricCRSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeocentricCRSRef();
			else if (elementName == "geocentricCRSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeocentricCRSRef_Group();
			else if (elementName == "GeocentricCRSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeocentricCRSType();
			else if (elementName == "GeocentricCRSType_Type_Seq_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeocentricCRSType_Type_Seq_Choice();
			else if (elementName == "Geodesic" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Geodesic();
			else if (elementName == "GeodesicString" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeodesicString();
			else if (elementName == "GeodesicStringType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeodesicStringType();
			else if (elementName == "GeodesicStringType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeodesicStringType_Type();
			else if (elementName == "GeodesicStringType_Type_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeodesicStringType_Type_Choice();
			else if (elementName == "GeodesicType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeodesicType();
			else if (elementName == "GeodeticDatum" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeodeticDatum();
			else if (elementName == "geodeticDatumRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeodeticDatumRef();
			else if (elementName == "geodeticDatumRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeodeticDatumRef_Group();
			else if (elementName == "GeodeticDatumType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeodeticDatumType();
			else if (elementName == "GeographicCRS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeographicCRS();
			else if (elementName == "geographicCRSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeographicCRSRef();
			else if (elementName == "geographicCRSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeographicCRSRef_Group();
			else if (elementName == "GeographicCRSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeographicCRSType();
			else if (elementName == "GeometricComplex" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeometricComplex();
			else if (elementName == "GeometricComplexType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeometricComplexType();
			else if (elementName == "GeometricPrimitivePropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeometricPrimitivePropertyType();
			else if (elementName == "GeometricPrimitivePropertyType_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeometricPrimitivePropertyType_Group();
			else if (elementName == "geometryMember" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeometryMember();
			else if (elementName == "geometryMember_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeometryMember_Group();
			else if (elementName == "geometryMembers" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeometryMembers();
			else if (elementName == "GeometryOperandsType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.GeometryOperandsType();
			else if (elementName == "geometryStyle" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeometryStyle();
			else if (elementName == "GeometryStyle" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeometryStyleA();
			else if (elementName == "GeometryStyleType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeometryStyleType();
			else if (elementName == "GeometryStyleType_Type_Seq_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GeometryStyleType_Type_Seq_Choice();
			else if (elementName == "GetCapabilities" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetCapabilities();
			else if (elementName == "GetCapabilities" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.GetCapabilities();
			else if (elementName == "GetCapabilitiesType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetCapabilitiesType();
			else if (elementName == "GetCapabilitiesType" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.GetCapabilitiesType();
			else if (elementName == "GetDomain" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetDomain();
			else if (elementName == "GetDomainResponse" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetDomainResponse();
			else if (elementName == "GetDomainType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetDomainType();
			else if (elementName == "GetDomainType_Type" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetDomainType_Type();
			else if (elementName == "GetRecordById" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetRecordById();
			else if (elementName == "GetRecordByIdResponse" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetRecordByIdResponse();
			else if (elementName == "GetRecordByIdResponse_Choice" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetRecordByIdResponse_Choice();
			else if (elementName == "GetRecordByIdType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetRecordByIdType();
			else if (elementName == "GetRecords" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetRecords();
			else if (elementName == "GetRecordsResponse" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetRecordsResponse();
			else if (elementName == "GetRecordsType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetRecordsType();
			else if (elementName == "GetRecordsType_Type_Choice" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetRecordsType_Type_Choice();
			else if (elementName == "GmlObjectId" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.GmlObjectId();
			else if (elementName == "GmlObjectIdType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.GmlObjectIdType();
			else if (elementName == "graphStyle" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GraphStyle();
			else if (elementName == "GraphStyle" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GraphStyleA();
			else if (elementName == "GraphStyleType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GraphStyleType();
			else if (elementName == "greenwichLongitude" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GreenwichLongitude();
			else if (elementName == "Grid" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Grid();
			else if (elementName == "GridCoverage" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GridCoverage();
			else if (elementName == "GridCoverageType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GridCoverageType();
			else if (elementName == "gridDomain" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GridDomain();
			else if (elementName == "GridDomainType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GridDomainType();
			else if (elementName == "GridDomainType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GridDomainType_Type();
			else if (elementName == "GridEnvelopeType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GridEnvelopeType();
			else if (elementName == "GridFunction" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GridFunction();
			else if (elementName == "GridFunctionType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GridFunctionType();
			else if (elementName == "GridLengthType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GridLengthType();
			else if (elementName == "GridLimitsType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GridLimitsType();
			else if (elementName == "GridType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GridType();
			else if (elementName == "groupID" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GroupID();
			else if (elementName == "groupName" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.GroupName();
			else if (elementName == "Harvest" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.Harvest();
			else if (elementName == "HarvestResponse" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.HarvestResponse();
			else if (elementName == "HarvestType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.HarvestType();
			else if (elementName == "hasFormat" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.HasFormat();
			else if (elementName == "hasPart" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.HasPart();
			else if (elementName == "hasVersion" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.HasVersion();
			else if (elementName == "history" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.History();
			else if (elementName == "HistoryPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.HistoryPropertyType();
			else if (elementName == "HistoryPropertyType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.HistoryPropertyType_Type();
			else if (elementName == "HistoryPropertyType_Type_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.HistoryPropertyType_Type_Group();
			else if (elementName == "HTTP" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.HTTP();
			else if (elementName == "HTTP_Group" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.HTTP_Group();
			else if (elementName == "Id_CapabilitiesType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Id_CapabilitiesType();
			else if (elementName == "Id_CapabilitiesType_Group" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Id_CapabilitiesType_Group();
			else if (elementName == "IdentificationType" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.IdentificationType();
			else if (elementName == "identifier" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Identifier();
			else if (elementName == "Identifier" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.Identifier();
			else if (elementName == "ImageCRS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ImageCRS();
			else if (elementName == "imageCRSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ImageCRSRef();
			else if (elementName == "imageCRSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ImageCRSRef_Group();
			else if (elementName == "ImageCRSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ImageCRSType();
			else if (elementName == "ImageCRSType_Type_Seq_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ImageCRSType_Type_Seq_Choice();
			else if (elementName == "ImageDatum" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ImageDatum();
			else if (elementName == "imageDatumRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ImageDatumRef();
			else if (elementName == "imageDatumRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ImageDatumRef_Group();
			else if (elementName == "ImageDatumType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ImageDatumType();
			else if (elementName == "includesCRS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.IncludesCRS();
			else if (elementName == "includesCRS_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.IncludesCRS_Group();
			else if (elementName == "includesElement" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.IncludesElement();
			else if (elementName == "includesParameter" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.IncludesParameter();
			else if (elementName == "includesParameter_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.IncludesParameter_Group();
			else if (elementName == "includesValue" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.IncludesValue();
			else if (elementName == "IndexMap" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.IndexMap();
			else if (elementName == "IndexMapType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.IndexMapType();
			else if (elementName == "indirectEntry" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.IndirectEntry();
			else if (elementName == "IndividualName" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.IndividualName();
			else if (elementName == "innerBoundaryIs" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.InnerBoundaryIs();
			else if (elementName == "InsertResultType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.InsertResultType();
			else if (elementName == "InsertType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.InsertType();
			else if (elementName == "integerValue" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.IntegerValue();
			else if (elementName == "integerValueList" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.IntegerValueList();
			else if (elementName == "interior" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Interior();
			else if (elementName == "Intersects" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Intersects();
			else if (elementName == "inverseFlattening" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.InverseFlattening();
			else if (elementName == "isFormatOf" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.IsFormatOf();
			else if (elementName == "isolated" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Isolated();
			else if (elementName == "isolated_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Isolated_Group();
			else if (elementName == "isPartOf" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.IsPartOf();
			else if (elementName == "isReferencedBy" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.IsReferencedBy();
			else if (elementName == "isReplacedBy" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.IsReplacedBy();
			else if (elementName == "isRequiredBy" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.IsRequiredBy();
			else if (elementName == "isSphere" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.IsSphere();
			else if (elementName == "issued" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.Issued();
			else if (elementName == "isVersionOf" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.IsVersionOf();
			else if (elementName == "Keywords" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.Keywords();
			else if (elementName == "KnotPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.KnotPropertyType();
			else if (elementName == "KnotType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.KnotType();
			else if (elementName == "labelStyle" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LabelStyle();
			else if (elementName == "LabelStyle" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LabelStyleA();
			else if (elementName == "LabelStyleType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LabelStyleType();
			else if (elementName == "LabelType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LabelType();
			else if (elementName == "language" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Language();
			else if (elementName == "Language" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.Language();
			else if (elementName == "LengthType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LengthType();
			else if (elementName == "license" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.License();
			else if (elementName == "LinearCS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LinearCS();
			else if (elementName == "linearCSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LinearCSRef();
			else if (elementName == "linearCSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LinearCSRef_Group();
			else if (elementName == "LinearCSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LinearCSType();
			else if (elementName == "LinearRing" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LinearRing();
			else if (elementName == "LinearRingType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LinearRingType();
			else if (elementName == "LinearRingType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LinearRingType_Type();
			else if (elementName == "LinearRingType_Type_Seq_Choice_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LinearRingType_Type_Seq_Choice_Choice();
			else if (elementName == "LineString" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LineString();
			else if (elementName == "lineStringMember" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LineStringMember();
			else if (elementName == "lineStringMember_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LineStringMember_Group();
			else if (elementName == "lineStringProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LineStringProperty();
			else if (elementName == "lineStringProperty_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LineStringProperty_Group();
			else if (elementName == "LineStringSegment" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LineStringSegment();
			else if (elementName == "LineStringSegmentArrayPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LineStringSegmentArrayPropertyType();
			else if (elementName == "LineStringSegmentType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LineStringSegmentType();
			else if (elementName == "LineStringSegmentType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LineStringSegmentType_Type();
			else if (elementName == "LineStringSegmentType_Type_Choice_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LineStringSegmentType_Type_Choice_Choice();
			else if (elementName == "LineStringType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LineStringType();
			else if (elementName == "LineStringType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LineStringType_Type();
			else if (elementName == "LineStringType_Type_Seq_Choice_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LineStringType_Type_Seq_Choice_Choice();
			else if (elementName == "ListOfValuesType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.ListOfValuesType();
			else if (elementName == "Literal" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Literal();
			else if (elementName == "LiteralType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.LiteralType();
			else if (elementName == "location" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Location();
			else if (elementName == "LocationKeyWord" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LocationKeyWord();
			else if (elementName == "LocationPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LocationPropertyType();
			else if (elementName == "LocationPropertyType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LocationPropertyType_Type();
			else if (elementName == "LocationPropertyType_Type_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LocationPropertyType_Type_Group();
			else if (elementName == "LocationString" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.LocationString();
			else if (elementName == "LogicalOperators" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.LogicalOperators();
			else if (elementName == "LowerBoundaryType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.LowerBoundaryType();
			else if (elementName == "MappingRule" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MappingRule();
			else if (elementName == "maximalComplex" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MaximalComplex();
			else if (elementName == "maximumOccurs" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MaximumOccurs();
			else if (elementName == "measure" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Measure();
			else if (elementName == "measureDescription" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MeasureDescription();
			else if (elementName == "MeasureOrNullListType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MeasureOrNullListType();
			else if (elementName == "MeasureType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MeasureType();
			else if (elementName == "mediator" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.Mediator();
			else if (elementName == "medium" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.Medium();
			else if (elementName == "member" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Member();
			else if (elementName == "member_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Member_Group();
			else if (elementName == "members" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Members();
			else if (elementName == "meridianID" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MeridianID();
			else if (elementName == "meridianName" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MeridianName();
			else if (elementName == "Metadata" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.Metadata();
			else if (elementName == "metaDataProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MetaDataProperty();
			else if (elementName == "metaDataProperty_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MetaDataProperty_Group();
			else if (elementName == "methodFormula" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MethodFormula();
			else if (elementName == "methodID" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MethodID();
			else if (elementName == "methodName" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MethodName();
			else if (elementName == "minimumOccurs" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MinimumOccurs();
			else if (elementName == "minutes" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Minutes();
			else if (elementName == "modified" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.Modified();
			else if (elementName == "modifiedCoordinate" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ModifiedCoordinate();
			else if (elementName == "MovingObjectStatus" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MovingObjectStatus();
			else if (elementName == "MovingObjectStatusType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MovingObjectStatusType();
			else if (elementName == "Mul" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Mul();
			else if (elementName == "multiCenterLineOf" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiCenterLineOf();
			else if (elementName == "multiCenterLineOf_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiCenterLineOf_Group();
			else if (elementName == "multiCenterOf" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiCenterOf();
			else if (elementName == "multiCenterOf_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiCenterOf_Group();
			else if (elementName == "multiCoverage" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiCoverage();
			else if (elementName == "multiCoverage_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiCoverage_Group();
			else if (elementName == "MultiCurve" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiCurve();
			else if (elementName == "MultiCurveCoverage" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiCurveCoverage();
			else if (elementName == "MultiCurveCoverageType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiCurveCoverageType();
			else if (elementName == "multiCurveDomain" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiCurveDomain();
			else if (elementName == "MultiCurveDomainType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiCurveDomainType();
			else if (elementName == "MultiCurveDomainType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiCurveDomainType_Type();
			else if (elementName == "multiCurveProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiCurveProperty();
			else if (elementName == "multiCurveProperty_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiCurveProperty_Group();
			else if (elementName == "MultiCurveType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiCurveType();
			else if (elementName == "multiEdgeOf" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiEdgeOf();
			else if (elementName == "multiEdgeOf_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiEdgeOf_Group();
			else if (elementName == "multiExtentOf" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiExtentOf();
			else if (elementName == "multiExtentOf_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiExtentOf_Group();
			else if (elementName == "MultiGeometry" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiGeometry();
			else if (elementName == "multiGeometryProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiGeometryProperty();
			else if (elementName == "multiGeometryProperty_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiGeometryProperty_Group();
			else if (elementName == "MultiGeometryType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiGeometryType();
			else if (elementName == "MultiLineString" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiLineString();
			else if (elementName == "MultiLineStringType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiLineStringType();
			else if (elementName == "multiLocation" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiLocation();
			else if (elementName == "multiLocation_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiLocation_Group();
			else if (elementName == "MultiPoint" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiPoint();
			else if (elementName == "MultiPointCoverage" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiPointCoverage();
			else if (elementName == "MultiPointCoverageType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiPointCoverageType();
			else if (elementName == "multiPointDomain" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiPointDomain();
			else if (elementName == "MultiPointDomainType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiPointDomainType();
			else if (elementName == "MultiPointDomainType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiPointDomainType_Type();
			else if (elementName == "multiPointProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiPointProperty();
			else if (elementName == "multiPointProperty_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiPointProperty_Group();
			else if (elementName == "MultiPointType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiPointType();
			else if (elementName == "MultiPolygon" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiPolygon();
			else if (elementName == "MultiPolygonType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiPolygonType();
			else if (elementName == "multiPosition" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiPosition();
			else if (elementName == "multiPosition_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiPosition_Group();
			else if (elementName == "MultiSolid" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiSolid();
			else if (elementName == "MultiSolidCoverage" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiSolidCoverage();
			else if (elementName == "MultiSolidCoverageType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiSolidCoverageType();
			else if (elementName == "multiSolidDomain" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiSolidDomain();
			else if (elementName == "MultiSolidDomainType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiSolidDomainType();
			else if (elementName == "MultiSolidDomainType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiSolidDomainType_Type();
			else if (elementName == "multiSolidProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiSolidProperty();
			else if (elementName == "multiSolidProperty_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiSolidProperty_Group();
			else if (elementName == "MultiSolidType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiSolidType();
			else if (elementName == "MultiSurface" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiSurface();
			else if (elementName == "MultiSurfaceCoverage" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiSurfaceCoverage();
			else if (elementName == "MultiSurfaceCoverageType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiSurfaceCoverageType();
			else if (elementName == "multiSurfaceDomain" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiSurfaceDomain();
			else if (elementName == "MultiSurfaceDomainType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiSurfaceDomainType();
			else if (elementName == "MultiSurfaceDomainType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiSurfaceDomainType_Type();
			else if (elementName == "multiSurfaceProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiSurfaceProperty();
			else if (elementName == "multiSurfaceProperty_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiSurfaceProperty_Group();
			else if (elementName == "MultiSurfaceType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.MultiSurfaceType();
			else if (elementName == "name" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Name();
			else if (elementName == "Node" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Node();
			else if (elementName == "NodeType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.NodeType();
			else if (elementName == "Not" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Not();
			else if (elementName == "Null" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.null_();
			else if (elementName == "ObliqueCartesianCS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ObliqueCartesianCS();
			else if (elementName == "obliqueCartesianCSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ObliqueCartesianCSRef();
			else if (elementName == "obliqueCartesianCSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ObliqueCartesianCSRef_Group();
			else if (elementName == "ObliqueCartesianCSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ObliqueCartesianCSType();
			else if (elementName == "Observation" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Observation();
			else if (elementName == "ObservationType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ObservationType();
			else if (elementName == "OffsetCurve" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OffsetCurve();
			else if (elementName == "OffsetCurveType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OffsetCurveType();
			else if (elementName == "OnlineResourceType" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.OnlineResourceType();
			else if (elementName == "Operation" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.Operation();
			else if (elementName == "OperationMethod" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OperationMethod();
			else if (elementName == "operationMethodRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OperationMethodRef();
			else if (elementName == "operationMethodRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OperationMethodRef_Group();
			else if (elementName == "OperationMethodType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OperationMethodType();
			else if (elementName == "OperationParameter" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OperationParameter();
			else if (elementName == "OperationParameterGroup" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OperationParameterGroup();
			else if (elementName == "operationParameterGroupRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OperationParameterGroupRef();
			else if (elementName == "operationParameterGroupRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OperationParameterGroupRef_Group();
			else if (elementName == "OperationParameterGroupType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OperationParameterGroupType();
			else if (elementName == "operationParameterRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OperationParameterRef();
			else if (elementName == "operationParameterRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OperationParameterRef_Group();
			else if (elementName == "OperationParameterType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OperationParameterType();
			else if (elementName == "operationRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OperationRef();
			else if (elementName == "operationRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OperationRef_Group();
			else if (elementName == "OperationsMetadata" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.OperationsMetadata();
			else if (elementName == "operationVersion" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OperationVersion();
			else if (elementName == "Or" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Or();
			else if (elementName == "OrganisationName" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.OrganisationName();
			else if (elementName == "OrientableCurve" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OrientableCurve();
			else if (elementName == "OrientableCurveType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OrientableCurveType();
			else if (elementName == "OrientableSurface" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OrientableSurface();
			else if (elementName == "OrientableSurfaceType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OrientableSurfaceType();
			else if (elementName == "origin" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Origin();
			else if (elementName == "outerBoundaryIs" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.OuterBoundaryIs();
			else if (elementName == "OutputFormat" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.OutputFormat();
			else if (elementName == "Overlaps" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Overlaps();
			else if (elementName == "parameterID" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ParameterID();
			else if (elementName == "parameterName" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ParameterName();
			else if (elementName == "parameterValue" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ParameterValue();
			else if (elementName == "parameterValueGroup" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ParameterValueGroup();
			else if (elementName == "ParameterValueGroupType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ParameterValueGroupType();
			else if (elementName == "ParameterValueType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ParameterValueType();
			else if (elementName == "ParameterValueType_Type_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ParameterValueType_Type_Choice();
			else if (elementName == "PassThroughOperation" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PassThroughOperation();
			else if (elementName == "passThroughOperationRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PassThroughOperationRef();
			else if (elementName == "passThroughOperationRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PassThroughOperationRef_Group();
			else if (elementName == "PassThroughOperationType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PassThroughOperationType();
			else if (elementName == "patches" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Patches();
			else if (elementName == "pixelInCell" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PixelInCell();
			else if (elementName == "PixelInCellType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PixelInCellType();
			else if (elementName == "Point" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Point();
			else if (elementName == "pointArrayProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PointArrayProperty();
			else if (elementName == "pointMember" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PointMember();
			else if (elementName == "pointMember_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PointMember_Group();
			else if (elementName == "pointMembers" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PointMembers();
			else if (elementName == "PointOfContact" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.PointOfContact();
			else if (elementName == "pointProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PointProperty();
			else if (elementName == "pointProperty_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PointProperty_Group();
			else if (elementName == "PointPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PointPropertyType();
			else if (elementName == "PointPropertyType_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PointPropertyType_Group();
			else if (elementName == "pointRep" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PointRep();
			else if (elementName == "pointRep_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PointRep_Group();
			else if (elementName == "PointType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PointType();
			else if (elementName == "PointType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PointType_Type();
			else if (elementName == "PolarCS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PolarCS();
			else if (elementName == "polarCSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PolarCSRef();
			else if (elementName == "polarCSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PolarCSRef_Group();
			else if (elementName == "PolarCSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PolarCSType();
			else if (elementName == "Polygon" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Polygon();
			else if (elementName == "polygonMember" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PolygonMember();
			else if (elementName == "polygonMember_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PolygonMember_Group();
			else if (elementName == "PolygonPatch" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PolygonPatch();
			else if (elementName == "PolygonPatchArrayPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PolygonPatchArrayPropertyType();
			else if (elementName == "PolygonPatchArrayPropertyType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PolygonPatchArrayPropertyType_Type();
			else if (elementName == "polygonPatches" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PolygonPatches();
			else if (elementName == "PolygonPatchType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PolygonPatchType();
			else if (elementName == "polygonProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PolygonProperty();
			else if (elementName == "polygonProperty_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PolygonProperty_Group();
			else if (elementName == "PolygonType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PolygonType();
			else if (elementName == "PolyhedralSurface" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PolyhedralSurface();
			else if (elementName == "PolyhedralSurfaceType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PolyhedralSurfaceType();
			else if (elementName == "pos" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Pos();
			else if (elementName == "position" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Position();
			else if (elementName == "position_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Position_Group();
			else if (elementName == "PositionName" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.PositionName();
			else if (elementName == "posList" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PosList();
			else if (elementName == "PrimeMeridian" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PrimeMeridian();
			else if (elementName == "primeMeridianRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PrimeMeridianRef();
			else if (elementName == "primeMeridianRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PrimeMeridianRef_Group();
			else if (elementName == "PrimeMeridianType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PrimeMeridianType();
			else if (elementName == "priorityLocation" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PriorityLocation();
			else if (elementName == "PriorityLocationPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PriorityLocationPropertyType();
			else if (elementName == "PriorityLocationPropertyType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.PriorityLocationPropertyType_Type();
			else if (elementName == "ProjectedCRS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ProjectedCRS();
			else if (elementName == "projectedCRSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ProjectedCRSRef();
			else if (elementName == "projectedCRSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ProjectedCRSRef_Group();
			else if (elementName == "ProjectedCRSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ProjectedCRSType();
			else if (elementName == "PropertyIsBetween" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsBetween();
			else if (elementName == "PropertyIsBetweenType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsBetweenType();
			else if (elementName == "PropertyIsEqualTo" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsEqualTo();
			else if (elementName == "PropertyIsGreaterThan" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsGreaterThan();
			else if (elementName == "PropertyIsGreaterThanOrEqualTo" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsGreaterThanOrEqualTo();
			else if (elementName == "PropertyIsLessThan" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsLessThan();
			else if (elementName == "PropertyIsLessThanOrEqualTo" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsLessThanOrEqualTo();
			else if (elementName == "PropertyIsLike" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsLike();
			else if (elementName == "PropertyIsLikeType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsLikeType();
			else if (elementName == "PropertyIsNotEqualTo" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsNotEqualTo();
			else if (elementName == "PropertyIsNull" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsNull();
			else if (elementName == "PropertyIsNullType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsNullType();
			else if (elementName == "PropertyName" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyName();
			else if (elementName == "PropertyNameType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyNameType();
			else if (elementName == "provenance" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.Provenance();
			else if (elementName == "publisher" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Publisher();
			else if (elementName == "Quantity" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Quantity();
			else if (elementName == "QuantityExtent" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.QuantityExtent();
			else if (elementName == "QuantityExtentType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.QuantityExtentType();
			else if (elementName == "QuantityList" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.QuantityList();
			else if (elementName == "QuantityPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.QuantityPropertyType();
			else if (elementName == "QuantityPropertyType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.QuantityPropertyType_Type();
			else if (elementName == "quantityType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.QuantityType();
			else if (elementName == "Query" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.Query();
			else if (elementName == "QueryType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.QueryType();
			else if (elementName == "QueryType_Type_Choice" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.QueryType_Type_Choice();
			else if (elementName == "RangeOfValuesType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.RangeOfValuesType();
			else if (elementName == "rangeParameters" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RangeParameters();
			else if (elementName == "rangeParameters_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RangeParameters_Group();
			else if (elementName == "rangeParameters_Group_Choice_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RangeParameters_Group_Choice_Choice();
			else if (elementName == "rangeParameters_Group_Choice_ChoiceA" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RangeParameters_Group_Choice_ChoiceA();
			else if (elementName == "rangeParameters_Group_Choice_ChoiceB" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RangeParameters_Group_Choice_ChoiceB();
			else if (elementName == "rangeSet" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RangeSet();
			else if (elementName == "rangeSet_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RangeSet_Choice();
			else if (elementName == "realizationEpoch" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RealizationEpoch();
			else if (elementName == "Record" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.Record();
			else if (elementName == "RecordProperty" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.RecordProperty();
			else if (elementName == "RecordType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.RecordType();
			else if (elementName == "Rectangle" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Rectangle();
			else if (elementName == "RectangleType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RectangleType();
			else if (elementName == "RectangleType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RectangleType_Type();
			else if (elementName == "RectifiedGrid" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RectifiedGrid();
			else if (elementName == "RectifiedGridCoverage" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RectifiedGridCoverage();
			else if (elementName == "RectifiedGridCoverageType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RectifiedGridCoverageType();
			else if (elementName == "rectifiedGridDomain" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RectifiedGridDomain();
			else if (elementName == "RectifiedGridDomainType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RectifiedGridDomainType();
			else if (elementName == "RectifiedGridDomainType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RectifiedGridDomainType_Type();
			else if (elementName == "RectifiedGridType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RectifiedGridType();
			else if (elementName == "references" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.References();
			else if (elementName == "referenceSystemRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ReferenceSystemRef();
			else if (elementName == "referenceSystemRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ReferenceSystemRef_Group();
			else if (elementName == "ReferenceType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ReferenceType();
			else if (elementName == "refLocation" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RefLocation();
			else if (elementName == "RelatedTimeType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RelatedTimeType();
			else if (elementName == "RelatedTimeType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RelatedTimeType_Type();
			else if (elementName == "relation" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Relation();
			else if (elementName == "relativeInternalPositionalAccuracy" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RelativeInternalPositionalAccuracy();
			else if (elementName == "RelativeInternalPositionalAccuracyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RelativeInternalPositionalAccuracyType();
			else if (elementName == "remarks" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Remarks();
			else if (elementName == "replaces" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.Replaces();
			else if (elementName == "RequestMethodType" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.RequestMethodType();
			else if (elementName == "RequestStatusType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.RequestStatusType();
			else if (elementName == "requires" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.Requires();
			else if (elementName == "ResponsiblePartySubsetType" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.ResponsiblePartySubsetType();
			else if (elementName == "result" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Result();
			else if (elementName == "resultOf" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ResultOf();
			else if (elementName == "resultOf_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ResultOf_Group();
			else if (elementName == "rights" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Rights();
			else if (elementName == "rightsHolder" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.RightsHolder();
			else if (elementName == "Ring" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Ring();
			else if (elementName == "RingType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RingType();
			else if (elementName == "Role" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.Role();
			else if (elementName == "roughConversionToPreferredUnit" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RoughConversionToPreferredUnit();
			else if (elementName == "row" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Row();
			else if (elementName == "row_Choice_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Row_Choice_Choice();
			else if (elementName == "rowIndex" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.RowIndex();
			else if (elementName == "Scalar_CapabilitiesType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Scalar_CapabilitiesType();
			else if (elementName == "ScalarValuePropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ScalarValuePropertyType();
			else if (elementName == "ScalarValuePropertyType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ScalarValuePropertyType_Type();
			else if (elementName == "ScaleType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ScaleType();
			else if (elementName == "SchemaComponentType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.SchemaComponentType();
			else if (elementName == "scope" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Scope();
			else if (elementName == "SearchResultsType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.SearchResultsType();
			else if (elementName == "SearchResultsType_Choice" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.SearchResultsType_Choice();
			else if (elementName == "secondDefiningParameter" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SecondDefiningParameter();
			else if (elementName == "seconds" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Seconds();
			else if (elementName == "SectionsType" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.SectionsType();
			else if (elementName == "segments" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Segments();
			else if (elementName == "semiMajorAxis" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SemiMajorAxis();
			else if (elementName == "semiMinorAxis" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SemiMinorAxis();
			else if (elementName == "SequenceRuleType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SequenceRuleType();
			else if (elementName == "ServiceIdentification" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.ServiceIdentification();
			else if (elementName == "ServiceProvider" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.ServiceProvider();
			else if (elementName == "set" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.Set();
			else if (elementName == "set" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.Set();
			else if (elementName == "setPrototype" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.SetPrototype();
			else if (elementName == "setType" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.SetType();
			else if (elementName == "setType_Type" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.SetType_Type();
			else if (elementName == "setType_Type_Group" && elementNamespaceUri == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.SetType_Type_Group();
			else if (elementName == "SimpleArithmetic" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.SimpleArithmetic();
			else if (elementName == "SimpleLiteral" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.SimpleLiteral();
			else if (elementName == "singleOperationRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SingleOperationRef();
			else if (elementName == "singleOperationRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SingleOperationRef_Group();
			else if (elementName == "Solid" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Solid();
			else if (elementName == "solidArrayProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SolidArrayProperty();
			else if (elementName == "solidArrayProperty_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SolidArrayProperty_Group();
			else if (elementName == "solidMember" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SolidMember();
			else if (elementName == "solidMember_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SolidMember_Group();
			else if (elementName == "solidMembers" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SolidMembers();
			else if (elementName == "solidMembers_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SolidMembers_Group();
			else if (elementName == "solidProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SolidProperty();
			else if (elementName == "solidProperty_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SolidProperty_Group();
			else if (elementName == "SolidType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SolidType();
			else if (elementName == "SortBy" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.SortBy();
			else if (elementName == "SortPropertyType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.SortPropertyType();
			else if (elementName == "source" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Source();
			else if (elementName == "sourceCRS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SourceCRS();
			else if (elementName == "sourceCRS_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SourceCRS_Group();
			else if (elementName == "sourceDimensions" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SourceDimensions();
			else if (elementName == "spatial" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.Spatial();
			else if (elementName == "Spatial_CapabilitiesType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Spatial_CapabilitiesType();
			else if (elementName == "SpatialOperatorsType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.SpatialOperatorsType();
			else if (elementName == "SpatialOperatorType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.SpatialOperatorType();
			else if (elementName == "SpeedType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SpeedType();
			else if (elementName == "Sphere" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Sphere();
			else if (elementName == "SphereType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SphereType();
			else if (elementName == "SphericalCS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SphericalCS();
			else if (elementName == "sphericalCSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SphericalCSRef();
			else if (elementName == "sphericalCSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SphericalCSRef_Group();
			else if (elementName == "SphericalCSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SphericalCSType();
			else if (elementName == "srsID" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SrsID();
			else if (elementName == "srsName" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SrsName();
			else if (elementName == "status" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Status();
			else if (elementName == "StringOrRefType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.StringOrRefType();
			else if (elementName == "stringValue" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.StringValue();
			else if (elementName == "Style" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Style();
			else if (elementName == "StyleType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.StyleType();
			else if (elementName == "StyleVariationType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.StyleVariationType();
			else if (elementName == "Sub" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Sub();
			else if (elementName == "subComplex" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubComplex();
			else if (elementName == "SubGrp_CoordinateOperation" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_CoordinateOperation();
			else if (elementName == "SubGrp_CoordinateReferenceSystem" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_CoordinateReferenceSystem();
			else if (elementName == "SubGrp_CoordinateSystem" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_CoordinateSystem();
			else if (elementName == "SubGrp_Coverage" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_Coverage();
			else if (elementName == "SubGrp_CRS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_CRS();
			else if (elementName == "SubGrp_Curve" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_Curve();
			else if (elementName == "SubGrp_CurveSegment" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_CurveSegment();
			else if (elementName == "SubGrp_Datum" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_Datum();
			else if (elementName == "SubGrp_DiscreteCoverage" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_DiscreteCoverage();
			else if (elementName == "SubGrp_Feature" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_Feature();
			else if (elementName == "SubGrp_GeneralConversion" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_GeneralConversion();
			else if (elementName == "SubGrp_GeneralDerivedCRS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_GeneralDerivedCRS();
			else if (elementName == "SubGrp_GeneralOperationParameter" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_GeneralOperationParameter();
			else if (elementName == "SubGrp_GeneralTransformation" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_GeneralTransformation();
			else if (elementName == "SubGrp_GeometricAggregate" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_GeometricAggregate();
			else if (elementName == "SubGrp_GeometricPrimitive" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_GeometricPrimitive();
			else if (elementName == "SubGrp_Geometry" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_Geometry();
			else if (elementName == "SubGrp_GML" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_GML();
			else if (elementName == "SubGrp_GriddedSurface" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_GriddedSurface();
			else if (elementName == "SubGrp_Id" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.SubGrp_Id();
			else if (elementName == "SubGrp_ImplicitGeometry" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_ImplicitGeometry();
			else if (elementName == "SubGrp_MetaData" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_MetaData();
			else if (elementName == "SubGrp_Object" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_Object();
			else if (elementName == "SubGrp_Operation" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_Operation();
			else if (elementName == "SubGrp_ParametricCurveSurface" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_ParametricCurveSurface();
			else if (elementName == "SubGrp_positionalAccuracy" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_positionalAccuracy();
			else if (elementName == "SubGrp_ReferenceSystem" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_ReferenceSystem();
			else if (elementName == "SubGrp_Ring" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_Ring();
			else if (elementName == "SubGrp_SingleOperation" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_SingleOperation();
			else if (elementName == "SubGrp_Solid" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_Solid();
			else if (elementName == "SubGrp_Style" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_Style();
			else if (elementName == "SubGrp_Surface" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_Surface();
			else if (elementName == "SubGrp_TimeComplex" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_TimeComplex();
			else if (elementName == "SubGrp_TimeGeometricPrimitive" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_TimeGeometricPrimitive();
			else if (elementName == "SubGrp_TimeObject" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_TimeObject();
			else if (elementName == "SubGrp_TimePrimitive" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_TimePrimitive();
			else if (elementName == "SubGrp_TimeReferenceSystem" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_TimeReferenceSystem();
			else if (elementName == "SubGrp_TimeSlice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_TimeSlice();
			else if (elementName == "SubGrp_TimeTopologyPrimitive" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_TimeTopologyPrimitive();
			else if (elementName == "SubGrp_Topology" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_Topology();
			else if (elementName == "SubGrp_TopoPrimitive" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrp_TopoPrimitive();
			else if (elementName == "SubGrpAbstractQuery" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.SubGrpAbstractQuery();
			else if (elementName == "SubGrpAbstractRecord" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.SubGrpAbstractRecord();
			else if (elementName == "SubGrpArc" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpArc();
			else if (elementName == "SubGrpArcByCenterPoint" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpArcByCenterPoint();
			else if (elementName == "SubGrpArcString" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpArcString();
			else if (elementName == "SubGrpArcStringByBulge" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpArcStringByBulge();
			else if (elementName == "SubGrpaudience" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.SubGrpaudience();
			else if (elementName == "SubGrpAvailableCRS" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.SubGrpAvailableCRS();
			else if (elementName == "SubGrpBoundingBox" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.SubGrpBoundingBox();
			else if (elementName == "SubGrpBSpline" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpBSpline();
			else if (elementName == "SubGrpcomparisonOps" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.SubGrpcomparisonOps();
			else if (elementName == "SubGrpCompositeValue" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpCompositeValue();
			else if (elementName == "SubGrpcoverage" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.SubGrpcoverage();
			else if (elementName == "SubGrpdate" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.SubGrpdate();
			else if (elementName == "SubGrpDC-element" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.SubGrpDC_element();
			else if (elementName == "SubGrpDefinition" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpDefinition();
			else if (elementName == "SubGrpdescription" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.SubGrpdescription();
			else if (elementName == "SubGrpdictionaryEntry" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpdictionaryEntry();
			else if (elementName == "SubGrpDirectedObservation" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpDirectedObservation();
			else if (elementName == "SubGrpdomainSet" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpdomainSet();
			else if (elementName == "SubGrpEnvelope" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpEnvelope();
			else if (elementName == "SubGrpexpression" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.SubGrpexpression();
			else if (elementName == "SubGrpexterior" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpexterior();
			else if (elementName == "SubGrpformat" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.SubGrpformat();
			else if (elementName == "SubGrpGeodesicString" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpGeodesicString();
			else if (elementName == "SubGrpGridFunction" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpGridFunction();
			else if (elementName == "SubGrphistory" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrphistory();
			else if (elementName == "SubGrpidentifier" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.SubGrpidentifier();
			else if (elementName == "SubGrpinterior" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpinterior();
			else if (elementName == "SubGrplocation" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrplocation();
			else if (elementName == "SubGrplogicOps" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.SubGrplogicOps();
			else if (elementName == "SubGrpname" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpname();
			else if (elementName == "SubGrpObservation" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpObservation();
			else if (elementName == "SubGrprelation" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.SubGrprelation();
			else if (elementName == "SubGrprights" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.SubGrprights();
			else if (elementName == "SubGrpspatialOps" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.SubGrpspatialOps();
			else if (elementName == "SubGrpSurface" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpSurface();
			else if (elementName == "SubGrptarget" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrptarget();
			else if (elementName == "SubGrptitle" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.SubGrptitle();
			else if (elementName == "SubGrpTriangulatedSurface" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpTriangulatedSurface();
			else if (elementName == "SubGrpUnitDefinition" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SubGrpUnitDefinition();
			else if (elementName == "subject" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Subject();
			else if (elementName == "subject" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Subject();
			else if (elementName == "SummaryRecord" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.SummaryRecord();
			else if (elementName == "SummaryRecordType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.SummaryRecordType();
			else if (elementName == "superComplex" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SuperComplex();
			else if (elementName == "SupportedCRS" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.SupportedCRS();
			else if (elementName == "Surface" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Surface();
			else if (elementName == "surfaceArrayProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SurfaceArrayProperty();
			else if (elementName == "surfaceMember" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SurfaceMember();
			else if (elementName == "surfaceMember_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SurfaceMember_Group();
			else if (elementName == "surfaceMembers" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SurfaceMembers();
			else if (elementName == "SurfacePatchArrayPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SurfacePatchArrayPropertyType();
			else if (elementName == "SurfacePatchArrayPropertyType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SurfacePatchArrayPropertyType_Type();
			else if (elementName == "SurfacePatchArrayPropertyType_Type_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SurfacePatchArrayPropertyType_Type_Group();
			else if (elementName == "surfaceProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SurfaceProperty();
			else if (elementName == "surfaceProperty_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SurfaceProperty_Group();
			else if (elementName == "SurfacePropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SurfacePropertyType();
			else if (elementName == "SurfacePropertyType_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SurfacePropertyType_Group();
			else if (elementName == "SurfaceType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SurfaceType();
			else if (elementName == "SurfaceType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.SurfaceType_Type();
			else if (elementName == "symbol" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Symbol();
			else if (elementName == "tableOfContents" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.TableOfContents();
			else if (elementName == "target" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Target();
			else if (elementName == "targetCRS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TargetCRS();
			else if (elementName == "targetCRS_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TargetCRS_Group();
			else if (elementName == "targetDimensions" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TargetDimensions();
			else if (elementName == "TargetPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TargetPropertyType();
			else if (elementName == "TargetPropertyType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TargetPropertyType_Type();
			else if (elementName == "TargetPropertyType_Type_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TargetPropertyType_Type_Group();
			else if (elementName == "TelephoneType" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.TelephoneType();
			else if (elementName == "temporal" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.Temporal();
			else if (elementName == "TemporalCRS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TemporalCRS();
			else if (elementName == "temporalCRSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TemporalCRSRef();
			else if (elementName == "temporalCRSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TemporalCRSRef_Group();
			else if (elementName == "TemporalCRSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TemporalCRSType();
			else if (elementName == "TemporalCS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TemporalCS();
			else if (elementName == "temporalCSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TemporalCSRef();
			else if (elementName == "temporalCSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TemporalCSRef_Group();
			else if (elementName == "TemporalCSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TemporalCSType();
			else if (elementName == "TemporalDatum" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TemporalDatum();
			else if (elementName == "temporalDatumRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TemporalDatumRef();
			else if (elementName == "temporalDatumRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TemporalDatumRef_Group();
			else if (elementName == "TemporalDatumType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TemporalDatumType();
			else if (elementName == "temporalExtent" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TemporalExtent();
			else if (elementName == "TimeCalendar" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeCalendar();
			else if (elementName == "TimeCalendarEra" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeCalendarEra();
			else if (elementName == "TimeCalendarEraPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeCalendarEraPropertyType();
			else if (elementName == "TimeCalendarEraPropertyType_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeCalendarEraPropertyType_Group();
			else if (elementName == "TimeCalendarEraType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeCalendarEraType();
			else if (elementName == "TimeCalendarPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeCalendarPropertyType();
			else if (elementName == "TimeCalendarPropertyType_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeCalendarPropertyType_Group();
			else if (elementName == "TimeCalendarType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeCalendarType();
			else if (elementName == "TimeClock" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeClock();
			else if (elementName == "TimeClockType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeClockType();
			else if (elementName == "TimeCoordinateSystem" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeCoordinateSystem();
			else if (elementName == "TimeCoordinateSystemType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeCoordinateSystemType();
			else if (elementName == "TimeCoordinateSystemType_Type_Seq_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeCoordinateSystemType_Type_Seq_Choice();
			else if (elementName == "TimeEdge" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeEdge();
			else if (elementName == "TimeEdgePropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeEdgePropertyType();
			else if (elementName == "TimeEdgePropertyType_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeEdgePropertyType_Group();
			else if (elementName == "TimeEdgeType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeEdgeType();
			else if (elementName == "TimeInstant" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeInstant();
			else if (elementName == "TimeInstantPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeInstantPropertyType();
			else if (elementName == "TimeInstantPropertyType_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeInstantPropertyType_Group();
			else if (elementName == "TimeInstantType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeInstantType();
			else if (elementName == "timeInterval" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeInterval();
			else if (elementName == "TimeIntervalLengthType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeIntervalLengthType();
			else if (elementName == "TimeNode" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeNode();
			else if (elementName == "TimeNodePropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeNodePropertyType();
			else if (elementName == "TimeNodePropertyType_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeNodePropertyType_Group();
			else if (elementName == "TimeNodeType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeNodeType();
			else if (elementName == "TimeOrdinalEra" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeOrdinalEra();
			else if (elementName == "TimeOrdinalEraPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeOrdinalEraPropertyType();
			else if (elementName == "TimeOrdinalEraPropertyType_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeOrdinalEraPropertyType_Group();
			else if (elementName == "TimeOrdinalEraType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeOrdinalEraType();
			else if (elementName == "TimeOrdinalReferenceSystem" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeOrdinalReferenceSystem();
			else if (elementName == "TimeOrdinalReferenceSystemType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeOrdinalReferenceSystemType();
			else if (elementName == "TimePeriod" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimePeriod();
			else if (elementName == "TimePeriodPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimePeriodPropertyType();
			else if (elementName == "TimePeriodPropertyType_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimePeriodPropertyType_Group();
			else if (elementName == "TimePeriodType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimePeriodType();
			else if (elementName == "TimePeriodType_Type_Seq_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimePeriodType_Type_Seq_Choice();
			else if (elementName == "TimePeriodType_Type_Seq_ChoiceA" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimePeriodType_Type_Seq_ChoiceA();
			else if (elementName == "TimePeriodType_Type_Seq_ChoiceB" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimePeriodType_Type_Seq_ChoiceB();
			else if (elementName == "timePosition" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimePosition();
			else if (elementName == "TimePositionType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimePositionType();
			else if (elementName == "TimePrimitivePropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimePrimitivePropertyType();
			else if (elementName == "TimePrimitivePropertyType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimePrimitivePropertyType_Type();
			else if (elementName == "TimePrimitivePropertyType_Type_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimePrimitivePropertyType_Type_Group();
			else if (elementName == "TimeTopologyComplex" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeTopologyComplex();
			else if (elementName == "TimeTopologyComplexType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeTopologyComplexType();
			else if (elementName == "TimeTopologyPrimitivePropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeTopologyPrimitivePropertyType();
			else if (elementName == "TimeTopologyPrimitivePropertyType_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeTopologyPrimitivePropertyType_Group();
			else if (elementName == "TimeType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TimeType();
			else if (elementName == "Tin" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Tin();
			else if (elementName == "TinType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TinType();
			else if (elementName == "title" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Title();
			else if (elementName == "Title" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.Title();
			else if (elementName == "TopoComplex" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoComplex();
			else if (elementName == "topoComplexProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoComplexProperty();
			else if (elementName == "TopoComplexType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoComplexType();
			else if (elementName == "TopoCurve" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoCurve();
			else if (elementName == "topoCurveProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoCurveProperty();
			else if (elementName == "TopoCurveType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoCurveType();
			else if (elementName == "topologyStyle" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopologyStyle();
			else if (elementName == "TopologyStyle" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopologyStyleA();
			else if (elementName == "TopologyStyleType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopologyStyleType();
			else if (elementName == "TopologyStyleType_Type_Seq_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopologyStyleType_Type_Seq_Choice();
			else if (elementName == "TopoPoint" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoPoint();
			else if (elementName == "topoPointProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoPointProperty();
			else if (elementName == "TopoPointType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoPointType();
			else if (elementName == "topoPrimitiveMember" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoPrimitiveMember();
			else if (elementName == "topoPrimitiveMembers" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoPrimitiveMembers();
			else if (elementName == "TopoSolid" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoSolid();
			else if (elementName == "TopoSolidType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoSolidType();
			else if (elementName == "TopoSurface" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoSurface();
			else if (elementName == "topoSurfaceProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoSurfaceProperty();
			else if (elementName == "TopoSurfaceType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoSurfaceType();
			else if (elementName == "TopoVolume" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoVolume();
			else if (elementName == "topoVolumeProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoVolumeProperty();
			else if (elementName == "TopoVolumeType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TopoVolumeType();
			else if (elementName == "Touches" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Touches();
			else if (elementName == "track" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Track();
			else if (elementName == "TrackType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TrackType();
			else if (elementName == "TrackType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TrackType_Type();
			else if (elementName == "Transaction" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.Transaction();
			else if (elementName == "TransactionResponse" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.TransactionResponse();
			else if (elementName == "TransactionSummaryType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.TransactionSummaryType();
			else if (elementName == "TransactionType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.TransactionType();
			else if (elementName == "TransactionType_Type_Choice" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.TransactionType_Type_Choice();
			else if (elementName == "Transformation" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Transformation();
			else if (elementName == "transformationRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TransformationRef();
			else if (elementName == "transformationRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TransformationRef_Group();
			else if (elementName == "TransformationType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TransformationType();
			else if (elementName == "Triangle" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Triangle();
			else if (elementName == "TrianglePatchArrayPropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TrianglePatchArrayPropertyType();
			else if (elementName == "TrianglePatchArrayPropertyType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TrianglePatchArrayPropertyType_Type();
			else if (elementName == "trianglePatches" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TrianglePatches();
			else if (elementName == "TriangleType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TriangleType();
			else if (elementName == "TriangleType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TriangleType_Type();
			else if (elementName == "TriangulatedSurface" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TriangulatedSurface();
			else if (elementName == "TriangulatedSurfaceType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TriangulatedSurfaceType();
			else if (elementName == "tupleList" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.TupleList();
			else if (elementName == "type" && elementNamespaceUri == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Type();
			else if (elementName == "UnaryLogicOpType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.UnaryLogicOpType();
			else if (elementName == "UnaryLogicOpType_Type" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.UnaryLogicOpType_Type();
			else if (elementName == "UnitDefinition" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UnitDefinition();
			else if (elementName == "UnitDefinitionType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UnitDefinitionType();
			else if (elementName == "unitOfMeasure" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UnitOfMeasure();
			else if (elementName == "UnitOfMeasureType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UnitOfMeasureType();
			else if (elementName == "UpdateType" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.UpdateType();
			else if (elementName == "UpdateType_Choice_Seq" && elementNamespaceUri == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.UpdateType_Choice_Seq();
			else if (elementName == "UpperBoundaryType" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.UpperBoundaryType();
			else if (elementName == "UserDefinedCS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UserDefinedCS();
			else if (elementName == "userDefinedCSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UserDefinedCSRef();
			else if (elementName == "userDefinedCSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UserDefinedCSRef_Group();
			else if (elementName == "UserDefinedCSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UserDefinedCSType();
			else if (elementName == "usesAxis" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesAxis();
			else if (elementName == "usesAxis_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesAxis_Group();
			else if (elementName == "usesCartesianCS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesCartesianCS();
			else if (elementName == "usesCartesianCS_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesCartesianCS_Group();
			else if (elementName == "usesCS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesCS();
			else if (elementName == "usesCS_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesCS_Group();
			else if (elementName == "usesEllipsoid" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesEllipsoid();
			else if (elementName == "usesEllipsoid_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesEllipsoid_Group();
			else if (elementName == "usesEllipsoidalCS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesEllipsoidalCS();
			else if (elementName == "usesEllipsoidalCS_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesEllipsoidalCS_Group();
			else if (elementName == "usesEngineeringDatum" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesEngineeringDatum();
			else if (elementName == "usesEngineeringDatum_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesEngineeringDatum_Group();
			else if (elementName == "usesGeodeticDatum" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesGeodeticDatum();
			else if (elementName == "usesGeodeticDatum_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesGeodeticDatum_Group();
			else if (elementName == "usesImageDatum" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesImageDatum();
			else if (elementName == "usesImageDatum_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesImageDatum_Group();
			else if (elementName == "usesMethod" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesMethod();
			else if (elementName == "usesMethod_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesMethod_Group();
			else if (elementName == "usesObliqueCartesianCS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesObliqueCartesianCS();
			else if (elementName == "usesObliqueCartesianCS_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesObliqueCartesianCS_Group();
			else if (elementName == "usesOperation" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesOperation();
			else if (elementName == "usesOperation_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesOperation_Group();
			else if (elementName == "usesParameter" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesParameter();
			else if (elementName == "usesParameter_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesParameter_Group();
			else if (elementName == "usesPrimeMeridian" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesPrimeMeridian();
			else if (elementName == "usesPrimeMeridian_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesPrimeMeridian_Group();
			else if (elementName == "usesSingleOperation" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesSingleOperation();
			else if (elementName == "usesSingleOperation_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesSingleOperation_Group();
			else if (elementName == "usesSphericalCS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesSphericalCS();
			else if (elementName == "usesSphericalCS_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesSphericalCS_Group();
			else if (elementName == "usesTemporalCS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesTemporalCS();
			else if (elementName == "usesTemporalCS_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesTemporalCS_Group();
			else if (elementName == "usesTemporalDatum" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesTemporalDatum();
			else if (elementName == "usesTemporalDatum_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesTemporalDatum_Group();
			else if (elementName == "usesValue" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesValue();
			else if (elementName == "usesVerticalCS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesVerticalCS();
			else if (elementName == "usesVerticalCS_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesVerticalCS_Group();
			else if (elementName == "usesVerticalDatum" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesVerticalDatum();
			else if (elementName == "usesVerticalDatum_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.UsesVerticalDatum_Group();
			else if (elementName == "using" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.using_();
			else if (elementName == "using_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Using_Group();
			else if (elementName == "valid" && elementNamespaceUri == "http://purl.org/dc/terms/")
				retVal = new AB.Valid();
			else if (elementName == "validArea" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValidArea();
			else if (elementName == "validArea_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValidArea_Choice();
			else if (elementName == "validTime" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValidTime();
			else if (elementName == "value" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Value();
			else if (elementName == "ValueArray" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValueArray();
			else if (elementName == "ValueArrayType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValueArrayType();
			else if (elementName == "valueComponent" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValueComponent();
			else if (elementName == "valueComponents" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValueComponents();
			else if (elementName == "valueComponents_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValueComponents_Choice();
			else if (elementName == "valueComponents_Choice_Choice" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValueComponents_Choice_Choice();
			else if (elementName == "valueFile" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValueFile();
			else if (elementName == "valueList" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValueList();
			else if (elementName == "valueOfParameter" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValueOfParameter();
			else if (elementName == "valueOfParameter_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValueOfParameter_Group();
			else if (elementName == "valueProperty" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValueProperty();
			else if (elementName == "ValuePropertyType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValuePropertyType();
			else if (elementName == "ValuePropertyType_Type" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValuePropertyType_Type();
			else if (elementName == "ValuePropertyType_Type_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValuePropertyType_Type_Group();
			else if (elementName == "valuesOfGroup" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValuesOfGroup();
			else if (elementName == "valuesOfGroup_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.ValuesOfGroup_Group();
			else if (elementName == "vector" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Vector();
			else if (elementName == "VectorType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.VectorType();
			else if (elementName == "version" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.Version();
			else if (elementName == "VerticalCRS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.VerticalCRS();
			else if (elementName == "verticalCRSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.VerticalCRSRef();
			else if (elementName == "verticalCRSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.VerticalCRSRef_Group();
			else if (elementName == "VerticalCRSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.VerticalCRSType();
			else if (elementName == "VerticalCS" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.VerticalCS();
			else if (elementName == "verticalCSRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.VerticalCSRef();
			else if (elementName == "verticalCSRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.VerticalCSRef_Group();
			else if (elementName == "VerticalCSType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.VerticalCSType();
			else if (elementName == "VerticalDatum" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.VerticalDatum();
			else if (elementName == "verticalDatumRef" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.VerticalDatumRef();
			else if (elementName == "verticalDatumRef_Group" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.VerticalDatumRef_Group();
			else if (elementName == "verticalDatumType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.VerticalDatumType();
			else if (elementName == "VerticalDatumType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.VerticalDatumTypeA();
			else if (elementName == "VerticalDatumTypeType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.VerticalDatumTypeType();
			else if (elementName == "verticalExtent" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.VerticalExtent();
			else if (elementName == "VolumeType" && elementNamespaceUri == "http://www.opengis.net/gml")
				retVal = new AE.VolumeType();
			else if (elementName == "WGS84BoundingBox" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.WGS84BoundingBox();
			else if (elementName == "WGS84BoundingBoxType" && elementNamespaceUri == "http://www.opengis.net/ows")
				retVal = new ows.WGS84BoundingBoxType();
			else if (elementName == "Within" && elementNamespaceUri == "http://www.opengis.net/ogc")
				retVal = new ogc.Within();
			else
			{
				throw new LiquidTechnologies.Runtime.Net45.LtException(
					string.Format("Failed load the element {0}:{1}. No appropriate class exists to load the data into. Ensure that the XML document complies with the schema.", 
						xmlParent.Name, xmlParent.NamespaceURI)); 
			}
			
			// load the data into the object
			retVal.FromXmlElement(xmlParent, context);

			return retVal;
		}


	}
}
namespace csw 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net45.ClassFactoryBase
	{



		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractQuery AbstractQueryCreateObject(XmlElement xmlParent)
		{
			csw.AbstractQuery retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractQueryType AbstractQueryTypeCreateObject(XmlElement xmlParent)
		{
			csw.AbstractQueryType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractRecord AbstractRecordCreateObject(XmlElement xmlParent)
		{
			csw.AbstractRecord retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractRecordType AbstractRecordTypeCreateObject(XmlElement xmlParent)
		{
			csw.AbstractRecordType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractQuery IAbstractQueryCreateObject(XmlElement xmlParent)
		{
			csw.IAbstractQuery retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = csw.ClassFactory.AbstractQueryCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractQueryType IAbstractQueryTypeCreateObject(XmlElement xmlParent)
		{
			csw.IAbstractQueryType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = csw.ClassFactory.AbstractQueryTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "Query"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.Query();
			if (retVal == null && typeName == "QueryType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.QueryType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractRecord IAbstractRecordCreateObject(XmlElement xmlParent)
		{
			csw.IAbstractRecord retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = csw.ClassFactory.AbstractRecordCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractRecordType IAbstractRecordTypeCreateObject(XmlElement xmlParent)
		{
			csw.IAbstractRecordType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = csw.ClassFactory.AbstractRecordTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "DCMIRecord"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.DCMIRecord();
			if (retVal == null && typeName == "DCMIRecordType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.DCMIRecordType();
			if (retVal == null)
				retVal = csw.ClassFactory.IDCMIRecordTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "BriefRecord"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.BriefRecord();
			if (retVal == null && typeName == "BriefRecordType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.BriefRecordType();
			if (retVal == null && typeName == "SummaryRecord"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.SummaryRecord();
			if (retVal == null && typeName == "SummaryRecordType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.SummaryRecordType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IDCMIRecordType IDCMIRecordTypeCreateObject(XmlElement xmlParent)
		{
			csw.IDCMIRecordType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new csw.DCMIRecordType();
		
			
			if (retVal == null && typeName == "DCMIRecordType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.DCMIRecordType();
			if (retVal == null && typeName == "DCMIRecord"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.DCMIRecord();
			if (retVal == null && typeName == "Record"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.Record();
			if (retVal == null && typeName == "RecordType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.RecordType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IRequestBaseType IRequestBaseTypeCreateObject(XmlElement xmlParent)
		{
			csw.IRequestBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = csw.ClassFactory.RequestBaseTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "GetDomain"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetDomain();
			if (retVal == null && typeName == "GetDomainType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetDomainType();
			if (retVal == null && typeName == "Harvest"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.Harvest();
			if (retVal == null && typeName == "HarvestType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.HarvestType();
			if (retVal == null && typeName == "Transaction"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.Transaction();
			if (retVal == null && typeName == "TransactionType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.TransactionType();
			if (retVal == null && typeName == "DescribeRecord"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.DescribeRecord();
			if (retVal == null && typeName == "DescribeRecordType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.DescribeRecordType();
			if (retVal == null && typeName == "GetRecords"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetRecords();
			if (retVal == null && typeName == "GetRecordsType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetRecordsType();
			if (retVal == null && typeName == "GetRecordById"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetRecordById();
			if (retVal == null && typeName == "GetRecordByIdType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetRecordByIdType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public RequestBaseType RequestBaseTypeCreateObject(XmlElement xmlParent)
		{
			csw.RequestBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}
	}
}
namespace ogc 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net45.ClassFactoryBase
	{



		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _Id _IdCreateObject(XmlElement xmlParent)
		{
			ogc._Id retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractIdType AbstractIdTypeCreateObject(XmlElement xmlParent)
		{
			ogc.AbstractIdType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public ComparisonOps ComparisonOpsCreateObject(XmlElement xmlParent)
		{
			ogc.ComparisonOps retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public ComparisonOpsType ComparisonOpsTypeCreateObject(XmlElement xmlParent)
		{
			ogc.ComparisonOpsType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public Expression ExpressionCreateObject(XmlElement xmlParent)
		{
			ogc.Expression retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public ExpressionType ExpressionTypeCreateObject(XmlElement xmlParent)
		{
			ogc.ExpressionType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_Id I_IdCreateObject(XmlElement xmlParent)
		{
			ogc.I_Id retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = ogc.ClassFactory._IdCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractIdType IAbstractIdTypeCreateObject(XmlElement xmlParent)
		{
			ogc.IAbstractIdType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = ogc.ClassFactory.AbstractIdTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "FeatureId"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.FeatureId();
			if (retVal == null && typeName == "FeatureIdType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.FeatureIdType();
			if (retVal == null && typeName == "GmlObjectId"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.GmlObjectId();
			if (retVal == null && typeName == "GmlObjectIdType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.GmlObjectIdType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IcomparisonOps IcomparisonOpsCreateObject(XmlElement xmlParent)
		{
			ogc.IcomparisonOps retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = ogc.ClassFactory.ComparisonOpsCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IComparisonOpsType IComparisonOpsTypeCreateObject(XmlElement xmlParent)
		{
			ogc.IComparisonOpsType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = ogc.ClassFactory.ComparisonOpsTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "PropertyIsLike"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsLike();
			if (retVal == null && typeName == "PropertyIsLikeType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsLikeType();
			if (retVal == null && typeName == "PropertyIsBetween"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsBetween();
			if (retVal == null && typeName == "PropertyIsBetweenType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsBetweenType();
			if (retVal == null && typeName == "PropertyIsLessThanOrEqualTo"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsLessThanOrEqualTo();
			if (retVal == null && typeName == "BinaryComparisonOpType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.BinaryComparisonOpType();
			if (retVal == null && typeName == "PropertyIsEqualTo"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsEqualTo();
			if (retVal == null && typeName == "PropertyIsNotEqualTo"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsNotEqualTo();
			if (retVal == null && typeName == "PropertyIsLessThan"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsLessThan();
			if (retVal == null && typeName == "PropertyIsGreaterThan"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsGreaterThan();
			if (retVal == null && typeName == "PropertyIsGreaterThanOrEqualTo"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsGreaterThanOrEqualTo();
			if (retVal == null && typeName == "PropertyIsNull"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsNull();
			if (retVal == null && typeName == "PropertyIsNullType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyIsNullType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public Iexpression IexpressionCreateObject(XmlElement xmlParent)
		{
			ogc.Iexpression retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = ogc.ClassFactory.ExpressionCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IExpressionType IExpressionTypeCreateObject(XmlElement xmlParent)
		{
			ogc.IExpressionType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = ogc.ClassFactory.ExpressionTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "Div"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.Div();
			if (retVal == null && typeName == "BinaryOperatorType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.BinaryOperatorType();
			if (retVal == null && typeName == "PropertyName"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyName();
			if (retVal == null && typeName == "PropertyNameType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.PropertyNameType();
			if (retVal == null && typeName == "Literal"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.Literal();
			if (retVal == null && typeName == "LiteralType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.LiteralType();
			if (retVal == null && typeName == "Mul"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.Mul();
			if (retVal == null && typeName == "Sub"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.Sub();
			if (retVal == null && typeName == "Function"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.Function();
			if (retVal == null && typeName == "FunctionType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.FunctionType();
			if (retVal == null && typeName == "Add"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.Add();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IlogicOps IlogicOpsCreateObject(XmlElement xmlParent)
		{
			ogc.IlogicOps retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = ogc.ClassFactory.LogicOpsCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public ILogicOpsType ILogicOpsTypeCreateObject(XmlElement xmlParent)
		{
			ogc.ILogicOpsType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = ogc.ClassFactory.LogicOpsTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "Not"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.Not();
			if (retVal == null && typeName == "UnaryLogicOpType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.UnaryLogicOpType();
			if (retVal == null && typeName == "And"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.And();
			if (retVal == null && typeName == "BinaryLogicOpType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.BinaryLogicOpType();
			if (retVal == null && typeName == "Or"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.Or();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IspatialOps IspatialOpsCreateObject(XmlElement xmlParent)
		{
			ogc.IspatialOps retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = ogc.ClassFactory.SpatialOpsCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public ISpatialOpsType ISpatialOpsTypeCreateObject(XmlElement xmlParent)
		{
			ogc.ISpatialOpsType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = ogc.ClassFactory.SpatialOpsTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "Touches"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.Touches();
			if (retVal == null && typeName == "BinarySpatialOpType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.BinarySpatialOpType();
			if (retVal == null && typeName == "Disjoint"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.Disjoint();
			if (retVal == null && typeName == "Contains"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.Contains();
			if (retVal == null && typeName == "Within"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.Within();
			if (retVal == null && typeName == "DWithin"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.DWithin();
			if (retVal == null && typeName == "DistanceBufferType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.DistanceBufferType();
			if (retVal == null && typeName == "Equals"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.Equals();
			if (retVal == null && typeName == "Overlaps"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.Overlaps();
			if (retVal == null && typeName == "Crosses"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.Crosses();
			if (retVal == null && typeName == "Intersects"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.Intersects();
			if (retVal == null && typeName == "Beyond"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.Beyond();
			if (retVal == null && typeName == "BBOX"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.BBOX();
			if (retVal == null && typeName == "BBOXType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ogc")
				retVal = new ogc.BBOXType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public LogicOps LogicOpsCreateObject(XmlElement xmlParent)
		{
			ogc.LogicOps retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public LogicOpsType LogicOpsTypeCreateObject(XmlElement xmlParent)
		{
			ogc.LogicOpsType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public SpatialOps SpatialOpsCreateObject(XmlElement xmlParent)
		{
			ogc.SpatialOps retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public SpatialOpsType SpatialOpsTypeCreateObject(XmlElement xmlParent)
		{
			ogc.SpatialOpsType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}
	}
}
namespace ows 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net45.ClassFactoryBase
	{



		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractMetaData AbstractMetaDataCreateObject(XmlElement xmlParent)
		{
			ows.AbstractMetaData retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractMetaData IAbstractMetaDataCreateObject(XmlElement xmlParent)
		{
			ows.IAbstractMetaData retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = ows.ClassFactory.AbstractMetaDataCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IBoundingBoxType IBoundingBoxTypeCreateObject(XmlElement xmlParent)
		{
			ows.IBoundingBoxType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new ows.BoundingBoxType();
		
			
			if (retVal == null && typeName == "BoundingBoxType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ows")
				retVal = new ows.BoundingBoxType();
			if (retVal == null && typeName == "BoundingBox"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ows")
				retVal = new ows.BoundingBox();
			if (retVal == null && typeName == "WGS84BoundingBox"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ows")
				retVal = new ows.WGS84BoundingBox();
			if (retVal == null && typeName == "WGS84BoundingBoxType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ows")
				retVal = new ows.WGS84BoundingBoxType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public ICapabilitiesBaseType ICapabilitiesBaseTypeCreateObject(XmlElement xmlParent)
		{
			ows.ICapabilitiesBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new ows.CapabilitiesBaseType();
		
			
			if (retVal == null && typeName == "CapabilitiesBaseType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ows")
				retVal = new ows.CapabilitiesBaseType();
			if (retVal == null && typeName == "Capabilities"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.Capabilities();
			if (retVal == null && typeName == "CapabilitiesType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.CapabilitiesType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IDescriptionType IDescriptionTypeCreateObject(XmlElement xmlParent)
		{
			ows.IDescriptionType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new ows.DescriptionType();
		
			
			if (retVal == null && typeName == "DescriptionType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ows")
				retVal = new ows.DescriptionType();
			if (retVal == null && typeName == "ServiceIdentification"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ows")
				retVal = new ows.ServiceIdentification();
			if (retVal == null && typeName == "IdentificationType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ows")
				retVal = new ows.IdentificationType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IGetCapabilitiesType IGetCapabilitiesTypeCreateObject(XmlElement xmlParent)
		{
			ows.IGetCapabilitiesType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new ows.GetCapabilitiesType();
		
			
			if (retVal == null && typeName == "GetCapabilitiesType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ows")
				retVal = new ows.GetCapabilitiesType();
			if (retVal == null && typeName == "GetCapabilities"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetCapabilities();
			if (retVal == null && typeName == "GetCapabilitiesType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/cat/csw/2.0.2")
				retVal = new csw.GetCapabilitiesType();
			if (retVal == null && typeName == "GetCapabilities"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ows")
				retVal = new ows.GetCapabilities();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IOnlineResourceType IOnlineResourceTypeCreateObject(XmlElement xmlParent)
		{
			ows.IOnlineResourceType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new ows.OnlineResourceType();
		
			
			if (retVal == null && typeName == "OnlineResourceType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ows")
				retVal = new ows.OnlineResourceType();
			if (retVal == null && typeName == "RequestMethodType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/ows")
				retVal = new ows.RequestMethodType();
		
			return retVal;
		}
	}
}
namespace AA 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net45.ClassFactoryBase
	{



		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public DC_element DC_elementCreateObject(XmlElement xmlParent)
		{
			AA.DC_element retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IDC_element IDC_elementCreateObject(XmlElement xmlParent)
		{
			AA.IDC_element retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AA.ClassFactory.DC_elementCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public ISimpleLiteral ISimpleLiteralCreateObject(XmlElement xmlParent)
		{
			AA.ISimpleLiteral retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AA.SimpleLiteral();
		
			
			if (retVal == null && typeName == "SimpleLiteral"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.SimpleLiteral();
			if (retVal == null && typeName == "temporal"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.Temporal();
			if (retVal == null && typeName == "educationLevel"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.EducationLevel();
			if (retVal == null && typeName == "issued"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.Issued();
			if (retVal == null && typeName == "created"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.Created();
			if (retVal == null && typeName == "conformsTo"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.ConformsTo();
			if (retVal == null && typeName == "requires"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.Requires();
			if (retVal == null && typeName == "alternative"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.Alternative();
			if (retVal == null && typeName == "isVersionOf"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.IsVersionOf();
			if (retVal == null && typeName == "rightsHolder"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.RightsHolder();
			if (retVal == null && typeName == "isReplacedBy"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.IsReplacedBy();
			if (retVal == null && typeName == "valid"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.Valid();
			if (retVal == null && typeName == "audience"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.Audience();
			if (retVal == null && typeName == "references"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.References();
			if (retVal == null && typeName == "dateAccepted"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.DateAccepted();
			if (retVal == null && typeName == "spatial"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.Spatial();
			if (retVal == null && typeName == "available"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.Available();
			if (retVal == null && typeName == "hasVersion"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.HasVersion();
			if (retVal == null && typeName == "extent"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.Extent();
			if (retVal == null && typeName == "dateCopyrighted"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.DateCopyrighted();
			if (retVal == null && typeName == "accessRights"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.AccessRights();
			if (retVal == null && typeName == "license"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.License();
			if (retVal == null && typeName == "bibliographicCitation"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.BibliographicCitation();
			if (retVal == null && typeName == "isPartOf"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.IsPartOf();
			if (retVal == null && typeName == "hasPart"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.HasPart();
			if (retVal == null && typeName == "dateSubmitted"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.DateSubmitted();
			if (retVal == null && typeName == "abstract"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.abstract_();
			if (retVal == null && typeName == "isFormatOf"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.IsFormatOf();
			if (retVal == null && typeName == "tableOfContents"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.TableOfContents();
			if (retVal == null && typeName == "replaces"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.Replaces();
			if (retVal == null && typeName == "medium"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.Medium();
			if (retVal == null && typeName == "provenance"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.Provenance();
			if (retVal == null && typeName == "isReferencedBy"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.IsReferencedBy();
			if (retVal == null && typeName == "modified"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.Modified();
			if (retVal == null && typeName == "isRequiredBy"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.IsRequiredBy();
			if (retVal == null && typeName == "mediator"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.Mediator();
			if (retVal == null && typeName == "hasFormat"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/terms/")
				retVal = new AB.HasFormat();
			if (retVal == null && typeName == "title"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Title();
			if (retVal == null && typeName == "description"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Description();
			if (retVal == null && typeName == "subject"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Subject();
			if (retVal == null && typeName == "relation"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Relation();
			if (retVal == null && typeName == "publisher"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Publisher();
			if (retVal == null && typeName == "contributor"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Contributor();
			if (retVal == null && typeName == "type"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Type();
			if (retVal == null && typeName == "date"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Date();
			if (retVal == null && typeName == "coverage"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Coverage();
			if (retVal == null && typeName == "format"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Format();
			if (retVal == null && typeName == "creator"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Creator();
			if (retVal == null && typeName == "source"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Source();
			if (retVal == null && typeName == "rights"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Rights();
			if (retVal == null && typeName == "language"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Language();
			if (retVal == null && typeName == "identifier"  && GetElementTypeNamespaceUri(xmlParent) == "http://purl.org/dc/elements/1.1/")
				retVal = new AA.Identifier();
		
			return retVal;
		}
	}
}
namespace AB 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net45.ClassFactoryBase
	{


	}
}
namespace AC 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net45.ClassFactoryBase
	{



		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public Arc ArcCreateObject(XmlElement xmlParent)
		{
			AC.Arc retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public Iarc IarcCreateObject(XmlElement xmlParent)
		{
			AC.Iarc retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AC.ClassFactory.ArcCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public Ilocator IlocatorCreateObject(XmlElement xmlParent)
		{
			AC.Ilocator retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AC.ClassFactory.LocatorCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public Iresource IresourceCreateObject(XmlElement xmlParent)
		{
			AC.Iresource retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AC.ClassFactory.ResourceCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public Ititle ItitleCreateObject(XmlElement xmlParent)
		{
			AC.Ititle retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AC.ClassFactory.TitleCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public Locator LocatorCreateObject(XmlElement xmlParent)
		{
			AC.Locator retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public Resource ResourceCreateObject(XmlElement xmlParent)
		{
			AC.Resource retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public Title TitleCreateObject(XmlElement xmlParent)
		{
			AC.Title retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}
	}
}
namespace AD 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net45.ClassFactoryBase
	{


	}
}
namespace AE 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net45.ClassFactoryBase
	{



		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _association _associationCreateObject(XmlElement xmlParent)
		{
			AE._association retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _ContinuousCoverage _ContinuousCoverageCreateObject(XmlElement xmlParent)
		{
			AE._ContinuousCoverage retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _CoordinateOperation _CoordinateOperationCreateObject(XmlElement xmlParent)
		{
			AE._CoordinateOperation retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _CoordinateReferenceSystem _CoordinateReferenceSystemCreateObject(XmlElement xmlParent)
		{
			AE._CoordinateReferenceSystem retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _CoordinateSystem _CoordinateSystemCreateObject(XmlElement xmlParent)
		{
			AE._CoordinateSystem retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _Coverage _CoverageCreateObject(XmlElement xmlParent)
		{
			AE._Coverage retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _CRS _CRSCreateObject(XmlElement xmlParent)
		{
			AE._CRS retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _Curve _CurveCreateObject(XmlElement xmlParent)
		{
			AE._Curve retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _CurveSegment _CurveSegmentCreateObject(XmlElement xmlParent)
		{
			AE._CurveSegment retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _Datum _DatumCreateObject(XmlElement xmlParent)
		{
			AE._Datum retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _DiscreteCoverage _DiscreteCoverageCreateObject(XmlElement xmlParent)
		{
			AE._DiscreteCoverage retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _Feature _FeatureCreateObject(XmlElement xmlParent)
		{
			AE._Feature retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _FeatureCollection _FeatureCollectionCreateObject(XmlElement xmlParent)
		{
			AE._FeatureCollection retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _GeneralConversion _GeneralConversionCreateObject(XmlElement xmlParent)
		{
			AE._GeneralConversion retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _GeneralDerivedCRS _GeneralDerivedCRSCreateObject(XmlElement xmlParent)
		{
			AE._GeneralDerivedCRS retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _GeneralOperationParameter _GeneralOperationParameterCreateObject(XmlElement xmlParent)
		{
			AE._GeneralOperationParameter retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _generalParameterValue _generalParameterValueCreateObject(XmlElement xmlParent)
		{
			AE._generalParameterValue retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _GeneralTransformation _GeneralTransformationCreateObject(XmlElement xmlParent)
		{
			AE._GeneralTransformation retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _GeometricAggregate _GeometricAggregateCreateObject(XmlElement xmlParent)
		{
			AE._GeometricAggregate retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _GeometricPrimitive _GeometricPrimitiveCreateObject(XmlElement xmlParent)
		{
			AE._GeometricPrimitive retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _Geometry _GeometryCreateObject(XmlElement xmlParent)
		{
			AE._Geometry retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _GML _GMLCreateObject(XmlElement xmlParent)
		{
			AE._GML retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _GriddedSurface _GriddedSurfaceCreateObject(XmlElement xmlParent)
		{
			AE._GriddedSurface retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _ImplicitGeometry _ImplicitGeometryCreateObject(XmlElement xmlParent)
		{
			AE._ImplicitGeometry retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _MetaData _MetaDataCreateObject(XmlElement xmlParent)
		{
			AE._MetaData retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _Object _ObjectCreateObject(XmlElement xmlParent)
		{
			AE._Object retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _Operation _OperationCreateObject(XmlElement xmlParent)
		{
			AE._Operation retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _ParametricCurveSurface _ParametricCurveSurfaceCreateObject(XmlElement xmlParent)
		{
			AE._ParametricCurveSurface retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _positionalAccuracy _positionalAccuracyCreateObject(XmlElement xmlParent)
		{
			AE._positionalAccuracy retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _reference _referenceCreateObject(XmlElement xmlParent)
		{
			AE._reference retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _ReferenceSystem _ReferenceSystemCreateObject(XmlElement xmlParent)
		{
			AE._ReferenceSystem retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _Ring _RingCreateObject(XmlElement xmlParent)
		{
			AE._Ring retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _SingleOperation _SingleOperationCreateObject(XmlElement xmlParent)
		{
			AE._SingleOperation retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _Solid _SolidCreateObject(XmlElement xmlParent)
		{
			AE._Solid retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _strictAssociation _strictAssociationCreateObject(XmlElement xmlParent)
		{
			AE._strictAssociation retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _Style _StyleCreateObject(XmlElement xmlParent)
		{
			AE._Style retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _Surface _SurfaceCreateObject(XmlElement xmlParent)
		{
			AE._Surface retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _SurfacePatch _SurfacePatchCreateObject(XmlElement xmlParent)
		{
			AE._SurfacePatch retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _TimeComplex _TimeComplexCreateObject(XmlElement xmlParent)
		{
			AE._TimeComplex retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _TimeGeometricPrimitive _TimeGeometricPrimitiveCreateObject(XmlElement xmlParent)
		{
			AE._TimeGeometricPrimitive retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _TimeObject _TimeObjectCreateObject(XmlElement xmlParent)
		{
			AE._TimeObject retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _TimePrimitive _TimePrimitiveCreateObject(XmlElement xmlParent)
		{
			AE._TimePrimitive retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _TimeReferenceSystem _TimeReferenceSystemCreateObject(XmlElement xmlParent)
		{
			AE._TimeReferenceSystem retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _TimeSlice _TimeSliceCreateObject(XmlElement xmlParent)
		{
			AE._TimeSlice retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _TimeTopologyPrimitive _TimeTopologyPrimitiveCreateObject(XmlElement xmlParent)
		{
			AE._TimeTopologyPrimitive retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _Topology _TopologyCreateObject(XmlElement xmlParent)
		{
			AE._Topology retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public _TopoPrimitive _TopoPrimitiveCreateObject(XmlElement xmlParent)
		{
			AE._TopoPrimitive retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractContinuousCoverageType AbstractContinuousCoverageTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractContinuousCoverageType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractCoordinateOperationBaseType AbstractCoordinateOperationBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractCoordinateOperationBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractCoordinateOperationType AbstractCoordinateOperationTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractCoordinateOperationType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractCoordinateSystemBaseType AbstractCoordinateSystemBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractCoordinateSystemBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractCoordinateSystemType AbstractCoordinateSystemTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractCoordinateSystemType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractCoverageType AbstractCoverageTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractCoverageType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractCurveSegmentType AbstractCurveSegmentTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractCurveSegmentType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractCurveType AbstractCurveTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractCurveType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractDatumBaseType AbstractDatumBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractDatumBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractDatumType AbstractDatumTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractDatumType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractDiscreteCoverageType AbstractDiscreteCoverageTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractDiscreteCoverageType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractFeatureCollectionType AbstractFeatureCollectionTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractFeatureCollectionType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractFeatureType AbstractFeatureTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractFeatureType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractGeneralConversionType AbstractGeneralConversionTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractGeneralConversionType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractGeneralDerivedCRSType AbstractGeneralDerivedCRSTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractGeneralDerivedCRSType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractGeneralOperationParameterType AbstractGeneralOperationParameterTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractGeneralOperationParameterType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractGeneralParameterValueType AbstractGeneralParameterValueTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractGeneralParameterValueType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractGeneralTransformationType AbstractGeneralTransformationTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractGeneralTransformationType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractGeometricAggregateType AbstractGeometricAggregateTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractGeometricAggregateType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractGeometricPrimitiveType AbstractGeometricPrimitiveTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractGeometricPrimitiveType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractGeometryType AbstractGeometryTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractGeometryType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractGMLType AbstractGMLTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractGMLType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractMetaDataType AbstractMetaDataTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractMetaDataType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractPositionalAccuracyType AbstractPositionalAccuracyTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractPositionalAccuracyType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractReferenceSystemBaseType AbstractReferenceSystemBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractReferenceSystemBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractReferenceSystemType AbstractReferenceSystemTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractReferenceSystemType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractRingType AbstractRingTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractRingType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractStyleType AbstractStyleTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractStyleType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractSurfacePatchType AbstractSurfacePatchTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractSurfacePatchType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractTimeComplexType AbstractTimeComplexTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractTimeComplexType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractTimeGeometricPrimitiveType AbstractTimeGeometricPrimitiveTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractTimeGeometricPrimitiveType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractTimeObjectType AbstractTimeObjectTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractTimeObjectType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractTimePrimitiveType AbstractTimePrimitiveTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractTimePrimitiveType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractTimeReferenceSystemType AbstractTimeReferenceSystemTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractTimeReferenceSystemType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractTimeSliceType AbstractTimeSliceTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractTimeSliceType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractTimeTopologyPrimitiveType AbstractTimeTopologyPrimitiveTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractTimeTopologyPrimitiveType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractTopologyType AbstractTopologyTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractTopologyType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public AbstractTopoPrimitiveType AbstractTopoPrimitiveTypeCreateObject(XmlElement xmlParent)
		{
			AE.AbstractTopoPrimitiveType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public BoundedFeatureType BoundedFeatureTypeCreateObject(XmlElement xmlParent)
		{
			AE.BoundedFeatureType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public CoordinateSystemAxisBaseType CoordinateSystemAxisBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.CoordinateSystemAxisBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public EllipsoidBaseType EllipsoidBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.EllipsoidBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_association I_associationCreateObject(XmlElement xmlParent)
		{
			AE.I_association retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._associationCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_ContinuousCoverage I_ContinuousCoverageCreateObject(XmlElement xmlParent)
		{
			AE.I_ContinuousCoverage retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._ContinuousCoverageCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_CoordinateOperation I_CoordinateOperationCreateObject(XmlElement xmlParent)
		{
			AE.I_CoordinateOperation retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._CoordinateOperationCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_CoordinateReferenceSystem I_CoordinateReferenceSystemCreateObject(XmlElement xmlParent)
		{
			AE.I_CoordinateReferenceSystem retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._CoordinateReferenceSystemCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_CoordinateSystem I_CoordinateSystemCreateObject(XmlElement xmlParent)
		{
			AE.I_CoordinateSystem retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._CoordinateSystemCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_Coverage I_CoverageCreateObject(XmlElement xmlParent)
		{
			AE.I_Coverage retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._CoverageCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_CRS I_CRSCreateObject(XmlElement xmlParent)
		{
			AE.I_CRS retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._CRSCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_Curve I_CurveCreateObject(XmlElement xmlParent)
		{
			AE.I_Curve retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._CurveCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_CurveSegment I_CurveSegmentCreateObject(XmlElement xmlParent)
		{
			AE.I_CurveSegment retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._CurveSegmentCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_Datum I_DatumCreateObject(XmlElement xmlParent)
		{
			AE.I_Datum retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._DatumCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_DiscreteCoverage I_DiscreteCoverageCreateObject(XmlElement xmlParent)
		{
			AE.I_DiscreteCoverage retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._DiscreteCoverageCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_Feature I_FeatureCreateObject(XmlElement xmlParent)
		{
			AE.I_Feature retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._FeatureCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_FeatureCollection I_FeatureCollectionCreateObject(XmlElement xmlParent)
		{
			AE.I_FeatureCollection retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._FeatureCollectionCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_GeneralConversion I_GeneralConversionCreateObject(XmlElement xmlParent)
		{
			AE.I_GeneralConversion retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._GeneralConversionCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_GeneralDerivedCRS I_GeneralDerivedCRSCreateObject(XmlElement xmlParent)
		{
			AE.I_GeneralDerivedCRS retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._GeneralDerivedCRSCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_GeneralOperationParameter I_GeneralOperationParameterCreateObject(XmlElement xmlParent)
		{
			AE.I_GeneralOperationParameter retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._GeneralOperationParameterCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_generalParameterValue I_generalParameterValueCreateObject(XmlElement xmlParent)
		{
			AE.I_generalParameterValue retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._generalParameterValueCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_GeneralTransformation I_GeneralTransformationCreateObject(XmlElement xmlParent)
		{
			AE.I_GeneralTransformation retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._GeneralTransformationCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_GeometricAggregate I_GeometricAggregateCreateObject(XmlElement xmlParent)
		{
			AE.I_GeometricAggregate retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._GeometricAggregateCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_GeometricPrimitive I_GeometricPrimitiveCreateObject(XmlElement xmlParent)
		{
			AE.I_GeometricPrimitive retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._GeometricPrimitiveCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_Geometry I_GeometryCreateObject(XmlElement xmlParent)
		{
			AE.I_Geometry retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._GeometryCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_GML I_GMLCreateObject(XmlElement xmlParent)
		{
			AE.I_GML retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._GMLCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_GriddedSurface I_GriddedSurfaceCreateObject(XmlElement xmlParent)
		{
			AE.I_GriddedSurface retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._GriddedSurfaceCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_ImplicitGeometry I_ImplicitGeometryCreateObject(XmlElement xmlParent)
		{
			AE.I_ImplicitGeometry retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._ImplicitGeometryCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_MetaData I_MetaDataCreateObject(XmlElement xmlParent)
		{
			AE.I_MetaData retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._MetaDataCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_Object I_ObjectCreateObject(XmlElement xmlParent)
		{
			AE.I_Object retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._ObjectCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_Operation I_OperationCreateObject(XmlElement xmlParent)
		{
			AE.I_Operation retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._OperationCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_ParametricCurveSurface I_ParametricCurveSurfaceCreateObject(XmlElement xmlParent)
		{
			AE.I_ParametricCurveSurface retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._ParametricCurveSurfaceCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_positionalAccuracy I_positionalAccuracyCreateObject(XmlElement xmlParent)
		{
			AE.I_positionalAccuracy retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._positionalAccuracyCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_reference I_referenceCreateObject(XmlElement xmlParent)
		{
			AE.I_reference retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._referenceCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_ReferenceSystem I_ReferenceSystemCreateObject(XmlElement xmlParent)
		{
			AE.I_ReferenceSystem retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._ReferenceSystemCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_Ring I_RingCreateObject(XmlElement xmlParent)
		{
			AE.I_Ring retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._RingCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_SingleOperation I_SingleOperationCreateObject(XmlElement xmlParent)
		{
			AE.I_SingleOperation retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._SingleOperationCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_Solid I_SolidCreateObject(XmlElement xmlParent)
		{
			AE.I_Solid retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._SolidCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_strictAssociation I_strictAssociationCreateObject(XmlElement xmlParent)
		{
			AE.I_strictAssociation retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._strictAssociationCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_Style I_StyleCreateObject(XmlElement xmlParent)
		{
			AE.I_Style retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._StyleCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_Surface I_SurfaceCreateObject(XmlElement xmlParent)
		{
			AE.I_Surface retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._SurfaceCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_SurfacePatch I_SurfacePatchCreateObject(XmlElement xmlParent)
		{
			AE.I_SurfacePatch retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._SurfacePatchCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_TimeComplex I_TimeComplexCreateObject(XmlElement xmlParent)
		{
			AE.I_TimeComplex retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._TimeComplexCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_TimeGeometricPrimitive I_TimeGeometricPrimitiveCreateObject(XmlElement xmlParent)
		{
			AE.I_TimeGeometricPrimitive retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._TimeGeometricPrimitiveCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_TimeObject I_TimeObjectCreateObject(XmlElement xmlParent)
		{
			AE.I_TimeObject retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._TimeObjectCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_TimePrimitive I_TimePrimitiveCreateObject(XmlElement xmlParent)
		{
			AE.I_TimePrimitive retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._TimePrimitiveCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_TimeReferenceSystem I_TimeReferenceSystemCreateObject(XmlElement xmlParent)
		{
			AE.I_TimeReferenceSystem retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._TimeReferenceSystemCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_TimeSlice I_TimeSliceCreateObject(XmlElement xmlParent)
		{
			AE.I_TimeSlice retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._TimeSliceCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_TimeTopologyPrimitive I_TimeTopologyPrimitiveCreateObject(XmlElement xmlParent)
		{
			AE.I_TimeTopologyPrimitive retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._TimeTopologyPrimitiveCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_Topology I_TopologyCreateObject(XmlElement xmlParent)
		{
			AE.I_Topology retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._TopologyCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public I_TopoPrimitive I_TopoPrimitiveCreateObject(XmlElement xmlParent)
		{
			AE.I_TopoPrimitive retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory._TopoPrimitiveCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractContinuousCoverageType IAbstractContinuousCoverageTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractContinuousCoverageType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractContinuousCoverageTypeCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractCoordinateOperationBaseType IAbstractCoordinateOperationBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractCoordinateOperationBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractCoordinateOperationBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._OperationCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_OperationCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._SingleOperationCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_SingleOperationCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractCoordinateOperationTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractCoordinateOperationTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._CoordinateOperationCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_CoordinateOperationCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractCoordinateOperationType IAbstractCoordinateOperationTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractCoordinateOperationType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractCoordinateOperationTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "PassThroughOperation"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.PassThroughOperation();
			if (retVal == null && typeName == "PassThroughOperationType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.PassThroughOperationType();
			if (retVal == null)
				retVal = AE.ClassFactory._GeneralConversionCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_GeneralConversionCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractGeneralConversionTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractGeneralConversionTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractGeneralTransformationTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractGeneralTransformationTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "ConcatenatedOperation"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ConcatenatedOperation();
			if (retVal == null && typeName == "ConcatenatedOperationType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ConcatenatedOperationType();
			if (retVal == null)
				retVal = AE.ClassFactory._GeneralTransformationCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_GeneralTransformationCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractCoordinateSystemBaseType IAbstractCoordinateSystemBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractCoordinateSystemBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractCoordinateSystemBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractCoordinateSystemTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractCoordinateSystemTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._CoordinateSystemCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_CoordinateSystemCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractCoordinateSystemType IAbstractCoordinateSystemTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractCoordinateSystemType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractCoordinateSystemTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "TemporalCS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TemporalCS();
			if (retVal == null && typeName == "TemporalCSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TemporalCSType();
			if (retVal == null && typeName == "UserDefinedCS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.UserDefinedCS();
			if (retVal == null && typeName == "UserDefinedCSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.UserDefinedCSType();
			if (retVal == null && typeName == "SphericalCS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.SphericalCS();
			if (retVal == null && typeName == "SphericalCSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.SphericalCSType();
			if (retVal == null && typeName == "ObliqueCartesianCS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ObliqueCartesianCS();
			if (retVal == null && typeName == "ObliqueCartesianCSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ObliqueCartesianCSType();
			if (retVal == null && typeName == "EllipsoidalCS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.EllipsoidalCS();
			if (retVal == null && typeName == "EllipsoidalCSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.EllipsoidalCSType();
			if (retVal == null && typeName == "PolarCS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.PolarCS();
			if (retVal == null && typeName == "PolarCSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.PolarCSType();
			if (retVal == null && typeName == "CartesianCS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CartesianCS();
			if (retVal == null && typeName == "CartesianCSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CartesianCSType();
			if (retVal == null && typeName == "VerticalCS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.VerticalCS();
			if (retVal == null && typeName == "VerticalCSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.VerticalCSType();
			if (retVal == null && typeName == "CylindricalCS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CylindricalCS();
			if (retVal == null && typeName == "CylindricalCSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CylindricalCSType();
			if (retVal == null && typeName == "LinearCS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.LinearCS();
			if (retVal == null && typeName == "LinearCSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.LinearCSType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractCoverageType IAbstractCoverageTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractCoverageType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractCoverageTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractDiscreteCoverageTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractDiscreteCoverageTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._ContinuousCoverageCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_ContinuousCoverageCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._DiscreteCoverageCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_DiscreteCoverageCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractContinuousCoverageTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractContinuousCoverageTypeCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractCurveSegmentType IAbstractCurveSegmentTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractCurveSegmentType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractCurveSegmentTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "ArcByCenterPointType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ArcByCenterPointType();
			if (retVal == null)
				retVal = AE.ClassFactory.IArcByCenterPointTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "OffsetCurve"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.OffsetCurve();
			if (retVal == null && typeName == "OffsetCurveType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.OffsetCurveType();
			if (retVal == null && typeName == "BSplineType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.BSplineType();
			if (retVal == null)
				retVal = AE.ClassFactory.IBSplineTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "GeodesicString"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GeodesicString();
			if (retVal == null && typeName == "GeodesicStringType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GeodesicStringType();
			if (retVal == null)
				retVal = AE.ClassFactory.IGeodesicStringTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "ArcString"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ArcString();
			if (retVal == null && typeName == "ArcStringType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ArcStringType();
			if (retVal == null)
				retVal = AE.ClassFactory.IArcStringTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "LineStringSegment"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.LineStringSegment();
			if (retVal == null && typeName == "LineStringSegmentType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.LineStringSegmentType();
			if (retVal == null && typeName == "Clothoid"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Clothoid();
			if (retVal == null && typeName == "ClothoidType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ClothoidType();
			if (retVal == null && typeName == "ArcStringByBulge"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ArcStringByBulge();
			if (retVal == null && typeName == "ArcStringByBulgeType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ArcStringByBulgeType();
			if (retVal == null)
				retVal = AE.ClassFactory.IArcStringByBulgeTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "ArcByCenterPoint"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ArcByCenterPoint();
			if (retVal == null && typeName == "CubicSpline"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CubicSpline();
			if (retVal == null && typeName == "CubicSplineType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CubicSplineType();
			if (retVal == null && typeName == "BSpline"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.BSpline();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractCurveType IAbstractCurveTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractCurveType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractCurveTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "CompositeCurve"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CompositeCurve();
			if (retVal == null && typeName == "CompositeCurveType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CompositeCurveType();
			if (retVal == null && typeName == "LineString"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.LineString();
			if (retVal == null && typeName == "LineStringType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.LineStringType();
			if (retVal == null && typeName == "OrientableCurve"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.OrientableCurve();
			if (retVal == null && typeName == "OrientableCurveType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.OrientableCurveType();
			if (retVal == null && typeName == "Curve"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Curve();
			if (retVal == null && typeName == "CurveType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CurveType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractDatumBaseType IAbstractDatumBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractDatumBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractDatumBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractDatumTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractDatumTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._DatumCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_DatumCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractDatumType IAbstractDatumTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractDatumType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractDatumTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.TemporalDatumBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.ITemporalDatumBaseTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "EngineeringDatum"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.EngineeringDatum();
			if (retVal == null && typeName == "EngineeringDatumType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.EngineeringDatumType();
			if (retVal == null && typeName == "VerticalDatum"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.VerticalDatum();
			if (retVal == null && typeName == "VerticalDatumType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.VerticalDatumTypeA();
			if (retVal == null && typeName == "GeodeticDatum"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GeodeticDatum();
			if (retVal == null && typeName == "GeodeticDatumType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GeodeticDatumType();
			if (retVal == null && typeName == "ImageDatum"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ImageDatum();
			if (retVal == null && typeName == "ImageDatumType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ImageDatumType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractDiscreteCoverageType IAbstractDiscreteCoverageTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractDiscreteCoverageType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractDiscreteCoverageTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "MultiSurfaceCoverage"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiSurfaceCoverage();
			if (retVal == null && typeName == "MultiSurfaceCoverageType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiSurfaceCoverageType();
			if (retVal == null && typeName == "GridCoverage"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GridCoverage();
			if (retVal == null && typeName == "GridCoverageType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GridCoverageType();
			if (retVal == null && typeName == "MultiPointCoverage"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiPointCoverage();
			if (retVal == null && typeName == "MultiPointCoverageType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiPointCoverageType();
			if (retVal == null && typeName == "MultiSolidCoverage"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiSolidCoverage();
			if (retVal == null && typeName == "MultiSolidCoverageType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiSolidCoverageType();
			if (retVal == null && typeName == "RectifiedGridCoverage"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.RectifiedGridCoverage();
			if (retVal == null && typeName == "RectifiedGridCoverageType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.RectifiedGridCoverageType();
			if (retVal == null && typeName == "MultiCurveCoverage"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiCurveCoverage();
			if (retVal == null && typeName == "MultiCurveCoverageType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiCurveCoverageType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractFeatureCollectionType IAbstractFeatureCollectionTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractFeatureCollectionType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractFeatureCollectionTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "FeatureCollection"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.FeatureCollection();
			if (retVal == null && typeName == "FeatureCollectionType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.FeatureCollectionType();
			if (retVal == null)
				retVal = AE.ClassFactory.IFeatureCollectionTypeCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractFeatureType IAbstractFeatureTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractFeatureType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractFeatureTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "Observation"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Observation();
			if (retVal == null && typeName == "ObservationType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ObservationType();
			if (retVal == null)
				retVal = AE.ClassFactory.IObservationTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractCoverageTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractCoverageTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._FeatureCollectionCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_FeatureCollectionCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractFeatureCollectionTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractFeatureCollectionTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._CoverageCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_CoverageCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.BoundedFeatureTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IBoundedFeatureTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "DynamicFeatureType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DynamicFeatureType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractGeneralConversionType IAbstractGeneralConversionTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractGeneralConversionType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractGeneralConversionTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "Conversion"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Conversion();
			if (retVal == null && typeName == "ConversionType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ConversionType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractGeneralDerivedCRSType IAbstractGeneralDerivedCRSTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractGeneralDerivedCRSType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractGeneralDerivedCRSTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "ProjectedCRS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ProjectedCRS();
			if (retVal == null && typeName == "ProjectedCRSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ProjectedCRSType();
			if (retVal == null && typeName == "DerivedCRS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DerivedCRS();
			if (retVal == null && typeName == "DerivedCRSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DerivedCRSTypeA();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractGeneralOperationParameterType IAbstractGeneralOperationParameterTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractGeneralOperationParameterType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractGeneralOperationParameterTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.OperationParameterBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IOperationParameterBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.OperationParameterGroupBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IOperationParameterGroupBaseTypeCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractGeneralParameterValueType IAbstractGeneralParameterValueTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractGeneralParameterValueType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractGeneralParameterValueTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "includesValue"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.IncludesValue();
			if (retVal == null && typeName == "usesValue"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.UsesValue();
			if (retVal == null && typeName == "ParameterValueType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ParameterValueType();
			if (retVal == null && typeName == "parameterValueGroup"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ParameterValueGroup();
			if (retVal == null && typeName == "ParameterValueGroupType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ParameterValueGroupType();
			if (retVal == null && typeName == "parameterValue"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ParameterValue();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractGeneralTransformationType IAbstractGeneralTransformationTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractGeneralTransformationType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractGeneralTransformationTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "Transformation"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Transformation();
			if (retVal == null && typeName == "TransformationType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TransformationType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractGeometricAggregateType IAbstractGeometricAggregateTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractGeometricAggregateType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractGeometricAggregateTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "MultiSolid"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiSolid();
			if (retVal == null && typeName == "MultiSolidType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiSolidType();
			if (retVal == null && typeName == "MultiLineString"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiLineString();
			if (retVal == null && typeName == "MultiLineStringType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiLineStringType();
			if (retVal == null && typeName == "MultiPolygon"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiPolygon();
			if (retVal == null && typeName == "MultiPolygonType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiPolygonType();
			if (retVal == null && typeName == "MultiCurve"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiCurve();
			if (retVal == null && typeName == "MultiCurveType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiCurveType();
			if (retVal == null && typeName == "MultiGeometry"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiGeometry();
			if (retVal == null && typeName == "MultiGeometryType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiGeometryType();
			if (retVal == null && typeName == "MultiPoint"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiPoint();
			if (retVal == null && typeName == "MultiPointType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiPointType();
			if (retVal == null && typeName == "MultiSurface"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiSurface();
			if (retVal == null && typeName == "MultiSurfaceType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiSurfaceType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractGeometricPrimitiveType IAbstractGeometricPrimitiveTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractGeometricPrimitiveType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractGeometricPrimitiveTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractCurveTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractCurveTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._SurfaceCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_SurfaceCreateObject(xmlParent);
			if (retVal == null && typeName == "AbstractSurfaceType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.AbstractSurfaceType();
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractSurfaceTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "AbstractSolidType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.AbstractSolidType();
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractSolidTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._CurveCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_CurveCreateObject(xmlParent);
			if (retVal == null && typeName == "Point"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Point();
			if (retVal == null && typeName == "PointType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.PointType();
			if (retVal == null)
				retVal = AE.ClassFactory._SolidCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_SolidCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractGeometryType IAbstractGeometryTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractGeometryType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractGeometryTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractGeometricPrimitiveTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractGeometricPrimitiveTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractGeometricAggregateTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractGeometricAggregateTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "Grid"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Grid();
			if (retVal == null && typeName == "GridType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GridType();
			if (retVal == null)
				retVal = AE.ClassFactory.IGridTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._GeometricPrimitiveCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_GeometricPrimitiveCreateObject(xmlParent);
			if (retVal == null && typeName == "GeometricComplex"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GeometricComplex();
			if (retVal == null && typeName == "GeometricComplexType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GeometricComplexType();
			if (retVal == null)
				retVal = AE.ClassFactory._RingCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_RingCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractRingTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractRingTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._GeometricAggregateCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_GeometricAggregateCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractGMLType IAbstractGMLTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractGMLType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractGMLTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "DefinitionType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DefinitionType();
			if (retVal == null)
				retVal = AE.ClassFactory.IDefinitionTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractGeometryTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractGeometryTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "Bag"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Bag();
			if (retVal == null && typeName == "BagType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.BagType();
			if (retVal == null)
				retVal = AE.ClassFactory._GeometryCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_GeometryCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractTopologyTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractTopologyTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractTimeObjectTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractTimeObjectTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "Array"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Array();
			if (retVal == null && typeName == "ArrayType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ArrayType();
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractFeatureTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractFeatureTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._TopologyCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_TopologyCreateObject(xmlParent);
			if (retVal == null && typeName == "Definition"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Definition();
			if (retVal == null)
				retVal = AE.ClassFactory._TimeObjectCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_TimeObjectCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractTimeSliceTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractTimeSliceTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "CompositeValueType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CompositeValueType();
			if (retVal == null)
				retVal = AE.ClassFactory.ICompositeValueTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._StyleCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_StyleCreateObject(xmlParent);
			if (retVal == null && typeName == "BaseStyleDescriptorType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.BaseStyleDescriptorType();
			if (retVal == null)
				retVal = AE.ClassFactory.IBaseStyleDescriptorTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._TimeSliceCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_TimeSliceCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._FeatureCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_FeatureCreateObject(xmlParent);
			if (retVal == null && typeName == "FeatureStyle"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.FeatureStyleA();
			if (retVal == null && typeName == "FeatureStyleType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.FeatureStyleType();
			if (retVal == null)
				retVal = AE.ClassFactory._ImplicitGeometryCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_ImplicitGeometryCreateObject(xmlParent);
			if (retVal == null && typeName == "CompositeValue"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CompositeValue();
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractStyleTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractStyleTypeCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractGriddedSurfaceType IAbstractGriddedSurfaceTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractGriddedSurfaceType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.AbstractGriddedSurfaceType();
		
			
			if (retVal == null && typeName == "AbstractGriddedSurfaceType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.AbstractGriddedSurfaceType();
			if (retVal == null && typeName == "Cone"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Cone();
			if (retVal == null && typeName == "ConeType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ConeType();
			if (retVal == null && typeName == "Cylinder"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Cylinder();
			if (retVal == null && typeName == "CylinderType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CylinderType();
			if (retVal == null && typeName == "Sphere"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Sphere();
			if (retVal == null && typeName == "SphereType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.SphereType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractMetaDataType IAbstractMetaDataTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractMetaDataType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractMetaDataTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "GenericMetaData"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GenericMetaData();
			if (retVal == null && typeName == "GenericMetaDataType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GenericMetaDataType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractParametricCurveSurfaceType IAbstractParametricCurveSurfaceTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractParametricCurveSurfaceType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.AbstractParametricCurveSurfaceType();
		
			
			if (retVal == null && typeName == "AbstractParametricCurveSurfaceType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.AbstractParametricCurveSurfaceType();
			if (retVal == null)
				retVal = AE.ClassFactory._GriddedSurfaceCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_GriddedSurfaceCreateObject(xmlParent);
			if (retVal == null && typeName == "AbstractGriddedSurfaceType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.AbstractGriddedSurfaceType();
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractGriddedSurfaceTypeCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractPositionalAccuracyType IAbstractPositionalAccuracyTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractPositionalAccuracyType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractPositionalAccuracyTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "relativeInternalPositionalAccuracy"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.RelativeInternalPositionalAccuracy();
			if (retVal == null && typeName == "RelativeInternalPositionalAccuracyType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.RelativeInternalPositionalAccuracyType();
			if (retVal == null && typeName == "covarianceMatrix"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CovarianceMatrix();
			if (retVal == null && typeName == "CovarianceMatrixType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CovarianceMatrixType();
			if (retVal == null && typeName == "absoluteExternalPositionalAccuracy"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.AbsoluteExternalPositionalAccuracy();
			if (retVal == null && typeName == "AbsoluteExternalPositionalAccuracyType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.AbsoluteExternalPositionalAccuracyType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractReferenceSystemBaseType IAbstractReferenceSystemBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractReferenceSystemBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractReferenceSystemBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractReferenceSystemTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractReferenceSystemTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._CRSCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_CRSCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._CoordinateReferenceSystemCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_CoordinateReferenceSystemCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._ReferenceSystemCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_ReferenceSystemCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractReferenceSystemType IAbstractReferenceSystemTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractReferenceSystemType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractReferenceSystemTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "EngineeringCRS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.EngineeringCRS();
			if (retVal == null && typeName == "EngineeringCRSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.EngineeringCRSType();
			if (retVal == null && typeName == "GeographicCRS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GeographicCRS();
			if (retVal == null && typeName == "GeographicCRSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GeographicCRSType();
			if (retVal == null && typeName == "TemporalCRS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TemporalCRS();
			if (retVal == null && typeName == "TemporalCRSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TemporalCRSType();
			if (retVal == null && typeName == "ImageCRS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ImageCRS();
			if (retVal == null && typeName == "ImageCRSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ImageCRSType();
			if (retVal == null && typeName == "CompoundCRS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CompoundCRS();
			if (retVal == null && typeName == "CompoundCRSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CompoundCRSType();
			if (retVal == null && typeName == "GeocentricCRS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GeocentricCRS();
			if (retVal == null && typeName == "GeocentricCRSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GeocentricCRSType();
			if (retVal == null)
				retVal = AE.ClassFactory._GeneralDerivedCRSCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_GeneralDerivedCRSCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractGeneralDerivedCRSTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractGeneralDerivedCRSTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "VerticalCRS"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.VerticalCRS();
			if (retVal == null && typeName == "VerticalCRSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.VerticalCRSType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractRingPropertyType IAbstractRingPropertyTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractRingPropertyType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.AbstractRingPropertyType();
		
			
			if (retVal == null && typeName == "AbstractRingPropertyType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.AbstractRingPropertyType();
			if (retVal == null && typeName == "innerBoundaryIs"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.InnerBoundaryIs();
			if (retVal == null && typeName == "outerBoundaryIs"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.OuterBoundaryIs();
			if (retVal == null && typeName == "interior"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Interior();
			if (retVal == null && typeName == "exterior"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Exterior();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractRingType IAbstractRingTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractRingType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractRingTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "LinearRing"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.LinearRing();
			if (retVal == null && typeName == "LinearRingType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.LinearRingType();
			if (retVal == null && typeName == "Ring"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Ring();
			if (retVal == null && typeName == "RingType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.RingType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractSolidType IAbstractSolidTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractSolidType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.AbstractSolidType();
		
			
			if (retVal == null && typeName == "AbstractSolidType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.AbstractSolidType();
			if (retVal == null && typeName == "CompositeSolid"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CompositeSolid();
			if (retVal == null && typeName == "CompositeSolidType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CompositeSolidType();
			if (retVal == null && typeName == "Solid"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Solid();
			if (retVal == null && typeName == "SolidType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.SolidType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractStyleType IAbstractStyleTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractStyleType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractStyleTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "Style"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Style();
			if (retVal == null && typeName == "StyleType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.StyleType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractSurfacePatchType IAbstractSurfacePatchTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractSurfacePatchType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractSurfacePatchTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._ParametricCurveSurfaceCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_ParametricCurveSurfaceCreateObject(xmlParent);
			if (retVal == null && typeName == "PolygonPatch"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.PolygonPatch();
			if (retVal == null && typeName == "PolygonPatchType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.PolygonPatchType();
			if (retVal == null && typeName == "Triangle"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Triangle();
			if (retVal == null && typeName == "TriangleType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TriangleType();
			if (retVal == null && typeName == "Rectangle"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Rectangle();
			if (retVal == null && typeName == "RectangleType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.RectangleType();
			if (retVal == null && typeName == "AbstractParametricCurveSurfaceType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.AbstractParametricCurveSurfaceType();
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractParametricCurveSurfaceTypeCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractSurfaceType IAbstractSurfaceTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractSurfaceType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.AbstractSurfaceType();
		
			
			if (retVal == null && typeName == "AbstractSurfaceType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.AbstractSurfaceType();
			if (retVal == null && typeName == "SurfaceType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.SurfaceType();
			if (retVal == null)
				retVal = AE.ClassFactory.ISurfaceTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "CompositeSurface"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CompositeSurface();
			if (retVal == null && typeName == "CompositeSurfaceType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CompositeSurfaceType();
			if (retVal == null && typeName == "boundingPolygon"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.BoundingPolygon();
			if (retVal == null && typeName == "PolygonType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.PolygonType();
			if (retVal == null && typeName == "Polygon"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Polygon();
			if (retVal == null && typeName == "Surface"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Surface();
			if (retVal == null && typeName == "OrientableSurface"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.OrientableSurface();
			if (retVal == null && typeName == "OrientableSurfaceType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.OrientableSurfaceType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractTimeComplexType IAbstractTimeComplexTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractTimeComplexType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractTimeComplexTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "TimeTopologyComplex"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeTopologyComplex();
			if (retVal == null && typeName == "TimeTopologyComplexType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeTopologyComplexType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractTimeGeometricPrimitiveType IAbstractTimeGeometricPrimitiveTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractTimeGeometricPrimitiveType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractTimeGeometricPrimitiveTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "TimeInstant"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeInstant();
			if (retVal == null && typeName == "TimeInstantType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeInstantType();
			if (retVal == null && typeName == "TimePeriod"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimePeriod();
			if (retVal == null && typeName == "TimePeriodType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimePeriodType();
			if (retVal == null && typeName == "temporalExtent"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TemporalExtent();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractTimeObjectType IAbstractTimeObjectTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractTimeObjectType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractTimeObjectTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractTimePrimitiveTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractTimePrimitiveTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._TimeComplexCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_TimeComplexCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._TimePrimitiveCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_TimePrimitiveCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractTimeComplexTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractTimeComplexTypeCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractTimePrimitiveType IAbstractTimePrimitiveTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractTimePrimitiveType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractTimePrimitiveTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._TimeTopologyPrimitiveCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_TimeTopologyPrimitiveCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._TimeGeometricPrimitiveCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_TimeGeometricPrimitiveCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractTimeGeometricPrimitiveTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractTimeGeometricPrimitiveTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractTimeTopologyPrimitiveTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractTimeTopologyPrimitiveTypeCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractTimeReferenceSystemType IAbstractTimeReferenceSystemTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractTimeReferenceSystemType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractTimeReferenceSystemTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "TimeClock"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeClock();
			if (retVal == null && typeName == "TimeClockType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeClockType();
			if (retVal == null && typeName == "TimeOrdinalReferenceSystem"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeOrdinalReferenceSystem();
			if (retVal == null && typeName == "TimeOrdinalReferenceSystemType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeOrdinalReferenceSystemType();
			if (retVal == null && typeName == "TimeCoordinateSystem"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeCoordinateSystem();
			if (retVal == null && typeName == "TimeCoordinateSystemType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeCoordinateSystemType();
			if (retVal == null && typeName == "TimeCalendar"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeCalendar();
			if (retVal == null && typeName == "TimeCalendarType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeCalendarType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractTimeSliceType IAbstractTimeSliceTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractTimeSliceType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractTimeSliceTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "MovingObjectStatus"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MovingObjectStatus();
			if (retVal == null && typeName == "MovingObjectStatusType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MovingObjectStatusType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractTimeTopologyPrimitiveType IAbstractTimeTopologyPrimitiveTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractTimeTopologyPrimitiveType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractTimeTopologyPrimitiveTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "TimeNode"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeNode();
			if (retVal == null && typeName == "TimeNodeType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeNodeType();
			if (retVal == null && typeName == "TimeEdge"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeEdge();
			if (retVal == null && typeName == "TimeEdgeType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeEdgeType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractTopologyType IAbstractTopologyTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractTopologyType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractTopologyTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractTopoPrimitiveTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractTopoPrimitiveTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "TopoCurve"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TopoCurve();
			if (retVal == null && typeName == "TopoCurveType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TopoCurveType();
			if (retVal == null && typeName == "TopoVolume"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TopoVolume();
			if (retVal == null && typeName == "TopoVolumeType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TopoVolumeType();
			if (retVal == null && typeName == "TopoSurface"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TopoSurface();
			if (retVal == null && typeName == "TopoSurfaceType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TopoSurfaceType();
			if (retVal == null && typeName == "TopoPoint"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TopoPoint();
			if (retVal == null && typeName == "TopoPointType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TopoPointType();
			if (retVal == null && typeName == "TopoComplex"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TopoComplex();
			if (retVal == null && typeName == "TopoComplexType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TopoComplexType();
			if (retVal == null)
				retVal = AE.ClassFactory._TopoPrimitiveCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_TopoPrimitiveCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IAbstractTopoPrimitiveType IAbstractTopoPrimitiveTypeCreateObject(XmlElement xmlParent)
		{
			AE.IAbstractTopoPrimitiveType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractTopoPrimitiveTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "Node"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Node();
			if (retVal == null && typeName == "NodeType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.NodeType();
			if (retVal == null && typeName == "Face"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Face();
			if (retVal == null && typeName == "FaceType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.FaceType();
			if (retVal == null && typeName == "Edge"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Edge();
			if (retVal == null && typeName == "EdgeType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.EdgeType();
			if (retVal == null && typeName == "TopoSolid"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TopoSolid();
			if (retVal == null && typeName == "TopoSolidType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TopoSolidType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IArcByCenterPointType IArcByCenterPointTypeCreateObject(XmlElement xmlParent)
		{
			AE.IArcByCenterPointType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.ArcByCenterPointType();
		
			
			if (retVal == null && typeName == "ArcByCenterPointType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ArcByCenterPointType();
			if (retVal == null && typeName == "CircleByCenterPoint"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CircleByCenterPoint();
			if (retVal == null && typeName == "CircleByCenterPointType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CircleByCenterPointType();
			if (retVal == null && typeName == "ArcByCenterPoint"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ArcByCenterPoint();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IArcStringByBulgeType IArcStringByBulgeTypeCreateObject(XmlElement xmlParent)
		{
			AE.IArcStringByBulgeType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.ArcStringByBulgeType();
		
			
			if (retVal == null && typeName == "ArcStringByBulgeType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ArcStringByBulgeType();
			if (retVal == null && typeName == "ArcStringByBulge"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ArcStringByBulge();
			if (retVal == null && typeName == "ArcByBulge"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ArcByBulge();
			if (retVal == null && typeName == "ArcByBulgeType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ArcByBulgeType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IArcStringType IArcStringTypeCreateObject(XmlElement xmlParent)
		{
			AE.IArcStringType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.ArcStringType();
		
			
			if (retVal == null && typeName == "ArcStringType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ArcStringType();
			if (retVal == null && typeName == "ArcString"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ArcString();
			if (retVal == null && typeName == "ArcType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ArcType();
			if (retVal == null)
				retVal = AE.ClassFactory.IArcTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "Arc"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Arc();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IArcType IArcTypeCreateObject(XmlElement xmlParent)
		{
			AE.IArcType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.ArcType();
		
			
			if (retVal == null && typeName == "ArcType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ArcType();
			if (retVal == null && typeName == "Circle"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Circle();
			if (retVal == null && typeName == "CircleType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CircleType();
			if (retVal == null && typeName == "Arc"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Arc();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IBaseStyleDescriptorType IBaseStyleDescriptorTypeCreateObject(XmlElement xmlParent)
		{
			AE.IBaseStyleDescriptorType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.BaseStyleDescriptorType();
		
			
			if (retVal == null && typeName == "BaseStyleDescriptorType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.BaseStyleDescriptorType();
			if (retVal == null && typeName == "TopologyStyle"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TopologyStyleA();
			if (retVal == null && typeName == "TopologyStyleType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TopologyStyleType();
			if (retVal == null && typeName == "GraphStyle"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GraphStyleA();
			if (retVal == null && typeName == "GraphStyleType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GraphStyleType();
			if (retVal == null && typeName == "GeometryStyle"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GeometryStyleA();
			if (retVal == null && typeName == "GeometryStyleType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GeometryStyleType();
			if (retVal == null && typeName == "LabelStyle"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.LabelStyleA();
			if (retVal == null && typeName == "LabelStyleType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.LabelStyleType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IBoundedFeatureType IBoundedFeatureTypeCreateObject(XmlElement xmlParent)
		{
			AE.IBoundedFeatureType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.BoundedFeatureTypeCreateObject(xmlParent);
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IBSplineType IBSplineTypeCreateObject(XmlElement xmlParent)
		{
			AE.IBSplineType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.BSplineType();
		
			
			if (retVal == null && typeName == "BSplineType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.BSplineType();
			if (retVal == null && typeName == "Bezier"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Bezier();
			if (retVal == null && typeName == "BezierType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.BezierType();
			if (retVal == null && typeName == "BSpline"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.BSpline();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public ICodeOrNullListType ICodeOrNullListTypeCreateObject(XmlElement xmlParent)
		{
			AE.ICodeOrNullListType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.CodeOrNullListType();
		
			
			if (retVal == null && typeName == "CodeOrNullListType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CodeOrNullListType();
			if (retVal == null && typeName == "CategoryExtent"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CategoryExtent();
			if (retVal == null && typeName == "CategoryExtentType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CategoryExtentType();
			if (retVal == null && typeName == "CategoryList"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CategoryList();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public ICodeType ICodeTypeCreateObject(XmlElement xmlParent)
		{
			AE.ICodeType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.CodeType();
		
			
			if (retVal == null && typeName == "CodeType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CodeType();
			if (retVal == null && typeName == "anchorPoint"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.AnchorPoint();
			if (retVal == null && typeName == "methodFormula"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MethodFormula();
			if (retVal == null && typeName == "parameterName"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ParameterName();
			if (retVal == null && typeName == "srsName"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.SrsName();
			if (retVal == null && typeName == "derivedCRSType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DerivedCRSType();
			if (retVal == null && typeName == "DerivedCRSTypeType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DerivedCRSTypeType();
			if (retVal == null && typeName == "measureDescription"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MeasureDescription();
			if (retVal == null && typeName == "LocationKeyWord"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.LocationKeyWord();
			if (retVal == null && typeName == "coordinateOperationName"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CoordinateOperationName();
			if (retVal == null && typeName == "axisAbbrev"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.AxisAbbrev();
			if (retVal == null && typeName == "methodName"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MethodName();
			if (retVal == null && typeName == "pixelInCell"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.PixelInCell();
			if (retVal == null && typeName == "PixelInCellType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.PixelInCellType();
			if (retVal == null && typeName == "ellipsoidName"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.EllipsoidName();
			if (retVal == null && typeName == "meridianName"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MeridianName();
			if (retVal == null && typeName == "csName"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CsName();
			if (retVal == null && typeName == "groupName"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GroupName();
			if (retVal == null && typeName == "catalogSymbol"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CatalogSymbol();
			if (retVal == null && typeName == "name"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Name();
			if (retVal == null && typeName == "axisDirection"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.AxisDirection();
			if (retVal == null && typeName == "verticalDatumType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.VerticalDatumType();
			if (retVal == null && typeName == "VerticalDatumTypeType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.VerticalDatumTypeType();
			if (retVal == null && typeName == "datumName"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DatumName();
			if (retVal == null && typeName == "Category"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Category();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public ICompositeValueType ICompositeValueTypeCreateObject(XmlElement xmlParent)
		{
			AE.ICompositeValueType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.CompositeValueType();
		
			
			if (retVal == null && typeName == "CompositeValueType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CompositeValueType();
			if (retVal == null && typeName == "ValueArray"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ValueArray();
			if (retVal == null && typeName == "ValueArrayType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ValueArrayType();
			if (retVal == null && typeName == "CompositeValue"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CompositeValue();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public ICoordinateSystemAxisBaseType ICoordinateSystemAxisBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.ICoordinateSystemAxisBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.CoordinateSystemAxisBaseTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "CoordinateSystemAxis"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CoordinateSystemAxis();
			if (retVal == null && typeName == "CoordinateSystemAxisType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CoordinateSystemAxisType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IDefinitionType IDefinitionTypeCreateObject(XmlElement xmlParent)
		{
			AE.IDefinitionType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.DefinitionType();
		
			
			if (retVal == null && typeName == "DefinitionType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DefinitionType();
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractReferenceSystemBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractReferenceSystemBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractCoordinateOperationBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractCoordinateOperationBaseTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "DefinitionProxy"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DefinitionProxy();
			if (retVal == null && typeName == "DefinitionProxyType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DefinitionProxyType();
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractCoordinateSystemBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractCoordinateSystemBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractGeneralOperationParameterTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractGeneralOperationParameterTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "Dictionary"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Dictionary();
			if (retVal == null && typeName == "DictionaryType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DictionaryType();
			if (retVal == null && typeName == "TimeCalendarEra"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeCalendarEra();
			if (retVal == null && typeName == "TimeCalendarEraType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeCalendarEraType();
			if (retVal == null)
				retVal = AE.ClassFactory._TimeReferenceSystemCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_TimeReferenceSystemCreateObject(xmlParent);
			if (retVal == null && typeName == "UnitDefinitionType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.UnitDefinitionType();
			if (retVal == null)
				retVal = AE.ClassFactory.IUnitDefinitionTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory._GeneralOperationParameterCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.I_GeneralOperationParameterCreateObject(xmlParent);
			if (retVal == null && typeName == "Definition"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Definition();
			if (retVal == null)
				retVal = AE.ClassFactory.EllipsoidBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IEllipsoidBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractDatumBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractDatumBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.PrimeMeridianBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IPrimeMeridianBaseTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "DefinitionCollection"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DefinitionCollection();
			if (retVal == null && typeName == "UnitDefinition"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.UnitDefinition();
			if (retVal == null)
				retVal = AE.ClassFactory.AbstractTimeReferenceSystemTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IAbstractTimeReferenceSystemTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.OperationMethodBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.IOperationMethodBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.CoordinateSystemAxisBaseTypeCreateObject(xmlParent);
			if (retVal == null)
				retVal = AE.ClassFactory.ICoordinateSystemAxisBaseTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "TimeOrdinalEra"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeOrdinalEra();
			if (retVal == null && typeName == "TimeOrdinalEraType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeOrdinalEraType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IDictionaryEntryType IDictionaryEntryTypeCreateObject(XmlElement xmlParent)
		{
			AE.IDictionaryEntryType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.DictionaryEntryType();
		
			
			if (retVal == null && typeName == "DictionaryEntryType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DictionaryEntryType();
			if (retVal == null && typeName == "dictionaryEntry"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DictionaryEntry();
			if (retVal == null && typeName == "definitionMember"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DefinitionMember();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IDirectedObservationType IDirectedObservationTypeCreateObject(XmlElement xmlParent)
		{
			AE.IDirectedObservationType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.DirectedObservationType();
		
			
			if (retVal == null && typeName == "DirectedObservationType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DirectedObservationType();
			if (retVal == null && typeName == "DirectedObservationAtDistance"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DirectedObservationAtDistance();
			if (retVal == null && typeName == "DirectedObservationAtDistanceType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DirectedObservationAtDistanceType();
			if (retVal == null && typeName == "DirectedObservation"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DirectedObservation();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IDomainSetType IDomainSetTypeCreateObject(XmlElement xmlParent)
		{
			AE.IDomainSetType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.DomainSetType();
		
			
			if (retVal == null && typeName == "DomainSetType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DomainSetType();
			if (retVal == null && typeName == "multiSolidDomain"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiSolidDomain();
			if (retVal == null && typeName == "MultiSolidDomainType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiSolidDomainType();
			if (retVal == null && typeName == "multiPointDomain"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiPointDomain();
			if (retVal == null && typeName == "MultiPointDomainType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiPointDomainType();
			if (retVal == null && typeName == "gridDomain"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GridDomain();
			if (retVal == null && typeName == "GridDomainType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GridDomainType();
			if (retVal == null && typeName == "multiCurveDomain"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiCurveDomain();
			if (retVal == null && typeName == "MultiCurveDomainType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiCurveDomainType();
			if (retVal == null && typeName == "domainSet"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DomainSet();
			if (retVal == null && typeName == "rectifiedGridDomain"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.RectifiedGridDomain();
			if (retVal == null && typeName == "RectifiedGridDomainType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.RectifiedGridDomainType();
			if (retVal == null && typeName == "multiSurfaceDomain"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiSurfaceDomain();
			if (retVal == null && typeName == "MultiSurfaceDomainType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MultiSurfaceDomainType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IEllipsoidBaseType IEllipsoidBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.IEllipsoidBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.EllipsoidBaseTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "Ellipsoid"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Ellipsoid();
			if (retVal == null && typeName == "EllipsoidType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.EllipsoidType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IEnvelopeType IEnvelopeTypeCreateObject(XmlElement xmlParent)
		{
			AE.IEnvelopeType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.EnvelopeType();
		
			
			if (retVal == null && typeName == "EnvelopeType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.EnvelopeType();
			if (retVal == null && typeName == "EnvelopeWithTimePeriod"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.EnvelopeWithTimePeriod();
			if (retVal == null && typeName == "EnvelopeWithTimePeriodType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.EnvelopeWithTimePeriodType();
			if (retVal == null && typeName == "verticalExtent"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.VerticalExtent();
			if (retVal == null && typeName == "boundingBox"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.BoundingBox();
			if (retVal == null && typeName == "Envelope"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Envelope();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IFeatureCollectionType IFeatureCollectionTypeCreateObject(XmlElement xmlParent)
		{
			AE.IFeatureCollectionType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.FeatureCollectionType();
		
			
			if (retVal == null && typeName == "FeatureCollectionType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.FeatureCollectionType();
			if (retVal == null && typeName == "FeatureCollection"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.FeatureCollection();
			if (retVal == null && typeName == "DynamicFeatureCollectionType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DynamicFeatureCollectionType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IGeodesicStringType IGeodesicStringTypeCreateObject(XmlElement xmlParent)
		{
			AE.IGeodesicStringType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.GeodesicStringType();
		
			
			if (retVal == null && typeName == "GeodesicStringType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GeodesicStringType();
			if (retVal == null && typeName == "GeodesicString"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GeodesicString();
			if (retVal == null && typeName == "Geodesic"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Geodesic();
			if (retVal == null && typeName == "GeodesicType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GeodesicType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IGridFunctionType IGridFunctionTypeCreateObject(XmlElement xmlParent)
		{
			AE.IGridFunctionType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.GridFunctionType();
		
			
			if (retVal == null && typeName == "GridFunctionType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GridFunctionType();
			if (retVal == null && typeName == "IndexMap"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.IndexMap();
			if (retVal == null && typeName == "IndexMapType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.IndexMapType();
			if (retVal == null && typeName == "GridFunction"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GridFunction();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IGridType IGridTypeCreateObject(XmlElement xmlParent)
		{
			AE.IGridType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.GridType();
		
			
			if (retVal == null && typeName == "GridType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GridType();
			if (retVal == null && typeName == "Grid"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Grid();
			if (retVal == null && typeName == "RectifiedGrid"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.RectifiedGrid();
			if (retVal == null && typeName == "RectifiedGridType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.RectifiedGridType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IHistoryPropertyType IHistoryPropertyTypeCreateObject(XmlElement xmlParent)
		{
			AE.IHistoryPropertyType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.HistoryPropertyType();
		
			
			if (retVal == null && typeName == "HistoryPropertyType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.HistoryPropertyType();
			if (retVal == null && typeName == "history"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.History();
			if (retVal == null && typeName == "track"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Track();
			if (retVal == null && typeName == "TrackType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TrackType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public ILocationPropertyType ILocationPropertyTypeCreateObject(XmlElement xmlParent)
		{
			AE.ILocationPropertyType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.LocationPropertyType();
		
			
			if (retVal == null && typeName == "LocationPropertyType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.LocationPropertyType();
			if (retVal == null && typeName == "priorityLocation"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.PriorityLocation();
			if (retVal == null && typeName == "PriorityLocationPropertyType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.PriorityLocationPropertyType();
			if (retVal == null && typeName == "location"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Location();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IMeasureOrNullListType IMeasureOrNullListTypeCreateObject(XmlElement xmlParent)
		{
			AE.IMeasureOrNullListType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.MeasureOrNullListType();
		
			
			if (retVal == null && typeName == "MeasureOrNullListType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MeasureOrNullListType();
			if (retVal == null && typeName == "QuantityList"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.QuantityList();
			if (retVal == null && typeName == "QuantityExtent"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.QuantityExtent();
			if (retVal == null && typeName == "QuantityExtentType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.QuantityExtentType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IMeasureType IMeasureTypeCreateObject(XmlElement xmlParent)
		{
			AE.IMeasureType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.MeasureType();
		
			
			if (retVal == null && typeName == "MeasureType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.MeasureType();
			if (retVal == null && typeName == "semiMajorAxis"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.SemiMajorAxis();
			if (retVal == null && typeName == "Quantity"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Quantity();
			if (retVal == null && typeName == "value"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Value();
			if (retVal == null && typeName == "measure"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Measure();
			if (retVal == null && typeName == "semiMinorAxis"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.SemiMinorAxis();
			if (retVal == null && typeName == "result"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Result();
			if (retVal == null && typeName == "inverseFlattening"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.InverseFlattening();
			if (retVal == null && typeName == "angle"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Angle();
			if (retVal == null && typeName == "GridLengthType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.GridLengthType();
			if (retVal == null && typeName == "AngleType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.AngleType();
			if (retVal == null && typeName == "AreaType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.AreaType();
			if (retVal == null && typeName == "VolumeType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.VolumeType();
			if (retVal == null && typeName == "SpeedType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.SpeedType();
			if (retVal == null && typeName == "TimeType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimeType();
			if (retVal == null && typeName == "ScaleType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ScaleType();
			if (retVal == null && typeName == "LengthType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.LengthType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IObservationType IObservationTypeCreateObject(XmlElement xmlParent)
		{
			AE.IObservationType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.ObservationType();
		
			
			if (retVal == null && typeName == "ObservationType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ObservationType();
			if (retVal == null && typeName == "Observation"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Observation();
			if (retVal == null && typeName == "DirectedObservationType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DirectedObservationType();
			if (retVal == null)
				retVal = AE.ClassFactory.IDirectedObservationTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "DirectedObservation"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DirectedObservation();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IOperationMethodBaseType IOperationMethodBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.IOperationMethodBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.OperationMethodBaseTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "OperationMethod"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.OperationMethod();
			if (retVal == null && typeName == "OperationMethodType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.OperationMethodType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IOperationParameterBaseType IOperationParameterBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.IOperationParameterBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.OperationParameterBaseTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "OperationParameter"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.OperationParameter();
			if (retVal == null && typeName == "OperationParameterType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.OperationParameterType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IOperationParameterGroupBaseType IOperationParameterGroupBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.IOperationParameterGroupBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.OperationParameterGroupBaseTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "OperationParameterGroup"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.OperationParameterGroup();
			if (retVal == null && typeName == "OperationParameterGroupType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.OperationParameterGroupType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IPrimeMeridianBaseType IPrimeMeridianBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.IPrimeMeridianBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.PrimeMeridianBaseTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "PrimeMeridian"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.PrimeMeridian();
			if (retVal == null && typeName == "PrimeMeridianType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.PrimeMeridianType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public ISurfacePatchArrayPropertyType ISurfacePatchArrayPropertyTypeCreateObject(XmlElement xmlParent)
		{
			AE.ISurfacePatchArrayPropertyType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.SurfacePatchArrayPropertyType();
		
			
			if (retVal == null && typeName == "SurfacePatchArrayPropertyType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.SurfacePatchArrayPropertyType();
			if (retVal == null && typeName == "patches"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Patches();
			if (retVal == null && typeName == "trianglePatches"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TrianglePatches();
			if (retVal == null && typeName == "TrianglePatchArrayPropertyType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TrianglePatchArrayPropertyType();
			if (retVal == null && typeName == "polygonPatches"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.PolygonPatches();
			if (retVal == null && typeName == "PolygonPatchArrayPropertyType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.PolygonPatchArrayPropertyType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public ISurfaceType ISurfaceTypeCreateObject(XmlElement xmlParent)
		{
			AE.ISurfaceType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.SurfaceType();
		
			
			if (retVal == null && typeName == "SurfaceType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.SurfaceType();
			if (retVal == null && typeName == "TriangulatedSurfaceType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TriangulatedSurfaceType();
			if (retVal == null)
				retVal = AE.ClassFactory.ITriangulatedSurfaceTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "TriangulatedSurface"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TriangulatedSurface();
			if (retVal == null && typeName == "PolyhedralSurface"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.PolyhedralSurface();
			if (retVal == null && typeName == "PolyhedralSurfaceType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.PolyhedralSurfaceType();
			if (retVal == null && typeName == "Surface"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Surface();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public ITargetPropertyType ITargetPropertyTypeCreateObject(XmlElement xmlParent)
		{
			AE.ITargetPropertyType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.TargetPropertyType();
		
			
			if (retVal == null && typeName == "TargetPropertyType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TargetPropertyType();
			if (retVal == null && typeName == "target"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Target();
			if (retVal == null && typeName == "subject"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Subject();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public ITemporalDatumBaseType ITemporalDatumBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.ITemporalDatumBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
			if (retVal == null)
				retVal = AE.ClassFactory.TemporalDatumBaseTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "TemporalDatum"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TemporalDatum();
			if (retVal == null && typeName == "TemporalDatumType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TemporalDatumType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public ITimePrimitivePropertyType ITimePrimitivePropertyTypeCreateObject(XmlElement xmlParent)
		{
			AE.ITimePrimitivePropertyType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.TimePrimitivePropertyType();
		
			
			if (retVal == null && typeName == "TimePrimitivePropertyType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TimePrimitivePropertyType();
			if (retVal == null && typeName == "validTime"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ValidTime();
			if (retVal == null && typeName == "RelatedTimeType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.RelatedTimeType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public ITriangulatedSurfaceType ITriangulatedSurfaceTypeCreateObject(XmlElement xmlParent)
		{
			AE.ITriangulatedSurfaceType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.TriangulatedSurfaceType();
		
			
			if (retVal == null && typeName == "TriangulatedSurfaceType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TriangulatedSurfaceType();
			if (retVal == null && typeName == "Tin"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.Tin();
			if (retVal == null && typeName == "TinType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TinType();
			if (retVal == null && typeName == "TriangulatedSurface"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.TriangulatedSurface();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IUnitDefinitionType IUnitDefinitionTypeCreateObject(XmlElement xmlParent)
		{
			AE.IUnitDefinitionType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.UnitDefinitionType();
		
			
			if (retVal == null && typeName == "UnitDefinitionType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.UnitDefinitionType();
			if (retVal == null && typeName == "BaseUnit"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.BaseUnit();
			if (retVal == null && typeName == "BaseUnitType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.BaseUnitType();
			if (retVal == null && typeName == "UnitDefinition"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.UnitDefinition();
			if (retVal == null && typeName == "ConventionalUnit"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ConventionalUnit();
			if (retVal == null && typeName == "ConventionalUnitType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ConventionalUnitType();
			if (retVal == null && typeName == "DerivedUnit"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DerivedUnit();
			if (retVal == null && typeName == "DerivedUnitType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DerivedUnitType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IUnitOfMeasureType IUnitOfMeasureTypeCreateObject(XmlElement xmlParent)
		{
			AE.IUnitOfMeasureType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.UnitOfMeasureType();
		
			
			if (retVal == null && typeName == "UnitOfMeasureType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.UnitOfMeasureType();
			if (retVal == null && typeName == "roughConversionToPreferredUnit"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.RoughConversionToPreferredUnit();
			if (retVal == null && typeName == "ConversionToPreferredUnitType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ConversionToPreferredUnitType();
			if (retVal == null && typeName == "unitOfMeasure"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.UnitOfMeasure();
			if (retVal == null && typeName == "derivationUnitTerm"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DerivationUnitTerm();
			if (retVal == null && typeName == "DerivationUnitTermType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.DerivationUnitTermType();
			if (retVal == null && typeName == "conversionToPreferredUnit"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ConversionToPreferredUnit();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IValuePropertyType IValuePropertyTypeCreateObject(XmlElement xmlParent)
		{
			AE.IValuePropertyType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AE.ValuePropertyType();
		
			
			if (retVal == null && typeName == "ValuePropertyType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ValuePropertyType();
			if (retVal == null && typeName == "valueComponent"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ValueComponent();
			if (retVal == null && typeName == "valueProperty"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ValueProperty();
			if (retVal == null && typeName == "BooleanPropertyType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.BooleanPropertyType();
			if (retVal == null && typeName == "CategoryPropertyType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CategoryPropertyType();
			if (retVal == null && typeName == "ScalarValuePropertyType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.ScalarValuePropertyType();
			if (retVal == null && typeName == "QuantityPropertyType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.QuantityPropertyType();
			if (retVal == null && typeName == "CountPropertyType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.opengis.net/gml")
				retVal = new AE.CountPropertyType();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public OperationMethodBaseType OperationMethodBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.OperationMethodBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public OperationParameterBaseType OperationParameterBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.OperationParameterBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public OperationParameterGroupBaseType OperationParameterGroupBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.OperationParameterGroupBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public PrimeMeridianBaseType PrimeMeridianBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.PrimeMeridianBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public TemporalDatumBaseType TemporalDatumBaseTypeCreateObject(XmlElement xmlParent)
		{
			AE.TemporalDatumBaseType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return null;
		
			
		
			return retVal;
		}
	}
}
namespace AF 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net45.ClassFactoryBase
	{



		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IanimateColorPrototype IanimateColorPrototypeCreateObject(XmlElement xmlParent)
		{
			AF.IanimateColorPrototype retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AF.AnimateColorPrototype();
		
			
			if (retVal == null && typeName == "animateColorPrototype"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.AnimateColorPrototype();
			if (retVal == null && typeName == "animateColor"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.AnimateColor();
			if (retVal == null && typeName == "animateColorType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateColorType();
			if (retVal == null)
				retVal = AG.ClassFactory.IanimateColorTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "animateColor"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateColor();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IanimateMotionPrototype IanimateMotionPrototypeCreateObject(XmlElement xmlParent)
		{
			AF.IanimateMotionPrototype retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AF.AnimateMotionPrototype();
		
			
			if (retVal == null && typeName == "animateMotionPrototype"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.AnimateMotionPrototype();
			if (retVal == null && typeName == "animateMotion"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.AnimateMotion();
			if (retVal == null && typeName == "animateMotionType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateMotionType();
			if (retVal == null)
				retVal = AG.ClassFactory.IanimateMotionTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "animateMotion"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateMotion();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IanimatePrototype IanimatePrototypeCreateObject(XmlElement xmlParent)
		{
			AF.IanimatePrototype retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AF.AnimatePrototype();
		
			
			if (retVal == null && typeName == "animatePrototype"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.AnimatePrototype();
			if (retVal == null && typeName == "animate"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.Animate();
			if (retVal == null && typeName == "animateType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateType();
			if (retVal == null)
				retVal = AG.ClassFactory.IanimateTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "animate"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.Animate();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IsetPrototype IsetPrototypeCreateObject(XmlElement xmlParent)
		{
			AF.IsetPrototype retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AF.SetPrototype();
		
			
			if (retVal == null && typeName == "setPrototype"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.SetPrototype();
			if (retVal == null && typeName == "set"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.Set();
			if (retVal == null && typeName == "setType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.SetType();
			if (retVal == null)
				retVal = AG.ClassFactory.IsetTypeCreateObject(xmlParent);
			if (retVal == null && typeName == "set"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.Set();
		
			return retVal;
		}
	}
}
namespace AG 
{
	public class ClassFactory : LiquidTechnologies.Runtime.Net45.ClassFactoryBase
	{



		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IanimateColorType IanimateColorTypeCreateObject(XmlElement xmlParent)
		{
			AG.IanimateColorType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AG.AnimateColorType();
		
			
			if (retVal == null && typeName == "animateColorType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateColorType();
			if (retVal == null && typeName == "animateColor"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.AnimateColor();
			if (retVal == null && typeName == "animateColor"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateColor();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IanimateMotionType IanimateMotionTypeCreateObject(XmlElement xmlParent)
		{
			AG.IanimateMotionType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AG.AnimateMotionType();
		
			
			if (retVal == null && typeName == "animateMotionType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateMotionType();
			if (retVal == null && typeName == "animateMotion"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.AnimateMotion();
			if (retVal == null && typeName == "animateMotion"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateMotion();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IanimateType IanimateTypeCreateObject(XmlElement xmlParent)
		{
			AG.IanimateType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AG.AnimateType();
		
			
			if (retVal == null && typeName == "animateType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.AnimateType();
			if (retVal == null && typeName == "animate"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.Animate();
			if (retVal == null && typeName == "animate"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.Animate();
		
			return retVal;
		}

		// Were trying to create a class, however it may be any one of the derived 
		// classes that be want, so we need to create them, if they fail move on to
		// the next, until we have one that fits.		
		static public IsetType IsetTypeCreateObject(XmlElement xmlParent)
		{
			AG.IsetType retVal = null;

			// Get the type name
			String typeName = GetElementType(xmlParent);

			if (typeName == "")
				return new AG.SetType();
		
			
			if (retVal == null && typeName == "setType"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.SetType();
			if (retVal == null && typeName == "set"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/")
				retVal = new AF.Set();
			if (retVal == null && typeName == "set"  && GetElementTypeNamespaceUri(xmlParent) == "http://www.w3.org/2001/SMIL20/Language")
				retVal = new AG.Set();
		
			return retVal;
		}
	}
}

