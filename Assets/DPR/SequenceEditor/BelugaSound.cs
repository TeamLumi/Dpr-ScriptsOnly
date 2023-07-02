using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dpr.SequenceEditor;

namespace Dpr.SequenceEditor
{
    public class BelugaSoundAddEvent : Macro
    {
        public string Event { get; set; }

        public BelugaSoundAddEvent(Macro macro)
        {
            //this.Event = ParseString(GetValue(macro, "Event"), "");
        }
    }

    public class BelugaSoundLoadBank : Macro
    {
        public string Name { get; set; }

        public BelugaSoundLoadBank(Macro macro)
        {
            //this.Name = ParseString(GetValue(macro, "Name"), "");
        }
    }

    public class BelugaSoundPlaySe : Macro
    {
        public string Event { get; set; }
        public bool Is3D { get; set; }

        public BelugaSoundPlaySe(Macro macro)
        {
            //this.Event = ParseString(GetValue(macro, "Event"), "");
            //this.Is3D = ParseBool(GetValue(macro, "Is3D"), false);
        }
    }

    public class BelugaSoundPlaySeVersion : Macro
    {
        public string PikaEvent { get; set; }
        public string EeveEvent { get; set; }
        public bool Is3D { get; set; }

        public BelugaSoundPlaySeVersion(Macro macro)
        {
            //this.PikaEvent = ParseString(GetValue(macro, "PikaEvent"), "");
            //this.EeveEvent = ParseString(GetValue(macro, "EeveEvent"), "");
            //this.Is3D = ParseBool(GetValue(macro, "Is3D"), false);
        }
    }

    public class BelugaSoundPlayVoice : Macro
    {
        public int Player { get; set; }
        public int Trg { get; set; }
        public int Type { get; set; }

        public BelugaSoundPlayVoice(Macro macro)
        {
            //this.Player = ParseInt(GetValue(macro, "Player"), 0);
            //this.Trg = ParseInt(GetValue(macro, "Trg"), 0); // Assuming Parse_SEQ_DEF_POS is equivalent to ParseInt
            //this.Type = ParseInt(GetValue(macro, "Type"), 0); // Assuming Parse_VOICE_TYPE is equivalent to ParseInt
        }
    }

    public class LabelBelugaSound : Macro
    {
        public LabelBelugaSound(Macro macro)
        {
            this.CommandNo = macro.CommandNo;
            this.Name = macro.Name;
            this.Values = macro.Values;
        }
    }
}
