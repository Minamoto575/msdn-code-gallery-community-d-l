//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VisualStudio.BizTalkProject.Generators, Version 4.0.30319.239.
// 
namespace HandlerExceptionsInsideOrchestration.net.webservicex.www {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="GlobalWeatherSoap", Namespace="http://www.webserviceX.NET")]
    [Microsoft.XLANGs.BaseTypes.WebServiceUrlAttribute("http://www.webservicex.net/globalweather.asmx")]
    public partial class GlobalWeather : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public GlobalWeather() {
            this.Url = "http://www.webservicex.net/globalweather.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webserviceX.NET/GetWeather", RequestNamespace="http://www.webserviceX.NET", ResponseNamespace="http://www.webserviceX.NET", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetWeather(string CityName, string CountryName) {
            object[] results = this.Invoke("GetWeather", new object[] {
                        CityName,
                        CountryName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetWeather(string CityName, string CountryName, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetWeather", new object[] {
                        CityName,
                        CountryName}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetWeather(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webserviceX.NET/GetCitiesByCountry", RequestNamespace="http://www.webserviceX.NET", ResponseNamespace="http://www.webserviceX.NET", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetCitiesByCountry(string CountryName) {
            object[] results = this.Invoke("GetCitiesByCountry", new object[] {
                        CountryName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetCitiesByCountry(string CountryName, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetCitiesByCountry", new object[] {
                        CountryName}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetCitiesByCountry(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
    }
}
