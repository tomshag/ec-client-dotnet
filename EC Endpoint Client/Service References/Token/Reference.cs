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

namespace EC_Endpoint_Client.Service_References.Token {
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
    [DataContract(Name="AuthorizationAccessTokenResponseExternalBE", Namespace="http://schemas.datacontract.org/2004/07/Altinn.Common.SBL.Entities.Authorization")]
    [Serializable()]
    public partial class AuthorizationAccessTokenResponseExternalBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [NonSerialized()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [OptionalField()]
        private System.Nullable<System.Guid> ReferenceTokenField;
        
        [OptionalField()]
        private string SelfContainedTokenField;
        
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
        public System.Nullable<System.Guid> ReferenceToken {
            get {
                return this.ReferenceTokenField;
            }
            set {
                if ((this.ReferenceTokenField.Equals(value) != true)) {
                    this.ReferenceTokenField = value;
                    this.RaisePropertyChanged("ReferenceToken");
                }
            }
        }
        
        [DataMember()]
        public string SelfContainedToken {
            get {
                return this.SelfContainedTokenField;
            }
            set {
                if ((object.ReferenceEquals(this.SelfContainedTokenField, value) != true)) {
                    this.SelfContainedTokenField = value;
                    this.RaisePropertyChanged("SelfContainedToken");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.altinn.no/services/Authorization/Administration/2016/02", ConfigurationName="Token.IAuthorizationTokenExternalEC")]
    public interface IAuthorizationTokenExternalEC {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://www.altinn.no/services/2009/10) of message TestRequest does not match the default value (http://www.altinn.no/services/Authorization/Administration/2016/02)
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/Test", ReplyAction="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AltinnFault), Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        TestResponse Test(TestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/Test", ReplyAction="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestResponse")]
        System.Threading.Tasks.Task<TestResponse> TestAsync(TestRequest request);
        
        // CODEGEN: Generating message contract since element name userName from namespace http://www.altinn.no/services/Authorization/Administration/2016/02 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/Authorization/Administration/2016/02/IAuthorization" +
            "TokenExternalEC/GetAccessToken", ReplyAction="http://www.altinn.no/services/Authorization/Administration/2016/02/IAuthorization" +
            "TokenExternalEC/GetAccessTokenResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AltinnFault), Action="http://www.altinn.no/services/Authorization/Administration/2016/02/IAuthorization" +
            "TokenExternalEC/GetAccessTokenAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/Authorization/Administration/2016/02/IAuthorization" +
            "TokenExternalEC/GetAccessToken", ReplyAction="http://www.altinn.no/services/Authorization/Administration/2016/02/IAuthorization" +
            "TokenExternalEC/GetAccessTokenResponse")]
        System.Threading.Tasks.Task<GetAccessTokenResponse> GetAccessTokenAsync(GetAccessTokenRequest request);
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
    public partial class GetAccessTokenRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAccessToken", Namespace="http://www.altinn.no/services/Authorization/Administration/2016/02", Order=0)]
        public GetAccessTokenRequestBody Body;
        
        public GetAccessTokenRequest() {
        }
        
        public GetAccessTokenRequest(GetAccessTokenRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [DataContract(Namespace="http://www.altinn.no/services/Authorization/Administration/2016/02")]
    public partial class GetAccessTokenRequestBody {
        
        [DataMember(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        [DataMember(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [DataMember(Order=2)]
        public System.Guid authorizationCode;
        
        [DataMember(Order=3)]
        public bool selfContained;
        
        public GetAccessTokenRequestBody() {
        }
        
        public GetAccessTokenRequestBody(string userName, string password, System.Guid authorizationCode, bool selfContained) {
            this.userName = userName;
            this.password = password;
            this.authorizationCode = authorizationCode;
            this.selfContained = selfContained;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAccessTokenResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAccessTokenResponse", Namespace="http://www.altinn.no/services/Authorization/Administration/2016/02", Order=0)]
        public GetAccessTokenResponseBody Body;
        
        public GetAccessTokenResponse() {
        }
        
        public GetAccessTokenResponse(GetAccessTokenResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [DataContract(Namespace="http://www.altinn.no/services/Authorization/Administration/2016/02")]
    public partial class GetAccessTokenResponseBody {
        
        [DataMember(Order=0)]
        public AuthorizationAccessTokenResponseExternalBE GetAccessTokenResult;
        
        public GetAccessTokenResponseBody() {
        }
        
        public GetAccessTokenResponseBody(AuthorizationAccessTokenResponseExternalBE GetAccessTokenResult) {
            this.GetAccessTokenResult = GetAccessTokenResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthorizationTokenExternalECChannel : IAuthorizationTokenExternalEC, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthorizationTokenExternalECClient : System.ServiceModel.ClientBase<IAuthorizationTokenExternalEC>, IAuthorizationTokenExternalEC {
        
        public AuthorizationTokenExternalECClient() {
        }
        
        public AuthorizationTokenExternalECClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthorizationTokenExternalECClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthorizationTokenExternalECClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthorizationTokenExternalECClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestResponse IAuthorizationTokenExternalEC.Test(TestRequest request) {
            return base.Channel.Test(request);
        }
        
        public void Test() {
            TestRequest inValue = new TestRequest();
            TestResponse retVal = ((IAuthorizationTokenExternalEC)(this)).Test(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestResponse> IAuthorizationTokenExternalEC.TestAsync(TestRequest request) {
            return base.Channel.TestAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestResponse> TestAsync() {
            TestRequest inValue = new TestRequest();
            return ((IAuthorizationTokenExternalEC)(this)).TestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetAccessTokenResponse IAuthorizationTokenExternalEC.GetAccessToken(GetAccessTokenRequest request) {
            return base.Channel.GetAccessToken(request);
        }
        
        public AuthorizationAccessTokenResponseExternalBE GetAccessToken(string userName, string password, System.Guid authorizationCode, bool selfContained) {
            GetAccessTokenRequest inValue = new GetAccessTokenRequest();
            inValue.Body = new GetAccessTokenRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            inValue.Body.authorizationCode = authorizationCode;
            inValue.Body.selfContained = selfContained;
            GetAccessTokenResponse retVal = ((IAuthorizationTokenExternalEC)(this)).GetAccessToken(inValue);
            return retVal.Body.GetAccessTokenResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetAccessTokenResponse> IAuthorizationTokenExternalEC.GetAccessTokenAsync(GetAccessTokenRequest request) {
            return base.Channel.GetAccessTokenAsync(request);
        }
        
        public System.Threading.Tasks.Task<GetAccessTokenResponse> GetAccessTokenAsync(string userName, string password, System.Guid authorizationCode, bool selfContained) {
            GetAccessTokenRequest inValue = new GetAccessTokenRequest();
            inValue.Body = new GetAccessTokenRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            inValue.Body.authorizationCode = authorizationCode;
            inValue.Body.selfContained = selfContained;
            return ((IAuthorizationTokenExternalEC)(this)).GetAccessTokenAsync(inValue);
        }
    }
}
