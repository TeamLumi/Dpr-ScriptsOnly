using System;
using System.Runtime.InteropServices;
using Pml;
using Pml.PokePara;
using Pml.WazaData;

namespace Dpr.Battle.Logic
{
    public class BTL_POKEPARAM
    {
        public static void WAZADMG_REC_Setup(BTL_POKEPARAM.WAZADMG_REC rec, byte pokeID, BtlPokePos pokePos, ushort wazaID, byte wazaType, ushort damage, WazaDamageType damageType)
        {
        }

        public byte GetFormNo()
        {
            return default(byte);
        }

        public byte GetFriendship()
        {
            return default(byte);
        }

        public static byte PokeIDtoFreeFallCounter(byte pokeID)
        {
            return default(byte);
        }

        public static byte FreeFallCounterToPokeID(byte counter)
        {
            return default(byte);
        }

        private void flgbuf_clear(byte[] buf)
        {
        }

        private void flgbuf_set(byte[] buf, uint flagID)
        {
        }

        private void flgbuf_reset(byte[] buf, uint flagID)
        {
        }

        private bool flgbuf_get(byte[] buf, uint flagID)
        {
            return default(bool);
        }

        public BTL_POKEPARAM([Optional] FieldStatus fieldStatus)
        {
        }

        public void Dispose()
        {
        }

        public void Setup(in BTL_POKEPARAM.SetupParam setupParam)
        {
        }

        private void setupBySrcData(bool fReflectHP, bool fParamUpdate, bool fTokuseiUpdate, bool fWeightUpdate)
        {
        }

        private void setupBySrcDataBase(bool fTypeUpdate, bool fParamUpdate, bool isGMode)
        {
        }

        private ushort getBasePower(PowerID powerID, bool isGMode, bool isApplyRaidBossHpCoef = true)
        {
            return default(ushort);
        }

        private void updateWeight()
        {
        }

        private uint wazaWork_setupByPP(PokemonParam pp_src, bool fLinkSurface)
        {
            return default(uint);
        }

        private void wazaWork_ReflectToPP()
        {
        }

        private void wazaWork_ReflectFromPP()
        {
        }

        private void wazaWork_ClearSurface()
        {
        }

        private void wazaSet_ClearUsedFlag(BTL_POKEPARAM.WAZA_SET waza)
        {
        }

        private bool wazaCore_SetupByPP(BTL_POKEPARAM.WAZA_CORE core, PokemonParam pp, byte index)
        {
            return default(bool);
        }

        public void CopyFrom(in BTL_POKEPARAM srcParam, bool isCompletely = false)
        {
        }

        private void CORE_PARAM_Copy(BTL_POKEPARAM.CORE_PARAM dest, in BTL_POKEPARAM.CORE_PARAM src)
        {
        }

        public byte GetID()
        {
            return default(byte);
        }

        public ushort GetMonsNo()
        {
            return default(ushort);
        }

        public Seikaku GetSeikaku()
        {
            return Seikaku.GANBARIYA;
        }

        public ushort GetHenshinMonsNo()
        {
            return default(ushort);
        }

        public ushort GetHenshinFormNo()
        {
            return default(ushort);
        }

        public DefaultPowerUpDesc GetDefaultPowerUpDesc()
        {
            return null;
        }

        public DamageCause GetDeadCause()
        {
            return DamageCause.OTHER;
        }

        public byte GetDeadCausePokeID()
        {
            return default(byte);
        }

        public void SetDeadCause(DamageCause damageCause, byte damageCausePokeID)
        {
        }

        public void ClearDeadCause()
        {
        }

        public byte GetKillCount()
        {
            return default(byte);
        }

        public void SetKillCount(byte killCount)
        {
        }

        public void IncKillCount()
        {
        }

        public BtlSpecialPri GetSpActPriority()
        {
            return BtlSpecialPri.BTL_SPPRI_LOW;
        }

        public void SetSpActPriority(byte priority)
        {
        }

        private void resetSpActPriority()
        {
        }

        public PokemonParam GetSrcData()
        {
            return null;
        }

        public PokemonParam GetSrcDataConst()
        {
            return null;
        }

        public void SetViewSrcPokeID(byte fakeTargetPokeID)
        {
        }

        public byte GetViewSrcPokeID()
        {
            return default(byte);
        }

        private void effrank_Init(BTL_POKEPARAM.VARIABLE_PARAM rank)
        {
        }

        private void effrank_Reset(BTL_POKEPARAM.VARIABLE_PARAM rank)
        {
        }

        private bool effrank_ResetRankUp(BTL_POKEPARAM.VARIABLE_PARAM rank)
        {
            return default(bool);
        }

        private bool effrank_Recover(BTL_POKEPARAM.VARIABLE_PARAM rank)
        {
            return default(bool);
        }

        private void dmgrec_ClearWork()
        {
        }

        private void dmgrec_FwdTurn()
        {
        }

        private void confrontRec_Clear()
        {
        }

        public void Confront_Set(byte pokeID)
        {
        }

        public byte Confront_GetCount()
        {
            return default(byte);
        }

        public byte Confront_GetPokeID(byte idx)
        {
            return default(byte);
        }

        public int GetValue(BTL_POKEPARAM.ValueID vid)
        {
            return default(int);
        }

        public int GetValue_Base(BTL_POKEPARAM.ValueID vid)
        {
            return default(int);
        }

        public byte GetEffortValue(PowerID powerID)
        {
            return default(byte);
        }

        public bool IsEffortValueFull()
        {
            return default(bool);
        }

        public byte GetNativeTalentPower(PowerID powerID)
        {
            return default(byte);
        }

        private BTL_POKEPARAM.ValueID convertValueID(BTL_POKEPARAM.ValueID vid)
        {
            return BTL_POKEPARAM.ValueID.BPP_VALUE_NULL;
        }

        public bool IsHPFull()
        {
            return default(bool);
        }

        public bool IsDead()
        {
            return default(bool);
        }

        public bool IsFightEnable()
        {
            return default(bool);
        }

        public bool CheckSick(WazaSick sickType)
        {
            return default(bool);
        }

        public bool CheckNemuri(BTL_POKEPARAM.NemuriCheckMode checkMode)
        {
            return default(bool);
        }

        public bool CheckMoudoku()
        {
            return default(bool);
        }

        public WazaNo GetWazaLockID()
        {
            return WazaNo.NULL;
        }

        private void clearWazaSickWork(uint clearCode)
        {
        }

        public Sick GetPokeSick()
        {
            return Sick.NONE;
        }

        public ushort GetSickParam(WazaSick sick)
        {
            return default(ushort);
        }

        public BTL_SICKCONT GetSickCont(WazaSick sick)
        {
            return default(BTL_SICKCONT);
        }

        public byte GetSickTurnCount(WazaSick sick)
        {
            return default(byte);
        }

        public bool IsSickLastTurn(WazaSick sickType)
        {
            return default(bool);
        }

        public int CalcSickDamage(WazaSick sick)
        {
            return default(int);
        }

        public WazaNo GetKodawariWazaID()
        {
            return WazaNo.NULL;
        }

        public bool IsTokuseiDisabledByKagakuHenkaGas()
        {
            return default(bool);
        }

        public void ReflectToPP(bool fDefaultForm)
        {
        }

        private void wazaWork_UpdateNumber(BTL_POKEPARAM.WAZA_SET waza, WazaNo nextNumber, byte ppMax, bool fPermenent)
        {
        }

        private void wazaCore_UpdateNumber(BTL_POKEPARAM.WAZA_CORE core, WazaNo nextID, byte ppMax)
        {
        }

        private void clearHensin()
        {
        }

        private void clearUsedWazaFlag()
        {
        }

        private void clearCounter()
        {
        }

        public byte WAZA_GetCount()
        {
            return default(byte);
        }

        public byte WAZA_GetCount_Org()
        {
            return default(byte);
        }

        public byte WAZA_GetUsedCountInAlive()
        {
            return default(byte);
        }

        public byte WAZA_GetUsedCount()
        {
            return default(byte);
        }

        public byte WAZA_GetUsableCount()
        {
            return default(byte);
        }

        public WazaNo WAZA_GetID(byte idx)
        {
            return WazaNo.NULL;
        }

        public WazaNo WAZA_GetID_Org(byte idx)
        {
            return WazaNo.NULL;
        }

        public bool WAZA_CheckUsedInAlive(byte idx)
        {
            return default(bool);
        }

        public void WAZA_Copy(BTL_POKEPARAM bppDst)
        {
        }

        public byte WAZA_GetUsedCount(byte wazaIdx)
        {
            return default(byte);
        }

        public void WAZA_SetUsedCount(byte wazaIdx, byte value)
        {
        }

        public byte WAZA_GetKillCount(byte wazaIdx)
        {
            return default(byte);
        }

        public void WAZA_SetKillCount(byte wazaIdx, byte value)
        {
        }

        public byte WAZA_GetPPShort(byte idx)
        {
            return default(byte);
        }

        public byte WAZA_GetPPShort_Org(byte idx)
        {
            return default(byte);
        }

        public bool WAZA_CheckPPShortAny()
        {
            return default(bool);
        }

        public bool WAZA_CheckPPShortAny_Org()
        {
            return default(bool);
        }

        public ushort WAZA_GetPP(byte wazaIdx)
        {
            return default(ushort);
        }

        public ushort WAZA_GetPP_ByNumber(WazaNo waza)
        {
            return default(ushort);
        }

        public ushort WAZA_GetPP_Org(byte wazaIdx)
        {
            return default(ushort);
        }

        public ushort WAZA_GetMaxPP(byte wazaIdx)
        {
            return default(ushort);
        }

        public ushort WAZA_GetMaxPP_Org(byte wazaIdx)
        {
            return default(ushort);
        }

        public bool WAZA_IsPPFull(byte wazaIdx, bool fOrg)
        {
            return default(bool);
        }

        public void WAZA_DecrementPP(byte wazaIdx, byte value)
        {
        }

        public void WAZA_DecrementPP_Org(byte wazaIdx, byte value)
        {
        }

        public void WAZA_SetUsedFlag_Org(byte wazaIdx)
        {
        }

        public WazaNo WAZA_IncrementPP(byte wazaIdx, byte value)
        {
            return WazaNo.NULL;
        }

        public WazaNo WAZA_IncrementPP_Org(byte wazaIdx, byte value)
        {
            return WazaNo.NULL;
        }

        public bool WAZA_IsLinkOut(byte wazaIdx)
        {
            return default(bool);
        }

        public void WAZA_SetUsedFlag(byte wazaIdx)
        {
        }

        public void WAZA_UpdateID(byte wazaIdx, WazaNo waza, byte ppMax, bool fPermenent)
        {
        }

        public bool WAZA_IsUsable(WazaNo waza)
        {
            return default(bool);
        }

        public byte WAZA_SearchIdx(WazaNo waza)
        {
            return default(byte);
        }

        //private void splitTypeCore(out byte type1, out byte type2)
        //{
        //}

        public PokeTypePair GetPokeType()
        {
            return default(PokeTypePair);
        }

        public byte GetOriginalPokeType1()
        {
            return default(byte);
        }

        public byte GetOriginalPokeType2()
        {
            return default(byte);
        }

        public bool IsMatchType(byte type)
        {
            return default(bool);
        }

        public void SetBaseStatus(BTL_POKEPARAM.ValueID vid, ushort value)
        {
        }

        public int GetValue_Critical(BTL_POKEPARAM.ValueID vid)
        {
            return default(int);
        }

        public ushort GetItem()
        {
            return default(ushort);
        }

        public void SetItem(ushort itemID)
        {
        }

        public ushort GetItemEffective(in FieldStatus fldSim)
        {
            return default(ushort);
        }

        public ushort GetTotalTurnCount()
        {
            return default(ushort);
        }

        public void IncTotalTurnCount()
        {
        }

        public ushort GetTurnCount()
        {
            return default(ushort);
        }

        public ushort GetAppearTurn()
        {
            return default(ushort);
        }

        public bool TURNFLAG_Get(BTL_POKEPARAM.TurnFlag flagID)
        {
            return default(bool);
        }

        public bool CONTFLAG_Get(ContFlag flagID)
        {
            return default(bool);
        }

        public bool PERMFLAG_Get(BTL_POKEPARAM.PermFlag flagID)
        {
            return default(bool);
        }

        public void PERMFLAG_Set(BTL_POKEPARAM.PermFlag flagID)
        {
        }

        public ContFlag CONTFLAG_CheckWazaHide()
        {
            return ContFlag.CONTFLG_ACTION_DONE;
        }

        public bool IsWazaHide()
        {
            return default(bool);
        }

        public bool IsUsingFreeFall()
        {
            return default(bool);
        }

        public int GetHPRatio()
        {
            return default(int);
        }

        public void SetHPRatio(int ratio)
        {
        }

        public uint calcHpRatio(uint maxHP, int ratio)
        {
            return default(uint);
        }

        private uint getHPBeforeG()
        {
            return default(uint);
        }

        private sbyte getRankVaryStatus(BTL_POKEPARAM.ValueID type, out sbyte min, out sbyte max)
        {
            min = 0;
            max = 0;
            return default(sbyte);
        }

        public bool IsRankEffectValid(BTL_POKEPARAM.ValueID rankType, int volume)
        {
            return default(bool);
        }

        public int RankEffectUpLimit(BTL_POKEPARAM.ValueID rankType)
        {
            return default(int);
        }

        public int RankEffectDownLimit(BTL_POKEPARAM.ValueID rankType)
        {
            return default(int);
        }

        public bool IsRankEffectDowned()
        {
            return default(bool);
        }

        public byte RankUp(BTL_POKEPARAM.ValueID rankType, byte volume)
        {
            return default(byte);
        }

        private byte RankUp_Core(byte volume, ref sbyte ptr)
        {
            return default(byte);
        }

        public byte RankDown(BTL_POKEPARAM.ValueID rankType, byte volume)
        {
            return default(byte);
        }

        private byte RankDown_Core(byte volume, ref sbyte ptr)
        {
            return default(byte);
        }

        public void RankSet(BTL_POKEPARAM.ValueID rankType, byte value)
        {
        }

        private void RankSet_Core(byte value, ref sbyte ptr)
        {
        }

        public bool RankRecover()
        {
            return default(bool);
        }

        public void RankReset()
        {
        }

        public bool RankUpReset()
        {
            return default(bool);
        }

        public byte GetCriticalRank()
        {
            return default(byte);
        }

        public byte GetCriticalRankPure()
        {
            return default(byte);
        }

        public bool AddCriticalRank(int value)
        {
            return default(bool);
        }

        public void SetCriticalRank(byte rank)
        {
        }

        public void HpMinus(ushort value)
        {
        }

        public void HpPlus(ushort value)
        {
        }

        public void HpZero()
        {
        }

        public void TURNFLAG_Set(BTL_POKEPARAM.TurnFlag flagID)
        {
        }

        public void CONTFLAG_Set(ContFlag flagID)
        {
        }

        public void CONTFLAG_Clear(ContFlag flagID)
        {
        }

        public void SetWazaSick(WazaSick sick, in BTL_SICKCONT contParam)
        {
        }

        public bool WazaSick_TurnCheck(WazaSick sick, out BTL_SICKCONT pOldContDest, out bool fCured)
        {
            pOldContDest = default;
            fCured = false;
            return default(bool);
        }

        public bool CheckNemuriWakeUp()
        {
            return default(bool);
        }

        public bool CheckKonranWakeUp()
        {
            return default(bool);
        }

        public void CurePokeSick()
        {
        }

        private void cureDependSick(WazaSick sickID)
        {
        }

        public void CureWazaSick(WazaSick sick)
        {
        }

        public void CureWazaSickDependPoke(byte depend_pokeID)
        {
        }

        public void SetAppearTurn(ushort turn)
        {
        }

        public void TurnCheck()
        {
        }

        public void TURNFLAG_ForceOff(BTL_POKEPARAM.TurnFlag flagID)
        {
        }

        public void Clear_ForDead()
        {
        }

        public void Clear_ForOut()
        {
        }

        public void Clear_ForIn()
        {
        }

        public void CopyBatonTouchParams(BTL_POKEPARAM user)
        {
        }

        public bool ChangePokeType(PokeTypePair type, BTL_POKEPARAM.ExTypeCause exTypeCause)
        {
            return default(bool);
        }

        public void ExPokeType(byte type, BTL_POKEPARAM.ExTypeCause exTypeCause)
        {
        }

        public byte GetExType()
        {
            return default(byte);
        }

        public bool HaveExType()
        {
            return default(bool);
        }

        public BTL_POKEPARAM.ExTypeCause GetExTypeCause()
        {
            return BTL_POKEPARAM.ExTypeCause.EXTYPE_CAUSE_NONE;
        }

        public void ChangeTokusei(TokuseiNo tok)
        {
        }

        public void ChangeForm(byte formNo, bool dontResetFormByOut = false)
        {
        }

        private void correctMaxHP()
        {
        }

        public void RemoveItem()
        {
        }

        public void ConsumeItem(ushort itemID)
        {
        }

        public void ClearConsumedItem()
        {
        }

        public ushort GetConsumedItem()
        {
            return default(ushort);
        }

        public void UpdateWazaProcResult(BtlPokePos actTargetPos, byte actWazaType, bool fActEnable, WazaNo actWaza, WazaNo orgWaza)
        {
        }

        public uint GetWazaContCounter()
        {
            return default(uint);
        }

        public WazaNo GetPrevWazaID()
        {
            return WazaNo.NULL;
        }

        public byte GetPrevWazaType()
        {
            return default(byte);
        }

        public WazaNo GetPrevOrgWazaID()
        {
            return WazaNo.NULL;
        }

        public BtlPokePos GetPrevTargetPos()
        {
            return BtlPokePos.POS_1ST_0;
        }

        public bool GetBtlInFlag()
        {
            return default(bool);
        }

        public void SetWeight(ushort weight)
        {
        }

        public ushort GetWeight()
        {
            return default(ushort);
        }

        public void WAZADMGREC_Add(BTL_POKEPARAM.WAZADMG_REC rec)
        {
        }

        public byte WAZADMGREC_GetCount(byte turn_ridx)
        {
            return default(byte);
        }

        public bool WAZADMGREC_Get(byte turn_ridx, byte rec_ridx, BTL_POKEPARAM.WAZADMG_REC dst)
        {
            return default(bool);
        }

        public void COUNTER_Set(BTL_POKEPARAM.Counter cnt, byte value)
        {
        }

        public void COUNTER_Inc(BTL_POKEPARAM.Counter cnt)
        {
        }

        public byte COUNTER_Get(BTL_POKEPARAM.Counter cnt)
        {
            return default(byte);
        }

        public void PERMCOUNTER_Set(BTL_POKEPARAM.PermCounter counter, uint value)
        {
        }

        public void PERMCOUNTER_Add(BTL_POKEPARAM.PermCounter counter, uint value)
        {
        }

        public void PERMCOUNTER_Inc(BTL_POKEPARAM.PermCounter counter)
        {
        }

        public uint PERMCOUNTER_Get(BTL_POKEPARAM.PermCounter counter)
        {
            return default(uint);
        }

        public bool AddExp(uint exp)
        {
            return default(bool);
        }

        public uint GetExpMargin()
        {
            return default(uint);
        }

        public void ReflectByPP()
        {
        }

        public bool IsFakeEnable()
        {
            return default(bool);
        }

        public void FakeDisable()
        {
        }

        public byte GetFakeTargetPokeID()
        {
            return default(byte);
        }

        public bool HENSIN_CheckEnable(BTL_POKEPARAM target)
        {
            return default(bool);
        }

        public void HENSIN_Set(BTL_POKEPARAM target)
        {
        }

        private void henshinCopyFrom(in BTL_POKEPARAM src)
        {
        }

        public bool HENSIN_Check()
        {
            return default(bool);
        }

        public void MIGAWARI_Create(ushort migawariHP)
        {
        }

        public void MIGAWARI_Delete()
        {
        }

        public bool MIGAWARI_IsExist()
        {
            return default(bool);
        }

        public uint MIGAWARI_GetHP()
        {
            return default(uint);
        }

        public bool MIGAWARI_AddDamage(ref ushort damage)
        {
            return default(bool);
        }

        public void CONFRONT_REC_Set(byte pokeID)
        {
        }

        public byte CONFRONT_REC_GetCount()
        {
            return default(byte);
        }

        public byte CONFRONT_REC_GetPokeID(byte idx)
        {
            return default(byte);
        }

        public bool CONFRONT_REC_IsMatch(byte pokeID)
        {
            return default(bool);
        }

        public void SetCaptureBallID(ushort ballItemID)
        {
        }

        public void CombiWaza_SetParam(byte combiPokeID, WazaNo combiUsedWaza)
        {
        }

        public bool CombiWaza_GetParam(out byte combiPokeID, out WazaNo combiUsedWaza)
        {
            combiPokeID = 0;
            combiUsedWaza = default;
            return default(bool);
        }

        public bool CombiWaza_IsSetParam()
        {
            return default(bool);
        }

        public void CombiWaza_ClearParam()
        {
        }

        public bool IsMatchTokusei(TokuseiNo tokusei)
        {
            return default(bool);
        }

        public bool HavePokerus()
        {
            return default(bool);
        }

        public void AddEffortPower(PowerID id, byte value)
        {
        }

        private void doryoku_InitParam(BTL_POKEPARAM.DORYOKU_PARAM work, PokemonParam pp)
        {
        }

        private void doryoku_AddPower(BTL_POKEPARAM.DORYOKU_PARAM work, PowerID powID, byte value)
        {
        }

        private void doryoku_PutToPP(BTL_POKEPARAM.DORYOKU_PARAM work, PokemonParam pp)
        {
        }

        //private ref byte doryoku_ParamIDtoValueAdrs(BTL_POKEPARAM.DORYOKU_PARAM work, PowerID powID)
        //{
            //return null;
        //}

        public void AddEffortG(byte value)
        {
        }

        public void SetRaidBoss(byte grade, in RaidBossDesc desc)
        {
        }

        public bool IsRaidBoss()
        {
            return default(bool);
        }

        public RaidBossParam GetRaidBossParam()
        {
            return null;
        }

        public bool IsGMode()
        {
            return default(bool);
        }

        public bool IsSpecialG()
        {
            return default(bool);
        }

        public bool CanStartG()
        {
            return default(bool);
        }

        public void StartGMode()
        {
        }

        public void EndGMode()
        {
        }

        public byte GetGModePassedTurnCount()
        {
            return default(byte);
        }

        public void IncGModePassedTurnCount()
        {
        }

        public bool IsSpecialGEnable()
        {
            return default(bool);
        }

        public void ReflectForExpUI([Optional] PokemonParam pp)
        {
        }

        public const int WAZADMG_REC_TURN_MAX = 3;

        public const int WAZADMG_REC_MAX = 6;

        public const int RANK_STATUS_MIN = 0;

        public const int RANK_STATUS_MAX = 12;

        public const int RANK_STATUS_DEFAULT = 6;

        public const uint PERMCOUNTER_MAX = 65535U;

        private const int TURNFLG_BUF_SIZE = 4;

        private const int CONTFLG_BUF_SIZE = 4;

        private const int PERMFLG_BUF_SIZE = 1;

        private const int TURNCOUNT_NULL = 10000;

        private BTL_POKEPARAM.CORE_PARAM m_coreParam;

        private BTL_POKEPARAM.BASE_PARAM m_baseParam;

        private BTL_POKEPARAM.VARIABLE_PARAM m_varyParam;

        private BTL_POKEPARAM.DORYOKU_PARAM m_doryokuParam;

        private BTL_POKEPARAM.WAZA_SET[] m_waza;

        private ushort m_tokusei;

        private ushort m_weight;

        private byte m_wazaCnt;

        private byte m_formNo;

        private byte m_friendship;

        private byte m_criticalRank;

        private byte m_usedWazaCount;

        private byte m_prevWazaType;

        private byte m_spActPriority;

        private ushort m_turnCount;

        private ushort m_appearedTurn;

        private ushort m_wazaContCounter;

        private BtlPokePos m_prevTargetPos;

        private WazaNo m_prevActWazaID;

        private WazaNo m_prevSelectWazaID;

        private WazaNo m_prevDamagedWaza;

        private byte[] m_turnFlag;

        private byte[] m_contFlag;

        private byte[] m_permFlag;

        private byte[] m_counter;

        private uint[] m_permCounter;

        private BTL_POKEPARAM.WAZADMG_REC[][] m_wazaDamageRec;

        private byte[] m_dmgrecCount;

        private byte m_dmgrecTurnPtr;

        private byte m_dmgrecPtr;

        private ushort m_migawariHP;

        private WazaNo m_combiWazaID;

        private byte m_combiPokeID;

        private readonly FieldStatus m_fldSim;

        private const int SICK_ID = 6;

        private static BTL_POKEPARAM.WAZA_SET[] HENSIN_Set_wazaWork;

        private static byte s_DmyByte;

        public class SetupParam
        {
            public SetupParam()
            {
            }

            public PokemonParam srcParam;

            public DefaultPowerUpDesc defaultPowerUpDesc;

            public byte pokeID;

            public byte friendship;

            public bool isForceGEnable;
        }

        public enum ValueID
        {
            BPP_VALUE_NULL,
            BPP_ATTACK_RANK,
            BPP_DEFENCE_RANK,
            BPP_SP_ATTACK_RANK,
            BPP_SP_DEFENCE_RANK,
            BPP_AGILITY_RANK,
            BPP_HIT_RATIO,
            BPP_AVOID_RATIO,
            BPP_ATTACK,
            BPP_DEFENCE,
            BPP_SP_ATTACK,
            BPP_SP_DEFENCE,
            BPP_AGILITY,
            BPP_HP,
            BPP_HP_BEFORE_G,
            BPP_MAX_HP,
            BPP_MAX_HP_BEFORE_G,
            BPP_LEVEL,
            BPP_TOKUSEI,
            BPP_TOKUSEI_EFFECTIVE,
            BPP_SEX,
            BPP_SEIKAKU,
            BPP_PERSONAL_RAND,
            BPP_EXP,
            BPP_MONS_POW,
            BPP_MONS_AGILITY,
            BPP_RANKVALUE_START = 1,
            BPP_RANKVALUE_END = 7,
            BPP_RANKVALUE_RANGE = 7
        }

        public class WAZADMG_REC
        {
            public void CopyFrom(BTL_POKEPARAM.WAZADMG_REC src)
            {
            }

            public void Clear()
            {
            }

            public WAZADMG_REC()
            {
            }

            public ushort wazaID;

            public ushort damage;

            public WazaDamageType damageType;

            public byte wazaType;

            public byte pokeID;

            public BtlPokePos pokePos;
        }

        public enum TurnFlag
        {
            TURNFLG_ACTION_START,
            TURNFLG_ACTION_DONE,
            TURNFLG_DAMAGED,
            TURNFLG_WAZAPROC_DONE,
            TURNFLG_SHRINK,
            TURNFLG_KIAI_READY,
            TURNFLG_KIAI_SHRINK,
            TURNFLG_MAMORU,
            TURNFLG_ITEM_CONSUMED,
            TURNFLG_ITEM_CANT_USE,
            TURNFLG_COMBIWAZA_READY,
            TURNFLG_TAMEHIDE_OFF,
            TURNFLG_MOVED,
            TURNFLG_TURNCHECK_SICK_PASSED,
            TURNFLG_HITRATIO_UP,
            TURNFLG_NAGETUKERU_USING,
            TURNFLG_MAMORU_ONLY_DAMAGE_WAZA,
            TURNFLG_RESERVE_ITEM_SPEND,
            TURNFLG_APPEARED_BY_POKECHANGE,
            TURNFLG_CANT_ACTION,
            TURNFLG_TRAPPSHELL_READY,
            TURNFLG_GWALL_BROKEN,
            TURNFLG_RAIDBOSS_REINFORCE_DONE,
            TURNFLG_RAIDBOSS_ANGRY,
            TURNFLG_RAIDBOSS_ANGRY_WAZA_ADD_DONE,
            TURNFLG_RANK_UP,
            TURNFLG_RANK_DOWN,
            TURNFLG_MAX
        }

        public enum PermFlag
        {
            PERMFLAG_ATE_KINOMI,
            PERMFLAG_LEVELUP,
            PERMFLAG_KIZUNAHENGE_DONE,
            PERMFLAG_MAX,
            PERMFLAG_NULL = 3
        }

        public enum Counter
        {
            COUNTER_TAKUWAERU,
            COUNTER_TAKUWAERU_DEF,
            COUNTER_TAKUWAERU_SPDEF,
            COUNTER_MAMORU,
            COUNTER_FREEFALL,
            COUNTER_TURN_FROM_GWALL_BROKEN,
            COUNTER_MAX
        }

        public enum PermCounter : byte
        {
            CRITICAL,
            DEAD,
            TOTAL_DAMAGE_RECIEVED,
            GSHOCK_NEKONIKOBAN_USE_COUNT,
            NUM
        }

        public enum ExTypeCause
        {
            EXTYPE_CAUSE_NONE,
            EXTYPE_CAUSE_HALLOWEEN,
            EXTYPE_CAUSE_MORINONOROI
        }

        public enum NemuriCheckMode
        {
            NEMURI_CHECK_ONLY_SICK,
            NEMURI_CHECK_INCLUDE_ZETTAINEMURI
        }

        private class WAZA_CORE
        {
            public void CopyFrom(BTL_POKEPARAM.WAZA_CORE src)
            {
            }

            public WAZA_CORE()
            {
            }

            public WazaNo number;

            public byte pp;

            public byte ppMax;

            public byte ppCnt;

            public bool usedFlag;

            public bool usedFlagFix;

            public byte usedCount;

            public byte killCount;
        }

        private class WAZA_SET
        {
            public void CopyFrom(BTL_POKEPARAM.WAZA_SET src)
            {
            }

            public WAZA_SET()
            {
            }

            public BTL_POKEPARAM.WAZA_CORE truth;

            public BTL_POKEPARAM.WAZA_CORE surface;

            public bool fLinked;
        }

        private class GModeParam
        {
            public void CopyFrom(BTL_POKEPARAM.GModeParam src)
            {
            }

            public GModeParam()
            {
            }

            public bool isGMode;

            public byte passedTurnCount;
        }

        private class CORE_PARAM
        {
            public CORE_PARAM()
            {
            }

            public PokemonParam ppSrc;

            public uint personalRand;

            public uint exp;

            public ushort monsno;

            public ushort formno;

            public ushort hpMax;

            public ushort hp;

            public ushort item;

            public ushort usedItem;

            public ushort defaultTokusei;

            public byte level;

            public byte myID;

            public byte mons_pow;

            public byte mons_agility;

            public byte seikaku;

            public byte native_talent_hp;

            public byte native_talent_atk;

            public byte native_talent_def;

            public byte native_talent_spatk;

            public byte native_talent_spdef;

            public byte native_talent_agi;

            public ushort defaultFormNo;

            public bool fHensin;

            public bool fFakeEnable;

            public bool fBtlIn;

            public bool fDontResetFormByByOut;

            public bool fForceGEnable;

            public BTL_SICKCONT[] sickCont;

            public byte[] wazaSickCounter;

            public byte confrontRecCount;

            public byte[] confrontRec;

            public ushort totalTurnCount;

            public byte fakeViewTargetPokeId;

            public DefaultPowerUpDesc defaultPowerUpDesc;

            public DamageCause deadCause;

            public byte deadCausePokeID;

            public byte killCount;

            public bool isRaidBoss;

            public RaidBossParam raidBossParam;

            public BTL_POKEPARAM.GModeParam gParam;
        }

        private class BASE_PARAM
        {
            public void CopyFrom(BTL_POKEPARAM.BASE_PARAM src)
            {
            }

            public BASE_PARAM()
            {
            }

            public ushort monsno;

            public ushort formno;

            public ushort attack;

            public ushort defence;

            public ushort sp_attack;

            public ushort sp_defence;

            public ushort agility;

            public byte type1;

            public byte type2;

            public byte type_ex;

            public byte sex;

            public BTL_POKEPARAM.ExTypeCause type_ex_cause;
        }

        private class VARIABLE_PARAM
        {
            public void CopyFrom(BTL_POKEPARAM.VARIABLE_PARAM src)
            {
            }

            public VARIABLE_PARAM()
            {
            }

            public sbyte attack;

            public sbyte defence;

            public sbyte sp_attack;

            public sbyte sp_defence;

            public sbyte agility;

            public sbyte hit;

            public sbyte avoid;
        }

        private class DORYOKU_PARAM
        {
            public void CopyFrom(BTL_POKEPARAM.DORYOKU_PARAM src)
            {
            }

            public DORYOKU_PARAM()
            {
            }

            public ushort srcSum;

            public byte srcHp;

            public byte srcPow;

            public byte srcDef;

            public byte srcAgi;

            public byte srcSpPow;

            public byte srcSpDef;

            public byte srcG;

            public bool bPokerus;

            public bool bModified;
        }

        private enum SickWorkClearCode
        {
            SICKWORK_CLEAR_ALL,
            SICKWORK_CLEAR_WITHOUT_SLEEP,
            SICKWORK_CLEAR_ONLY_WAZASICK
        }
    }
}
