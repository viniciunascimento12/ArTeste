﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cenas : MonoBehaviour
{

   public void Cubo()
	{
		SceneManager.LoadScene("Cubos_");
	}

	public void Sair()
	{
		Application.Quit();
	}
}
