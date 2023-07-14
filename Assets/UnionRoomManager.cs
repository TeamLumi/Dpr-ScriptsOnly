using SmartPoint.AssetAssistant;
using SmartPoint.Components;
using System.Collections.Generic;
using UnityEngine;

public class UnionRoomManager : SingletonMonoBehaviour<UnionRoomManager>
{
    private object player
    {
        get
        {
            return null;
        }
    }

    protected void Start()
    {
    }

    public void SetMatchingParam(object matchingParam)
    {
    }

    protected void Init()
    {
    }

    protected void MyUpdate(bool deltaTime)
    {
    }

    protected void OnDestroy()
    {
    }

    public void SetZoneData(object zoneId, int locIndex, Vector3 returnPos)
    {
    }

    private void SetUp()
    {
    }

    private void Clear()
    {
    }

    private void CreateWarpCollision()
    {
    }

    private void SSGaminWaitMessage(bool isSSGaming)
    {
    }

    private void SetupLeave()
    {
    }

    private void LandStartPoint()
    {
    }

    private void CreateFrontDesk()
    {
    }

    private void RestartJoin()
    {
    }

    private void StartGuruGuruJoinAnimation()
    {
    }

    public void StartGuruGuruLeaveAnimation()
    {
    }

    private void StartUnion()
    {
    }

    public void LeaveUnion()
    {
    }

    public void TransitionUnionInit()
    {
    }

    private void CreateTradeManager()
    {
    }

    protected void OnSessionEvent(object eventData)
    {
    }

    private void LeaveMine()
    {
    }

    private void LeaveOtherPlayer(int index)
    {
    }

    private void GamingError()
    {
    }

    private void Crush()
    {
    }

    private void Resume()
    {
    }

    private void NetworkError()
    {
    }

    private void OpenSystemErrorMessage(object errorAppletResult)
    {
    }

    public void SessionStart()
    {
    }

    public void ClearSession()
    {
    }

    protected void OnReceiveData(object netData)
    {
    }

    protected void SetNetData(object netData)
    {
    }

    protected void LoadAsset()
    {
    }

    private void SendJoinData(int stationIndex)
    {
    }

    private void SendPosData()
    {
    }

    private void SendOpcStateData(int stationIndex)
    {
    }

    public void SendRequestData(int stationIndex, byte id)
    {
    }

    private void SendIsTransitionAfter()
    {
    }

    private void SendTradePokeData(int stationIndex)
    {
    }

    private void SendTradeStandbyData(int stationIndex, bool isAll)
    {
    }

    private void SendIsMatchWait(int stationIndex)
    {
    }

    private void RecivePokeData(object netTradePokeData)
    {
    }

    private void StartTalk(object controller)
    {
    }

    private int GetAvaterId()
    {
        return 0;
    }

    private void CheckReStartZone()
    {
    }

    private void Test()
    {
    }

    private void SetNpcFrontDeskPos()
    {
    }

    private void SetNpcTalkBit()
    {
    }

    public int SESSION_PLAYER_MAX_COUNT_COMMUNITY;

    public int SESSION_PLAYER_MAX_COUNT_GLOBAL;

    public string UNION_MASTER_PATH;

    public string CHARACTER_DATATABLE_PATH;

    public string NPC_COLOR_DATATABLE;

    public string UNION_DEBUG_PATH;

    public string DEBUG_UI_PATH;

    public string DEBUG_UI_ONLINE_STATUS_PATH;

    public int POSITION_DATA_MAX_SIZE;

    public GameObject GURUGURU_HEIGHT_UP;

    public string UNION_FRONT_DESK_CONTROLLER;

    public GameObject enableZones;

    public GameObject _characterTable;

    public GameObject _npcColorTable;

    public GameObject netJoinData;

    public GameObject posDataList;

    public int posDataIndex;

    public GameObject stateController;

    public GameObject returnZoneID;

    public int locatorIndex;

    public Vector3 returnPosition;

    public GameObject _testUI;

    public GameObject batteStateDataWindow;

    public GameObject onlineStateDataWindow;

    public GameObject fdControllerObject;

    public GameObject unionFrontController;

    public GameObject startPointObject;

    public GameObject startLandObj;

    public GameObject pointCollision;

    public GameObject tradeManager;

    public GameObject msgWindow;

    public GameObject frontDeskEntity;

    public GameObject textMEshProMaterial;

    public int DEBUG_COLOR_INDEX_MAX;

    public int DEBUG_NPC_INDEX_MAX;

    public int debugColorIndex;

    public int debugNpcIndex;

    public GameObject npcObj;

    private void Dispose()
    {
    }

    private bool MoveNext()
    {
        return false;
    }

    private object Current
    {
        get
        {
            return null;
        }
    }

    private void Reset()
    {
    }

    public sealed class UNION_ERRORSTATE : ScriptableObject
    {
        public GameObject NONE;

        public GameObject NETWORK_ERROR;
    }
}
