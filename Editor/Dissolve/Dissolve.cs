using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Dissolve : MonoBehaviour
{
	Material material;

	bool isDissolving = false;
	float fade = 1f;

	void Start()
	{
		// Get a reference to the material
		material = GetComponent<Image>().material;
	}

	void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
		{
			isDissolving = true;
		}

		if (isDissolving)
		{
			fade -= Time.deltaTime;

			if (fade <= 0f)
			{
				fade = 0f;
				isDissolving = false;
			}

			// Set the property
			material.SetFloat("_Fade", fade);
			// gameObject.SetActive(false);
		}
    }
}