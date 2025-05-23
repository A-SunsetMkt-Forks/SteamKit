// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_remoteclient_service.steamclient.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    public class RemoteClient : SteamUnifiedMessages.UnifiedService
    {
        public override string ServiceName { get; } = "RemoteClient";

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CRemoteClient_GetPairingInfo_Response>> GetPairingInfo( CRemoteClient_GetPairingInfo_Request request )
        {
            return UnifiedMessages.SendMessage<CRemoteClient_GetPairingInfo_Request, CRemoteClient_GetPairingInfo_Response>( "RemoteClient.GetPairingInfo#1", request );
        }

        public void NotifyOnline(CRemoteClient_Online_Notification request )
        {
            UnifiedMessages.SendNotification<CRemoteClient_Online_Notification>( "RemoteClient.NotifyOnline#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CRemoteClient_GetRecentClients_Response>> GetRecentClients( CRemoteClient_GetRecentClients_Request request )
        {
            return UnifiedMessages.SendMessage<CRemoteClient_GetRecentClients_Request, CRemoteClient_GetRecentClients_Response>( "RemoteClient.GetRecentClients#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CRemoteClient_MarkTaskComplete_Response>> MarkTaskComplete( CRemoteClient_MarkTaskComplete_Request request )
        {
            return UnifiedMessages.SendMessage<CRemoteClient_MarkTaskComplete_Request, CRemoteClient_MarkTaskComplete_Response>( "RemoteClient.MarkTaskComplete#1", request );
        }

        public void NotifyReplyPacket(CRemoteClient_ReplyPacket_Notification request )
        {
            UnifiedMessages.SendNotification<CRemoteClient_ReplyPacket_Notification>( "RemoteClient.NotifyReplyPacket#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CRemoteClient_AllocateRelayServer_Response>> AllocateRelayServer( CRemoteClient_AllocateRelayServer_Request request )
        {
            return UnifiedMessages.SendMessage<CRemoteClient_AllocateRelayServer_Request, CRemoteClient_AllocateRelayServer_Response>( "RemoteClient.AllocateRelayServer#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CRemoteClient_AllocateSDR_Response>> AllocateSDR( CRemoteClient_AllocateSDR_Request request )
        {
            return UnifiedMessages.SendMessage<CRemoteClient_AllocateSDR_Request, CRemoteClient_AllocateSDR_Response>( "RemoteClient.AllocateSDR#1", request );
        }

        public void SendSteamBroadcastPacket(CRemoteClient_SteamBroadcast_Notification request )
        {
            UnifiedMessages.SendNotification<CRemoteClient_SteamBroadcast_Notification>( "RemoteClient.SendSteamBroadcastPacket#1", request );
        }

        public void SendSteamToSteamPacket(CRemoteClient_SteamToSteam_Notification request )
        {
            UnifiedMessages.SendNotification<CRemoteClient_SteamToSteam_Notification>( "RemoteClient.SendSteamToSteamPacket#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CRemotePlay_SessionStarted_Response>> SendRemotePlaySessionStarted( CRemotePlay_SessionStarted_Request request )
        {
            return UnifiedMessages.SendMessage<CRemotePlay_SessionStarted_Request, CRemotePlay_SessionStarted_Response>( "RemoteClient.SendRemotePlaySessionStarted#1", request );
        }

        public void SendRemotePlaySessionStopped(CRemotePlay_SessionStopped_Notification request )
        {
            UnifiedMessages.SendNotification<CRemotePlay_SessionStopped_Notification>( "RemoteClient.SendRemotePlaySessionStopped#1", request );
        }

        public void SendRemotePlayTogetherPacket(CRemotePlayTogether_Notification request )
        {
            UnifiedMessages.SendNotification<CRemotePlayTogether_Notification>( "RemoteClient.SendRemotePlayTogetherPacket#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CRemoteClient_CreateRemotePlayTogetherInvitation_Response>> CreateRemotePlayTogetherInvitation( CRemoteClient_CreateRemotePlayTogetherInvitation_Request request )
        {
            return UnifiedMessages.SendMessage<CRemoteClient_CreateRemotePlayTogetherInvitation_Request, CRemoteClient_CreateRemotePlayTogetherInvitation_Response>( "RemoteClient.CreateRemotePlayTogetherInvitation#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CRemoteClient_DeleteRemotePlayTogetherInvitation_Response>> DeleteRemotePlayTogetherInvitation( CRemoteClient_DeleteRemotePlayTogetherInvitation_Request request )
        {
            return UnifiedMessages.SendMessage<CRemoteClient_DeleteRemotePlayTogetherInvitation_Request, CRemoteClient_DeleteRemotePlayTogetherInvitation_Response>( "RemoteClient.DeleteRemotePlayTogetherInvitation#1", request );
        }

        public override void HandleResponseMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
            switch ( methodName )
            {
                case "GetPairingInfo":
                    PostResponseMsg<CRemoteClient_GetPairingInfo_Response>( packetMsg );
                    break;
                case "GetRecentClients":
                    PostResponseMsg<CRemoteClient_GetRecentClients_Response>( packetMsg );
                    break;
                case "MarkTaskComplete":
                    PostResponseMsg<CRemoteClient_MarkTaskComplete_Response>( packetMsg );
                    break;
                case "AllocateRelayServer":
                    PostResponseMsg<CRemoteClient_AllocateRelayServer_Response>( packetMsg );
                    break;
                case "AllocateSDR":
                    PostResponseMsg<CRemoteClient_AllocateSDR_Response>( packetMsg );
                    break;
                case "SendRemotePlaySessionStarted":
                    PostResponseMsg<CRemotePlay_SessionStarted_Response>( packetMsg );
                    break;
                case "CreateRemotePlayTogetherInvitation":
                    PostResponseMsg<CRemoteClient_CreateRemotePlayTogetherInvitation_Response>( packetMsg );
                    break;
                case "DeleteRemotePlayTogetherInvitation":
                    PostResponseMsg<CRemoteClient_DeleteRemotePlayTogetherInvitation_Response>( packetMsg );
                    break;
            }
        }

        public override void HandleNotificationMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
            switch ( methodName )
            {
                case "NotifyOnline":
                    PostNotificationMsg<CRemoteClient_Online_Notification>( packetMsg );
                    break;
                case "NotifyReplyPacket":
                    PostNotificationMsg<CRemoteClient_ReplyPacket_Notification>( packetMsg );
                    break;
                case "SendSteamBroadcastPacket":
                    PostNotificationMsg<CRemoteClient_SteamBroadcast_Notification>( packetMsg );
                    break;
                case "SendSteamToSteamPacket":
                    PostNotificationMsg<CRemoteClient_SteamToSteam_Notification>( packetMsg );
                    break;
                case "SendRemotePlaySessionStopped":
                    PostNotificationMsg<CRemotePlay_SessionStopped_Notification>( packetMsg );
                    break;
                case "SendRemotePlayTogetherPacket":
                    PostNotificationMsg<CRemotePlayTogether_Notification>( packetMsg );
                    break;
            }
        }
    }

    public class RemoteClientSteamClient : SteamUnifiedMessages.UnifiedService
    {
        public override string ServiceName { get; } = "RemoteClientSteamClient";

        public void NotifyRegisterStatusUpdate(CRemoteClient_RegisterStatusUpdate_Notification request )
        {
            UnifiedMessages.SendNotification<CRemoteClient_RegisterStatusUpdate_Notification>( "RemoteClientSteamClient.NotifyRegisterStatusUpdate#1", request );
        }

        public void NotifyUnregisterStatusUpdate(CRemoteClient_UnregisterStatusUpdate_Notification request )
        {
            UnifiedMessages.SendNotification<CRemoteClient_UnregisterStatusUpdate_Notification>( "RemoteClientSteamClient.NotifyUnregisterStatusUpdate#1", request );
        }

        public void NotifyRemotePacket(CRemoteClient_RemotePacket_Notification request )
        {
            UnifiedMessages.SendNotification<CRemoteClient_RemotePacket_Notification>( "RemoteClientSteamClient.NotifyRemotePacket#1", request );
        }

        public void NotifySteamBroadcastPacket(CRemoteClient_SteamBroadcast_Notification request )
        {
            UnifiedMessages.SendNotification<CRemoteClient_SteamBroadcast_Notification>( "RemoteClientSteamClient.NotifySteamBroadcastPacket#1", request );
        }

        public void NotifySteamToSteamPacket(CRemoteClient_SteamToSteam_Notification request )
        {
            UnifiedMessages.SendNotification<CRemoteClient_SteamToSteam_Notification>( "RemoteClientSteamClient.NotifySteamToSteamPacket#1", request );
        }

        public void NotifyRemotePlayTogetherPacket(CRemotePlayTogether_Notification request )
        {
            UnifiedMessages.SendNotification<CRemotePlayTogether_Notification>( "RemoteClientSteamClient.NotifyRemotePlayTogetherPacket#1", request );
        }

        public void NotifyTaskList(CRemoteClient_TaskList_Notification request )
        {
            UnifiedMessages.SendNotification<CRemoteClient_TaskList_Notification>( "RemoteClientSteamClient.NotifyTaskList#1", request );
        }

        public override void HandleResponseMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
        }

        public override void HandleNotificationMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
            switch ( methodName )
            {
                case "NotifyRegisterStatusUpdate":
                    PostNotificationMsg<CRemoteClient_RegisterStatusUpdate_Notification>( packetMsg );
                    break;
                case "NotifyUnregisterStatusUpdate":
                    PostNotificationMsg<CRemoteClient_UnregisterStatusUpdate_Notification>( packetMsg );
                    break;
                case "NotifyRemotePacket":
                    PostNotificationMsg<CRemoteClient_RemotePacket_Notification>( packetMsg );
                    break;
                case "NotifySteamBroadcastPacket":
                    PostNotificationMsg<CRemoteClient_SteamBroadcast_Notification>( packetMsg );
                    break;
                case "NotifySteamToSteamPacket":
                    PostNotificationMsg<CRemoteClient_SteamToSteam_Notification>( packetMsg );
                    break;
                case "NotifyRemotePlayTogetherPacket":
                    PostNotificationMsg<CRemotePlayTogether_Notification>( packetMsg );
                    break;
                case "NotifyTaskList":
                    PostNotificationMsg<CRemoteClient_TaskList_Notification>( packetMsg );
                    break;
            }
        }
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
