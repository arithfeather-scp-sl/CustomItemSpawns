using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ArithFeather.CustomItemSpawns
{
	public class DataIO
	{

		//public static void Save(PointList pointList, string filePath) {
		//	var culture = CultureInfo.GetCultureInfo("en-US");
		//	var data = pointList.RawPoints;
		//	using (var writer = new StreamWriter(File.Create(filePath))) {
		//		foreach (var point in data) {
		//			var pos = point.Position.RoundVector3();
		//			var rot = point.Rotation.RoundVector3();
		//			writer.WriteLine($"{point.Id}:{point.ZoneType}:{pos.x.ToString(culture)},{pos.y.ToString(culture)},{pos.z.ToString(culture)}:{rot.x.ToString(culture)},{rot.y.ToString(culture)},{rot.z.ToString(culture)}");
		//		}
		//	}
		//}

		//private static bool TryParseVector3(string vectorData, out Vector3 vector) {
		//	vector = Vector3.zero;
		//	var sVector = vectorData.Split(',');

		//	if (sVector.Length != 3) return false;

		//	if (!float.TryParse(sVector[0].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out float x)
		//		|| !float.TryParse(sVector[1].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out float y)
		//		|| !float.TryParse(sVector[2].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out float z))
		//		return false;

		//	vector = new Vector3(x, y, z);
		//	return true;
		//}
	}
}