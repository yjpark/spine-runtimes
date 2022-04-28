using UnityEngine;
using Unity.Profiling;

using Edger.Unity;
using Edger.Unity.Profiling;

namespace Spine.Unity {
    public partial class Profiling : BaseMono {
        public static readonly ProfilerMarker SkeletonGraphic_Update = ProfilerUtil.GetMarker("SkeletonGraphic_Update", ProfilerItemFormat.MilliSeconds);
        public static readonly ProfilerMarker SkeletonGraphic_UpdateMesh = ProfilerUtil.GetMarker("SkeletonGraphic_UpdateMesh", ProfilerItemFormat.MilliSeconds);

        public static readonly ProfilerMarker SkeletonAnimation_Update = ProfilerUtil.GetMarker("SkeletonAnimation_Update", ProfilerItemFormat.MilliSeconds);
        public static readonly ProfilerMarker SkeletonAnimation_LateUpdateMesh = ProfilerUtil.GetMarker("SkeletonAnimation_LateUpdateMesh", ProfilerItemFormat.MilliSeconds);
    }
}
