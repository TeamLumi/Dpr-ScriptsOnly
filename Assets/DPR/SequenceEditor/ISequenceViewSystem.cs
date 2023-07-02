using System;
using UnityEngine;

namespace Dpr.SequenceEditor
{
    public interface ISequenceViewSystem
    {
        void OnUpdate(bool deltaTime);

        void OnLateUpdate(bool deltaTime);

        void ResetPokemon(object vPos, int frame, object moveType, object placement);

        void GetDefaultPokePos(object vPos, object pos, object deg, object placement);

        object GetPokeModel(object vPos);

        object GetPokeSize(object side, bool isGPoke);

        void ResetTrainer(object vPos, bool isOrigin, object placement);

        object GetTrainerModel(object vPos);

        string GetBallModelPath(int idx);

        void ResetAll();

        void SEQ_CMD_ResetDefaultCamera(int frame, object moveType, object system);

        bool SeqComFunc_IsFlipEffect(object target, object subTarget);

        object SeqComFunc_GetTargetChara(object trg, int idx);

        //object SeqComFunc_GetTargetChara(object trg, int idx);

        object SeqComFunc_GetTargetPoke(object target, int index);

        object SeqComFunc_GetTargetPokeSub(object target);

        object SeqComFunc_GetTargetPoke_Org(int idx);

        void SeqComFunc_GetPokeRelativePos(object opt, object pRetPos, object pRetRot, object pRetScale, bool isCameraAdjust);

        void SeqComFunc_GetSpecialPos(object trgType, object retPos, object retRot);

        void SeqComFunc_GetPokeFiledPos(object retPos, object retRot, object plater, bool isAttack);

        int SeqComFunc_GetTargetPokeNum(bool isCheck);

        object SeqComFunc_GetTargetCharaVPos(object target, int index);

        void SeqComFunc_CalcPokeDir(Vector3 nowPos, object trgPoke, object trgNode, object retRot, bool isVertical);

        void SeqComFunc_CalcPosDir(Vector3 nowPos, Vector3 trgPos, object retRot, bool isVertical);

        void SeqComFunc_MoveRelativePoke(object iPtrObj, int frame, object opt, bool isTrainer);

        void SeqComFunc_MoveSpecialPos(object iPtrObj, int frame, object trgType, Vector3 ofs, bool isRotate, bool isFlip);

        object SeqComFunc_GetEffectBallInfo(int idx);

        void SetTerrainChipVisibility(bool disp);

        void StartWeather(object weather);

        void SetSuspendSequenceFunc(object type);

        object GetTaskManager();

        object GetTaskManagerLate();

        object GetBattlePokeParam(object pos);

        object GetMainModule();

        object GetWazaParam();

        object SetWazaParam(object param);

        string GetBttleWazaModelPath(string idx);

        void CheckWazaDataPath_Particle(object path, int idx, bool isBallEffect, bool isCapture, bool isAttributeEffect, bool isStreamLineEffect);

        object GetSequenceSystem();

        object GetCharacterSystem();

        object GetCameraSystem();

        object GetBattleWeatherSystem();

        object GetBattleGroundEffectSystem();

        object GetSoundPlayingIDHashTable();

        bool IsStencilEnable { get; set; }

        bool blurry { get; set; }

        void SetIsSoundPlayingFinishCheckInvalid(bool value);
    }
}
