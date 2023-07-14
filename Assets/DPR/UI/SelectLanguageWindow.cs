using System;
using System.Collections;
using System.Reflection.Emit;
using UnityEditor.PackageManager.UI;
using UnityEngine;

namespace Dpr.UI
{
    public class SelectLanguageWindow
    {
        private int _selectIndex;
        private Animator _animator;
        //private Action<UIWindow> _onClosed;

        public int SelectIndex
        {
            get
            {
                return _selectIndex;
            }
        }

        //protected override void OnCreate()
        //{
            //base.OnCreate();

            //_animator = GetComponentInChildren<Animator>();
        //}

        public void Open(int prevWindowId)
        {
            //StartCoroutine(OpOpen(prevWindowId));
        }

        public IEnumerator OpOpen(object prevWindowId)
        {
            return null;
        }

        //public void Close(Action<UIWindow> onClosed, int nextWindowId)
        //{
            //_onClosed = onClosed;
            //StartCoroutine(OpClose(nextWindowId));
        //}

        public IEnumerator OpClose(object onClosed_, object nextWindowId)
        {
            return null;
        }

        //public void Destroy(Action<UIWindow> onClosed)
        //{
            //UIManager.Instance.ReleaseUIWindow(this);

            //if (onClosed != null)
            //{
                //onClosed(this);
            //}
        //}

        private void OnUpdate(bool deltaTime)
        {
        }

        private void OpenConfirmMessageWindow()
        {
        }

        private void UpdateSelect(bool deltaTime)
        {
        }

        private bool SetSelectIndex(int index, bool isInitialized)
        {
            return false;
        }

        protected virtual void OnAddContextMenuYesNoItemParams(object contextMenuItemParams)
        {
        }

        public GameObject _content;

        public GameObject _cursor;

        public int _columnNum;

        public int _rowNum;

        public GameObject _items;

        public int _reloadAllMsbtState;

        public GameObject onReloadLanguage;

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

public GameObject nextWindowId;

public GameObject prevWindowId;

	}
}
