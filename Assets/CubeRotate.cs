using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    public float donmeHizi = 50f; // K�p�n d�nme h�z�
    public Vector3 vec;
    void Update()
    {
        // K�p� kendi etraf�nda d�nd�rmek i�in d�nme ekseni belirliyoruz (�rne�in, y ekseni)
        //transform.Rotate(Vector3.up, donmeHizi * Time.deltaTime);
        //transform.Rotate(Vector3.forward, donmeHizi * Time.deltaTime); // saat y�n� tersi d�ner
        transform.Rotate(vec, donmeHizi * Time.deltaTime);

    }
}
