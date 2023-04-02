﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpaceBox_3D.ShapesServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ShapeParameters", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ShapeParameters : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private double RadiusField;
        
        private double LengthField;
        
        private double WidthField;
        
        private double SideAField;
        
        private double SideBField;
        
        private double SideCField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public double Radius {
            get {
                return this.RadiusField;
            }
            set {
                if ((this.RadiusField.Equals(value) != true)) {
                    this.RadiusField = value;
                    this.RaisePropertyChanged("Radius");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public double Length {
            get {
                return this.LengthField;
            }
            set {
                if ((this.LengthField.Equals(value) != true)) {
                    this.LengthField = value;
                    this.RaisePropertyChanged("Length");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public double Width {
            get {
                return this.WidthField;
            }
            set {
                if ((this.WidthField.Equals(value) != true)) {
                    this.WidthField = value;
                    this.RaisePropertyChanged("Width");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public double SideA {
            get {
                return this.SideAField;
            }
            set {
                if ((this.SideAField.Equals(value) != true)) {
                    this.SideAField = value;
                    this.RaisePropertyChanged("SideA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public double SideB {
            get {
                return this.SideBField;
            }
            set {
                if ((this.SideBField.Equals(value) != true)) {
                    this.SideBField = value;
                    this.RaisePropertyChanged("SideB");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public double SideC {
            get {
                return this.SideCField;
            }
            set {
                if ((this.SideCField.Equals(value) != true)) {
                    this.SideCField = value;
                    this.RaisePropertyChanged("SideC");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ShapesServiceReference.ShapesServiceSoap")]
    public interface ShapesServiceSoap {
        
        // CODEGEN: Generating message contract since element name shapeType from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateRequiredDotsForShape", ReplyAction="*")]
        SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeResponse CalculateRequiredDotsForShape(SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateRequiredDotsForShape", ReplyAction="*")]
        System.Threading.Tasks.Task<SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeResponse> CalculateRequiredDotsForShapeAsync(SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculateRequiredDotsForShapeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalculateRequiredDotsForShape", Namespace="http://tempuri.org/", Order=0)]
        public SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeRequestBody Body;
        
        public CalculateRequiredDotsForShapeRequest() {
        }
        
        public CalculateRequiredDotsForShapeRequest(SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalculateRequiredDotsForShapeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string shapeType;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public SpaceBox_3D.ShapesServiceReference.ShapeParameters shapeParameters;
        
        public CalculateRequiredDotsForShapeRequestBody() {
        }
        
        public CalculateRequiredDotsForShapeRequestBody(string shapeType, SpaceBox_3D.ShapesServiceReference.ShapeParameters shapeParameters) {
            this.shapeType = shapeType;
            this.shapeParameters = shapeParameters;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculateRequiredDotsForShapeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalculateRequiredDotsForShapeResponse", Namespace="http://tempuri.org/", Order=0)]
        public SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeResponseBody Body;
        
        public CalculateRequiredDotsForShapeResponse() {
        }
        
        public CalculateRequiredDotsForShapeResponse(SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalculateRequiredDotsForShapeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int CalculateRequiredDotsForShapeResult;
        
        public CalculateRequiredDotsForShapeResponseBody() {
        }
        
        public CalculateRequiredDotsForShapeResponseBody(int CalculateRequiredDotsForShapeResult) {
            this.CalculateRequiredDotsForShapeResult = CalculateRequiredDotsForShapeResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ShapesServiceSoapChannel : SpaceBox_3D.ShapesServiceReference.ShapesServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShapesServiceSoapClient : System.ServiceModel.ClientBase<SpaceBox_3D.ShapesServiceReference.ShapesServiceSoap>, SpaceBox_3D.ShapesServiceReference.ShapesServiceSoap {
        
        public ShapesServiceSoapClient() {
        }
        
        public ShapesServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ShapesServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShapesServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShapesServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeResponse SpaceBox_3D.ShapesServiceReference.ShapesServiceSoap.CalculateRequiredDotsForShape(SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeRequest request) {
            return base.Channel.CalculateRequiredDotsForShape(request);
        }
        
        public int CalculateRequiredDotsForShape(string shapeType, SpaceBox_3D.ShapesServiceReference.ShapeParameters shapeParameters) {
            SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeRequest inValue = new SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeRequest();
            inValue.Body = new SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeRequestBody();
            inValue.Body.shapeType = shapeType;
            inValue.Body.shapeParameters = shapeParameters;
            SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeResponse retVal = ((SpaceBox_3D.ShapesServiceReference.ShapesServiceSoap)(this)).CalculateRequiredDotsForShape(inValue);
            return retVal.Body.CalculateRequiredDotsForShapeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeResponse> SpaceBox_3D.ShapesServiceReference.ShapesServiceSoap.CalculateRequiredDotsForShapeAsync(SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeRequest request) {
            return base.Channel.CalculateRequiredDotsForShapeAsync(request);
        }
        
        public System.Threading.Tasks.Task<SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeResponse> CalculateRequiredDotsForShapeAsync(string shapeType, SpaceBox_3D.ShapesServiceReference.ShapeParameters shapeParameters) {
            SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeRequest inValue = new SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeRequest();
            inValue.Body = new SpaceBox_3D.ShapesServiceReference.CalculateRequiredDotsForShapeRequestBody();
            inValue.Body.shapeType = shapeType;
            inValue.Body.shapeParameters = shapeParameters;
            return ((SpaceBox_3D.ShapesServiceReference.ShapesServiceSoap)(this)).CalculateRequiredDotsForShapeAsync(inValue);
        }
    }
}
