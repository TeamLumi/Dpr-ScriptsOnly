using System;
using UnityEngine;

namespace XLSXContent
{
	[Serializable]
	public class ArenaInfo
	{
		[Serializable]
		public class SheetArenaData : ScriptableObject
		{
			public string Caption;

			public GameObject ArenaID;

			public string GroundAssetBundleName;

			public string SkyAssetBundleName;

			public GameObject RenderSettings;

			public bool EnableDarkBall;

			public byte MinomuttiFormNo;

			public GameObject SizennotikaraWazaNo;

			public GameObject FootEffectID;

			public GameObject AttachJoint;

			public int ReflectionResolution;

			public int ShadowResolution;

			public bool IsIndoor;
		}

		public GameObject ArenaData;

		public object this[int index] => null;
	}
}
