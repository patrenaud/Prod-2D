using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(SpriteRenderer))]
public class KirbyControl : MonoBehaviour
{
    [SerializeField]
    private Animator m_Animator;
    private SpriteRenderer m_Visual;

	public InfiniteParallaxe m_Parallaxe;

    private void Awake()
    {
        m_Visual = GetComponent<SpriteRenderer>();
		
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            m_Animator.SetTrigger("Run");
			m_Parallaxe.SetSpeed();
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
			m_Animator.SetTrigger("Idle");
			m_Parallaxe.StopSpeed();
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            m_Animator.SetTrigger("Blow");
			m_Parallaxe.StopSpeed();
        }
    }
}