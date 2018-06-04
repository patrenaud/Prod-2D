using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(SpriteRenderer))]
public class KirbyControl : MonoBehaviour
{
    [SerializeField]
    private Animator m_KirbyAnimator;
    private SpriteRenderer m_Visual;

    public Animator m_MetaKnightAnimator;
    public SpriteRenderer m_MetaKnightSprite;
    public InfiniteParallaxe m_Parallaxe;

    private void Awake()
    {
        //m_Visual = GetComponent<SpriteRenderer>();
        m_MetaKnightSprite.flipX = false;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RunButton();
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            IdleButton();

        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            BlowButton();
        }
    }

    public void RunButton()
    {
        m_KirbyAnimator.SetTrigger("Run");
        m_MetaKnightAnimator.SetTrigger("Run");
        m_Parallaxe.SetSpeed();
    }
    public void IdleButton()
    {
            m_KirbyAnimator.SetTrigger("Idle");
            m_MetaKnightAnimator.SetTrigger("Idle");
            m_Parallaxe.StopSpeed();
    }
    public void BlowButton()
    {
            m_KirbyAnimator.SetTrigger("Blow");
            m_Parallaxe.StopSpeed();
    }
}