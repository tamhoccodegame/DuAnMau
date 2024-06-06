using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class CutsceneManager : MonoBehaviour
{
    public Animator bossAnimator;
    public AnimatorController cutsceneController;
    public AnimatorController normalController;
    PlayableDirector playableDirector;
    // Start is called before the first frame update
    void Start()
    {
        playableDirector = GetComponent<PlayableDirector>();
        bossAnimator.runtimeAnimatorController = cutsceneController;
		playableDirector.stopped += PlayableDirector_stopped;
    }

	private void PlayableDirector_stopped(PlayableDirector obj)
	{
		if (obj == playableDirector)
        {
            Debug.Log("Timeline đã chạy xong!");
            bossAnimator.runtimeAnimatorController = normalController;
            Destroy(gameObject); 
        }
	}

	private void OnDestroy()
	{
		playableDirector.stopped -= PlayableDirector_stopped;
	}

	// Update is called once per frame
	void Update()
    {
        
    }
}
