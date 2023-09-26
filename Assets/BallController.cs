using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

	public float hiz = 10f; // Topun hareket hýzý
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
		yatayHareket = Input.GetAxis("Horizontal"); // Yatay giriþ alýnýr (A, D veya sol ok, sað ok tuþlarý)
		dikeyHareket = Input.GetAxis("Vertical"); // Dikey giriþ alýnýr (W, S veya yukarý ok, aþaðý ok tuþlarý)

		Vector3 hareket = new Vector3(yatayHareket, 0f, dikeyHareket); // Hareket vektörü oluþturulur
																	   //hareket = hareket.normalized * hiz * Time.deltaTime; // Hýz ve zaman tabanlý düzenlemeler yapýlýr

		transform.Translate(hareket * hiz * Time.deltaTime); // Top hareket ettirilir
	}




	// Küp nesnesini atanacak boþ bir oyuncu nesnesi oluþturduk
	public int sayac;
	private TMPro.TextMeshProUGUI sayacText, bittiText;

	void OnCollisionEnter(Collision collision)
	{
		// Top bir küp ile çarpýþtýðýnda bu fonksiyon çalýþýr
		if (collision.gameObject.CompareTag("Kup")) // Küplerin etiketini "Kup" olarak varsayýyoruz
		{
			// Çarpýþan küp nesnesini yok et
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
