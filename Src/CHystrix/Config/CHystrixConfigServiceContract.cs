﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1026
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CHystrix.Config
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Runtime.Serialization;
    using System.Collections.Generic;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://soa.ctrip.com/framework/chystrix/configservice/v1")]
    [System.Xml.Serialization.XmlRootAttribute("GetApplicationConfigRequest", Namespace = "http://soa.ctrip.com/framework/chystrix/configservice/v1", IsNullable = false)]
    [DataContract(Name = "GetApplicationConfigRequest", Namespace = "http://soa.ctrip.com/framework/chystrix/configservice/v1")]
    internal partial class GetApplicationConfigRequestType
    {

        private string appNameField;

        [DataMember()]
        public string AppName
        {
            get
            {
                return this.appNameField;
            }
            set
            {
                this.appNameField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://soa.ctrip.com/framework/chystrix/configservice/v1")]
    [System.Xml.Serialization.XmlRootAttribute("GetApplicationConfigResponse", Namespace = "http://soa.ctrip.com/framework/chystrix/configservice/v1", IsNullable = false)]
    [DataContract(Name = "GetApplicationConfigResponse", Namespace = "http://soa.ctrip.com/framework/chystrix/configservice/v1")]
    internal partial class GetApplicationConfigResponseType
    {

        private CHystrixApplication applicationField;

        private CHystrixCommandDefaultConfig defaultConfigField;

        [DataMember()]
        public CHystrixApplication Application
        {
            get
            {
                return this.applicationField;
            }
            set
            {
                this.applicationField = value;
            }
        }

        [DataMember()]
        public CHystrixCommandDefaultConfig DefaultConfig
        {
            get
            {
                return this.defaultConfigField;
            }
            set
            {
                this.defaultConfigField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://soa.ctrip.com/framework/chystrix/configservice/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://soa.ctrip.com/framework/chystrix/configservice/v1", IsNullable = true)]
    [DataContract(Namespace = "http://soa.ctrip.com/framework/chystrix/configservice/v1")]
    internal partial class CHystrixApplication
    {

        private string appNameField;

        private List<CHystrixCommand> commandsField;

        [DataMember()]
        public string AppName
        {
            get
            {
                return this.appNameField;
            }
            set
            {
                this.appNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Commands")]
        [DataMember()]
        public List<CHystrixCommand> Commands
        {
            get
            {
                if ((this.commandsField == null))
                {
                    this.commandsField = new List<CHystrixCommand>();
                }
                return this.commandsField;
            }
            set
            {
                this.commandsField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://soa.ctrip.com/framework/chystrix/configservice/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://soa.ctrip.com/framework/chystrix/configservice/v1", IsNullable = true)]
    [DataContract(Namespace = "http://soa.ctrip.com/framework/chystrix/configservice/v1")]
    internal partial class CHystrixCommandDefaultConfig
    {

        private System.Nullable<int> circuitBreakerRequestCountThresholdField;

        private System.Nullable<int> circuitBreakerErrorThresholdPercentageField;

        private System.Nullable<bool> circuitBreakerForceClosedField;

        private System.Nullable<int> commandTimeoutInMillisecondsField;

        private System.Nullable<int> commandMaxConcurrentCountField;

        private System.Nullable<int> fallbackMaxConcurrentCountField;

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        [DataMember()]
        public System.Nullable<int> CircuitBreakerRequestCountThreshold
        {
            get
            {
                return this.circuitBreakerRequestCountThresholdField;
            }
            set
            {
                this.circuitBreakerRequestCountThresholdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        [DataMember()]
        public System.Nullable<int> CircuitBreakerErrorThresholdPercentage
        {
            get
            {
                return this.circuitBreakerErrorThresholdPercentageField;
            }
            set
            {
                this.circuitBreakerErrorThresholdPercentageField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        [DataMember()]
        public System.Nullable<bool> CircuitBreakerForceClosed
        {
            get
            {
                return this.circuitBreakerForceClosedField;
            }
            set
            {
                this.circuitBreakerForceClosedField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        [DataMember()]
        public System.Nullable<int> CommandTimeoutInMilliseconds
        {
            get
            {
                return this.commandTimeoutInMillisecondsField;
            }
            set
            {
                this.commandTimeoutInMillisecondsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        [DataMember()]
        public System.Nullable<int> CommandMaxConcurrentCount
        {
            get
            {
                return this.commandMaxConcurrentCountField;
            }
            set
            {
                this.commandMaxConcurrentCountField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        [DataMember()]
        public System.Nullable<int> FallbackMaxConcurrentCount
        {
            get
            {
                return this.fallbackMaxConcurrentCountField;
            }
            set
            {
                this.fallbackMaxConcurrentCountField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://soa.ctrip.com/framework/chystrix/configservice/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://soa.ctrip.com/framework/chystrix/configservice/v1", IsNullable = true)]
    [DataContract(Namespace = "http://soa.ctrip.com/framework/chystrix/configservice/v1")]
    internal partial class CHystrixCommand
    {

        private string keyField;

        private CHystrixCommandConfig configField;

        [DataMember()]
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        [DataMember()]
        public CHystrixCommandConfig Config
        {
            get
            {
                return this.configField;
            }
            set
            {
                this.configField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://soa.ctrip.com/framework/chystrix/configservice/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://soa.ctrip.com/framework/chystrix/configservice/v1", IsNullable = true)]
    [DataContract(Namespace = "http://soa.ctrip.com/framework/chystrix/configservice/v1")]
    internal partial class CHystrixCommandConfig
    {

        private System.Nullable<int> circuitBreakerRequestCountThresholdField;

        private System.Nullable<int> circuitBreakerErrorThresholdPercentageField;

        private System.Nullable<bool> circuitBreakerForceOpenField;

        private System.Nullable<bool> circuitBreakerForceClosedField;

        private System.Nullable<int> commandTimeoutInMillisecondsField;

        private System.Nullable<int> commandMaxConcurrentCountField;

        private System.Nullable<int> fallbackMaxConcurrentCountField;

        private System.Nullable<int> maxAsyncCommandExceedPercentageField;

        private System.Nullable<bool> degradeLogLevelField;

        private System.Nullable<bool> logExecutionErrorField;

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        [DataMember()]
        public System.Nullable<int> CircuitBreakerRequestCountThreshold
        {
            get
            {
                return this.circuitBreakerRequestCountThresholdField;
            }
            set
            {
                this.circuitBreakerRequestCountThresholdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        [DataMember()]
        public System.Nullable<int> CircuitBreakerErrorThresholdPercentage
        {
            get
            {
                return this.circuitBreakerErrorThresholdPercentageField;
            }
            set
            {
                this.circuitBreakerErrorThresholdPercentageField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        [DataMember()]
        public System.Nullable<bool> CircuitBreakerForceOpen
        {
            get
            {
                return this.circuitBreakerForceOpenField;
            }
            set
            {
                this.circuitBreakerForceOpenField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        [DataMember()]
        public System.Nullable<bool> CircuitBreakerForceClosed
        {
            get
            {
                return this.circuitBreakerForceClosedField;
            }
            set
            {
                this.circuitBreakerForceClosedField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        [DataMember()]
        public System.Nullable<int> CommandTimeoutInMilliseconds
        {
            get
            {
                return this.commandTimeoutInMillisecondsField;
            }
            set
            {
                this.commandTimeoutInMillisecondsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        [DataMember()]
        public System.Nullable<int> CommandMaxConcurrentCount
        {
            get
            {
                return this.commandMaxConcurrentCountField;
            }
            set
            {
                this.commandMaxConcurrentCountField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        [DataMember()]
        public System.Nullable<int> FallbackMaxConcurrentCount
        {
            get
            {
                return this.fallbackMaxConcurrentCountField;
            }
            set
            {
                this.fallbackMaxConcurrentCountField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        [DataMember()]
        public System.Nullable<int> MaxAsyncCommandExceedPercentage
        {
            get
            {
                return this.maxAsyncCommandExceedPercentageField;
            }
            set
            {
                this.maxAsyncCommandExceedPercentageField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        [DataMember()]
        public System.Nullable<bool> DegradeLogLevel
        {
            get
            {
                return this.degradeLogLevelField;
            }
            set
            {
                this.degradeLogLevelField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        [DataMember()]
        public System.Nullable<bool> LogExecutionError
        {
            get
            {
                return this.logExecutionErrorField;
            }
            set
            {
                this.logExecutionErrorField = value;
            }
        }
    }
}