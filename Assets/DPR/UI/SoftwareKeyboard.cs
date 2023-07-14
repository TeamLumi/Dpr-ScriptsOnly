using System;
using System.Text;
using UnityEngine;

namespace Dpr.UI
{
    public static class SoftwareKeyboard
    {
        public sealed class Preset : ScriptableObject
        {
            public int value__;

            public GameObject Default;

            public GameObject Password;

            public GameObject UserName;

            public GameObject DownloadCode;

            public GameObject Custom;

            public GameObject Max;
        }

        public sealed class KeyboardMode : ScriptableObject
        {
            public int value__;

            public GameObject LanguageSet1;

            public GameObject Numeric;

            public GameObject ASCII;

            public GameObject LanguageSet1Latin;

            public GameObject Alphabet;

            public GameObject SimplifiedChinese;

            public GameObject TraditionalChinese;

            public GameObject Korean;

            public GameObject LanguageSet2;

            public GameObject Max;

            public GameObject Full;

            public GameObject FullLatin;

            public GameObject Auto;
        }

        public sealed class InvalidChar : ScriptableObject
        {
            public int value__;

            public GameObject Space;

            public GameObject AtMark;

            public GameObject Percent;

            public GameObject Slash;

            public GameObject BackSlash;

            public GameObject Numeric;

            public GameObject OutsideOfDownloadCode;

            public GameObject OutsideOfMiiNickName;

            public GameObject Force32;
        }

        public sealed class InitialCursorPos : ScriptableObject
        {
            public int value__;

            public GameObject First;

            public GameObject Last;

            public GameObject Max;
        }

        public sealed class PasswordMode : ScriptableObject
        {
            public int value__;

            public GameObject Show;

            public GameObject Hide;

            public GameObject Max;
        }

        public sealed class InputFormMode : ScriptableObject
        {
            public int value__;

            public GameObject OneLine;

            public GameObject MultiLine;

            public GameObject Separate;

            public GameObject Max;
        }

        public class Param : ScriptableObject
        {
            public GameObject preset;

            public GameObject keyboardMode;

            public bool isPredictionEnabled;

            public GameObject invalidCharFlag;

            public GameObject initialCursorPos;

            public int textMaxLength;

            public int textMinLength;

            public GameObject passwordMode;

            public GameObject inputFormMode;

            public bool isUseNewLine;

            public bool isUseBlurBackground;

            public GameObject separateTextPos;

            public string text;

            public string guideText;

            public string headerText;

            public string subText;

            public string okText;
        }

        public sealed class ErrorState : ScriptableObject
        {
            public int value__;

            public GameObject None;

            public GameObject WhiteSpace;

            public GameObject NumberCount;

            public GameObject WhiteUnicode;

            public GameObject NgWord;
        }

        public static int TextMaxLength;

        public static int SeparateModeTextMaxLength;

        public static int HeaderTextMaxLength;

        public static int SubTextMaxLength;

        public static int GuideTextMaxLength;

        public static int OkTextMaxLength;

        public static int UnfixedStringLengthMax;

        public static int UserWordMax;

        public static int DialogTextMaxLength;

        public static int SepareteTextPosMax;

        public static int CustomizedDicionarySetMax;

        public static bool _isInitialized;

        public static GameObject _param;

        public static GameObject _onInputCheck;

        public static GameObject _onComplete;

        public static string _resultText;

        public static GameObject _errorState;

        public static bool _isCheckResult;

        public static GameObject _showKeyboardArg;

        public static GameObject _patterns;

        public static string _messageFileNameWhiteWords;

        public static string _messageFileName;

        public static GameObject _msgFile;

        public static object _whiteWords;

        public static int _maxNumberNum;

        public static char _errorWhiteUnicode;

        public static bool isInitialized => false;

        public static object onInputCheck => null;

        public static object onComplete => null;

        public static string resultText => "";

        public static object errorState => null;

        public static bool isCheckResult => false;

        public static void Initialize()
        {
        }

        public static string GetMessageText(string messageLabel)
        {
            return "";
        }

        private static bool CheckWhiteSpace(string text)
        {
            return false;
        }

        private static bool CheckNumbers(string text)
        {
            return false;
        }

        private static bool CheckWhiteUnicodes(string text)
        {
            return false;
        }

        private static bool CheckWhiteWords(string text)
        {
            return false;
        }

        public static void Terminate()
        {
        }

        public static void Open(object param, object onInputCheck, object onComplete)
        {
        }

        private static object GetKeyboardMode()
        {
            return null;
        }

        private static object GetLanguageKeyboardMode()
        {
            return null;
        }

        internal static void _SetCheckResult(bool isCheckResult)
        {
        }

        internal static void _SetResult(bool isSuccess, string resultText)
        {
        }

        private static object GetLanguagePatternAll()
        {
            return null;
        }

        private static object TextCheckCallback(IntPtr textBuf, object length, object str)
        {
            return null;
        }

        internal static bool _IsCheckNumberCount()
        {
            return false;
        }

        private static object _TextCheckCallbackImpl(IntPtr textBuf, object length, string input, Encoding encoding)
        {
            return null;
        }

        public static object CheckNgWords(object resultText, bool isChechNumberCount)
        {
            return null;
        }

        private static object _CheckNgWords(object resultText, bool isChechNumberCount)
        {
            return null;
        }

        private static bool CheckNgc(object resultText, bool isMaskResult)
        {
            return false;
        }

        public static int LanguageMaxLength(int maxLength)
        {
            return 0;
        }

        public static object InputCheck(string resultText, object errorState)
        {
            return null;
        }
    }
}
