using System;
using System.Collections.Generic;
using System.Xml;
//using nn.hid;
using UnityEngine;

public class GameController
{
    public static Vector2 analogStickL;
    public static Vector2 analogStickR;
    public static Vector2 digitalPad;
    public static int on;
    public static int push;
    public static int release;
    public static int accel;
    public static long[] times;
    public static int repeat;
    private static long start;
    private static long interval;
    private static long limit_intarval;
    private static long required_time;
    private static long prevTicks;
    private static HashSet<LogicalInput> logicalInputs;
    //private static readonly NpadId[] npadIds;
    //public static NpadState npadState;
    //public static NpadId npadId;
    //public static NpadStyle npadStyle;
    private static int[] _analogStickLButtonMasks;
    private static int[] _analogStickRButtonMasks;

    public class LogicalInput
    {
        public int on;
        public int push;
        public int release;
        public int repeat;
        public int accel;
        private ValueTuple<int, Condition>[] maps;

        public LogicalInput()
        {
        }

        public void Assign(int index, int mask, Condition condition = Condition.Any)
        {
        }

        public void Clear()
        {
        }

        internal void Remap()
        {
        }

        public enum Condition
        {
            Any,
            All
        }
    }

    public class ButtonIndex
    {
        public const int A = 0;
        public const int B = 1;
        public const int X = 2;
        public const int Y = 3;
        public const int StickL = 4;
        public const int StickR = 5;
        public const int L = 6;
        public const int R = 7;
        public const int ZL = 8;
        public const int ZR = 9;
        public const int Plus = 10;
        public const int Minus = 11;
        public const int Left = 12;
        public const int Up = 13;
        public const int Right = 14;
        public const int Down = 15;
        public const int StickLLeft = 16;
        public const int StickLUp = 17;
        public const int StickLRight = 18;
        public const int StickLDown = 19;
        public const int StickRLeft = 20;
        public const int StickRUp = 21;
        public const int StickRRight = 22;
        public const int StickRDown = 23;
        public const int LeftSL = 24;
        public const int LeftSR = 25;
        public const int RightSL = 26;
        public const int RightSR = 27;
        public const int Count = 28;
    }

    public class ButtonMask
    {
        public const int None = 0;
        public const int A = 1;
        public const int B = 2;
        public const int X = 4;
        public const int Y = 8;
        public const int StickL = 16;
        public const int StickR = 32;
        public const int L = 64;
        public const int R = 128;
        public const int ZL = 256;
        public const int ZR = 512;
        public const int Plus = 1024;
        public const int Minus = 2048;
        public const int Left = 4096;
        public const int Up = 8192;
        public const int Right = 16384;
        public const int Down = 32768;
        public const int StickLLeft = 65536;
        public const int StickLUp = 131072;
        public const int StickLRight = 262144;
        public const int StickLDown = 524288;
        public const int StickRLeft = 1048576;
        public const int StickRUp = 2097152;
        public const int StickRRight = 4194304;
        public const int StickRDown = 8388608;
        public const int LeftSL = 16777216;
        public const int LeftSR = 33554432;
        public const int RightSL = 67108864;
        public const int RightSR = 134217728;
    }

    private static int[] npadIds;
    private static Action onDestroy;

    public static void OnApplicationPlaying()
    {
        //nn.hid.Npad.Initialize();
        //nn.hid.Npad.SetSupportedIdType(npadIds);
        //nn.hid.Npad.SetSupportedStyleSet(7, 0);

        //var callback = new SmartPoint.AssetAssistant.Sequencer.TickCallback();
        //SmartPoint.AssetAssistant.Sequencer.SubscribeUpdate(-10000, callback);

        //var eventCallback = new SmartPoint.AssetAssistant.Sequencer.EventCallback();
        //onDestroy += eventCallback;
    }

    private static void Shutdown()
    {
    }

    private static void Update(float deltaTime)
    {
    }

    private static bool UpdateNpadState()
    {
        return default(bool);
    }

    //private static Vector2 CalcNpadAnalogValue(AnalogStickState analogState, float dead)
    //{
        //return default(Vector2);
    //}

    private static int GetAnalogStickButtonIndex(Vector2 analogStick)
    {
        return default(int);
    }

    public static void Subscribe(LogicalInput logicalInput)
    {
    }

    public static void Remove(LogicalInput logicalInput)
    {
    }

    public GameController()
    {
    }
}
