﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebserviceTest.ServiceReference1
{


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://cxfserver.lxl.cn/", ConfigurationName = "ServiceReference1.IWeatherService")]
    public interface IWeatherService
    {

        // CODEGEN: 命名空间  的元素名称 arg0 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        WebserviceTest.ServiceReference1.infoResponse info(WebserviceTest.ServiceReference1.info request);

        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        System.Threading.Tasks.Task<WebserviceTest.ServiceReference1.infoResponse> infoAsync(WebserviceTest.ServiceReference1.info request);
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class info
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "info", Namespace = "http://cxfserver.lxl.cn/", Order = 0)]
        public WebserviceTest.ServiceReference1.infoBody Body;

        public info()
        {
        }

        public info(WebserviceTest.ServiceReference1.infoBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "")]
    public partial class infoBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string arg0;

        public infoBody()
        {
        }

        public infoBody(string arg0)
        {
            this.arg0 = arg0;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class infoResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "infoResponse", Namespace = "http://cxfserver.lxl.cn/", Order = 0)]
        public WebserviceTest.ServiceReference1.infoResponseBody Body;

        public infoResponse()
        {
        }

        public infoResponse(WebserviceTest.ServiceReference1.infoResponseBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "")]
    public partial class infoResponseBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string @return;

        public infoResponseBody()
        {
        }

        public infoResponseBody(string @return)
        {
            this.@return = @return;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWeatherServiceChannel : WebserviceTest.ServiceReference1.IWeatherService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WeatherServiceClient : System.ServiceModel.ClientBase<WebserviceTest.ServiceReference1.IWeatherService>, WebserviceTest.ServiceReference1.IWeatherService
    {

        public WeatherServiceClient()
        {
        }

        public WeatherServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public WeatherServiceClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public WeatherServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public WeatherServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebserviceTest.ServiceReference1.infoResponse WebserviceTest.ServiceReference1.IWeatherService.info(WebserviceTest.ServiceReference1.info request)
        {
            return base.Channel.info(request);
        }

        public string info(string arg0)
        {
            WebserviceTest.ServiceReference1.info inValue = new WebserviceTest.ServiceReference1.info();
            inValue.Body = new WebserviceTest.ServiceReference1.infoBody();
            inValue.Body.arg0 = arg0;
            WebserviceTest.ServiceReference1.infoResponse retVal = ((WebserviceTest.ServiceReference1.IWeatherService)(this)).info(inValue);
            return retVal.Body.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebserviceTest.ServiceReference1.infoResponse> WebserviceTest.ServiceReference1.IWeatherService.infoAsync(WebserviceTest.ServiceReference1.info request)
        {
            return base.Channel.infoAsync(request);
        }

        public System.Threading.Tasks.Task<WebserviceTest.ServiceReference1.infoResponse> infoAsync(string arg0)
        {
            WebserviceTest.ServiceReference1.info inValue = new WebserviceTest.ServiceReference1.info();
            inValue.Body = new WebserviceTest.ServiceReference1.infoBody();
            inValue.Body.arg0 = arg0;
            return ((WebserviceTest.ServiceReference1.IWeatherService)(this)).infoAsync(inValue);
        }
    }
}