using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
{

    public Vector3 rotacaoCubo;

    // Update is called once per frame
    void Update()
    {
		transform.Rotate(rotacaoCubo * Time.deltaTime);
    }
}
