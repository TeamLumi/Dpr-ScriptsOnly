using UnityEngine;
using Dpr.Movie;
using System;
using SmartPoint.AssetAssistant;
using UnityEngine.Events;
using UnityEngine.UI;

public class Title : SingletonScriptableObject<Title>
{
    private static Title instance;

    private MoviePlayer moviePlayer;
    private GameObject staffrollPlayer;
    private GameObject movieRendereObject;
    private bool diaVersion;
    private int lang;
    private bool male;
    private uint skinType;
    private bool playEnding;
    private RawImage fadeImage;

    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        //moviePlayer = GetComponent<MoviePlayer>();
        //moviePlayer.Initialize(movieRendereObject, null);

        diaVersion = true;
        //lang = PlayerWork.GetMsgLangID();
        //male = PlayerWork.GetPlayerSex();
        //skinType = PlayerWork.GetPlayerStatus().bodyType;

        //playEnding = GameManager.GetPlayEnding();

        if (!playEnding)
        {
            PlayOpeningSequence();
        }
        else
        {
            PlayEndingSequence();
        }
    }

    private void PlayEndingSequence()
    {
        // assuming that 'staffrollPlayer', 'fadeImage', and 'staffrollPlayer' are members of Title class
        //staffrollPlayer.SetActive(true);
        //var endingPlayer = gameObject.AddComponent<EndingPlayer>();

        // it seems diaVersion is a bool, lang, male, and skinType are int, moviePlayer is of type MoviePlayer
        // fadeImage is of type UnityEngine.UI.RawImage and staffrollPlayer is of type GameObject
        // if these assumptions are not correct, please adjust the types accordingly
        //endingPlayer.Initialize(moviePlayer, diaVersion, lang, male, skinType, fadeImage, null, staffrollPlayer);
        //endingPlayer.Play();
    }

    private void PlayOpeningSequence()
    {
        //staffrollPlayer.SetActive(false);

        //if (titlePlayer == null)
        {
            //titlePlayer = gameObject.GetComponent<TitlePlayer>();
        }

        //titlePlayer.Initialize(moviePlayer, diaVersion, lang, fadeImage, new Action<int>((type) =>
        {
            // Implement the callback action here
        }//));

        //titlePlayer.Play();
    }

    private void Uninitialize()
    {
        //moviePlayer.Uninitialize();
    }


    private void OnFinishedOpening(int type)
    {
        if (type == 1)
        {
            PlayBackUpSequence();
        }
        else if (type == 0)
        {
            PlayOpeningSequence();
        }
        else
        {
            EndTitle();
        }
    }

    private void PlayBackUpSequence()
    {
        // This code is not complete because there are system calls
        // that can't be easily converted to C#.
        // Please replace it with the appropriate implementation.
    }

    private void EndTitle()
    {
        // This code is not complete because there are system calls
        // that can't be easily converted to C#.
        // Please replace it with the appropriate implementation.
    }

    /*
private void OpenDialog(string file, string label, UnityAction closeCallback)
{
    if (SingletonMonoBehaviour<UIManager>.Instance != null)
    {
        DialogWindow dialogWindow = SingletonMonoBehaviour<UIManager>.Instance.CreateUIWindow<DialogWindow>();

        if (dialogWindow != null)
        {
            dialogWindow.onClosed = closeCallback;
            Action<UIText> setDialogText = null; // Initialize with the actual function
            dialogWindow.Open(setDialogText, 0, -2, false);
        }
    }
}

private void SaveDataErrorDialog()
{
    if (SingletonMonoBehaviour<UIManager>.Instance != null)
    {
        FatalErrorDialogWindow fatalErrorDialogWindow = SingletonMonoBehaviour<UIManager>.Instance.CreateUIWindow<FatalErrorDialogWindow>();

        if (fatalErrorDialogWindow != null)
        {
            Action<UIText> setDialogText = null; // Initialize with the actual function

            // Check if the setDialogText is already initialized, if not, create new action
            if (setDialogText == null)
            {
                setDialogText = new Action<UIText>(...); // Define the action here
            }

            fatalErrorDialogWindow.Open(setDialogText, -1);
        }
    }
}
*/

    public bool forceEndingPlay;

    public bool forceMovieLangSetting;

    public GameObject forceMovieLang;

    public bool forceVersionSetting;

    public bool forceDiamondVersion;

    public bool forceMaleSetting;

    public bool forceMale;

    public bool forceSkinTypeSetting;

    public int forceSkinType;

    //public GameObject movieRendereObject;

    //public GameObject fadeImage;

    //public GameObject staffrollPlayer;

    public bool _diaVersion;

    public GameObject _lang;

    public bool _male;

    public int _skinType;

    public GameObject _moviePlayer;

    public string file;

    public string label;

    public bool isLoadWindows;
}
