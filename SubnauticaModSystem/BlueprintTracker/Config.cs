using System;

namespace BlueprintTracker
{
	[Serializable]
	class Config
	{
		public int MaxPinnedBlueprints = 100;
		public string Position = "TopRight";
		public int CornerOffsetX = 5;
		public int CornerOffsetY = 5;
        public int EntrySpacing = 5;
		public float TrackerScale = 0.7f;
        public float EntryHeight = 70f;
        public float IconSpacing = -6f;
        public float IconWidth = 50f;
		public int FontSize = 16;
		public float BackgroundAlpha = 0.5f;
		public bool ShowWhilePiloting = false;
		public bool ColorblindMode = false;
        public bool ShowExcessAmounts = true;
	}
}
