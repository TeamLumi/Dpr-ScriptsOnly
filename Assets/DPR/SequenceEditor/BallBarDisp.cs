using System;
using UnityEngine;
//using static UnityEditor.PlayerSettings;

namespace Dpr.SequenceEditor
{
    public class BallBarDisp : Macro
    {
        public int trg;

        public BallBarDisp(Macro macro)
            : base(macro)
        {
            //this.trg = Parse_SEQ_DEF_POS(macro.GetValue("SEQ_DEF_POS"));
        }
    }

    public enum BALL_ANIME
    {
        NONE = 0,

        BALL_ANIME_NONE,

        BALL_ANIME_INTRO,

        BALL_ANIME_FALL
    }
}
