// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_credentials.steamclient.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CCredentials_GetSteamGuardDetails_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string webcookie
        {
            get => __pbn__webcookie ?? "";
            set => __pbn__webcookie = value;
        }
        public bool ShouldSerializewebcookie() => __pbn__webcookie != null;
        public void Resetwebcookie() => __pbn__webcookie = null;
        private string __pbn__webcookie;

        [global::ProtoBuf.ProtoMember(3, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint timestamp_minimum_wanted
        {
            get => __pbn__timestamp_minimum_wanted.GetValueOrDefault();
            set => __pbn__timestamp_minimum_wanted = value;
        }
        public bool ShouldSerializetimestamp_minimum_wanted() => __pbn__timestamp_minimum_wanted != null;
        public void Resettimestamp_minimum_wanted() => __pbn__timestamp_minimum_wanted = null;
        private uint? __pbn__timestamp_minimum_wanted;

        [global::ProtoBuf.ProtoMember(4)]
        public int deprecated_ipaddress
        {
            get => __pbn__deprecated_ipaddress.GetValueOrDefault();
            set => __pbn__deprecated_ipaddress = value;
        }
        public bool ShouldSerializedeprecated_ipaddress() => __pbn__deprecated_ipaddress != null;
        public void Resetdeprecated_ipaddress() => __pbn__deprecated_ipaddress = null;
        private int? __pbn__deprecated_ipaddress;

        [global::ProtoBuf.ProtoMember(5)]
        public CMsgIPAddress ip_address { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCredentials_GetSteamGuardDetails_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool is_steamguard_enabled
        {
            get => __pbn__is_steamguard_enabled.GetValueOrDefault();
            set => __pbn__is_steamguard_enabled = value;
        }
        public bool ShouldSerializeis_steamguard_enabled() => __pbn__is_steamguard_enabled != null;
        public void Resetis_steamguard_enabled() => __pbn__is_steamguard_enabled = null;
        private bool? __pbn__is_steamguard_enabled;

        [global::ProtoBuf.ProtoMember(2, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint timestamp_steamguard_enabled
        {
            get => __pbn__timestamp_steamguard_enabled.GetValueOrDefault();
            set => __pbn__timestamp_steamguard_enabled = value;
        }
        public bool ShouldSerializetimestamp_steamguard_enabled() => __pbn__timestamp_steamguard_enabled != null;
        public void Resettimestamp_steamguard_enabled() => __pbn__timestamp_steamguard_enabled = null;
        private uint? __pbn__timestamp_steamguard_enabled;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string deprecated_machine_name_userchosen
        {
            get => __pbn__deprecated_machine_name_userchosen ?? "";
            set => __pbn__deprecated_machine_name_userchosen = value;
        }
        public bool ShouldSerializedeprecated_machine_name_userchosen() => __pbn__deprecated_machine_name_userchosen != null;
        public void Resetdeprecated_machine_name_userchosen() => __pbn__deprecated_machine_name_userchosen = null;
        private string __pbn__deprecated_machine_name_userchosen;

        [global::ProtoBuf.ProtoMember(5, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint deprecated_timestamp_machine_steamguard_enabled
        {
            get => __pbn__deprecated_timestamp_machine_steamguard_enabled.GetValueOrDefault();
            set => __pbn__deprecated_timestamp_machine_steamguard_enabled = value;
        }
        public bool ShouldSerializedeprecated_timestamp_machine_steamguard_enabled() => __pbn__deprecated_timestamp_machine_steamguard_enabled != null;
        public void Resetdeprecated_timestamp_machine_steamguard_enabled() => __pbn__deprecated_timestamp_machine_steamguard_enabled = null;
        private uint? __pbn__deprecated_timestamp_machine_steamguard_enabled;

        [global::ProtoBuf.ProtoMember(6)]
        public bool deprecated_authentication_exists_from_geoloc_before_mintime
        {
            get => __pbn__deprecated_authentication_exists_from_geoloc_before_mintime.GetValueOrDefault();
            set => __pbn__deprecated_authentication_exists_from_geoloc_before_mintime = value;
        }
        public bool ShouldSerializedeprecated_authentication_exists_from_geoloc_before_mintime() => __pbn__deprecated_authentication_exists_from_geoloc_before_mintime != null;
        public void Resetdeprecated_authentication_exists_from_geoloc_before_mintime() => __pbn__deprecated_authentication_exists_from_geoloc_before_mintime = null;
        private bool? __pbn__deprecated_authentication_exists_from_geoloc_before_mintime;

        [global::ProtoBuf.ProtoMember(7)]
        public ulong deprecated_machine_id
        {
            get => __pbn__deprecated_machine_id.GetValueOrDefault();
            set => __pbn__deprecated_machine_id = value;
        }
        public bool ShouldSerializedeprecated_machine_id() => __pbn__deprecated_machine_id != null;
        public void Resetdeprecated_machine_id() => __pbn__deprecated_machine_id = null;
        private ulong? __pbn__deprecated_machine_id;

        [global::ProtoBuf.ProtoMember(8)]
        public global::System.Collections.Generic.List<SessionData> session_data { get; } = new global::System.Collections.Generic.List<SessionData>();

        [global::ProtoBuf.ProtoMember(9)]
        public bool is_twofactor_enabled
        {
            get => __pbn__is_twofactor_enabled.GetValueOrDefault();
            set => __pbn__is_twofactor_enabled = value;
        }
        public bool ShouldSerializeis_twofactor_enabled() => __pbn__is_twofactor_enabled != null;
        public void Resetis_twofactor_enabled() => __pbn__is_twofactor_enabled = null;
        private bool? __pbn__is_twofactor_enabled;

        [global::ProtoBuf.ProtoMember(10, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint timestamp_twofactor_enabled
        {
            get => __pbn__timestamp_twofactor_enabled.GetValueOrDefault();
            set => __pbn__timestamp_twofactor_enabled = value;
        }
        public bool ShouldSerializetimestamp_twofactor_enabled() => __pbn__timestamp_twofactor_enabled != null;
        public void Resettimestamp_twofactor_enabled() => __pbn__timestamp_twofactor_enabled = null;
        private uint? __pbn__timestamp_twofactor_enabled;

        [global::ProtoBuf.ProtoMember(11)]
        public bool is_phone_verified
        {
            get => __pbn__is_phone_verified.GetValueOrDefault();
            set => __pbn__is_phone_verified = value;
        }
        public bool ShouldSerializeis_phone_verified() => __pbn__is_phone_verified != null;
        public void Resetis_phone_verified() => __pbn__is_phone_verified = null;
        private bool? __pbn__is_phone_verified;

        [global::ProtoBuf.ProtoContract()]
        public partial class SessionData : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public ulong machine_id
            {
                get => __pbn__machine_id.GetValueOrDefault();
                set => __pbn__machine_id = value;
            }
            public bool ShouldSerializemachine_id() => __pbn__machine_id != null;
            public void Resetmachine_id() => __pbn__machine_id = null;
            private ulong? __pbn__machine_id;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue("")]
            public string machine_name_userchosen
            {
                get => __pbn__machine_name_userchosen ?? "";
                set => __pbn__machine_name_userchosen = value;
            }
            public bool ShouldSerializemachine_name_userchosen() => __pbn__machine_name_userchosen != null;
            public void Resetmachine_name_userchosen() => __pbn__machine_name_userchosen = null;
            private string __pbn__machine_name_userchosen;

            [global::ProtoBuf.ProtoMember(3, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
            public uint timestamp_machine_steamguard_enabled
            {
                get => __pbn__timestamp_machine_steamguard_enabled.GetValueOrDefault();
                set => __pbn__timestamp_machine_steamguard_enabled = value;
            }
            public bool ShouldSerializetimestamp_machine_steamguard_enabled() => __pbn__timestamp_machine_steamguard_enabled != null;
            public void Resettimestamp_machine_steamguard_enabled() => __pbn__timestamp_machine_steamguard_enabled = null;
            private uint? __pbn__timestamp_machine_steamguard_enabled;

            [global::ProtoBuf.ProtoMember(4)]
            public bool authentication_exists_from_geoloc_before_mintime
            {
                get => __pbn__authentication_exists_from_geoloc_before_mintime.GetValueOrDefault();
                set => __pbn__authentication_exists_from_geoloc_before_mintime = value;
            }
            public bool ShouldSerializeauthentication_exists_from_geoloc_before_mintime() => __pbn__authentication_exists_from_geoloc_before_mintime != null;
            public void Resetauthentication_exists_from_geoloc_before_mintime() => __pbn__authentication_exists_from_geoloc_before_mintime = null;
            private bool? __pbn__authentication_exists_from_geoloc_before_mintime;

            [global::ProtoBuf.ProtoMember(6)]
            public bool authentication_exists_from_same_ip_before_mintime
            {
                get => __pbn__authentication_exists_from_same_ip_before_mintime.GetValueOrDefault();
                set => __pbn__authentication_exists_from_same_ip_before_mintime = value;
            }
            public bool ShouldSerializeauthentication_exists_from_same_ip_before_mintime() => __pbn__authentication_exists_from_same_ip_before_mintime != null;
            public void Resetauthentication_exists_from_same_ip_before_mintime() => __pbn__authentication_exists_from_same_ip_before_mintime = null;
            private bool? __pbn__authentication_exists_from_same_ip_before_mintime;

            [global::ProtoBuf.ProtoMember(7)]
            public uint public_ipv4
            {
                get => __pbn__public_ipv4.GetValueOrDefault();
                set => __pbn__public_ipv4 = value;
            }
            public bool ShouldSerializepublic_ipv4() => __pbn__public_ipv4 != null;
            public void Resetpublic_ipv4() => __pbn__public_ipv4 = null;
            private uint? __pbn__public_ipv4;

            [global::ProtoBuf.ProtoMember(8)]
            [global::System.ComponentModel.DefaultValue("")]
            public string public_ip_address
            {
                get => __pbn__public_ip_address ?? "";
                set => __pbn__public_ip_address = value;
            }
            public bool ShouldSerializepublic_ip_address() => __pbn__public_ip_address != null;
            public void Resetpublic_ip_address() => __pbn__public_ip_address = null;
            private string __pbn__public_ip_address;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCredentials_ValidateEmailAddress_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string stoken
        {
            get => __pbn__stoken ?? "";
            set => __pbn__stoken = value;
        }
        public bool ShouldSerializestoken() => __pbn__stoken != null;
        public void Resetstoken() => __pbn__stoken = null;
        private string __pbn__stoken;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCredentials_ValidateEmailAddress_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool was_validated
        {
            get => __pbn__was_validated.GetValueOrDefault();
            set => __pbn__was_validated = value;
        }
        public bool ShouldSerializewas_validated() => __pbn__was_validated != null;
        public void Resetwas_validated() => __pbn__was_validated = null;
        private bool? __pbn__was_validated;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCredentials_SteamGuardPhishingReport_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string param_string
        {
            get => __pbn__param_string ?? "";
            set => __pbn__param_string = value;
        }
        public bool ShouldSerializeparam_string() => __pbn__param_string != null;
        public void Resetparam_string() => __pbn__param_string = null;
        private string __pbn__param_string;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ipaddress_actual
        {
            get => __pbn__ipaddress_actual ?? "";
            set => __pbn__ipaddress_actual = value;
        }
        public bool ShouldSerializeipaddress_actual() => __pbn__ipaddress_actual != null;
        public void Resetipaddress_actual() => __pbn__ipaddress_actual = null;
        private string __pbn__ipaddress_actual;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCredentials_SteamGuardPhishingReport_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ipaddress_loginattempt
        {
            get => __pbn__ipaddress_loginattempt ?? "";
            set => __pbn__ipaddress_loginattempt = value;
        }
        public bool ShouldSerializeipaddress_loginattempt() => __pbn__ipaddress_loginattempt != null;
        public void Resetipaddress_loginattempt() => __pbn__ipaddress_loginattempt = null;
        private string __pbn__ipaddress_loginattempt;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string countryname_loginattempt
        {
            get => __pbn__countryname_loginattempt ?? "";
            set => __pbn__countryname_loginattempt = value;
        }
        public bool ShouldSerializecountryname_loginattempt() => __pbn__countryname_loginattempt != null;
        public void Resetcountryname_loginattempt() => __pbn__countryname_loginattempt = null;
        private string __pbn__countryname_loginattempt;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string statename_loginattempt
        {
            get => __pbn__statename_loginattempt ?? "";
            set => __pbn__statename_loginattempt = value;
        }
        public bool ShouldSerializestatename_loginattempt() => __pbn__statename_loginattempt != null;
        public void Resetstatename_loginattempt() => __pbn__statename_loginattempt = null;
        private string __pbn__statename_loginattempt;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string cityname_loginattempt
        {
            get => __pbn__cityname_loginattempt ?? "";
            set => __pbn__cityname_loginattempt = value;
        }
        public bool ShouldSerializecityname_loginattempt() => __pbn__cityname_loginattempt != null;
        public void Resetcityname_loginattempt() => __pbn__cityname_loginattempt = null;
        private string __pbn__cityname_loginattempt;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ipaddress_actual
        {
            get => __pbn__ipaddress_actual ?? "";
            set => __pbn__ipaddress_actual = value;
        }
        public bool ShouldSerializeipaddress_actual() => __pbn__ipaddress_actual != null;
        public void Resetipaddress_actual() => __pbn__ipaddress_actual = null;
        private string __pbn__ipaddress_actual;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string countryname_actual
        {
            get => __pbn__countryname_actual ?? "";
            set => __pbn__countryname_actual = value;
        }
        public bool ShouldSerializecountryname_actual() => __pbn__countryname_actual != null;
        public void Resetcountryname_actual() => __pbn__countryname_actual = null;
        private string __pbn__countryname_actual;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue("")]
        public string statename_actual
        {
            get => __pbn__statename_actual ?? "";
            set => __pbn__statename_actual = value;
        }
        public bool ShouldSerializestatename_actual() => __pbn__statename_actual != null;
        public void Resetstatename_actual() => __pbn__statename_actual = null;
        private string __pbn__statename_actual;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue("")]
        public string cityname_actual
        {
            get => __pbn__cityname_actual ?? "";
            set => __pbn__cityname_actual = value;
        }
        public bool ShouldSerializecityname_actual() => __pbn__cityname_actual != null;
        public void Resetcityname_actual() => __pbn__cityname_actual = null;
        private string __pbn__cityname_actual;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue("")]
        public string steamguard_code
        {
            get => __pbn__steamguard_code ?? "";
            set => __pbn__steamguard_code = value;
        }
        public bool ShouldSerializesteamguard_code() => __pbn__steamguard_code != null;
        public void Resetsteamguard_code() => __pbn__steamguard_code = null;
        private string __pbn__steamguard_code;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCredentials_LastCredentialChangeTime_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool user_changes_only
        {
            get => __pbn__user_changes_only.GetValueOrDefault();
            set => __pbn__user_changes_only = value;
        }
        public bool ShouldSerializeuser_changes_only() => __pbn__user_changes_only != null;
        public void Resetuser_changes_only() => __pbn__user_changes_only = null;
        private bool? __pbn__user_changes_only;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCredentials_LastCredentialChangeTime_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint timestamp_last_password_change
        {
            get => __pbn__timestamp_last_password_change.GetValueOrDefault();
            set => __pbn__timestamp_last_password_change = value;
        }
        public bool ShouldSerializetimestamp_last_password_change() => __pbn__timestamp_last_password_change != null;
        public void Resettimestamp_last_password_change() => __pbn__timestamp_last_password_change = null;
        private uint? __pbn__timestamp_last_password_change;

        [global::ProtoBuf.ProtoMember(2, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint timestamp_last_email_change
        {
            get => __pbn__timestamp_last_email_change.GetValueOrDefault();
            set => __pbn__timestamp_last_email_change = value;
        }
        public bool ShouldSerializetimestamp_last_email_change() => __pbn__timestamp_last_email_change != null;
        public void Resettimestamp_last_email_change() => __pbn__timestamp_last_email_change = null;
        private uint? __pbn__timestamp_last_email_change;

        [global::ProtoBuf.ProtoMember(3, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint timestamp_last_password_reset
        {
            get => __pbn__timestamp_last_password_reset.GetValueOrDefault();
            set => __pbn__timestamp_last_password_reset = value;
        }
        public bool ShouldSerializetimestamp_last_password_reset() => __pbn__timestamp_last_password_reset != null;
        public void Resettimestamp_last_password_reset() => __pbn__timestamp_last_password_reset = null;
        private uint? __pbn__timestamp_last_password_reset;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCredentials_GetAccountAuthSecret_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCredentials_GetAccountAuthSecret_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public int secret_id
        {
            get => __pbn__secret_id.GetValueOrDefault();
            set => __pbn__secret_id = value;
        }
        public bool ShouldSerializesecret_id() => __pbn__secret_id != null;
        public void Resetsecret_id() => __pbn__secret_id = null;
        private int? __pbn__secret_id;

        [global::ProtoBuf.ProtoMember(2)]
        public byte[] secret
        {
            get => __pbn__secret;
            set => __pbn__secret = value;
        }
        public bool ShouldSerializesecret() => __pbn__secret != null;
        public void Resetsecret() => __pbn__secret = null;
        private byte[] __pbn__secret;

    }

    public class Credentials : SteamUnifiedMessages.UnifiedService
    {
        public override string ServiceName { get; } = "Credentials";

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CCredentials_GetSteamGuardDetails_Response>> GetSteamGuardDetails( CCredentials_GetSteamGuardDetails_Request request )
        {
            return UnifiedMessages.SendMessage<CCredentials_GetSteamGuardDetails_Request, CCredentials_GetSteamGuardDetails_Response>( "Credentials.GetSteamGuardDetails#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CCredentials_ValidateEmailAddress_Response>> ValidateEmailAddress( CCredentials_ValidateEmailAddress_Request request )
        {
            return UnifiedMessages.SendMessage<CCredentials_ValidateEmailAddress_Request, CCredentials_ValidateEmailAddress_Response>( "Credentials.ValidateEmailAddress#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CCredentials_SteamGuardPhishingReport_Response>> SteamGuardPhishingReport( CCredentials_SteamGuardPhishingReport_Request request )
        {
            return UnifiedMessages.SendMessage<CCredentials_SteamGuardPhishingReport_Request, CCredentials_SteamGuardPhishingReport_Response>( "Credentials.SteamGuardPhishingReport#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CCredentials_LastCredentialChangeTime_Response>> GetCredentialChangeTimeDetails( CCredentials_LastCredentialChangeTime_Request request )
        {
            return UnifiedMessages.SendMessage<CCredentials_LastCredentialChangeTime_Request, CCredentials_LastCredentialChangeTime_Response>( "Credentials.GetCredentialChangeTimeDetails#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CCredentials_GetAccountAuthSecret_Response>> GetAccountAuthSecret( CCredentials_GetAccountAuthSecret_Request request )
        {
            return UnifiedMessages.SendMessage<CCredentials_GetAccountAuthSecret_Request, CCredentials_GetAccountAuthSecret_Response>( "Credentials.GetAccountAuthSecret#1", request );
        }

        public override void HandleResponseMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
            switch ( methodName )
            {
                case "GetSteamGuardDetails":
                    PostResponseMsg<CCredentials_GetSteamGuardDetails_Response>( packetMsg );
                    break;
                case "ValidateEmailAddress":
                    PostResponseMsg<CCredentials_ValidateEmailAddress_Response>( packetMsg );
                    break;
                case "SteamGuardPhishingReport":
                    PostResponseMsg<CCredentials_SteamGuardPhishingReport_Response>( packetMsg );
                    break;
                case "GetCredentialChangeTimeDetails":
                    PostResponseMsg<CCredentials_LastCredentialChangeTime_Response>( packetMsg );
                    break;
                case "GetAccountAuthSecret":
                    PostResponseMsg<CCredentials_GetAccountAuthSecret_Response>( packetMsg );
                    break;
            }
        }

        public override void HandleNotificationMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
        }
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
