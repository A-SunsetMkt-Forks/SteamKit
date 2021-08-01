// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_clientnotificationtypes.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CClientNotificationDownloadCompleted : global::ProtoBuf.IExtensible
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
    public partial class CClientNotificationFriendInvite : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get => __pbn__steamid.GetValueOrDefault();
            set => __pbn__steamid = value;
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CClientNotificationFriendInGame : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get => __pbn__steamid.GetValueOrDefault();
            set => __pbn__steamid = value;
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string game_name
        {
            get => __pbn__game_name ?? "";
            set => __pbn__game_name = value;
        }
        public bool ShouldSerializegame_name() => __pbn__game_name != null;
        public void Resetgame_name() => __pbn__game_name = null;
        private string __pbn__game_name;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CClientNotificationFriendOnline : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get => __pbn__steamid.GetValueOrDefault();
            set => __pbn__steamid = value;
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CClientNotificationAchievement : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string achievement_id
        {
            get => __pbn__achievement_id ?? "";
            set => __pbn__achievement_id = value;
        }
        public bool ShouldSerializeachievement_id() => __pbn__achievement_id != null;
        public void Resetachievement_id() => __pbn__achievement_id = null;
        private string __pbn__achievement_id;

        [global::ProtoBuf.ProtoMember(2)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get => __pbn__name ?? "";
            set => __pbn__name = value;
        }
        public bool ShouldSerializename() => __pbn__name != null;
        public void Resetname() => __pbn__name = null;
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string description
        {
            get => __pbn__description ?? "";
            set => __pbn__description = value;
        }
        public bool ShouldSerializedescription() => __pbn__description != null;
        public void Resetdescription() => __pbn__description = null;
        private string __pbn__description;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string image_url
        {
            get => __pbn__image_url ?? "";
            set => __pbn__image_url = value;
        }
        public bool ShouldSerializeimage_url() => __pbn__image_url != null;
        public void Resetimage_url() => __pbn__image_url = null;
        private string __pbn__image_url;

        [global::ProtoBuf.ProtoMember(6)]
        public bool achieved
        {
            get => __pbn__achieved.GetValueOrDefault();
            set => __pbn__achieved = value;
        }
        public bool ShouldSerializeachieved() => __pbn__achieved != null;
        public void Resetachieved() => __pbn__achieved = null;
        private bool? __pbn__achieved;

        [global::ProtoBuf.ProtoMember(7)]
        public uint rtime_unlocked
        {
            get => __pbn__rtime_unlocked.GetValueOrDefault();
            set => __pbn__rtime_unlocked = value;
        }
        public bool ShouldSerializertime_unlocked() => __pbn__rtime_unlocked != null;
        public void Resetrtime_unlocked() => __pbn__rtime_unlocked = null;
        private uint? __pbn__rtime_unlocked;

        [global::ProtoBuf.ProtoMember(8)]
        public float min_progress
        {
            get => __pbn__min_progress.GetValueOrDefault();
            set => __pbn__min_progress = value;
        }
        public bool ShouldSerializemin_progress() => __pbn__min_progress != null;
        public void Resetmin_progress() => __pbn__min_progress = null;
        private float? __pbn__min_progress;

        [global::ProtoBuf.ProtoMember(9)]
        public float current_progress
        {
            get => __pbn__current_progress.GetValueOrDefault();
            set => __pbn__current_progress = value;
        }
        public bool ShouldSerializecurrent_progress() => __pbn__current_progress != null;
        public void Resetcurrent_progress() => __pbn__current_progress = null;
        private float? __pbn__current_progress;

        [global::ProtoBuf.ProtoMember(10)]
        public float max_progress
        {
            get => __pbn__max_progress.GetValueOrDefault();
            set => __pbn__max_progress = value;
        }
        public bool ShouldSerializemax_progress() => __pbn__max_progress != null;
        public void Resetmax_progress() => __pbn__max_progress = null;
        private float? __pbn__max_progress;

        [global::ProtoBuf.ProtoMember(11)]
        public float global_achieved_pct
        {
            get => __pbn__global_achieved_pct.GetValueOrDefault();
            set => __pbn__global_achieved_pct = value;
        }
        public bool ShouldSerializeglobal_achieved_pct() => __pbn__global_achieved_pct != null;
        public void Resetglobal_achieved_pct() => __pbn__global_achieved_pct = null;
        private float? __pbn__global_achieved_pct;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CClientNotificationLowBattery : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public float pct_remaining
        {
            get => __pbn__pct_remaining.GetValueOrDefault();
            set => __pbn__pct_remaining = value;
        }
        public bool ShouldSerializepct_remaining() => __pbn__pct_remaining != null;
        public void Resetpct_remaining() => __pbn__pct_remaining = null;
        private float? __pbn__pct_remaining;

    }

    [global::ProtoBuf.ProtoContract()]
    public enum EClientNotificationType
    {
        k_EClientNotificationType_Invalid = 0,
        k_EClientNotificationType_DownloadCompleted = 1,
        k_EClientNotificationType_FriendInvite = 2,
        k_EClientNotificationType_FriendInGame = 3,
        k_EClientNotificationType_FriendOnline = 4,
        k_EClientNotificationType_Achievement = 5,
        k_EClientNotificationType_LowBattery = 6,
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion