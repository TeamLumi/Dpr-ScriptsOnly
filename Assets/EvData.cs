using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvData : ScriptableObject
{
    public List<Script> Scripts;
    public List<string> StrList;

    public string GetString(int index)
    {
        return "";
    }

    public EvData()
    {
        // TODO
    }

    public enum ArgType
    {
        Command = 0,
        Float = 1,
        Work = 2,
        Flag = 3,
        SysFlag = 4,
        String = 5
    }

    [Serializable]
    public struct Aregment
    {
	    public ArgType argType;
        public int data;
    }

    [Serializable]
    public class Script
    {
	    public string Label;
        public List<Command> Commands;

        public Script()
        {
            // TODO
        }
    }

    [Serializable]
    public class Command
    {
        public List<Aregment> Arg;

        public Command()
        {
            // TODO
        }
    }
}
