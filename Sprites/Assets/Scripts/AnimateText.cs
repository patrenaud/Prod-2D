using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnimateText : MonoBehaviour
{
    public float m_LetterDelay = 0.2f;
    public TextMeshProUGUI m_KirbyTextBox;
    public TextMeshProUGUI m_MetaKnightTextBox;
    public string[] m_KirbyText = new string[10];
    public string[] m_MetaKnightText = new string[10];

    //private int m_rounds = 0;
    private int m_Choices = 3;
    private int m_counter = 0;

    private void Start()
    {
        StartCoroutine(TypeMetaKnightText());
    }

    private void Update()
    {   // Lorsque les boutons sont appuyés, les énumérateurs changeront le choix et fera apparaître un text différent du MetaKnight
        if (m_Choices == 0)
        {
            Debug.Log("RunTalk");
            StartCoroutine(RunTalk());
        }
        else if (m_Choices == 1)
        {
            Debug.Log("IdleTalk");
            StartCoroutine(IdleTalk());
        }
        else if (m_Choices == 2)
        {
            Debug.Log("BlowTalk");
            StartCoroutine(BlowTalk());
        }
    }

    // Ces 3 fonctions sont appelées par les 3 boutons pour activer dans l'Update l'énumérateur choisi
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

    // Ces Enumerateurs appellent le text du MetaKnight en envoyant le bon index de text
    // ICI ON FAIT LES CONDITIONS
    private IEnumerator RunTalk()
    {
        m_Choices = 3; // Ceci est pour ne pas appeler le string en boucle lors du clic du bouton
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(TypeMetaKnightText());
    }
    private IEnumerator IdleTalk()
    {
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(TypeMetaKnightText());
    }
    private IEnumerator BlowTalk()
    {
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(TypeMetaKnightText());
    }

    // Le texte de Kirby s'écrit
    private IEnumerator TypeKirbyText()
    {
        foreach (char letter in m_KirbyText[m_counter].ToString())
        {
            m_KirbyTextBox.text += letter;
            yield return new WaitForSeconds(m_LetterDelay);
        }
    }

    // Le texte de MetaKnight s'écrit
    private IEnumerator TypeMetaKnightText()
    {
        foreach (char letter in m_MetaKnightText[m_counter].ToString())
        {
            m_MetaKnightTextBox.text += letter;
            yield return new WaitForSeconds(m_LetterDelay);
        }
        StartCoroutine(TypeKirbyText());
    }
}
