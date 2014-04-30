﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VJoyTestFeeder.VJoyServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VJoyServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ConnectJoystick", ReplyAction="http://tempuri.org/IService/ConnectJoystickResponse")]
        int ConnectJoystick();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ConnectJoystick", ReplyAction="http://tempuri.org/IService/ConnectJoystickResponse")]
        System.Threading.Tasks.Task<int> ConnectJoystickAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/PostCurrentJoystickState", ReplyAction="http://tempuri.org/IService/PostCurrentJoystickStateResponse")]
        void PostCurrentJoystickState(int joyId, vJoyInterfaceWrap.vJoy.JoystickState joyState);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/PostCurrentJoystickState", ReplyAction="http://tempuri.org/IService/PostCurrentJoystickStateResponse")]
        System.Threading.Tasks.Task PostCurrentJoystickStateAsync(int joyId, vJoyInterfaceWrap.vJoy.JoystickState joyState);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : VJoyTestFeeder.VJoyServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<VJoyTestFeeder.VJoyServiceReference.IService>, VJoyTestFeeder.VJoyServiceReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int ConnectJoystick() {
            return base.Channel.ConnectJoystick();
        }
        
        public System.Threading.Tasks.Task<int> ConnectJoystickAsync() {
            return base.Channel.ConnectJoystickAsync();
        }
        
        public void PostCurrentJoystickState(int joyId, vJoyInterfaceWrap.vJoy.JoystickState joyState) {
            base.Channel.PostCurrentJoystickState(joyId, joyState);
        }
        
        public System.Threading.Tasks.Task PostCurrentJoystickStateAsync(int joyId, vJoyInterfaceWrap.vJoy.JoystickState joyState) {
            return base.Channel.PostCurrentJoystickStateAsync(joyId, joyState);
        }
    }
}
