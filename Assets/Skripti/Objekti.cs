using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject putns;
	public GameObject pils;
	public GameObject hut;
	public GameObject house;
	public GameObject dog;
	public GameObject mushroom;
	public GameObject sailor;
	public GameObject ship;
	public GameObject tower;
	public GameObject dragon;
	public GameObject warriorband;
	public GameObject mill;

	[HideInInspector]
	public Vector2 putnsKoord;
	[HideInInspector]
	public Vector2 pilsKoord;
	[HideInInspector]
	public Vector2 hutKoord;
	[HideInInspector]
	public Vector2 houseKoord;
	[HideInInspector]
	public Vector2 dogKoord;
	[HideInInspector]
	public Vector2 mushroomKoord;
	[HideInInspector]
	public Vector2 sailorKoord;
	[HideInInspector]
	public Vector2 shipKoord;
	[HideInInspector]
	public Vector2 towerKoord;
	[HideInInspector]
	public Vector2 dragonKoord;
	[HideInInspector]
	public Vector2 warriorbandKoord;
	[HideInInspector]
	public Vector2 millKoord;



	public Canvas kanva;

	public AudioSource skanasAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;

	public GameObject pedejaisVilktais = null;


	void Start() {
 
		putnsKoord =
		putns.GetComponent<RectTransform>().localPosition;
		pilsKoord =
		pils.GetComponent<RectTransform>().localPosition;
		hutKoord =
		hut.GetComponent<RectTransform>().localPosition;
		houseKoord =
		house.GetComponent<RectTransform>().localPosition;
		dogKoord =
		dog.GetComponent<RectTransform>().localPosition;
		mushroomKoord =
		mushroom.GetComponent<RectTransform>().localPosition;
		sailorKoord =
		sailor.GetComponent<RectTransform>().localPosition;
		shipKoord =
		ship.GetComponent<RectTransform>().localPosition;
		towerKoord =
		tower.GetComponent<RectTransform>().localPosition;
		dragonKoord =
		dragon.GetComponent<RectTransform>().localPosition;
		warriorbandKoord =
		warriorband.GetComponent<RectTransform>().localPosition;
		millKoord =
		mill.GetComponent<RectTransform>().localPosition;
    }
}
