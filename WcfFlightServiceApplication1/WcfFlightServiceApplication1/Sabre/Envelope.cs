using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfFlightServiceApplication1.Sabre
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
    public partial class Envelope
    {

        private EnvelopeHeader headerField;

        private EnvelopeBody bodyField;

        /// <remarks/>
        public EnvelopeHeader Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class EnvelopeHeader
    {

        private MessageHeader messageHeaderField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.ebxml.org/namespaces/messageHeader")]
        public MessageHeader MessageHeader
        {
            get
            {
                return this.messageHeaderField;
            }
            set
            {
                this.messageHeaderField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ebxml.org/namespaces/messageHeader")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.ebxml.org/namespaces/messageHeader", IsNullable = false)]
    public partial class MessageHeader
    {

        private MessageHeaderFrom fromField;

        private MessageHeaderTO toField;

        private string cPAIdField;

        private string conversationIdField;

        private string serviceField;

        private string actionField;

        private MessageHeaderMessageData messageDataField;

        private object refToMessageIdField;

        private byte mustUnderstandField;

        private decimal versionField;

        /// <remarks/>
        public MessageHeaderFrom From
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
            }
        }

        /// <remarks/>
        public MessageHeaderTO To
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
            }
        }

        /// <remarks/>
        public string CPAId
        {
            get
            {
                return this.cPAIdField;
            }
            set
            {
                this.cPAIdField = value;
            }
        }

        /// <remarks/>
        public string ConversationId
        {
            get
            {
                return this.conversationIdField;
            }
            set
            {
                this.conversationIdField = value;
            }
        }

        /// <remarks/>
        public string Service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }

        /// <remarks/>
        public string Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        /// <remarks/>
        public MessageHeaderMessageData MessageData
        {
            get
            {
                return this.messageDataField;
            }
            set
            {
                this.messageDataField = value;
            }
        }

        /// <remarks/>
        public object RefToMessageId
        {
            get
            {
                return this.refToMessageIdField;
            }
            set
            {
                this.refToMessageIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public byte mustUnderstand
        {
            get
            {
                return this.mustUnderstandField;
            }
            set
            {
                this.mustUnderstandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public decimal version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ebxml.org/namespaces/messageHeader")]
    public partial class MessageHeaderFrom
    {

        private object partyIdField;

        /// <remarks/>
        public object PartyId
        {
            get
            {
                return this.partyIdField;
            }
            set
            {
                this.partyIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ebxml.org/namespaces/messageHeader")]
    public partial class MessageHeaderTO
    {

        private object partyIdField;

        /// <remarks/>
        public object PartyId
        {
            get
            {
                return this.partyIdField;
            }
            set
            {
                this.partyIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ebxml.org/namespaces/messageHeader")]
    public partial class MessageHeaderMessageData
    {

        private string messageIdField;

        private System.DateTime timestampField;

        /// <remarks/>
        public string MessageId
        {
            get
            {
                return this.messageIdField;
            }
            set
            {
                this.messageIdField = value;
            }
        }

        /// <remarks/>
        public System.DateTime Timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class EnvelopeBody
    {

        private OTA_AirLowFareSearchRS oTA_AirLowFareSearchRSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opentravel.org/OTA/2003/05")]
        public OTA_AirLowFareSearchRS OTA_AirLowFareSearchRS
        {
            get
            {
                return this.oTA_AirLowFareSearchRSField;
            }
            set
            {
                this.oTA_AirLowFareSearchRSField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opentravel.org/OTA/2003/05", IsNullable = false)]
    public partial class OTA_AirLowFareSearchRS
    {

        private object successField;

        private OTA_AirLowFareSearchRSWarning[] warningsField;

        private OTA_AirLowFareSearchRSPricedItinerary[] pricedItinerariesField;

        private string versionField;

        private byte pricedItinCountField;

        private byte brandedOneWayItinCountField;

        private byte simpleOneWayItinCountField;

        private byte departedItinCountField;

        private byte soldOutItinCountField;

        private byte availableItinCountField;

        /// <remarks/>
        public object Success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Warning", IsNullable = false)]
        public OTA_AirLowFareSearchRSWarning[] Warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PricedItinerary", IsNullable = false)]
        public OTA_AirLowFareSearchRSPricedItinerary[] PricedItineraries
        {
            get
            {
                return this.pricedItinerariesField;
            }
            set
            {
                this.pricedItinerariesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PricedItinCount
        {
            get
            {
                return this.pricedItinCountField;
            }
            set
            {
                this.pricedItinCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte BrandedOneWayItinCount
        {
            get
            {
                return this.brandedOneWayItinCountField;
            }
            set
            {
                this.brandedOneWayItinCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte SimpleOneWayItinCount
        {
            get
            {
                return this.simpleOneWayItinCountField;
            }
            set
            {
                this.simpleOneWayItinCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DepartedItinCount
        {
            get
            {
                return this.departedItinCountField;
            }
            set
            {
                this.departedItinCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte SoldOutItinCount
        {
            get
            {
                return this.soldOutItinCountField;
            }
            set
            {
                this.soldOutItinCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte AvailableItinCount
        {
            get
            {
                return this.availableItinCountField;
            }
            set
            {
                this.availableItinCountField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSWarning
    {

        private string typeField;

        private string codeField;

        private string shortTextField;

        private string messageClassField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ShortText
        {
            get
            {
                return this.shortTextField;
            }
            set
            {
                this.shortTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MessageClass
        {
            get
            {
                return this.messageClassField;
            }
            set
            {
                this.messageClassField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItinerary
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItinerary airItineraryField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfo airItineraryPricingInfoField;

        private OTA_AirLowFareSearchRSPricedItineraryTicketingInfo ticketingInfoField;

        private OTA_AirLowFareSearchRSPricedItineraryTPA_Extensions tPA_ExtensionsField;

        private byte sequenceNumberField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItinerary AirItinerary
        {
            get
            {
                return this.airItineraryField;
            }
            set
            {
                this.airItineraryField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfo AirItineraryPricingInfo
        {
            get
            {
                return this.airItineraryPricingInfoField;
            }
            set
            {
                this.airItineraryPricingInfoField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryTicketingInfo TicketingInfo
        {
            get
            {
                return this.ticketingInfoField;
            }
            set
            {
                this.ticketingInfoField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryTPA_Extensions TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte SequenceNumber
        {
            get
            {
                return this.sequenceNumberField;
            }
            set
            {
                this.sequenceNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItinerary
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptions originDestinationOptionsField;

        private string directionIndField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptions OriginDestinationOptions
        {
            get
            {
                return this.originDestinationOptionsField;
            }
            set
            {
                this.originDestinationOptionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DirectionInd
        {
            get
            {
                return this.directionIndField;
            }
            set
            {
                this.directionIndField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptions
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOption originDestinationOptionField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOption OriginDestinationOption
        {
            get
            {
                return this.originDestinationOptionField;
            }
            set
            {
                this.originDestinationOptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOption
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegment[] flightSegmentField;

        private ushort elapsedTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FlightSegment")]
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegment[] FlightSegment
        {
            get
            {
                return this.flightSegmentField;
            }
            set
            {
                this.flightSegmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ElapsedTime
        {
            get
            {
                return this.elapsedTimeField;
            }
            set
            {
                this.elapsedTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegment
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentDepartureAirport departureAirportField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentArrivalAirport arrivalAirportField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentOperatingAirline operatingAirlineField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentEquipment equipmentField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentMarketingAirline marketingAirlineField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentDisclosureAirline disclosureAirlineField;

        private string marriageGrpField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentDepartureTimeZone departureTimeZoneField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentArrivalTimeZone arrivalTimeZoneField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentOnTimePerformance onTimePerformanceField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentTPA_Extensions tPA_ExtensionsField;

        private System.DateTime departureDateTimeField;

        private System.DateTime arrivalDateTimeField;

        private byte stopQuantityField;

        private ushort flightNumberField;

        private string resBookDesigCodeField;

        private ushort elapsedTimeField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentDepartureAirport DepartureAirport
        {
            get
            {
                return this.departureAirportField;
            }
            set
            {
                this.departureAirportField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentArrivalAirport ArrivalAirport
        {
            get
            {
                return this.arrivalAirportField;
            }
            set
            {
                this.arrivalAirportField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentOperatingAirline OperatingAirline
        {
            get
            {
                return this.operatingAirlineField;
            }
            set
            {
                this.operatingAirlineField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentEquipment Equipment
        {
            get
            {
                return this.equipmentField;
            }
            set
            {
                this.equipmentField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentMarketingAirline MarketingAirline
        {
            get
            {
                return this.marketingAirlineField;
            }
            set
            {
                this.marketingAirlineField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentDisclosureAirline DisclosureAirline
        {
            get
            {
                return this.disclosureAirlineField;
            }
            set
            {
                this.disclosureAirlineField = value;
            }
        }

        /// <remarks/>
        public string MarriageGrp
        {
            get
            {
                return this.marriageGrpField;
            }
            set
            {
                this.marriageGrpField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentDepartureTimeZone DepartureTimeZone
        {
            get
            {
                return this.departureTimeZoneField;
            }
            set
            {
                this.departureTimeZoneField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentArrivalTimeZone ArrivalTimeZone
        {
            get
            {
                return this.arrivalTimeZoneField;
            }
            set
            {
                this.arrivalTimeZoneField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentOnTimePerformance OnTimePerformance
        {
            get
            {
                return this.onTimePerformanceField;
            }
            set
            {
                this.onTimePerformanceField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentTPA_Extensions TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DepartureDateTime
        {
            get
            {
                return this.departureDateTimeField;
            }
            set
            {
                this.departureDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ArrivalDateTime
        {
            get
            {
                return this.arrivalDateTimeField;
            }
            set
            {
                this.arrivalDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte StopQuantity
        {
            get
            {
                return this.stopQuantityField;
            }
            set
            {
                this.stopQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort FlightNumber
        {
            get
            {
                return this.flightNumberField;
            }
            set
            {
                this.flightNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCode
        {
            get
            {
                return this.resBookDesigCodeField;
            }
            set
            {
                this.resBookDesigCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ElapsedTime
        {
            get
            {
                return this.elapsedTimeField;
            }
            set
            {
                this.elapsedTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentDepartureAirport
    {

        private string locationCodeField;

        private string terminalIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TerminalID
        {
            get
            {
                return this.terminalIDField;
            }
            set
            {
                this.terminalIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentArrivalAirport
    {

        private string locationCodeField;

        private string terminalIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TerminalID
        {
            get
            {
                return this.terminalIDField;
            }
            set
            {
                this.terminalIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentOperatingAirline
    {

        private string codeField;

        private ushort flightNumberField;

        private string companyShortNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort FlightNumber
        {
            get
            {
                return this.flightNumberField;
            }
            set
            {
                this.flightNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CompanyShortName
        {
            get
            {
                return this.companyShortNameField;
            }
            set
            {
                this.companyShortNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentEquipment
    {

        private string airEquipTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirEquipType
        {
            get
            {
                return this.airEquipTypeField;
            }
            set
            {
                this.airEquipTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentMarketingAirline
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentDisclosureAirline
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentDepartureTimeZone
    {

        private decimal gMTOffsetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal GMTOffset
        {
            get
            {
                return this.gMTOffsetField;
            }
            set
            {
                this.gMTOffsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentArrivalTimeZone
    {

        private decimal gMTOffsetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal GMTOffset
        {
            get
            {
                return this.gMTOffsetField;
            }
            set
            {
                this.gMTOffsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentOnTimePerformance
    {

        private byte levelField;

        private bool levelFieldSpecified;

        private byte percentageField;

        private bool percentageFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LevelSpecified
        {
            get
            {
                return this.levelFieldSpecified;
            }
            set
            {
                this.levelFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Percentage
        {
            get
            {
                return this.percentageField;
            }
            set
            {
                this.percentageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentageSpecified
        {
            get
            {
                return this.percentageFieldSpecified;
            }
            set
            {
                this.percentageFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentTPA_Extensions
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentTPA_ExtensionsETicket eTicketField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentTPA_ExtensionsETicket eTicket
        {
            get
            {
                return this.eTicketField;
            }
            set
            {
                this.eTicketField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentTPA_ExtensionsETicket
    {

        private bool indField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Ind
        {
            get
            {
                return this.indField;
            }
            set
            {
                this.indField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfo
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFare itinTotalFareField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdowns pTC_FareBreakdownsField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoFareInfo[] fareInfosField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoTPA_Extensions tPA_ExtensionsField;

        private string pricingSourceField;

        private string pricingSubSourceField;

        private System.DateTime lastTicketDateField;

        private bool lastTicketDateFieldSpecified;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFare ItinTotalFare
        {
            get
            {
                return this.itinTotalFareField;
            }
            set
            {
                this.itinTotalFareField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdowns PTC_FareBreakdowns
        {
            get
            {
                return this.pTC_FareBreakdownsField;
            }
            set
            {
                this.pTC_FareBreakdownsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("FareInfo", IsNullable = false)]
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoFareInfo[] FareInfos
        {
            get
            {
                return this.fareInfosField;
            }
            set
            {
                this.fareInfosField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoTPA_Extensions TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PricingSource
        {
            get
            {
                return this.pricingSourceField;
            }
            set
            {
                this.pricingSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PricingSubSource
        {
            get
            {
                return this.pricingSubSourceField;
            }
            set
            {
                this.pricingSubSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime LastTicketDate
        {
            get
            {
                return this.lastTicketDateField;
            }
            set
            {
                this.lastTicketDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastTicketDateSpecified
        {
            get
            {
                return this.lastTicketDateFieldSpecified;
            }
            set
            {
                this.lastTicketDateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFare
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareBaseFare baseFareField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareFareConstruction fareConstructionField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareEquivFare equivFareField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareTaxes taxesField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareTotalFare totalFareField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareBaseFare BaseFare
        {
            get
            {
                return this.baseFareField;
            }
            set
            {
                this.baseFareField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareFareConstruction FareConstruction
        {
            get
            {
                return this.fareConstructionField;
            }
            set
            {
                this.fareConstructionField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareEquivFare EquivFare
        {
            get
            {
                return this.equivFareField;
            }
            set
            {
                this.equivFareField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareTaxes Taxes
        {
            get
            {
                return this.taxesField;
            }
            set
            {
                this.taxesField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareTotalFare TotalFare
        {
            get
            {
                return this.totalFareField;
            }
            set
            {
                this.totalFareField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareBaseFare
    {

        private uint amountField;

        private string currencyCodeField;

        private byte decimalPlacesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareFareConstruction
    {

        private decimal amountField;

        private string currencyCodeField;

        private byte decimalPlacesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareEquivFare
    {

        private decimal amountField;

        private string currencyCodeField;

        private byte decimalPlacesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareTaxes
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareTaxesTax taxField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareTaxesTax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareTaxesTax
    {

        private string taxCodeField;

        private decimal amountField;

        private string currencyCodeField;

        private byte decimalPlacesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TaxCode
        {
            get
            {
                return this.taxCodeField;
            }
            set
            {
                this.taxCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareTotalFare
    {

        private decimal amountField;

        private string currencyCodeField;

        private byte decimalPlacesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdowns
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdown pTC_FareBreakdownField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdown PTC_FareBreakdown
        {
            get
            {
                return this.pTC_FareBreakdownField;
            }
            set
            {
                this.pTC_FareBreakdownField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdown
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerTypeQuantity passengerTypeQuantityField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownFareBasisCode[] fareBasisCodesField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFare passengerFareField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownEndorsements endorsementsField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownTPA_Extensions tPA_ExtensionsField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerTypeQuantity PassengerTypeQuantity
        {
            get
            {
                return this.passengerTypeQuantityField;
            }
            set
            {
                this.passengerTypeQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("FareBasisCode", IsNullable = false)]
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownFareBasisCode[] FareBasisCodes
        {
            get
            {
                return this.fareBasisCodesField;
            }
            set
            {
                this.fareBasisCodesField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFare PassengerFare
        {
            get
            {
                return this.passengerFareField;
            }
            set
            {
                this.passengerFareField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownEndorsements Endorsements
        {
            get
            {
                return this.endorsementsField;
            }
            set
            {
                this.endorsementsField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownTPA_Extensions TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerTypeQuantity
    {

        private string codeField;

        private byte quantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownFareBasisCode
    {

        private string bookingCodeField;

        private bool availabilityBreakField;

        private bool availabilityBreakFieldSpecified;

        private string departureAirportCodeField;

        private string arrivalAirportCodeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BookingCode
        {
            get
            {
                return this.bookingCodeField;
            }
            set
            {
                this.bookingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AvailabilityBreak
        {
            get
            {
                return this.availabilityBreakField;
            }
            set
            {
                this.availabilityBreakField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AvailabilityBreakSpecified
        {
            get
            {
                return this.availabilityBreakFieldSpecified;
            }
            set
            {
                this.availabilityBreakFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DepartureAirportCode
        {
            get
            {
                return this.departureAirportCodeField;
            }
            set
            {
                this.departureAirportCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ArrivalAirportCode
        {
            get
            {
                return this.arrivalAirportCodeField;
            }
            set
            {
                this.arrivalAirportCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFare
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareBaseFare baseFareField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareFareConstruction fareConstructionField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareEquivFare equivFareField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTaxes taxesField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTotalFare totalFareField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_Extensions tPA_ExtensionsField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareBaseFare BaseFare
        {
            get
            {
                return this.baseFareField;
            }
            set
            {
                this.baseFareField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareFareConstruction FareConstruction
        {
            get
            {
                return this.fareConstructionField;
            }
            set
            {
                this.fareConstructionField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareEquivFare EquivFare
        {
            get
            {
                return this.equivFareField;
            }
            set
            {
                this.equivFareField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTaxes Taxes
        {
            get
            {
                return this.taxesField;
            }
            set
            {
                this.taxesField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTotalFare TotalFare
        {
            get
            {
                return this.totalFareField;
            }
            set
            {
                this.totalFareField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_Extensions TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareBaseFare
    {

        private uint amountField;

        private string currencyCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareFareConstruction
    {

        private decimal amountField;

        private string currencyCodeField;

        private byte decimalPlacesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareEquivFare
    {

        private decimal amountField;

        private string currencyCodeField;

        private byte decimalPlacesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTaxes
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTaxesTax[] taxField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTaxesTotalTax totalTaxField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Tax")]
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTaxesTax[] Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTaxesTotalTax TotalTax
        {
            get
            {
                return this.totalTaxField;
            }
            set
            {
                this.totalTaxField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTaxesTax
    {

        private string taxCodeField;

        private decimal amountField;

        private string currencyCodeField;

        private byte decimalPlacesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TaxCode
        {
            get
            {
                return this.taxCodeField;
            }
            set
            {
                this.taxCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTaxesTotalTax
    {

        private decimal amountField;

        private string currencyCodeField;

        private byte decimalPlacesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTotalFare
    {

        private decimal amountField;

        private string currencyCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_Extensions
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsSurcharges[] surchargesField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsFareComponent[] fareComponentsField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsMessage[] messagesField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsBaggageInformationList baggageInformationListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Surcharges")]
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsSurcharges[] Surcharges
        {
            get
            {
                return this.surchargesField;
            }
            set
            {
                this.surchargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("FareComponent", IsNullable = false)]
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsFareComponent[] FareComponents
        {
            get
            {
                return this.fareComponentsField;
            }
            set
            {
                this.fareComponentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Message", IsNullable = false)]
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsMessage[] Messages
        {
            get
            {
                return this.messagesField;
            }
            set
            {
                this.messagesField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsBaggageInformationList BaggageInformationList
        {
            get
            {
                return this.baggageInformationListField;
            }
            set
            {
                this.baggageInformationListField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsSurcharges
    {

        private string indField;

        private string typeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ind
        {
            get
            {
                return this.indField;
            }
            set
            {
                this.indField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsFareComponent
    {

        private string programIDField;

        private string programDescriptionField;

        private string brandIDField;

        private string brandNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProgramID
        {
            get
            {
                return this.programIDField;
            }
            set
            {
                this.programIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProgramDescription
        {
            get
            {
                return this.programDescriptionField;
            }
            set
            {
                this.programDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BrandID
        {
            get
            {
                return this.brandIDField;
            }
            set
            {
                this.brandIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BrandName
        {
            get
            {
                return this.brandNameField;
            }
            set
            {
                this.brandNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsMessage
    {

        private string airlineCodeField;

        private string typeField;

        private byte failCodeField;

        private string infoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirlineCode
        {
            get
            {
                return this.airlineCodeField;
            }
            set
            {
                this.airlineCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte FailCode
        {
            get
            {
                return this.failCodeField;
            }
            set
            {
                this.failCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsBaggageInformationList
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsBaggageInformationListBaggageInformation baggageInformationField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsBaggageInformationListBaggageInformation BaggageInformation
        {
            get
            {
                return this.baggageInformationField;
            }
            set
            {
                this.baggageInformationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsBaggageInformationListBaggageInformation
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsBaggageInformationListBaggageInformationSegment[] segmentField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsBaggageInformationListBaggageInformationAllowance allowanceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Segment")]
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsBaggageInformationListBaggageInformationSegment[] Segment
        {
            get
            {
                return this.segmentField;
            }
            set
            {
                this.segmentField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsBaggageInformationListBaggageInformationAllowance Allowance
        {
            get
            {
                return this.allowanceField;
            }
            set
            {
                this.allowanceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsBaggageInformationListBaggageInformationSegment
    {

        private byte idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTPA_ExtensionsBaggageInformationListBaggageInformationAllowance
    {

        private byte piecesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Pieces
        {
            get
            {
                return this.piecesField;
            }
            set
            {
                this.piecesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownEndorsements
    {

        private bool nonRefundableIndicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonRefundableIndicator
        {
            get
            {
                return this.nonRefundableIndicatorField;
            }
            set
            {
                this.nonRefundableIndicatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownTPA_Extensions
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownTPA_ExtensionsFareCalcLine fareCalcLineField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownTPA_ExtensionsFareCalcLine FareCalcLine
        {
            get
            {
                return this.fareCalcLineField;
            }
            set
            {
                this.fareCalcLineField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownsPTC_FareBreakdownTPA_ExtensionsFareCalcLine
    {

        private string infoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoFareInfo
    {

        private string fareReferenceField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoFareInfoTPA_Extensions tPA_ExtensionsField;

        /// <remarks/>
        public string FareReference
        {
            get
            {
                return this.fareReferenceField;
            }
            set
            {
                this.fareReferenceField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoFareInfoTPA_Extensions TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoFareInfoTPA_Extensions
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoFareInfoTPA_ExtensionsSeatsRemaining seatsRemainingField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoFareInfoTPA_ExtensionsCabin cabinField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoFareInfoTPA_ExtensionsMeal mealField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoFareInfoTPA_ExtensionsSeatsRemaining SeatsRemaining
        {
            get
            {
                return this.seatsRemainingField;
            }
            set
            {
                this.seatsRemainingField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoFareInfoTPA_ExtensionsCabin Cabin
        {
            get
            {
                return this.cabinField;
            }
            set
            {
                this.cabinField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoFareInfoTPA_ExtensionsMeal Meal
        {
            get
            {
                return this.mealField;
            }
            set
            {
                this.mealField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoFareInfoTPA_ExtensionsSeatsRemaining
    {

        private byte numberField;

        private bool belowMinField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BelowMin
        {
            get
            {
                return this.belowMinField;
            }
            set
            {
                this.belowMinField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoFareInfoTPA_ExtensionsCabin
    {

        private string cabinField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Cabin
        {
            get
            {
                return this.cabinField;
            }
            set
            {
                this.cabinField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoFareInfoTPA_ExtensionsMeal
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoTPA_Extensions
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoTPA_ExtensionsDivideInParty divideInPartyField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoTPA_ExtensionsValidatingCarrier validatingCarrierField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoTPA_ExtensionsDivideInParty DivideInParty
        {
            get
            {
                return this.divideInPartyField;
            }
            set
            {
                this.divideInPartyField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoTPA_ExtensionsValidatingCarrier ValidatingCarrier
        {
            get
            {
                return this.validatingCarrierField;
            }
            set
            {
                this.validatingCarrierField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoTPA_ExtensionsDivideInParty
    {

        private bool indicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Indicator
        {
            get
            {
                return this.indicatorField;
            }
            set
            {
                this.indicatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoTPA_ExtensionsValidatingCarrier
    {

        private string defaultField;

        private string[] alternateField;

        private string settlementMethodField;

        private bool newVcxProcessField;

        /// <remarks/>
        public string Default
        {
            get
            {
                return this.defaultField;
            }
            set
            {
                this.defaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Alternate")]
        public string[] Alternate
        {
            get
            {
                return this.alternateField;
            }
            set
            {
                this.alternateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SettlementMethod
        {
            get
            {
                return this.settlementMethodField;
            }
            set
            {
                this.settlementMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NewVcxProcess
        {
            get
            {
                return this.newVcxProcessField;
            }
            set
            {
                this.newVcxProcessField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryTicketingInfo
    {

        private string ticketTypeField;

        private string validInterlineField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketType
        {
            get
            {
                return this.ticketTypeField;
            }
            set
            {
                this.ticketTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ValidInterline
        {
            get
            {
                return this.validInterlineField;
            }
            set
            {
                this.validInterlineField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryTPA_Extensions
    {

        private OTA_AirLowFareSearchRSPricedItineraryTPA_ExtensionsValidatingCarrier validatingCarrierField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryTPA_ExtensionsValidatingCarrier ValidatingCarrier
        {
            get
            {
                return this.validatingCarrierField;
            }
            set
            {
                this.validatingCarrierField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryTPA_ExtensionsValidatingCarrier
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }


}