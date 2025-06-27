using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoCamera : MonoBehaviour
{
    
    public Transform player;
    public Vector3 offset;
    public float minX, maxX;
    public float minY, maxY;
    public float smoothSpeed = 5f; // Quanto maior, mais rápida a suavização

    void LateUpdate()
    {
        // Posição alvo desejada
        Vector3 desiredPosition = player.position + offset;

        // Suavizar o movimento
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // Aplicar os limites
        float clampedX = Mathf.Clamp(smoothedPosition.x, minX, maxX);
        float clampedY = Mathf.Clamp(smoothedPosition.y, minY, maxY);

        // Atualiza a posição da câmera
        transform.position = new Vector3(clampedX, clampedY, desiredPosition.z);
    }
}

