using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    public float donmeHizi = 50f; // Küpün dönme hýzý
    public Vector3 vec;
    void Update()
    {
        // Küpü kendi etrafýnda döndürmek için dönme ekseni belirliyoruz (örneðin, y ekseni)
        //transform.Rotate(Vector3.up, donmeHizi * Time.deltaTime);
        //transform.Rotate(Vector3.forward, donmeHizi * Time.deltaTime); // saat yönü tersi döner
        transform.Rotate(vec, donmeHizi * Time.deltaTime);

    }
}
