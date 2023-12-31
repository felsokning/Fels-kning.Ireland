﻿// <auto-generated/>

// ----------------------------------------------------------------------
// <copyright file="ArrayOfObjStation.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Ireland.IarnródÉireann
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ArrayOfObjStation"/> class.
    /// </summary>
    /// <remarks>NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.</remarks>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.irishrail.ie/realtime/")]
    [XmlRootAttribute(Namespace = "http://api.irishrail.ie/realtime/", IsNullable = false)]
    public partial class ArrayOfObjStation
    {

        private ObjStation[] objStationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("objStation")]
        public ObjStation[] objStation
        {
            get
            {
                return this.objStationField;
            }
            set
            {
                this.objStationField = value;
            }
        }
    }
}