using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnimateText : MonoBehaviour
{
    public float m_LetterDelay = 0.2f;
    public TextMeshProUGUI m_KirbyText;
    public TextMeshProUGUI m_MetaKnightText;
    public string[] m_Text = new string[10];

    private int m_Choices = 3;
    private int m_counter = 0;


    private void Start()
    {
        //StartCoroutine(TypeText());
    }

    private void Update()
    {
        if (m_Choices == 0)
        {
            Debug.Log("RunTalk");
            StartCoroutine(RunTalk());
        }
        else if (m_Choices == 1)
        {
            StartCoroutine(IdleTalk());
        }
        else if (m_Choices == 2)
        {
            StartCoroutine(BlowTalk());
        }
    }


    public void SetRun()
    {
        m_Choices = 0;
    }
    public void SetIdle()
    {
        m_Choices = 1;
    }
    public void SetBlow()
    {
        m_Choices = 2;
    }


    private IEnumerator RunTalk()
    {
        m_counter = 0;
        foreach (char letter in m_Text[m_counter].ToString())
        {
            m_KirbyText.text += letter;
            yield return new WaitForSeconds(m_LetterDelay);
        }
        m_Choices = 3;
    }
    private IEnumerator IdleTalk()
    {
        m_counter = 1;
        TypeMetaKnightText();
        yield return new WaitForSeconds(1);
    }
    private IEnumerator BlowTalk()
    {
        m_counter = 2;
        TypeMetaKnightText();
        yield return new WaitForSeconds(1);
    }

    /*private IEnumerator TypeKirbyText()
    {
        foreach (char letter in m_Text[m_counter].ToString())
        {
            m_KirbyText.text += letter;
            yield return new WaitForSeconds(m_LetterDelay);
        }
    }*/

    private IEnumerator TypeMetaKnightText()
    {
        foreach (char letter in m_Text[m_counter].ToString())
        {
            m_KirbyText.text += letter;
            yield return new WaitForSeconds(m_LetterDelay);
        }
    }
}
