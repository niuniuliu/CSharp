﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.21205.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASPNETClient.WebServicesSample {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.wrox.com/BeginningCSharp/2010", ConfigurationName="WebServicesSample.SampleServiceSoap")]
    public interface SampleServiceSoap {
        
        // CODEGEN: Generating message contract since element name message from namespace http://www.wrox.com/BeginningCSharp/2010 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.wrox.com/BeginningCSharp/2010/ReverseString", ReplyAction="*")]
        ASPNETClient.WebServicesSample.ReverseStringResponse ReverseString(ASPNETClient.WebServicesSample.ReverseStringRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReverseStringRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReverseString", Namespace="http://www.wrox.com/BeginningCSharp/2010", Order=0)]
        public ASPNETClient.WebServicesSample.ReverseStringRequestBody Body;
        
        public ReverseStringRequest() {
        }
        
        public ReverseStringRequest(ASPNETClient.WebServicesSample.ReverseStringRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.wrox.com/BeginningCSharp/2010")]
    public partial class ReverseStringRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string message;
        
        public ReverseStringRequestBody() {
        }
        
        public ReverseStringRequestBody(string message) {
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReverseStringResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReverseStringResponse", Namespace="http://www.wrox.com/BeginningCSharp/2010", Order=0)]
        public ASPNETClient.WebServicesSample.ReverseStringResponseBody Body;
        
        public ReverseStringResponse() {
        }
        
        public ReverseStringResponse(ASPNETClient.WebServicesSample.ReverseStringResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.wrox.com/BeginningCSharp/2010")]
    public partial class ReverseStringResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ReverseStringResult;
        
        public ReverseStringResponseBody() {
        }
        
        public ReverseStringResponseBody(string ReverseStringResult) {
            this.ReverseStringResult = ReverseStringResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SampleServiceSoapChannel : ASPNETClient.WebServicesSample.SampleServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SampleServiceSoapClient : System.ServiceModel.ClientBase<ASPNETClient.WebServicesSample.SampleServiceSoap>, ASPNETClient.WebServicesSample.SampleServiceSoap {
        
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
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ASPNETClient.WebServicesSample.ReverseStringResponse ASPNETClient.WebServicesSample.SampleServiceSoap.ReverseString(ASPNETClient.WebServicesSample.ReverseStringRequest request) {
            return base.Channel.ReverseString(request);
        }
        
        public string ReverseString(string message) {
            ASPNETClient.WebServicesSample.ReverseStringRequest inValue = new ASPNETClient.WebServicesSample.ReverseStringRequest();
            inValue.Body = new ASPNETClient.WebServicesSample.ReverseStringRequestBody();
            inValue.Body.message = message;
            ASPNETClient.WebServicesSample.ReverseStringResponse retVal = ((ASPNETClient.WebServicesSample.SampleServiceSoap)(this)).ReverseString(inValue);
            return retVal.Body.ReverseStringResult;
        }
    }
}
