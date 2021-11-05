using Exiled.API.Features;


namespace PBCplugin
{
    public static class EventHandlers
    {

        public static void OnPreCommand(int param)
        {
            switch (param)
            {
                case -1:
                    // this doesnt need to exist tbh. too lazy lol
                    break;
                case 1:
                    Map.Broadcast(PBCPlugin.pbc.Config.BroadcastDuration, PBCPlugin.pbc.Config.Broadcast1);
                    break;
                case 2:
                    Map.Broadcast(PBCPlugin.pbc.Config.BroadcastDuration, PBCPlugin.pbc.Config.Broadcast2);
                    break;
                case 3:
                    Map.Broadcast(PBCPlugin.pbc.Config.BroadcastDuration, PBCPlugin.pbc.Config.Broadcast3);
                    break;
                case 4:
                    Map.Broadcast(PBCPlugin.pbc.Config.BroadcastDuration, PBCPlugin.pbc.Config.Broadcast4);
                    break;
                case 5:
                    Map.Broadcast(PBCPlugin.pbc.Config.BroadcastDuration, PBCPlugin.pbc.Config.Broadcast5);
                    break;
                case 6:
                    Map.Broadcast(PBCPlugin.pbc.Config.BroadcastDuration, PBCPlugin.pbc.Config.Broadcast6);
                    break;
                case 7:
                    Map.Broadcast(PBCPlugin.pbc.Config.BroadcastDuration, PBCPlugin.pbc.Config.Broadcast7);
                    break;
                case 8:
                    Map.Broadcast(PBCPlugin.pbc.Config.BroadcastDuration, PBCPlugin.pbc.Config.Broadcast8);
                    break;
                case 9:
                    Map.Broadcast(PBCPlugin.pbc.Config.BroadcastDuration, PBCPlugin.pbc.Config.Broadcast9);
                    break;
            }
            
        }
    }
}
