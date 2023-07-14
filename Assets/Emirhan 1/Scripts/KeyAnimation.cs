using UnityEngine;

public class KeyAnimation : MonoBehaviour
{
    public Animator animator;
    private bool isAnimationPlaying = false;

    void Update()
    {
        if (Input.anyKeyDown && !isAnimationPlaying)
        {
            animator.SetTrigger("KeyPressed");
            isAnimationPlaying = true;
        }

       
        if (isAnimationPlaying && !animator.GetCurrentAnimatorStateInfo(0).IsName("ClickingKey"))
        {
            isAnimationPlaying = false;
        }
    }
}


