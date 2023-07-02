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
        if (index < StrList.Count)
        {
            if (StrList.Count <= index)
            {
                throw new ArgumentOutOfRangeException();
            }
            return StrList[index];
        }
        return null;
    }

    public EvData()
    {
        Scripts = new List<Script>();
        StrList = new List<string>();
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
            Label = "";
            Commands = new List<Command>();
        }
    }

    [Serializable]
    public class Command
    {
        public List<Aregment> Arg;

        public Command()
        {
            Arg = new List<Aregment>();
        }
    }
}
