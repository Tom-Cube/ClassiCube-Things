using System;
using MCGalaxy.Commands;
namespace MCGalaxy {
	public class CmdNobuild : Command {
		public override string name { get { return "NoBuild"; } }
		public override string shortcut { get { return "nbd"; } }
		public override string type { get { return "other"; } }
		public override bool museumUsable { get { return false; } }
		public override LevelPermission defaultRank { get { return LevelPermission.Banned; } }
		public override void Use(Player p, string message) {Command.Find("map").Use("buildable"); Command.Find("map").Use("deletable")}
		public override void Help(Player p) {p.Message("%T/NoBuild - %HToggles map building and deleting.");}
	}
}
