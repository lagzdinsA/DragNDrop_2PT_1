using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, 
	IDropHandler{
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmStarpiba, yIzmStarpiba;
	public Objekti objektuSkripts;

    public void OnDrop(PointerEventData eventData)
    {
		if (eventData.pointerDrag != null)
		{
			if (eventData.pointerDrag.tag.Equals(tag))
			{
				vietasZRot =
				eventData.pointerDrag.
				GetComponent<RectTransform>().transform.eulerAngles.z;

				velkObjZRot =
				GetComponent<RectTransform>().transform.eulerAngles.z;

				rotacijasStarpiba =
				Mathf.Abs(vietasZRot - velkObjZRot);

				vietasIzm =
				eventData.pointerDrag.
				GetComponent<RectTransform>().localScale;

				velkObjIzm =
					GetComponent<RectTransform>().localScale;

				xIzmStarpiba = Mathf.Abs(vietasIzm.x - velkObjIzm.x);
				yIzmStarpiba = Mathf.Abs(vietasIzm.y - velkObjIzm.y);

				Debug.Log("Objektu rotācijas starpība: " + rotacijasStarpiba
					+ "\nPlatuma starpība: " + xIzmStarpiba +
					"\nAugstuma starpība: " + yIzmStarpiba);


				if ((rotacijasStarpiba <= 6 ||
					(rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
					&& (xIzmStarpiba <= 0.1 && yIzmStarpiba <= 0.1))
				{
					Debug.Log("Nomests pareizajā vietā!");
                    objektuSkripts.vaiIstajaVieta = true;
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition
						= GetComponent<RectTransform>().anchoredPosition;

					eventData.pointerDrag.GetComponent<RectTransform>().localRotation =
						GetComponent<RectTransform>().localRotation;

					eventData.pointerDrag.GetComponent<RectTransform>().localScale =
						GetComponent<RectTransform>().localScale;

					switch (eventData.pointerDrag.tag) {
							case "puts":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[1]);
							break;
							case "pils":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[2]);
							break;
							case "hut":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[3]);
							break;
							case "house":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[4]);
							break;
							case "dog":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[5]);
							break;
							case "mushroom":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[6]);
							break;
							case "sailor":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[7]);
							break;
							case "ship":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[8]);
							break;
							case "tower":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[9]);
							break;
							case "dragon":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[10]);
							break;
							case "warrior band":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[11]);
							break;
							case "mill":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[12]);
							break;

						default:
							Debug.Log("Tags nav definēts!");
							break;
					}
				}

				//Ja tagi nesakrīt, tātad nepareizajā vietā
			} else	{
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot(
					objektuSkripts.skanasKoAtskanot[0]);

                switch (eventData.pointerDrag.tag){
						case "putns":
                        objektuSkripts.putns.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.putnsKoord;
                        break;
						case "pils":
                        objektuSkripts.pils.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.pilsKoord;
                        break;
						case "hut":
                        objektuSkripts.hut.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.hutKoord;
                        break;
						case "house":
                        objektuSkripts.house.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.houseKoord;
                        break;
						case "dog":
                        objektuSkripts.dog.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.dogKoord;
                        break;
						case "mushroom":
                        objektuSkripts.mushroom.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.mushroomKoord;
                        break;
						case "sailor":
                        objektuSkripts.sailor.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.sailorKoord;
                        break;
						case "ship":
                        objektuSkripts.ship.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.shipKoord;
                        break;
						case "tower":
                        objektuSkripts.tower.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.towerKoord;
                        break;
						case "dragon":
                        objektuSkripts.dragon.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.shipKoord;
                        break;
						case "warrior band":
                        objektuSkripts.warriorband.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.warriorbandKoord;
                        break;
                    default:
                        Debug.Log("Tags nav definēts!");
                        break;
                }
            }
		}
		
	}
}
