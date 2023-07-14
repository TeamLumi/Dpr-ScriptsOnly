using System;
using DG.Tweening;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;

namespace Dpr.Battle.Logic
{
    public class DefaultPowerUpDesc
    {
        public DefaultPowerUpDesc()
        {
        }

        public DefaultPowerUpReason reason;

        public byte rankUp_Attack;

        public byte rankUp_Defense;

        public byte rankUp_SpAttack;

        public byte rankUp_SpDefense;

        public byte rankUp_Agility;

        public Vector4 aura_color;
    }
}
