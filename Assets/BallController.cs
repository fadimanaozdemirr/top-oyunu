using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

	public float hiz = 10f; // Topun hareket h�z�
	public float yatayHareket;
	public float dikeyHareket;
	public float timer;
	
	GameObject[] diz;
	private void Start()
	{
		diz = GameObject.FindGameObjectsWithTag("Kup");
		bittiText = GameObject.FindGameObjectWithTag("bitti").GetComponent<TextMeshProUGUI>();
		bittiText.gameObject.SetActive(false);
		//hiz = 9;
		this.GetComponent<Rigidbody>();
		sayacText = GameObject.FindGameObjectWithTag("text").GetComponent<TextMeshProUGUI>();
		Debug.Log("start girdi");
		sayacText.text = "sayac: 0";
	}
	void FixedUpdate()
	{
		yatayHareket = Input.GetAxis("Horizontal"); // Yatay giri� al�n�r (A, D veya sol ok, sa� ok tu�lar�)
		dikeyHareket = Input.GetAxis("Vertical"); // Dikey giri� al�n�r (W, S veya yukar� ok, a�a�� ok tu�lar�)

		Vector3 hareket = new Vector3(yatayHareket, 0f, dikeyHareket); // Hareket vekt�r� olu�turulur
																	   //hareket = hareket.normalized * hiz * Time.deltaTime; // H�z ve zaman tabanl� d�zenlemeler yap�l�r

		transform.Translate(hareket * hiz * Time.deltaTime); // Top hareket ettirilir
	}




	// K�p nesnesini atanacak bo� bir oyuncu nesnesi olu�turduk
	public int sayac;
	private TMPro.TextMeshProUGUI sayacText, bittiText;

	void OnCollisionEnter(Collision collision)
	{
		// Top bir k�p ile �arp��t���nda bu fonksiyon �al���r
		if (collision.gameObject.CompareTag("Kup")) // K�plerin etiketini "Kup" olarak varsay�yoruz
		{
			// �arp��an k�p nesnesini yok et
			Destroy(collision.gameObject);
			sayac++;
			sayacText.text ="sayac: "+ sayac.ToString();

			

			if(diz.Length == sayac)
			{
				
				bittiText.gameObject.SetActive(true);

			}
			

		}
	}










}
