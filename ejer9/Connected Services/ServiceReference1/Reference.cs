﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ejer9.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ejer9.ServiceReference1.HelloWorldResponse HelloWorld(ejer9.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ejer9.ServiceReference1.HelloWorldResponse> HelloWorldAsync(ejer9.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ModificarPersona", ReplyAction="*")]
        ejer9.ServiceReference1.ModificarPersonaResponse ModificarPersona(ejer9.ServiceReference1.ModificarPersonaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ModificarPersona", ReplyAction="*")]
        System.Threading.Tasks.Task<ejer9.ServiceReference1.ModificarPersonaResponse> ModificarPersonaAsync(ejer9.ServiceReference1.ModificarPersonaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarPersona", ReplyAction="*")]
        ejer9.ServiceReference1.AgregarPersonaResponse AgregarPersona(ejer9.ServiceReference1.AgregarPersonaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarPersona", ReplyAction="*")]
        System.Threading.Tasks.Task<ejer9.ServiceReference1.AgregarPersonaResponse> AgregarPersonaAsync(ejer9.ServiceReference1.AgregarPersonaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarPersona", ReplyAction="*")]
        int EliminarPersona(int id_persona);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarPersona", ReplyAction="*")]
        System.Threading.Tasks.Task<int> EliminarPersonaAsync(int id_persona);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ejer9.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ejer9.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ejer9.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ejer9.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificarPersonaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ModificarPersona", Namespace="http://tempuri.org/", Order=0)]
        public ejer9.ServiceReference1.ModificarPersonaRequestBody Body;
        
        public ModificarPersonaRequest() {
        }
        
        public ModificarPersonaRequest(ejer9.ServiceReference1.ModificarPersonaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificarPersonaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id_persona;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string apellido;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int edad;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string rol;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string direccion;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string departamento;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string contraseña;
        
        public ModificarPersonaRequestBody() {
        }
        
        public ModificarPersonaRequestBody(int id_persona, string nombre, string apellido, int edad, string rol, string direccion, string departamento, string contraseña) {
            this.id_persona = id_persona;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.rol = rol;
            this.direccion = direccion;
            this.departamento = departamento;
            this.contraseña = contraseña;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificarPersonaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ModificarPersonaResponse", Namespace="http://tempuri.org/", Order=0)]
        public ejer9.ServiceReference1.ModificarPersonaResponseBody Body;
        
        public ModificarPersonaResponse() {
        }
        
        public ModificarPersonaResponse(ejer9.ServiceReference1.ModificarPersonaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificarPersonaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int ModificarPersonaResult;
        
        public ModificarPersonaResponseBody() {
        }
        
        public ModificarPersonaResponseBody(int ModificarPersonaResult) {
            this.ModificarPersonaResult = ModificarPersonaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarPersonaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarPersona", Namespace="http://tempuri.org/", Order=0)]
        public ejer9.ServiceReference1.AgregarPersonaRequestBody Body;
        
        public AgregarPersonaRequest() {
        }
        
        public AgregarPersonaRequest(ejer9.ServiceReference1.AgregarPersonaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarPersonaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string apellido;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int edad;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string rol;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string direccion;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string departamento;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string contraseña;
        
        public AgregarPersonaRequestBody() {
        }
        
        public AgregarPersonaRequestBody(string nombre, string apellido, int edad, string rol, string direccion, string departamento, string contraseña) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.rol = rol;
            this.direccion = direccion;
            this.departamento = departamento;
            this.contraseña = contraseña;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarPersonaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarPersonaResponse", Namespace="http://tempuri.org/", Order=0)]
        public ejer9.ServiceReference1.AgregarPersonaResponseBody Body;
        
        public AgregarPersonaResponse() {
        }
        
        public AgregarPersonaResponse(ejer9.ServiceReference1.AgregarPersonaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarPersonaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int AgregarPersonaResult;
        
        public AgregarPersonaResponseBody() {
        }
        
        public AgregarPersonaResponseBody(int AgregarPersonaResult) {
            this.AgregarPersonaResult = AgregarPersonaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : ejer9.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<ejer9.ServiceReference1.WebService1Soap>, ejer9.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ejer9.ServiceReference1.HelloWorldResponse ejer9.ServiceReference1.WebService1Soap.HelloWorld(ejer9.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ejer9.ServiceReference1.HelloWorldRequest inValue = new ejer9.ServiceReference1.HelloWorldRequest();
            inValue.Body = new ejer9.ServiceReference1.HelloWorldRequestBody();
            ejer9.ServiceReference1.HelloWorldResponse retVal = ((ejer9.ServiceReference1.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ejer9.ServiceReference1.HelloWorldResponse> ejer9.ServiceReference1.WebService1Soap.HelloWorldAsync(ejer9.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ejer9.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            ejer9.ServiceReference1.HelloWorldRequest inValue = new ejer9.ServiceReference1.HelloWorldRequest();
            inValue.Body = new ejer9.ServiceReference1.HelloWorldRequestBody();
            return ((ejer9.ServiceReference1.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ejer9.ServiceReference1.ModificarPersonaResponse ejer9.ServiceReference1.WebService1Soap.ModificarPersona(ejer9.ServiceReference1.ModificarPersonaRequest request) {
            return base.Channel.ModificarPersona(request);
        }
        
        public int ModificarPersona(int id_persona, string nombre, string apellido, int edad, string rol, string direccion, string departamento, string contraseña) {
            ejer9.ServiceReference1.ModificarPersonaRequest inValue = new ejer9.ServiceReference1.ModificarPersonaRequest();
            inValue.Body = new ejer9.ServiceReference1.ModificarPersonaRequestBody();
            inValue.Body.id_persona = id_persona;
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.edad = edad;
            inValue.Body.rol = rol;
            inValue.Body.direccion = direccion;
            inValue.Body.departamento = departamento;
            inValue.Body.contraseña = contraseña;
            ejer9.ServiceReference1.ModificarPersonaResponse retVal = ((ejer9.ServiceReference1.WebService1Soap)(this)).ModificarPersona(inValue);
            return retVal.Body.ModificarPersonaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ejer9.ServiceReference1.ModificarPersonaResponse> ejer9.ServiceReference1.WebService1Soap.ModificarPersonaAsync(ejer9.ServiceReference1.ModificarPersonaRequest request) {
            return base.Channel.ModificarPersonaAsync(request);
        }
        
        public System.Threading.Tasks.Task<ejer9.ServiceReference1.ModificarPersonaResponse> ModificarPersonaAsync(int id_persona, string nombre, string apellido, int edad, string rol, string direccion, string departamento, string contraseña) {
            ejer9.ServiceReference1.ModificarPersonaRequest inValue = new ejer9.ServiceReference1.ModificarPersonaRequest();
            inValue.Body = new ejer9.ServiceReference1.ModificarPersonaRequestBody();
            inValue.Body.id_persona = id_persona;
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.edad = edad;
            inValue.Body.rol = rol;
            inValue.Body.direccion = direccion;
            inValue.Body.departamento = departamento;
            inValue.Body.contraseña = contraseña;
            return ((ejer9.ServiceReference1.WebService1Soap)(this)).ModificarPersonaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ejer9.ServiceReference1.AgregarPersonaResponse ejer9.ServiceReference1.WebService1Soap.AgregarPersona(ejer9.ServiceReference1.AgregarPersonaRequest request) {
            return base.Channel.AgregarPersona(request);
        }
        
        public int AgregarPersona(string nombre, string apellido, int edad, string rol, string direccion, string departamento, string contraseña) {
            ejer9.ServiceReference1.AgregarPersonaRequest inValue = new ejer9.ServiceReference1.AgregarPersonaRequest();
            inValue.Body = new ejer9.ServiceReference1.AgregarPersonaRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.edad = edad;
            inValue.Body.rol = rol;
            inValue.Body.direccion = direccion;
            inValue.Body.departamento = departamento;
            inValue.Body.contraseña = contraseña;
            ejer9.ServiceReference1.AgregarPersonaResponse retVal = ((ejer9.ServiceReference1.WebService1Soap)(this)).AgregarPersona(inValue);
            return retVal.Body.AgregarPersonaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ejer9.ServiceReference1.AgregarPersonaResponse> ejer9.ServiceReference1.WebService1Soap.AgregarPersonaAsync(ejer9.ServiceReference1.AgregarPersonaRequest request) {
            return base.Channel.AgregarPersonaAsync(request);
        }
        
        public System.Threading.Tasks.Task<ejer9.ServiceReference1.AgregarPersonaResponse> AgregarPersonaAsync(string nombre, string apellido, int edad, string rol, string direccion, string departamento, string contraseña) {
            ejer9.ServiceReference1.AgregarPersonaRequest inValue = new ejer9.ServiceReference1.AgregarPersonaRequest();
            inValue.Body = new ejer9.ServiceReference1.AgregarPersonaRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.edad = edad;
            inValue.Body.rol = rol;
            inValue.Body.direccion = direccion;
            inValue.Body.departamento = departamento;
            inValue.Body.contraseña = contraseña;
            return ((ejer9.ServiceReference1.WebService1Soap)(this)).AgregarPersonaAsync(inValue);
        }
        
        public int EliminarPersona(int id_persona) {
            return base.Channel.EliminarPersona(id_persona);
        }
        
        public System.Threading.Tasks.Task<int> EliminarPersonaAsync(int id_persona) {
            return base.Channel.EliminarPersonaAsync(id_persona);
        }
    }
}
