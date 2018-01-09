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

namespace WarlockSoft.JTarea {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="TareaPortBinding", Namespace="http://Servicios/")]
    public partial class Tarea : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback elegirParticipanteTareaOperationCompleted;
        
        private System.Threading.SendOrPostCallback obtenerMiembrosInscritosPorTareaOperationCompleted;
        
        private System.Threading.SendOrPostCallback agregarTareaOperationCompleted;
        
        private System.Threading.SendOrPostCallback obtenerTareasIndividualesOperationCompleted;
        
        private System.Threading.SendOrPostCallback cambiarEstadoOperationCompleted;
        
        private System.Threading.SendOrPostCallback obtenerMisTareasIndividualesOperationCompleted;
        
        private System.Threading.SendOrPostCallback agregarMiembrosPorTareaOperationCompleted;
        
        private System.Threading.SendOrPostCallback obtenerDatosTareaOperationCompleted;
        
        private System.Threading.SendOrPostCallback obtenerMiembrosParticipantesPorTareaOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Tarea() {
            this.Url = global::WarlockSoft.Properties.Settings.Default.WarlockSoft_JTarea_Tarea;
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
        public event elegirParticipanteTareaCompletedEventHandler elegirParticipanteTareaCompleted;
        
        /// <remarks/>
        public event obtenerMiembrosInscritosPorTareaCompletedEventHandler obtenerMiembrosInscritosPorTareaCompleted;
        
        /// <remarks/>
        public event agregarTareaCompletedEventHandler agregarTareaCompleted;
        
        /// <remarks/>
        public event obtenerTareasIndividualesCompletedEventHandler obtenerTareasIndividualesCompleted;
        
        /// <remarks/>
        public event cambiarEstadoCompletedEventHandler cambiarEstadoCompleted;
        
        /// <remarks/>
        public event obtenerMisTareasIndividualesCompletedEventHandler obtenerMisTareasIndividualesCompleted;
        
        /// <remarks/>
        public event agregarMiembrosPorTareaCompletedEventHandler agregarMiembrosPorTareaCompleted;
        
        /// <remarks/>
        public event obtenerDatosTareaCompletedEventHandler obtenerDatosTareaCompleted;
        
        /// <remarks/>
        public event obtenerMiembrosParticipantesPorTareaCompletedEventHandler obtenerMiembrosParticipantesPorTareaCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool elegirParticipanteTarea([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int id_usuario, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int id_tarea) {
            object[] results = this.Invoke("elegirParticipanteTarea", new object[] {
                        id_usuario,
                        id_tarea});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void elegirParticipanteTareaAsync(int id_usuario, int id_tarea) {
            this.elegirParticipanteTareaAsync(id_usuario, id_tarea, null);
        }
        
        /// <remarks/>
        public void elegirParticipanteTareaAsync(int id_usuario, int id_tarea, object userState) {
            if ((this.elegirParticipanteTareaOperationCompleted == null)) {
                this.elegirParticipanteTareaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnelegirParticipanteTareaOperationCompleted);
            }
            this.InvokeAsync("elegirParticipanteTarea", new object[] {
                        id_usuario,
                        id_tarea}, this.elegirParticipanteTareaOperationCompleted, userState);
        }
        
        private void OnelegirParticipanteTareaOperationCompleted(object arg) {
            if ((this.elegirParticipanteTareaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.elegirParticipanteTareaCompleted(this, new elegirParticipanteTareaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string[] obtenerMiembrosInscritosPorTarea([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int id_tarea) {
            object[] results = this.Invoke("obtenerMiembrosInscritosPorTarea", new object[] {
                        id_tarea});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void obtenerMiembrosInscritosPorTareaAsync(int id_tarea) {
            this.obtenerMiembrosInscritosPorTareaAsync(id_tarea, null);
        }
        
        /// <remarks/>
        public void obtenerMiembrosInscritosPorTareaAsync(int id_tarea, object userState) {
            if ((this.obtenerMiembrosInscritosPorTareaOperationCompleted == null)) {
                this.obtenerMiembrosInscritosPorTareaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnobtenerMiembrosInscritosPorTareaOperationCompleted);
            }
            this.InvokeAsync("obtenerMiembrosInscritosPorTarea", new object[] {
                        id_tarea}, this.obtenerMiembrosInscritosPorTareaOperationCompleted, userState);
        }
        
        private void OnobtenerMiembrosInscritosPorTareaOperationCompleted(object arg) {
            if ((this.obtenerMiembrosInscritosPorTareaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.obtenerMiembrosInscritosPorTareaCompleted(this, new obtenerMiembrosInscritosPorTareaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool agregarTarea([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string nombre, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string descripcion, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int diaIni, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int mesIni, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int anoIni, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int diaFin, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int mesFin, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int anoFin, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] double precio, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int cantidadParticipantes, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string estado, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int id_usuario, [System.Xml.Serialization.XmlElementAttribute("conocimientos", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string[] conocimientos) {
            object[] results = this.Invoke("agregarTarea", new object[] {
                        nombre,
                        descripcion,
                        diaIni,
                        mesIni,
                        anoIni,
                        diaFin,
                        mesFin,
                        anoFin,
                        precio,
                        cantidadParticipantes,
                        estado,
                        id_usuario,
                        conocimientos});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void agregarTareaAsync(string nombre, string descripcion, int diaIni, int mesIni, int anoIni, int diaFin, int mesFin, int anoFin, double precio, int cantidadParticipantes, string estado, int id_usuario, string[] conocimientos) {
            this.agregarTareaAsync(nombre, descripcion, diaIni, mesIni, anoIni, diaFin, mesFin, anoFin, precio, cantidadParticipantes, estado, id_usuario, conocimientos, null);
        }
        
        /// <remarks/>
        public void agregarTareaAsync(string nombre, string descripcion, int diaIni, int mesIni, int anoIni, int diaFin, int mesFin, int anoFin, double precio, int cantidadParticipantes, string estado, int id_usuario, string[] conocimientos, object userState) {
            if ((this.agregarTareaOperationCompleted == null)) {
                this.agregarTareaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnagregarTareaOperationCompleted);
            }
            this.InvokeAsync("agregarTarea", new object[] {
                        nombre,
                        descripcion,
                        diaIni,
                        mesIni,
                        anoIni,
                        diaFin,
                        mesFin,
                        anoFin,
                        precio,
                        cantidadParticipantes,
                        estado,
                        id_usuario,
                        conocimientos}, this.agregarTareaOperationCompleted, userState);
        }
        
        private void OnagregarTareaOperationCompleted(object arg) {
            if ((this.agregarTareaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.agregarTareaCompleted(this, new agregarTareaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string[] obtenerTareasIndividuales() {
            object[] results = this.Invoke("obtenerTareasIndividuales", new object[0]);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void obtenerTareasIndividualesAsync() {
            this.obtenerTareasIndividualesAsync(null);
        }
        
        /// <remarks/>
        public void obtenerTareasIndividualesAsync(object userState) {
            if ((this.obtenerTareasIndividualesOperationCompleted == null)) {
                this.obtenerTareasIndividualesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnobtenerTareasIndividualesOperationCompleted);
            }
            this.InvokeAsync("obtenerTareasIndividuales", new object[0], this.obtenerTareasIndividualesOperationCompleted, userState);
        }
        
        private void OnobtenerTareasIndividualesOperationCompleted(object arg) {
            if ((this.obtenerTareasIndividualesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.obtenerTareasIndividualesCompleted(this, new obtenerTareasIndividualesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool cambiarEstado([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int id_tarea, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string estado) {
            object[] results = this.Invoke("cambiarEstado", new object[] {
                        id_tarea,
                        estado});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void cambiarEstadoAsync(int id_tarea, string estado) {
            this.cambiarEstadoAsync(id_tarea, estado, null);
        }
        
        /// <remarks/>
        public void cambiarEstadoAsync(int id_tarea, string estado, object userState) {
            if ((this.cambiarEstadoOperationCompleted == null)) {
                this.cambiarEstadoOperationCompleted = new System.Threading.SendOrPostCallback(this.OncambiarEstadoOperationCompleted);
            }
            this.InvokeAsync("cambiarEstado", new object[] {
                        id_tarea,
                        estado}, this.cambiarEstadoOperationCompleted, userState);
        }
        
        private void OncambiarEstadoOperationCompleted(object arg) {
            if ((this.cambiarEstadoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.cambiarEstadoCompleted(this, new cambiarEstadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string[] obtenerMisTareasIndividuales([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int id_usuario) {
            object[] results = this.Invoke("obtenerMisTareasIndividuales", new object[] {
                        id_usuario});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void obtenerMisTareasIndividualesAsync(int id_usuario) {
            this.obtenerMisTareasIndividualesAsync(id_usuario, null);
        }
        
        /// <remarks/>
        public void obtenerMisTareasIndividualesAsync(int id_usuario, object userState) {
            if ((this.obtenerMisTareasIndividualesOperationCompleted == null)) {
                this.obtenerMisTareasIndividualesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnobtenerMisTareasIndividualesOperationCompleted);
            }
            this.InvokeAsync("obtenerMisTareasIndividuales", new object[] {
                        id_usuario}, this.obtenerMisTareasIndividualesOperationCompleted, userState);
        }
        
        private void OnobtenerMisTareasIndividualesOperationCompleted(object arg) {
            if ((this.obtenerMisTareasIndividualesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.obtenerMisTareasIndividualesCompleted(this, new obtenerMisTareasIndividualesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool agregarMiembrosPorTarea([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int id_tarea, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int id_usuario) {
            object[] results = this.Invoke("agregarMiembrosPorTarea", new object[] {
                        id_tarea,
                        id_usuario});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void agregarMiembrosPorTareaAsync(int id_tarea, int id_usuario) {
            this.agregarMiembrosPorTareaAsync(id_tarea, id_usuario, null);
        }
        
        /// <remarks/>
        public void agregarMiembrosPorTareaAsync(int id_tarea, int id_usuario, object userState) {
            if ((this.agregarMiembrosPorTareaOperationCompleted == null)) {
                this.agregarMiembrosPorTareaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnagregarMiembrosPorTareaOperationCompleted);
            }
            this.InvokeAsync("agregarMiembrosPorTarea", new object[] {
                        id_tarea,
                        id_usuario}, this.agregarMiembrosPorTareaOperationCompleted, userState);
        }
        
        private void OnagregarMiembrosPorTareaOperationCompleted(object arg) {
            if ((this.agregarMiembrosPorTareaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.agregarMiembrosPorTareaCompleted(this, new agregarMiembrosPorTareaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string[] obtenerDatosTarea([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int id_tarea) {
            object[] results = this.Invoke("obtenerDatosTarea", new object[] {
                        id_tarea});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void obtenerDatosTareaAsync(int id_tarea) {
            this.obtenerDatosTareaAsync(id_tarea, null);
        }
        
        /// <remarks/>
        public void obtenerDatosTareaAsync(int id_tarea, object userState) {
            if ((this.obtenerDatosTareaOperationCompleted == null)) {
                this.obtenerDatosTareaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnobtenerDatosTareaOperationCompleted);
            }
            this.InvokeAsync("obtenerDatosTarea", new object[] {
                        id_tarea}, this.obtenerDatosTareaOperationCompleted, userState);
        }
        
        private void OnobtenerDatosTareaOperationCompleted(object arg) {
            if ((this.obtenerDatosTareaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.obtenerDatosTareaCompleted(this, new obtenerDatosTareaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicios/", ResponseNamespace="http://Servicios/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string[] obtenerMiembrosParticipantesPorTarea([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int id_tarea) {
            object[] results = this.Invoke("obtenerMiembrosParticipantesPorTarea", new object[] {
                        id_tarea});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void obtenerMiembrosParticipantesPorTareaAsync(int id_tarea) {
            this.obtenerMiembrosParticipantesPorTareaAsync(id_tarea, null);
        }
        
        /// <remarks/>
        public void obtenerMiembrosParticipantesPorTareaAsync(int id_tarea, object userState) {
            if ((this.obtenerMiembrosParticipantesPorTareaOperationCompleted == null)) {
                this.obtenerMiembrosParticipantesPorTareaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnobtenerMiembrosParticipantesPorTareaOperationCompleted);
            }
            this.InvokeAsync("obtenerMiembrosParticipantesPorTarea", new object[] {
                        id_tarea}, this.obtenerMiembrosParticipantesPorTareaOperationCompleted, userState);
        }
        
        private void OnobtenerMiembrosParticipantesPorTareaOperationCompleted(object arg) {
            if ((this.obtenerMiembrosParticipantesPorTareaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.obtenerMiembrosParticipantesPorTareaCompleted(this, new obtenerMiembrosParticipantesPorTareaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void elegirParticipanteTareaCompletedEventHandler(object sender, elegirParticipanteTareaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class elegirParticipanteTareaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal elegirParticipanteTareaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void obtenerMiembrosInscritosPorTareaCompletedEventHandler(object sender, obtenerMiembrosInscritosPorTareaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class obtenerMiembrosInscritosPorTareaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal obtenerMiembrosInscritosPorTareaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void agregarTareaCompletedEventHandler(object sender, agregarTareaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class agregarTareaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal agregarTareaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void obtenerTareasIndividualesCompletedEventHandler(object sender, obtenerTareasIndividualesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class obtenerTareasIndividualesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal obtenerTareasIndividualesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void cambiarEstadoCompletedEventHandler(object sender, cambiarEstadoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class cambiarEstadoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal cambiarEstadoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void obtenerMisTareasIndividualesCompletedEventHandler(object sender, obtenerMisTareasIndividualesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class obtenerMisTareasIndividualesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal obtenerMisTareasIndividualesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void agregarMiembrosPorTareaCompletedEventHandler(object sender, agregarMiembrosPorTareaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class agregarMiembrosPorTareaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal agregarMiembrosPorTareaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void obtenerDatosTareaCompletedEventHandler(object sender, obtenerDatosTareaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class obtenerDatosTareaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal obtenerDatosTareaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void obtenerMiembrosParticipantesPorTareaCompletedEventHandler(object sender, obtenerMiembrosParticipantesPorTareaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class obtenerMiembrosParticipantesPorTareaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal obtenerMiembrosParticipantesPorTareaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591