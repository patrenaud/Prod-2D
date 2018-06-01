using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnimateText : MonoBehaviour
{
    public float m_LetterDelay = 0.2f;
    public TextMeshProUGUI m_NewText;
    public string[] m_Text = new string[10];
    public string m_Choices;

    private int m_counter = 0;

    private void Start()
    {
        StartCoroutine(TypeText());
    }

    private void Update()
    {

    }

    IEnumerator TypeText()
    {
        foreach (char letter in m_Text[m_counter].ToCharArray())
        {
            m_NewText.text += letter;
            yield return new WaitForSeconds(m_LetterDelay);
        }
		
        foreach (char letter in m_Choices.ToCharArray())
        {
            m_NewText.text += letter;
            yield return new WaitForSeconds(m_LetterDelay);
        }

    }
}
