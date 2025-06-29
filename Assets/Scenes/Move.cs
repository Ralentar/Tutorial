using UnityEngine;

public class Move : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}