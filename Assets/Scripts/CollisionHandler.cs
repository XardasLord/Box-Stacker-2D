using UnityEngine;
using System.Collections;

public class CollisionHandler : MonoBehaviour {

	void OnCollisionEnter2D()
    {
        Vector3 camPos = Camera.main.transform.position;

        if (camPos.y < transform.position.y)
        {
            Camera.main.GetComponent<CameraMover>().targetY = transform.position.y;
        }
    }
}
