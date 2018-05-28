using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class InfiniteParallaxe : MonoBehaviour 
{
	public List<GameObject> m_Backgrounds = new List<GameObject>();
	public float m_Speed = 5f;

	private float m_ScreenWidth;
	private Vector3 m_MovePos = new Vector3();

	private void Start () 
	{
		m_ScreenWidth = -Screen.width/100f;
	}	

	private void Update () 
	{
		for(int i = 0; i < m_Backgrounds.Count; i++)
		{
			// On déplace nos Backgrounds
			m_Backgrounds[i].transform.Translate(-m_Speed*Time.deltaTime, 0f, 0f);
			// On vérifie si nos backgrounds ont dépassé la limite de l'écran
			if(m_Backgrounds[i].transform.position.x < m_ScreenWidth)
			{
				// On assigne une nouvelle position en x au background ayant dépassé la limite
				m_MovePos.x = -m_ScreenWidth * (m_Backgrounds.Count-1);					
				m_Backgrounds[i].transform.position = m_MovePos;				
			}
		}
	}
}
