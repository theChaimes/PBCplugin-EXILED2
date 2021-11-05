using CommandSystem;
using Exiled.API.Features;
using Exiled.Permissions.Extensions;
using System;

namespace PBCplugin
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class PBCcommand : ICommand
    {
        string ICommand.Command => "pre";

        public string[] Aliases {get;} = { "p" };

        public string Description => "Send a pre-made broadcast to the server. Usage: pre [#]";


        // command execution
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (arguments.Count > 0)
            {

                if (!((CommandSender)sender).CheckPermission("pbc.broadcast")) // checks permissions
                {
                    response = "Permission denied."; // sends response. the way exiled works is that it must return a response and a boolean.
                    return false;
                }
                else
                {
                    string toBroadcast = arguments.At(0); // gets the first argument parameter
                    bool result = Int32.TryParse(toBroadcast, out int param); // converts string to integer
                    if (result)
                    {
                        if (param > 11 || param < 1) // checks if result is in range
                        {
                            response = "Number is out of bounds! Use pre to view commands!";
                            return false;
                        }
                    }
                    else
                    {
                        response = "Incorrect parameter entered! Usage: pre [#]";
                        return false;
                    }
                    EventHandlers.OnPreCommand(param);
                    response = "Command ran!";
                    return true;
                }
            }
            else
            {
                // this is if there is no args, which then relays all available broadacsts. after a permission check of course
                if (!((CommandSender)sender).CheckPermission("pbc.broadcast"))
                {
                    response = "Permission denied.";
                    return false;
                }
                else
                {
                    // the response is all of the available broadcasts
                    EventHandlers.OnPreCommand(-1);
                    response = ("\n1. " + PBCPlugin.pbc.Config.ShorthandBroadcast1 + "\n" +
                    "2. " + PBCPlugin.pbc.Config.ShorthandBroadcast2 + "\n" +
                    "3. " + PBCPlugin.pbc.Config.ShorthandBroadcast3 + "\n" +
                    "4. " + PBCPlugin.pbc.Config.ShorthandBroadcast4 + "\n" +
                    "5. " + PBCPlugin.pbc.Config.ShorthandBroadcast5 + "\n" +
                    "6. " + PBCPlugin.pbc.Config.ShorthandBroadcast6 + "\n" +
                    "7. " + PBCPlugin.pbc.Config.ShorthandBroadcast7 + "\n" +
                    "8. " + PBCPlugin.pbc.Config.ShorthandBroadcast8 + "\n" +
                    "9. " + PBCPlugin.pbc.Config.ShorthandBroadcast9);
                    return true;
                }

            }
        }
    }
}
