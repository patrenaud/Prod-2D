using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class InfiniteParallaxe : MonoBehaviour
{
    public List<GameObject> m_Backgrounds = new List<GameObject>();
    public List<GameObject> m_Foregrounds = new List<GameObject>();
    public List<GameObject> m_Floor = new List<GameObject>();

    public float m_Speed_Background = 2f;
    public float m_Speed_Foreground = 5f;
    public float m_Speed_Floor = 10f;
    public float m_StopSpeed_Background = 0f;
    public float m_StopSpeed_Foreground = 0f;
    public float m_StopSpeed_Floor = 0f;

    private float m_ScreenWidth;
    private Vector3 m_MovePos = new Vector3();
    private GameObject m_PreviousBackground;
    private GameObject m_PreviousForeground;
    private GameObject m_PreviousFloor;

    private void Start()
    {
        m_ScreenWidth = -Screen.width / 100f;
        m_PreviousBackground = m_Backgrounds[m_Backgrounds.Count - 1];
        m_PreviousForeground = m_Foregrounds[m_Foregrounds.Count - 1];
        m_PreviousFloor = m_Floor[m_Floor.Count - 1];
    }

    private void Update()
    {

        for (int i = 0; i < m_Backgrounds.Count; i++)
        {
            // On déplace nos Backgrounds
            m_Backgrounds[i].transform.Translate(-m_Speed_Background * Time.deltaTime, 0f, 0f);
            // On vérifie si nos backgrounds ont dépassé la limite de l'écran
            if (m_Backgrounds[i].transform.position.x < m_ScreenWidth)
            {
                // On assigne une nouvelle position en x au background ayant dépassé la limite
                m_MovePos.x = m_PreviousBackground.transform.position.x - m_ScreenWidth;
                m_Backgrounds[i].transform.position = m_MovePos;
                m_Backgrounds[i].transform.Translate(-m_Speed_Background * Time.deltaTime, 0f, 0f);
            }
            m_PreviousBackground = m_Backgrounds[i];
        }

        for (int i = 0; i < m_Foregrounds.Count; i++)
        {
            // On déplace nos Backgrounds
            m_Foregrounds[i].transform.Translate(-m_Speed_Foreground * Time.deltaTime, 0f, 0f);
            // On vérifie si nos backgrounds ont dépassé la limite de l'écran
            if (m_Foregrounds[i].transform.position.x < m_ScreenWidth)
            {
                // On assigne une nouvelle position en x au background ayant dépassé la limite
                m_MovePos.x = m_PreviousForeground.transform.position.x - m_ScreenWidth;
                m_Foregrounds[i].transform.position = m_MovePos;
                m_Foregrounds[i].transform.Translate(-m_Speed_Foreground * Time.deltaTime, 0f, 0f);
            }
            m_PreviousForeground = m_Foregrounds[i];
        }

        for (int i = 0; i < m_Floor.Count; i++)
        {
            // On déplace nos Backgrounds
            m_Floor[i].transform.Translate(-m_Speed_Floor * Time.deltaTime, 0f, 0f);
            // On vérifie si nos backgrounds ont dépassé la limite de l'écran
            if (m_Floor[i].transform.position.x < m_ScreenWidth)
            {
                // On assigne une nouvelle position en x au background ayant dépassé la limite
                m_MovePos.x = m_PreviousFloor.transform.position.x - m_ScreenWidth;
                m_Floor[i].transform.position = m_MovePos;
                m_Floor[i].transform.Translate(-m_Speed_Floor * Time.deltaTime, 0f, 0f);
            }
            m_PreviousFloor = m_Floor[i];
        }
    }

    public void StopSpeed()
    {
        m_Speed_Background = 0f;
        m_Speed_Foreground = 0f;
        m_Speed_Floor = 0f;
    }

    public void SetSpeed()
    {
        m_Speed_Background = 2f;
        m_Speed_Foreground = 5f;
        m_Speed_Floor = 10f;
    }
}
