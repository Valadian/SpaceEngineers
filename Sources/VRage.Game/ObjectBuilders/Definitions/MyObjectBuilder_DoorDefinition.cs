﻿using VRage.ObjectBuilders;
using ProtoBuf;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
    [ProtoContract]
    [MyObjectBuilderDefinition]
    public class MyObjectBuilder_DoorDefinition : MyObjectBuilder_CubeBlockDefinition
    {
	    [ProtoMember]
	    public string ResourceSinkGroup;

        [ProtoMember]
        public float MaxOpen;

        [ProtoMember]
        public string OpenSound;

        [ProtoMember]
        public string CloseSound;

        [ProtoMember]
        public float OpeningSpeed = 1f;
    }
}
