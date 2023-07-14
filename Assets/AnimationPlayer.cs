using System;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

[Serializable]
public class AnimationPlayer
{
    public AnimationClip[] clips
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public AvatarMask avatarMask
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public AnimationClip layerClip
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public AvatarMask additiveAvatarMask
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public AnimationClip additiveLayerClip
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public int currentIndex
    {
        get
        {
            return default(int);
        }
        private set
        {
        }
    }

    public bool forceLoop
    {
        get
        {
            return default(bool);
        }
        set
        {
        }
    }

    public bool forcePlay
    {
        get
        {
            return default(bool);
        }
        set
        {
        }
    }

    public AnimationClipPlayable currentPlayable
    {
        get
        {
            return default(AnimationClipPlayable);
        }
    }

    public float currentPlayingTime
    {
        get
        {
            return default(float);
        }
    }

    public float currentRemaingTime
    {
        get
        {
            return default(float);
        }
    }

    public float layerWeight
    {
        get
        {
            return default(float);
        }
        set
        {
        }
    }

    public bool IsValidCurrentPlayable
    {
        get
        {
            return default(bool);
        }
    }

    public bool IsPlayingEnd
    {
        get
        {
            return default(bool);
        }
    }

    public bool IsPlaying
    {
        get
        {
            return default(bool);
        }
    }

    public AnimationClipPlayable layerClipPlayable
    {
        get
        {
            return default(AnimationClipPlayable);
        }
    }

    public AnimatorCullingMode cullingMode
    {
        get
        {
            return AnimatorCullingMode.AlwaysAnimate;
        }
        set
        {
        }
    }

    public void InitializePlayables(Animator animator)
    {
    }

    public void Destroy()
    {
    }

    public void AdvanaceTime(float deltaTime)
    {
    }

    public void Play(int index, float duration = 0f, float startTime = 0f)
    {
    }

    public void Stop()
    {
    }

    public void Resume()
    {
    }

    public void SetSpeed(float speed)
    {
    }

    public void SetTimeUpdateMode(DirectorUpdateMode mode)
    {
    }

    public void SetAdditiveLayerTime(float time)
    {
    }

    public void Evalute()
    {
    }

    public void PlayFrame(int index, float duration = 0f, float startFrame = 0f, bool forceplay = false)
    {
    }

    public void SetAnimSpeed(float speed)
    {
    }

    public void ResetAnimSpeed()
    {
    }

    public void RePlay(float startFrame = 0f)
    {
    }

    public AnimationPlayer()
    {
    }

    private PlayableGraph _graph;

    private Playable _mixer;

    private AnimationPlayableOutput _output;

    private Animator _animator;

    private AnimationClipPlayable[] _playables;

    private float _increase;

    private float _weight;

    private int _activePort;

    private RuntimeAnimatorController _savedAnimatorController;

    [SerializeField]
    private AnimationClip[] _clips;

    [SerializeField]
    private AvatarMask _avatarMask;

    [SerializeField]
    private AnimationClip _layerClip;

    [SerializeField]
    private AvatarMask _additiveAvatarMask;

    [SerializeField]
    private AnimationClip _additiveLayerClip;

	private int _additiveLayerIndex;

    private AnimationClipPlayable _layerClipPlayable;

    private AnimationClipPlayable _additiveClipPlayable;
}
