using System;
using UnityEngine;

namespace Pml.PokePara
{
    public class CoreParam
    {
        public int DATASIZE;

        public object sCoreSerializeBuffer;

        public byte TOKUSEI_INDEX_ERROR;

        public byte BIRTH_FRIENDSHIP;

        public object m_coreData;

        public object m_calcData;

        public GameObject m_accessor;

        public CoreParam()
        {
        }

        public CoreParam(object monsno, ushort level, bool id)
        {
        }

        public CoreParam(object spec)
        {
        }

        public byte[] GetCoreData()
        {
            return (byte[])m_coreData;
        }

        public object GetCalcData()
        {
            return null;
        }

        public object GetAccessor()
        {
            return null;
        }

        public static sbyte GetPowerTransformBySeikaku(ushort seikaku, object powerId)
        {
            return 0;
        }

        public static void CheckPublicDataSize()
        {
        }

        public static bool IsRareFromValue(uint id, uint colorRnd)
        {
            return false;
        }

        public uint GetPower(object powerId)
        {
            return 0U;
        }

        public uint GetMaxHp()
        {
            return 0U;
        }

        public uint GetHp()
        {
            return 0U;
        }

        public void SetHp(uint value)
        {
        }

        public void ReduceHp(uint value)
        {
        }

        public void ReduceNowHp(uint value)
        {
        }

        public void RecoverHp(uint value)
        {
        }

        public void RecoverHpFull()
        {
        }

        public bool IsHpFull()
        {
            return false;
        }

        public bool IsHpZero()
        {
            return false;
        }

        public void RecoverAll()
        {
        }

        public void SetMaxHp(uint value)
        {
        }

        protected void SetAtk(ushort value)
        {
        }

        protected void SetDef(ushort value)
        {
        }

        protected void SetSpAtk(ushort value)
        {
        }

        protected void SetSpDef(ushort value)
        {
        }

        protected void SetAgi(ushort value)
        {
        }

        public bool HaveSick()
        {
            return false;
        }

        public object GetSick()
        {
            return null;
        }

        public void SetSick(object sick)
        {
        }

        public void RecoverSick()
        {
        }

        public uint GetLevel()
        {
            return 0U;
        }

        public uint GetExp()
        {
            return 0U;
        }

        public void SetExp(uint value)
        {
        }

        public void AddExp(uint value)
        {
        }

        public uint GetExpForCurrentLevel()
        {
            return 0U;
        }

        public uint GetExpForNextLevel()
        {
            return 0U;
        }

        public void LevelUp(byte upVal)
        {
        }

        public uint GetBasicPower(object powerID)
        {
            return 0U;
        }

        public uint GetNativeTalentPower(object powerId)
        {
            return 0U;
        }

        public uint GetTalentPower(object powerId)
        {
            return 0U;
        }

        public void ChangeTalentPower(object powerId, uint value)
        {
        }

        public uint GetTalentPowerMaxNum()
        {
            return 0U;
        }

        public bool IsTrainingDone(object powerId)
        {
            return false;
        }

        public void SetTrainingDone(object powerId)
        {
        }

        public uint GetEffortPower(object powerId)
        {
            return 0U;
        }

        public uint GetTotalEffortPower()
        {
            return 0U;
        }

        public void ChangeEffortPower(object powerId, uint value)
        {
        }

        public void AddEffortPower(object powerId, uint value)
        {
        }

        public void SubEffortPower(object powerId, uint value)
        {
        }

        public object GetGState()
        {
            return null;
        }

        public void SetGState(object state)
        {
        }

        public bool IsG()
        {
            return false;
        }

        public void ChangeEffortG(byte value)
        {
        }

        public byte GetEffortG()
        {
            return 0;
        }

        public void AddEffortG(uint value)
        {
        }

        public void SubEffortG(uint value)
        {
        }

        public uint GetPower_G(object powerID)
        {
            return 0U;
        }

        public uint GetPower_NotG(object powerID)
        {
            return 0U;
        }

        public bool IsSpecialGEnable()
        {
            return false;
        }

        public void SetSpecialGEnable()
        {
        }

        public void SetSpecialGDisable()
        {
        }

        public object GetMonsNo()
        {
            return null;
        }

        public ushort GetFormNo()
        {
            //return null;
            return (ushort)0;
        }

        public void ChangeMonsNo(object newMonsno, ushort newFormno)
        {
        }

        public object GetWazaNo(byte index)
        {
            return null;
        }

        public byte GetWazaCount()
        {
            return 0;
        }

        public bool HaveWaza(object wazano)
        {
            return false;
        }

        public byte GetWazaIndex(object wazano)
        {
            return 0;
        }

        public void SetDefaultWaza()
        {
        }

        public void PushWaza(object wazano)
        {
        }

        public void SetWaza(byte wazaIndex, object wazano)
        {
        }

        public void RemoveWaza(byte wazaIndex)
        {
        }

        public void RemoveDuplicatedWaza()
        {
        }

        public void ExchangeWazaPos(byte pos1, byte pos2)
        {
        }

        public void CloseUpWazaPos()
        {
        }

        public bool CheckWazaMachine(uint machineNo)
        {
            return false;
        }

        public bool CheckWazaRecord(uint recordNo)
        {
            return false;
        }

        public bool CheckWazaOshie(uint oshieNo)
        {
            return false;
        }

        public bool CheckWazaOshie(object wazano)
        {
            return false;
        }

        public object GetTamagoWazaNo(byte index)
        {
            return null;
        }

        public void SetTamagoWazaNo(byte index, object wazano)
        {
        }

        public void ClearTamagoWaza()
        {
        }

        public void InheriteTamagoWaza(object teacher)
        {
        }

        public object AddWazaIfEmptyExist(object wazano)
        {
            return null;
        }

        public object LearnNewWazaOnCurrentLevel(object sameLevelIndex, object newWazano, object work)
        {
            return null;
        }

        public object LearnNewWazaOnLevel(byte level, object sameLevelIndex, object newWazano, object work)
        {
            return null;
        }

        public object LearnNewWazaOnEvolution(object learnIndex, object newWazano, object work)
        {
            return null;
        }

        public object CollectRemindableWaza()
        {
            return null;
        }

        public uint GetWazaPP(byte wazaIndex)
        {
            return 0U;
        }

        public uint GetWazaMaxPP(byte index)
        {
            return 0U;
        }

        public void SetWazaPP(byte wazaIndex, byte value)
        {
        }

        public void ReduceWazaPP(byte wazaIndex, byte value)
        {
        }

        public void RecoverWazaPP(byte wazaIndex)
        {
        }

        public void RecoverWazaPP(byte wazaIndex, byte recvValue)
        {
        }

        public void RecoverWazaPPAll()
        {
        }

        public bool CanUsePointUp(byte wazaIndex)
        {
            return false;
        }

        public void UsePointUp(byte wazaIndex)
        {
        }

        public uint GetWazaPPUpCount(byte wazaIndex)
        {
            return 0U;
        }

        public void SetWazaPPUpCount(byte wazaIndex, byte value)
        {
        }

        public void IncWazaPPUpCount(byte wazaIndex)
        {
        }

        public bool GetWazaRecordFlag(byte recordIndex)
        {
            return false;
        }

        public void SetWazaRecordFlag(byte recordIndex)
        {
        }

        public void RemoveWazaRecordFlag(byte recordIndex)
        {
        }

        public void ClearWazaRecordFlag()
        {
        }

        public object GetSex()
        {
            return null;
        }

        public byte GetSexVector()
        {
            return 0;
        }

        public object GetSexType()
        {
            return null;
        }

        public void ChangeSex(object newSex)
        {
        }

        public object GetSeikaku()
        {
            return null;
        }

        public void ChangeSeikaku(object seikaku)
        {
        }

        public bool IsSeikakuHigh()
        {
            return false;
        }

        public bool IsSeikakuLow()
        {
            return false;
        }

        public object GetSeikakuHosei()
        {
            return null;
        }

        public void ChangeSeikakuHosei(object seikaku)
        {
        }

        public object GetTokuseiNo()
        {
            return null;
        }

        public byte GetTokuseiIndex()
        {
            return 0;
        }

        public byte GetTokuseiIndexStrict()
        {
            return 0;
        }

        public void FlipTokuseiIndex()
        {
        }

        public void SetTokusei3rd()
        {
        }

        public void SetTokuseiIndex(byte tokuseiIndex)
        {
        }

        public void SetFavoriteFlag(bool flag)
        {
        }

        public bool GetFavoriteFlag()
        {
            return false;
        }

        public bool CompareOwnerInfo(object ownerInfo)
        {
            return false;
        }

        public bool UpdateOwnerInfo(object ownerInfo)
        {
            return false;
        }

        public bool IsOwnedOriginalParent()
        {
            return false;
        }

        public bool HaveNickName()
        {
            return false;
        }

        public string GetNickName()
        {
            return "";
        }

        public void SetNickName(string nickName)
        {
        }

        public void SetDefaultNickName()
        {
        }

        public bool IsDefaultNickName()
        {
            return false;
        }

        public uint GetFriendship()
        {
            return 0U;
        }

        public void SetFriendship(uint value)
        {
        }

        public void AddFriendship(uint value)
        {
        }

        public void SubFriendship(uint value)
        {
        }

        public uint GetOriginalFriendship()
        {
            return 0U;
        }

        public void SetOriginalFriendship(uint value)
        {
        }

        public void AddOriginalFriendship(uint value)
        {
        }

        public void SubOriginalFriendship(uint value)
        {
        }

        public ushort GetOthersFriendshipTrainerID()
        {
            //return null;
            return ushort.MaxValue;
        }

        public uint GetOthersFriendship()
        {
            return 0U;
        }

        public void SetOthersFriendship(uint value)
        {
        }

        public void AddOthersFriendship(uint value)
        {
        }

        public void SubOthersFriendship(uint value)
        {
        }

        public bool IsEgg(object type)
        {
            return false;
        }

        public void SetEggFlag()
        {
        }

        public void ChangeEgg()
        {
        }

        public void Birth()
        {
        }

        public ushort GetItem()
        {
            //return null;
            return (ushort)0;
        }

        public void SetItem(ushort itemno)
        {
        }

        public void RemoveItem()
        {
        }

        public void Evolve(object nextMonsno, uint routeIndex)
        {
        }

        public bool CanEvolve(object situation, object party, object nextMonsno, object rootNum)
        {
            return false;
        }

        public bool CanEvolveByItem(object situation, ushort itemno, object nextMonsno, object rootNum)
        {
            return false;
        }

        public bool CanEvolveByTrade(object pairPoke, object nextMonsno, object rootNum)
        {
            return false;
        }

        public bool CanEvolveByEvent(object situation, object party, object nextMonsno, object rootNum)
        {
            return false;
        }

        public bool HaveEvolutionRoot()
        {
            return false;
        }

        public void ChangeFormNo(ushort nextFormno, object pResult)
        {
        }

        public ushort GetNextFormNoFromHoldItem(ushort holdItemno)
        {
            //return null;
            return 0;
        }

        public bool RegulateFormParams()
        {
            return false;
        }

        public bool IsRare()
        {
            return false;
        }

        public uint GetRareRnd()
        {
            return 0U;
        }

        public object GetRareType()
        {
            return null;
        }

        public uint GetID()
        {
            return 0U;
        }

        public uint GetPersonalRnd()
        {
            return 0U;
        }

        public uint GetCheckSum()
        {
            return 0U;
        }

        public void SetID(uint id)
        {
        }

        public void SetRare()
        {
        }

        public void SetNotRare()
        {
        }

        public void SetRareType(object type)
        {
        }

        public object GetType1()
        {
            return null;
        }

        public object GetType2()
        {
            return null;
        }

        public string GetParentName()
        {
            return "";
        }

        public void SetParentName(string name)
        {
        }

        public object GetParentSex()
        {
            return null;
        }

        public void SetParentSex(object sex)
        {
        }

        public uint GetMemories(object memoriesKind)
        {
            return 0U;
        }

        public void SetMemories(object memoriesKind, uint value)
        {
        }

        public string GetPastParentsName()
        {
            return "";
        }

        public void SetPastParentsName(string name)
        {
        }

        public object GetPastParentsSex()
        {
            return null;
        }

        public void SetPastParentsSex(object sex)
        {
        }

        public byte GetPastParentsLangID()
        {
            return 0;
        }

        public void SetPastParentsLangID(byte langID)
        {
        }

        public byte GetCondition(object cond)
        {
            return 0;
        }

        public void SetCondition(object cond, byte value)
        {
        }

        public bool IsBoxMarkSet()
        {
            return false;
        }

        public bool IsBoxMarkSet(object mark)
        {
            return false;
        }

        public void SetBoxMark(object mark, object color)
        {
        }

        public void RemoveBoxMark(object mark)
        {
        }

        public object GetBoxMark(object mark)
        {
            return null;
        }

        public void RemoveAllBoxMark()
        {
        }

        public void SetAllBoxMark(object markContainer)
        {
        }

        public void GetAllBoxMark(object markContainer)
        {
        }

        public uint GetLangId()
        {
            return 0U;
        }

        public void SetLangId(uint langId)
        {
        }

        public uint GetCassetteVersion()
        {
            return 0U;
        }

        public void SetCassetteVersion(uint version)
        {
        }

        public uint GetGetBall()
        {
            return 0U;
        }

        public void SetGetBall(uint value)
        {
        }

        public byte GetBattleRomMark()
        {
            return 0;
        }

        public void SetBattleRomMark(byte battleRomMark)
        {
        }

        public byte GetNadenadeValue()
        {
            return 0;
        }

        public void SetNadenadeValue(byte value)
        {
        }

        public void AddNadenadeValue(byte value)
        {
        }

        public void SubNadenadeValue(byte value)
        {
        }

        public object GetMezapaType()
        {
            return null;
        }

        public uint GetMezapaPower()
        {
            return 0U;
        }

        public object JudgeTaste(object taste)
        {
            return null;
        }

        public bool HaveRibbon(uint ribbonNo)
        {
            return false;
        }

        public void SetRibbon(uint ribbonNo)
        {
        }

        public void RemoveRibbon(uint ribbonNo)
        {
        }

        public void RemoveAllRibbon()
        {
        }

        public void SetLumpingRibbon(object ribbonId, uint num)
        {
        }

        public void SetLumpingRibbon(uint ribbonNo, uint num)
        {
        }

        public uint GetLumpingRibbon(object ribbonId)
        {
            return 0U;
        }

        public uint GetLumpingRibbon(uint ribbonNo)
        {
            return 0U;
        }

        public bool IsEquipRibbonExist()
        {
            return false;
        }

        public byte GetEquipRibbonNo()
        {
            return 0;
        }

        public void SetEquipRibbonNo(byte ribbonNo)
        {
        }

        public bool HavePokerusJustNow()
        {
            return false;
        }

        public bool HavePokerusUntilNow()
        {
            return false;
        }

        public bool HavePokerusPast()
        {
            return false;
        }

        public void CatchPokerus()
        {
        }

        public void InfectPokerusWith(object target)
        {
        }

        public void DecreasePokerusDayCount(int passedDayCount)
        {
        }

        public uint GetPokerus()
        {
            return 0U;
        }

        public void SetPokerus(uint pokerus)
        {
        }

        public bool GetEventPokeFlag()
        {
            return false;
        }

        public void SetEventPokeFlag(bool flag)
        {
        }

        public bool HaveOfficialBattleRights()
        {
            return false;
        }

        public void GrantOfficialBattleRights()
        {
        }

        public void RemoveAllRotomWaza()
        {
        }

        public void SetRotomWaza(byte wazaIndex)
        {
        }

        public object CheckLoveLevel(object partner)
        {
            return null;
        }

        public bool GetPokeJobFlag(byte jobIndex)
        {
            return false;
        }

        public void SetPokeJobFlag(byte jobIndex)
        {
        }

        public void RemovePokeJobFlag(byte jobIndex)
        {
        }

        public void ClearPokeJobFlag()
        {
        }

        public byte GetCampFriendship()
        {
            return 0;
        }

        public void SetCampFriendship(uint value)
        {
        }

        public void AddCampFriendship(uint value)
        {
        }

        public void SubCampFriendship(uint value)
        {
        }

        public byte GetEnjoy()
        {
            return 0;
        }

        public void SetEnjoy(uint value)
        {
        }

        public void AddEnjoy(byte value)
        {
        }

        public void SubEnjoy(byte value)
        {
        }

        public uint GetPalma()
        {
            return 0U;
        }

        public void SetPalma(uint value)
        {
        }

        public bool StartFastMode()
        {
            return false;
        }

        public bool EndFastMode(bool validFlag)
        {
            return false;
        }

        public bool IsFastMode()
        {
            return false;
        }

        public void Clear()
        {
        }

        public bool IsNull()
        {
            return false;
        }

        public bool HaveCalcParam()
        {
            return false;
        }

        public void CopyFrom(object pSrcParam)
        {
        }

        public void RecalculateCalcData()
        {
        }

        public virtual void Serialize_Core(int buffer)
        {
        }

        public virtual void Serialize_Core(object buffer)
        {
        }

        public virtual void Deserialize_Core(int serializedData)
        {
        }

        public virtual void Deserialize_Core(object serializedData)
        {
        }

        protected void InitCoreData()
        {
        }

        protected void SetIllegalParam()
        {
        }

        protected void CheckIllegalParam()
        {
        }

        protected void UpdateCalcDatas(bool keepDead)
        {
        }

        protected void UpdateLevel()
        {
        }

        protected void UpdateMaxHP()
        {
        }

        protected void UpdateMaxHpAndCorrectHp(bool keepDead)
        {
        }

        protected void UpdateAtk()
        {
        }

        protected void UpdateDef()
        {
        }

        protected void UpdateSpAtk()
        {
        }

        protected void UpdateSpDef()
        {
        }

        protected void UpdateAgi()
        {
        }

        protected uint GetAtk()
        {
            return 0U;
        }

        protected uint GetDef()
        {
            return 0U;
        }

        protected uint GetSpAtk()
        {
            return 0U;
        }

        protected uint GetSpDef()
        {
            return 0U;
        }

        protected uint GetAgi()
        {
            return 0U;
        }

        protected byte CalcLevel()
        {
            return 0;
        }

        protected ushort CalcMaxHp()
        {
            //return null;
            return ushort.MaxValue;
        }

        protected ushort CalcAtk()
        {
            //return null;
            return (ushort)0;
        }

        protected ushort CalcDef()
        {
            //return null;
            return (ushort)0;
        }

        protected ushort CalcSpAtk()
        {
            //return null;
            return (ushort)0;
        }

        protected ushort CalcSpDef()
        {
            //return null;
            return (ushort)0;
        }

        protected ushort CalcAgi()
        {
            //return null;
            return (ushort)0;
        }

        protected ushort CalcMaxHp_G()
        {
            //return null;
            return (ushort)0;
        }

        protected ushort CalcAtk_G()
        {
            //return null;
            return (ushort)0;
        }

        protected ushort CalcDef_G()
        {
            //return null;
            return (ushort)0;
        }

        protected ushort CalcSpAtk_G()
        {
            //return null;
            return (ushort)0;
        }

        protected ushort CalcSpDef_G()
        {
            //return null;
            return (ushort)0;
        }

        protected ushort CalcAgi_G()
        {
            //return null;
            return (ushort)0;
        }

        protected ushort CalcMaxHp_NotG()
        {
            //return null;
            return (ushort)0;
        }

        protected ushort CalcAtk_NotG()
        {
            //return null;
            return (ushort)0;
        }

        protected ushort CalcDef_NotG()
        {
            //return null;
            return (ushort)0;
        }

        protected ushort CalcSpAtk_NotG()
        {
            //return null;
            return (ushort)0;
        }

        protected ushort CalcSpDef_NotG()
        {
            //return null;
            return (ushort)0;
        }

        protected ushort CalcAgi_NotG()
        {
            //return null;
            return (ushort)0;
        }

        protected void changeWazaByFormChange(ushort nextFormno, object pResult)
        {
        }

        protected void changeWazaByFormChange_Learn(object learnWaza, object pResult)
        {
        }

        protected void changeWazaByFormChange_Forget(object forgetWaza, object supplyWaza, object pResult)
        {
        }

        protected void changeWazaByFormChange_Replace(object forgetWaza, object learnWaza, object pResult)
        {
        }

        protected uint AdjustEffortPower(uint beforeValue, uint afterValue)
        {
            return 0U;
        }

        //private void <CollectRemindableWaza>CheckAndAddWazaNo(object list, object wazaNo)
        //{
        //}
    }

    public class FormChangeResult
    {
        public byte GetAddedWazaNum()
        {
            return 0;
        }

        public object GetAddedWaza(byte idx)
        {
            return null;
        }

        public byte GetRemovedWazaNum()
        {
            return 0;
        }

        public object GetRemovedWaza(byte idx)
        {
            return null;
        }

        public byte GetAddFailedWazaNum()
        {
            return 0;
        }

        public object GetAddFaildedWaza(byte idx)
        {
            return null;
        }

        public void Clear()
        {
        }

        public void SetAddedWaza(object wazano)
        {
        }

        public void SetRemovedWaza(object wazano)
        {
        }

        public void SetAddFailedWaza(object wazano)
        {
        }

        private void add(object pArray, object wazano)
        {
        }

        private void set(object pArray, object wazano)
        {
        }

        private object get(object pArray, byte idx)
        {
            return null;
        }

        private byte getCount(object pArray)
        {
            return 0;
        }

        public GameObject m_addedWaza;

        public GameObject m_removedWaza;

        public GameObject m_addFailedWaza;
    }

    public class WazaLearnWork
    {
        public void Clear()
        {
        }

        public void AddCheckedWaza(object waza)
        {
        }

        public bool IsCheckedWaza(object waza)
        {
            return false;
        }

        public GameObject m_checkedWazaArray;

        public uint m_checkedWazaNum;
    }
}
