using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrCameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5f;

    private Vector3 offset;
    public float maxLimit = 6.86f;
    public float minLimit = -6.77f;

    public float minLimitY = -14.31f;

    public float maxLimitY = 0.05f;

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

            // Aplica os limites de clamping
            targetCamPos.x = Mathf.Clamp(targetCamPos.x, minLimit, maxLimit);
            targetCamPos.y = Mathf.Clamp(targetCamPos.y, minLimitY, maxLimitY);

            // Move a câmera suavemente para a nova posição
            transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
        }
    }
}
