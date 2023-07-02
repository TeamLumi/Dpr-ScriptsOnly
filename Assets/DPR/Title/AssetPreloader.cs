using Dpr.EvScript;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Dpr.Title
{
    public class AssetPreloader
    {
        private static List<string> _preloadRequestList = new List<string>();
        public static bool IsLoading { get; set; }

        public void UnloadPreloadAssetBundle()
        {
            foreach (var item in _preloadRequestList)
            {
                //SmartPoint.AssetAssistant.AssetManager.UnloadAssetBundle(null);
            }

            // Clear the list
            _preloadRequestList.Clear();
        }

        public class LoadAssetBundle : IEnumerator
        {
            private int _state;
            private object _current;
            private string _path;

            public LoadAssetBundle(int state, string path)
            {
                _state = state;
                _path = path;
            }

            public bool MoveNext()
            {
                switch (_state)
                {
                    case 0:
                        _state = -1;
                        _preloadRequestList.Add(_path);
                        //SmartPoint.AssetAssistant.AssetManager.RequestAssetBundle(_path, true);
                        //_current = SmartPoint.AssetAssistant.AssetManager.DispatchRequests();
                        _state = 1;
                        return true;
                    case 1:
                        _state = -1;
                        return false;
                    default:
                        return false;
                }
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }

            public object Current
            {
                get { return _current; }
            }

            public void Dispose()
            {
                // Implementation of the method goes here
                throw new NotImplementedException();
            }
        }

        public class PreloadAssetBundle //: IEnumerator
        {
            private int _state;
            private object _current;
            private string _path;

            public PreloadAssetBundle(int state)
            {
                _state = state;
            }

            public bool MoveNext()
            {
                //switch (_state)
                //{
                    //case 0:
                        //_state = -1;
                        //_sw = new SimpleStopwatch();
                        //_IsLoading = true;
                        //_elapsedMilliseconds = _sw.ElapsedMilliseconds;
                        //_transitionZoneID = PlayerWork.GetTransitionZoneID();
                        //if (_transitionZoneID != -1)
                        //{
                            //_mapInfo = GameManager.GetMapInfo();
                            //_zoneData = _mapInfo.GetItem(_transitionZoneID);
                            //_activeFieldPlayer = EntityManager.GetActiveFieldPlayer();
                            //if (_activeFieldPlayer == null)
                            //{
                                //var characterDressData = DataManager.CharacterDressData.Data;
                                //var length = characterDressData.Length;
                                //if (length > 0)
                                //{
                                    //for (long i = 0; i < length; i++)
                                    //{
                                        //var dressData = characterDressData[i];
                                        //var index = dressData.Index;
                                        //var playerFashion = PlayerWork.GetPlayerFashion();
                                        //if (index == playerFashion)
                                        //{
                                            //var preloadRequestList = AssetPreloader._preloadRequestList;
                                            //var item = String.Concat("StringLiteral_7019", dressData.FieldGraphic);
                                            //preloadRequestList.Add(item);
                                            //var assetBundleName = String.Concat("StringLiteral_7019", dressData.FieldGraphic);
                                            //var assetRequest = AssetManager.AppendAssetBundleRequest(assetBundleName, true, null, null);
                                            //if (assetRequest != null)
                                            //{
                                                //AssetManager.DispatchRequests(null);
                                                // yield return assetRequest; // This would be here if this was a coroutine
                                                //break;
                                            //}
                                        //}
                                    //}
                                //}
                            //}
                            //else
                            //{
                                // Some operations related to zone data and asset bundle request
                                // This part is not clear in the original code
                            //}
                        //}
                        //_state = 1;
                        //return true;
                    //case 1:
                        //_state = -1;
                        //_IsLoading = false;
                        //_sw.Dispose();
                        //_sw = null;
                        //return false;
                    //default:
                        //return false;
                        return false;
                }
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }

            //public object Current
            //{
                //get { return _current; }
            //}

            public void Dispose()
            {
                // Implementation of the method goes here
                throw new NotImplementedException();
            }
        }
    }
//}
