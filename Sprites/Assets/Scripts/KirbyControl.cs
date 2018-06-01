using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(SpriteRenderer))]
public class KirbyControl : MonoBehaviour
{
    [SerializeField]
    private Animator m_KirbyAnimator;
    private SpriteRenderer m_Visual;

    public Animator m_MetaKnightAnomator;
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
            m_KirbyAnimator.SetTrigger("Run");
            m_MetaKnightAnomator.SetTrigger("Run");
            m_MetaKnightSprite.flipX = false;
            m_Parallaxe.SetSpeed();
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            m_KirbyAnimator.SetTrigger("Idle");
            m_MetaKnightAnomator.SetTrigger("Idle");
            m_MetaKnightSprite.flipX = true;
            m_Parallaxe.StopSpeed();
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            m_KirbyAnimator.SetTrigger("Blow");
            m_Parallaxe.StopSpeed();
        }
    }
}