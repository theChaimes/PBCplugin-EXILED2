using System;
using CommandSystem;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.Permissions.Extensions;
using RemoteAdmin;

namespace PBCplugin
{
    public class PBCPlugin : Plugin<Config>
    {
        public static PBCPlugin pbc;

        public override void OnEnabled()
        {
            pbc = this; // shit is stupid and needs the plugin to define itself lol, otherwise tho this script does like nothing
        }
    }
}
