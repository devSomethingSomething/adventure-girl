using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationController : MonoBehaviour
{
    [SerializeField]
    private RuntimeAnimatorController[] runtimeAnimatorControllers;

    private Animator animator;

    public bool canSetAnimations;

    private void Awake()
    {
        animator = GetComponent<Animator>();

        canSetAnimations = true;
    }

    public void Idle()
    {
        if (canSetAnimations)
        {
            animator.runtimeAnimatorController = runtimeAnimatorControllers[0];
        }
    }

    public void Run()
    {
        if (canSetAnimations)
        {
            animator.runtimeAnimatorController = runtimeAnimatorControllers[1];
        }
    }

    public void Jump()
    {
        if (canSetAnimations)
        {
            animator.runtimeAnimatorController = runtimeAnimatorControllers[2];
        }
    }

    public void Dead()
    {
        if (canSetAnimations)
        {
            animator.runtimeAnimatorController = runtimeAnimatorControllers[3];
        }
    }
}
