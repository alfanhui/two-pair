using UnityEngine;
using System.Collections;

public class AnimationPlayer : MonoBehaviour {

    public void PlayAnimation(string animationName) {
        GetComponent<Animator>().Play(animationName, 0, 0f);
    }

}
