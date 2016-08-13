using UnityEngine;
using System.Collections;

public class ControllerPowerUp : MonoBehaviour {

	public GameObject powerUp;

	private float tiempo = 40.0f;
	private float resetTiempo;

	private int posX;
	// Use this for initialization
	void Awake ()
	{
		resetTiempo = tiempo;
	}
	void Start () {
	
		posX = (int)Random.Range (-7.60f, 7.60f);
	}
	
	// Update is called once per frame
	void Update () {
	
	
		tiempo = tiempo - Time.deltaTime;

		if (tiempo <= 0) {
			
			Instantiate(powerUp, new Vector3(posX, -3.51f, 0), Quaternion.identity);
			posX = (int)Random.Range (-7.60f, 7.60f);

			tiempo = resetTiempo;
		}

	}
}
