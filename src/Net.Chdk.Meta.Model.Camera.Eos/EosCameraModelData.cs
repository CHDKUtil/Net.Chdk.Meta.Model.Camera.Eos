using System.Collections.Generic;

namespace Net.Chdk.Meta.Model.Camera
{
    public sealed class EosCameraModelData : CameraModelData
    {
        public IDictionary<string, VersionData> Versions { get; set; }
    }
}
