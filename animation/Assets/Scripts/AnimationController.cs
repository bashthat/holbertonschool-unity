using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator animation;
    int isWalkingNode;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
        isWalkingNode = Animator.StringToHash("isWalking");
        
    }

    // Update is called once per frame
    void Update()
    {
        // set the value only when needed.
        bool isWalking = animation.GetBool(isWalkingNode);
        // when the player starts walking forward by pressing "w" the animation will play
        bool funWalk = Input.GetKey("w");
        // funWalk is true when the player is drunkenly.... walking forward
        if (!isWalking && funWalk)
        {
            animation.SetBool(isWalkingNode, true);
        }
        // if player is at idle and not walking, the animation will stop
        if (isWalking && !funWalk)
        {
            animation.SetBool(isWalkingNode, false);
        }

        
    }
}
