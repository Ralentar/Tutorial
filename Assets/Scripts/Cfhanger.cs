using UnityEngine;

public class Changer : MonoBehaviour
{
    [SerializeField] private float _increaseRate = 0.1f;

    private void Update()
    {
        transform.localScale += Vector3.one * _increaseRate * Time.deltaTime;      
    }
}