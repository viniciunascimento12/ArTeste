﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class voltar : MonoBehaviour
{
	void Update()
	{
		
		if (Application.platform == RuntimePlatform.Android)
		{

			if (Input.GetKeyDown(KeyCode.Escape))
			{
				SceneManager.LoadScene("inicio");
			}
		}
	}
}
