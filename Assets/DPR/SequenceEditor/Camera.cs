using System;
using UnityEngine;

namespace Dpr.SequenceEditor
{
    public class CameraAnimationChangeSpeed : Macro
    {
        public float Speed { get; set; }

        public CameraAnimationChangeSpeed(Macro macro) : base(macro)
        {
            Speed = ParseFloat(macro.GetValue("10157"), 0.0f);
        }
    }

    public class SubCameraAnimationChangeSpeed : Macro
    {
        public float Speed { get; set; }

        public SubCameraAnimationChangeSpeed(Macro macro) : base(macro)
        {
            Speed = ParseFloat(macro.GetValue("10157"), 0.0f);
        }
    }

    public class CameraAnimationDoubleIntro : Macro
    {
        public string Envfile { get; set; }
        public string MotfileA { get; set; }
        public string MotfileB { get; set; }
        public string MotfileC { get; set; }
        public int TrgA { get; set; }
        public int TrgB { get; set; }
        public int Node { get; set; }
        public Vector3 Pos { get; set; }
        public bool IsFlip { get; set; }
        public bool IsRot { get; set; }
        public bool ForceUpdate { get; set; }

        public CameraAnimationDoubleIntro(Macro macro) : base(macro)
        {
            //Envfile = ParseString(macro.GetValue("10158"));
            //MotfileA = ParseString(macro.GetValue("10159"));
            //MotfileB = ParseString(macro.GetValue("10160"));
            //MotfileC = ParseString(macro.GetValue("10161"));
            //TrgA = ParseSeqDefPos(macro.GetValue("10162"));
            //TrgB = ParseSeqDefPos(macro.GetValue("10163"));
            //Node = ParseSeqDefNode(macro.GetValue("10164"));
            //Pos = ParseVector3(macro.GetValue("10165"));
            //IsFlip = ParseBool(macro.GetValue("10166"));
            //IsRot = ParseBool(macro.GetValue("10167"));
            //ForceUpdate = ParseBool(macro.GetValue("10168"));
        }
    }

    public class SubCameraAnimationDoubleIntro : Macro
    {
        public string Envfile { get; set; }
        public string MotfileA { get; set; }
        public string MotfileB { get; set; }
        public string MotfileC { get; set; }
        public int TrgA { get; set; }
        public int TrgB { get; set; }
        public int Node { get; set; }
        public Vector3 Pos { get; set; }
        public bool IsFlip { get; set; }
        public bool IsRot { get; set; }
        public bool ForceUpdate { get; set; }

        public SubCameraAnimationDoubleIntro(Macro macro) : base(macro)
        {
            //Envfile = ParseString(macro.GetValue("10158"));
            //MotfileA = ParseString(macro.GetValue("10159"));
            //MotfileB = ParseString(macro.GetValue("10160"));
            //MotfileC = ParseString(macro.GetValue("10161"));
            //TrgA = ParseSeqDefPos(macro.GetValue("10162"));
            //TrgB = ParseSeqDefPos(macro.GetValue("10163"));
            //Node = ParseSeqDefNode(macro.GetValue("10164"));
            //Pos = ParseVector3(macro.GetValue("10165"));
            //IsFlip = ParseBool(macro.GetValue("10166"));
            //IsRot = ParseBool(macro.GetValue("10167"));
            //ForceUpdate = ParseBool(macro.GetValue("10168"));
        }
    }

    // CameraAnimationChangeSpeed
    // CameraAnimationDoubleIntro
    // CameraAnimationEnd
    // CameraAnimationPoke
    // CameraAnimationPosition
    // CameraAnimationRotate
    // CameraAnimationScale
    // CameraAnimationSpecialPos
    // CameraAnimationTrainer
    // CameraCheckGroundFlg
    // CameraMovePosition
    // CameraMoveRelativeCameraSp
    // CameraMoveRelativeOtherModel
    // CameraMoveRelativePoke
    // CameraMoveRelativeTrainer
    // CameraMoveSpecialPos
    // CameraNearFarFovSet
    // CameraReset
    // CameraResetFieldAll
    // CameraRotatePos
    // CameraRotatePosPoke
    // CameraRotateTrg
    // CameraShake
    // CameraTwist
}
