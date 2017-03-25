using UnityEngine;
using System.Collections;

public class DustEffect : MonoBehaviour {

	void OnDestroy(){
		Destroy (gameObject);
	}
}
