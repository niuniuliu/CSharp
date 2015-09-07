﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.21205.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeatherClient.WeatherService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.wrox.com/BeginningCSharp/2010", ConfigurationName="WeatherService.SampleServiceSoap")]
    public interface SampleServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.wrox.com/BeginningCSharp/2010/ReverseString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string ReverseString(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.wrox.com/BeginningCSharp/2010/GetWeather", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WeatherClient.WeatherService.GetWeatherResponse GetWeather(WeatherClient.WeatherService.GetWeatherRequest req);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.21205.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.wrox.com/BeginningCSharp/2010")]
    public partial class GetWeatherRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string cityField;
        
        private TemperatureType temperatureTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
                this.RaisePropertyChanged("City");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public TemperatureType TemperatureType {
            get {
                return this.temperatureTypeField;
            }
            set {
                this.temperatureTypeField = value;
                this.RaisePropertyChanged("TemperatureType");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.21205.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.wrox.com/BeginningCSharp/2010")]
    public enum TemperatureType {
        
        /// <remarks/>
        Fahrenheit,
        
        /// <remarks/>
        Celsius,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.21205.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.wrox.com/BeginningCSharp/2010")]
    public partial class GetWeatherResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private TemparatureCondition conditionField;
        
        private int temperatureField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TemparatureCondition Condition {
            get {
                return this.conditionField;
            }
            set {
                this.conditionField = value;
                this.RaisePropertyChanged("Condition");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Temperature {
            get {
                return this.temperatureField;
            }
            set {
                this.temperatureField = value;
                this.RaisePropertyChanged("Temperature");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.21205.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.wrox.com/BeginningCSharp/2010")]
    public enum TemparatureCondition {
        
        /// <remarks/>
        Rainy,
        
        /// <remarks/>
        Sunny,
        
        /// <remarks/>
        Cloudy,
        
        /// <remarks/>
        Thunderstorm,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SampleServiceSoapChannel : WeatherClient.WeatherService.SampleServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SampleServiceSoapClient : System.ServiceModel.ClientBase<WeatherClient.WeatherService.SampleServiceSoap>, WeatherClient.WeatherService.SampleServiceSoap {
        
        public SampleServiceSoapClient() {
        }
        
        public SampleServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SampleServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ReverseString(string message) {
            return base.Channel.ReverseString(message);
        }
        
        public WeatherClient.WeatherService.GetWeatherResponse GetWeather(WeatherClient.WeatherService.GetWeatherRequest req) {
            return base.Channel.GetWeather(req);
        }
    }
}