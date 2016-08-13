using UnityEngine;
using System.Collections;

public class GrupoManager : MonoBehaviour {

	public float velocidad ;
	public int cantidad = 6;
	public GameObject grupoSiguiente;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//Debug.Log (cantidad + "es la cantidadde enemigos de este grupo");
		transform.Translate(Vector3.down * velocidad * Time.deltaTime);

		if (cantidad <= 0) {
			//activar siguiente grupo
			grupoSiguiente.SetActive(true);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.name == "limiteInferior") {

			Debug.Log ("si choco con el fondo de abajo"); /* aca tiene que preguntar si la cantidad es 0
				si es 0, tiene que activarse el grupo que sigue, y si no lo es
				tiene que volver a subir los enemigos que sobraron.
				*/
			}

	}
}
