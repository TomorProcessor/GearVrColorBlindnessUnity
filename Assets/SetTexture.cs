﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class SetTexture : MonoBehaviour
{
	
	public GameObject sphere;
	
	private static String currentImage = "dome";
	private static String currentMode = "protanope";
	
	public Texture dome;
	public Texture domeDeuteranope;
	public Texture domeProtanope;
	public Texture domeTritanope;
	
	public Texture flowers;
	public Texture flowersDeuteranope;
	public Texture flowersProtanope;
	public Texture flowersTritanope;
	
	private static int count = 0;
	private bool isLookAtItem = false;
	
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("STARR");
    }

    // Update is called once per frame
    void Update()
    {
        if (isLookAtItem) count++;
		if (count == 150) {
			if (currentImage == "dome") {
				if (currentMode == "") setDome();
				if (currentMode == "protanope") setDomeProtanope();
				if (currentMode == "deuteranope") setDomeDeuteranope();
				if (currentMode == "tritanope") setDomeTritanope();
			} else if (currentImage == "flowers") {
				if (currentMode == "") setFlowers();
				if (currentMode == "protanope") setFlowersProtanope();
				if (currentMode == "deuteranope") setFlowersDeuteranope();
				if (currentMode == "tritanope") setFlowersTritanope();
			}
		}
    }
	
	public void domeEnter() {
		Debug.Log("ENTER");
		isLookAtItem = true;
		currentImage = "dome";
		currentMode = "";
	}
	
	public void protanopeEnter() {
		Debug.Log("ENTER");
		isLookAtItem = true;
		currentMode = "protanope";
	}
	
	public void deuteranopeEnter() {
		Debug.Log("ENTER");
		isLookAtItem = true;
		currentMode = "deuteranope";
	}
	
	public void tritanopeEnter() {
		Debug.Log("ENTER");
		isLookAtItem = true;
		currentMode = "tritanope";
	}
	
	public void flowersEnter() {
		Debug.Log("ENTER");
		isLookAtItem = true;
		currentImage = "flowers";
		currentMode = "";
	}
	
	public void leave() {
		Debug.Log("LEAVE");
		isLookAtItem = false;
		count = 0;
	}
	
	void setDome() {
		sphere.GetComponent<Renderer>().material.mainTexture = dome;
		currentImage = "dome";
	}
	
	void setDomeDeuteranope() {
		sphere.GetComponent<Renderer>().material.mainTexture = domeDeuteranope;
	}
	
	void setDomeProtanope() {
		sphere.GetComponent<Renderer>().material.mainTexture = domeProtanope;
	}
	
	void setDomeTritanope() {
		sphere.GetComponent<Renderer>().material.mainTexture = domeTritanope;
	}
	
	void setFlowers() {
		sphere.GetComponent<Renderer>().material.mainTexture = flowers;
		currentImage = "flowers";
	}
	
	void setFlowersDeuteranope() {
		sphere.GetComponent<Renderer>().material.mainTexture = flowersDeuteranope;
	}
	
	void setFlowersProtanope() {
		sphere.GetComponent<Renderer>().material.mainTexture = flowersProtanope;
	}
	
	void setFlowersTritanope() {
		sphere.GetComponent<Renderer>().material.mainTexture = flowersTritanope;
	}
}
