﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Runtime.Serialization;

namespace EC_Endpoint_Client.Service_References.LookUp {
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
    [Serializable()]
    public partial class AltinnFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [NonSerialized()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [OptionalField()]
        private string AltinnErrorMessageField;
        
        [OptionalField()]
        private string AltinnExtendedErrorMessageField;
        
        [OptionalField()]
        private string AltinnLocalizedErrorMessageField;
        
        [OptionalField()]
        private string ErrorGuidField;
        
        [OptionalField()]
        private int ErrorIDField;
        
        [OptionalField()]
        private string UserGuidField;
        
        [OptionalField()]
        private string UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [DataMember()]
        public string AltinnErrorMessage {
            get {
                return this.AltinnErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.AltinnErrorMessageField, value) != true)) {
                    this.AltinnErrorMessageField = value;
                    this.RaisePropertyChanged("AltinnErrorMessage");
                }
            }
        }
        
        [DataMember()]
        public string AltinnExtendedErrorMessage {
            get {
                return this.AltinnExtendedErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.AltinnExtendedErrorMessageField, value) != true)) {
                    this.AltinnExtendedErrorMessageField = value;
                    this.RaisePropertyChanged("AltinnExtendedErrorMessage");
                }
            }
        }
        
        [DataMember()]
        public string AltinnLocalizedErrorMessage {
            get {
                return this.AltinnLocalizedErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.AltinnLocalizedErrorMessageField, value) != true)) {
                    this.AltinnLocalizedErrorMessageField = value;
                    this.RaisePropertyChanged("AltinnLocalizedErrorMessage");
                }
            }
        }
        
        [DataMember()]
        public string ErrorGuid {
            get {
                return this.ErrorGuidField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorGuidField, value) != true)) {
                    this.ErrorGuidField = value;
                    this.RaisePropertyChanged("ErrorGuid");
                }
            }
        }
        
        [DataMember()]
        public int ErrorID {
            get {
                return this.ErrorIDField;
            }
            set {
                if ((this.ErrorIDField.Equals(value) != true)) {
                    this.ErrorIDField = value;
                    this.RaisePropertyChanged("ErrorID");
                }
            }
        }
        
        [DataMember()]
        public string UserGuid {
            get {
                return this.UserGuidField;
            }
            set {
                if ((object.ReferenceEquals(this.UserGuidField, value) != true)) {
                    this.UserGuidField = value;
                    this.RaisePropertyChanged("UserGuid");
                }
            }
        }
        
        [DataMember()]
        public string UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIdField, value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [DataContract(Name="LookUpRequest", Namespace="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02")]
    [Serializable()]
    public partial class LookUpRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [NonSerialized()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string QueryDataField;
        
        private string ReporteeField;
        
        private string ServiceCodeField;
        
        private int ServiceEditionCodeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [DataMember(IsRequired=true)]
        public string QueryData {
            get {
                return this.QueryDataField;
            }
            set {
                if ((object.ReferenceEquals(this.QueryDataField, value) != true)) {
                    this.QueryDataField = value;
                    this.RaisePropertyChanged("QueryData");
                }
            }
        }
        
        [DataMember(IsRequired=true)]
        public string Reportee {
            get {
                return this.ReporteeField;
            }
            set {
                if ((object.ReferenceEquals(this.ReporteeField, value) != true)) {
                    this.ReporteeField = value;
                    this.RaisePropertyChanged("Reportee");
                }
            }
        }
        
        [DataMember(IsRequired=true)]
        public string ServiceCode {
            get {
                return this.ServiceCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceCodeField, value) != true)) {
                    this.ServiceCodeField = value;
                    this.RaisePropertyChanged("ServiceCode");
                }
            }
        }
        
        [DataMember(IsRequired=true)]
        public int ServiceEditionCode {
            get {
                return this.ServiceEditionCodeField;
            }
            set {
                if ((this.ServiceEditionCodeField.Equals(value) != true)) {
                    this.ServiceEditionCodeField = value;
                    this.RaisePropertyChanged("ServiceEditionCode");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02", ConfigurationName="LookUp.ILookUpExternalEC")]
    public interface ILookUpExternalEC {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://www.altinn.no/services/2009/10) of message TestRequest does not match the default value (http://www.altinn.no/services/ServiceEngine/LookUp/2016/02)
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/Test", ReplyAction="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AltinnFault), Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        TestResponse Test(TestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/Test", ReplyAction="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestResponse")]
        System.Threading.Tasks.Task<TestResponse> TestAsync(TestRequest request);
        
        // CODEGEN: Generating message contract since element name userName from namespace http://www.altinn.no/services/ServiceEngine/LookUp/2016/02 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02/ILookUpExternalEC/Exec" +
            "uteLookUp", ReplyAction="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02/ILookUpExternalEC/Exec" +
            "uteLookUpResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AltinnFault), Action="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02/ILookUpExternalEC/Exec" +
            "uteLookUpAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        ExecuteLookUpResponse ExecuteLookUp(ExecuteLookUpRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02/ILookUpExternalEC/Exec" +
            "uteLookUp", ReplyAction="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02/ILookUpExternalEC/Exec" +
            "uteLookUpResponse")]
        System.Threading.Tasks.Task<ExecuteLookUpResponse> ExecuteLookUpAsync(ExecuteLookUpRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Test", WrapperNamespace="http://www.altinn.no/services/2009/10", IsWrapped=true)]
    public partial class TestRequest {
        
        public TestRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TestResponse", WrapperNamespace="http://www.altinn.no/services/2009/10", IsWrapped=true)]
    public partial class TestResponse {
        
        public TestResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteLookUpRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExecuteLookUp", Namespace="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02", Order=0)]
        public ExecuteLookUpRequestBody Body;
        
        public ExecuteLookUpRequest() {
        }
        
        public ExecuteLookUpRequest(ExecuteLookUpRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [DataContract(Namespace="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02")]
    public partial class ExecuteLookUpRequestBody {
        
        [DataMember(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        [DataMember(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [DataMember(EmitDefaultValue=false, Order=2)]
        public LookUpRequest lookUpRequest;
        
        public ExecuteLookUpRequestBody() {
        }
        
        public ExecuteLookUpRequestBody(string userName, string password, LookUpRequest lookUpRequest) {
            this.userName = userName;
            this.password = password;
            this.lookUpRequest = lookUpRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteLookUpResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExecuteLookUpResponse", Namespace="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02", Order=0)]
        public ExecuteLookUpResponseBody Body;
        
        public ExecuteLookUpResponse() {
        }
        
        public ExecuteLookUpResponse(ExecuteLookUpResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [DataContract(Namespace="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02")]
    public partial class ExecuteLookUpResponseBody {
        
        [DataMember(Order=0)]
        public string ExecuteLookUpResult;
        
        public ExecuteLookUpResponseBody() {
        }
        
        public ExecuteLookUpResponseBody(string ExecuteLookUpResult) {
            this.ExecuteLookUpResult = ExecuteLookUpResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILookUpExternalECChannel : ILookUpExternalEC, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LookUpExternalECClient : System.ServiceModel.ClientBase<ILookUpExternalEC>, ILookUpExternalEC {
        
        public LookUpExternalECClient() {
        }
        
        public LookUpExternalECClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LookUpExternalECClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LookUpExternalECClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LookUpExternalECClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestResponse ILookUpExternalEC.Test(TestRequest request) {
            return base.Channel.Test(request);
        }
        
        public void Test() {
            TestRequest inValue = new TestRequest();
            TestResponse retVal = ((ILookUpExternalEC)(this)).Test(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestResponse> ILookUpExternalEC.TestAsync(TestRequest request) {
            return base.Channel.TestAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestResponse> TestAsync() {
            TestRequest inValue = new TestRequest();
            return ((ILookUpExternalEC)(this)).TestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ExecuteLookUpResponse ILookUpExternalEC.ExecuteLookUp(ExecuteLookUpRequest request) {
            return base.Channel.ExecuteLookUp(request);
        }
        
        public string ExecuteLookUp(string userName, string password, LookUpRequest lookUpRequest) {
            ExecuteLookUpRequest inValue = new ExecuteLookUpRequest();
            inValue.Body = new ExecuteLookUpRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            inValue.Body.lookUpRequest = lookUpRequest;
            ExecuteLookUpResponse retVal = ((ILookUpExternalEC)(this)).ExecuteLookUp(inValue);
            return retVal.Body.ExecuteLookUpResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ExecuteLookUpResponse> ILookUpExternalEC.ExecuteLookUpAsync(ExecuteLookUpRequest request) {
            return base.Channel.ExecuteLookUpAsync(request);
        }
        
        public System.Threading.Tasks.Task<ExecuteLookUpResponse> ExecuteLookUpAsync(string userName, string password, LookUpRequest lookUpRequest) {
            ExecuteLookUpRequest inValue = new ExecuteLookUpRequest();
            inValue.Body = new ExecuteLookUpRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            inValue.Body.lookUpRequest = lookUpRequest;
            return ((ILookUpExternalEC)(this)).ExecuteLookUpAsync(inValue);
        }
    }
}
