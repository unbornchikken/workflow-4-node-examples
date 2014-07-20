﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.CorrelatedCalculator.CalculatorClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculator/Add")]
        void Add(double Value, string CalculatorId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculator/Add")]
        System.Threading.Tasks.Task AddAsync(double Value, string CalculatorId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculator/Subtract")]
        void Subtract(double Value, string CalculatorId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculator/Subtract")]
        System.Threading.Tasks.Task SubtractAsync(double Value, string CalculatorId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculator/Multiply")]
        void Multiply(double Value, string CalculatorId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculator/Multiply")]
        System.Threading.Tasks.Task MultiplyAsync(double Value, string CalculatorId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculator/Divide")]
        void Divide(double Value, string CalculatorId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculator/Divide")]
        System.Threading.Tasks.Task DivideAsync(double Value, string CalculatorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Equals", ReplyAction="http://tempuri.org/ICalculator/EqualsResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Value")]
        double Equals(string CalculatorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Equals", ReplyAction="http://tempuri.org/ICalculator/EqualsResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Value")]
        System.Threading.Tasks.Task<double> EqualsAsync(string CalculatorId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculator/Reset")]
        void Reset(string CalculatorId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculator/Reset")]
        System.Threading.Tasks.Task ResetAsync(string CalculatorId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : Microsoft.Samples.CorrelatedCalculator.CalculatorClient.ServiceReference1.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<Microsoft.Samples.CorrelatedCalculator.CalculatorClient.ServiceReference1.ICalculator>, Microsoft.Samples.CorrelatedCalculator.CalculatorClient.ServiceReference1.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Add(double Value, string CalculatorId) {
            base.Channel.Add(Value, CalculatorId);
        }
        
        public System.Threading.Tasks.Task AddAsync(double Value, string CalculatorId) {
            return base.Channel.AddAsync(Value, CalculatorId);
        }
        
        public void Subtract(double Value, string CalculatorId) {
            base.Channel.Subtract(Value, CalculatorId);
        }
        
        public System.Threading.Tasks.Task SubtractAsync(double Value, string CalculatorId) {
            return base.Channel.SubtractAsync(Value, CalculatorId);
        }
        
        public void Multiply(double Value, string CalculatorId) {
            base.Channel.Multiply(Value, CalculatorId);
        }
        
        public System.Threading.Tasks.Task MultiplyAsync(double Value, string CalculatorId) {
            return base.Channel.MultiplyAsync(Value, CalculatorId);
        }
        
        public void Divide(double Value, string CalculatorId) {
            base.Channel.Divide(Value, CalculatorId);
        }
        
        public System.Threading.Tasks.Task DivideAsync(double Value, string CalculatorId) {
            return base.Channel.DivideAsync(Value, CalculatorId);
        }
        
        public double Equals(string CalculatorId) {
            return base.Channel.Equals(CalculatorId);
        }
        
        public System.Threading.Tasks.Task<double> EqualsAsync(string CalculatorId) {
            return base.Channel.EqualsAsync(CalculatorId);
        }
        
        public void Reset(string CalculatorId) {
            base.Channel.Reset(CalculatorId);
        }
        
        public System.Threading.Tasks.Task ResetAsync(string CalculatorId) {
            return base.Channel.ResetAsync(CalculatorId);
        }
    }
}
