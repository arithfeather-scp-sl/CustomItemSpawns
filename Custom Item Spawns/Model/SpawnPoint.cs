namespace ArithFeather.CustomItemSpawns.Model {
	public class SpawnPoint
	{
		public SpawnPoint(string id, string room, string zone, string position, string rotation)
		{
			ID = id;
			Room = room;
			Position = position;
			Rotation = rotation;
			Zone = zone;
		}

		public string ID { get; }
		public string Room { get; }
		private string Zone { get; }
		private string Position { get; }
		private string Rotation { get; }
	}
}
