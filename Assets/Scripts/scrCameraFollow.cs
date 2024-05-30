using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrCameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5f;

    private Vector3 offset;

    void Start()
    {
        // Calcula a distância inicial entre a câmera e o Player
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        if (target != null)
        {
            // Calcula a nova posição da câmera
            Vector3 targetCamPos = target.position + offset;
            
            // Move a câmera suavemente para a nova posição
            transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
        }
    }
}
