using Dpr.Demo;
using Dpr.UI;
using SmartPoint.AssetAssistant;
using System;
using System.Collections;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class OpeningController : SingletonScriptableObject<OpeningController>
{
    //private DemoModel demoModel; // Assuming DemoModel is a defined class
    private DemoBase demoModel; // Assuming DemoModel is a defined class
    //private GameObject demoModel; // Assuming DemoModel is a defined class

    //public UIManager uiManager;

    // Start is usually a coroutine in Unity, it is hard to understand exactly what is happening without context.
    // If Start is a coroutine it may look like this in C#
    public IEnumerator Start()
    {
        // Here you need to put some logic based on the original method
        // yield return null;
        return null;
    }

    public void OnDisable()
    {
        if (demoModel != null)
        {
            demoModel.ReleasePreloadedAssetBundles(); // Assuming that DemoModel has method ReleasePreloadedAssetBundles
        }
    }

    public void OpenSelectLanguage()
    {
        //var uiManager = SingletonMonoBehaviour<UIManager>.Instance;
        //var languageWindow = uiManager.CreateUIWindow<SelectLanguageWindow>(0x22);

        //languageWindow.onClosed += OnLanguageWindowClosed;
        //languageWindow.onReloadLanguage += OnReloadLanguage;

        //languageWindow.Open(-2);
    }

    //private void OnWindowClosed(UIWindow window)
    //{
    // this method is empty in the provided pseudo-code
    //}

    private void OnReloadLanguage()
    {
        // handle reload language
        var demoSceneManagerObject = new GameObject("DemoSceneManager");
        //var demoSceneManager = demoSceneManagerObject.AddComponent<DemoSceneManager>();

        var demoHakase = new Demo_Hakase
        {
            openingController = this,
            StartEnterFadeDuration = 0
        };

        //var loadAndPlayRoutine = demoSceneManager.OpLoadAndPlay(demoHakase, true);
        //Sequencer.Start(loadAndPlayRoutine);
    }

    public void OpenSelectPlayerVisual()
    {
        //var uiManager = UIManager.Instance; // Singleton instance

        // Assuming CreateUIWindow method is properly defined in UIManager to instantiate the window
        //SelectPlayerVisualWindow visualWindow = uiManager.CreateUIWindow<SelectPlayerVisualWindow>(0x23);

        // Assigning some method to someUnityAction UnityAction
        //visualWindow.someUnityAction += YetAnotherMethod; // Replace someUnityAction and YetAnotherMethod with the actual field and method names

        // Assuming the Open method is properly defined in SelectPlayerVisualWindow to open the window
        //visualWindow.Open(-2);
    }

    //var messageManager = MessageManager.Instance; // Singleton instance

    // GetSimpleMessage method is properly defined in MessageManager
    //string headerText = messageManager.GetSimpleMessage("dp_scenario1", "7-msg_opening_13"); // replace with the correct string keys

    /*
    SoftwareKeyboard.Param keyboardParam = new SoftwareKeyboard.Param 
    {
        text = "", // assuming this is some default text
        textMinLength = 1,
        textMaxLength = SoftwareKeyboard.LanguageMaxLength(6, -1), // assuming this method exists in SoftwareKeyboard
        headerText = headerText,
        subText = null,
        guideText = null,
        okText = null,
        invalidCharFlag = 4
    };
    */

    // Assigning OnInputCheck method to the input check function
   // Func<string, SoftwareKeyboard.ErrorState, (bool, string)> onInputCheck = OnInputCheck;

    // Assigning SomeMethod to the onComplete function
    //Action<bool, string> onComplete = SomeMethod; // Replace SomeMethod with the method name

    // Assuming the Open method is properly defined in SoftwareKeyboard to open the keyboard
    //SoftwareKeyboard.Open(keyboardParam, onInputCheck, onComplete);
    //}

    private (bool, string) OnInputCheck(string resultText,  SoftwareKeyboard.ErrorState errorState)
    {
        return ((bool, string))SoftwareKeyboard.InputCheck(resultText, errorState); // assuming this method exists in SoftwareKeyboard
    }

    private void OpenKeyboardByPlayerName()
    {
    }

    public void OpenKeyboardByRivalName()
    {
    }

    private void OnFinished()
    {
    }

    public GameObject _selectPlayerVisualItem;

    public Action OnFinishedCallBack;

    public GameObject demoRequestOperation;

    public GameObject demoInstance;

    public GameObject demoSceneManager;

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
}
