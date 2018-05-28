using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private Animator m_Animator;
    [SerializeField]
    private float m_Speed = 5f;

    private SpriteRenderer m_Visual;
    private float m_InputX;


    private void Awake()
    {
        m_Visual = GetComponent<SpriteRenderer>();
    }


    private void Update()
    {
        m_InputX = Input.GetAxisRaw("Horizontal");
		m_Animator.SetInteger("Speed", (int)m_InputX);
        if (m_InputX > 0)
        {
            m_Visual.flipX = false;
        }
        else if (m_InputX < 0)
        {
            m_Visual.flipX = true;
        }


        transform.Translate(m_Speed * m_InputX * Time.deltaTime, 0f, 0f);
    }
}
