﻿namespace CgfConverter.CryEngine_Core
{
    public abstract class ChunkBoneAnim : Chunk
    {
        public int NumBones;

        public override void WriteChunk()
        {
            Utils.Log(LogLevelEnum.Debug, "*** START MorphTargets Chunk ***");
            Utils.Log(LogLevelEnum.Debug, "    ChunkType:           {0}", ChunkType);
            Utils.Log(LogLevelEnum.Debug, "    Node ID:             {0:X}", ID);
            Utils.Log(LogLevelEnum.Debug, "    Number of Targets:   {0:X}", NumBones);
        }
    }
}
