﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WarlockSoft.JCargaMasiva2 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="EstadosYComentariosPortBinding", Namespace="http://Servicios/")]
    public partial class EstadosYComentarios : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback S1OperationCompleted;
        
        private System.Threading.SendOrPostCallback S2OperationCompleted;
        
        private System.Threading.SendOrPostCallback S3OperationCompleted;
        
        private System.Threading.SendOrPostCallback S4OperationCompleted;
        
        private System.Threading.SendOrPostCallback S5OperationCompleted;
        
        private System.Threading.SendOrPostCallback S6OperationCompleted;
        
        private System.Threading.SendOrPostCallback S7OperationCompleted;
        
        private System.Threading.SendOrPostCallback esUnNumeroOperationCompleted;
        
        private System.Threading.SendOrPostCallback leerEstadosYComentariosOperationCompleted;
        
        private System.Threading.SendOrPostCallback S9OperationCompleted;
        
        private System.Threading.SendOrPostCallback S10OperationCompleted;
        
        private System.Threading.SendOrPostCallback S8OperationCompleted;
        
        private System.Threading.SendOrPostCallback S11OperationCompleted;
        
        private System.Threading.SendOrPostCallback S12OperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public EstadosYComentarios() {
            this.Url = global::WarlockSoft.Properties.Settings.Default.WarlockSoft_JCargaMasiva2_EstadosYComentarios;
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
        public event S1CompletedEventHandler S1Completed;
        
        /// <remarks/>
        public event S2CompletedEventHandler S2Completed;
        
        /// <remarks/>
        public event S3CompletedEventHandler S3Completed;
        
        /// <remarks/>
        public event S4CompletedEventHandler S4Completed;
        
        /// <remarks/>
        public event S5CompletedEventHandler S5Completed;
        
        /// <remarks/>
        public event S6CompletedEventHandler S6Completed;
        
        /// <remarks/>
        public event S7CompletedEventHandler S7Completed;
        
        /// <remarks/>
        public event esUnNumeroCompletedEventHandler esUnNumeroCompleted;
        
        /// <remarks/>
        public event leerEstadosYComentariosCompletedEventHandler leerEstadosYComentariosCompleted;
        
        /// <remarks/>
        public event S9CompletedEventHandler S9Completed;
        
        /// <remarks/>
        public event S10CompletedEventHandler S10Completed;
        
        /// <remarks/>
        public event S8CompletedEventHandler S8Completed;
        
        /// <remarks/>
        public event S11CompletedEventHandler S11Completed;
        
        /// <remarks/>
        public event S12CompletedEventHandler S12Completed;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void S1() {
            this.Invoke("S1", new object[0]);
        }
        
        /// <remarks/>
        public void S1Async() {
            this.S1Async(null);
        }
        
        /// <remarks/>
        public void S1Async(object userState) {
            if ((this.S1OperationCompleted == null)) {
                this.S1OperationCompleted = new System.Threading.SendOrPostCallback(this.OnS1OperationCompleted);
            }
            this.InvokeAsync("S1", new object[0], this.S1OperationCompleted, userState);
        }
        
        private void OnS1OperationCompleted(object arg) {
            if ((this.S1Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.S1Completed(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void S2() {
            this.Invoke("S2", new object[0]);
        }
        
        /// <remarks/>
        public void S2Async() {
            this.S2Async(null);
        }
        
        /// <remarks/>
        public void S2Async(object userState) {
            if ((this.S2OperationCompleted == null)) {
                this.S2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnS2OperationCompleted);
            }
            this.InvokeAsync("S2", new object[0], this.S2OperationCompleted, userState);
        }
        
        private void OnS2OperationCompleted(object arg) {
            if ((this.S2Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.S2Completed(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void S3() {
            this.Invoke("S3", new object[0]);
        }
        
        /// <remarks/>
        public void S3Async() {
            this.S3Async(null);
        }
        
        /// <remarks/>
        public void S3Async(object userState) {
            if ((this.S3OperationCompleted == null)) {
                this.S3OperationCompleted = new System.Threading.SendOrPostCallback(this.OnS3OperationCompleted);
            }
            this.InvokeAsync("S3", new object[0], this.S3OperationCompleted, userState);
        }
        
        private void OnS3OperationCompleted(object arg) {
            if ((this.S3Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.S3Completed(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void S4() {
            this.Invoke("S4", new object[0]);
        }
        
        /// <remarks/>
        public void S4Async() {
            this.S4Async(null);
        }
        
        /// <remarks/>
        public void S4Async(object userState) {
            if ((this.S4OperationCompleted == null)) {
                this.S4OperationCompleted = new System.Threading.SendOrPostCallback(this.OnS4OperationCompleted);
            }
            this.InvokeAsync("S4", new object[0], this.S4OperationCompleted, userState);
        }
        
        private void OnS4OperationCompleted(object arg) {
            if ((this.S4Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.S4Completed(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void S5([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0) {
            this.Invoke("S5", new object[] {
                        arg0});
        }
        
        /// <remarks/>
        public void S5Async(string arg0) {
            this.S5Async(arg0, null);
        }
        
        /// <remarks/>
        public void S5Async(string arg0, object userState) {
            if ((this.S5OperationCompleted == null)) {
                this.S5OperationCompleted = new System.Threading.SendOrPostCallback(this.OnS5OperationCompleted);
            }
            this.InvokeAsync("S5", new object[] {
                        arg0}, this.S5OperationCompleted, userState);
        }
        
        private void OnS5OperationCompleted(object arg) {
            if ((this.S5Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.S5Completed(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void S6() {
            this.Invoke("S6", new object[0]);
        }
        
        /// <remarks/>
        public void S6Async() {
            this.S6Async(null);
        }
        
        /// <remarks/>
        public void S6Async(object userState) {
            if ((this.S6OperationCompleted == null)) {
                this.S6OperationCompleted = new System.Threading.SendOrPostCallback(this.OnS6OperationCompleted);
            }
            this.InvokeAsync("S6", new object[0], this.S6OperationCompleted, userState);
        }
        
        private void OnS6OperationCompleted(object arg) {
            if ((this.S6Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.S6Completed(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void S7() {
            this.Invoke("S7", new object[0]);
        }
        
        /// <remarks/>
        public void S7Async() {
            this.S7Async(null);
        }
        
        /// <remarks/>
        public void S7Async(object userState) {
            if ((this.S7OperationCompleted == null)) {
                this.S7OperationCompleted = new System.Threading.SendOrPostCallback(this.OnS7OperationCompleted);
            }
            this.InvokeAsync("S7", new object[0], this.S7OperationCompleted, userState);
        }
        
        private void OnS7OperationCompleted(object arg) {
            if ((this.S7Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.S7Completed(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool esUnNumero([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0) {
            object[] results = this.Invoke("esUnNumero", new object[] {
                        arg0});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void esUnNumeroAsync(string arg0) {
            this.esUnNumeroAsync(arg0, null);
        }
        
        /// <remarks/>
        public void esUnNumeroAsync(string arg0, object userState) {
            if ((this.esUnNumeroOperationCompleted == null)) {
                this.esUnNumeroOperationCompleted = new System.Threading.SendOrPostCallback(this.OnesUnNumeroOperationCompleted);
            }
            this.InvokeAsync("esUnNumero", new object[] {
                        arg0}, this.esUnNumeroOperationCompleted, userState);
        }
        
        private void OnesUnNumeroOperationCompleted(object arg) {
            if ((this.esUnNumeroCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.esUnNumeroCompleted(this, new esUnNumeroCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void leerEstadosYComentarios([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string ruta) {
            this.Invoke("leerEstadosYComentarios", new object[] {
                        ruta});
        }
        
        /// <remarks/>
        public void leerEstadosYComentariosAsync(string ruta) {
            this.leerEstadosYComentariosAsync(ruta, null);
        }
        
        /// <remarks/>
        public void leerEstadosYComentariosAsync(string ruta, object userState) {
            if ((this.leerEstadosYComentariosOperationCompleted == null)) {
                this.leerEstadosYComentariosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnleerEstadosYComentariosOperationCompleted);
            }
            this.InvokeAsync("leerEstadosYComentarios", new object[] {
                        ruta}, this.leerEstadosYComentariosOperationCompleted, userState);
        }
        
        private void OnleerEstadosYComentariosOperationCompleted(object arg) {
            if ((this.leerEstadosYComentariosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.leerEstadosYComentariosCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void S9() {
            this.Invoke("S9", new object[0]);
        }
        
        /// <remarks/>
        public void S9Async() {
            this.S9Async(null);
        }
        
        /// <remarks/>
        public void S9Async(object userState) {
            if ((this.S9OperationCompleted == null)) {
                this.S9OperationCompleted = new System.Threading.SendOrPostCallback(this.OnS9OperationCompleted);
            }
            this.InvokeAsync("S9", new object[0], this.S9OperationCompleted, userState);
        }
        
        private void OnS9OperationCompleted(object arg) {
            if ((this.S9Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.S9Completed(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void S10() {
            this.Invoke("S10", new object[0]);
        }
        
        /// <remarks/>
        public void S10Async() {
            this.S10Async(null);
        }
        
        /// <remarks/>
        public void S10Async(object userState) {
            if ((this.S10OperationCompleted == null)) {
                this.S10OperationCompleted = new System.Threading.SendOrPostCallback(this.OnS10OperationCompleted);
            }
            this.InvokeAsync("S10", new object[0], this.S10OperationCompleted, userState);
        }
        
        private void OnS10OperationCompleted(object arg) {
            if ((this.S10Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.S10Completed(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void S8([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0) {
            this.Invoke("S8", new object[] {
                        arg0});
        }
        
        /// <remarks/>
        public void S8Async(string arg0) {
            this.S8Async(arg0, null);
        }
        
        /// <remarks/>
        public void S8Async(string arg0, object userState) {
            if ((this.S8OperationCompleted == null)) {
                this.S8OperationCompleted = new System.Threading.SendOrPostCallback(this.OnS8OperationCompleted);
            }
            this.InvokeAsync("S8", new object[] {
                        arg0}, this.S8OperationCompleted, userState);
        }
        
        private void OnS8OperationCompleted(object arg) {
            if ((this.S8Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.S8Completed(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void S11() {
            this.Invoke("S11", new object[0]);
        }
        
        /// <remarks/>
        public void S11Async() {
            this.S11Async(null);
        }
        
        /// <remarks/>
        public void S11Async(object userState) {
            if ((this.S11OperationCompleted == null)) {
                this.S11OperationCompleted = new System.Threading.SendOrPostCallback(this.OnS11OperationCompleted);
            }
            this.InvokeAsync("S11", new object[0], this.S11OperationCompleted, userState);
        }
        
        private void OnS11OperationCompleted(object arg) {
            if ((this.S11Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.S11Completed(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void S12([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0) {
            this.Invoke("S12", new object[] {
                        arg0});
        }
        
        /// <remarks/>
        public void S12Async(string arg0) {
            this.S12Async(arg0, null);
        }
        
        /// <remarks/>
        public void S12Async(string arg0, object userState) {
            if ((this.S12OperationCompleted == null)) {
                this.S12OperationCompleted = new System.Threading.SendOrPostCallback(this.OnS12OperationCompleted);
            }
            this.InvokeAsync("S12", new object[] {
                        arg0}, this.S12OperationCompleted, userState);
        }
        
        private void OnS12OperationCompleted(object arg) {
            if ((this.S12Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.S12Completed(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void S1CompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void S2CompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void S3CompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void S4CompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void S5CompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void S6CompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void S7CompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void esUnNumeroCompletedEventHandler(object sender, esUnNumeroCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class esUnNumeroCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal esUnNumeroCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void leerEstadosYComentariosCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void S9CompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void S10CompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void S8CompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void S11CompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void S12CompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591