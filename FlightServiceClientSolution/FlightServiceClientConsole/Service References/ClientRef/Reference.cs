﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlightServiceClientConsole.ClientRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Result", Namespace="http://schemas.datacontract.org/2004/07/FlightIISServices.Entity")]
    [System.SerializableAttribute()]
    public partial class Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private FlightServiceClientConsole.ClientRef.Flight[] FlightListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool StatusField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FlightServiceClientConsole.ClientRef.Flight[] FlightList {
            get {
                return this.FlightListField;
            }
            set {
                if ((object.ReferenceEquals(this.FlightListField, value) != true)) {
                    this.FlightListField = value;
                    this.RaisePropertyChanged("FlightList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Flight", Namespace="http://schemas.datacontract.org/2004/07/FlightIISServices.Entity")]
    [System.SerializableAttribute()]
    public partial class Flight : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AirlineNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ArrivalTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AvailableSeatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartureTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DestinationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FlightClassField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FlightIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double RatingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AirlineName {
            get {
                return this.AirlineNameField;
            }
            set {
                if ((object.ReferenceEquals(this.AirlineNameField, value) != true)) {
                    this.AirlineNameField = value;
                    this.RaisePropertyChanged("AirlineName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ArrivalTime {
            get {
                return this.ArrivalTimeField;
            }
            set {
                if ((object.ReferenceEquals(this.ArrivalTimeField, value) != true)) {
                    this.ArrivalTimeField = value;
                    this.RaisePropertyChanged("ArrivalTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AvailableSeat {
            get {
                return this.AvailableSeatField;
            }
            set {
                if ((this.AvailableSeatField.Equals(value) != true)) {
                    this.AvailableSeatField = value;
                    this.RaisePropertyChanged("AvailableSeat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DepartureTime {
            get {
                return this.DepartureTimeField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartureTimeField, value) != true)) {
                    this.DepartureTimeField = value;
                    this.RaisePropertyChanged("DepartureTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Destination {
            get {
                return this.DestinationField;
            }
            set {
                if ((object.ReferenceEquals(this.DestinationField, value) != true)) {
                    this.DestinationField = value;
                    this.RaisePropertyChanged("Destination");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FlightClass {
            get {
                return this.FlightClassField;
            }
            set {
                if ((object.ReferenceEquals(this.FlightClassField, value) != true)) {
                    this.FlightClassField = value;
                    this.RaisePropertyChanged("FlightClass");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FlightId {
            get {
                return this.FlightIdField;
            }
            set {
                if ((object.ReferenceEquals(this.FlightIdField, value) != true)) {
                    this.FlightIdField = value;
                    this.RaisePropertyChanged("FlightId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Rating {
            get {
                return this.RatingField;
            }
            set {
                if ((this.RatingField.Equals(value) != true)) {
                    this.RatingField = value;
                    this.RaisePropertyChanged("Rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Source {
            get {
                return this.SourceField;
            }
            set {
                if ((object.ReferenceEquals(this.SourceField, value) != true)) {
                    this.SourceField = value;
                    this.RaisePropertyChanged("Source");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Filter", Namespace="http://schemas.datacontract.org/2004/07/FlightIISServices.Entity")]
    [System.SerializableAttribute()]
    public partial class Filter : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AirlineNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EndRangeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double RatingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StartRangeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AirlineName {
            get {
                return this.AirlineNameField;
            }
            set {
                if ((object.ReferenceEquals(this.AirlineNameField, value) != true)) {
                    this.AirlineNameField = value;
                    this.RaisePropertyChanged("AirlineName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EndRange {
            get {
                return this.EndRangeField;
            }
            set {
                if ((this.EndRangeField.Equals(value) != true)) {
                    this.EndRangeField = value;
                    this.RaisePropertyChanged("EndRange");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Rating {
            get {
                return this.RatingField;
            }
            set {
                if ((this.RatingField.Equals(value) != true)) {
                    this.RatingField = value;
                    this.RaisePropertyChanged("Rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StartRange {
            get {
                return this.StartRangeField;
            }
            set {
                if ((this.StartRangeField.Equals(value) != true)) {
                    this.StartRangeField = value;
                    this.RaisePropertyChanged("StartRange");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/FlightIISServices.Entity")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FisrtNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MobileNumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerIdField, value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FisrtName {
            get {
                return this.FisrtNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FisrtNameField, value) != true)) {
                    this.FisrtNameField = value;
                    this.RaisePropertyChanged("FisrtName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MobileNumber {
            get {
                return this.MobileNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.MobileNumberField, value) != true)) {
                    this.MobileNumberField = value;
                    this.RaisePropertyChanged("MobileNumber");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Card", Namespace="http://schemas.datacontract.org/2004/07/FlightIISServices.Entity")]
    [System.SerializableAttribute()]
    public partial class Card : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CVVField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CardHolderNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CardNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string validTillMonthAndYearField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CVV {
            get {
                return this.CVVField;
            }
            set {
                if ((this.CVVField.Equals(value) != true)) {
                    this.CVVField = value;
                    this.RaisePropertyChanged("CVV");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CardHolderName {
            get {
                return this.CardHolderNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CardHolderNameField, value) != true)) {
                    this.CardHolderNameField = value;
                    this.RaisePropertyChanged("CardHolderName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CardNumber {
            get {
                return this.CardNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.CardNumberField, value) != true)) {
                    this.CardNumberField = value;
                    this.RaisePropertyChanged("CardNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string validTillMonthAndYear {
            get {
                return this.validTillMonthAndYearField;
            }
            set {
                if ((object.ReferenceEquals(this.validTillMonthAndYearField, value) != true)) {
                    this.validTillMonthAndYearField = value;
                    this.RaisePropertyChanged("validTillMonthAndYear");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClientRef.IFlightService")]
    public interface IFlightService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/GetFlightsBySourceDestinationTravellersAndClass" +
            "", ReplyAction="http://tempuri.org/IFlightService/GetFlightsBySourceDestinationTravellersAndClass" +
            "Response")]
        FlightServiceClientConsole.ClientRef.Result GetFlightsBySourceDestinationTravellersAndClass(string source, string destination, string traveller, string flightClass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/GetFlightsBySourceDestinationTravellersAndClass" +
            "", ReplyAction="http://tempuri.org/IFlightService/GetFlightsBySourceDestinationTravellersAndClass" +
            "Response")]
        System.Threading.Tasks.Task<FlightServiceClientConsole.ClientRef.Result> GetFlightsBySourceDestinationTravellersAndClassAsync(string source, string destination, string traveller, string flightClass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/FilteringFlights", ReplyAction="http://tempuri.org/IFlightService/FilteringFlightsResponse")]
        FlightServiceClientConsole.ClientRef.Result FilteringFlights(FlightServiceClientConsole.ClientRef.Result result, FlightServiceClientConsole.ClientRef.Filter filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/FilteringFlights", ReplyAction="http://tempuri.org/IFlightService/FilteringFlightsResponse")]
        System.Threading.Tasks.Task<FlightServiceClientConsole.ClientRef.Result> FilteringFlightsAsync(FlightServiceClientConsole.ClientRef.Result result, FlightServiceClientConsole.ClientRef.Filter filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/AddNewBooking", ReplyAction="http://tempuri.org/IFlightService/AddNewBookingResponse")]
        string AddNewBooking(FlightServiceClientConsole.ClientRef.Flight flight, FlightServiceClientConsole.ClientRef.Customer customer, int travellers);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/AddNewBooking", ReplyAction="http://tempuri.org/IFlightService/AddNewBookingResponse")]
        System.Threading.Tasks.Task<string> AddNewBookingAsync(FlightServiceClientConsole.ClientRef.Flight flight, FlightServiceClientConsole.ClientRef.Customer customer, int travellers);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/CancelBooking", ReplyAction="http://tempuri.org/IFlightService/CancelBookingResponse")]
        string CancelBooking(string bookindId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/CancelBooking", ReplyAction="http://tempuri.org/IFlightService/CancelBookingResponse")]
        System.Threading.Tasks.Task<string> CancelBookingAsync(string bookindId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/SaveCardDetails", ReplyAction="http://tempuri.org/IFlightService/SaveCardDetailsResponse")]
        FlightServiceClientConsole.ClientRef.Result SaveCardDetails(FlightServiceClientConsole.ClientRef.Result result, FlightServiceClientConsole.ClientRef.Card card);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/SaveCardDetails", ReplyAction="http://tempuri.org/IFlightService/SaveCardDetailsResponse")]
        System.Threading.Tasks.Task<FlightServiceClientConsole.ClientRef.Result> SaveCardDetailsAsync(FlightServiceClientConsole.ClientRef.Result result, FlightServiceClientConsole.ClientRef.Card card);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFlightServiceChannel : FlightServiceClientConsole.ClientRef.IFlightService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FlightServiceClient : System.ServiceModel.ClientBase<FlightServiceClientConsole.ClientRef.IFlightService>, FlightServiceClientConsole.ClientRef.IFlightService {
        
        public FlightServiceClient() {
        }
        
        public FlightServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FlightServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FlightServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FlightServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public FlightServiceClientConsole.ClientRef.Result GetFlightsBySourceDestinationTravellersAndClass(string source, string destination, string traveller, string flightClass) {
            return base.Channel.GetFlightsBySourceDestinationTravellersAndClass(source, destination, traveller, flightClass);
        }
        
        public System.Threading.Tasks.Task<FlightServiceClientConsole.ClientRef.Result> GetFlightsBySourceDestinationTravellersAndClassAsync(string source, string destination, string traveller, string flightClass) {
            return base.Channel.GetFlightsBySourceDestinationTravellersAndClassAsync(source, destination, traveller, flightClass);
        }
        
        public FlightServiceClientConsole.ClientRef.Result FilteringFlights(FlightServiceClientConsole.ClientRef.Result result, FlightServiceClientConsole.ClientRef.Filter filter) {
            return base.Channel.FilteringFlights(result, filter);
        }
        
        public System.Threading.Tasks.Task<FlightServiceClientConsole.ClientRef.Result> FilteringFlightsAsync(FlightServiceClientConsole.ClientRef.Result result, FlightServiceClientConsole.ClientRef.Filter filter) {
            return base.Channel.FilteringFlightsAsync(result, filter);
        }
        
        public string AddNewBooking(FlightServiceClientConsole.ClientRef.Flight flight, FlightServiceClientConsole.ClientRef.Customer customer, int travellers) {
            return base.Channel.AddNewBooking(flight, customer, travellers);
        }
        
        public System.Threading.Tasks.Task<string> AddNewBookingAsync(FlightServiceClientConsole.ClientRef.Flight flight, FlightServiceClientConsole.ClientRef.Customer customer, int travellers) {
            return base.Channel.AddNewBookingAsync(flight, customer, travellers);
        }
        
        public string CancelBooking(string bookindId) {
            return base.Channel.CancelBooking(bookindId);
        }
        
        public System.Threading.Tasks.Task<string> CancelBookingAsync(string bookindId) {
            return base.Channel.CancelBookingAsync(bookindId);
        }
        
        public FlightServiceClientConsole.ClientRef.Result SaveCardDetails(FlightServiceClientConsole.ClientRef.Result result, FlightServiceClientConsole.ClientRef.Card card) {
            return base.Channel.SaveCardDetails(result, card);
        }
        
        public System.Threading.Tasks.Task<FlightServiceClientConsole.ClientRef.Result> SaveCardDetailsAsync(FlightServiceClientConsole.ClientRef.Result result, FlightServiceClientConsole.ClientRef.Card card) {
            return base.Channel.SaveCardDetailsAsync(result, card);
        }
    }
}
