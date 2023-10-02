using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
	private int cherries = 0;

	[SerializeField] private Text Kers;

	[SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
   {
		if (collision.gameObject.CompareTag("Cherry"))
		{
			collectionSoundEffect.Play();
            Destroy(collision.gameObject);
			cherries++;
			Kers.text = "Cherries: " + cherries;
		}
   }
}
