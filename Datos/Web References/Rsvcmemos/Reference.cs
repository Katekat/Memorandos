﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34003.
// 
#pragma warning disable 1591

namespace Datos.Rsvcmemos {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="svcmemosSoap", Namespace="http://tempuri.org/")]
    public partial class svcmemos : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback CargarItemsOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertarDepartamentoOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertarTecnicoOperationCompleted;
        
        private System.Threading.SendOrPostCallback BuscarTecnicoOperationCompleted;
        
        private System.Threading.SendOrPostCallback BuscarDptoOperationCompleted;
        
        private System.Threading.SendOrPostCallback ActualizarDepartamentoOperationCompleted;
        
        private System.Threading.SendOrPostCallback ActualizarTecnicoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public svcmemos() {
            this.Url = global::Datos.Properties.Settings.Default.Datos_Rsvcmemos_svcmemos;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        public event CargarItemsCompletedEventHandler CargarItemsCompleted;
        
        /// <remarks/>
        public event InsertarDepartamentoCompletedEventHandler InsertarDepartamentoCompleted;
        
        /// <remarks/>
        public event InsertarTecnicoCompletedEventHandler InsertarTecnicoCompleted;
        
        /// <remarks/>
        public event BuscarTecnicoCompletedEventHandler BuscarTecnicoCompleted;
        
        /// <remarks/>
        public event BuscarDptoCompletedEventHandler BuscarDptoCompleted;
        
        /// <remarks/>
        public event ActualizarDepartamentoCompletedEventHandler ActualizarDepartamentoCompleted;
        
        /// <remarks/>
        public event ActualizarTecnicoCompletedEventHandler ActualizarTecnicoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CargarItems", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable CargarItems() {
            object[] results = this.Invoke("CargarItems", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void CargarItemsAsync() {
            this.CargarItemsAsync(null);
        }
        
        /// <remarks/>
        public void CargarItemsAsync(object userState) {
            if ((this.CargarItemsOperationCompleted == null)) {
                this.CargarItemsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCargarItemsOperationCompleted);
            }
            this.InvokeAsync("CargarItems", new object[0], this.CargarItemsOperationCompleted, userState);
        }
        
        private void OnCargarItemsOperationCompleted(object arg) {
            if ((this.CargarItemsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CargarItemsCompleted(this, new CargarItemsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertarDepartamento", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void InsertarDepartamento(int codigo, string nombre, string encargado) {
            this.Invoke("InsertarDepartamento", new object[] {
                        codigo,
                        nombre,
                        encargado});
        }
        
        /// <remarks/>
        public void InsertarDepartamentoAsync(int codigo, string nombre, string encargado) {
            this.InsertarDepartamentoAsync(codigo, nombre, encargado, null);
        }
        
        /// <remarks/>
        public void InsertarDepartamentoAsync(int codigo, string nombre, string encargado, object userState) {
            if ((this.InsertarDepartamentoOperationCompleted == null)) {
                this.InsertarDepartamentoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertarDepartamentoOperationCompleted);
            }
            this.InvokeAsync("InsertarDepartamento", new object[] {
                        codigo,
                        nombre,
                        encargado}, this.InsertarDepartamentoOperationCompleted, userState);
        }
        
        private void OnInsertarDepartamentoOperationCompleted(object arg) {
            if ((this.InsertarDepartamentoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertarDepartamentoCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertarTecnico", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void InsertarTecnico(string pCedula, string pnombre, string pcargo) {
            this.Invoke("InsertarTecnico", new object[] {
                        pCedula,
                        pnombre,
                        pcargo});
        }
        
        /// <remarks/>
        public void InsertarTecnicoAsync(string pCedula, string pnombre, string pcargo) {
            this.InsertarTecnicoAsync(pCedula, pnombre, pcargo, null);
        }
        
        /// <remarks/>
        public void InsertarTecnicoAsync(string pCedula, string pnombre, string pcargo, object userState) {
            if ((this.InsertarTecnicoOperationCompleted == null)) {
                this.InsertarTecnicoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertarTecnicoOperationCompleted);
            }
            this.InvokeAsync("InsertarTecnico", new object[] {
                        pCedula,
                        pnombre,
                        pcargo}, this.InsertarTecnicoOperationCompleted, userState);
        }
        
        private void OnInsertarTecnicoOperationCompleted(object arg) {
            if ((this.InsertarTecnicoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertarTecnicoCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BuscarTecnico", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet BuscarTecnico(string pCedula) {
            object[] results = this.Invoke("BuscarTecnico", new object[] {
                        pCedula});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void BuscarTecnicoAsync(string pCedula) {
            this.BuscarTecnicoAsync(pCedula, null);
        }
        
        /// <remarks/>
        public void BuscarTecnicoAsync(string pCedula, object userState) {
            if ((this.BuscarTecnicoOperationCompleted == null)) {
                this.BuscarTecnicoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscarTecnicoOperationCompleted);
            }
            this.InvokeAsync("BuscarTecnico", new object[] {
                        pCedula}, this.BuscarTecnicoOperationCompleted, userState);
        }
        
        private void OnBuscarTecnicoOperationCompleted(object arg) {
            if ((this.BuscarTecnicoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscarTecnicoCompleted(this, new BuscarTecnicoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BuscarDpto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet BuscarDpto(int pCodigo) {
            object[] results = this.Invoke("BuscarDpto", new object[] {
                        pCodigo});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void BuscarDptoAsync(int pCodigo) {
            this.BuscarDptoAsync(pCodigo, null);
        }
        
        /// <remarks/>
        public void BuscarDptoAsync(int pCodigo, object userState) {
            if ((this.BuscarDptoOperationCompleted == null)) {
                this.BuscarDptoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscarDptoOperationCompleted);
            }
            this.InvokeAsync("BuscarDpto", new object[] {
                        pCodigo}, this.BuscarDptoOperationCompleted, userState);
        }
        
        private void OnBuscarDptoOperationCompleted(object arg) {
            if ((this.BuscarDptoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscarDptoCompleted(this, new BuscarDptoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ActualizarDepartamento", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ActualizarDepartamento(int codigo, string nombre, string encargado) {
            this.Invoke("ActualizarDepartamento", new object[] {
                        codigo,
                        nombre,
                        encargado});
        }
        
        /// <remarks/>
        public void ActualizarDepartamentoAsync(int codigo, string nombre, string encargado) {
            this.ActualizarDepartamentoAsync(codigo, nombre, encargado, null);
        }
        
        /// <remarks/>
        public void ActualizarDepartamentoAsync(int codigo, string nombre, string encargado, object userState) {
            if ((this.ActualizarDepartamentoOperationCompleted == null)) {
                this.ActualizarDepartamentoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnActualizarDepartamentoOperationCompleted);
            }
            this.InvokeAsync("ActualizarDepartamento", new object[] {
                        codigo,
                        nombre,
                        encargado}, this.ActualizarDepartamentoOperationCompleted, userState);
        }
        
        private void OnActualizarDepartamentoOperationCompleted(object arg) {
            if ((this.ActualizarDepartamentoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ActualizarDepartamentoCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ActualizarTecnico", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ActualizarTecnico(string cedula, string nombre, string cargo) {
            this.Invoke("ActualizarTecnico", new object[] {
                        cedula,
                        nombre,
                        cargo});
        }
        
        /// <remarks/>
        public void ActualizarTecnicoAsync(string cedula, string nombre, string cargo) {
            this.ActualizarTecnicoAsync(cedula, nombre, cargo, null);
        }
        
        /// <remarks/>
        public void ActualizarTecnicoAsync(string cedula, string nombre, string cargo, object userState) {
            if ((this.ActualizarTecnicoOperationCompleted == null)) {
                this.ActualizarTecnicoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnActualizarTecnicoOperationCompleted);
            }
            this.InvokeAsync("ActualizarTecnico", new object[] {
                        cedula,
                        nombre,
                        cargo}, this.ActualizarTecnicoOperationCompleted, userState);
        }
        
        private void OnActualizarTecnicoOperationCompleted(object arg) {
            if ((this.ActualizarTecnicoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ActualizarTecnicoCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void CargarItemsCompletedEventHandler(object sender, CargarItemsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CargarItemsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CargarItemsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void InsertarDepartamentoCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void InsertarTecnicoCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void BuscarTecnicoCompletedEventHandler(object sender, BuscarTecnicoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscarTecnicoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscarTecnicoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void BuscarDptoCompletedEventHandler(object sender, BuscarDptoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscarDptoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscarDptoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void ActualizarDepartamentoCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void ActualizarTecnicoCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591