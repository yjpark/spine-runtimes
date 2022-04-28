using UnityEngine;

namespace Spine.Unity {
	public partial class SkeletonGraphic {
		public static bool UseLocalScale = true;
		private float _LastScale = 0f;
		private void CheckLocalScale() {
			if (canvas == null) return;

			float scale = canvas.referencePixelsPerUnit;
			if (Mathf.Abs(scale - _LastScale) >= 0.001) {
				Edger.Unity.Log.ErrorFrom(this, "SkeletonGraphic.CheckLocalScale() {0} -> {1}", _LastScale, scale);
				_LastScale = scale;
				this.GetComponent<RectTransform>().localScale = Vector3.one * scale;
			}
		}
	}
}
