// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_workshop.steamclient.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CWorkshop_GetEULAStatus_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CWorkshop_GetEULAStatus_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint version
        {
            get => __pbn__version.GetValueOrDefault();
            set => __pbn__version = value;
        }
        public bool ShouldSerializeversion() => __pbn__version != null;
        public void Resetversion() => __pbn__version = null;
        private uint? __pbn__version;

        [global::ProtoBuf.ProtoMember(2)]
        public uint timestamp_action
        {
            get => __pbn__timestamp_action.GetValueOrDefault();
            set => __pbn__timestamp_action = value;
        }
        public bool ShouldSerializetimestamp_action() => __pbn__timestamp_action != null;
        public void Resettimestamp_action() => __pbn__timestamp_action = null;
        private uint? __pbn__timestamp_action;

        [global::ProtoBuf.ProtoMember(3)]
        public bool accepted
        {
            get => __pbn__accepted.GetValueOrDefault();
            set => __pbn__accepted = value;
        }
        public bool ShouldSerializeaccepted() => __pbn__accepted != null;
        public void Resetaccepted() => __pbn__accepted = null;
        private bool? __pbn__accepted;

        [global::ProtoBuf.ProtoMember(4)]
        public bool needs_action
        {
            get => __pbn__needs_action.GetValueOrDefault();
            set => __pbn__needs_action = value;
        }
        public bool ShouldSerializeneeds_action() => __pbn__needs_action != null;
        public void Resetneeds_action() => __pbn__needs_action = null;
        private bool? __pbn__needs_action;

    }

    public class Workshop : SteamUnifiedMessages.UnifiedService
    {
        public override string ServiceName { get; } = "Workshop";

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CWorkshop_GetEULAStatus_Response>> GetEULAStatus( CWorkshop_GetEULAStatus_Request request )
        {
            return UnifiedMessages.SendMessage<CWorkshop_GetEULAStatus_Request, CWorkshop_GetEULAStatus_Response>( "Workshop.GetEULAStatus#1", request );
        }

        public override void HandleResponseMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
            switch ( methodName )
            {
                case "GetEULAStatus":
                    PostResponseMsg<CWorkshop_GetEULAStatus_Response>( packetMsg );
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
